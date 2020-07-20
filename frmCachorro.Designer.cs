namespace IdadeCanina
{
    partial class frmCachorro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCachorro));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pcbFundo = new System.Windows.Forms.PictureBox();
            this.pcbFrente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a idade humana do seu cachorro: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(121, 218);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(81, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(131, 183);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(179, 20);
            this.txbIdade.TabIndex = 4;
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(82, 247);
            this.txbResultado.Multiline = true;
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(267, 68);
            this.txbResultado.TabIndex = 5;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(235, 218);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pcbFundo
            // 
            this.pcbFundo.BackColor = System.Drawing.Color.Transparent;
            this.pcbFundo.Image = ((System.Drawing.Image)(resources.GetObject("pcbFundo.Image")));
            this.pcbFundo.Location = new System.Drawing.Point(121, 1);
            this.pcbFundo.Name = "pcbFundo";
            this.pcbFundo.Size = new System.Drawing.Size(204, 156);
            this.pcbFundo.TabIndex = 7;
            this.pcbFundo.TabStop = false;
            this.pcbFundo.Visible = false;
            // 
            // pcbFrente
            // 
            this.pcbFrente.BackColor = System.Drawing.Color.Transparent;
            this.pcbFrente.Image = ((System.Drawing.Image)(resources.GetObject("pcbFrente.Image")));
            this.pcbFrente.Location = new System.Drawing.Point(121, 1);
            this.pcbFrente.Name = "pcbFrente";
            this.pcbFrente.Size = new System.Drawing.Size(204, 156);
            this.pcbFrente.TabIndex = 8;
            this.pcbFrente.TabStop = false;
            // 
            // frmCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(447, 330);
            this.Controls.Add(this.pcbFrente);
            this.Controls.Add(this.pcbFundo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCachorro";
            this.Text = "Calcular Idade Canina";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pcbFundo;
        private System.Windows.Forms.PictureBox pcbFrente;
        private System.Windows.Forms.Label label1;
    }
}

