/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 16/11/2019
 * Time: 11:10 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace AlgoritmiaAct4
{
	/// <summary>
	/// Description of Profundidad.
	/// </summary>
	public class Profundidad
	{
		List<Vertice> visitados;
		Stack<Vertice> pila;
		List<Arista> camino;
		List<Arista> validos;
		public Profundidad(Vertice origen, List<Arista> vlds)
		{
			camino = new List<Arista>();
			visitados = new List<Vertice>();
			pila = new Stack<Vertice>();
			pila.Push(origen);
			validos = new List<Arista>(vlds);
		}
		public List<Arista> ejecutarDFS()
		{
			bool flag = true;
			Vertice aux;
			aux = pila.Peek();
			while(pila.Count != 0)
			{
				for(int i = 0;i<aux.getLista().Count;i++)
				{
					if(validos.Exists(x => x.getID() == aux.getLista()[i].getID()))
					{
						if(!visitados.Exists(x => x.getID() == aux.getLista()[i].getDestino().getID()))
						{	
							pila.Push(aux);
							visitados.Add(aux);
							camino.Add(aux.getLista()[i]);
							aux = aux.getLista()[i].getDestino();
							flag = false;
							break;
						}
					}
				}
				
				if(flag)
				{
					visitados.Add(aux);
					Vertice aux2 = pila.Pop();
					
					if(aux.getID() != aux2.getID())
					camino.Add(encontrarArista(aux, aux2));
					
					aux = aux2;
				}else
					flag = true;
			}
			return camino;
		}
		private Arista encontrarArista(Vertice v_1, Vertice v_2)
		{
			for(int i = 0; i<v_1.getLista().Count;i++)
			{
				if(v_1.getLista()[i].getDestino().getID() == v_2.getID())
					return v_1.getLista()[i];
			}
			return null;
		}
	}
}
