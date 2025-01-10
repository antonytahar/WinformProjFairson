namespace WinformProjFairson
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
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.labelBonjour = new System.Windows.Forms.Label();
            this.labelTxt = new System.Windows.Forms.Label();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(481, 102);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 0;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(493, 342);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // labelBonjour
            // 
            this.labelBonjour.AutoSize = true;
            this.labelBonjour.Location = new System.Drawing.Point(41, 22);
            this.labelBonjour.Name = "labelBonjour";
            this.labelBonjour.Size = new System.Drawing.Size(43, 13);
            this.labelBonjour.TabIndex = 2;
            this.labelBonjour.Text = "Bonjour";
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Location = new System.Drawing.Point(41, 70);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(95, 13);
            this.labelTxt.TabIndex = 3;
            this.labelTxt.Text = "Texte à eregistrer :";
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(199, 63);
            this.txtSaisie.MaxLength = 30;
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(271, 20);
            this.txtSaisie.TabIndex = 4;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(199, 144);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(320, 186);
            this.listBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.labelBonjour);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnEnvoyer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label labelBonjour;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.ListBox listBox;
    }
}

