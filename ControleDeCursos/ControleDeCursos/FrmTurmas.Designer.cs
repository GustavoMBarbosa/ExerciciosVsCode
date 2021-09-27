
namespace ControleDeCursos
{
    partial class FrmTurmas
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpdatainicio = new System.Windows.Forms.DateTimePicker();
            this.dtpdatatermino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgTurma = new System.Windows.Forms.DataGridView();
            this.txthorainicio = new System.Windows.Forms.TextBox();
            this.txthoratermino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbcurso = new System.Windows.Forms.ComboBox();
            this.cbprofessor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(116, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Início:";
            // 
            // dtpdatainicio
            // 
            this.dtpdatainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatainicio.Location = new System.Drawing.Point(116, 40);
            this.dtpdatainicio.Name = "dtpdatainicio";
            this.dtpdatainicio.Size = new System.Drawing.Size(100, 20);
            this.dtpdatainicio.TabIndex = 15;
            // 
            // dtpdatatermino
            // 
            this.dtpdatatermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatatermino.Location = new System.Drawing.Point(347, 40);
            this.dtpdatatermino.Name = "dtpdatatermino";
            this.dtpdatatermino.Size = new System.Drawing.Size(100, 20);
            this.dtpdatatermino.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora: de Término:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(15, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 57);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "CADASTRAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "ALTERAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "LISTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgTurma
            // 
            this.dtgTurma.BackgroundColor = System.Drawing.Color.White;
            this.dtgTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurma.Location = new System.Drawing.Point(15, 228);
            this.dtgTurma.Name = "dtgTurma";
            this.dtgTurma.Size = new System.Drawing.Size(432, 150);
            this.dtgTurma.TabIndex = 22;
            this.dtgTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTurma_CellClick);
            // 
            // txthorainicio
            // 
            this.txthorainicio.Location = new System.Drawing.Point(116, 78);
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.Size = new System.Drawing.Size(100, 20);
            this.txthorainicio.TabIndex = 23;
            // 
            // txthoratermino
            // 
            this.txthoratermino.Location = new System.Drawing.Point(347, 78);
            this.txthoratermino.Name = "txthoratermino";
            this.txthoratermino.Size = new System.Drawing.Size(100, 20);
            this.txthoratermino.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso ID:";
            // 
            // cbcurso
            // 
            this.cbcurso.FormattingEnabled = true;
            this.cbcurso.Location = new System.Drawing.Point(347, 5);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(100, 21);
            this.cbcurso.TabIndex = 26;
            // 
            // cbprofessor
            // 
            this.cbprofessor.FormattingEnabled = true;
            this.cbprofessor.Location = new System.Drawing.Point(116, 114);
            this.cbprofessor.Name = "cbprofessor";
            this.cbprofessor.Size = new System.Drawing.Size(100, 21);
            this.cbprofessor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Professor(a) ID:";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.cbprofessor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbcurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthoratermino);
            this.Controls.Add(this.txthorainicio);
            this.Controls.Add(this.dtgTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpdatatermino);
            this.Controls.Add(this.dtpdatainicio);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protótipo - TURMAS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpdatainicio;
        private System.Windows.Forms.DateTimePicker dtpdatatermino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgTurma;
        private System.Windows.Forms.TextBox txthorainicio;
        private System.Windows.Forms.TextBox txthoratermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbcurso;
        private System.Windows.Forms.ComboBox cbprofessor;
        private System.Windows.Forms.Label label7;
    }
}