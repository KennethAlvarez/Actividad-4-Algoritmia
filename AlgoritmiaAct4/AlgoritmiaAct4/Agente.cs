/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 10/11/2019
 * Time: 10:07 a. m.
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
	/// Description of Agente.
	/// </summary>
	public class Agente
	{
		Vertice vActual;
		int velocidad;
		int id;
		List<Arista> camino;
		int avanzar;
		int contador;
		bool solucion;
		public Agente(List<Arista> pa, int id)
		{
			solucion = true;
			contador = 0;
			this.id = id;
			this.velocidad = 5;
			avanzar = 10;
			camino = new List<Arista>(pa);
		}
		public bool moverAgente()
		{		
			velocidad += 15;
			if(velocidad >= camino[contador].getListaPixeles().Count)
			{
				contador++;
				if(contador >= camino.Count-1){
					contador--;
					velocidad -= 15;
					return false;
				}
				velocidad = 5;
				id = camino[contador].getOrigen().getID();
			}
			
			return true;
		}
		public void setSolucion(bool l)
		{
			solucion = l;
		}
		public bool getSolucion()
		{
			return solucion;
		}
		public void setVerticeActual(Vertice a)
		{
			vActual = a;
		}
		public Vertice getVertice()
		{
			return vActual;
		}
		
		public int getAvanzar()
		{
			return avanzar;
		}
		public void setAvanzar(int d)
		{
			 avanzar += d;
		}
		public void setCamino(List<Arista> p)
		{
			camino = p;
		}
		public List<Arista> getCamino()
		{
			return camino;
		}
		public int getId()
		{
			return id;
		}
		public int getContador()
		{
			return contador;
		}
		public Point getListaCamino()
		{
			return this.camino[contador].getListaPixeles()[velocidad];
		}
	}
}
