﻿namespace ADOTpEFM
{
    partial class NomDate
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Tnom = new System.Windows.Forms.TextBox();
            this.datePi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "dateD";
            // 
            // Tnom
            // 
            this.Tnom.Location = new System.Drawing.Point(115, 40);
            this.Tnom.Name = "Tnom";
            this.Tnom.Size = new System.Drawing.Size(186, 20);
            this.Tnom.TabIndex = 2;
            // 
            // datePi
            // 
            this.datePi.Location = new System.Drawing.Point(115, 78);
            this.datePi.Name = "datePi";
            this.datePi.Size = new System.Drawing.Size(186, 20);
            this.datePi.TabIndex = 5;
            // 
            // NomDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePi);
            this.Controls.Add(this.Tnom);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Name = "NomDate";
            this.Size = new System.Drawing.Size(331, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox Tnom;
        private System.Windows.Forms.DateTimePicker datePi;
    }
}
