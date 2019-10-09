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
            this.tmrCam = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPrincipale = new System.Windows.Forms.TabPage();
            this.pbLastCapture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIPView = new System.Windows.Forms.TextBox();
            this.txtLocalView = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDataRead = new System.Windows.Forms.Label();
            this.txtDemandes = new System.Windows.Forms.TextBox();
            this.txtDataRead = new System.Windows.Forms.TextBox();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnAucune = new System.Windows.Forms.Button();
            this.btnRouge = new System.Windows.Forms.Button();
            this.btnJaune = new System.Windows.Forms.Button();
            this.btnVert = new System.Windows.Forms.Button();
            this.lblUSB = new System.Windows.Forms.Label();
            this.txtUSB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIPServeur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.grboxAcquisition = new System.Windows.Forms.GroupBox();
            this.rbtnSerie = new System.Windows.Forms.RadioButton();
            this.rbtnUSB = new System.Windows.Forms.RadioButton();
            this.spc = new gei1076_tools.SerialPortConfigurator();
            this.tmrSerie = new System.Windows.Forms.Timer(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tipAcquisition = new System.Windows.Forms.ToolTip(this.components);
            this.tipTestUSB = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain.SuspendLayout();
            this.tabPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLastCapture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grboxAcquisition.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPrincipale.Controls.Add(this.pbLastCapture);
            this.tabPrincipale.Controls.Add(this.groupBox3);
            this.tabPrincipale.Controls.Add(this.txtMsg);
            this.tabPrincipale.Controls.Add(this.label3);
            this.tabPrincipale.Controls.Add(this.label4);
            this.tabPrincipale.Controls.Add(this.lblDataRead);
            this.tabPrincipale.Controls.Add(this.txtDemandes);
            this.tabPrincipale.Controls.Add(this.txtDataRead);
            this.tabPrincipale.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipale.Name = "tabPrincipale";
            this.tabPrincipale.Size = new System.Drawing.Size(793, 496);
            this.tabPrincipale.TabIndex = 2;
            this.tabPrincipale.Text = "Principale";
            this.tabPrincipale.UseVisualStyleBackColor = true;
            // 
            // pbLastCapture
            // 
            this.pbLastCapture.Location = new System.Drawing.Point(519, 223);
            this.pbLastCapture.Name = "pbLastCapture";
            this.pbLastCapture.Size = new System.Drawing.Size(202, 178);
            this.pbLastCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLastCapture.TabIndex = 15;
            this.pbLastCapture.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIPView);
            this.groupBox3.Controls.Add(this.txtLocalView);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(590, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Local :";
            // 
            // txtIPView
            // 
            this.txtIPView.Enabled = false;
            this.txtIPView.Location = new System.Drawing.Point(80, 19);
            this.txtIPView.Name = "txtIPView";
            this.txtIPView.Size = new System.Drawing.Size(114, 20);
            this.txtIPView.TabIndex = 15;
            this.txtIPView.Text = "172.16.200.144";
            // 
            // txtLocalView
            // 
            this.txtLocalView.Enabled = false;
            this.txtLocalView.Location = new System.Drawing.Point(80, 45);
            this.txtLocalView.Name = "txtLocalView";
            this.txtLocalView.Size = new System.Drawing.Size(114, 20);
            this.txtLocalView.TabIndex = 18;
            this.txtLocalView.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adresse IP :";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(3, 223);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(480, 178);
            this.txtMsg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Demandes d\'accès";
            // 
            // lblDataRead
            // 
            this.lblDataRead.AutoSize = true;
            this.lblDataRead.Location = new System.Drawing.Point(0, 6);
            this.lblDataRead.Name = "lblDataRead";
            this.lblDataRead.Size = new System.Drawing.Size(106, 13);
            this.lblDataRead.TabIndex = 4;
            this.lblDataRead.Text = "Dernières cartes lues";
            // 
            // txtDemandes
            // 
            this.txtDemandes.Location = new System.Drawing.Point(246, 22);
            this.txtDemandes.Multiline = true;
            this.txtDemandes.Name = "txtDemandes";
            this.txtDemandes.Size = new System.Drawing.Size(237, 178);
            this.txtDemandes.TabIndex = 3;
            // 
            // txtDataRead
            // 
            this.txtDataRead.Location = new System.Drawing.Point(3, 22);
            this.txtDataRead.Multiline = true;
            this.txtDataRead.Name = "txtDataRead";
            this.txtDataRead.Size = new System.Drawing.Size(237, 178);
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
            this.pbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCamera.Location = new System.Drawing.Point(6, 6);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(640, 480);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCamera.TabIndex = 3;
            this.pbCamera.TabStop = false;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.btnAucune);
            this.tabConfig.Controls.Add(this.btnRouge);
            this.tabConfig.Controls.Add(this.btnJaune);
            this.tabConfig.Controls.Add(this.btnVert);
            this.tabConfig.Controls.Add(this.lblUSB);
            this.tabConfig.Controls.Add(this.txtUSB);
            this.tabConfig.Controls.Add(this.label5);
            this.tabConfig.Controls.Add(this.txtLocal);
            this.tabConfig.Controls.Add(this.groupBox2);
            this.tabConfig.Controls.Add(this.grboxAcquisition);
            this.tabConfig.Controls.Add(this.spc);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(793, 496);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // btnAucune
            // 
            this.btnAucune.Location = new System.Drawing.Point(678, 137);
            this.btnAucune.Name = "btnAucune";
            this.btnAucune.Size = new System.Drawing.Size(75, 23);
            this.btnAucune.TabIndex = 18;
            this.btnAucune.Text = "Aucune";
            this.btnAucune.UseVisualStyleBackColor = true;
            this.btnAucune.Click += new System.EventHandler(this.btnAucune_Click);
            // 
            // btnRouge
            // 
            this.btnRouge.Location = new System.Drawing.Point(597, 166);
            this.btnRouge.Name = "btnRouge";
            this.btnRouge.Size = new System.Drawing.Size(75, 23);
            this.btnRouge.TabIndex = 17;
            this.btnRouge.Text = "Rouge";
            this.btnRouge.UseVisualStyleBackColor = true;
            this.btnRouge.Click += new System.EventHandler(this.btnRouge_Click);
            // 
            // btnJaune
            // 
            this.btnJaune.Location = new System.Drawing.Point(597, 137);
            this.btnJaune.Name = "btnJaune";
            this.btnJaune.Size = new System.Drawing.Size(75, 23);
            this.btnJaune.TabIndex = 16;
            this.btnJaune.Text = "Jaune";
            this.btnJaune.UseVisualStyleBackColor = true;
            this.btnJaune.Click += new System.EventHandler(this.btnJaune_Click);
            // 
            // btnVert
            // 
            this.btnVert.Location = new System.Drawing.Point(597, 108);
            this.btnVert.Name = "btnVert";
            this.btnVert.Size = new System.Drawing.Size(75, 23);
            this.btnVert.TabIndex = 15;
            this.btnVert.Text = "Vert";
            this.btnVert.UseVisualStyleBackColor = true;
            this.btnVert.Click += new System.EventHandler(this.btnVert_Click);
            // 
            // lblUSB
            // 
            this.lblUSB.AutoSize = true;
            this.lblUSB.Location = new System.Drawing.Point(53, 181);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new System.Drawing.Size(94, 13);
            this.lblUSB.TabIndex = 14;
            this.lblUSB.Text = "Test lecture USB :";
            // 
            // txtUSB
            // 
            this.txtUSB.Location = new System.Drawing.Point(153, 178);
            this.txtUSB.Multiline = true;
            this.txtUSB.Name = "txtUSB";
            this.txtUSB.Size = new System.Drawing.Size(160, 20);
            this.txtUSB.TabIndex = 13;
            this.txtUSB.TextChanged += new System.EventHandler(this.txtUSB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local :";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(89, 275);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(100, 20);
            this.txtLocal.TabIndex = 10;
            this.txtLocal.Text = "1133";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIPServeur);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConnexion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Location = new System.Drawing.Point(6, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connexion au serveur";
            // 
            // txtIPServeur
            // 
            this.txtIPServeur.Location = new System.Drawing.Point(83, 20);
            this.txtIPServeur.Name = "txtIPServeur";
            this.txtIPServeur.Size = new System.Drawing.Size(100, 20);
            this.txtIPServeur.TabIndex = 1;
            this.txtIPServeur.Text = "24.122.0.207";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresse IP :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(275, 18);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(227, 20);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(42, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8080";
            // 
            // grboxAcquisition
            // 
            this.grboxAcquisition.Controls.Add(this.rbtnSerie);
            this.grboxAcquisition.Controls.Add(this.rbtnUSB);
            this.grboxAcquisition.Location = new System.Drawing.Point(6, 6);
            this.grboxAcquisition.Name = "grboxAcquisition";
            this.grboxAcquisition.Size = new System.Drawing.Size(155, 67);
            this.grboxAcquisition.TabIndex = 8;
            this.grboxAcquisition.TabStop = false;
            this.grboxAcquisition.Text = "Méthode d\'acquisition";
            // 
            // rbtnSerie
            // 
            this.rbtnSerie.AutoSize = true;
            this.rbtnSerie.Checked = true;
            this.rbtnSerie.Location = new System.Drawing.Point(18, 19);
            this.rbtnSerie.Name = "rbtnSerie";
            this.rbtnSerie.Size = new System.Drawing.Size(69, 17);
            this.rbtnSerie.TabIndex = 5;
            this.rbtnSerie.TabStop = true;
            this.rbtnSerie.Text = "Port série";
            this.rbtnSerie.UseVisualStyleBackColor = true;
            // 
            // rbtnUSB
            // 
            this.rbtnUSB.AutoSize = true;
            this.rbtnUSB.Location = new System.Drawing.Point(18, 42);
            this.rbtnUSB.Name = "rbtnUSB";
            this.rbtnUSB.Size = new System.Drawing.Size(77, 17);
            this.rbtnUSB.TabIndex = 6;
            this.rbtnUSB.Text = "USB (Test)";
            this.rbtnUSB.UseVisualStyleBackColor = true;
            // 
            // spc
            // 
            this.spc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc.Location = new System.Drawing.Point(40, 79);
            this.spc.Name = "spc";
            this.spc.Size = new System.Drawing.Size(551, 93);
            this.spc.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLastCapture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            this.tabCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grboxAcquisition.ResumeLayout(false);
            this.grboxAcquisition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
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
        private System.Windows.Forms.TabPage tabPrincipale;
        private System.Windows.Forms.Label lblDataRead;
        private System.Windows.Forms.TextBox txtDataRead;
        private gei1076_tools.SerialPortConfigurator spc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grboxAcquisition;
        private System.Windows.Forms.RadioButton rbtnSerie;
        private System.Windows.Forms.RadioButton rbtnUSB;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIPView;
        private System.Windows.Forms.TextBox txtLocalView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.TextBox txtUSB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDemandes;
        private System.Windows.Forms.PictureBox pbLastCapture;
        private System.Windows.Forms.ToolTip tipAcquisition;
        private System.Windows.Forms.ToolTip tipTestUSB;
        private System.Windows.Forms.Button btnVert;
        private System.Windows.Forms.Button btnJaune;
        private System.Windows.Forms.Button btnRouge;
        private System.Windows.Forms.Button btnAucune;
    }
}

