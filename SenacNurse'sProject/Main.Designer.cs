namespace SenacNurse_sProject
{
    partial class Main
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
            this.lsbtop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbl = new System.Windows.Forms.Panel();
            this.lsbr = new System.Windows.Forms.Panel();
            this.lsbc = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbtop.SuspendLayout();
            this.lsbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbtop
            // 
            this.lsbtop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsbtop.Controls.Add(this.label1);
            this.lsbtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbtop.Location = new System.Drawing.Point(0, 0);
            this.lsbtop.Name = "lsbtop";
            this.lsbtop.Size = new System.Drawing.Size(858, 188);
            this.lsbtop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(157, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Bem vindo ao sistema gerenciador de\r\n                   estoque de enferm" +
    "agem\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lsbl
            // 
            this.lsbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbl.Location = new System.Drawing.Point(0, 188);
            this.lsbl.Name = "lsbl";
            this.lsbl.Size = new System.Drawing.Size(200, 354);
            this.lsbl.TabIndex = 2;
            // 
            // lsbr
            // 
            this.lsbr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsbr.Location = new System.Drawing.Point(658, 188);
            this.lsbr.Name = "lsbr";
            this.lsbr.Size = new System.Drawing.Size(200, 354);
            this.lsbr.TabIndex = 0;
            // 
            // lsbc
            // 
            this.lsbc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsbc.Controls.Add(this.button5);
            this.lsbc.Controls.Add(this.button4);
            this.lsbc.Controls.Add(this.button3);
            this.lsbc.Controls.Add(this.button2);
            this.lsbc.Controls.Add(this.button1);
            this.lsbc.Controls.Add(this.label4);
            this.lsbc.Controls.Add(this.label2);
            this.lsbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbc.Location = new System.Drawing.Point(200, 188);
            this.lsbc.Name = "lsbc";
            this.lsbc.Size = new System.Drawing.Size(458, 354);
            this.lsbc.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(140, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "Adicionar item";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(140, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 35);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(140, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Visualizar itens";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(140, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usar item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(140, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar novo item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label4.Location = new System.Drawing.Point(169, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selecione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(176, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 542);
            this.Controls.Add(this.lsbc);
            this.Controls.Add(this.lsbr);
            this.Controls.Add(this.lsbl);
            this.Controls.Add(this.lsbtop);
            this.Name = "Main";
            this.Text = "SGEF";
            this.Load += new System.EventHandler(this.Main_Load);
            this.lsbtop.ResumeLayout(false);
            this.lsbtop.PerformLayout();
            this.lsbc.ResumeLayout(false);
            this.lsbc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lsbtop;
        private System.Windows.Forms.Panel lsbl;
        private System.Windows.Forms.Panel lsbr;
        private System.Windows.Forms.Panel lsbc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

