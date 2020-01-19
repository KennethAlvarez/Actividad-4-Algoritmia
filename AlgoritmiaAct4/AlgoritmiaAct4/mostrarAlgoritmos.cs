/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 15/11/2019
 * Time: 04:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoritmiaAct4
{
	/// <summary>
	/// Description of mostrarAlgoritmos.
	/// </summary>
	public partial class mostrarAlgoritmos : Form
	{
		Grafo grafo = new Grafo();
		Bitmap bm;
		Bitmap bm2;
		public mostrarAlgoritmos(Bitmap bmp, Grafo grafo)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.bm = new Bitmap(bmp);
			this.bm2 = new Bitmap(bmp);
			this.pictureBox1.Image = bm;
			this.pictureBox2.Image = bm2;
			this.grafo = grafo;
			
			for(int i = 0; i<grafo.getVertices().Count;i++)
				comboBox1.Items.Add(grafo.getVertices()[i].getID().ToString());
		}
		
		void pintarAristas(List<Arista> lAristas, bool flag)
		{

			Pen lapiz = new Pen(Color.Green, 10);
			Graphics gr;
			if(flag)
				 gr = Graphics.FromImage(bm);
			else
				 gr = Graphics.FromImage(bm2);
				
			for(int i = 0; i<lAristas.Count;i++)
			{
				gr.DrawLine(lapiz, lAristas[i].getOrigen().getCentro(), lAristas[i].getDestino().getCentro());
				
				if(flag)
					pictureBox1.Refresh();
				else
					pictureBox2.Refresh();
			}
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int vert = comboBox1.SelectedIndex;
			Kruskal a = new Kruskal(grafo);
			pintarAristas(a.ejecutarKruskal(), true);
			
			Prim aa = new Prim(grafo, grafo.getVertices()[vert]);
			pintarAristas(aa.ejecutarPrim(), false);
			
			this.treeView1.BeginUpdate();
			for(int i = 0; i<a.getPrometedor().Count;i++)
			{
				this.treeView1.Nodes.Add("Origen: "+a.getPrometedor()[i].getOrigen().getID()+" -> "+a.getPrometedor()[i].getDestino().getID());
				
			}
			this.treeView1.EndUpdate();
			
			this.treeView2.BeginUpdate();
			for(int i = 0; i<aa.getPrometedor().Count;i++)
			{
				this.treeView2.Nodes.Add("Origen: "+aa.getPrometedor()[i].getOrigen().getID()+" -> "+aa.getPrometedor()[i].getDestino().getID());
				
			}
			this.treeView2.EndUpdate();
			
			this.labelNumKruskal.Text = " "+a.getCC().Count;
			this.labelNumPrim.Text = " "+aa.getNumGrafos();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Graphics gr = Graphics.FromImage(bm);
			gr.Clear(Color.Transparent);
			
			gr = Graphics.FromImage(bm2);
			gr.Clear(Color.Transparent);
			pictureBox1.Refresh();
			pictureBox2.Refresh();
			        
		}
		
		void MostrarAlgoritmosLoad(object sender, EventArgs e)
		{
			
		}
	}
}
