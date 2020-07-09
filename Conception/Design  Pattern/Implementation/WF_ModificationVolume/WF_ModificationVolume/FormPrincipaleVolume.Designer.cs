namespace WF_ModificationVolume
{
    partial class FormPrincipaleVolume
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
            this.ValiderChangerVolume = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbChangerVolume = new System.Windows.Forms.TextBox();
            this.ProgressBarVolume = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ValiderChangerVolume
            // 
            this.ValiderChangerVolume.Location = new System.Drawing.Point(12, 12);
            this.ValiderChangerVolume.Name = "ValiderChangerVolume";
            this.ValiderChangerVolume.Size = new System.Drawing.Size(75, 23);
            this.ValiderChangerVolume.TabIndex = 0;
            this.ValiderChangerVolume.Text = "Valider";
            this.ValiderChangerVolume.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbChangerVolume
            // 
            this.tbChangerVolume.Location = new System.Drawing.Point(93, 12);
            this.tbChangerVolume.Name = "tbChangerVolume";
            this.tbChangerVolume.Size = new System.Drawing.Size(156, 20);
            this.tbChangerVolume.TabIndex = 3;
            // 
            // ProgressBarVolume
            // 
            this.ProgressBarVolume.Location = new System.Drawing.Point(12, 99);
            this.ProgressBarVolume.Maximum = 500;
            this.ProgressBarVolume.Name = "ProgressBarVolume";
            this.ProgressBarVolume.Size = new System.Drawing.Size(237, 23);
            this.ProgressBarVolume.TabIndex = 4;
            // 
            // FormPrincipaleVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.ProgressBarVolume);
            this.Controls.Add(this.tbChangerVolume);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ValiderChangerVolume);
            this.Name = "FormPrincipaleVolume";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipaleVolume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValiderChangerVolume;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbChangerVolume;
        private System.Windows.Forms.ProgressBar ProgressBarVolume;
    }
}

