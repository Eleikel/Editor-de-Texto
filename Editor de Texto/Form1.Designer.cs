namespace Editor_de_Texto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeEleikelNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaYFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(948, 568);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Nuevo,
            this.MenuItem_Abrir,
            this.MenuItem_Guardar,
            this.toolStripSeparator1,
            this.MenuItem_Salir});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // MenuItem_Nuevo
            // 
            this.MenuItem_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Nuevo.Image")));
            this.MenuItem_Nuevo.Name = "MenuItem_Nuevo";
            this.MenuItem_Nuevo.Size = new System.Drawing.Size(180, 26);
            this.MenuItem_Nuevo.Text = "Nuevo";
            this.MenuItem_Nuevo.Click += new System.EventHandler(this.MenuItem_Nuevo_Click);
            // 
            // MenuItem_Abrir
            // 
            this.MenuItem_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Abrir.Image")));
            this.MenuItem_Abrir.Name = "MenuItem_Abrir";
            this.MenuItem_Abrir.Size = new System.Drawing.Size(180, 26);
            this.MenuItem_Abrir.Text = "Abrir";
            this.MenuItem_Abrir.Click += new System.EventHandler(this.MenuItem_Abrir_Click);
            // 
            // MenuItem_Guardar
            // 
            this.MenuItem_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Guardar.Image")));
            this.MenuItem_Guardar.Name = "MenuItem_Guardar";
            this.MenuItem_Guardar.Size = new System.Drawing.Size(180, 26);
            this.MenuItem_Guardar.Text = "Guardar";
            this.MenuItem_Guardar.Click += new System.EventHandler(this.MenuItem_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItem_Salir
            // 
            this.MenuItem_Salir.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Salir.Image")));
            this.MenuItem_Salir.Name = "MenuItem_Salir";
            this.MenuItem_Salir.Size = new System.Drawing.Size(180, 26);
            this.MenuItem_Salir.Text = "Salir";
            this.MenuItem_Salir.Click += new System.EventHandler(this.MenuItem_Salir_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeEleikelNotesToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // acercaDeEleikelNotesToolStripMenuItem
            // 
            this.acercaDeEleikelNotesToolStripMenuItem.Name = "acercaDeEleikelNotesToolStripMenuItem";
            this.acercaDeEleikelNotesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.acercaDeEleikelNotesToolStripMenuItem.Text = "Acerca de EleikelNotes";
            this.acercaDeEleikelNotesToolStripMenuItem.Click += new System.EventHandler(this.acercaDeEleikelNotesToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Copiar,
            this.MenuItem_Pegar,
            this.horaYFechaToolStripMenuItem1});
            this.edicionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // horaYFechaToolStripMenuItem1
            // 
            this.horaYFechaToolStripMenuItem1.Name = "horaYFechaToolStripMenuItem1";
            this.horaYFechaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.horaYFechaToolStripMenuItem1.Text = "Hora y Fecha";
            this.horaYFechaToolStripMenuItem1.Click += new System.EventHandler(this.horaYFechaToolStripMenuItem1_Click);
            // 
            // MenuItem_Copiar
            // 
            this.MenuItem_Copiar.Name = "MenuItem_Copiar";
            this.MenuItem_Copiar.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Copiar.Text = "Copiar";
            this.MenuItem_Copiar.Click += new System.EventHandler(this.MenuItem_Copiar_Click);
            // 
            // MenuItem_Pegar
            // 
            this.MenuItem_Pegar.Name = "MenuItem_Pegar";
            this.MenuItem_Pegar.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Pegar.Text = "Pegar";
            this.MenuItem_Pegar.Click += new System.EventHandler(this.MenuItem_Pegar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 597);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EleikelNotes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Abrir;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Salir;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeEleikelNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaYFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Copiar;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Pegar;
    }
}

