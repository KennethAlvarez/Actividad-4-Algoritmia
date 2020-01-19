/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 15/11/2019
 * Time: 04:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlgoritmiaAct4
{
	partial class mostrarAlgoritmos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.labelNumKruskal = new System.Windows.Forms.Label();
			this.labelNumPrim = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(458, 384);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(719, 48);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(461, 384);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(140, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kruskal";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(891, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Prim";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(661, 489);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(568, 479);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 31);
			this.button1.TabIndex = 6;
			this.button1.Text = "Mostrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(661, 453);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 33);
			this.label3.TabIndex = 7;
			this.label3.Text = "Seleccione vértice incio para Prim";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(487, 479);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 31);
			this.button2.TabIndex = 8;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(476, 132);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(108, 253);
			this.treeView1.TabIndex = 9;
			// 
			// treeView2
			// 
			this.treeView2.Location = new System.Drawing.Point(603, 132);
			this.treeView2.Name = "treeView2";
			this.treeView2.Size = new System.Drawing.Size(109, 253);
			this.treeView2.TabIndex = 10;
			// 
			// labelNumKruskal
			// 
			this.labelNumKruskal.Location = new System.Drawing.Point(503, 106);
			this.labelNumKruskal.Name = "labelNumKruskal";
			this.labelNumKruskal.Size = new System.Drawing.Size(50, 23);
			this.labelNumKruskal.TabIndex = 11;
			// 
			// labelNumPrim
			// 
			this.labelNumPrim.Location = new System.Drawing.Point(628, 106);
			this.labelNumPrim.Name = "labelNumPrim";
			this.labelNumPrim.Size = new System.Drawing.Size(58, 23);
			this.labelNumPrim.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(517, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 27);
			this.label4.TabIndex = 13;
			this.label4.Text = "Número de Grafos";
			// 
			// mostrarAlgoritmos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 516);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelNumPrim);
			this.Controls.Add(this.labelNumKruskal);
			this.Controls.Add(this.treeView2);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "mostrarAlgoritmos";
			this.Text = "mostrarAlgoritmos";
			this.Load += new System.EventHandler(this.MostrarAlgoritmosLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelNumPrim;
		private System.Windows.Forms.Label labelNumKruskal;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
