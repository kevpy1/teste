namespace teste
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
            System.Windows.Forms.ComboBox comboBox3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label cmbtpye;
            System.Windows.Forms.ComboBox comboBox4;
            System.Windows.Forms.Label lbklQuart;
            System.Windows.Forms.ComboBox comboBox5;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.ComboBox comboBox6;
            System.Windows.Forms.Label label6;
            this.lpl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbobjec = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbtye = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cmbtpye = new System.Windows.Forms.Label();
            comboBox4 = new System.Windows.Forms.ComboBox();
            lbklQuart = new System.Windows.Forms.Label();
            comboBox5 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            comboBox6 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lpl
            // 
            this.lpl.AutoSize = true;
            this.lpl.Enabled = false;
            this.lpl.Location = new System.Drawing.Point(31, 43);
            this.lpl.Name = "lpl";
            this.lpl.Size = new System.Drawing.Size(36, 13);
            this.lpl.TabIndex = 0;
            this.lpl.Text = "marca";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "modelo";
            // 
            // cmbobjec
            // 
            this.cmbobjec.FormattingEnabled = true;
            this.cmbobjec.Items.AddRange(new object[] {
            "VENDA",
            "LOCAÇÃO"});
            this.cmbobjec.Location = new System.Drawing.Point(34, 124);
            this.cmbobjec.Name = "cmbobjec";
            this.cmbobjec.Size = new System.Drawing.Size(121, 21);
            this.cmbobjec.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(34, 233);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(139, 21);
            comboBox3.TabIndex = 7;
            comboBox3.Visible = false;
            comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new System.Drawing.Point(31, 217);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(22, 13);
            label4.TabIndex = 6;
            label4.Text = "até";
            label4.Visible = false;
            // 
            // cmbtpye
            // 
            cmbtpye.AutoSize = true;
            cmbtpye.Enabled = false;
            cmbtpye.Location = new System.Drawing.Point(31, 164);
            cmbtpye.Name = "cmbtpye";
            cmbtpye.Size = new System.Drawing.Size(25, 13);
            cmbtpye.TabIndex = 8;
            cmbtpye.Text = "ano";
            cmbtpye.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(comboBox6);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(comboBox5);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(lbklQuart);
            this.panel2.Controls.Add(comboBox4);
            this.panel2.Location = new System.Drawing.Point(420, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 182);
            this.panel2.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(6, 32);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(139, 21);
            comboBox4.TabIndex = 12;
            comboBox4.Visible = false;
            comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lbklQuart
            // 
            lbklQuart.AutoSize = true;
            lbklQuart.Enabled = false;
            lbklQuart.Location = new System.Drawing.Point(3, 16);
            lbklQuart.Name = "lbklQuart";
            lbklQuart.Size = new System.Drawing.Size(44, 13);
            lbklQuart.TabIndex = 11;
            lbklQuart.Text = "Quartos";
            lbklQuart.Visible = false;
            lbklQuart.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new System.Drawing.Point(6, 79);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(139, 21);
            comboBox5.TabIndex = 14;
            comboBox5.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new System.Drawing.Point(3, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 13);
            label5.TabIndex = 13;
            label5.Text = "Banheiro";
            label5.Visible = false;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new System.Drawing.Point(6, 123);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new System.Drawing.Size(139, 21);
            comboBox6.TabIndex = 16;
            comboBox6.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new System.Drawing.Point(3, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 13);
            label6.TabIndex = 15;
            label6.Text = "vagas";
            label6.Visible = false;
            // 
            // cmbtye
            // 
            this.cmbtye.FormattingEnabled = true;
            this.cmbtye.Location = new System.Drawing.Point(34, 179);
            this.cmbtye.Name = "cmbtye";
            this.cmbtye.Size = new System.Drawing.Size(121, 21);
            this.cmbtye.TabIndex = 12;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbtye);
            this.Controls.Add(this.panel2);
            this.Controls.Add(cmbtpye);
            this.Controls.Add(comboBox3);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbobjec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lpl);
            this.Name = "Form1";
            this.Text = "cod1";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbobjec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbtye;
    }
}

