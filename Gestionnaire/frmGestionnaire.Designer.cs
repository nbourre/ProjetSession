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
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.cboIPs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgPrincipale = new System.Windows.Forms.TabPage();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.tpgPersonne = new System.Windows.Forms.TabPage();
            this.dgvPersonnes = new System.Windows.Forms.DataGridView();
            this.tpgLocal = new System.Windows.Forms.TabPage();
            this.dgvLocaux = new System.Windows.Forms.DataGridView();
            this.tpgPermissions = new System.Windows.Forms.TabPage();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpgPrincipale.SuspendLayout();
            this.tpgPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).BeginInit();
            this.tpgLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).BeginInit();
            this.tpgPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(202, 184);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "8080";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(270, 183);
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
            this.lstHistorique.Location = new System.Drawing.Point(6, 211);
            this.lstHistorique.Name = "lstHistorique";
            this.lstHistorique.Size = new System.Drawing.Size(366, 95);
            this.lstHistorique.TabIndex = 9;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // cboIPs
            // 
            this.cboIPs.FormattingEnabled = true;
            this.cboIPs.Location = new System.Drawing.Point(37, 184);
            this.cboIPs.Name = "cboIPs";
            this.cboIPs.Size = new System.Drawing.Size(121, 21);
            this.cboIPs.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpgPrincipale);
            this.tabControl1.Controls.Add(this.tpgPersonne);
            this.tabControl1.Controls.Add(this.tpgLocal);
            this.tabControl1.Controls.Add(this.tpgPermissions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 476);
            this.tabControl1.TabIndex = 12;
            // 
            // tpgPrincipale
            // 
            this.tpgPrincipale.Controls.Add(this.button1);
            this.tpgPrincipale.Controls.Add(this.txtMsg);
            this.tpgPrincipale.Controls.Add(this.cboIPs);
            this.tpgPrincipale.Controls.Add(this.label1);
            this.tpgPrincipale.Controls.Add(this.btnConnexion);
            this.tpgPrincipale.Controls.Add(this.txtPort);
            this.tpgPrincipale.Controls.Add(this.lstHistorique);
            this.tpgPrincipale.Controls.Add(this.label2);
            this.tpgPrincipale.Location = new System.Drawing.Point(4, 22);
            this.tpgPrincipale.Name = "tpgPrincipale";
            this.tpgPrincipale.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPrincipale.Size = new System.Drawing.Size(603, 450);
            this.tpgPrincipale.TabIndex = 0;
            this.tpgPrincipale.Text = "Principale";
            this.tpgPrincipale.UseVisualStyleBackColor = true;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(391, 64);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 20);
            this.txtMsg.TabIndex = 12;
            // 
            // tpgPersonne
            // 
            this.tpgPersonne.Controls.Add(this.dgvPersonnes);
            this.tpgPersonne.Location = new System.Drawing.Point(4, 22);
            this.tpgPersonne.Name = "tpgPersonne";
            this.tpgPersonne.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPersonne.Size = new System.Drawing.Size(603, 450);
            this.tpgPersonne.TabIndex = 1;
            this.tpgPersonne.Text = "Personnes";
            this.tpgPersonne.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnes
            // 
            this.dgvPersonnes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnes.Location = new System.Drawing.Point(3, 54);
            this.dgvPersonnes.Name = "dgvPersonnes";
            this.dgvPersonnes.Size = new System.Drawing.Size(596, 150);
            this.dgvPersonnes.TabIndex = 1;
            // 
            // tpgLocal
            // 
            this.tpgLocal.Controls.Add(this.dgvLocaux);
            this.tpgLocal.Location = new System.Drawing.Point(4, 22);
            this.tpgLocal.Name = "tpgLocal";
            this.tpgLocal.Size = new System.Drawing.Size(603, 450);
            this.tpgLocal.TabIndex = 2;
            this.tpgLocal.Text = "Locaux";
            this.tpgLocal.UseVisualStyleBackColor = true;
            // 
            // dgvLocaux
            // 
            this.dgvLocaux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocaux.Location = new System.Drawing.Point(3, 54);
            this.dgvLocaux.Name = "dgvLocaux";
            this.dgvLocaux.Size = new System.Drawing.Size(596, 150);
            this.dgvLocaux.TabIndex = 0;
            // 
            // tpgPermissions
            // 
            this.tpgPermissions.Controls.Add(this.dgvPermissions);
            this.tpgPermissions.Location = new System.Drawing.Point(4, 22);
            this.tpgPermissions.Name = "tpgPermissions";
            this.tpgPermissions.Size = new System.Drawing.Size(603, 450);
            this.tpgPermissions.TabIndex = 3;
            this.tpgPermissions.Text = "Permissions";
            this.tpgPermissions.UseVisualStyleBackColor = true;
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissions.Location = new System.Drawing.Point(3, 53);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.Size = new System.Drawing.Size(596, 150);
            this.dgvPermissions.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGestionnaire";
            this.Text = "Gestionnaire d\'accès - BD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionnaire_FormClosing);
            this.Load += new System.EventHandler(this.frmGestionnaire_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpgPrincipale.ResumeLayout(false);
            this.tpgPrincipale.PerformLayout();
            this.tpgPersonne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).EndInit();
            this.tpgLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).EndInit();
            this.tpgPermissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.ListBox lstHistorique;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ComboBox cboIPs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgPrincipale;
        private System.Windows.Forms.TabPage tpgPersonne;
        private System.Windows.Forms.TabPage tpgLocal;
        private System.Windows.Forms.DataGridView dgvLocaux;
        private System.Windows.Forms.TabPage tpgPermissions;
        private System.Windows.Forms.DataGridView dgvPersonnes;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button button1;
    }
}

