namespace SenacNurse_sProject
{
    partial class AddTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.TextBoxAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteNameLabel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewAddDelete = new System.Windows.Forms.DataGridView();
            this.DeleteLabelID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(44, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.dataGridViewAddDelete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxAddQuantity);
            this.panel1.Controls.Add(this.DeleteLabelID);
            this.panel1.Controls.Add(this.DeleteNameLabel);
            this.panel1.Controls.Add(this.TextBoxAddName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 552);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(70, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 114);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(76, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adicionar";
            // 
            // textBoxAddQuantity
            // 
            this.textBoxAddQuantity.Location = new System.Drawing.Point(67, 281);
            this.textBoxAddQuantity.Name = "textBoxAddQuantity";
            this.textBoxAddQuantity.Size = new System.Drawing.Size(241, 22);
            this.textBoxAddQuantity.TabIndex = 1;
            this.textBoxAddQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // TextBoxAddName
            // 
            this.TextBoxAddName.Location = new System.Drawing.Point(64, 178);
            this.TextBoxAddName.Name = "TextBoxAddName";
            this.TextBoxAddName.Size = new System.Drawing.Size(241, 22);
            this.TextBoxAddName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(124, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(78, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1047, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 51);
            this.label6.TabIndex = 0;
            this.label6.Text = "Remover";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1107, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome";
            // 
            // DeleteNameLabel
            // 
            this.DeleteNameLabel.Location = new System.Drawing.Point(1042, 178);
            this.DeleteNameLabel.Name = "DeleteNameLabel";
            this.DeleteNameLabel.Size = new System.Drawing.Size(241, 22);
            this.DeleteNameLabel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1045, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteBottom_Click);
            // 
            // dataGridViewAddDelete
            // 
            this.dataGridViewAddDelete.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewAddDelete.ColumnHeadersHeight = 25;
            this.dataGridViewAddDelete.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridViewAddDelete.Location = new System.Drawing.Point(339, 109);
            this.dataGridViewAddDelete.Name = "dataGridViewAddDelete";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddDelete.RowHeadersWidth = 51;
            this.dataGridViewAddDelete.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAddDelete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAddDelete.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAddDelete.RowTemplate.Height = 40;
            this.dataGridViewAddDelete.Size = new System.Drawing.Size(675, 431);
            this.dataGridViewAddDelete.TabIndex = 4;
            // 
            // DeleteLabelID
            // 
            this.DeleteLabelID.Location = new System.Drawing.Point(1042, 281);
            this.DeleteLabelID.Name = "DeleteLabelID";
            this.DeleteLabelID.Size = new System.Drawing.Size(241, 22);
            this.DeleteLabelID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(1135, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "AddTable";
            this.Text = "Adicionar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAddQuantity;
        private System.Windows.Forms.TextBox TextBoxAddName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAddDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DeleteNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeleteLabelID;
        private System.Windows.Forms.Label label8;
    }
}