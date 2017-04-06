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
            this.lstHistorique = new System.Windows.Forms.ListBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgPrincipale = new System.Windows.Forms.TabPage();
            this.pbRelais = new System.Windows.Forms.PictureBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.tpgPersonne = new System.Windows.Forms.TabPage();
            this.dgvPersonnes = new System.Windows.Forms.DataGridView();
            this.tpgLocal = new System.Windows.Forms.TabPage();
            this.dgvLocaux = new System.Windows.Forms.DataGridView();
            this.tpgPermissions = new System.Windows.Forms.TabPage();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.cboIPs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP_view = new System.Windows.Forms.TextBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpgPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelais)).BeginInit();
            this.tpgPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).BeginInit();
            this.tpgLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).BeginInit();
            this.tpgPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHistorique
            // 
            this.lstHistorique.FormattingEnabled = true;
            this.lstHistorique.Location = new System.Drawing.Point(6, 23);
            this.lstHistorique.Name = "lstHistorique";
            this.lstHistorique.Size = new System.Drawing.Size(366, 95);
            this.lstHistorique.TabIndex = 9;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpgPrincipale);
            this.tabMain.Controls.Add(this.tpgPersonne);
            this.tabMain.Controls.Add(this.tpgLocal);
            this.tabMain.Controls.Add(this.tpgPermissions);
            this.tabMain.Controls.Add(this.tabConfig);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(611, 476);
            this.tabMain.TabIndex = 12;
            // 
            // tpgPrincipale
            // 
            this.tpgPrincipale.Controls.Add(this.label7);
            this.tpgPrincipale.Controls.Add(this.label6);
            this.tpgPrincipale.Controls.Add(this.txtIP_view);
            this.tpgPrincipale.Controls.Add(this.label4);
            this.tpgPrincipale.Controls.Add(this.label3);
            this.tpgPrincipale.Controls.Add(this.pbRelais);
            this.tpgPrincipale.Controls.Add(this.txtMsg);
            this.tpgPrincipale.Controls.Add(this.lstHistorique);
            this.tpgPrincipale.Location = new System.Drawing.Point(4, 22);
            this.tpgPrincipale.Name = "tpgPrincipale";
            this.tpgPrincipale.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPrincipale.Size = new System.Drawing.Size(603, 450);
            this.tpgPrincipale.TabIndex = 0;
            this.tpgPrincipale.Text = "Principale";
            this.tpgPrincipale.UseVisualStyleBackColor = true;
            // 
            // pbRelais
            // 
            this.pbRelais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRelais.Location = new System.Drawing.Point(6, 143);
            this.pbRelais.Name = "pbRelais";
            this.pbRelais.Size = new System.Drawing.Size(366, 301);
            this.pbRelais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRelais.TabIndex = 14;
            this.pbRelais.TabStop = false;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(378, 143);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(144, 81);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Historique des demandes";
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.label5);
            this.tabConfig.Controls.Add(this.txtDebug);
            this.tabConfig.Controls.Add(this.cboIPs);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Controls.Add(this.btnConnexion);
            this.tabConfig.Controls.Add(this.txtPort);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(603, 450);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // cboIPs
            // 
            this.cboIPs.FormattingEnabled = true;
            this.cboIPs.Location = new System.Drawing.Point(36, 12);
            this.cboIPs.Name = "cboIPs";
            this.cboIPs.Size = new System.Drawing.Size(121, 21);
            this.cboIPs.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(269, 11);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 12;
            this.btnConnexion.Text = "Écouter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(201, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 20);
            this.txtPort.TabIndex = 13;
            this.txtPort.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "IP :";
            // 
            // txtIP_view
            // 
            this.txtIP_view.Location = new System.Drawing.Point(473, 7);
            this.txtIP_view.Name = "txtIP_view";
            this.txtIP_view.ReadOnly = true;
            this.txtIP_view.Size = new System.Drawing.Size(124, 20);
            this.txtIP_view.TabIndex = 21;
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(3, 83);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(144, 81);
            this.txtDebug.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Débogage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dernière photo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dernier message";
            // 
            // frmGestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 500);
            this.Controls.Add(this.tabMain);
            this.Name = "frmGestionnaire";
            this.Text = "Gestionnaire d\'accès - BD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionnaire_FormClosing);
            this.Load += new System.EventHandler(this.frmGestionnaire_Load);
            this.tabMain.ResumeLayout(false);
            this.tpgPrincipale.ResumeLayout(false);
            this.tpgPrincipale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelais)).EndInit();
            this.tpgPersonne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).EndInit();
            this.tpgLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).EndInit();
            this.tpgPermissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstHistorique;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgPrincipale;
        private System.Windows.Forms.TabPage tpgPersonne;
        private System.Windows.Forms.TabPage tpgLocal;
        private System.Windows.Forms.DataGridView dgvLocaux;
        private System.Windows.Forms.TabPage tpgPermissions;
        private System.Windows.Forms.DataGridView dgvPersonnes;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.PictureBox pbRelais;
        private System.Windows.Forms.TextBox txtIP_view;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.ComboBox cboIPs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

