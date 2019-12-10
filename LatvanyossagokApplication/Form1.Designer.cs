namespace LatvanyossagokApplication
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
        private void InitializeComponent()
        {
            this.VarosLakossag = new System.Windows.Forms.NumericUpDown();
            this.VarosNeve = new System.Windows.Forms.TextBox();
            this.varos_hozzad_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LatvanyossagNeve = new System.Windows.Forms.TextBox();
            this.LatvanyossagAra = new System.Windows.Forms.NumericUpDown();
            this.latvanyossag_hozzad_btn = new System.Windows.Forms.Button();
            this.VarosNeveComboBox = new System.Windows.Forms.ComboBox();
            this.LatvanyossagLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VarosokLista = new System.Windows.Forms.ListBox();
            this.btn_varos_torles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VarosLakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatvanyossagAra)).BeginInit();
            this.SuspendLayout();
            // 
            // VarosLakossag
            // 
            this.VarosLakossag.Location = new System.Drawing.Point(12, 256);
            this.VarosLakossag.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.VarosLakossag.Name = "VarosLakossag";
            this.VarosLakossag.Size = new System.Drawing.Size(120, 20);
            this.VarosLakossag.TabIndex = 0;
            // 
            // VarosNeve
            // 
            this.VarosNeve.Location = new System.Drawing.Point(12, 230);
            this.VarosNeve.Name = "VarosNeve";
            this.VarosNeve.Size = new System.Drawing.Size(120, 20);
            this.VarosNeve.TabIndex = 1;
            this.VarosNeve.Tag = "";
            // 
            // varos_hozzad_btn
            // 
            this.varos_hozzad_btn.Location = new System.Drawing.Point(12, 282);
            this.varos_hozzad_btn.Name = "varos_hozzad_btn";
            this.varos_hozzad_btn.Size = new System.Drawing.Size(120, 23);
            this.varos_hozzad_btn.TabIndex = 2;
            this.varos_hozzad_btn.Text = "Város hozzáad";
            this.varos_hozzad_btn.UseVisualStyleBackColor = true;
            this.varos_hozzad_btn.Click += new System.EventHandler(this.varos_hozzad_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Város hozzáadása";
            // 
            // LatvanyossagNeve
            // 
            this.LatvanyossagNeve.Location = new System.Drawing.Point(341, 230);
            this.LatvanyossagNeve.Name = "LatvanyossagNeve";
            this.LatvanyossagNeve.Size = new System.Drawing.Size(137, 20);
            this.LatvanyossagNeve.TabIndex = 4;
            // 
            // LatvanyossagAra
            // 
            this.LatvanyossagAra.Location = new System.Drawing.Point(341, 256);
            this.LatvanyossagAra.Name = "LatvanyossagAra";
            this.LatvanyossagAra.Size = new System.Drawing.Size(137, 20);
            this.LatvanyossagAra.TabIndex = 5;
            // 
            // latvanyossag_hozzad_btn
            // 
            this.latvanyossag_hozzad_btn.Location = new System.Drawing.Point(341, 309);
            this.latvanyossag_hozzad_btn.Name = "latvanyossag_hozzad_btn";
            this.latvanyossag_hozzad_btn.Size = new System.Drawing.Size(137, 23);
            this.latvanyossag_hozzad_btn.TabIndex = 6;
            this.latvanyossag_hozzad_btn.Text = "Látávnyosság hozzáad";
            this.latvanyossag_hozzad_btn.UseVisualStyleBackColor = true;
            this.latvanyossag_hozzad_btn.Click += new System.EventHandler(this.latvanyossag_hozzad_btn_Click);
            // 
            // VarosNeveComboBox
            // 
            this.VarosNeveComboBox.FormattingEnabled = true;
            this.VarosNeveComboBox.Location = new System.Drawing.Point(341, 282);
            this.VarosNeveComboBox.Name = "VarosNeveComboBox";
            this.VarosNeveComboBox.Size = new System.Drawing.Size(137, 21);
            this.VarosNeveComboBox.TabIndex = 7;
            // 
            // LatvanyossagLista
            // 
            this.LatvanyossagLista.FormattingEnabled = true;
            this.LatvanyossagLista.Location = new System.Drawing.Point(341, 12);
            this.LatvanyossagLista.Name = "LatvanyossagLista";
            this.LatvanyossagLista.Size = new System.Drawing.Size(272, 199);
            this.LatvanyossagLista.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Látványosság hozzáadása";
            // 
            // VarosokLista
            // 
            this.VarosokLista.FormattingEnabled = true;
            this.VarosokLista.Location = new System.Drawing.Point(12, 12);
            this.VarosokLista.Name = "VarosokLista";
            this.VarosokLista.Size = new System.Drawing.Size(291, 199);
            this.VarosokLista.TabIndex = 10;
            // 
            // btn_varos_torles
            // 
            this.btn_varos_torles.Location = new System.Drawing.Point(189, 227);
            this.btn_varos_torles.Name = "btn_varos_torles";
            this.btn_varos_torles.Size = new System.Drawing.Size(114, 23);
            this.btn_varos_torles.TabIndex = 11;
            this.btn_varos_torles.Text = "Város törlése";
            this.btn_varos_torles.UseVisualStyleBackColor = true;
            this.btn_varos_torles.Click += new System.EventHandler(this.btn_varos_torles_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(625, 418);
            this.Controls.Add(this.btn_varos_torles);
            this.Controls.Add(this.VarosokLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LatvanyossagLista);
            this.Controls.Add(this.VarosNeveComboBox);
            this.Controls.Add(this.latvanyossag_hozzad_btn);
            this.Controls.Add(this.LatvanyossagAra);
            this.Controls.Add(this.LatvanyossagNeve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varos_hozzad_btn);
            this.Controls.Add(this.VarosNeve);
            this.Controls.Add(this.VarosLakossag);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VarosLakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatvanyossagAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown VarosLakossag;
        private System.Windows.Forms.TextBox VarosNeve;
        private System.Windows.Forms.Button varos_hozzad_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LatvanyossagNeve;
        private System.Windows.Forms.NumericUpDown LatvanyossagAra;
        private System.Windows.Forms.Button latvanyossag_hozzad_btn;
        private System.Windows.Forms.ComboBox VarosNeveComboBox;
        private System.Windows.Forms.ListBox LatvanyossagLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox VarosokLista;
        private System.Windows.Forms.Button btn_varos_torles;
    }
}

