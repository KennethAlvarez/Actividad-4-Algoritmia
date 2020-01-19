﻿/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 10/11/2019
 * Time: 10:05 a. m.
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Grafo grafo = new Grafo();
		Vertice objetivo;
		Bitmap bm;
		Bitmap back;
		List<Agente> aList = new List<Agente>();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			aList.Clear();
			comboBox1.Items.Clear();
			grafo.getVertices().Clear();
			this.treeView1.Nodes.Clear();
			this.openFileDialog1.ShowDialog();
			back = new Bitmap(this.openFileDialog1.FileName);
			this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox1.BackgroundImage = back;
			bm = new Bitmap(back.Width, back.Height);
			this.pictureBox1.Image = bm;
			this.button2.Enabled = true;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Point centro;
			int radio = 0;
			int contador = 1;
			for(int i = 0; i<back.Width;i++)
			{
				for(int j = 0; j<back.Height;j++)
				{
					if(back.GetPixel(i, j) == Color.FromArgb(0, 0, 0))
					{
						centro = obtenerCentro(i, j);
						radio = obtenerRadio(centro);
						dibujarCirculo(i, j, radio);
						if(radio != -1)
						{
							Vertice verticeAux = new Vertice(contador, centro, radio);
							grafo.agregarVertice(verticeAux);
							contador++;
						}
					}
				}
			}
			generarAristas();
			dibujarEtiqueta();
			generarTreeView();
			for(int i = 0; i<grafo.getVertices().Count;i++)
				comboBox1.Items.Add(grafo.getVertices()[i].getID().ToString());
			/*Profundidad krs = new Profundidad(grafo.getVertices()[7], -1);
			krs.ejecutarDFS();*/
			/*for(int i = 0; i<krs.getCC().Count;i++)
				MessageBox.Show("Cmp: "+krs.getCC()[i]);
			*/	                
			pictureBox1.Refresh();
		}
		void generarTreeView()
		{
			treeView1.BeginUpdate();
			for(int i = 0; i<grafo.getVertices().Count;i++)
			{
				treeView1.Nodes.Add("Vertice: "+grafo.getVertices()[i].getID());
				for(int j = 0; j<grafo.getVertices()[i].getLista().Count;j++)
				{
					treeView1.Nodes[i].Nodes.Add("Destino: "+grafo.getVertices()[i].getLista()[j].getDestino().getID());
				}
			}
			treeView1.EndUpdate();
		}
		Point obtenerCentro(int x, int y)
		{
			int aux=0;
			int auxy=0;
			aux = x;
			auxy = y;
			//MessageBox.Show("antes x: "+aux+" y: "+auxy);
			while(back.GetPixel(aux, auxy) == Color.FromArgb(0, 0, 0))
			{
				aux++;
			}
			int xTotal = (aux-x)/2;
			aux = x;
			while(back.GetPixel(aux, auxy) == Color.FromArgb(0, 0, 0))
			{
				auxy++;
			}
			int yTotal = (auxy-y)/2;
			Point centro = new Point((xTotal+x), (yTotal+y));
			//MessageBox.Show("Total: "+(xTotal+x)+" "+(yTotal+y));
			return centro;
			
		}
		int obtenerRadio(Point p)
		{	
			int _x = p.X;
			int _y = p.Y;
			int contx = 0;
			int conty = 0;
			
			while(back.GetPixel(_x, p.Y) != Color.FromArgb(255,255,255))
			{
				_x++;
				contx++;	
			}
			while(back.GetPixel(p.X, _y) != Color.FromArgb(255,255,255))
			{
				_y++;
				conty++;
			}
			int radio = contx - conty;
			if(radio < -10 || radio > 10)
			{
				return -1;
			}
			return contx;
		}
		void dibujarCirculo(int x, int y, int radio)
		{
			int _x = x;
			int _y = y;
			Color col;
			if(radio == -1)
			{			
				//MessageBox.Show("x: "+x+" Y: "+y);
				col = Color.FromArgb(255,255,255);
			}else
			{
				col = Color.Blue;
			}
			while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			{
				while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
				{
					back.SetPixel(_x, _y, col);
					_y--;
				}
				//pictureBox1.Refresh();
				_x++;
				_y = y;
			}
			_x = x-1;
			_y = y;
			while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			{
				while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
				{
					back.SetPixel(_x, _y, col);
					_y--;
				}
				//pictureBox1.Refresh();
				_x--;
				_y = y;
			}
			_x = x;
			_y = y+1;
			while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			{
				while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
				{
					back.SetPixel(_x, _y, col);
					_y++;
				}
				//pictureBox1.Refresh();
				_x++;
				_y = y+1;
			}
			_x = x-1;
			_y = y+1;
			while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			{
				while(back.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
				{
					back.SetPixel(_x, _y, col);
					_y++;
				}
				//pictureBox1.Refresh();
				_x--;
				_y = y;
			}
			pictureBox1.Refresh();

		}
		int obtenerDistancia(Point origenCentro, Point destinoCentro)
		{
			int distancia = (int)Math.Round(Math.Sqrt(Math.Pow((destinoCentro.X - origenCentro.X), 2) + Math.Pow((destinoCentro.Y - origenCentro.Y), 2)));
			return distancia;		
		}
		void generarAristas()
		{
			int ponderacion = 0;
			int j = 0;
			int generarID = 0;
			//Arista aux = new Arista(-1, null, null, 5000);
			List<Point> pList;
			for(int i = 0; i<grafo.getVertices().Count;i++)
			{
				for(j = i+1; j<grafo.getVertices().Count;j++)
				{
					ponderacion = obtenerDistancia(grafo.getVertices()[i].getCentro(), grafo.getVertices()[j].getCentro());
					pList = new List<Point>(detectarObstaculos(grafo.getVertices()[i].getCentro(), grafo.getVertices()[j].getCentro()));
					if(pList.Count != 0)
					{
						Arista arista = new Arista(generarID, grafo.getVertices()[i], grafo.getVertices()[j], ponderacion, pList);
						grafo.getVertices()[i].agregarArista(arista);
						generarID++;
						pList.Reverse();
						Arista _arista = new Arista(generarID, grafo.getVertices()[j], grafo.getVertices()[i], ponderacion, pList);
						grafo.getVertices()[j].agregarArista(_arista);
						generarID++;
					//	MessageBox.Show("Primero elemento X: "+arista.getListaPixeles()[0].X+" Y:"+arista.getListaPixeles()[0].Y);
						
						//MessageBox.Show("Primero elemento X: "+_arista.getListaPixeles()[0].X+" Y:"+_arista.getListaPixeles()[0].Y);
						pictureBox1.Refresh();
					}

				}
			}
			pictureBox1.Refresh();
			pintarAristas();
		}
		void pintarAristas()
		{
			Pen lapiz = new Pen(Color.Red, 3);
			Graphics gr = Graphics.FromImage(back);
			for(int i = 0; i<grafo.getVertices().Count;i++)
			{
				for(int j = 0; j<grafo.getVertices()[i].getLista().Count;j++)
				{
					if(grafo.getVertices()[i].getID() < grafo.getVertices()[i].getLista()[j].getDestino().getID());
					gr.DrawLine(lapiz, grafo.getVertices()[i].getCentro(),grafo.getVertices()[i].getLista()[j].getDestino().getCentro());
					
				}
				pictureBox1.Refresh();
			}
			
		}
		
		void pintarAristas(List<Arista> lAristas)
		{

			Pen lapiz = new Pen(Color.Green, 10);
			Graphics gr = Graphics.FromImage(bm);
			for(int i = 0; i<lAristas.Count;i++)
			{
				gr.DrawLine(lapiz, lAristas[i].getOrigen().getCentro(), lAristas[i].getDestino().getCentro());
				pictureBox1.Refresh();
			}
			
		}
		List<Point> detectarObstaculos(Point origenCentro, Point DestinoCentro)
		{
			int x = origenCentro.X;
			int y = origenCentro.Y;
			int x1 = DestinoCentro.X;
			int y1 = DestinoCentro.Y;
			List<Point> camino = new List<Point>();
			float Dx = x1 -x;
			float Dy = y1-y;
			float m, b;
			int band = 0;
			if(Math.Abs(Dx) < Math.Abs(Dy))
			{
				if(Dy != 0)
				{
					m = Dx / Dy;
					b = x - m*y;
					if(Dy < 0)
					{
						Dy = -1;
					}
					else
					{
						Dy = 1;
					}
				while(y != y1)
				{					
					y += (int)Dy;
					x = (int)Math.Round(m*y + b);
					switch(band)
					{
						case 0:
							if(Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
								band = 1;
							break;
						case 1:
							if(!Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
							{
								band = 2;
							}
							break;
						case 2:
							if(Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
							{
								camino.Clear();
								//MessageBox.Show("Origen X:"+origenCentro.X+" Y: "+origenCentro.Y+" Destino X: "+DestinoCentro.X+" Y: "+DestinoCentro.Y);
								return camino;
							}
							break;
						}
					Point p = new Point(x, y);
					camino.Add(p);
						
					}
				}
			}else
			{
				m = Dy / Dx;
				b = y - m*x;
				if(Dx < 0)
				{
					MessageBox.Show("aagria");
					                
					Dx = -1;
				}
				else
				{
					Dx = 1;
				}
				while(x != x1)
				{
					x += (int)Dx;
					y = (int)Math.Round(m*x + b);
					switch(band)
					{
						case 0:
							if(Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
								band = 1;
							break;
						case 1:
							if(!Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
							{
								band = 2;
							}
							break;
						case 2:
							if(Color.Equals(Color.FromArgb(255,255,255), back.GetPixel(x, y)))
							{
								camino.Clear();
								return camino;
							} break;
					}
					
					Point p = new Point(x, y);
					camino.Add(p);
				}
			}
			return camino;
	}
		void dibujarEspectro(Point centro, bool band)
		{
			Graphics gr = Graphics.FromImage(bm);
			if(!band)
			gr.FillEllipse(Brushes.Purple, centro.X-25, centro.Y-25, 50, 50);
			else
			gr.FillEllipse(Brushes.Black, centro.X-12, centro.Y-12, 25, 25);
			//pictureBox1.Refresh();
			
		}
		void dibujarEtiqueta()
		{
			Graphics grap = Graphics.FromImage(back);

			for(int i = 0; i<grafo.getVertices().Count;i++)
			{	
				Font a = new Font("Arial", grafo.getVertices()[i].getRadio());
				SolidBrush brocha = new SolidBrush(Color.Black);
				StringFormat cad = new StringFormat();
				cad.FormatFlags = StringFormatFlags.DirectionVertical;
				string cadena = ""+(i+1);
				grap.DrawString(cadena, a, brocha, grafo.getVertices()[i].getCentro().X, grafo.getVertices()[i].getCentro().Y);
			}
			pictureBox1.Refresh();
		}
		/*void TreeView1MouseDown(object sender, MouseEventArgs e)
		{
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.ContextMenuStrip.Show();
		}*/
		void AgenteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(aList.Count > 1){
				MessageBox.Show("No puedes agregar más agentes");
				return;
			}
			
			int node_select = this.treeView1.SelectedNode.Index;
			Profundidad krs;
			List<Arista> auxiliar;
			if(radioButton1.Checked)
			{
				Kruskal kruskal = new Kruskal(grafo);
				kruskal.ejecutarKruskal();
				krs = new Profundidad(grafo.getVertices()[node_select], kruskal.getCamino());
				auxiliar = kruskal.getPrometedor();
				
			}else if(radioButton2.Checked)
			{
				if(comboBox1.SelectedIndex == -1){
					MessageBox.Show("Elija un vértice origen para Prim");
					return;
				}
				Prim prim = new Prim(grafo, grafo.getVertices()[comboBox1.SelectedIndex]);
				prim.ejecutarPrim();
				krs = new Profundidad(grafo.getVertices()[node_select], prim.getCamino());
				auxiliar = prim.getPrometedor();
			}else
			{
				MessageBox.Show("Seleccione un algoritmo");
				return;
			}
		
			dibujarEspectro(grafo.getVertices()[node_select].getCentro(), true);
			Agente a = new Agente(krs.ejecutarDFS(), node_select+1);
			aList.Add(a);
			pictureBox1.Refresh();
		}

		void Button3Click(object sender, EventArgs e)
		{
			animar();
		}
		bool revisarSoluciones()
		{
			for(int i = 0; i<aList.Count;i++)
			{
				if(aList[i].getSolucion())
					return true;
			}
			return false;
		}
		bool actualizarAgentes()
		{
			for(int i = 0; i<aList.Count;i++)
			{	
				if(!revisarSoluciones())
				{
					MessageBox.Show("Ningún agente logró llegar");
					return false;
				}
				
				if(!aList[i].moverAgente())
					aList[i].setSolucion(false);
					
				dibujarEspectro(aList[i].getListaCamino(), true);
				
				if(aList[i].getId() == objetivo.getID())
					return false;	
					
			}
			return true;
		}
		void animar()
		{
			Graphics gr = Graphics.FromImage(bm);
			
			while(actualizarAgentes())
			{
				dibujarEspectro(objetivo.getCentro(), false);
				pictureBox1.Refresh();
				gr.Clear(Color.Transparent);
			}
			for(int i = 0; i<aList.Count;i++)
			{
				dibujarEspectro(aList[i].getListaCamino(), true);
			}
			pictureBox1.Refresh();
		}
		void TreeView1Click(object sender, EventArgs e)
		{
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.ContextMenuStrip.Show();
		}
		
		void ObjetivoToolStripMenuItemClick(object sender, EventArgs e)
		{
			int node_select = this.treeView1.SelectedNode.Index;
			this.objetivo = grafo.getVertices()[node_select];
			this.dibujarEspectro(objetivo.getCentro(), false);
			pictureBox1.Refresh();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			mostrarAlgoritmos a = new mostrarAlgoritmos(back, grafo);
			a.Show();
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			comboBox1.Enabled = true;
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			comboBox1.Enabled = false;			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			aList.Clear();
			Graphics gr = Graphics.FromImage(bm);
			gr.Clear(Color.Transparent);
			pictureBox1.Refresh();
			
			
		}
	}
}
