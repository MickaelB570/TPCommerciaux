
namespace formCommerciaux
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCommercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleNoteDeFraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiualiserLesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.commercialToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // commercialToolStripMenuItem
            // 
            this.commercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauCommercialToolStripMenuItem,
            this.nouvelleNoteDeFraisToolStripMenuItem,
            this.visiualiserLesNotesToolStripMenuItem});
            this.commercialToolStripMenuItem.Name = "commercialToolStripMenuItem";
            this.commercialToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.commercialToolStripMenuItem.Text = "Commercial";
            // 
            // nouveauCommercialToolStripMenuItem
            // 
            this.nouveauCommercialToolStripMenuItem.Name = "nouveauCommercialToolStripMenuItem";
            this.nouveauCommercialToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nouveauCommercialToolStripMenuItem.Text = "Nouveau commercial";
            this.nouveauCommercialToolStripMenuItem.Click += new System.EventHandler(this.nouveauCommercialToolStripMenuItem_Click);
            // 
            // nouvelleNoteDeFraisToolStripMenuItem
            // 
            this.nouvelleNoteDeFraisToolStripMenuItem.Name = "nouvelleNoteDeFraisToolStripMenuItem";
            this.nouvelleNoteDeFraisToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nouvelleNoteDeFraisToolStripMenuItem.Text = "Nouvelle note de frais";
            this.nouvelleNoteDeFraisToolStripMenuItem.Click += new System.EventHandler(this.nouvelleNoteDeFraisToolStripMenuItem_Click);
            // 
            // visiualiserLesNotesToolStripMenuItem
            // 
            this.visiualiserLesNotesToolStripMenuItem.Name = "visiualiserLesNotesToolStripMenuItem";
            this.visiualiserLesNotesToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.visiualiserLesNotesToolStripMenuItem.Text = "Visiualiser les notes ";
            this.visiualiserLesNotesToolStripMenuItem.Click += new System.EventHandler(this.visiualiserLesNotesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauCommercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleNoteDeFraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiualiserLesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

