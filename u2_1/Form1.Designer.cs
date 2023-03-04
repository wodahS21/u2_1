namespace u2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbLinea = new System.Windows.Forms.CheckBox();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.cbElipcell = new System.Windows.Forms.CheckBox();
            this.cbElipce = new System.Windows.Forms.CheckBox();
            this.cbCuadrado = new System.Windows.Forms.CheckBox();
            this.cbRectangulo = new System.Windows.Forms.CheckBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(179, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Aceptar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(309, 221);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 15);
            this.lblNombre.TabIndex = 4;
            // 
            // cbLinea
            // 
            this.cbLinea.AutoSize = true;
            this.cbLinea.Location = new System.Drawing.Point(54, 48);
            this.cbLinea.Name = "cbLinea";
            this.cbLinea.Size = new System.Drawing.Size(54, 19);
            this.cbLinea.TabIndex = 5;
            this.cbLinea.Text = "Linea";
            this.cbLinea.UseVisualStyleBackColor = true;
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(295, 3);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(493, 448);
            this.pB1.TabIndex = 7;
            this.pB1.TabStop = false;
            // 
            // cbElipcell
            // 
            this.cbElipcell.AutoSize = true;
            this.cbElipcell.Location = new System.Drawing.Point(54, 206);
            this.cbElipcell.Name = "cbElipcell";
            this.cbElipcell.Size = new System.Drawing.Size(86, 19);
            this.cbElipcell.TabIndex = 8;
            this.cbElipcell.Text = "Elipce lleno";
            this.cbElipcell.UseVisualStyleBackColor = true;
            // 
            // cbElipce
            // 
            this.cbElipce.AutoSize = true;
            this.cbElipce.Location = new System.Drawing.Point(54, 164);
            this.cbElipce.Name = "cbElipce";
            this.cbElipce.Size = new System.Drawing.Size(57, 19);
            this.cbElipce.TabIndex = 9;
            this.cbElipce.Text = "Elipce";
            this.cbElipce.UseVisualStyleBackColor = true;
            // 
            // cbCuadrado
            // 
            this.cbCuadrado.AutoSize = true;
            this.cbCuadrado.Location = new System.Drawing.Point(54, 127);
            this.cbCuadrado.Name = "cbCuadrado";
            this.cbCuadrado.Size = new System.Drawing.Size(78, 19);
            this.cbCuadrado.TabIndex = 10;
            this.cbCuadrado.Text = "Cuadrado";
            this.cbCuadrado.UseVisualStyleBackColor = true;
            // 
            // cbRectangulo
            // 
            this.cbRectangulo.AutoSize = true;
            this.cbRectangulo.Location = new System.Drawing.Point(54, 84);
            this.cbRectangulo.Name = "cbRectangulo";
            this.cbRectangulo.Size = new System.Drawing.Size(86, 19);
            this.cbRectangulo.TabIndex = 11;
            this.cbRectangulo.Text = "Rectangulo";
            this.cbRectangulo.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(54, 253);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(71, 19);
            this.cbRandom.TabIndex = 12;
            this.cbRandom.Text = "Random";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Borrar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(181, 60);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 14;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(180, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbRandom);
            this.Controls.Add(this.cbRectangulo);
            this.Controls.Add(this.cbCuadrado);
            this.Controls.Add(this.cbElipce);
            this.Controls.Add(this.cbElipcell);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.cbLinea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn1;
        private Label lblNombre;
        private CheckBox cbLinea;
        private PictureBox pB1;
        private CheckBox cbElipcell;
        private CheckBox cbElipce;
        private CheckBox cbCuadrado;
        private CheckBox cbRectangulo;
        private CheckBox cbRandom;
        private Button btnClear;
        private Button btnColor;
        private ColorDialog colorDialog1;
        private Button btnGuardar;
    }
}