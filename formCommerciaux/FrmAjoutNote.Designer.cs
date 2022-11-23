
namespace formCommerciaux
{
    partial class FrmAjoutNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_AjoutNote = new System.Windows.Forms.ListBox();
            this.btn_AjoutNote_valider = new System.Windows.Forms.Button();
            this.btn_AjoutNote_Fermer = new System.Windows.Forms.Button();
            this.dtp_AjoutNote = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_AjoutNote_Nuite = new System.Windows.Forms.RadioButton();
            this.rdb_AjoutNote_Repas = new System.Windows.Forms.RadioButton();
            this.rdb_ajoutNote_Transport = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_ajoutNote_nbkm = new System.Windows.Forms.TextBox();
            this.lbl_ajoutNote_nbkm = new System.Windows.Forms.Label();
            this.Nutée = new System.Windows.Forms.GroupBox();
            this.lbl_ajoutNote_prixRepas = new System.Windows.Forms.Label();
            this.txb_ajoutNote_prixRepas = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_ajoutNote_zone3 = new System.Windows.Forms.RadioButton();
            this.rdb_ajoutNote_zone2 = new System.Windows.Forms.RadioButton();
            this.rdb_ajoutNote_zone1 = new System.Windows.Forms.RadioButton();
            this.lbl_ajoutNote_PrixNuitee = new System.Windows.Forms.Label();
            this.txb_ajoutNote_prixNuitee = new System.Windows.Forms.TextBox();
            this.lbl_ajoutnote_verif = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Nutée.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_AjoutNote);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commerciaux";
            // 
            // lst_AjoutNote
            // 
            this.lst_AjoutNote.FormattingEnabled = true;
            this.lst_AjoutNote.ItemHeight = 16;
            this.lst_AjoutNote.Location = new System.Drawing.Point(20, 26);
            this.lst_AjoutNote.Name = "lst_AjoutNote";
            this.lst_AjoutNote.Size = new System.Drawing.Size(231, 68);
            this.lst_AjoutNote.TabIndex = 0;
            // 
            // btn_AjoutNote_valider
            // 
            this.btn_AjoutNote_valider.Location = new System.Drawing.Point(33, 330);
            this.btn_AjoutNote_valider.Name = "btn_AjoutNote_valider";
            this.btn_AjoutNote_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_AjoutNote_valider.TabIndex = 0;
            this.btn_AjoutNote_valider.Text = "Valider";
            this.btn_AjoutNote_valider.UseVisualStyleBackColor = true;
            this.btn_AjoutNote_valider.Click += new System.EventHandler(this.btn_AjoutNote_valider_Click);
            // 
            // btn_AjoutNote_Fermer
            // 
            this.btn_AjoutNote_Fermer.Location = new System.Drawing.Point(167, 330);
            this.btn_AjoutNote_Fermer.Name = "btn_AjoutNote_Fermer";
            this.btn_AjoutNote_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_AjoutNote_Fermer.TabIndex = 1;
            this.btn_AjoutNote_Fermer.Text = "Fermer";
            this.btn_AjoutNote_Fermer.UseVisualStyleBackColor = true;
            this.btn_AjoutNote_Fermer.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtp_AjoutNote
            // 
            this.dtp_AjoutNote.Location = new System.Drawing.Point(70, 157);
            this.dtp_AjoutNote.Name = "dtp_AjoutNote";
            this.dtp_AjoutNote.Size = new System.Drawing.Size(200, 22);
            this.dtp_AjoutNote.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_AjoutNote_Nuite);
            this.groupBox2.Controls.Add(this.rdb_AjoutNote_Repas);
            this.groupBox2.Controls.Add(this.rdb_ajoutNote_Transport);
            this.groupBox2.Location = new System.Drawing.Point(13, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type de note";
            // 
            // rdb_AjoutNote_Nuite
            // 
            this.rdb_AjoutNote_Nuite.AutoSize = true;
            this.rdb_AjoutNote_Nuite.Location = new System.Drawing.Point(189, 39);
            this.rdb_AjoutNote_Nuite.Name = "rdb_AjoutNote_Nuite";
            this.rdb_AjoutNote_Nuite.Size = new System.Drawing.Size(62, 21);
            this.rdb_AjoutNote_Nuite.TabIndex = 2;
            this.rdb_AjoutNote_Nuite.TabStop = true;
            this.rdb_AjoutNote_Nuite.Text = "Nuité";
            this.rdb_AjoutNote_Nuite.UseVisualStyleBackColor = true;
            this.rdb_AjoutNote_Nuite.CheckedChanged += new System.EventHandler(this.rdb_AjoutNote_Nuite_CheckedChanged);
            // 
            // rdb_AjoutNote_Repas
            // 
            this.rdb_AjoutNote_Repas.AutoSize = true;
            this.rdb_AjoutNote_Repas.Location = new System.Drawing.Point(110, 39);
            this.rdb_AjoutNote_Repas.Name = "rdb_AjoutNote_Repas";
            this.rdb_AjoutNote_Repas.Size = new System.Drawing.Size(70, 21);
            this.rdb_AjoutNote_Repas.TabIndex = 1;
            this.rdb_AjoutNote_Repas.TabStop = true;
            this.rdb_AjoutNote_Repas.Text = "Repas";
            this.rdb_AjoutNote_Repas.UseVisualStyleBackColor = true;
            this.rdb_AjoutNote_Repas.CheckedChanged += new System.EventHandler(this.rdb_AjoutNote_Repas_CheckedChanged);
            // 
            // rdb_ajoutNote_Transport
            // 
            this.rdb_ajoutNote_Transport.AutoSize = true;
            this.rdb_ajoutNote_Transport.Location = new System.Drawing.Point(20, 39);
            this.rdb_ajoutNote_Transport.Name = "rdb_ajoutNote_Transport";
            this.rdb_ajoutNote_Transport.Size = new System.Drawing.Size(84, 21);
            this.rdb_ajoutNote_Transport.TabIndex = 0;
            this.rdb_ajoutNote_Transport.TabStop = true;
            this.rdb_ajoutNote_Transport.Text = "Tranport";
            this.rdb_ajoutNote_Transport.UseVisualStyleBackColor = true;
            this.rdb_ajoutNote_Transport.CheckedChanged += new System.EventHandler(this.rdb_ajoutNote_Transport_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_ajoutNote_nbkm);
            this.groupBox3.Controls.Add(this.lbl_ajoutNote_nbkm);
            this.groupBox3.Location = new System.Drawing.Point(447, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transport";
            // 
            // txb_ajoutNote_nbkm
            // 
            this.txb_ajoutNote_nbkm.Location = new System.Drawing.Point(10, 42);
            this.txb_ajoutNote_nbkm.Name = "txb_ajoutNote_nbkm";
            this.txb_ajoutNote_nbkm.Size = new System.Drawing.Size(184, 22);
            this.txb_ajoutNote_nbkm.TabIndex = 1;
            // 
            // lbl_ajoutNote_nbkm
            // 
            this.lbl_ajoutNote_nbkm.AutoSize = true;
            this.lbl_ajoutNote_nbkm.Location = new System.Drawing.Point(7, 22);
            this.lbl_ajoutNote_nbkm.Name = "lbl_ajoutNote_nbkm";
            this.lbl_ajoutNote_nbkm.Size = new System.Drawing.Size(139, 17);
            this.lbl_ajoutNote_nbkm.TabIndex = 0;
            this.lbl_ajoutNote_nbkm.Text = "Nombre de kilomètre";
            // 
            // Nutée
            // 
            this.Nutée.Controls.Add(this.lbl_ajoutNote_prixRepas);
            this.Nutée.Controls.Add(this.txb_ajoutNote_prixRepas);
            this.Nutée.Location = new System.Drawing.Point(447, 147);
            this.Nutée.Name = "Nutée";
            this.Nutée.Size = new System.Drawing.Size(200, 100);
            this.Nutée.TabIndex = 0;
            this.Nutée.TabStop = false;
            this.Nutée.Text = "Repas";
            // 
            // lbl_ajoutNote_prixRepas
            // 
            this.lbl_ajoutNote_prixRepas.AutoSize = true;
            this.lbl_ajoutNote_prixRepas.Location = new System.Drawing.Point(7, 33);
            this.lbl_ajoutNote_prixRepas.Name = "lbl_ajoutNote_prixRepas";
            this.lbl_ajoutNote_prixRepas.Size = new System.Drawing.Size(91, 17);
            this.lbl_ajoutNote_prixRepas.TabIndex = 2;
            this.lbl_ajoutNote_prixRepas.Text = "Prix du repas";
            // 
            // txb_ajoutNote_prixRepas
            // 
            this.txb_ajoutNote_prixRepas.Location = new System.Drawing.Point(10, 53);
            this.txb_ajoutNote_prixRepas.Name = "txb_ajoutNote_prixRepas";
            this.txb_ajoutNote_prixRepas.Size = new System.Drawing.Size(184, 22);
            this.txb_ajoutNote_prixRepas.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_ajoutNote_zone3);
            this.groupBox5.Controls.Add(this.rdb_ajoutNote_zone2);
            this.groupBox5.Controls.Add(this.rdb_ajoutNote_zone1);
            this.groupBox5.Controls.Add(this.lbl_ajoutNote_PrixNuitee);
            this.groupBox5.Controls.Add(this.txb_ajoutNote_prixNuitee);
            this.groupBox5.Location = new System.Drawing.Point(447, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nuitée";
            // 
            // rdb_ajoutNote_zone3
            // 
            this.rdb_ajoutNote_zone3.AutoSize = true;
            this.rdb_ajoutNote_zone3.Location = new System.Drawing.Point(160, 73);
            this.rdb_ajoutNote_zone3.Name = "rdb_ajoutNote_zone3";
            this.rdb_ajoutNote_zone3.Size = new System.Drawing.Size(74, 21);
            this.rdb_ajoutNote_zone3.TabIndex = 11;
            this.rdb_ajoutNote_zone3.TabStop = true;
            this.rdb_ajoutNote_zone3.Text = "Zone 3";
            this.rdb_ajoutNote_zone3.UseVisualStyleBackColor = true;
            this.rdb_ajoutNote_zone3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdb_ajoutNote_zone2
            // 
            this.rdb_ajoutNote_zone2.AutoSize = true;
            this.rdb_ajoutNote_zone2.Location = new System.Drawing.Point(80, 73);
            this.rdb_ajoutNote_zone2.Name = "rdb_ajoutNote_zone2";
            this.rdb_ajoutNote_zone2.Size = new System.Drawing.Size(74, 21);
            this.rdb_ajoutNote_zone2.TabIndex = 10;
            this.rdb_ajoutNote_zone2.TabStop = true;
            this.rdb_ajoutNote_zone2.Text = "Zone 2";
            this.rdb_ajoutNote_zone2.UseVisualStyleBackColor = true;
            // 
            // rdb_ajoutNote_zone1
            // 
            this.rdb_ajoutNote_zone1.AutoSize = true;
            this.rdb_ajoutNote_zone1.Location = new System.Drawing.Point(0, 73);
            this.rdb_ajoutNote_zone1.Name = "rdb_ajoutNote_zone1";
            this.rdb_ajoutNote_zone1.Size = new System.Drawing.Size(74, 21);
            this.rdb_ajoutNote_zone1.TabIndex = 9;
            this.rdb_ajoutNote_zone1.TabStop = true;
            this.rdb_ajoutNote_zone1.Text = "Zone 1";
            this.rdb_ajoutNote_zone1.UseVisualStyleBackColor = true;
            // 
            // lbl_ajoutNote_PrixNuitee
            // 
            this.lbl_ajoutNote_PrixNuitee.AutoSize = true;
            this.lbl_ajoutNote_PrixNuitee.Location = new System.Drawing.Point(7, 18);
            this.lbl_ajoutNote_PrixNuitee.Name = "lbl_ajoutNote_PrixNuitee";
            this.lbl_ajoutNote_PrixNuitee.Size = new System.Drawing.Size(101, 17);
            this.lbl_ajoutNote_PrixNuitee.TabIndex = 8;
            this.lbl_ajoutNote_PrixNuitee.Text = "Prix de la nuité";
            // 
            // txb_ajoutNote_prixNuitee
            // 
            this.txb_ajoutNote_prixNuitee.Location = new System.Drawing.Point(8, 39);
            this.txb_ajoutNote_prixNuitee.Name = "txb_ajoutNote_prixNuitee";
            this.txb_ajoutNote_prixNuitee.Size = new System.Drawing.Size(184, 22);
            this.txb_ajoutNote_prixNuitee.TabIndex = 7;
            // 
            // lbl_ajoutnote_verif
            // 
            this.lbl_ajoutnote_verif.AutoSize = true;
            this.lbl_ajoutnote_verif.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutnote_verif.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_ajoutnote_verif.Location = new System.Drawing.Point(13, 297);
            this.lbl_ajoutnote_verif.Name = "lbl_ajoutnote_verif";
            this.lbl_ajoutnote_verif.Size = new System.Drawing.Size(80, 9);
            this.lbl_ajoutnote_verif.TabIndex = 1;
            this.lbl_ajoutnote_verif.Text = "*************************";
            // 
            // FrmAjoutNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 374);
            this.Controls.Add(this.lbl_ajoutnote_verif);
            this.Controls.Add(this.Nutée);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtp_AjoutNote);
            this.Controls.Add(this.btn_AjoutNote_Fermer);
            this.Controls.Add(this.btn_AjoutNote_valider);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAjoutNote";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Nutée.ResumeLayout(false);
            this.Nutée.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_AjoutNote;
        private System.Windows.Forms.Button btn_AjoutNote_valider;
        private System.Windows.Forms.Button btn_AjoutNote_Fermer;
        private System.Windows.Forms.DateTimePicker dtp_AjoutNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_AjoutNote_Nuite;
        private System.Windows.Forms.RadioButton rdb_AjoutNote_Repas;
        private System.Windows.Forms.RadioButton rdb_ajoutNote_Transport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txb_ajoutNote_nbkm;
        private System.Windows.Forms.Label lbl_ajoutNote_nbkm;
        private System.Windows.Forms.GroupBox Nutée;
        private System.Windows.Forms.Label lbl_ajoutNote_prixRepas;
        private System.Windows.Forms.TextBox txb_ajoutNote_prixRepas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_ajoutNote_zone3;
        private System.Windows.Forms.RadioButton rdb_ajoutNote_zone2;
        private System.Windows.Forms.RadioButton rdb_ajoutNote_zone1;
        private System.Windows.Forms.Label lbl_ajoutNote_PrixNuitee;
        private System.Windows.Forms.TextBox txb_ajoutNote_prixNuitee;
        private System.Windows.Forms.Label lbl_ajoutnote_verif;
    }
}