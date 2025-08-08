namespace CALCULADORA_AREA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RBArea = new System.Windows.Forms.RadioButton();
            this.CALCULOS = new System.Windows.Forms.GroupBox();
            this.RBVolume = new System.Windows.Forms.RadioButton();
            this.RBPerimetro = new System.Windows.Forms.RadioButton();
            this.GBResultado = new System.Windows.Forms.GroupBox();
            this.LbResposta = new System.Windows.Forms.TextBox();
            this.PROP_CIRCULO = new System.Windows.Forms.GroupBox();
            this.BtnDesenhar = new System.Windows.Forms.Button();
            this.TxtRaio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.PnDesenho = new System.Windows.Forms.Panel();
            this.CHBApagarDesenho = new System.Windows.Forms.CheckBox();
            this.CHBPreencherCirculo = new System.Windows.Forms.CheckBox();
            this.CALCULOS.SuspendLayout();
            this.GBResultado.SuspendLayout();
            this.PROP_CIRCULO.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBArea
            // 
            this.RBArea.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBArea.Location = new System.Drawing.Point(6, 26);
            this.RBArea.Name = "RBArea";
            this.RBArea.Size = new System.Drawing.Size(158, 45);
            this.RBArea.TabIndex = 0;
            this.RBArea.TabStop = true;
            this.RBArea.Text = "ÁREA DO CIRCULO";
            this.RBArea.UseVisualStyleBackColor = true;
            this.RBArea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CALCULOS
            // 
            this.CALCULOS.Controls.Add(this.RBVolume);
            this.CALCULOS.Controls.Add(this.RBPerimetro);
            this.CALCULOS.Controls.Add(this.RBArea);
            this.CALCULOS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CALCULOS.Location = new System.Drawing.Point(12, 12);
            this.CALCULOS.Name = "CALCULOS";
            this.CALCULOS.Size = new System.Drawing.Size(238, 180);
            this.CALCULOS.TabIndex = 1;
            this.CALCULOS.TabStop = false;
            this.CALCULOS.Text = "CÁLCULOS";
            this.CALCULOS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RBVolume
            // 
            this.RBVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBVolume.Location = new System.Drawing.Point(6, 128);
            this.RBVolume.Name = "RBVolume";
            this.RBVolume.Size = new System.Drawing.Size(158, 45);
            this.RBVolume.TabIndex = 2;
            this.RBVolume.TabStop = true;
            this.RBVolume.Text = "VOLUME DA ESPERA";
            this.RBVolume.UseVisualStyleBackColor = true;
            this.RBVolume.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RBPerimetro
            // 
            this.RBPerimetro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPerimetro.Location = new System.Drawing.Point(6, 77);
            this.RBPerimetro.Name = "RBPerimetro";
            this.RBPerimetro.Size = new System.Drawing.Size(196, 45);
            this.RBPerimetro.TabIndex = 1;
            this.RBPerimetro.TabStop = true;
            this.RBPerimetro.Text = "PERÍMETRO DO CIRCULO";
            this.RBPerimetro.UseVisualStyleBackColor = true;
            // 
            // GBResultado
            // 
            this.GBResultado.Controls.Add(this.LbResposta);
            this.GBResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBResultado.Location = new System.Drawing.Point(12, 211);
            this.GBResultado.Name = "GBResultado";
            this.GBResultado.Size = new System.Drawing.Size(519, 107);
            this.GBResultado.TabIndex = 2;
            this.GBResultado.TabStop = false;
            this.GBResultado.Text = "RESULTADO DO CÁLCULO";
            this.GBResultado.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LbResposta
            // 
            this.LbResposta.BackColor = System.Drawing.Color.White;
            this.LbResposta.Location = new System.Drawing.Point(13, 37);
            this.LbResposta.Multiline = true;
            this.LbResposta.Name = "LbResposta";
            this.LbResposta.Size = new System.Drawing.Size(480, 43);
            this.LbResposta.TabIndex = 4;
            // 
            // PROP_CIRCULO
            // 
            this.PROP_CIRCULO.Controls.Add(this.BtnDesenhar);
            this.PROP_CIRCULO.Controls.Add(this.TxtRaio);
            this.PROP_CIRCULO.Controls.Add(this.label1);
            this.PROP_CIRCULO.Controls.Add(this.BtnCalcular);
            this.PROP_CIRCULO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROP_CIRCULO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PROP_CIRCULO.Location = new System.Drawing.Point(279, 12);
            this.PROP_CIRCULO.Name = "PROP_CIRCULO";
            this.PROP_CIRCULO.Size = new System.Drawing.Size(252, 180);
            this.PROP_CIRCULO.TabIndex = 3;
            this.PROP_CIRCULO.TabStop = false;
            this.PROP_CIRCULO.Text = "PROPRIEDADES DO CIRCULO";
            // 
            // BtnDesenhar
            // 
            this.BtnDesenhar.AutoSize = true;
            this.BtnDesenhar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesenhar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDesenhar.Image = ((System.Drawing.Image)(resources.GetObject("BtnDesenhar.Image")));
            this.BtnDesenhar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDesenhar.Location = new System.Drawing.Point(134, 110);
            this.BtnDesenhar.Name = "BtnDesenhar";
            this.BtnDesenhar.Size = new System.Drawing.Size(94, 58);
            this.BtnDesenhar.TabIndex = 4;
            this.BtnDesenhar.Text = "DESENHAR";
            this.BtnDesenhar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDesenhar.UseVisualStyleBackColor = true;
            this.BtnDesenhar.Click += new System.EventHandler(this.BtnDesenhar_Click);
            // 
            // TxtRaio
            // 
            this.TxtRaio.Location = new System.Drawing.Point(25, 48);
            this.TxtRaio.Multiline = true;
            this.TxtRaio.Name = "TxtRaio";
            this.TxtRaio.Size = new System.Drawing.Size(201, 43);
            this.TxtRaio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RAIO DO CIRCULO:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.AutoSize = true;
            this.BtnCalcular.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCalcular.Location = new System.Drawing.Point(25, 110);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(92, 58);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // PnDesenho
            // 
            this.PnDesenho.BackColor = System.Drawing.Color.White;
            this.PnDesenho.Location = new System.Drawing.Point(549, 22);
            this.PnDesenho.Name = "PnDesenho";
            this.PnDesenho.Size = new System.Drawing.Size(346, 296);
            this.PnDesenho.TabIndex = 4;
            // 
            // CHBApagarDesenho
            // 
            this.CHBApagarDesenho.AutoSize = true;
            this.CHBApagarDesenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBApagarDesenho.ForeColor = System.Drawing.SystemColors.Control;
            this.CHBApagarDesenho.Location = new System.Drawing.Point(549, 346);
            this.CHBApagarDesenho.Name = "CHBApagarDesenho";
            this.CHBApagarDesenho.Size = new System.Drawing.Size(118, 17);
            this.CHBApagarDesenho.TabIndex = 5;
            this.CHBApagarDesenho.Text = "Apagar desenho";
            this.CHBApagarDesenho.UseVisualStyleBackColor = true;
            // 
            // CHBPreencherCirculo
            // 
            this.CHBPreencherCirculo.AutoSize = true;
            this.CHBPreencherCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBPreencherCirculo.ForeColor = System.Drawing.SystemColors.Control;
            this.CHBPreencherCirculo.Location = new System.Drawing.Point(769, 346);
            this.CHBPreencherCirculo.Name = "CHBPreencherCirculo";
            this.CHBPreencherCirculo.Size = new System.Drawing.Size(126, 17);
            this.CHBPreencherCirculo.TabIndex = 6;
            this.CHBPreencherCirculo.Text = "Preencher circulo";
            this.CHBPreencherCirculo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(915, 384);
            this.Controls.Add(this.CHBPreencherCirculo);
            this.Controls.Add(this.CHBApagarDesenho);
            this.Controls.Add(this.PnDesenho);
            this.Controls.Add(this.PROP_CIRCULO);
            this.Controls.Add(this.GBResultado);
            this.Controls.Add(this.CALCULOS);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CALCULADORA CIRCULO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CALCULOS.ResumeLayout(false);
            this.GBResultado.ResumeLayout(false);
            this.GBResultado.PerformLayout();
            this.PROP_CIRCULO.ResumeLayout(false);
            this.PROP_CIRCULO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBArea;
        private System.Windows.Forms.GroupBox CALCULOS;
        private System.Windows.Forms.RadioButton RBVolume;
        private System.Windows.Forms.RadioButton RBPerimetro;
        private System.Windows.Forms.GroupBox GBResultado;
        private System.Windows.Forms.GroupBox PROP_CIRCULO;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRaio;
        private System.Windows.Forms.TextBox LbResposta;
        private System.Windows.Forms.Button BtnDesenhar;
        private System.Windows.Forms.Panel PnDesenho;
        private System.Windows.Forms.CheckBox CHBApagarDesenho;
        private System.Windows.Forms.CheckBox CHBPreencherCirculo;
    }
}

