
namespace Capa_de_presentacion
{
    partial class Productos_mostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_mostrar));
            this.P_Precio = new System.Windows.Forms.Label();
            this.P_Nombre = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.P_Imagen = new System.Windows.Forms.PictureBox();
            this.lbid = new System.Windows.Forms.Label();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Precio
            // 
            this.P_Precio.AutoSize = true;
            this.P_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.P_Precio.Location = new System.Drawing.Point(40, 150);
            this.P_Precio.Name = "P_Precio";
            this.P_Precio.Size = new System.Drawing.Size(26, 18);
            this.P_Precio.TabIndex = 1;
            this.P_Precio.Text = "00";
            // 
            // P_Nombre
            // 
            this.P_Nombre.AutoSize = true;
            this.P_Nombre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.P_Nombre.Location = new System.Drawing.Point(22, 4);
            this.P_Nombre.MaximumSize = new System.Drawing.Size(120, 0);
            this.P_Nombre.Name = "P_Nombre";
            this.P_Nombre.Size = new System.Drawing.Size(73, 19);
            this.P_Nombre.TabIndex = 2;
            this.P_Nombre.Text = "Nombre ";
            this.P_Nombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 14;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(10, 172);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(119, 28);
            this.guna2GradientButton1.TabIndex = 5;
            this.guna2GradientButton1.Text = "Agregar";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.P_Imagen;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 25;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.LabelCantidad);
            this.bunifuPanel2.Location = new System.Drawing.Point(114, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(28, 28);
            this.bunifuPanel2.TabIndex = 6;
            // 
            // LabelCantidad
            // 
            this.LabelCantidad.AutoSize = true;
            this.LabelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.LabelCantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCantidad.ForeColor = System.Drawing.Color.White;
            this.LabelCantidad.Location = new System.Drawing.Point(7, 5);
            this.LabelCantidad.Name = "LabelCantidad";
            this.LabelCantidad.Size = new System.Drawing.Size(16, 17);
            this.LabelCantidad.TabIndex = 7;
            this.LabelCantidad.Text = "0";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.P_Imagen);
            this.bunifuPanel1.Location = new System.Drawing.Point(7, 40);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(126, 107);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // P_Imagen
            // 
            this.P_Imagen.BackColor = System.Drawing.Color.Transparent;
            this.P_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("P_Imagen.Image")));
            this.P_Imagen.Location = new System.Drawing.Point(6, 11);
            this.P_Imagen.Name = "P_Imagen";
            this.P_Imagen.Size = new System.Drawing.Size(115, 84);
            this.P_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_Imagen.TabIndex = 1;
            this.P_Imagen.TabStop = false;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(78)))), ((int)(((byte)(145)))));
            this.lbid.Location = new System.Drawing.Point(200, 150);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(26, 18);
            this.lbid.TabIndex = 7;
            this.lbid.Text = "00";
            // 
            // Productos_mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.P_Nombre);
            this.Controls.Add(this.P_Precio);
            this.Name = "Productos_mostrar";
            this.Size = new System.Drawing.Size(142, 209);
            this.Load += new System.EventHandler(this.Productos_mostrar_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label P_Precio;
        public System.Windows.Forms.Label P_Nombre;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public System.Windows.Forms.PictureBox P_Imagen;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public System.Windows.Forms.Label LabelCantidad;
        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        public System.Windows.Forms.Label lbid;
    }
}
