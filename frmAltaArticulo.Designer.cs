namespace Tp2_Winform
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcod = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblimagen = new System.Windows.Forms.Label();
            this.tbxCategoria = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(214, 42);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(57, 16);
            this.lblcod.TabIndex = 1;
            this.lblcod.Text = "Código: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(214, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(214, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(214, 160);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(214, 204);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(214, 249);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(330, 33);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(212, 22);
            this.tbxCodigo.TabIndex = 8;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(330, 75);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(212, 22);
            this.tbxNombre.TabIndex = 9;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(330, 119);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(212, 22);
            this.tbxDescripcion.TabIndex = 10;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(330, 246);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(212, 22);
            this.tbxPrecio.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(198, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 46);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 46);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(330, 289);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(212, 22);
            this.tbxUrl.TabIndex = 17;
            // 
            // lblimagen
            // 
            this.lblimagen.AutoSize = true;
            this.lblimagen.Location = new System.Drawing.Point(214, 292);
            this.lblimagen.Name = "lblimagen";
            this.lblimagen.Size = new System.Drawing.Size(85, 16);
            this.lblimagen.TabIndex = 16;
            this.lblimagen.Text = "URL Imagen:";
            // 
            // tbxCategoria
            // 
            this.tbxCategoria.Location = new System.Drawing.Point(330, 204);
            this.tbxCategoria.Name = "tbxCategoria";
            this.tbxCategoria.Size = new System.Drawing.Size(212, 22);
            this.tbxCategoria.TabIndex = 12;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(330, 157);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(212, 22);
            this.tbxMarca.TabIndex = 11;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.lblimagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxCategoria);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblcod);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lblimagen;
        private System.Windows.Forms.TextBox tbxCategoria;
        private System.Windows.Forms.TextBox tbxMarca;
    }
}