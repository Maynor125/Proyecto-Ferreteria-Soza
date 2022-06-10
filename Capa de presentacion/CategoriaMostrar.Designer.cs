
namespace Capa_de_presentacion
{
    partial class CategoriaMostrar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaMostrar));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NombreCategoria = new System.Windows.Forms.Label();
            this.messaje = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightGray;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 12;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.NombreCategoria);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(197, 42);
            this.bunifuPanel1.TabIndex = 0;
            this.messaje.SetToolTip(this.bunifuPanel1, "");
            this.messaje.SetToolTipIcon(this.bunifuPanel1, null);
            this.messaje.SetToolTipTitle(this.bunifuPanel1, "");
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            this.bunifuPanel1.Leave += new System.EventHandler(this.bunifuPanel1_Leave);
            this.bunifuPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.messaje.SetToolTip(this.pictureBox1, "");
            this.messaje.SetToolTipIcon(this.pictureBox1, null);
            this.messaje.SetToolTipTitle(this.pictureBox1, "");
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.AutoSize = true;
            this.NombreCategoria.BackColor = System.Drawing.Color.Transparent;
            this.NombreCategoria.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.NombreCategoria.Location = new System.Drawing.Point(51, 10);
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Size = new System.Drawing.Size(76, 22);
            this.NombreCategoria.TabIndex = 14;
            this.NombreCategoria.Text = "Nombre";
            this.messaje.SetToolTip(this.NombreCategoria, "");
            this.messaje.SetToolTipIcon(this.NombreCategoria, null);
            this.messaje.SetToolTipTitle(this.NombreCategoria, "");
            // 
            // messaje
            // 
            this.messaje.Active = true;
            this.messaje.AlignTextWithTitle = false;
            this.messaje.AllowAutoClose = false;
            this.messaje.AllowFading = true;
            this.messaje.AutoCloseDuration = 5000;
            this.messaje.BackColor = System.Drawing.SystemColors.Control;
            this.messaje.BorderColor = System.Drawing.Color.Gainsboro;
            this.messaje.ClickToShowDisplayControl = false;
            this.messaje.ConvertNewlinesToBreakTags = true;
            this.messaje.DisplayControl = null;
            this.messaje.EntryAnimationSpeed = 350;
            this.messaje.ExitAnimationSpeed = 200;
            this.messaje.GenerateAutoCloseDuration = false;
            this.messaje.IconMargin = 6;
            this.messaje.InitialDelay = 0;
            this.messaje.Name = "messaje";
            this.messaje.Opacity = 1D;
            this.messaje.OverrideToolTipTitles = false;
            this.messaje.Padding = new System.Windows.Forms.Padding(10);
            this.messaje.ReshowDelay = 100;
            this.messaje.ShowAlways = true;
            this.messaje.ShowBorders = false;
            this.messaje.ShowIcons = true;
            this.messaje.ShowShadows = true;
            this.messaje.Tag = null;
            this.messaje.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.messaje.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messaje.TextMargin = 2;
            this.messaje.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.messaje.TitleForeColor = System.Drawing.Color.Black;
            this.messaje.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.messaje.ToolTipTitle = null;
            // 
            // CategoriaMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "CategoriaMostrar";
            this.Size = new System.Drawing.Size(197, 42);
            this.messaje.SetToolTip(this, "");
            this.messaje.SetToolTipIcon(this, null);
            this.messaje.SetToolTipTitle(this, "");
            this.MouseHover += new System.EventHandler(this.CategoriaMostrar_MouseHover);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label NombreCategoria;
        private Bunifu.UI.WinForms.BunifuToolTip messaje;
    }
}
