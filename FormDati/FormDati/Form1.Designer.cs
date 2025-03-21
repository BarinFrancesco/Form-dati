namespace FormDati
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_main = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_textNome = new System.Windows.Forms.Label();
            this.lbl_textAltezza = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.lbl_textPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoFemmina = new System.Windows.Forms.RadioButton();
            this.rdoMaschio = new System.Windows.Forms.RadioButton();
            this.lbl_textSesso = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.rdoVarianza = new System.Windows.Forms.RadioButton();
            this.rdoModa = new System.Windows.Forms.RadioButton();
            this.rdoMedia = new System.Windows.Forms.RadioButton();
            this.rdoMediana = new System.Windows.Forms.RadioButton();
            this.rdoCalcolo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_main
            // 
            this.lst_main.FormattingEnabled = true;
            this.lst_main.ItemHeight = 16;
            this.lst_main.Location = new System.Drawing.Point(86, 128);
            this.lst_main.Name = "lst_main";
            this.lst_main.Size = new System.Drawing.Size(1145, 356);
            this.lst_main.TabIndex = 0;
            this.lst_main.SelectedIndexChanged += new System.EventHandler(this.lst_main_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbl_textNome
            // 
            this.lbl_textNome.AutoSize = true;
            this.lbl_textNome.Location = new System.Drawing.Point(86, 45);
            this.lbl_textNome.Name = "lbl_textNome";
            this.lbl_textNome.Size = new System.Drawing.Size(44, 16);
            this.lbl_textNome.TabIndex = 2;
            this.lbl_textNome.Text = "Nome";
            // 
            // lbl_textAltezza
            // 
            this.lbl_textAltezza.AutoSize = true;
            this.lbl_textAltezza.Location = new System.Drawing.Point(333, 45);
            this.lbl_textAltezza.Name = "lbl_textAltezza";
            this.lbl_textAltezza.Size = new System.Drawing.Size(79, 16);
            this.lbl_textAltezza.TabIndex = 4;
            this.lbl_textAltezza.Text = "Altezza (cm)";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(333, 81);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(183, 22);
            this.txtAltezza.TabIndex = 3;
            this.txtAltezza.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_textPeso
            // 
            this.lbl_textPeso.AutoSize = true;
            this.lbl_textPeso.Location = new System.Drawing.Point(580, 45);
            this.lbl_textPeso.Name = "lbl_textPeso";
            this.lbl_textPeso.Size = new System.Drawing.Size(39, 16);
            this.lbl_textPeso.TabIndex = 6;
            this.lbl_textPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(580, 81);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(183, 22);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rdoFemmina);
            this.panel1.Controls.Add(this.rdoMaschio);
            this.panel1.Location = new System.Drawing.Point(826, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 28);
            this.panel1.TabIndex = 7;
            // 
            // rdoFemmina
            // 
            this.rdoFemmina.AutoSize = true;
            this.rdoFemmina.Location = new System.Drawing.Point(89, 3);
            this.rdoFemmina.Name = "rdoFemmina";
            this.rdoFemmina.Size = new System.Drawing.Size(79, 20);
            this.rdoFemmina.TabIndex = 1;
            this.rdoFemmina.TabStop = true;
            this.rdoFemmina.Text = "femmina";
            this.rdoFemmina.UseVisualStyleBackColor = true;
            this.rdoFemmina.CheckedChanged += new System.EventHandler(this.rdoFemmina_CheckedChanged);
            // 
            // rdoMaschio
            // 
            this.rdoMaschio.AutoSize = true;
            this.rdoMaschio.Location = new System.Drawing.Point(4, 4);
            this.rdoMaschio.Name = "rdoMaschio";
            this.rdoMaschio.Size = new System.Drawing.Size(79, 20);
            this.rdoMaschio.TabIndex = 0;
            this.rdoMaschio.TabStop = true;
            this.rdoMaschio.Text = "maschio";
            this.rdoMaschio.UseVisualStyleBackColor = true;
            this.rdoMaschio.CheckedChanged += new System.EventHandler(this.rdoMaschio_CheckedChanged);
            // 
            // lbl_textSesso
            // 
            this.lbl_textSesso.AutoSize = true;
            this.lbl_textSesso.Location = new System.Drawing.Point(823, 45);
            this.lbl_textSesso.Name = "lbl_textSesso";
            this.lbl_textSesso.Size = new System.Drawing.Size(46, 16);
            this.lbl_textSesso.TabIndex = 8;
            this.lbl_textSesso.Text = "Sesso";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(1114, 25);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(117, 39);
            this.btnSalva.TabIndex = 10;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(1114, 64);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(117, 39);
            this.btnVisualizza.TabIndex = 11;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEsegui);
            this.panel2.Controls.Add(this.rdoVarianza);
            this.panel2.Controls.Add(this.rdoModa);
            this.panel2.Controls.Add(this.rdoMedia);
            this.panel2.Controls.Add(this.rdoMediana);
            this.panel2.Controls.Add(this.rdoCalcolo);
            this.panel2.Location = new System.Drawing.Point(89, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 49);
            this.panel2.TabIndex = 12;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(1022, 5);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(117, 39);
            this.btnEsegui.TabIndex = 13;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // rdoVarianza
            // 
            this.rdoVarianza.AutoSize = true;
            this.rdoVarianza.Location = new System.Drawing.Point(677, 14);
            this.rdoVarianza.Name = "rdoVarianza";
            this.rdoVarianza.Size = new System.Drawing.Size(107, 20);
            this.rdoVarianza.TabIndex = 4;
            this.rdoVarianza.TabStop = true;
            this.rdoVarianza.Text = "Varianza IMC";
            this.rdoVarianza.UseVisualStyleBackColor = true;
            this.rdoVarianza.CheckedChanged += new System.EventHandler(this.rdoVarianza_CheckedChanged);
            // 
            // rdoModa
            // 
            this.rdoModa.AutoSize = true;
            this.rdoModa.Location = new System.Drawing.Point(494, 14);
            this.rdoModa.Name = "rdoModa";
            this.rdoModa.Size = new System.Drawing.Size(89, 20);
            this.rdoModa.TabIndex = 3;
            this.rdoModa.TabStop = true;
            this.rdoModa.Text = "Moda IMC";
            this.rdoModa.UseVisualStyleBackColor = true;
            this.rdoModa.CheckedChanged += new System.EventHandler(this.rdoModa_CheckedChanged);
            // 
            // rdoMedia
            // 
            this.rdoMedia.AutoSize = true;
            this.rdoMedia.Location = new System.Drawing.Point(166, 14);
            this.rdoMedia.Name = "rdoMedia";
            this.rdoMedia.Size = new System.Drawing.Size(92, 20);
            this.rdoMedia.TabIndex = 2;
            this.rdoMedia.TabStop = true;
            this.rdoMedia.Text = "Media IMC";
            this.rdoMedia.UseVisualStyleBackColor = true;
            this.rdoMedia.CheckedChanged += new System.EventHandler(this.rdoMedia_CheckedChanged);
            // 
            // rdoMediana
            // 
            this.rdoMediana.AutoSize = true;
            this.rdoMediana.Location = new System.Drawing.Point(324, 14);
            this.rdoMediana.Name = "rdoMediana";
            this.rdoMediana.Size = new System.Drawing.Size(107, 20);
            this.rdoMediana.TabIndex = 1;
            this.rdoMediana.TabStop = true;
            this.rdoMediana.Text = "Mediana IMC";
            this.rdoMediana.UseVisualStyleBackColor = true;
            this.rdoMediana.CheckedChanged += new System.EventHandler(this.rdoMediana_CheckedChanged);
            // 
            // rdoCalcolo
            // 
            this.rdoCalcolo.AutoSize = true;
            this.rdoCalcolo.Location = new System.Drawing.Point(4, 14);
            this.rdoCalcolo.Name = "rdoCalcolo";
            this.rdoCalcolo.Size = new System.Drawing.Size(100, 20);
            this.rdoCalcolo.TabIndex = 0;
            this.rdoCalcolo.TabStop = true;
            this.rdoCalcolo.Text = "Calcolo IMC";
            this.rdoCalcolo.UseVisualStyleBackColor = true;
            this.rdoCalcolo.CheckedChanged += new System.EventHandler(this.rdoCalcolo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lbl_textSesso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_textPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbl_textAltezza);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.lbl_textNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lst_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_main;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_textNome;
        private System.Windows.Forms.Label lbl_textAltezza;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label lbl_textPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoMaschio;
        private System.Windows.Forms.Label lbl_textSesso;
        private System.Windows.Forms.RadioButton rdoFemmina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.RadioButton rdoVarianza;
        private System.Windows.Forms.RadioButton rdoModa;
        private System.Windows.Forms.RadioButton rdoMedia;
        private System.Windows.Forms.RadioButton rdoMediana;
        private System.Windows.Forms.RadioButton rdoCalcolo;
    }
}

