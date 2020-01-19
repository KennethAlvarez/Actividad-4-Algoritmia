/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 10/11/2019
 * Time: 10:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlgoritmiaAct4
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button4 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 43);
			this.button1.TabIndex = 0;
			this.button1.Text = "Seleccionar imagen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(120, 389);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 43);
			this.button2.TabIndex = 1;
			this.button2.Text = "Analizar imagen";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(253, 389);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 43);
			this.button3.TabIndex = 2;
			this.button3.Text = "Empezar animación";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(748, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(141, 180);
			this.treeView1.TabIndex = 4;
			this.treeView1.Click += new System.EventHandler(this.TreeView1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(729, 355);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.agenteToolStripMenuItem,
									this.objetivoToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
			// 
			// agenteToolStripMenuItem
			// 
			this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
			this.agenteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.agenteToolStripMenuItem.Text = "Agente";
			this.agenteToolStripMenuItem.Click += new System.EventHandler(this.AgenteToolStripMenuItemClick);
			// 
			// objetivoToolStripMenuItem
			// 
			this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
			this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.objetivoToolStripMenuItem.Text = "Objetivo";
			this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.ObjetivoToolStripMenuItemClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(360, 389);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 43);
			this.button4.TabIndex = 7;
			this.button4.Text = "Comparar Arboles";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(748, 205);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Kruskal";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(748, 224);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Prim";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(837, 224);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(52, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(790, 389);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(77, 43);
			this.button5.TabIndex = 11;
			this.button5.Text = "Reiniciar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(916, 444);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "AlgoritmiaAct4";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
