
namespace formCommerciaux
{
    partial class FrmVisualiserNote
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
            this.lst_VisualiserNote_Commerciaux = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_VisualiserNote = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_VisualiserNote_Commerciaux);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commerciaux";
            // 
            // lst_VisualiserNote_Commerciaux
            // 
            this.lst_VisualiserNote_Commerciaux.FormattingEnabled = true;
            this.lst_VisualiserNote_Commerciaux.ItemHeight = 16;
            this.lst_VisualiserNote_Commerciaux.Location = new System.Drawing.Point(26, 26);
            this.lst_VisualiserNote_Commerciaux.Name = "lst_VisualiserNote_Commerciaux";
            this.lst_VisualiserNote_Commerciaux.Size = new System.Drawing.Size(573, 84);
            this.lst_VisualiserNote_Commerciaux.TabIndex = 0;
            this.lst_VisualiserNote_Commerciaux.SelectedIndexChanged += new System.EventHandler(this.lst_VisualiserNote_Commerciaux_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_VisualiserNote);
            this.groupBox2.Location = new System.Drawing.Point(23, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes de frais";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_VisualiserNote
            // 
            this.lst_VisualiserNote.FormattingEnabled = true;
            this.lst_VisualiserNote.ItemHeight = 16;
            this.lst_VisualiserNote.Location = new System.Drawing.Point(26, 31);
            this.lst_VisualiserNote.Name = "lst_VisualiserNote";
            this.lst_VisualiserNote.Size = new System.Drawing.Size(573, 148);
            this.lst_VisualiserNote.TabIndex = 0;
            // 
            // FrmVisualiserNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVisualiserNote";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_VisualiserNote_Commerciaux;
        private System.Windows.Forms.ListBox lst_VisualiserNote;
    }
}