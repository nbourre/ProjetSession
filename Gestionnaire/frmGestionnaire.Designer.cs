namespace Gestionnaire
{
    partial class frmGestionnaire
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lstHistorique = new System.Windows.Forms.ListBox();
            this.Minuterie = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(62, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "8080";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(130, 20);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Écouter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lstHistorique
            // 
            this.lstHistorique.FormattingEnabled = true;
            this.lstHistorique.Location = new System.Drawing.Point(12, 49);
            this.lstHistorique.Name = "lstHistorique";
            this.lstHistorique.Size = new System.Drawing.Size(246, 95);
            this.lstHistorique.TabIndex = 9;
            // 
            // Minuterie
            // 
            this.Minuterie.Enabled = true;
            this.Minuterie.Tick += new System.EventHandler(this.Minuterie_Tick);
            // 
            // frmGestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstHistorique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnConnexion);
            this.Name = "frmGestionnaire";
            this.Text = "Gestionnaire d\'accès - BD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionnaire_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.ListBox lstHistorique;
        private System.Windows.Forms.Timer Minuterie;
    }
}

