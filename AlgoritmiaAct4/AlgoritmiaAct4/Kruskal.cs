/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 10/11/2019
 * Time: 01:50 p. m.
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
	/// Description of Kruskal.
	/// </summary>
	public class Kruskal
	{
		List<Arista> candidatos;
		List<Arista> prometedor;
		List<String> compConexos;
		List<Arista> camino;
		Grafo grafo;
		public Kruskal(Grafo grafo)
		{
			candidatos = new List<Arista>();
			for(int i = 0;i<grafo.getVertices().Count;i++)
			{
				for(int j = 0; j<grafo.getVertices()[i].getLista().Count;j++)
					candidatos.Add(grafo.getVertices()[i].getLista()[j]);
			}
			compConexos = new List<String>();
			for(int i = 0; i<grafo.getVertices().Count;i++)
			{
				compConexos.Add(grafo.getVertices()[i].getID().ToString()+"|");
			}
			prometedor = new List<Arista>();
			this.grafo = new Grafo();
			this.grafo = grafo;
			camino = new List<Arista>();
			
		}
		public List<Arista> ejecutarKruskal()
		{
			Arista aux;
			String cmp1 = "";
			String cmp2 = "";
			while(!solucion())
			{
				aux = seleccion();
				if(aux == null)
					return prometedor;
				
				cmp1 = obtenerCC(aux.getOrigen().getID());
				cmp2 = obtenerCC(aux.getDestino().getID());
				if(!validarConexo(cmp1,cmp2))
				{
   					prometedor.Add(aux);
   					camino.Add(aux);
   					camino.Add(encontrarVertice(aux.getOrigen(), aux.getDestino()));
   					concatenarConexos(cmp1, cmp2);
				}

			}
			return prometedor;
		}
		public List<Arista> getPrometedor()
		{
			return prometedor;
		}
		private String obtenerCC(int ide)
		{
			int j = 0;
			String cadena = "";
			for(int i = 0; i<compConexos.Count;i++)
			{
				j = 0;
				cadena = "";
				while(j<compConexos[i].Length)
				{
					if(compConexos[i][j].ToString() == "|")
					{
						if(cadena == ide.ToString())
						{
							return compConexos[i];
						}
						cadena = "";
					}else
					{
						cadena+=compConexos[i][j];
					}
					j++;
				}
			}
			return "-1";
		}
		public bool solucion()
		{
			if(prometedor.Count == grafo.getVertices().Count-1)
				return true;
			
			return false;
		}
		public Arista seleccion()
		{
			Arista aux = null;
			int menor = 1000;
			
			for(int i = 0; i<candidatos.Count;i++)
			{
				if(candidatos[i].getPonderacion() < menor)
				{
					aux = candidatos[i];
					menor = candidatos[i].getPonderacion();
				}
			}
			candidatos.Remove(aux);
			if(aux == null)
				return aux;
			
			candidatos.Remove(encontrarVertice(aux.getOrigen(), aux.getDestino()));
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
		private bool validarConexo(String comp1, String comp2)
		{
			if(comp1 == comp2)
				return true;
			return false;
		}
		private void concatenarConexos(String c1, String c2)
		{
			String comp_nuevo1 = c1+c2;
			String comp_nuevo2 = c2+c1;
			
			String aux1 = getIdComponente(c1);
			String aux2 = getIdComponente(c2);
			String aux3 = "";
						
			for(int i = 0; i<compConexos.Count;i++)
			{	
				aux3 = getIdComponente(compConexos[i]);
				if(aux1 == aux3)
				{
					compConexos[i] = comp_nuevo1;
					compConexos.Remove(c2);
					//MessageBox.Show("eliminando "+ aux2);
					break;
				}else if(aux2 == aux3)
				{
					compConexos[i] = comp_nuevo2;
					compConexos.Remove(c1);
					//MessageBox.Show("eliminando "+aux1);
					break;
				}
				
			}
		}
		public List<String> getCC()
		{
			return this.compConexos;
		} 
		public List<Arista> getCamino()
		{
			return camino;
		}
		private String getIdComponente(String cadena)
		{
			if(cadena.Length == 0)
				return "error";
			String aux = "";
			int i = 0;
			while(i < cadena.Length)
			{
				if(cadena[i].ToString() == "|")
					break;
				aux = aux + cadena[i].ToString();
				i++;
			}
				
			return aux;
		}
	}
}
