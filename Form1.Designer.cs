namespace ADOTpEFM
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
            this.nomDate1 = new ADOTpEFM.NomDate();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomDate1
            // 
            this.nomDate1.dateN = new System.DateTime(2016, 3, 3, 11, 31, 22, 91);
            this.nomDate1.Location = new System.Drawing.Point(49, 29);
            this.nomDate1.Name = "nomDate1";
            this.nomDate1.nom = "";
            this.nomDate1.Size = new System.Drawing.Size(331, 145);
            this.nomDate1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomDate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NomDate nomDate1;
        private System.Windows.Forms.Button button1;
    }
}

