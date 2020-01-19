/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 12/11/2019
 * Time: 08:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmiaAct4
{
	/// <summary>
	/// Description of Prim.
	/// </summary>
	public class Prim
	{
		List<Arista> candidatos;
		List<Arista> prometedor;
		List<Vertice> compConexos;
		Grafo grafo;
		List<Arista> camino;
		int numGrafos;
		public Prim(Grafo gra, Vertice origen)
		{
			candidatos = new List<Arista>(origen.getLista());
			prometedor = new List<Arista>();
			compConexos = new List<Vertice>();
			compConexos.Add(origen);
			grafo = gra;
			camino = new List<Arista>();
			numGrafos = 1;
		}
		public List<Arista> ejecutarPrim()
		{
			Arista aux;
			while(!solucion())
			{
				aux = seleccion();
				
				if(aux == null)
				{
				 	forzarEntrada();
				 	aux = seleccion();
				}
				
				if(factible(aux))
				{
					prometedor.Add(aux);
					camino.Add(aux);
					camino.Add(encontrarVertice(aux.getOrigen(), aux.getDestino()));
					//compConexos.Add(aux.getDestino());
					if(pertenece(aux.getOrigen()))
					{
						compConexos.Add(aux.getDestino());
						for(int i = 0; i<aux.getDestino().getLista().Count;i++)
							candidatos.Add(aux.getDestino().getLista()[i]);
					}else
					{
						compConexos.Add(aux.getOrigen());
						for(int i = 0; i<aux.getOrigen().getLista().Count;i++)
							candidatos.Add(aux.getOrigen().getLista()[i]);
					}
					
				}
			}
			return prometedor;
		}
		public List<Arista> getPrometedor()
		{
			return prometedor;
		}
		private void forzarEntrada()
		{
			numGrafos++;
			for(int i = 0; i<grafo.getVertices().Count;i++)
			{
				if(!compConexos.Exists(id => id.getID() == grafo.getVertices()[i].getID()))
				{
					for(int j = 0; j <grafo.getVertices()[i].getLista().Count;j++)
						candidatos.Add(grafo.getVertices()[i].getLista()[j]);
					
					return;
				}
			}
			
		}
		private bool pertenece(Vertice vrt)
		{
			for(int i = 0; i<compConexos.Count;i++)
			{
				if(vrt.getID() == compConexos[i].getID())
					return true;
			}
			return false;
		}
		private bool solucion()
		{
			if(prometedor.Count == grafo.getVertices().Count-1)
			{	
				return true;
			}
				return false;
		}
		private Arista seleccion()
		{
			Arista aux = null;
			int menor = 5000;
			for(int i = 0; i<candidatos.Count;i++)
			{
				if(candidatos[i].getPonderacion() < menor)
				{
					aux = candidatos[i];
					menor = candidatos[i].getPonderacion();
				}
			}
			candidatos.Remove(aux);
			//candidatos.Remove(encontrarVertice(aux.getOrigen(), aux.getDestino()));
			return aux;
		}
		Arista encontrarVertice(Vertice v_1, Vertice v_2)
		{
			for(int i = 0; i < v_2.getLista().Count; i++)
			{
				if(v_1.getID() == v_2.getLista()[i].getDestino().getID())
				{
					return v_2.getLista()[i];
				}
			}
			MessageBox.Show("Regresando null");
			return null;
		}
		private bool factible(Arista a)
		{
			for(int i = 0; i<compConexos.Count;i++)
			{
				if(a.getDestino().getID() == compConexos[i].getID())
					return false;
			}
			return true;			
		}
		public List<Arista> getCamino()
		{
			return camino;
		}
		public int getNumGrafos()
		{
			return numGrafos;
		}
		
	}
}
