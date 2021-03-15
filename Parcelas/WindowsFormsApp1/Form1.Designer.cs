namespace WindowsFormsApp1
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtparcela = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtvalorparcela = new System.Windows.Forms.TextBox();
            this.btnapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(89, 21);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(154, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Exemplo de codificação em C#";
            this.lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(21, 43);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(47, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Entrada:";
            this.lblnum1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(21, 85);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(37, 13);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Saida:";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(21, 128);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(51, 13);
            this.lblnum3.TabIndex = 3;
            this.lblnum3.Text = "Parcelas:";
            this.lblnum3.Click += new System.EventHandler(this.lblnum3_Click);
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(81, 40);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(109, 20);
            this.txtcompra.TabIndex = 4;
            this.txtcompra.Text = "0";
            this.txtcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcompra.TextChanged += new System.EventHandler(this.txtcompra_TextChanged);
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(81, 82);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(109, 20);
            this.txtentrada.TabIndex = 5;
            this.txtentrada.Text = "0";
            this.txtentrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtparcela
            // 
            this.txtparcela.Location = new System.Drawing.Point(81, 125);
            this.txtparcela.Name = "txtparcela";
            this.txtparcela.Size = new System.Drawing.Size(109, 20);
            this.txtparcela.TabIndex = 6;
            this.txtparcela.Text = "0";
            this.txtparcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(210, 37);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(116, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtvalorparcela
            // 
            this.txtvalorparcela.Location = new System.Drawing.Point(210, 82);
            this.txtvalorparcela.Name = "txtvalorparcela";
            this.txtvalorparcela.Size = new System.Drawing.Size(116, 20);
            this.txtvalorparcela.TabIndex = 8;
            this.txtvalorparcela.Text = "0";
            this.txtvalorparcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvalorparcela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(210, 125);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(116, 23);
            this.btnapagar.TabIndex = 9;
            this.btnapagar.Text = "Apagar Dados";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 156);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.txtvalorparcela);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtparcela);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.TextBox txtparcela;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtvalorparcela;
        private System.Windows.Forms.Button btnapagar;
    }
}

