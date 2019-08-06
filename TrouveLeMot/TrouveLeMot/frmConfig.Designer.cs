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
            this.components = new System.ComponentModel.Container();
            this.listBoxLex = new System.Windows.Forms.ListBox();
            this.lexiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxMot = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lexiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource1)).BeginInit();
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
            // lexiqueBindingSource
            // 
            this.lexiqueBindingSource.DataSource = typeof(TrouveLeMot.Lexique);
            // 
            // txtBoxMot
            // 
            this.txtBoxMot.AcceptsReturn = true;
            this.txtBoxMot.Location = new System.Drawing.Point(30, 158);
            this.txtBoxMot.Name = "txtBoxMot";
            this.txtBoxMot.Size = new System.Drawing.Size(163, 20);
            this.txtBoxMot.TabIndex = 1;
            this.txtBoxMot.TextChanged += new System.EventHandler(this.TxtBoxMot_TextChanged);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Sauvegarder la liste";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(199, 59);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Charger la liste";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lexiqueBindingSource1
            // 
            this.lexiqueBindingSource1.DataSource = typeof(TrouveLeMot.Lexique);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxMot);
            this.Controls.Add(this.listBoxLex);
            this.Name = "frmConfig";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLex;
        private System.Windows.Forms.TextBox txtBoxMot;
        private System.Windows.Forms.BindingSource lexiqueBindingSource;
        private System.Windows.Forms.BindingSource lexiqueBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

