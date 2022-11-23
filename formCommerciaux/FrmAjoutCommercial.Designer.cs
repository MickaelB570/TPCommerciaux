
namespace formCommerciaux
{
    partial class FrmAjoutCommercial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_puissance = new System.Windows.Forms.ComboBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_form2_C = new System.Windows.Forms.RadioButton();
            this.rdb_form2_B = new System.Windows.Forms.RadioButton();
            this.rdb_form2_A = new System.Windows.Forms.RadioButton();
            this.btn_form2_valider = new System.Windows.Forms.Button();
            this.lbl_form2_affichage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puissance véhicule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // cbb_puissance
            // 
            this.cbb_puissance.FormattingEnabled = true;
            this.cbb_puissance.Location = new System.Drawing.Point(179, 70);
            this.cbb_puissance.Name = "cbb_puissance";
            this.cbb_puissance.Size = new System.Drawing.Size(191, 24);
            this.cbb_puissance.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(123, 19);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(247, 22);
            this.txt_nom.TabIndex = 4;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(468, 19);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(267, 22);
            this.txt_prenom.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_form2_C);
            this.groupBox1.Controls.Add(this.rdb_form2_B);
            this.groupBox1.Controls.Add(this.rdb_form2_A);
            this.groupBox1.Location = new System.Drawing.Point(410, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégorie";
            // 
            // rdb_form2_C
            // 
            this.rdb_form2_C.AutoSize = true;
            this.rdb_form2_C.Location = new System.Drawing.Point(275, 28);
            this.rdb_form2_C.Name = "rdb_form2_C";
            this.rdb_form2_C.Size = new System.Drawing.Size(38, 21);
            this.rdb_form2_C.TabIndex = 2;
            this.rdb_form2_C.TabStop = true;
            this.rdb_form2_C.Text = "C";
            this.rdb_form2_C.UseVisualStyleBackColor = true;
            this.rdb_form2_C.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdb_form2_B
            // 
            this.rdb_form2_B.AutoSize = true;
            this.rdb_form2_B.Location = new System.Drawing.Point(153, 28);
            this.rdb_form2_B.Name = "rdb_form2_B";
            this.rdb_form2_B.Size = new System.Drawing.Size(38, 21);
            this.rdb_form2_B.TabIndex = 1;
            this.rdb_form2_B.TabStop = true;
            this.rdb_form2_B.Text = "B";
            this.rdb_form2_B.UseVisualStyleBackColor = true;
            // 
            // rdb_form2_A
            // 
            this.rdb_form2_A.AutoSize = true;
            this.rdb_form2_A.Location = new System.Drawing.Point(24, 28);
            this.rdb_form2_A.Name = "rdb_form2_A";
            this.rdb_form2_A.Size = new System.Drawing.Size(38, 21);
            this.rdb_form2_A.TabIndex = 0;
            this.rdb_form2_A.TabStop = true;
            this.rdb_form2_A.Text = "A";
            this.rdb_form2_A.UseVisualStyleBackColor = true;
            // 
            // btn_form2_valider
            // 
            this.btn_form2_valider.Location = new System.Drawing.Point(47, 136);
            this.btn_form2_valider.Name = "btn_form2_valider";
            this.btn_form2_valider.Size = new System.Drawing.Size(125, 43);
            this.btn_form2_valider.TabIndex = 7;
            this.btn_form2_valider.Text = "Valider";
            this.btn_form2_valider.UseVisualStyleBackColor = true;
            this.btn_form2_valider.Click += new System.EventHandler(this.btn_form2_valider_Click);
            // 
            // lbl_form2_affichage
            // 
            this.lbl_form2_affichage.AutoSize = true;
            this.lbl_form2_affichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form2_affichage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_form2_affichage.Location = new System.Drawing.Point(187, 144);
            this.lbl_form2_affichage.Name = "lbl_form2_affichage";
            this.lbl_form2_affichage.Size = new System.Drawing.Size(302, 17);
            this.lbl_form2_affichage.TabIndex = 8;
            this.lbl_form2_affichage.Text = "Veuillez rentrer les informations du commercial";
            // 
            // FrmAjoutCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 191);
            this.Controls.Add(this.lbl_form2_affichage);
            this.Controls.Add(this.btn_form2_valider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.cbb_puissance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutCommercial";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_puissance;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_form2_C;
        private System.Windows.Forms.RadioButton rdb_form2_B;
        private System.Windows.Forms.RadioButton rdb_form2_A;
        private System.Windows.Forms.Button btn_form2_valider;
        private System.Windows.Forms.Label lbl_form2_affichage;
    }
}