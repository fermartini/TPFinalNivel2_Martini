namespace Presentacion
{
    partial class ArticuloDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticuloDetalles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalirArticulo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pbxDetalleImagen = new System.Windows.Forms.PictureBox();
            this.lblDetalleTextPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDetalleTextCategoria = new System.Windows.Forms.Label();
            this.lblDetalleTextMarca = new System.Windows.Forms.Label();
            this.lblDetalleTextDetalle = new System.Windows.Forms.Label();
            this.lblDetalleTextNombre = new System.Windows.Forms.Label();
            this.lblDetalleTextCodigo = new System.Windows.Forms.Label();
            this.lblDetalleTextId = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.lblIdDetalle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnSalirArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(500, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(250, 100);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(250, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(250, 100);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(250, 100);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalirArticulo
            // 
            this.btnSalirArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirArticulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalirArticulo.FlatAppearance.BorderSize = 0;
            this.btnSalirArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSalirArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.btnSalirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirArticulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirArticulo.ForeColor = System.Drawing.Color.Black;
            this.btnSalirArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirArticulo.Image")));
            this.btnSalirArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirArticulo.Location = new System.Drawing.Point(550, 0);
            this.btnSalirArticulo.Name = "btnSalirArticulo";
            this.btnSalirArticulo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSalirArticulo.Size = new System.Drawing.Size(250, 100);
            this.btnSalirArticulo.TabIndex = 3;
            this.btnSalirArticulo.Text = "SALIR";
            this.btnSalirArticulo.UseVisualStyleBackColor = true;
            this.btnSalirArticulo.Click += new System.EventHandler(this.btnSalirArticulo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.btnAgregarImagen);
            this.panel2.Controls.Add(this.txtCategoria);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.txtImagen);
            this.panel2.Controls.Add(this.lblImagen);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.txtDetalle);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.pbxDetalleImagen);
            this.panel2.Controls.Add(this.lblDetalleTextPrecio);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Controls.Add(this.lblDetalleTextCategoria);
            this.panel2.Controls.Add(this.lblDetalleTextMarca);
            this.panel2.Controls.Add(this.lblDetalleTextDetalle);
            this.panel2.Controls.Add(this.lblDetalleTextNombre);
            this.panel2.Controls.Add(this.lblDetalleTextCodigo);
            this.panel2.Controls.Add(this.lblDetalleTextId);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.lblMarca);
            this.panel2.Controls.Add(this.lblDetalle);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblCodigoDetalle);
            this.panel2.Controls.Add(this.lblIdDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAgregarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImagen.Image")));
            this.btnAgregarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarImagen.Location = new System.Drawing.Point(408, 298);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(86, 27);
            this.btnAgregarImagen.TabIndex = 7;
            this.btnAgregarImagen.Text = "Adjuntar";
            this.btnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(184, 228);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(310, 28);
            this.txtCategoria.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.Location = new System.Drawing.Point(184, 190);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(310, 28);
            this.txtMarca.TabIndex = 3;
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.txtImagen.Location = new System.Drawing.Point(184, 299);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(218, 26);
            this.txtImagen.TabIndex = 6;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblImagen.Location = new System.Drawing.Point(31, 300);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(141, 24);
            this.lblImagen.TabIndex = 22;
            this.lblImagen.Text = "URL IMAGEN:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.txtPrecio.Location = new System.Drawing.Point(184, 266);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(310, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.txtDetalle.Location = new System.Drawing.Point(184, 147);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(310, 26);
            this.txtDetalle.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.txtNombre.Location = new System.Drawing.Point(184, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.txtCodigo.Location = new System.Drawing.Point(184, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(310, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // pbxDetalleImagen
            // 
            this.pbxDetalleImagen.Location = new System.Drawing.Point(513, 27);
            this.pbxDetalleImagen.Name = "pbxDetalleImagen";
            this.pbxDetalleImagen.Size = new System.Drawing.Size(275, 298);
            this.pbxDetalleImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDetalleImagen.TabIndex = 14;
            this.pbxDetalleImagen.TabStop = false;
            // 
            // lblDetalleTextPrecio
            // 
            this.lblDetalleTextPrecio.AutoSize = true;
            this.lblDetalleTextPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextPrecio.Location = new System.Drawing.Point(193, 266);
            this.lblDetalleTextPrecio.Name = "lblDetalleTextPrecio";
            this.lblDetalleTextPrecio.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextPrecio.TabIndex = 13;
            this.lblDetalleTextPrecio.Text = "a";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblPrecio.Location = new System.Drawing.Point(81, 266);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 24);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "PRECIO: ";
            // 
            // lblDetalleTextCategoria
            // 
            this.lblDetalleTextCategoria.AutoSize = true;
            this.lblDetalleTextCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextCategoria.Location = new System.Drawing.Point(193, 227);
            this.lblDetalleTextCategoria.Name = "lblDetalleTextCategoria";
            this.lblDetalleTextCategoria.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextCategoria.TabIndex = 11;
            this.lblDetalleTextCategoria.Text = "a";
            // 
            // lblDetalleTextMarca
            // 
            this.lblDetalleTextMarca.AutoSize = true;
            this.lblDetalleTextMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextMarca.Location = new System.Drawing.Point(193, 187);
            this.lblDetalleTextMarca.Name = "lblDetalleTextMarca";
            this.lblDetalleTextMarca.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextMarca.TabIndex = 10;
            this.lblDetalleTextMarca.Text = "a";
            // 
            // lblDetalleTextDetalle
            // 
            this.lblDetalleTextDetalle.AutoSize = true;
            this.lblDetalleTextDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextDetalle.Location = new System.Drawing.Point(193, 147);
            this.lblDetalleTextDetalle.Name = "lblDetalleTextDetalle";
            this.lblDetalleTextDetalle.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextDetalle.TabIndex = 9;
            this.lblDetalleTextDetalle.Text = "a";
            // 
            // lblDetalleTextNombre
            // 
            this.lblDetalleTextNombre.AutoSize = true;
            this.lblDetalleTextNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextNombre.Location = new System.Drawing.Point(193, 104);
            this.lblDetalleTextNombre.Name = "lblDetalleTextNombre";
            this.lblDetalleTextNombre.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextNombre.TabIndex = 8;
            this.lblDetalleTextNombre.Text = "a";
            // 
            // lblDetalleTextCodigo
            // 
            this.lblDetalleTextCodigo.AutoSize = true;
            this.lblDetalleTextCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextCodigo.Location = new System.Drawing.Point(193, 66);
            this.lblDetalleTextCodigo.Name = "lblDetalleTextCodigo";
            this.lblDetalleTextCodigo.Size = new System.Drawing.Size(24, 25);
            this.lblDetalleTextCodigo.TabIndex = 7;
            this.lblDetalleTextCodigo.Text = "a";
            // 
            // lblDetalleTextId
            // 
            this.lblDetalleTextId.AutoSize = true;
            this.lblDetalleTextId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleTextId.Location = new System.Drawing.Point(193, 27);
            this.lblDetalleTextId.Name = "lblDetalleTextId";
            this.lblDetalleTextId.Size = new System.Drawing.Size(0, 25);
            this.lblDetalleTextId.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblCategoria.Location = new System.Drawing.Point(38, 227);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(141, 24);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "CATEGORIA: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblMarca.Location = new System.Drawing.Point(78, 190);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(100, 24);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "MARCA: ";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblDetalle.Location = new System.Drawing.Point(79, 147);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(102, 24);
            this.lblDetalle.TabIndex = 3;
            this.lblDetalle.Text = "DETALLE: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblNombre.Location = new System.Drawing.Point(69, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE: ";
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblCodigoDetalle.Location = new System.Drawing.Point(66, 69);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(113, 24);
            this.lblCodigoDetalle.TabIndex = 1;
            this.lblCodigoDetalle.Text = "CODIGO: ";
            // 
            // lblIdDetalle
            // 
            this.lblIdDetalle.AutoSize = true;
            this.lblIdDetalle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(179)))), ((int)(((byte)(126)))));
            this.lblIdDetalle.Location = new System.Drawing.Point(137, 27);
            this.lblIdDetalle.Name = "lblIdDetalle";
            this.lblIdDetalle.Size = new System.Drawing.Size(42, 24);
            this.lblIdDetalle.TabIndex = 0;
            this.lblIdDetalle.Text = "ID: ";
            // 
            // ArticuloDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticuloDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArticuloDetalles";
            this.Load += new System.EventHandler(this.ArticuloDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirArticulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Label lblIdDetalle;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDetalleTextId;
        private System.Windows.Forms.Label lblDetalleTextCodigo;
        private System.Windows.Forms.Label lblDetalleTextPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDetalleTextCategoria;
        private System.Windows.Forms.Label lblDetalleTextMarca;
        private System.Windows.Forms.Label lblDetalleTextDetalle;
        private System.Windows.Forms.Label lblDetalleTextNombre;
        private System.Windows.Forms.PictureBox pbxDetalleImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.Button btnAgregarImagen;
        protected System.Windows.Forms.Button btnEliminar;
    }
}