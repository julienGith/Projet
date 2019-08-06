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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lexiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lexiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // lexiqueBindingSource1
            // 
            this.lexiqueBindingSource1.DataSource = typeof(TrouveLeMot.Lexique);
            // 
            // lexiqueBindingSource
            // 
            this.lexiqueBindingSource.DataSource = typeof(TrouveLeMot.Lexique);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmConfig";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexiqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource lexiqueBindingSource;
        private System.Windows.Forms.BindingSource lexiqueBindingSource1;
    }
}

