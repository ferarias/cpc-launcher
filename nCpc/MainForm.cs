using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace nCpc
{
	public class MainForm : Form
	{
		private ListaDescripcionesCPC descripcs;

		private IContainer components = null;

		private ColumnHeader columnHeader3;

		private TextBox tbDetalles;

		private Button btAcerca;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader1;

		private Button btReleer;

		private Button btJugar;

		private ListView lvLista;

		private Label lbDetalles;

		private Label lbLista;

		private PictureBox pbPresent;

		private CheckBox cbPantCompleta;

		public MainForm()
		{
			InitializeComponent();
			leerLista();
			lvLista.Focus();
		}

		private void BtReleerClick(object sender, EventArgs e)
		{
			leerLista();
		}

		private void leerLista()
		{
			try
			{
				ListaFicherosCPC listaFicherosCPC = new ListaFicherosCPC();
				listaFicherosCPC.Leer();
				lvLista.Items.Clear();
				for (int i = 0; i < listaFicherosCPC.LeerCantidad(); i = checked(i + 1))
				{
					char[] separator = new char[1] { '¬' };
					string[] array = listaFicherosCPC.LeerDato(i).Split(separator);
					ListViewItem listViewItem = new ListViewItem(array[0]);
					listViewItem.SubItems.Add(array[2]);
					lvLista.Items.Add(listViewItem);
				}
				lvLista.SelectedIndices.Add(0);
				descripcs = new ListaDescripcionesCPC();
				descripcs.Leer();
			}
			catch (Exception)
			{
			}
		}

		private void jugar()
		{
			try
			{
				string text = lvLista.Items[lvLista.SelectedIndices[0]].Text;
				string currentDirectory = Environment.CurrentDirectory;
				string fileName = currentDirectory + "\\emulador\\cpce95.exe";
				string text2 = "";
				if (cbPantCompleta.Checked)
				{
					text2 = "/m ";
				}
				Process process = Process.Start(fileName, text2 + "\"" + text + "\"");
				process.WaitForExit();
			}
			catch (Exception)
			{
			}
		}

		private void BtJugarClick(object sender, EventArgs e)
		{
			jugar();
		}

		private void LvListaDoubleClick(object sender, EventArgs e)
		{
			jugar();
		}

		private void BtAcercaClick(object sender, EventArgs e)
		{
			MessageBox.Show("nCPC, cargador rápido de juegos de CPC\nVersión 0.03\n\nSe basa en el emulador CPCE, de CNGsoft\ny usa capturas de CpcGamesCD por MiguelSky\nDesarrollado por N., 2011", "Acerca de...");
		}

		private void LvListaSelectedIndexChanged(object sender, EventArgs e)
		{
			ActualizaInformacion();
		}

		private void ActualizaInformacion()
		{
			if (lvLista.SelectedIndices.Count > 0)
			{
				string text = lvLista.Items[lvLista.SelectedIndices[0]].Text;
				string text2 = "capturas\\" + text + ".png";
				if (File.Exists(text2))
				{
					pbPresent.Load(text2);
				}
				else
				{
					pbPresent.Image = null;
				}
				string text3 = descripcs.LeerTeclas(text);
				tbDetalles.Clear();
				tbDetalles.Lines = new string[5] { "Pulsa:", "* Alt+F4 para terminar", "* Alt+Intro para pasar de ventana a pantalla completa", text3, "Joystick: Joystick externo o el teclado numérico" };
			}
			lvLista.Focus();
		}

		private void LvListaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				jugar();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.pbPresent = new System.Windows.Forms.PictureBox();
			this.tbDetalles = new System.Windows.Forms.TextBox();
			this.lvLista = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.lbLista = new System.Windows.Forms.Label();
			this.lbDetalles = new System.Windows.Forms.Label();
			this.btJugar = new System.Windows.Forms.Button();
			this.btReleer = new System.Windows.Forms.Button();
			this.btAcerca = new System.Windows.Forms.Button();
			this.cbPantCompleta = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)this.pbPresent).BeginInit();
			base.SuspendLayout();
			this.pbPresent.BackColor = System.Drawing.Color.Black;
			this.pbPresent.Location = new System.Drawing.Point(306, 2);
			this.pbPresent.Margin = new System.Windows.Forms.Padding(2);
			this.pbPresent.Name = "pbPresent";
			this.pbPresent.Size = new System.Drawing.Size(384, 544);
			this.pbPresent.TabIndex = 0;
			this.pbPresent.TabStop = false;
			this.tbDetalles.Location = new System.Drawing.Point(16, 432);
			this.tbDetalles.Margin = new System.Windows.Forms.Padding(2);
			this.tbDetalles.Multiline = true;
			this.tbDetalles.Name = "tbDetalles";
			this.tbDetalles.ReadOnly = true;
			this.tbDetalles.Size = new System.Drawing.Size(263, 104);
			this.tbDetalles.TabIndex = 4;
			this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader1, this.columnHeader2, this.columnHeader3 });
			this.lvLista.GridLines = true;
			this.lvLista.Location = new System.Drawing.Point(18, 68);
			this.lvLista.Margin = new System.Windows.Forms.Padding(2);
			this.lvLista.MultiSelect = false;
			this.lvLista.Name = "lvLista";
			this.lvLista.Size = new System.Drawing.Size(261, 326);
			this.lvLista.TabIndex = 5;
			this.lvLista.UseCompatibleStateImageBehavior = false;
			this.lvLista.View = System.Windows.Forms.View.Details;
			this.lvLista.SelectedIndexChanged += new System.EventHandler(LvListaSelectedIndexChanged);
			this.lvLista.DoubleClick += new System.EventHandler(LvListaDoubleClick);
			this.lvLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(LvListaKeyPress);
			this.columnHeader1.Text = "Nombre";
			this.columnHeader1.Width = 152;
			this.columnHeader2.Text = "Tipo";
			this.columnHeader3.Text = "Categorías";
			this.columnHeader3.Width = 111;
			this.lbLista.Location = new System.Drawing.Point(18, 47);
			this.lbLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbLista.Name = "lbLista";
			this.lbLista.Size = new System.Drawing.Size(182, 19);
			this.lbLista.TabIndex = 6;
			this.lbLista.Text = "Lista de juegos y aplicaciones";
			this.lbDetalles.Location = new System.Drawing.Point(18, 411);
			this.lbDetalles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbDetalles.Name = "lbDetalles";
			this.lbDetalles.Size = new System.Drawing.Size(222, 19);
			this.lbDetalles.TabIndex = 7;
			this.lbDetalles.Text = "Detalles del juego o aplicación actual";
			this.btJugar.Location = new System.Drawing.Point(18, 13);
			this.btJugar.Margin = new System.Windows.Forms.Padding(2);
			this.btJugar.Name = "btJugar";
			this.btJugar.Size = new System.Drawing.Size(58, 32);
			this.btJugar.TabIndex = 8;
			this.btJugar.Text = "Jugar";
			this.btJugar.UseVisualStyleBackColor = true;
			this.btJugar.Click += new System.EventHandler(BtJugarClick);
			this.btReleer.Location = new System.Drawing.Point(180, 24);
			this.btReleer.Margin = new System.Windows.Forms.Padding(2);
			this.btReleer.Name = "btReleer";
			this.btReleer.Size = new System.Drawing.Size(74, 20);
			this.btReleer.TabIndex = 9;
			this.btReleer.Text = "Releer lista";
			this.btReleer.UseVisualStyleBackColor = true;
			this.btReleer.Click += new System.EventHandler(BtReleerClick);
			this.btAcerca.Location = new System.Drawing.Point(259, 24);
			this.btAcerca.Margin = new System.Windows.Forms.Padding(2);
			this.btAcerca.Name = "btAcerca";
			this.btAcerca.Size = new System.Drawing.Size(20, 20);
			this.btAcerca.TabIndex = 10;
			this.btAcerca.Text = "?";
			this.btAcerca.UseVisualStyleBackColor = true;
			this.btAcerca.Click += new System.EventHandler(BtAcercaClick);
			this.cbPantCompleta.AutoSize = true;
			this.cbPantCompleta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbPantCompleta.Location = new System.Drawing.Point(166, 2);
			this.cbPantCompleta.Margin = new System.Windows.Forms.Padding(2);
			this.cbPantCompleta.Name = "cbPantCompleta";
			this.cbPantCompleta.Size = new System.Drawing.Size(116, 17);
			this.cbPantCompleta.TabIndex = 11;
			this.cbPantCompleta.Text = "Pantalla completa?";
			this.cbPantCompleta.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(702, 556);
			base.Controls.Add(this.cbPantCompleta);
			base.Controls.Add(this.btAcerca);
			base.Controls.Add(this.btReleer);
			base.Controls.Add(this.btJugar);
			base.Controls.Add(this.lbDetalles);
			base.Controls.Add(this.lbLista);
			base.Controls.Add(this.lvLista);
			base.Controls.Add(this.tbDetalles);
			base.Controls.Add(this.pbPresent);
			base.Margin = new System.Windows.Forms.Padding(2);
			base.Name = "MainForm";
			this.Text = "nCpc 0.03";
			base.Load += new System.EventHandler(MainForm_Load);
			((System.ComponentModel.ISupportInitialize)this.pbPresent).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
