namespace Premeny
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
            this.vstupj = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vystupj = new System.Windows.Forms.ComboBox();
            this.vstuph = new System.Windows.Forms.TextBox();
            this.vystuph = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.informacia = new System.Windows.Forms.RadioButton();
            this.uhol = new System.Windows.Forms.RadioButton();
            this.praca = new System.Windows.Forms.RadioButton();
            this.sila = new System.Windows.Forms.RadioButton();
            this.hustota = new System.Windows.Forms.RadioButton();
            this.objem = new System.Windows.Forms.RadioButton();
            this.rychlost = new System.Windows.Forms.RadioButton();
            this.vykon = new System.Windows.Forms.RadioButton();
            this.obsah = new System.Windows.Forms.RadioButton();
            this.cas = new System.Windows.Forms.RadioButton();
            this.hmotnost = new System.Windows.Forms.RadioButton();
            this.dlzka = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.autosave = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input.SuspendLayout();
            this.output.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vstupj
            // 
            this.vstupj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vstupj.FormattingEnabled = true;
            this.vstupj.Location = new System.Drawing.Point(215, 5);
            this.vstupj.Name = "vstupj";
            this.vstupj.Size = new System.Drawing.Size(114, 24);
            this.vstupj.TabIndex = 0;
            this.vstupj.SelectedIndexChanged += new System.EventHandler(this.konverzia);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Načítať";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vystupj
            // 
            this.vystupj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vystupj.FormattingEnabled = true;
            this.vystupj.Location = new System.Drawing.Point(215, 5);
            this.vystupj.Name = "vystupj";
            this.vystupj.Size = new System.Drawing.Size(114, 24);
            this.vystupj.TabIndex = 2;
            this.vystupj.SelectedIndexChanged += new System.EventHandler(this.konverzia);
            // 
            // vstuph
            // 
            this.vstuph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstuph.Location = new System.Drawing.Point(18, 5);
            this.vstuph.Name = "vstuph";
            this.vstuph.Size = new System.Drawing.Size(191, 24);
            this.vstuph.TabIndex = 3;
            this.vstuph.TextChanged += new System.EventHandler(this.konverzia);
            // 
            // vystuph
            // 
            this.vystuph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystuph.Location = new System.Drawing.Point(18, 5);
            this.vystuph.Name = "vystuph";
            this.vystuph.Size = new System.Drawing.Size(191, 24);
            this.vystuph.TabIndex = 4;
            // 
            // input
            // 
            this.input.Controls.Add(this.vstupj);
            this.input.Controls.Add(this.vstuph);
            this.input.Location = new System.Drawing.Point(139, 209);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(335, 34);
            this.input.TabIndex = 5;
            this.input.Paint += new System.Windows.Forms.PaintEventHandler(this.input_Paint);
            // 
            // output
            // 
            this.output.Controls.Add(this.vystuph);
            this.output.Controls.Add(this.vystupj);
            this.output.Location = new System.Drawing.Point(139, 269);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(335, 34);
            this.output.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.informacia);
            this.groupBox1.Controls.Add(this.uhol);
            this.groupBox1.Controls.Add(this.praca);
            this.groupBox1.Controls.Add(this.sila);
            this.groupBox1.Controls.Add(this.hustota);
            this.groupBox1.Controls.Add(this.objem);
            this.groupBox1.Controls.Add(this.rychlost);
            this.groupBox1.Controls.Add(this.vykon);
            this.groupBox1.Controls.Add(this.obsah);
            this.groupBox1.Controls.Add(this.cas);
            this.groupBox1.Controls.Add(this.hmotnost);
            this.groupBox1.Controls.Add(this.dlzka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Premieňaná veličina ";
            // 
            // informacia
            // 
            this.informacia.AutoSize = true;
            this.informacia.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informacia.Location = new System.Drawing.Point(363, 75);
            this.informacia.Name = "informacia";
            this.informacia.Size = new System.Drawing.Size(90, 21);
            this.informacia.TabIndex = 11;
            this.informacia.Text = "Informácia";
            this.informacia.UseVisualStyleBackColor = true;
            this.informacia.CheckedChanged += new System.EventHandler(this.informacia_CheckedChanged);
            // 
            // uhol
            // 
            this.uhol.AutoSize = true;
            this.uhol.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uhol.Location = new System.Drawing.Point(363, 37);
            this.uhol.Name = "uhol";
            this.uhol.Size = new System.Drawing.Size(102, 21);
            this.uhol.TabIndex = 10;
            this.uhol.Text = "Rovinný Uhol";
            this.uhol.UseVisualStyleBackColor = true;
            this.uhol.CheckedChanged += new System.EventHandler(this.uhol_CheckedChanged);
            // 
            // praca
            // 
            this.praca.AutoSize = true;
            this.praca.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.praca.Location = new System.Drawing.Point(363, 113);
            this.praca.Name = "praca";
            this.praca.Size = new System.Drawing.Size(61, 21);
            this.praca.TabIndex = 9;
            this.praca.Text = "Práca";
            this.praca.UseVisualStyleBackColor = true;
            this.praca.CheckedChanged += new System.EventHandler(this.praca_CheckedChanged);
            // 
            // sila
            // 
            this.sila.AutoSize = true;
            this.sila.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sila.Location = new System.Drawing.Point(241, 75);
            this.sila.Name = "sila";
            this.sila.Size = new System.Drawing.Size(48, 21);
            this.sila.TabIndex = 8;
            this.sila.Text = "Sila";
            this.sila.UseVisualStyleBackColor = true;
            this.sila.CheckedChanged += new System.EventHandler(this.sila_CheckedChanged);
            // 
            // hustota
            // 
            this.hustota.AutoSize = true;
            this.hustota.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hustota.Location = new System.Drawing.Point(125, 75);
            this.hustota.Name = "hustota";
            this.hustota.Size = new System.Drawing.Size(74, 21);
            this.hustota.TabIndex = 7;
            this.hustota.Text = "Hustota";
            this.hustota.UseVisualStyleBackColor = true;
            this.hustota.CheckedChanged += new System.EventHandler(this.hustota_CheckedChanged);
            // 
            // objem
            // 
            this.objem.AutoSize = true;
            this.objem.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objem.Location = new System.Drawing.Point(241, 37);
            this.objem.Name = "objem";
            this.objem.Size = new System.Drawing.Size(66, 21);
            this.objem.TabIndex = 6;
            this.objem.Text = "Objem";
            this.objem.UseVisualStyleBackColor = true;
            this.objem.CheckedChanged += new System.EventHandler(this.objem_CheckedChanged);
            // 
            // rychlost
            // 
            this.rychlost.AutoSize = true;
            this.rychlost.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rychlost.Location = new System.Drawing.Point(125, 113);
            this.rychlost.Name = "rychlost";
            this.rychlost.Size = new System.Drawing.Size(76, 21);
            this.rychlost.TabIndex = 5;
            this.rychlost.Text = "Rýchlosť";
            this.rychlost.UseVisualStyleBackColor = true;
            this.rychlost.CheckedChanged += new System.EventHandler(this.rychlost_CheckedChanged);
            // 
            // vykon
            // 
            this.vykon.AutoSize = true;
            this.vykon.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vykon.Location = new System.Drawing.Point(241, 113);
            this.vykon.Name = "vykon";
            this.vykon.Size = new System.Drawing.Size(63, 21);
            this.vykon.TabIndex = 4;
            this.vykon.Text = "Výkon";
            this.vykon.UseVisualStyleBackColor = true;
            this.vykon.CheckedChanged += new System.EventHandler(this.vykon_CheckedChanged);
            // 
            // obsah
            // 
            this.obsah.AutoSize = true;
            this.obsah.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obsah.Location = new System.Drawing.Point(125, 37);
            this.obsah.Name = "obsah";
            this.obsah.Size = new System.Drawing.Size(64, 21);
            this.obsah.TabIndex = 3;
            this.obsah.Text = "Obsah";
            this.obsah.UseVisualStyleBackColor = true;
            this.obsah.CheckedChanged += new System.EventHandler(this.obsah_CheckedChanged);
            // 
            // cas
            // 
            this.cas.AutoSize = true;
            this.cas.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cas.Location = new System.Drawing.Point(12, 113);
            this.cas.Name = "cas";
            this.cas.Size = new System.Drawing.Size(48, 21);
            this.cas.TabIndex = 2;
            this.cas.Text = "Čas";
            this.cas.UseVisualStyleBackColor = true;
            this.cas.CheckedChanged += new System.EventHandler(this.cas_CheckedChanged);
            // 
            // hmotnost
            // 
            this.hmotnost.AutoSize = true;
            this.hmotnost.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hmotnost.Location = new System.Drawing.Point(12, 75);
            this.hmotnost.Name = "hmotnost";
            this.hmotnost.Size = new System.Drawing.Size(85, 21);
            this.hmotnost.TabIndex = 1;
            this.hmotnost.Text = "Hmotnosť";
            this.hmotnost.UseVisualStyleBackColor = true;
            this.hmotnost.CheckedChanged += new System.EventHandler(this.hmotnost_CheckedChanged);
            // 
            // dlzka
            // 
            this.dlzka.AutoSize = true;
            this.dlzka.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlzka.Location = new System.Drawing.Point(12, 37);
            this.dlzka.Name = "dlzka";
            this.dlzka.Size = new System.Drawing.Size(60, 21);
            this.dlzka.TabIndex = 0;
            this.dlzka.Text = "Dĺžka";
            this.dlzka.UseVisualStyleBackColor = true;
            this.dlzka.CheckedChanged += new System.EventHandler(this.dlzka_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"txt subory (*.txt)|*.txt";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.Title = "Vyber zdrojovy súbor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(294, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"textovy subor (*.txt)|*.txt";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(134, 412);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(112, 26);
            this.save.TabIndex = 9;
            this.save.Text = "Uložiť";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // autosave
            // 
            this.autosave.AutoSize = true;
            this.autosave.Location = new System.Drawing.Point(21, 351);
            this.autosave.Name = "autosave";
            this.autosave.Size = new System.Drawing.Size(172, 21);
            this.autosave.TabIndex = 10;
            this.autosave.Text = "Automatické ukladanie";
            this.autosave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vstup:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Výstup:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autosave);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vstupj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vystupj;
        private System.Windows.Forms.TextBox vstuph;
        private System.Windows.Forms.TextBox vystuph;
        private System.Windows.Forms.Panel input;
        private System.Windows.Forms.Panel output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sila;
        private System.Windows.Forms.RadioButton hustota;
        private System.Windows.Forms.RadioButton objem;
        private System.Windows.Forms.RadioButton rychlost;
        private System.Windows.Forms.RadioButton vykon;
        private System.Windows.Forms.RadioButton obsah;
        private System.Windows.Forms.RadioButton cas;
        private System.Windows.Forms.RadioButton hmotnost;
        private System.Windows.Forms.RadioButton dlzka;
        private System.Windows.Forms.RadioButton informacia;
        private System.Windows.Forms.RadioButton uhol;
        private System.Windows.Forms.RadioButton praca;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox autosave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

