namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.ImagemOriginal = new System.Windows.Forms.PictureBox();
            this.ImagemResultado = new System.Windows.Forms.PictureBox();
            this.SelecionaImagem = new System.Windows.Forms.Button();
            this.SalvaImagem = new System.Windows.Forms.Button();
            this.Negativo = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.Blur = new System.Windows.Forms.Button();
            this.PretoeBranco = new System.Windows.Forms.Button();
            this.BordaPreta = new System.Windows.Forms.Button();
            this.GrayScale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemOriginal
            // 
            this.ImagemOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagemOriginal.Location = new System.Drawing.Point(25, 58);
            this.ImagemOriginal.Name = "ImagemOriginal";
            this.ImagemOriginal.Size = new System.Drawing.Size(500, 500);
            this.ImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemOriginal.TabIndex = 0;
            this.ImagemOriginal.TabStop = false;
            this.ImagemOriginal.Click += new System.EventHandler(this.campoImagemOriginal);
            // 
            // ImagemResultado
            // 
            this.ImagemResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagemResultado.Location = new System.Drawing.Point(752, 58);
            this.ImagemResultado.Name = "ImagemResultado";
            this.ImagemResultado.Size = new System.Drawing.Size(500, 500);
            this.ImagemResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemResultado.TabIndex = 2;
            this.ImagemResultado.TabStop = false;
            // 
            // SelecionaImagem
            // 
            this.SelecionaImagem.BackColor = System.Drawing.Color.White;
            this.SelecionaImagem.Location = new System.Drawing.Point(25, 577);
            this.SelecionaImagem.Name = "SelecionaImagem";
            this.SelecionaImagem.Size = new System.Drawing.Size(171, 30);
            this.SelecionaImagem.TabIndex = 3;
            this.SelecionaImagem.Text = "Selecionar Imagem";
            this.SelecionaImagem.UseVisualStyleBackColor = false;
            this.SelecionaImagem.Click += new System.EventHandler(this.btSeleciona);
            // 
            // SalvaImagem
            // 
            this.SalvaImagem.BackColor = System.Drawing.Color.White;
            this.SalvaImagem.Location = new System.Drawing.Point(1081, 577);
            this.SalvaImagem.Name = "SalvaImagem";
            this.SalvaImagem.Size = new System.Drawing.Size(171, 30);
            this.SalvaImagem.TabIndex = 4;
            this.SalvaImagem.Text = "Salvar Imagem";
            this.SalvaImagem.UseVisualStyleBackColor = false;
            this.SalvaImagem.Click += new System.EventHandler(this.btSalvar);
            // 
            // Negativo
            // 
            this.Negativo.BackColor = System.Drawing.Color.White;
            this.Negativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Negativo.Location = new System.Drawing.Point(594, 197);
            this.Negativo.Name = "Negativo";
            this.Negativo.Size = new System.Drawing.Size(100, 30);
            this.Negativo.TabIndex = 5;
            this.Negativo.Text = "Negativo";
            this.Negativo.UseVisualStyleBackColor = false;
            this.Negativo.Click += new System.EventHandler(this.btNegativo);
            // 
            // Sepia
            // 
            this.Sepia.BackColor = System.Drawing.Color.White;
            this.Sepia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sepia.Location = new System.Drawing.Point(594, 341);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(100, 30);
            this.Sepia.TabIndex = 6;
            this.Sepia.Text = "Sepia";
            this.Sepia.UseVisualStyleBackColor = false;
            this.Sepia.Click += new System.EventHandler(this.btSepia);
            // 
            // Blur
            // 
            this.Blur.BackColor = System.Drawing.Color.White;
            this.Blur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Blur.Location = new System.Drawing.Point(594, 132);
            this.Blur.Name = "Blur";
            this.Blur.Size = new System.Drawing.Size(100, 30);
            this.Blur.TabIndex = 7;
            this.Blur.Text = "Blur";
            this.Blur.UseVisualStyleBackColor = false;
            this.Blur.Click += new System.EventHandler(this.btBlur);
            // 
            // PretoeBranco
            // 
            this.PretoeBranco.BackColor = System.Drawing.Color.White;
            this.PretoeBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PretoeBranco.Location = new System.Drawing.Point(594, 481);
            this.PretoeBranco.Name = "PretoeBranco";
            this.PretoeBranco.Size = new System.Drawing.Size(100, 30);
            this.PretoeBranco.TabIndex = 8;
            this.PretoeBranco.Text = "Preto e branco";
            this.PretoeBranco.UseVisualStyleBackColor = false;
            this.PretoeBranco.Click += new System.EventHandler(this.btPretoBranco);
            // 
            // BordaPreta
            // 
            this.BordaPreta.BackColor = System.Drawing.Color.White;
            this.BordaPreta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BordaPreta.Location = new System.Drawing.Point(594, 411);
            this.BordaPreta.Name = "BordaPreta";
            this.BordaPreta.Size = new System.Drawing.Size(100, 30);
            this.BordaPreta.TabIndex = 14;
            this.BordaPreta.Text = "Borda preta";
            this.BordaPreta.UseVisualStyleBackColor = false;
            this.BordaPreta.Click += new System.EventHandler(this.btBordaPreta);
            // 
            // GrayScale
            // 
            this.GrayScale.BackColor = System.Drawing.Color.White;
            this.GrayScale.Location = new System.Drawing.Point(594, 272);
            this.GrayScale.Name = "GrayScale";
            this.GrayScale.Size = new System.Drawing.Size(100, 30);
            this.GrayScale.TabIndex = 27;
            this.GrayScale.Text = "Gray-Scale";
            this.GrayScale.UseVisualStyleBackColor = false;
            this.GrayScale.Click += new System.EventHandler(this.btGrayscale);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Imagem Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Filtros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrayScale);
            this.Controls.Add(this.BordaPreta);
            this.Controls.Add(this.PretoeBranco);
            this.Controls.Add(this.Blur);
            this.Controls.Add(this.Sepia);
            this.Controls.Add(this.Negativo);
            this.Controls.Add(this.SalvaImagem);
            this.Controls.Add(this.SelecionaImagem);
            this.Controls.Add(this.ImagemResultado);
            this.Controls.Add(this.ImagemOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemOriginal;
        private System.Windows.Forms.PictureBox ImagemResultado;
        private System.Windows.Forms.Button SelecionaImagem;
        private System.Windows.Forms.Button SalvaImagem;
        private System.Windows.Forms.Button Negativo;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.Button Blur;
        private System.Windows.Forms.Button PretoeBranco;
        private System.Windows.Forms.Button BordaPreta;
        private System.Windows.Forms.Button GrayScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

