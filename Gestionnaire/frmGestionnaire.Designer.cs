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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIP_view = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbRelais = new System.Windows.Forms.PictureBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.tpgPersonne = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnPersonneAjouter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPersonneSupprimer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodeCarte = new System.Windows.Forms.TextBox();
            this.dgvPersonnes = new System.Windows.Forms.DataGridView();
            this.tpgLocal = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLocalNumero = new System.Windows.Forms.TextBox();
            this.btnLocalAjouter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLocalSupprimer = new System.Windows.Forms.Button();
            this.txtLocalDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvLocaux = new System.Windows.Forms.DataGridView();
            this.tpgPermissions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboLocaux = new System.Windows.Forms.ComboBox();
            this.cboPersonnes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlageFin = new System.Windows.Forms.TextBox();
            this.btnPermissionAjouter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPermissionSupprimer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPlageDebut = new System.Windows.Forms.TextBox();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.cboIPs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpgPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelais)).BeginInit();
            this.tpgPersonne.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).BeginInit();
            this.tpgLocal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).BeginInit();
            this.tpgPermissions.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dernier message";
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
            // txtIP_view
            // 
            this.txtIP_view.Location = new System.Drawing.Point(473, 7);
            this.txtIP_view.Name = "txtIP_view";
            this.txtIP_view.ReadOnly = true;
            this.txtIP_view.Size = new System.Drawing.Size(124, 20);
            this.txtIP_view.TabIndex = 21;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Historique des demandes";
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
            this.tpgPersonne.Controls.Add(this.groupBox1);
            this.tpgPersonne.Controls.Add(this.dgvPersonnes);
            this.tpgPersonne.Location = new System.Drawing.Point(4, 22);
            this.tpgPersonne.Name = "tpgPersonne";
            this.tpgPersonne.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPersonne.Size = new System.Drawing.Size(603, 450);
            this.tpgPersonne.TabIndex = 1;
            this.tpgPersonne.Text = "Personnes";
            this.tpgPersonne.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.btnPersonneAjouter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPersonneSupprimer);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodeCarte);
            this.groupBox1.Location = new System.Drawing.Point(6, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 105);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des données";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(66, 19);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // btnPersonneAjouter
            // 
            this.btnPersonneAjouter.Location = new System.Drawing.Point(187, 43);
            this.btnPersonneAjouter.Name = "btnPersonneAjouter";
            this.btnPersonneAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnPersonneAjouter.TabIndex = 8;
            this.btnPersonneAjouter.Text = "Ajouter";
            this.btnPersonneAjouter.UseVisualStyleBackColor = true;
            this.btnPersonneAjouter.Click += new System.EventHandler(this.btnPersonneAjouter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Prénom :";
            // 
            // btnPersonneSupprimer
            // 
            this.btnPersonneSupprimer.Location = new System.Drawing.Point(187, 17);
            this.btnPersonneSupprimer.Name = "btnPersonneSupprimer";
            this.btnPersonneSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnPersonneSupprimer.TabIndex = 8;
            this.btnPersonneSupprimer.Text = "Supprimer";
            this.btnPersonneSupprimer.UseVisualStyleBackColor = true;
            this.btnPersonneSupprimer.Click += new System.EventHandler(this.btnPersonneSupprimer_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(66, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Carte :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nom :";
            // 
            // txtCodeCarte
            // 
            this.txtCodeCarte.Location = new System.Drawing.Point(66, 71);
            this.txtCodeCarte.Name = "txtCodeCarte";
            this.txtCodeCarte.Size = new System.Drawing.Size(100, 20);
            this.txtCodeCarte.TabIndex = 6;
            // 
            // dgvPersonnes
            // 
            this.dgvPersonnes.AllowUserToAddRows = false;
            this.dgvPersonnes.AllowUserToDeleteRows = false;
            this.dgvPersonnes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnes.Location = new System.Drawing.Point(4, 6);
            this.dgvPersonnes.Name = "dgvPersonnes";
            this.dgvPersonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnes.Size = new System.Drawing.Size(596, 150);
            this.dgvPersonnes.TabIndex = 1;
            this.dgvPersonnes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonnes_CellMouseDoubleClick);
            // 
            // tpgLocal
            // 
            this.tpgLocal.Controls.Add(this.groupBox2);
            this.tpgLocal.Controls.Add(this.dgvLocaux);
            this.tpgLocal.Location = new System.Drawing.Point(4, 22);
            this.tpgLocal.Name = "tpgLocal";
            this.tpgLocal.Size = new System.Drawing.Size(603, 450);
            this.tpgLocal.TabIndex = 2;
            this.tpgLocal.Text = "Locaux";
            this.tpgLocal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLocalNumero);
            this.groupBox2.Controls.Add(this.btnLocalAjouter);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnLocalSupprimer);
            this.groupBox2.Controls.Add(this.txtLocalDescription);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(6, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion des données";
            // 
            // txtLocalNumero
            // 
            this.txtLocalNumero.Location = new System.Drawing.Point(81, 19);
            this.txtLocalNumero.Name = "txtLocalNumero";
            this.txtLocalNumero.Size = new System.Drawing.Size(100, 20);
            this.txtLocalNumero.TabIndex = 2;
            // 
            // btnLocalAjouter
            // 
            this.btnLocalAjouter.Location = new System.Drawing.Point(187, 43);
            this.btnLocalAjouter.Name = "btnLocalAjouter";
            this.btnLocalAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnLocalAjouter.TabIndex = 8;
            this.btnLocalAjouter.Text = "Ajouter";
            this.btnLocalAjouter.UseVisualStyleBackColor = true;
            this.btnLocalAjouter.Click += new System.EventHandler(this.btnLocalAjouter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Numéro :";
            // 
            // btnLocalSupprimer
            // 
            this.btnLocalSupprimer.Location = new System.Drawing.Point(187, 17);
            this.btnLocalSupprimer.Name = "btnLocalSupprimer";
            this.btnLocalSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnLocalSupprimer.TabIndex = 8;
            this.btnLocalSupprimer.Text = "Supprimer";
            this.btnLocalSupprimer.UseVisualStyleBackColor = true;
            this.btnLocalSupprimer.Click += new System.EventHandler(this.btnLocalSupprimer_Click);
            // 
            // txtLocalDescription
            // 
            this.txtLocalDescription.Location = new System.Drawing.Point(81, 45);
            this.txtLocalDescription.Name = "txtLocalDescription";
            this.txtLocalDescription.Size = new System.Drawing.Size(100, 20);
            this.txtLocalDescription.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Description :";
            // 
            // dgvLocaux
            // 
            this.dgvLocaux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocaux.Location = new System.Drawing.Point(4, 6);
            this.dgvLocaux.Name = "dgvLocaux";
            this.dgvLocaux.Size = new System.Drawing.Size(596, 150);
            this.dgvLocaux.TabIndex = 0;
            this.dgvLocaux.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocaux_CellMouseDoubleClick);
            // 
            // tpgPermissions
            // 
            this.tpgPermissions.Controls.Add(this.groupBox3);
            this.tpgPermissions.Controls.Add(this.dgvPermissions);
            this.tpgPermissions.Location = new System.Drawing.Point(4, 22);
            this.tpgPermissions.Name = "tpgPermissions";
            this.tpgPermissions.Size = new System.Drawing.Size(603, 450);
            this.tpgPermissions.TabIndex = 3;
            this.tpgPermissions.Text = "Permissions";
            this.tpgPermissions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboLocaux);
            this.groupBox3.Controls.Add(this.cboPersonnes);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPlageFin);
            this.groupBox3.Controls.Add(this.btnPermissionAjouter);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnPermissionSupprimer);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtPlageDebut);
            this.groupBox3.Location = new System.Drawing.Point(6, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 141);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion des données";
            // 
            // cboLocaux
            // 
            this.cboLocaux.FormattingEnabled = true;
            this.cboLocaux.Location = new System.Drawing.Point(87, 45);
            this.cboLocaux.Name = "cboLocaux";
            this.cboLocaux.Size = new System.Drawing.Size(181, 21);
            this.cboLocaux.TabIndex = 11;
            // 
            // cboPersonnes
            // 
            this.cboPersonnes.FormattingEnabled = true;
            this.cboPersonnes.Location = new System.Drawing.Point(87, 19);
            this.cboPersonnes.Name = "cboPersonnes";
            this.cboPersonnes.Size = new System.Drawing.Size(181, 21);
            this.cboPersonnes.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Plage fin :";
            // 
            // txtPlageFin
            // 
            this.txtPlageFin.Location = new System.Drawing.Point(87, 97);
            this.txtPlageFin.Name = "txtPlageFin";
            this.txtPlageFin.Size = new System.Drawing.Size(181, 20);
            this.txtPlageFin.TabIndex = 9;
            // 
            // btnPermissionAjouter
            // 
            this.btnPermissionAjouter.Location = new System.Drawing.Point(274, 43);
            this.btnPermissionAjouter.Name = "btnPermissionAjouter";
            this.btnPermissionAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnPermissionAjouter.TabIndex = 8;
            this.btnPermissionAjouter.Text = "Ajouter";
            this.btnPermissionAjouter.UseVisualStyleBackColor = true;
            this.btnPermissionAjouter.Click += new System.EventHandler(this.btnPermissionAjouter_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Personne :";
            // 
            // btnPermissionSupprimer
            // 
            this.btnPermissionSupprimer.Location = new System.Drawing.Point(274, 17);
            this.btnPermissionSupprimer.Name = "btnPermissionSupprimer";
            this.btnPermissionSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnPermissionSupprimer.TabIndex = 8;
            this.btnPermissionSupprimer.Text = "Supprimer";
            this.btnPermissionSupprimer.UseVisualStyleBackColor = true;
            this.btnPermissionSupprimer.Click += new System.EventHandler(this.btnPermissionSupprimer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Plage début :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Local :";
            // 
            // txtPlageDebut
            // 
            this.txtPlageDebut.Location = new System.Drawing.Point(87, 71);
            this.txtPlageDebut.Name = "txtPlageDebut";
            this.txtPlageDebut.Size = new System.Drawing.Size(181, 20);
            this.txtPlageDebut.TabIndex = 6;
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissions.Location = new System.Drawing.Point(4, 6);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.Size = new System.Drawing.Size(596, 150);
            this.dgvPermissions.TabIndex = 2;
            this.dgvPermissions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPermissions_CellMouseDoubleClick);
            this.dgvPermissions.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPermissions_ColumnHeaderMouseClick);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Débogage";
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(3, 83);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(341, 169);
            this.txtDebug.TabIndex = 17;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).EndInit();
            this.tpgLocal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocaux)).EndInit();
            this.tpgPermissions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodeCarte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnPersonneAjouter;
        private System.Windows.Forms.Button btnPersonneSupprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLocalNumero;
        private System.Windows.Forms.Button btnLocalAjouter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLocalSupprimer;
        private System.Windows.Forms.TextBox txtLocalDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboLocaux;
        private System.Windows.Forms.ComboBox cboPersonnes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlageFin;
        private System.Windows.Forms.Button btnPermissionAjouter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPermissionSupprimer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPlageDebut;
    }
}

