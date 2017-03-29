namespace Relais
{
    partial class frmRelais
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
            this.spc = new gei1076_tools.SerialPortConfigurator();
            this.tmrCam = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPrincipale = new System.Windows.Forms.TabPage();
            this.lblDataRead = new System.Windows.Forms.Label();
            this.txtDataRead = new System.Windows.Forms.TextBox();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnTestConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPServeur = new System.Windows.Forms.TextBox();
            this.tmrSerie = new System.Windows.Forms.Timer(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabPrincipale.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc
            // 
            this.spc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc.Location = new System.Drawing.Point(3, 6);
            this.spc.Name = "spc";
            this.spc.Size = new System.Drawing.Size(784, 93);
            this.spc.TabIndex = 0;
            // 
            // tmrCam
            // 
            this.tmrCam.Tick += new System.EventHandler(this.tmrCam_Tick);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPrincipale);
            this.tabMain.Controls.Add(this.tabCamera);
            this.tabMain.Controls.Add(this.tabConfig);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(801, 522);
            this.tabMain.TabIndex = 4;
            // 
            // tabPrincipale
            // 
            this.tabPrincipale.Controls.Add(this.lblDataRead);
            this.tabPrincipale.Controls.Add(this.txtDataRead);
            this.tabPrincipale.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipale.Name = "tabPrincipale";
            this.tabPrincipale.Size = new System.Drawing.Size(793, 496);
            this.tabPrincipale.TabIndex = 2;
            this.tabPrincipale.Text = "Principale";
            this.tabPrincipale.UseVisualStyleBackColor = true;
            // 
            // lblDataRead
            // 
            this.lblDataRead.AutoSize = true;
            this.lblDataRead.Location = new System.Drawing.Point(29, 82);
            this.lblDataRead.Name = "lblDataRead";
            this.lblDataRead.Size = new System.Drawing.Size(91, 13);
            this.lblDataRead.TabIndex = 4;
            this.lblDataRead.Text = "Données reçues :";
            // 
            // txtDataRead
            // 
            this.txtDataRead.Location = new System.Drawing.Point(45, 98);
            this.txtDataRead.Multiline = true;
            this.txtDataRead.Name = "txtDataRead";
            this.txtDataRead.Size = new System.Drawing.Size(237, 222);
            this.txtDataRead.TabIndex = 3;
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.pbCamera);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(793, 496);
            this.tabCamera.TabIndex = 0;
            this.tabCamera.Text = "Caméra";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(6, 6);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(640, 480);
            this.pbCamera.TabIndex = 3;
            this.pbCamera.TabStop = false;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.btnTestConnexion);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.txtPort);
            this.tabConfig.Controls.Add(this.btnConnexion);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Controls.Add(this.txtIPServeur);
            this.tabConfig.Controls.Add(this.spc);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(793, 496);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // btnTestConnexion
            // 
            this.btnTestConnexion.Location = new System.Drawing.Point(328, 144);
            this.btnTestConnexion.Name = "btnTestConnexion";
            this.btnTestConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnexion.TabIndex = 6;
            this.btnTestConnexion.Text = "Test";
            this.btnTestConnexion.UseVisualStyleBackColor = true;
            this.btnTestConnexion.Click += new System.EventHandler(this.btnTestConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(260, 116);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(62, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8080";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(328, 115);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP serveur :";
            // 
            // txtIPServeur
            // 
            this.txtIPServeur.Location = new System.Drawing.Point(116, 116);
            this.txtIPServeur.Name = "txtIPServeur";
            this.txtIPServeur.Size = new System.Drawing.Size(100, 20);
            this.txtIPServeur.TabIndex = 1;
            this.txtIPServeur.Text = "172.16.200.144";
            // 
            // tmrSerie
            // 
            this.tmrSerie.Tick += new System.EventHandler(this.tmrSerie_Tick);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 250;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmRelais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 546);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(840, 584);
            this.Name = "frmRelais";
            this.Text = "Gestionnaire d\'accès - Relais";
            this.Load += new System.EventHandler(this.frmRelais_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPrincipale.ResumeLayout(false);
            this.tabPrincipale.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private gei1076_tools.SerialPortConfigurator spc;
        private System.Windows.Forms.Timer tmrCam;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Timer tmrSerie;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPServeur;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestConnexion;
        private System.Windows.Forms.TabPage tabPrincipale;
        private System.Windows.Forms.Label lblDataRead;
        private System.Windows.Forms.TextBox txtDataRead;
    }
}

