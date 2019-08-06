namespace TrouveLeMot
{
    partial class frmConfig
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
            this.listBoxLex = new System.Windows.Forms.ListBox();
            this.txtBoxMot = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLex
            // 
            this.listBoxLex.FormattingEnabled = true;
            this.listBoxLex.Location = new System.Drawing.Point(199, 88);
            this.listBoxLex.Name = "listBoxLex";
            this.listBoxLex.Size = new System.Drawing.Size(229, 316);
            this.listBoxLex.TabIndex = 0;
            // 
            // txtBoxMot
            // 
            this.txtBoxMot.AcceptsReturn = true;
            this.txtBoxMot.Location = new System.Drawing.Point(30, 158);
            this.txtBoxMot.Name = "txtBoxMot";
            this.txtBoxMot.Size = new System.Drawing.Size(163, 20);
            this.txtBoxMot.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter à la liste";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxMot);
            this.Controls.Add(this.listBoxLex);
            this.Name = "frmConfig";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLex;
        private System.Windows.Forms.TextBox txtBoxMot;
        private System.Windows.Forms.Button btnAdd;
    }
}

