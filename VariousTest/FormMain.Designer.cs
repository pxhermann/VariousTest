namespace VariousTest
{
	partial class FormMain
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
            System.Windows.Forms.Label lblUIlist;
            System.Windows.Forms.Label lblUItree;
            System.Windows.Forms.GroupBox gbLINQtoXML;
            System.Windows.Forms.Label lblLinqAddr;
            System.Windows.Forms.RadioButton rbLINQxmlAll;
            System.Windows.Forms.Label lblLINQxml;
            System.Windows.Forms.GroupBox gbLINQobj;
            System.Windows.Forms.Button btnLINQselObj;
            System.Windows.Forms.Label lblLINQobj;
            System.Windows.Forms.GroupBox gbLINQds;
            System.Windows.Forms.Label lblXML;
            System.Windows.Forms.Button btnXmlSerialize;
            System.Windows.Forms.Button btnXMLParse;
            System.Windows.Forms.Label lblXmlItems;
            System.Windows.Forms.GroupBox gbIOfileWatch;
            System.Windows.Forms.Label lblIOfileLastWrite;
            System.Windows.Forms.Label lblIOfile;
            System.Windows.Forms.Label lblIOfileContent;
            System.Windows.Forms.Label lblIOclass;
            System.Windows.Forms.Button btnWWWDownload;
            System.Windows.Forms.Button btnMailMAPIsend;
            System.Windows.Forms.Label lblUser;
            System.Windows.Forms.Label lblComputer;
            System.Windows.Forms.Label lblUImbox;
            System.Windows.Forms.TableLayoutPanel panelUI;
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Subpoložka 1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Polozka 1", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Subpoložka 2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Subpoložka 3");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Subpoložka 4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Položka 2", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item1Col1",
            "Item1Col2",
            "Item1Col3"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item2Col1",
            "Item2Col2",
            "Item2Col3"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panelUITreeBox;
            System.Windows.Forms.TableLayoutPanel pnlLINQ;
            System.Windows.Forms.Label lblOtherToday;
            System.Windows.Forms.Label lblOtherNow;
            System.Windows.Forms.Label lblAlgWrap;
            System.Windows.Forms.Label lblAlgCID;
            System.Windows.Forms.Label lblAlgAdVAT;
            System.Windows.Forms.Label lblAlgAdName;
            System.Windows.Forms.Label lblAlgAdStreet;
            System.Windows.Forms.Label lblAlgAdCity;
            System.Windows.Forms.Label lblAlgAdZip;
            System.Windows.Forms.Label lblOtherAppPathStartup;
            System.Windows.Forms.Label lblOtherAppPathExe;
            System.Windows.Forms.Label lblOtherAppProdName;
            System.Windows.Forms.Label lblOtherAppProdVer;
            System.Windows.Forms.Button btnLangDelgGUItest;
            System.Windows.Forms.Button btnLangDelgTest;
            System.Windows.Forms.Label lblOtherProcName;
            System.Windows.Forms.GroupBox gbLangDelg;
            System.Windows.Forms.TableLayoutPanel panelLangDelg;
            System.Windows.Forms.GroupBox gbLangRefl;
            System.Windows.Forms.Label lblLangRefl4;
            System.Windows.Forms.Label lblLangRefl3;
            System.Windows.Forms.Label lbLangRefl;
            System.Windows.Forms.Label lblLangRefl2;
            System.Windows.Forms.Button btnLangException;
            System.Windows.Forms.Button btnLangMemberAccess;
            System.Windows.Forms.GroupBox gbOtherProcess;
            System.Windows.Forms.Label lblOtherProc;
            System.Windows.Forms.TableLayoutPanel panelOtherProc;
            System.Windows.Forms.GroupBox gbAlgNum;
            System.Windows.Forms.GroupBox gbWrapText;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox gbServiceAccnt;
            System.Windows.Forms.Label lblServiceUser;
            System.Windows.Forms.Label lblServiceAccount;
            System.Windows.Forms.Label lblSerticePwd;
            System.Windows.Forms.Label lblServiceName;
            System.Windows.Forms.Label lblServiceFile;
            System.Windows.Forms.GroupBox gbMailSMTP;
            System.Windows.Forms.Label lblMailSMPTport;
            System.Windows.Forms.Label lblMailFrom;
            System.Windows.Forms.Label lblMailSMTPpwd;
            System.Windows.Forms.Label lblMailSMTPuser;
            System.Windows.Forms.Button btnMailSMTPsend;
            System.Windows.Forms.Label lblMailSMTPserver;
            System.Windows.Forms.Label lblMailSubject;
            System.Windows.Forms.Label lblMailCopy;
            System.Windows.Forms.Label lblMailRcp;
            System.Windows.Forms.Label lblWWWcontent;
            System.Windows.Forms.Label lblWWWURL;
            this.rbLINQxmlAccnt = new System.Windows.Forms.RadioButton();
            this.rbLINQxmlDeliv = new System.Windows.Forms.RadioButton();
            this.tbLINQxml = new System.Windows.Forms.TextBox();
            this.btnLINQselXML = new System.Windows.Forms.Button();
            this.listLINQxml = new System.Windows.Forms.ListView();
            this.tbLINQobj = new System.Windows.Forms.TextBox();
            this.listLINQobj = new System.Windows.Forms.ListBox();
            this.dgLINQds = new System.Windows.Forms.DataGridView();
            this.btnIOfileSel = new System.Windows.Forms.Button();
            this.tbIOfileContent = new System.Windows.Forms.TextBox();
            this.dtIOfileModified = new System.Windows.Forms.DateTimePicker();
            this.tbIOfile = new System.Windows.Forms.TextBox();
            this.btnUImbox = new System.Windows.Forms.Button();
            this.listUImbox = new System.Windows.Forms.ListView();
            this.treeUI = new System.Windows.Forms.TreeView();
            this.listUI = new System.Windows.Forms.ListView();
            this.hdrCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrCol3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.chbUITreeBoxEditable = new System.Windows.Forms.CheckBox();
            this.chbUITreeBoxEnabled = new System.Windows.Forms.CheckBox();
            this.btnLangDelgLambda = new System.Windows.Forms.Button();
            this.btnLangDelgAnonymous = new System.Windows.Forms.Button();
            this.tbLangReflParam2 = new System.Windows.Forms.TextBox();
            this.cbLangReflParam1 = new System.Windows.Forms.ComboBox();
            this.tbLangReflResult = new System.Windows.Forms.TextBox();
            this.cbLangReflType = new System.Windows.Forms.ComboBox();
            this.tbOtherProc = new System.Windows.Forms.TextBox();
            this.btnOtherMinimizeProcWnd = new System.Windows.Forms.Button();
            this.btnOtherMaximizeProcWnd = new System.Windows.Forms.Button();
            this.btnOtherCloseProcWnd = new System.Windows.Forms.Button();
            this.btnOtherRestoreProcWnd = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabAlg = new System.Windows.Forms.TabPage();
            this.gbAlgCutDiactric = new System.Windows.Forms.GroupBox();
            this.tbAlgDiactric = new System.Windows.Forms.TextBox();
            this.tbAlgDiactricCut = new System.Windows.Forms.TextBox();
            this.btnAlgCutDiactric = new System.Windows.Forms.Button();
            this.btnAlgNumToText = new System.Windows.Forms.Button();
            this.nudAlgNum = new System.Windows.Forms.NumericUpDown();
            this.tbAlgNumText = new System.Windows.Forms.TextBox();
            this.nudAlgWrap = new System.Windows.Forms.NumericUpDown();
            this.tbAlgWrap = new System.Windows.Forms.TextBox();
            this.tbAlgWrapText = new System.Windows.Forms.TextBox();
            this.btnAlgWrapText = new System.Windows.Forms.Button();
            this.gbAlgCID = new System.Windows.Forms.GroupBox();
            this.btnAlgCIDValidity = new System.Windows.Forms.Button();
            this.tbAlgCID = new System.Windows.Forms.TextBox();
            this.tbAlgAdZip = new System.Windows.Forms.TextBox();
            this.btnAlgAres = new System.Windows.Forms.Button();
            this.tbAlgAdCity = new System.Windows.Forms.TextBox();
            this.tbAlgAdVAT = new System.Windows.Forms.TextBox();
            this.tbAlgAdStreet = new System.Windows.Forms.TextBox();
            this.tbAlgAdName = new System.Windows.Forms.TextBox();
            this.tabLang = new System.Windows.Forms.TabPage();
            this.tabFileIO = new System.Windows.Forms.TabPage();
            this.gbIOzip = new System.Windows.Forms.GroupBox();
            this.panelIOzip = new System.Windows.Forms.TableLayoutPanel();
            this.btnIOzip = new System.Windows.Forms.Button();
            this.btnIOunzip = new System.Windows.Forms.Button();
            this.listIO = new System.Windows.Forms.ListView();
            this.tabXMLread = new System.Windows.Forms.TabPage();
            this.listXMLitems = new System.Windows.Forms.ListView();
            this.tbXMLFile = new System.Windows.Forms.TextBox();
            this.btnXMLSel = new System.Windows.Forms.Button();
            this.tabLINQ = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.tbServiceStatus = new System.Windows.Forms.TextBox();
            this.btnServiceStop = new System.Windows.Forms.Button();
            this.btnServiceStart = new System.Windows.Forms.Button();
            this.tbServiceUser = new System.Windows.Forms.TextBox();
            this.cbServiceAccount = new System.Windows.Forms.ComboBox();
            this.tbServicePwd = new System.Windows.Forms.TextBox();
            this.btnServiceUninstall = new System.Windows.Forms.Button();
            this.btnServiceInstall = new System.Windows.Forms.Button();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tbServiceFile = new System.Windows.Forms.TextBox();
            this.btnServiceSel = new System.Windows.Forms.Button();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.nudMailSMPTport = new System.Windows.Forms.NumericUpDown();
            this.tbMailFrom = new System.Windows.Forms.TextBox();
            this.tbMailSMTPpwd = new System.Windows.Forms.TextBox();
            this.tbMailSMTPuser = new System.Windows.Forms.TextBox();
            this.tbMailSMTPserver = new System.Windows.Forms.TextBox();
            this.tbMailBody = new System.Windows.Forms.TextBox();
            this.tbMailSubject = new System.Windows.Forms.TextBox();
            this.tbMailCopy = new System.Windows.Forms.TextBox();
            this.tbMailRcp = new System.Windows.Forms.TextBox();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.tbWWWURL = new System.Windows.Forms.TextBox();
            this.tbWWWContent = new System.Windows.Forms.TextBox();
            this.tabUI = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.tbOtherAppProdVer = new System.Windows.Forms.TextBox();
            this.tbOtherAppProdName = new System.Windows.Forms.TextBox();
            this.tbOtherAppPathExe = new System.Windows.Forms.TextBox();
            this.tbOtherAppPathStartup = new System.Windows.Forms.TextBox();
            this.tbOtherDTtoday = new System.Windows.Forms.TextBox();
            this.tbOtherDTnow = new System.Windows.Forms.TextBox();
            this.chbOnTop = new System.Windows.Forms.CheckBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbComputer = new System.Windows.Forms.TextBox();
            this.tbOtherProcName = new System.Windows.Forms.TextBox();
            this.serviceController = new System.ServiceProcess.ServiceController();
            this.tbUI = new XXX.TreeBox();
            lblUIlist = new System.Windows.Forms.Label();
            lblUItree = new System.Windows.Forms.Label();
            gbLINQtoXML = new System.Windows.Forms.GroupBox();
            lblLinqAddr = new System.Windows.Forms.Label();
            rbLINQxmlAll = new System.Windows.Forms.RadioButton();
            lblLINQxml = new System.Windows.Forms.Label();
            gbLINQobj = new System.Windows.Forms.GroupBox();
            btnLINQselObj = new System.Windows.Forms.Button();
            lblLINQobj = new System.Windows.Forms.Label();
            gbLINQds = new System.Windows.Forms.GroupBox();
            lblXML = new System.Windows.Forms.Label();
            btnXmlSerialize = new System.Windows.Forms.Button();
            btnXMLParse = new System.Windows.Forms.Button();
            lblXmlItems = new System.Windows.Forms.Label();
            gbIOfileWatch = new System.Windows.Forms.GroupBox();
            lblIOfileLastWrite = new System.Windows.Forms.Label();
            lblIOfile = new System.Windows.Forms.Label();
            lblIOfileContent = new System.Windows.Forms.Label();
            lblIOclass = new System.Windows.Forms.Label();
            btnWWWDownload = new System.Windows.Forms.Button();
            btnMailMAPIsend = new System.Windows.Forms.Button();
            lblUser = new System.Windows.Forms.Label();
            lblComputer = new System.Windows.Forms.Label();
            lblUImbox = new System.Windows.Forms.Label();
            panelUI = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            panelUITreeBox = new System.Windows.Forms.Panel();
            pnlLINQ = new System.Windows.Forms.TableLayoutPanel();
            lblOtherToday = new System.Windows.Forms.Label();
            lblOtherNow = new System.Windows.Forms.Label();
            lblAlgWrap = new System.Windows.Forms.Label();
            lblAlgCID = new System.Windows.Forms.Label();
            lblAlgAdVAT = new System.Windows.Forms.Label();
            lblAlgAdName = new System.Windows.Forms.Label();
            lblAlgAdStreet = new System.Windows.Forms.Label();
            lblAlgAdCity = new System.Windows.Forms.Label();
            lblAlgAdZip = new System.Windows.Forms.Label();
            lblOtherAppPathStartup = new System.Windows.Forms.Label();
            lblOtherAppPathExe = new System.Windows.Forms.Label();
            lblOtherAppProdName = new System.Windows.Forms.Label();
            lblOtherAppProdVer = new System.Windows.Forms.Label();
            btnLangDelgGUItest = new System.Windows.Forms.Button();
            btnLangDelgTest = new System.Windows.Forms.Button();
            lblOtherProcName = new System.Windows.Forms.Label();
            gbLangDelg = new System.Windows.Forms.GroupBox();
            panelLangDelg = new System.Windows.Forms.TableLayoutPanel();
            gbLangRefl = new System.Windows.Forms.GroupBox();
            lblLangRefl4 = new System.Windows.Forms.Label();
            lblLangRefl3 = new System.Windows.Forms.Label();
            lbLangRefl = new System.Windows.Forms.Label();
            lblLangRefl2 = new System.Windows.Forms.Label();
            btnLangException = new System.Windows.Forms.Button();
            btnLangMemberAccess = new System.Windows.Forms.Button();
            gbOtherProcess = new System.Windows.Forms.GroupBox();
            lblOtherProc = new System.Windows.Forms.Label();
            panelOtherProc = new System.Windows.Forms.TableLayoutPanel();
            gbAlgNum = new System.Windows.Forms.GroupBox();
            gbWrapText = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            gbServiceAccnt = new System.Windows.Forms.GroupBox();
            lblServiceUser = new System.Windows.Forms.Label();
            lblServiceAccount = new System.Windows.Forms.Label();
            lblSerticePwd = new System.Windows.Forms.Label();
            lblServiceName = new System.Windows.Forms.Label();
            lblServiceFile = new System.Windows.Forms.Label();
            gbMailSMTP = new System.Windows.Forms.GroupBox();
            lblMailSMPTport = new System.Windows.Forms.Label();
            lblMailFrom = new System.Windows.Forms.Label();
            lblMailSMTPpwd = new System.Windows.Forms.Label();
            lblMailSMTPuser = new System.Windows.Forms.Label();
            btnMailSMTPsend = new System.Windows.Forms.Button();
            lblMailSMTPserver = new System.Windows.Forms.Label();
            lblMailSubject = new System.Windows.Forms.Label();
            lblMailCopy = new System.Windows.Forms.Label();
            lblMailRcp = new System.Windows.Forms.Label();
            lblWWWcontent = new System.Windows.Forms.Label();
            lblWWWURL = new System.Windows.Forms.Label();
            gbLINQtoXML.SuspendLayout();
            gbLINQobj.SuspendLayout();
            gbLINQds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLINQds)).BeginInit();
            gbIOfileWatch.SuspendLayout();
            panelUI.SuspendLayout();
            panelUITreeBox.SuspendLayout();
            pnlLINQ.SuspendLayout();
            gbLangDelg.SuspendLayout();
            panelLangDelg.SuspendLayout();
            gbLangRefl.SuspendLayout();
            gbOtherProcess.SuspendLayout();
            panelOtherProc.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tabAlg.SuspendLayout();
            this.gbAlgCutDiactric.SuspendLayout();
            gbAlgNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgNum)).BeginInit();
            gbWrapText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgWrap)).BeginInit();
            this.gbAlgCID.SuspendLayout();
            this.tabLang.SuspendLayout();
            this.tabFileIO.SuspendLayout();
            this.gbIOzip.SuspendLayout();
            this.panelIOzip.SuspendLayout();
            this.tabXMLread.SuspendLayout();
            this.tabLINQ.SuspendLayout();
            this.tabService.SuspendLayout();
            gbServiceAccnt.SuspendLayout();
            this.tabMail.SuspendLayout();
            gbMailSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailSMPTport)).BeginInit();
            this.tabWeb.SuspendLayout();
            this.tabUI.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUIlist
            // 
            lblUIlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUIlist.AutoSize = true;
            lblUIlist.Location = new System.Drawing.Point(3, 7);
            lblUIlist.Name = "lblUIlist";
            lblUIlist.Size = new System.Drawing.Size(73, 13);
            lblUIlist.TabIndex = 0;
            lblUIlist.Text = "List with icons";
            lblUIlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUItree
            // 
            lblUItree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUItree.AutoSize = true;
            lblUItree.Location = new System.Drawing.Point(316, 7);
            lblUItree.Name = "lblUItree";
            lblUItree.Size = new System.Drawing.Size(116, 13);
            lblUItree.TabIndex = 2;
            lblUItree.Text = "Owner drawn tree view";
            // 
            // gbLINQtoXML
            // 
            gbLINQtoXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbLINQtoXML.Controls.Add(this.rbLINQxmlAccnt);
            gbLINQtoXML.Controls.Add(this.rbLINQxmlDeliv);
            gbLINQtoXML.Controls.Add(lblLinqAddr);
            gbLINQtoXML.Controls.Add(rbLINQxmlAll);
            gbLINQtoXML.Controls.Add(this.tbLINQxml);
            gbLINQtoXML.Controls.Add(lblLINQxml);
            gbLINQtoXML.Controls.Add(this.btnLINQselXML);
            gbLINQtoXML.Controls.Add(this.listLINQxml);
            gbLINQtoXML.Location = new System.Drawing.Point(3, 6);
            gbLINQtoXML.Name = "gbLINQtoXML";
            gbLINQtoXML.Size = new System.Drawing.Size(620, 224);
            gbLINQtoXML.TabIndex = 0;
            gbLINQtoXML.TabStop = false;
            gbLINQtoXML.Text = "LINQ to XML";
            // 
            // rbLINQxmlAccnt
            // 
            this.rbLINQxmlAccnt.AutoSize = true;
            this.rbLINQxmlAccnt.Location = new System.Drawing.Point(271, 47);
            this.rbLINQxmlAccnt.Name = "rbLINQxmlAccnt";
            this.rbLINQxmlAccnt.Size = new System.Drawing.Size(64, 17);
            this.rbLINQxmlAccnt.TabIndex = 6;
            this.rbLINQxmlAccnt.Text = "account";
            this.rbLINQxmlAccnt.UseVisualStyleBackColor = true;
            this.rbLINQxmlAccnt.Click += new System.EventHandler(this.rbLINQxml_Click);
            // 
            // rbLINQxmlDeliv
            // 
            this.rbLINQxmlDeliv.AutoSize = true;
            this.rbLINQxmlDeliv.Location = new System.Drawing.Point(190, 47);
            this.rbLINQxmlDeliv.Name = "rbLINQxmlDeliv";
            this.rbLINQxmlDeliv.Size = new System.Drawing.Size(61, 17);
            this.rbLINQxmlDeliv.TabIndex = 5;
            this.rbLINQxmlDeliv.Text = "delivery";
            this.rbLINQxmlDeliv.UseVisualStyleBackColor = true;
            this.rbLINQxmlDeliv.Click += new System.EventHandler(this.rbLINQxml_Click);
            // 
            // lblLinqAddr
            // 
            lblLinqAddr.AutoSize = true;
            lblLinqAddr.Location = new System.Drawing.Point(10, 47);
            lblLinqAddr.Name = "lblLinqAddr";
            lblLinqAddr.Size = new System.Drawing.Size(88, 13);
            lblLinqAddr.TabIndex = 3;
            lblLinqAddr.Text = "Show addresses:";
            // 
            // rbLINQxmlAll
            // 
            rbLINQxmlAll.AutoSize = true;
            rbLINQxmlAll.Checked = true;
            rbLINQxmlAll.Location = new System.Drawing.Point(104, 47);
            rbLINQxmlAll.Name = "rbLINQxmlAll";
            rbLINQxmlAll.Size = new System.Drawing.Size(35, 17);
            rbLINQxmlAll.TabIndex = 4;
            rbLINQxmlAll.TabStop = true;
            rbLINQxmlAll.Text = "all";
            rbLINQxmlAll.UseVisualStyleBackColor = true;
            rbLINQxmlAll.Click += new System.EventHandler(this.rbLINQxml_Click);
            // 
            // tbLINQxml
            // 
            this.tbLINQxml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLINQxml.BackColor = System.Drawing.SystemColors.Window;
            this.tbLINQxml.Location = new System.Drawing.Point(104, 19);
            this.tbLINQxml.Name = "tbLINQxml";
            this.tbLINQxml.ReadOnly = true;
            this.tbLINQxml.Size = new System.Drawing.Size(482, 20);
            this.tbLINQxml.TabIndex = 1;
            this.tbLINQxml.Text = "AddrTest.xml";
            // 
            // lblLINQxml
            // 
            lblLINQxml.AutoSize = true;
            lblLINQxml.Location = new System.Drawing.Point(10, 23);
            lblLINQxml.Name = "lblLINQxml";
            lblLINQxml.Size = new System.Drawing.Size(88, 13);
            lblLINQxml.TabIndex = 0;
            lblLINQxml.Text = "XML address file:";
            // 
            // btnLINQselXML
            // 
            this.btnLINQselXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLINQselXML.Location = new System.Drawing.Point(587, 19);
            this.btnLINQselXML.Name = "btnLINQselXML";
            this.btnLINQselXML.Size = new System.Drawing.Size(28, 20);
            this.btnLINQselXML.TabIndex = 2;
            this.btnLINQselXML.Text = "...";
            this.btnLINQselXML.UseVisualStyleBackColor = true;
            this.btnLINQselXML.Click += new System.EventHandler(this.btnLINQxmlSel_Click);
            // 
            // listLINQxml
            // 
            this.listLINQxml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLINQxml.GridLines = true;
            this.listLINQxml.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listLINQxml.HideSelection = false;
            this.listLINQxml.Location = new System.Drawing.Point(5, 72);
            this.listLINQxml.Name = "listLINQxml";
            this.listLINQxml.Size = new System.Drawing.Size(610, 146);
            this.listLINQxml.TabIndex = 7;
            this.listLINQxml.UseCompatibleStateImageBehavior = false;
            this.listLINQxml.View = System.Windows.Forms.View.Details;
            // 
            // gbLINQobj
            // 
            gbLINQobj.Controls.Add(btnLINQselObj);
            gbLINQobj.Controls.Add(this.tbLINQobj);
            gbLINQobj.Controls.Add(lblLINQobj);
            gbLINQobj.Controls.Add(this.listLINQobj);
            gbLINQobj.Dock = System.Windows.Forms.DockStyle.Fill;
            gbLINQobj.Location = new System.Drawing.Point(3, 3);
            gbLINQobj.Name = "gbLINQobj";
            gbLINQobj.Size = new System.Drawing.Size(305, 172);
            gbLINQobj.TabIndex = 0;
            gbLINQobj.TabStop = false;
            gbLINQobj.Text = "LINQ to Objects";
            // 
            // btnLINQselObj
            // 
            btnLINQselObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnLINQselObj.Location = new System.Drawing.Point(271, 31);
            btnLINQselObj.Name = "btnLINQselObj";
            btnLINQselObj.Size = new System.Drawing.Size(28, 20);
            btnLINQselObj.TabIndex = 2;
            btnLINQselObj.Text = "...";
            btnLINQselObj.UseVisualStyleBackColor = true;
            btnLINQselObj.Click += new System.EventHandler(this.btnLINQselObj_Click);
            // 
            // tbLINQobj
            // 
            this.tbLINQobj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLINQobj.BackColor = System.Drawing.SystemColors.Window;
            this.tbLINQobj.Location = new System.Drawing.Point(6, 31);
            this.tbLINQobj.Name = "tbLINQobj";
            this.tbLINQobj.ReadOnly = true;
            this.tbLINQobj.Size = new System.Drawing.Size(265, 20);
            this.tbLINQobj.TabIndex = 1;
            // 
            // lblLINQobj
            // 
            lblLINQobj.AutoSize = true;
            lblLINQobj.Location = new System.Drawing.Point(6, 16);
            lblLINQobj.Name = "lblLINQobj";
            lblLINQobj.Size = new System.Drawing.Size(100, 13);
            lblLINQobj.TabIndex = 0;
            lblLINQobj.Text = "Files in the directory";
            // 
            // listLINQobj
            // 
            this.listLINQobj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLINQobj.FormattingEnabled = true;
            this.listLINQobj.IntegralHeight = false;
            this.listLINQobj.Location = new System.Drawing.Point(5, 53);
            this.listLINQobj.Name = "listLINQobj";
            this.listLINQobj.Size = new System.Drawing.Size(294, 113);
            this.listLINQobj.TabIndex = 3;
            // 
            // gbLINQds
            // 
            gbLINQds.Controls.Add(this.dgLINQds);
            gbLINQds.Dock = System.Windows.Forms.DockStyle.Fill;
            gbLINQds.Location = new System.Drawing.Point(314, 3);
            gbLINQds.Name = "gbLINQds";
            gbLINQds.Size = new System.Drawing.Size(306, 172);
            gbLINQds.TabIndex = 1;
            gbLINQds.TabStop = false;
            gbLINQds.Text = "LINQ to DataSet";
            // 
            // dgLINQds
            // 
            this.dgLINQds.AllowUserToAddRows = false;
            this.dgLINQds.AllowUserToDeleteRows = false;
            this.dgLINQds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLINQds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLINQds.Location = new System.Drawing.Point(3, 16);
            this.dgLINQds.Name = "dgLINQds";
            this.dgLINQds.ReadOnly = true;
            this.dgLINQds.Size = new System.Drawing.Size(300, 153);
            this.dgLINQds.TabIndex = 0;
            // 
            // lblXML
            // 
            lblXML.AutoSize = true;
            lblXML.Location = new System.Drawing.Point(20, 27);
            lblXML.Name = "lblXML";
            lblXML.Size = new System.Drawing.Size(48, 13);
            lblXML.TabIndex = 0;
            lblXML.Text = "XML file:";
            // 
            // btnXmlSerialize
            // 
            btnXmlSerialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnXmlSerialize.Location = new System.Drawing.Point(466, 372);
            btnXmlSerialize.Name = "btnXmlSerialize";
            btnXmlSerialize.Size = new System.Drawing.Size(160, 36);
            btnXmlSerialize.TabIndex = 6;
            btnXmlSerialize.Text = "Serialize items to file";
            btnXmlSerialize.UseVisualStyleBackColor = true;
            btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
            // 
            // btnXMLParse
            // 
            btnXMLParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnXMLParse.Location = new System.Drawing.Point(301, 372);
            btnXMLParse.Name = "btnXMLParse";
            btnXMLParse.Size = new System.Drawing.Size(160, 36);
            btnXMLParse.TabIndex = 5;
            btnXMLParse.Text = "Parse items from file";
            btnXMLParse.UseVisualStyleBackColor = true;
            btnXMLParse.Click += new System.EventHandler(this.btnXMLParse_Click);
            // 
            // lblXmlItems
            // 
            lblXmlItems.AutoSize = true;
            lblXmlItems.Location = new System.Drawing.Point(5, 55);
            lblXmlItems.Name = "lblXmlItems";
            lblXmlItems.Size = new System.Drawing.Size(59, 13);
            lblXmlItems.TabIndex = 3;
            lblXmlItems.Text = "XML items:";
            // 
            // gbIOfileWatch
            // 
            gbIOfileWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbIOfileWatch.Controls.Add(this.btnIOfileSel);
            gbIOfileWatch.Controls.Add(lblIOfileLastWrite);
            gbIOfileWatch.Controls.Add(this.tbIOfileContent);
            gbIOfileWatch.Controls.Add(this.dtIOfileModified);
            gbIOfileWatch.Controls.Add(lblIOfile);
            gbIOfileWatch.Controls.Add(this.tbIOfile);
            gbIOfileWatch.Controls.Add(lblIOfileContent);
            gbIOfileWatch.Location = new System.Drawing.Point(0, 214);
            gbIOfileWatch.Name = "gbIOfileWatch";
            gbIOfileWatch.Size = new System.Drawing.Size(626, 194);
            gbIOfileWatch.TabIndex = 2;
            gbIOfileWatch.TabStop = false;
            gbIOfileWatch.Text = "File watcher";
            // 
            // btnIOfileSel
            // 
            this.btnIOfileSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIOfileSel.Location = new System.Drawing.Point(590, 18);
            this.btnIOfileSel.Name = "btnIOfileSel";
            this.btnIOfileSel.Size = new System.Drawing.Size(28, 21);
            this.btnIOfileSel.TabIndex = 2;
            this.btnIOfileSel.Text = "...";
            this.btnIOfileSel.UseVisualStyleBackColor = true;
            this.btnIOfileSel.Click += new System.EventHandler(this.btnIOfileWatchSel_Click);
            // 
            // lblIOfileLastWrite
            // 
            lblIOfileLastWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblIOfileLastWrite.AutoSize = true;
            lblIOfileLastWrite.Location = new System.Drawing.Point(383, 44);
            lblIOfileLastWrite.Name = "lblIOfileLastWrite";
            lblIOfileLastWrite.Size = new System.Drawing.Size(55, 13);
            lblIOfileLastWrite.TabIndex = 4;
            lblIOfileLastWrite.Text = "Last write:";
            // 
            // tbIOfileContent
            // 
            this.tbIOfileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIOfileContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbIOfileContent.Location = new System.Drawing.Point(6, 63);
            this.tbIOfileContent.Multiline = true;
            this.tbIOfileContent.Name = "tbIOfileContent";
            this.tbIOfileContent.ReadOnly = true;
            this.tbIOfileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIOfileContent.Size = new System.Drawing.Size(615, 122);
            this.tbIOfileContent.TabIndex = 6;
            // 
            // dtIOfileModified
            // 
            this.dtIOfileModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIOfileModified.CustomFormat = "\"d.M.yyy HH:mm:ss\"";
            this.dtIOfileModified.Enabled = false;
            this.dtIOfileModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIOfileModified.Location = new System.Drawing.Point(444, 40);
            this.dtIOfileModified.Name = "dtIOfileModified";
            this.dtIOfileModified.Size = new System.Drawing.Size(147, 20);
            this.dtIOfileModified.TabIndex = 5;
            // 
            // lblIOfile
            // 
            lblIOfile.AutoSize = true;
            lblIOfile.Location = new System.Drawing.Point(6, 22);
            lblIOfile.Name = "lblIOfile";
            lblIOfile.Size = new System.Drawing.Size(75, 13);
            lblIOfile.TabIndex = 0;
            lblIOfile.Text = "File to monitor:";
            // 
            // tbIOfile
            // 
            this.tbIOfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIOfile.BackColor = System.Drawing.SystemColors.Window;
            this.tbIOfile.Enabled = false;
            this.tbIOfile.Location = new System.Drawing.Point(90, 19);
            this.tbIOfile.Name = "tbIOfile";
            this.tbIOfile.ReadOnly = true;
            this.tbIOfile.Size = new System.Drawing.Size(501, 20);
            this.tbIOfile.TabIndex = 1;
            this.tbIOfile.Text = "C:\\AUTOEXEC.BAT ";
            // 
            // lblIOfileContent
            // 
            lblIOfileContent.AutoSize = true;
            lblIOfileContent.Location = new System.Drawing.Point(8, 47);
            lblIOfileContent.Name = "lblIOfileContent";
            lblIOfileContent.Size = new System.Drawing.Size(65, 13);
            lblIOfileContent.TabIndex = 3;
            lblIOfileContent.Text = "File content:";
            // 
            // lblIOclass
            // 
            lblIOclass.AutoSize = true;
            lblIOclass.Location = new System.Drawing.Point(3, 6);
            lblIOclass.Name = "lblIOclass";
            lblIOclass.Size = new System.Drawing.Size(121, 13);
            lblIOclass.TabIndex = 0;
            lblIOclass.Text = "Path && Directory classes";
            // 
            // btnWWWDownload
            // 
            btnWWWDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnWWWDownload.Location = new System.Drawing.Point(537, 19);
            btnWWWDownload.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            btnWWWDownload.Name = "btnWWWDownload";
            btnWWWDownload.Size = new System.Drawing.Size(81, 22);
            btnWWWDownload.TabIndex = 2;
            btnWWWDownload.Text = "Download";
            btnWWWDownload.UseVisualStyleBackColor = true;
            btnWWWDownload.Click += new System.EventHandler(this.btnWWWDownload_Click);
            // 
            // btnMailMAPIsend
            // 
            btnMailMAPIsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnMailMAPIsend.Location = new System.Drawing.Point(8, 236);
            btnMailMAPIsend.Name = "btnMailMAPIsend";
            btnMailMAPIsend.Size = new System.Drawing.Size(610, 32);
            btnMailMAPIsend.TabIndex = 7;
            btnMailMAPIsend.Text = "Send mail by simple MAPI";
            btnMailMAPIsend.UseVisualStyleBackColor = true;
            btnMailMAPIsend.Click += new System.EventHandler(this.btnMailMAPIsend_Click);
            // 
            // lblUser
            // 
            lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(366, 449);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(67, 13);
            lblUser.TabIndex = 2;
            lblUser.Text = "Current user:";
            // 
            // lblComputer
            // 
            lblComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblComputer.AutoSize = true;
            lblComputer.Location = new System.Drawing.Point(140, 449);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new System.Drawing.Size(84, 13);
            lblComputer.TabIndex = 4;
            lblComputer.Text = "Computer name:";
            // 
            // lblUImbox
            // 
            lblUImbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUImbox.AutoSize = true;
            lblUImbox.Location = new System.Drawing.Point(3, 196);
            lblUImbox.Name = "lblUImbox";
            lblUImbox.Size = new System.Drawing.Size(100, 13);
            lblUImbox.TabIndex = 4;
            lblUImbox.Text = "Message Box Icons";
            // 
            // panelUI
            // 
            panelUI.ColumnCount = 2;
            panelUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelUI.Controls.Add(this.btnUImbox, 0, 4);
            panelUI.Controls.Add(lblUImbox, 0, 2);
            panelUI.Controls.Add(this.listUImbox, 0, 3);
            panelUI.Controls.Add(this.treeUI, 1, 1);
            panelUI.Controls.Add(this.listUI, 0, 1);
            panelUI.Controls.Add(lblUIlist, 0, 0);
            panelUI.Controls.Add(lblUItree, 1, 0);
            panelUI.Controls.Add(label1, 1, 2);
            panelUI.Controls.Add(panelUITreeBox, 1, 3);
            panelUI.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUI.Location = new System.Drawing.Point(0, 0);
            panelUI.Name = "panelUI";
            panelUI.RowCount = 5;
            panelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            panelUI.Size = new System.Drawing.Size(626, 408);
            panelUI.TabIndex = 0;
            // 
            // btnUImbox
            // 
            this.btnUImbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUImbox.Location = new System.Drawing.Point(3, 378);
            this.btnUImbox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnUImbox.Name = "btnUImbox";
            this.btnUImbox.Size = new System.Drawing.Size(307, 27);
            this.btnUImbox.TabIndex = 6;
            this.btnUImbox.Text = "Call message box";
            this.btnUImbox.UseVisualStyleBackColor = true;
            this.btnUImbox.Click += new System.EventHandler(this.btnUImbox_Click);
            // 
            // listUImbox
            // 
            this.listUImbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUImbox.FullRowSelect = true;
            this.listUImbox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listUImbox.HideSelection = false;
            this.listUImbox.Location = new System.Drawing.Point(3, 212);
            this.listUImbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listUImbox.Name = "listUImbox";
            this.listUImbox.Size = new System.Drawing.Size(307, 166);
            this.listUImbox.TabIndex = 5;
            this.listUImbox.UseCompatibleStateImageBehavior = false;
            this.listUImbox.View = System.Windows.Forms.View.Details;
            this.listUImbox.DoubleClick += new System.EventHandler(this.btnUImbox_Click);
            this.listUImbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listUImbox_KeyDown);
            // 
            // treeUI
            // 
            this.treeUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeUI.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeUI.Location = new System.Drawing.Point(316, 23);
            this.treeUI.Name = "treeUI";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Subpoložka 1";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Polozka 1";
            treeNode15.Name = "Node3";
            treeNode15.Text = "Subpoložka 2";
            treeNode16.Name = "Node4";
            treeNode16.Text = "Subpoložka 3";
            treeNode17.Name = "Node5";
            treeNode17.Text = "Subpoložka 4";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Položka 2";
            this.treeUI.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode18});
            this.treeUI.Size = new System.Drawing.Size(307, 163);
            this.treeUI.TabIndex = 3;
            this.treeUI.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeUI_DrawNode);
            // 
            // listUI
            // 
            this.listUI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrCol1,
            this.hdrCol2,
            this.hdrCol3});
            this.listUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUI.FullRowSelect = true;
            this.listUI.GridLines = true;
            this.listUI.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listUI.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listUI.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listUI.Location = new System.Drawing.Point(3, 23);
            this.listUI.Name = "listUI";
            this.listUI.Size = new System.Drawing.Size(307, 163);
            this.listUI.SmallImageList = this.imageList;
            this.listUI.TabIndex = 1;
            this.listUI.UseCompatibleStateImageBehavior = false;
            this.listUI.View = System.Windows.Forms.View.Details;
            // 
            // hdrCol1
            // 
            this.hdrCol1.Text = "Column1";
            this.hdrCol1.Width = 150;
            // 
            // hdrCol2
            // 
            this.hdrCol2.Text = "Column2";
            this.hdrCol2.Width = 100;
            // 
            // hdrCol3
            // 
            this.hdrCol3.Text = "Column3";
            this.hdrCol3.Width = 59;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Close.gif");
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(316, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 13);
            label1.TabIndex = 7;
            label1.Text = "TreeBox - ComboBox with dropdown TreeView";
            // 
            // panelUITreeBox
            // 
            panelUITreeBox.Controls.Add(this.chbUITreeBoxEditable);
            panelUITreeBox.Controls.Add(this.chbUITreeBoxEnabled);
            panelUITreeBox.Controls.Add(this.tbUI);
            panelUITreeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            panelUITreeBox.Location = new System.Drawing.Point(316, 212);
            panelUITreeBox.Name = "panelUITreeBox";
            panelUITreeBox.Size = new System.Drawing.Size(307, 163);
            panelUITreeBox.TabIndex = 9;
            // 
            // chbUITreeBoxEditable
            // 
            this.chbUITreeBoxEditable.AutoSize = true;
            this.chbUITreeBoxEditable.Location = new System.Drawing.Point(100, 27);
            this.chbUITreeBoxEditable.Name = "chbUITreeBoxEditable";
            this.chbUITreeBoxEditable.Size = new System.Drawing.Size(83, 17);
            this.chbUITreeBoxEditable.TabIndex = 10;
            this.chbUITreeBoxEditable.Text = "text editable";
            this.chbUITreeBoxEditable.UseVisualStyleBackColor = true;
            this.chbUITreeBoxEditable.CheckedChanged += new System.EventHandler(this.chbUITreeBoxEditable_CheckedChanged);
            // 
            // chbUITreeBoxEnabled
            // 
            this.chbUITreeBoxEnabled.AutoSize = true;
            this.chbUITreeBoxEnabled.Location = new System.Drawing.Point(3, 27);
            this.chbUITreeBoxEnabled.Name = "chbUITreeBoxEnabled";
            this.chbUITreeBoxEnabled.Size = new System.Drawing.Size(64, 17);
            this.chbUITreeBoxEnabled.TabIndex = 9;
            this.chbUITreeBoxEnabled.Text = "enabled";
            this.chbUITreeBoxEnabled.UseVisualStyleBackColor = true;
            this.chbUITreeBoxEnabled.CheckedChanged += new System.EventHandler(this.chbUITreeBoxEnabled_CheckedChanged);
            // 
            // pnlLINQ
            // 
            pnlLINQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pnlLINQ.ColumnCount = 2;
            pnlLINQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.Controls.Add(gbLINQds, 1, 0);
            pnlLINQ.Controls.Add(gbLINQobj, 0, 0);
            pnlLINQ.Location = new System.Drawing.Point(0, 230);
            pnlLINQ.Name = "pnlLINQ";
            pnlLINQ.RowCount = 1;
            pnlLINQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.Size = new System.Drawing.Size(623, 178);
            pnlLINQ.TabIndex = 1;
            // 
            // lblOtherToday
            // 
            lblOtherToday.AutoSize = true;
            lblOtherToday.Location = new System.Drawing.Point(49, 104);
            lblOtherToday.Name = "lblOtherToday";
            lblOtherToday.Size = new System.Drawing.Size(89, 13);
            lblOtherToday.TabIndex = 10;
            lblOtherToday.Text = "DateTime.Today:";
            // 
            // lblOtherNow
            // 
            lblOtherNow.AutoSize = true;
            lblOtherNow.Location = new System.Drawing.Point(49, 84);
            lblOtherNow.Name = "lblOtherNow";
            lblOtherNow.Size = new System.Drawing.Size(81, 13);
            lblOtherNow.TabIndex = 8;
            lblOtherNow.Text = "DateTime.Now:";
            // 
            // lblAlgWrap
            // 
            lblAlgWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAlgWrap.AutoSize = true;
            lblAlgWrap.Location = new System.Drawing.Point(511, 17);
            lblAlgWrap.Name = "lblAlgWrap";
            lblAlgWrap.Size = new System.Drawing.Size(104, 13);
            lblAlgWrap.TabIndex = 2;
            lblAlgWrap.Text = "Required line length:";
            // 
            // lblAlgCID
            // 
            lblAlgCID.AutoSize = true;
            lblAlgCID.Location = new System.Drawing.Point(9, 20);
            lblAlgCID.Name = "lblAlgCID";
            lblAlgCID.Size = new System.Drawing.Size(68, 13);
            lblAlgCID.TabIndex = 0;
            lblAlgCID.Text = "Company ID:";
            // 
            // lblAlgAdVAT
            // 
            lblAlgAdVAT.AutoSize = true;
            lblAlgAdVAT.Location = new System.Drawing.Point(9, 63);
            lblAlgAdVAT.Name = "lblAlgAdVAT";
            lblAlgAdVAT.Size = new System.Drawing.Size(45, 13);
            lblAlgAdVAT.TabIndex = 2;
            lblAlgAdVAT.Text = "VAT ID:";
            // 
            // lblAlgAdName
            // 
            lblAlgAdName.AutoSize = true;
            lblAlgAdName.Location = new System.Drawing.Point(158, 21);
            lblAlgAdName.Name = "lblAlgAdName";
            lblAlgAdName.Size = new System.Drawing.Size(38, 13);
            lblAlgAdName.TabIndex = 4;
            lblAlgAdName.Text = "Name:";
            // 
            // lblAlgAdStreet
            // 
            lblAlgAdStreet.AutoSize = true;
            lblAlgAdStreet.Location = new System.Drawing.Point(158, 42);
            lblAlgAdStreet.Name = "lblAlgAdStreet";
            lblAlgAdStreet.Size = new System.Drawing.Size(38, 13);
            lblAlgAdStreet.TabIndex = 6;
            lblAlgAdStreet.Text = "Street:";
            // 
            // lblAlgAdCity
            // 
            lblAlgAdCity.AutoSize = true;
            lblAlgAdCity.Location = new System.Drawing.Point(169, 63);
            lblAlgAdCity.Name = "lblAlgAdCity";
            lblAlgAdCity.Size = new System.Drawing.Size(27, 13);
            lblAlgAdCity.TabIndex = 8;
            lblAlgAdCity.Text = "City:";
            // 
            // lblAlgAdZip
            // 
            lblAlgAdZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAlgAdZip.AutoSize = true;
            lblAlgAdZip.Location = new System.Drawing.Point(420, 64);
            lblAlgAdZip.Name = "lblAlgAdZip";
            lblAlgAdZip.Size = new System.Drawing.Size(25, 13);
            lblAlgAdZip.TabIndex = 10;
            lblAlgAdZip.Text = "Zip:";
            // 
            // lblOtherAppPathStartup
            // 
            lblOtherAppPathStartup.AutoSize = true;
            lblOtherAppPathStartup.Location = new System.Drawing.Point(21, 35);
            lblOtherAppPathStartup.Name = "lblOtherAppPathStartup";
            lblOtherAppPathStartup.Size = new System.Drawing.Size(121, 13);
            lblOtherAppPathStartup.TabIndex = 2;
            lblOtherAppPathStartup.Text = "Application.StartupPath:";
            // 
            // lblOtherAppPathExe
            // 
            lblOtherAppPathExe.AutoSize = true;
            lblOtherAppPathExe.Location = new System.Drawing.Point(4, 14);
            lblOtherAppPathExe.Name = "lblOtherAppPathExe";
            lblOtherAppPathExe.Size = new System.Drawing.Size(140, 13);
            lblOtherAppPathExe.TabIndex = 0;
            lblOtherAppPathExe.Text = "Application.ExecutablePath:";
            // 
            // lblOtherAppProdName
            // 
            lblOtherAppProdName.AutoSize = true;
            lblOtherAppProdName.Location = new System.Drawing.Point(14, 58);
            lblOtherAppProdName.Name = "lblOtherAppProdName";
            lblOtherAppProdName.Size = new System.Drawing.Size(130, 13);
            lblOtherAppProdName.TabIndex = 4;
            lblOtherAppProdName.Text = "Application.ProductName:";
            // 
            // lblOtherAppProdVer
            // 
            lblOtherAppProdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblOtherAppProdVer.AutoSize = true;
            lblOtherAppProdVer.Location = new System.Drawing.Point(391, 58);
            lblOtherAppProdVer.Name = "lblOtherAppProdVer";
            lblOtherAppProdVer.Size = new System.Drawing.Size(137, 13);
            lblOtherAppProdVer.TabIndex = 6;
            lblOtherAppProdVer.Text = "Application.ProductVersion:";
            // 
            // btnLangDelgGUItest
            // 
            btnLangDelgGUItest.Dock = System.Windows.Forms.DockStyle.Fill;
            btnLangDelgGUItest.Location = new System.Drawing.Point(305, 0);
            btnLangDelgGUItest.Margin = new System.Windows.Forms.Padding(0);
            btnLangDelgGUItest.Name = "btnLangDelgGUItest";
            btnLangDelgGUItest.Size = new System.Drawing.Size(306, 30);
            btnLangDelgGUItest.TabIndex = 1;
            btnLangDelgGUItest.Text = "Control.BeginInvoke - GUI test";
            btnLangDelgGUItest.UseVisualStyleBackColor = true;
            btnLangDelgGUItest.Click += new System.EventHandler(this.btnLangDelgGUItest_Click);
            // 
            // btnLangDelgTest
            // 
            btnLangDelgTest.Dock = System.Windows.Forms.DockStyle.Fill;
            btnLangDelgTest.Location = new System.Drawing.Point(0, 0);
            btnLangDelgTest.Margin = new System.Windows.Forms.Padding(0);
            btnLangDelgTest.Name = "btnLangDelgTest";
            btnLangDelgTest.Size = new System.Drawing.Size(305, 30);
            btnLangDelgTest.TabIndex = 0;
            btnLangDelgTest.Text = "Delegate\'s BeginInvoke test";
            btnLangDelgTest.UseVisualStyleBackColor = true;
            btnLangDelgTest.Click += new System.EventHandler(this.btnLangDelgTest_Click);
            // 
            // lblOtherProcName
            // 
            lblOtherProcName.AutoSize = true;
            lblOtherProcName.Location = new System.Drawing.Point(13, 27);
            lblOtherProcName.Name = "lblOtherProcName";
            lblOtherProcName.Size = new System.Drawing.Size(38, 13);
            lblOtherProcName.TabIndex = 0;
            lblOtherProcName.Text = "Name:";
            // 
            // gbLangDelg
            // 
            gbLangDelg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbLangDelg.Controls.Add(panelLangDelg);
            gbLangDelg.Location = new System.Drawing.Point(0, 83);
            gbLangDelg.Name = "gbLangDelg";
            gbLangDelg.Size = new System.Drawing.Size(626, 93);
            gbLangDelg.TabIndex = 0;
            gbLangDelg.TabStop = false;
            gbLangDelg.Text = "Delegates";
            // 
            // panelLangDelg
            // 
            panelLangDelg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panelLangDelg.ColumnCount = 2;
            panelLangDelg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelLangDelg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelLangDelg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panelLangDelg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panelLangDelg.Controls.Add(this.btnLangDelgLambda, 1, 1);
            panelLangDelg.Controls.Add(this.btnLangDelgAnonymous, 0, 1);
            panelLangDelg.Controls.Add(btnLangDelgGUItest, 1, 0);
            panelLangDelg.Controls.Add(btnLangDelgTest, 0, 0);
            panelLangDelg.Location = new System.Drawing.Point(8, 19);
            panelLangDelg.Name = "panelLangDelg";
            panelLangDelg.RowCount = 2;
            panelLangDelg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelLangDelg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelLangDelg.Size = new System.Drawing.Size(611, 61);
            panelLangDelg.TabIndex = 15;
            // 
            // btnLangDelgLambda
            // 
            this.btnLangDelgLambda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLangDelgLambda.Location = new System.Drawing.Point(305, 30);
            this.btnLangDelgLambda.Margin = new System.Windows.Forms.Padding(0);
            this.btnLangDelgLambda.Name = "btnLangDelgLambda";
            this.btnLangDelgLambda.Size = new System.Drawing.Size(306, 31);
            this.btnLangDelgLambda.TabIndex = 3;
            this.btnLangDelgLambda.Text = "Delegate realized as lambda expression";
            this.btnLangDelgLambda.UseVisualStyleBackColor = true;
            // 
            // btnLangDelgAnonymous
            // 
            this.btnLangDelgAnonymous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLangDelgAnonymous.Location = new System.Drawing.Point(0, 30);
            this.btnLangDelgAnonymous.Margin = new System.Windows.Forms.Padding(0);
            this.btnLangDelgAnonymous.Name = "btnLangDelgAnonymous";
            this.btnLangDelgAnonymous.Size = new System.Drawing.Size(305, 31);
            this.btnLangDelgAnonymous.TabIndex = 2;
            this.btnLangDelgAnonymous.Text = "Anonymous delegate";
            this.btnLangDelgAnonymous.UseVisualStyleBackColor = true;
            // 
            // gbLangRefl
            // 
            gbLangRefl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbLangRefl.Controls.Add(this.tbLangReflParam2);
            gbLangRefl.Controls.Add(lblLangRefl4);
            gbLangRefl.Controls.Add(this.cbLangReflParam1);
            gbLangRefl.Controls.Add(lblLangRefl3);
            gbLangRefl.Controls.Add(lbLangRefl);
            gbLangRefl.Controls.Add(this.tbLangReflResult);
            gbLangRefl.Controls.Add(this.cbLangReflType);
            gbLangRefl.Controls.Add(lblLangRefl2);
            gbLangRefl.Location = new System.Drawing.Point(0, 0);
            gbLangRefl.Name = "gbLangRefl";
            gbLangRefl.Size = new System.Drawing.Size(626, 90);
            gbLangRefl.TabIndex = 0;
            gbLangRefl.TabStop = false;
            gbLangRefl.Text = "Reflection";
            // 
            // tbLangReflParam2
            // 
            this.tbLangReflParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangReflParam2.Location = new System.Drawing.Point(432, 18);
            this.tbLangReflParam2.Name = "tbLangReflParam2";
            this.tbLangReflParam2.Size = new System.Drawing.Size(77, 20);
            this.tbLangReflParam2.TabIndex = 3;
            this.tbLangReflParam2.Text = "1";
            // 
            // lblLangRefl4
            // 
            lblLangRefl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl4.AutoSize = true;
            lblLangRefl4.Location = new System.Drawing.Point(607, 19);
            lblLangRefl4.Margin = new System.Windows.Forms.Padding(0);
            lblLangRefl4.Name = "lblLangRefl4";
            lblLangRefl4.Size = new System.Drawing.Size(10, 13);
            lblLangRefl4.TabIndex = 6;
            lblLangRefl4.Text = ")";
            // 
            // cbLangReflParam1
            // 
            this.cbLangReflParam1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLangReflParam1.FormattingEnabled = true;
            this.cbLangReflParam1.Location = new System.Drawing.Point(83, 19);
            this.cbLangReflParam1.Name = "cbLangReflParam1";
            this.cbLangReflParam1.Size = new System.Drawing.Size(330, 21);
            this.cbLangReflParam1.TabIndex = 1;
            // 
            // lblLangRefl3
            // 
            lblLangRefl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl3.AutoSize = true;
            lblLangRefl3.Location = new System.Drawing.Point(512, 22);
            lblLangRefl3.Margin = new System.Windows.Forms.Padding(0);
            lblLangRefl3.Name = "lblLangRefl3";
            lblLangRefl3.Size = new System.Drawing.Size(18, 13);
            lblLangRefl3.TabIndex = 4;
            lblLangRefl3.Text = "as";
            // 
            // lbLangRefl
            // 
            lbLangRefl.AutoSize = true;
            lbLangRefl.Location = new System.Drawing.Point(5, 22);
            lbLangRefl.Name = "lbLangRefl";
            lbLangRefl.Size = new System.Drawing.Size(75, 13);
            lbLangRefl.TabIndex = 0;
            lbLangRefl.Text = "string.Format(\"";
            // 
            // tbLangReflResult
            // 
            this.tbLangReflResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangReflResult.Location = new System.Drawing.Point(83, 43);
            this.tbLangReflResult.Multiline = true;
            this.tbLangReflResult.Name = "tbLangReflResult";
            this.tbLangReflResult.ReadOnly = true;
            this.tbLangReflResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLangReflResult.Size = new System.Drawing.Size(521, 33);
            this.tbLangReflResult.TabIndex = 7;
            // 
            // cbLangReflType
            // 
            this.cbLangReflType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLangReflType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLangReflType.FormattingEnabled = true;
            this.cbLangReflType.Location = new System.Drawing.Point(533, 18);
            this.cbLangReflType.Name = "cbLangReflType";
            this.cbLangReflType.Size = new System.Drawing.Size(71, 21);
            this.cbLangReflType.TabIndex = 5;
            // 
            // lblLangRefl2
            // 
            lblLangRefl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl2.AutoSize = true;
            lblLangRefl2.Location = new System.Drawing.Point(413, 21);
            lblLangRefl2.Margin = new System.Windows.Forms.Padding(0);
            lblLangRefl2.Name = "lblLangRefl2";
            lblLangRefl2.Size = new System.Drawing.Size(18, 13);
            lblLangRefl2.TabIndex = 2;
            lblLangRefl2.Text = "\", ";
            // 
            // btnLangException
            // 
            btnLangException.Location = new System.Drawing.Point(196, 193);
            btnLangException.Name = "btnLangException";
            btnLangException.Size = new System.Drawing.Size(174, 38);
            btnLangException.TabIndex = 2;
            btnLangException.Text = "Inner exception test";
            btnLangException.UseVisualStyleBackColor = true;
            btnLangException.Click += new System.EventHandler(this.btnLangException_Click);
            // 
            // btnLangMemberAccess
            // 
            btnLangMemberAccess.Location = new System.Drawing.Point(19, 193);
            btnLangMemberAccess.Name = "btnLangMemberAccess";
            btnLangMemberAccess.Size = new System.Drawing.Size(174, 38);
            btnLangMemberAccess.TabIndex = 1;
            btnLangMemberAccess.Text = "Private member access test";
            btnLangMemberAccess.UseVisualStyleBackColor = true;
            btnLangMemberAccess.Click += new System.EventHandler(this.btnLangProp_Click);
            // 
            // gbOtherProcess
            // 
            gbOtherProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbOtherProcess.Controls.Add(this.tbOtherProc);
            gbOtherProcess.Controls.Add(lblOtherProc);
            gbOtherProcess.Controls.Add(panelOtherProc);
            gbOtherProcess.Location = new System.Drawing.Point(0, 148);
            gbOtherProcess.Name = "gbOtherProcess";
            gbOtherProcess.Size = new System.Drawing.Size(626, 67);
            gbOtherProcess.TabIndex = 12;
            gbOtherProcess.TabStop = false;
            gbOtherProcess.Text = "Process";
            // 
            // tbOtherProc
            // 
            this.tbOtherProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherProc.Location = new System.Drawing.Point(57, 24);
            this.tbOtherProc.Name = "tbOtherProc";
            this.tbOtherProc.Size = new System.Drawing.Size(182, 20);
            this.tbOtherProc.TabIndex = 1;
            this.tbOtherProc.Text = "firefox";
            // 
            // lblOtherProc
            // 
            lblOtherProc.AutoSize = true;
            lblOtherProc.Location = new System.Drawing.Point(13, 27);
            lblOtherProc.Name = "lblOtherProc";
            lblOtherProc.Size = new System.Drawing.Size(38, 13);
            lblOtherProc.TabIndex = 0;
            lblOtherProc.Text = "Name:";
            // 
            // panelOtherProc
            // 
            panelOtherProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panelOtherProc.ColumnCount = 4;
            panelOtherProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panelOtherProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panelOtherProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panelOtherProc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panelOtherProc.Controls.Add(this.btnOtherMinimizeProcWnd, 0, 0);
            panelOtherProc.Controls.Add(this.btnOtherMaximizeProcWnd, 1, 0);
            panelOtherProc.Controls.Add(this.btnOtherCloseProcWnd, 3, 0);
            panelOtherProc.Controls.Add(this.btnOtherRestoreProcWnd, 2, 0);
            panelOtherProc.Location = new System.Drawing.Point(245, 17);
            panelOtherProc.Name = "panelOtherProc";
            panelOtherProc.RowCount = 1;
            panelOtherProc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelOtherProc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            panelOtherProc.Size = new System.Drawing.Size(373, 35);
            panelOtherProc.TabIndex = 2;
            // 
            // btnOtherMinimizeProcWnd
            // 
            this.btnOtherMinimizeProcWnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherMinimizeProcWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherMinimizeProcWnd.Location = new System.Drawing.Point(1, 1);
            this.btnOtherMinimizeProcWnd.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherMinimizeProcWnd.Name = "btnOtherMinimizeProcWnd";
            this.btnOtherMinimizeProcWnd.Size = new System.Drawing.Size(91, 33);
            this.btnOtherMinimizeProcWnd.TabIndex = 0;
            this.btnOtherMinimizeProcWnd.Text = "Minimize";
            this.btnOtherMinimizeProcWnd.UseVisualStyleBackColor = true;
            this.btnOtherMinimizeProcWnd.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherMaximizeProcWnd
            // 
            this.btnOtherMaximizeProcWnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherMaximizeProcWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherMaximizeProcWnd.Location = new System.Drawing.Point(94, 1);
            this.btnOtherMaximizeProcWnd.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherMaximizeProcWnd.Name = "btnOtherMaximizeProcWnd";
            this.btnOtherMaximizeProcWnd.Size = new System.Drawing.Size(91, 33);
            this.btnOtherMaximizeProcWnd.TabIndex = 1;
            this.btnOtherMaximizeProcWnd.Text = "Maximize";
            this.btnOtherMaximizeProcWnd.UseVisualStyleBackColor = true;
            this.btnOtherMaximizeProcWnd.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherCloseProcWnd
            // 
            this.btnOtherCloseProcWnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherCloseProcWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherCloseProcWnd.Location = new System.Drawing.Point(280, 1);
            this.btnOtherCloseProcWnd.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherCloseProcWnd.Name = "btnOtherCloseProcWnd";
            this.btnOtherCloseProcWnd.Size = new System.Drawing.Size(92, 33);
            this.btnOtherCloseProcWnd.TabIndex = 3;
            this.btnOtherCloseProcWnd.Text = "Close";
            this.btnOtherCloseProcWnd.UseVisualStyleBackColor = true;
            this.btnOtherCloseProcWnd.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherRestoreProcWnd
            // 
            this.btnOtherRestoreProcWnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherRestoreProcWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherRestoreProcWnd.Location = new System.Drawing.Point(187, 1);
            this.btnOtherRestoreProcWnd.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherRestoreProcWnd.Name = "btnOtherRestoreProcWnd";
            this.btnOtherRestoreProcWnd.Size = new System.Drawing.Size(91, 33);
            this.btnOtherRestoreProcWnd.TabIndex = 2;
            this.btnOtherRestoreProcWnd.Text = "Restore";
            this.btnOtherRestoreProcWnd.UseVisualStyleBackColor = true;
            this.btnOtherRestoreProcWnd.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPanel.Controls.Add(this.tabAlg);
            this.tabPanel.Controls.Add(this.tabService);
            this.tabPanel.Controls.Add(this.tabFileIO);
            this.tabPanel.Controls.Add(this.tabLINQ);
            this.tabPanel.Controls.Add(this.tabXMLread);
            this.tabPanel.Controls.Add(this.tabLang);
            this.tabPanel.Controls.Add(this.tabUI);
            this.tabPanel.Controls.Add(this.tabMail);
            this.tabPanel.Controls.Add(this.tabWeb);
            this.tabPanel.Controls.Add(this.tabOther);
            this.tabPanel.Location = new System.Drawing.Point(0, 5);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(634, 434);
            this.tabPanel.TabIndex = 0;
            // 
            // tabAlg
            // 
            this.tabAlg.Controls.Add(this.gbAlgCutDiactric);
            this.tabAlg.Controls.Add(gbAlgNum);
            this.tabAlg.Controls.Add(gbWrapText);
            this.tabAlg.Controls.Add(this.gbAlgCID);
            this.tabAlg.Location = new System.Drawing.Point(4, 22);
            this.tabAlg.Name = "tabAlg";
            this.tabAlg.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlg.Size = new System.Drawing.Size(626, 408);
            this.tabAlg.TabIndex = 11;
            this.tabAlg.Text = "Algorithms";
            this.tabAlg.UseVisualStyleBackColor = true;
            // 
            // gbAlgCutDiactric
            // 
            this.gbAlgCutDiactric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAlgCutDiactric.Controls.Add(this.tbAlgDiactric);
            this.gbAlgCutDiactric.Controls.Add(this.tbAlgDiactricCut);
            this.gbAlgCutDiactric.Controls.Add(this.btnAlgCutDiactric);
            this.gbAlgCutDiactric.Location = new System.Drawing.Point(0, 0);
            this.gbAlgCutDiactric.Name = "gbAlgCutDiactric";
            this.gbAlgCutDiactric.Size = new System.Drawing.Size(626, 71);
            this.gbAlgCutDiactric.TabIndex = 0;
            this.gbAlgCutDiactric.TabStop = false;
            // 
            // tbAlgDiactric
            // 
            this.tbAlgDiactric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgDiactric.Location = new System.Drawing.Point(12, 18);
            this.tbAlgDiactric.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbAlgDiactric.Name = "tbAlgDiactric";
            this.tbAlgDiactric.Size = new System.Drawing.Size(493, 20);
            this.tbAlgDiactric.TabIndex = 0;
            this.tbAlgDiactric.Text = "123 ìšèøøžýáí ÌŠÈØŽÝÁÍ";
            // 
            // tbAlgDiactricCut
            // 
            this.tbAlgDiactricCut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgDiactricCut.Location = new System.Drawing.Point(12, 37);
            this.tbAlgDiactricCut.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbAlgDiactricCut.Name = "tbAlgDiactricCut";
            this.tbAlgDiactricCut.ReadOnly = true;
            this.tbAlgDiactricCut.Size = new System.Drawing.Size(493, 20);
            this.tbAlgDiactricCut.TabIndex = 1;
            // 
            // btnAlgCutDiactric
            // 
            this.btnAlgCutDiactric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgCutDiactric.Location = new System.Drawing.Point(511, 18);
            this.btnAlgCutDiactric.Name = "btnAlgCutDiactric";
            this.btnAlgCutDiactric.Size = new System.Drawing.Size(104, 39);
            this.btnAlgCutDiactric.TabIndex = 2;
            this.btnAlgCutDiactric.Text = "Cut diactric";
            this.btnAlgCutDiactric.UseVisualStyleBackColor = true;
            this.btnAlgCutDiactric.Click += new System.EventHandler(this.btnAlgCutDiactric_Click);
            // 
            // gbAlgNum
            // 
            gbAlgNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbAlgNum.Controls.Add(this.btnAlgNumToText);
            gbAlgNum.Controls.Add(this.nudAlgNum);
            gbAlgNum.Controls.Add(this.tbAlgNumText);
            gbAlgNum.Location = new System.Drawing.Point(0, 63);
            gbAlgNum.Name = "gbAlgNum";
            gbAlgNum.Size = new System.Drawing.Size(626, 53);
            gbAlgNum.TabIndex = 1;
            gbAlgNum.TabStop = false;
            // 
            // btnAlgNumToText
            // 
            this.btnAlgNumToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgNumToText.Location = new System.Drawing.Point(511, 15);
            this.btnAlgNumToText.Name = "btnAlgNumToText";
            this.btnAlgNumToText.Size = new System.Drawing.Size(104, 27);
            this.btnAlgNumToText.TabIndex = 2;
            this.btnAlgNumToText.Text = "Number to text";
            this.btnAlgNumToText.UseVisualStyleBackColor = true;
            this.btnAlgNumToText.Click += new System.EventHandler(this.btnAlgNumToText_Click);
            // 
            // nudAlgNum
            // 
            this.nudAlgNum.Location = new System.Drawing.Point(12, 19);
            this.nudAlgNum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.nudAlgNum.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudAlgNum.Name = "nudAlgNum";
            this.nudAlgNum.Size = new System.Drawing.Size(82, 20);
            this.nudAlgNum.TabIndex = 0;
            this.nudAlgNum.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // tbAlgNumText
            // 
            this.tbAlgNumText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgNumText.Location = new System.Drawing.Point(97, 19);
            this.tbAlgNumText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbAlgNumText.Name = "tbAlgNumText";
            this.tbAlgNumText.ReadOnly = true;
            this.tbAlgNumText.Size = new System.Drawing.Size(409, 20);
            this.tbAlgNumText.TabIndex = 1;
            // 
            // gbWrapText
            // 
            gbWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbWrapText.Controls.Add(this.nudAlgWrap);
            gbWrapText.Controls.Add(this.tbAlgWrap);
            gbWrapText.Controls.Add(this.tbAlgWrapText);
            gbWrapText.Controls.Add(this.btnAlgWrapText);
            gbWrapText.Controls.Add(lblAlgWrap);
            gbWrapText.Location = new System.Drawing.Point(0, 109);
            gbWrapText.Name = "gbWrapText";
            gbWrapText.Size = new System.Drawing.Size(626, 125);
            gbWrapText.TabIndex = 2;
            gbWrapText.TabStop = false;
            // 
            // nudAlgWrap
            // 
            this.nudAlgWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAlgWrap.Location = new System.Drawing.Point(511, 31);
            this.nudAlgWrap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAlgWrap.Name = "nudAlgWrap";
            this.nudAlgWrap.Size = new System.Drawing.Size(104, 20);
            this.nudAlgWrap.TabIndex = 3;
            this.nudAlgWrap.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tbAlgWrap
            // 
            this.tbAlgWrap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgWrap.Location = new System.Drawing.Point(12, 20);
            this.tbAlgWrap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbAlgWrap.Multiline = true;
            this.tbAlgWrap.Name = "tbAlgWrap";
            this.tbAlgWrap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAlgWrap.Size = new System.Drawing.Size(493, 46);
            this.tbAlgWrap.TabIndex = 0;
            this.tbAlgWrap.Text = "Text needed to be wrapped to specified line \r\nlength. 123456890123456879012345678" +
    "901234568790\r\nxxx\r\n";
            // 
            // tbAlgWrapText
            // 
            this.tbAlgWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgWrapText.Location = new System.Drawing.Point(12, 65);
            this.tbAlgWrapText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbAlgWrapText.Multiline = true;
            this.tbAlgWrapText.Name = "tbAlgWrapText";
            this.tbAlgWrapText.ReadOnly = true;
            this.tbAlgWrapText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAlgWrapText.Size = new System.Drawing.Size(493, 46);
            this.tbAlgWrapText.TabIndex = 1;
            // 
            // btnAlgWrapText
            // 
            this.btnAlgWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgWrapText.Location = new System.Drawing.Point(511, 53);
            this.btnAlgWrapText.Name = "btnAlgWrapText";
            this.btnAlgWrapText.Size = new System.Drawing.Size(104, 33);
            this.btnAlgWrapText.TabIndex = 4;
            this.btnAlgWrapText.Text = "Wrap text";
            this.btnAlgWrapText.UseVisualStyleBackColor = true;
            this.btnAlgWrapText.Click += new System.EventHandler(this.btnAlgWrapText_Click);
            // 
            // gbAlgCID
            // 
            this.gbAlgCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAlgCID.Controls.Add(this.btnAlgCIDValidity);
            this.gbAlgCID.Controls.Add(lblAlgCID);
            this.gbAlgCID.Controls.Add(this.tbAlgCID);
            this.gbAlgCID.Controls.Add(this.tbAlgAdZip);
            this.gbAlgCID.Controls.Add(this.btnAlgAres);
            this.gbAlgCID.Controls.Add(lblAlgAdZip);
            this.gbAlgCID.Controls.Add(lblAlgAdVAT);
            this.gbAlgCID.Controls.Add(this.tbAlgAdCity);
            this.gbAlgCID.Controls.Add(this.tbAlgAdVAT);
            this.gbAlgCID.Controls.Add(lblAlgAdCity);
            this.gbAlgCID.Controls.Add(lblAlgAdName);
            this.gbAlgCID.Controls.Add(this.tbAlgAdStreet);
            this.gbAlgCID.Controls.Add(this.tbAlgAdName);
            this.gbAlgCID.Controls.Add(lblAlgAdStreet);
            this.gbAlgCID.Location = new System.Drawing.Point(0, 227);
            this.gbAlgCID.Name = "gbAlgCID";
            this.gbAlgCID.Size = new System.Drawing.Size(626, 96);
            this.gbAlgCID.TabIndex = 3;
            this.gbAlgCID.TabStop = false;
            // 
            // btnAlgCIDValidity
            // 
            this.btnAlgCIDValidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgCIDValidity.Location = new System.Drawing.Point(513, 17);
            this.btnAlgCIDValidity.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnAlgCIDValidity.Name = "btnAlgCIDValidity";
            this.btnAlgCIDValidity.Size = new System.Drawing.Size(102, 32);
            this.btnAlgCIDValidity.TabIndex = 12;
            this.btnAlgCIDValidity.Text = "Check CID";
            this.btnAlgCIDValidity.UseVisualStyleBackColor = true;
            this.btnAlgCIDValidity.Click += new System.EventHandler(this.btnAlgCIDValidity_Click);
            // 
            // tbAlgCID
            // 
            this.tbAlgCID.Location = new System.Drawing.Point(84, 17);
            this.tbAlgCID.Name = "tbAlgCID";
            this.tbAlgCID.Size = new System.Drawing.Size(68, 20);
            this.tbAlgCID.TabIndex = 1;
            this.tbAlgCID.Text = "69368457";
            // 
            // tbAlgAdZip
            // 
            this.tbAlgAdZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdZip.Location = new System.Drawing.Point(453, 61);
            this.tbAlgAdZip.Name = "tbAlgAdZip";
            this.tbAlgAdZip.ReadOnly = true;
            this.tbAlgAdZip.Size = new System.Drawing.Size(54, 20);
            this.tbAlgAdZip.TabIndex = 11;
            // 
            // btnAlgAres
            // 
            this.btnAlgAres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgAres.Location = new System.Drawing.Point(513, 49);
            this.btnAlgAres.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnAlgAres.Name = "btnAlgAres";
            this.btnAlgAres.Size = new System.Drawing.Size(102, 32);
            this.btnAlgAres.TabIndex = 13;
            this.btnAlgAres.Text = "Load from ARES";
            this.btnAlgAres.UseVisualStyleBackColor = true;
            this.btnAlgAres.Click += new System.EventHandler(this.btnAlgAres_Click);
            // 
            // tbAlgAdCity
            // 
            this.tbAlgAdCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdCity.Location = new System.Drawing.Point(202, 60);
            this.tbAlgAdCity.Name = "tbAlgAdCity";
            this.tbAlgAdCity.ReadOnly = true;
            this.tbAlgAdCity.Size = new System.Drawing.Size(212, 20);
            this.tbAlgAdCity.TabIndex = 9;
            // 
            // tbAlgAdVAT
            // 
            this.tbAlgAdVAT.Location = new System.Drawing.Point(69, 60);
            this.tbAlgAdVAT.Name = "tbAlgAdVAT";
            this.tbAlgAdVAT.ReadOnly = true;
            this.tbAlgAdVAT.Size = new System.Drawing.Size(83, 20);
            this.tbAlgAdVAT.TabIndex = 3;
            // 
            // tbAlgAdStreet
            // 
            this.tbAlgAdStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdStreet.Location = new System.Drawing.Point(202, 39);
            this.tbAlgAdStreet.Name = "tbAlgAdStreet";
            this.tbAlgAdStreet.ReadOnly = true;
            this.tbAlgAdStreet.Size = new System.Drawing.Size(305, 20);
            this.tbAlgAdStreet.TabIndex = 7;
            // 
            // tbAlgAdName
            // 
            this.tbAlgAdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdName.Location = new System.Drawing.Point(202, 18);
            this.tbAlgAdName.Name = "tbAlgAdName";
            this.tbAlgAdName.ReadOnly = true;
            this.tbAlgAdName.Size = new System.Drawing.Size(305, 20);
            this.tbAlgAdName.TabIndex = 5;
            // 
            // tabLang
            // 
            this.tabLang.Controls.Add(gbLangDelg);
            this.tabLang.Controls.Add(gbLangRefl);
            this.tabLang.Controls.Add(btnLangException);
            this.tabLang.Controls.Add(btnLangMemberAccess);
            this.tabLang.Location = new System.Drawing.Point(4, 22);
            this.tabLang.Name = "tabLang";
            this.tabLang.Size = new System.Drawing.Size(626, 408);
            this.tabLang.TabIndex = 4;
            this.tabLang.Text = "C# features";
            this.tabLang.UseVisualStyleBackColor = true;
            // 
            // tabFileIO
            // 
            this.tabFileIO.Controls.Add(gbIOfileWatch);
            this.tabFileIO.Controls.Add(this.gbIOzip);
            this.tabFileIO.Controls.Add(lblIOclass);
            this.tabFileIO.Controls.Add(this.listIO);
            this.tabFileIO.Location = new System.Drawing.Point(4, 22);
            this.tabFileIO.Name = "tabFileIO";
            this.tabFileIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileIO.Size = new System.Drawing.Size(626, 408);
            this.tabFileIO.TabIndex = 7;
            this.tabFileIO.Text = "File IO";
            this.tabFileIO.UseVisualStyleBackColor = true;
            // 
            // gbIOzip
            // 
            this.gbIOzip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIOzip.Controls.Add(this.panelIOzip);
            this.gbIOzip.Location = new System.Drawing.Point(0, 155);
            this.gbIOzip.Name = "gbIOzip";
            this.gbIOzip.Size = new System.Drawing.Size(626, 64);
            this.gbIOzip.TabIndex = 3;
            this.gbIOzip.TabStop = false;
            this.gbIOzip.Text = "Zip test";
            // 
            // panelIOzip
            // 
            this.panelIOzip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIOzip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelIOzip.ColumnCount = 2;
            this.panelIOzip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelIOzip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelIOzip.Controls.Add(this.btnIOzip, 0, 0);
            this.panelIOzip.Controls.Add(this.btnIOunzip, 1, 0);
            this.panelIOzip.Location = new System.Drawing.Point(11, 17);
            this.panelIOzip.Name = "panelIOzip";
            this.panelIOzip.RowCount = 1;
            this.panelIOzip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelIOzip.Size = new System.Drawing.Size(607, 36);
            this.panelIOzip.TabIndex = 2;
            // 
            // btnIOzip
            // 
            this.btnIOzip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIOzip.Location = new System.Drawing.Point(3, 3);
            this.btnIOzip.Name = "btnIOzip";
            this.btnIOzip.Size = new System.Drawing.Size(297, 30);
            this.btnIOzip.TabIndex = 0;
            this.btnIOzip.Text = "Zip file...";
            this.btnIOzip.UseVisualStyleBackColor = true;
            this.btnIOzip.Click += new System.EventHandler(this.btnIOzip_Click);
            // 
            // btnIOunzip
            // 
            this.btnIOunzip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIOunzip.Location = new System.Drawing.Point(306, 3);
            this.btnIOunzip.Name = "btnIOunzip";
            this.btnIOunzip.Size = new System.Drawing.Size(298, 30);
            this.btnIOunzip.TabIndex = 1;
            this.btnIOunzip.Text = "Unzip file...";
            this.btnIOunzip.UseVisualStyleBackColor = true;
            this.btnIOunzip.Click += new System.EventHandler(this.btnIOunzip_Click);
            // 
            // listIO
            // 
            this.listIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listIO.FullRowSelect = true;
            this.listIO.GridLines = true;
            this.listIO.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listIO.HideSelection = false;
            this.listIO.Location = new System.Drawing.Point(0, 22);
            this.listIO.Name = "listIO";
            this.listIO.Size = new System.Drawing.Size(626, 127);
            this.listIO.TabIndex = 1;
            this.listIO.UseCompatibleStateImageBehavior = false;
            this.listIO.View = System.Windows.Forms.View.Details;
            // 
            // tabXMLread
            // 
            this.tabXMLread.Controls.Add(lblXmlItems);
            this.tabXMLread.Controls.Add(this.listXMLitems);
            this.tabXMLread.Controls.Add(this.tbXMLFile);
            this.tabXMLread.Controls.Add(btnXMLParse);
            this.tabXMLread.Controls.Add(btnXmlSerialize);
            this.tabXMLread.Controls.Add(lblXML);
            this.tabXMLread.Controls.Add(this.btnXMLSel);
            this.tabXMLread.Location = new System.Drawing.Point(4, 22);
            this.tabXMLread.Name = "tabXMLread";
            this.tabXMLread.Size = new System.Drawing.Size(626, 408);
            this.tabXMLread.TabIndex = 3;
            this.tabXMLread.Text = "XML reader";
            this.tabXMLread.UseVisualStyleBackColor = true;
            // 
            // listXMLitems
            // 
            this.listXMLitems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listXMLitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listXMLitems.FullRowSelect = true;
            this.listXMLitems.GridLines = true;
            this.listXMLitems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listXMLitems.HideSelection = false;
            this.listXMLitems.HoverSelection = true;
            this.listXMLitems.Location = new System.Drawing.Point(3, 70);
            this.listXMLitems.MultiSelect = false;
            this.listXMLitems.Name = "listXMLitems";
            this.listXMLitems.Size = new System.Drawing.Size(623, 293);
            this.listXMLitems.TabIndex = 4;
            this.listXMLitems.UseCompatibleStateImageBehavior = false;
            this.listXMLitems.View = System.Windows.Forms.View.Details;
            // 
            // tbXMLFile
            // 
            this.tbXMLFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXMLFile.BackColor = System.Drawing.SystemColors.Window;
            this.tbXMLFile.Location = new System.Drawing.Point(74, 23);
            this.tbXMLFile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbXMLFile.Name = "tbXMLFile";
            this.tbXMLFile.ReadOnly = true;
            this.tbXMLFile.Size = new System.Drawing.Size(506, 20);
            this.tbXMLFile.TabIndex = 1;
            this.tbXMLFile.Text = "C:\\TestData.xml";
            // 
            // btnXMLSel
            // 
            this.btnXMLSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXMLSel.Location = new System.Drawing.Point(580, 22);
            this.btnXMLSel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnXMLSel.Name = "btnXMLSel";
            this.btnXMLSel.Size = new System.Drawing.Size(28, 22);
            this.btnXMLSel.TabIndex = 2;
            this.btnXMLSel.Text = "...";
            this.btnXMLSel.UseVisualStyleBackColor = true;
            this.btnXMLSel.Click += new System.EventHandler(this.btnXMLSel_Click);
            // 
            // tabLINQ
            // 
            this.tabLINQ.Controls.Add(pnlLINQ);
            this.tabLINQ.Controls.Add(gbLINQtoXML);
            this.tabLINQ.Location = new System.Drawing.Point(4, 22);
            this.tabLINQ.Name = "tabLINQ";
            this.tabLINQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabLINQ.Size = new System.Drawing.Size(626, 408);
            this.tabLINQ.TabIndex = 10;
            this.tabLINQ.Text = "LINQ";
            this.tabLINQ.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.tbServiceStatus);
            this.tabService.Controls.Add(label2);
            this.tabService.Controls.Add(this.btnServiceStop);
            this.tabService.Controls.Add(this.btnServiceStart);
            this.tabService.Controls.Add(gbServiceAccnt);
            this.tabService.Controls.Add(this.tbServiceName);
            this.tabService.Controls.Add(lblServiceName);
            this.tabService.Controls.Add(this.tbServiceFile);
            this.tabService.Controls.Add(this.btnServiceSel);
            this.tabService.Controls.Add(lblServiceFile);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(626, 408);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Windows service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // tbServiceStatus
            // 
            this.tbServiceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbServiceStatus.Location = new System.Drawing.Point(83, 221);
            this.tbServiceStatus.Multiline = true;
            this.tbServiceStatus.Name = "tbServiceStatus";
            this.tbServiceStatus.ReadOnly = true;
            this.tbServiceStatus.Size = new System.Drawing.Size(326, 86);
            this.tbServiceStatus.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 222);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 13);
            label2.TabIndex = 6;
            label2.Text = "Service status:";
            // 
            // btnServiceStop
            // 
            this.btnServiceStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceStop.Location = new System.Drawing.Point(415, 267);
            this.btnServiceStop.Name = "btnServiceStop";
            this.btnServiceStop.Size = new System.Drawing.Size(177, 40);
            this.btnServiceStop.TabIndex = 0;
            this.btnServiceStop.Text = "Stop";
            this.btnServiceStop.UseVisualStyleBackColor = true;
            this.btnServiceStop.Click += new System.EventHandler(this.btnServiceAction_Click);
            // 
            // btnServiceStart
            // 
            this.btnServiceStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceStart.Location = new System.Drawing.Point(415, 221);
            this.btnServiceStart.Name = "btnServiceStart";
            this.btnServiceStart.Size = new System.Drawing.Size(177, 40);
            this.btnServiceStart.TabIndex = 8;
            this.btnServiceStart.Text = "Start";
            this.btnServiceStart.UseVisualStyleBackColor = true;
            this.btnServiceStart.Click += new System.EventHandler(this.btnServiceAction_Click);
            // 
            // gbServiceAccnt
            // 
            gbServiceAccnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbServiceAccnt.Controls.Add(lblServiceUser);
            gbServiceAccnt.Controls.Add(this.tbServiceUser);
            gbServiceAccnt.Controls.Add(this.cbServiceAccount);
            gbServiceAccnt.Controls.Add(lblServiceAccount);
            gbServiceAccnt.Controls.Add(lblSerticePwd);
            gbServiceAccnt.Controls.Add(this.tbServicePwd);
            gbServiceAccnt.Controls.Add(this.btnServiceUninstall);
            gbServiceAccnt.Controls.Add(this.btnServiceInstall);
            gbServiceAccnt.Location = new System.Drawing.Point(8, 85);
            gbServiceAccnt.Name = "gbServiceAccnt";
            gbServiceAccnt.Size = new System.Drawing.Size(600, 113);
            gbServiceAccnt.TabIndex = 5;
            gbServiceAccnt.TabStop = false;
            gbServiceAccnt.Text = "Login account";
            // 
            // lblServiceUser
            // 
            lblServiceUser.AutoSize = true;
            lblServiceUser.Location = new System.Drawing.Point(37, 57);
            lblServiceUser.Name = "lblServiceUser";
            lblServiceUser.Size = new System.Drawing.Size(32, 13);
            lblServiceUser.TabIndex = 2;
            lblServiceUser.Text = "User:";
            // 
            // tbServiceUser
            // 
            this.tbServiceUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceUser.Location = new System.Drawing.Point(72, 54);
            this.tbServiceUser.Name = "tbServiceUser";
            this.tbServiceUser.Size = new System.Drawing.Size(329, 20);
            this.tbServiceUser.TabIndex = 3;
            // 
            // cbServiceAccount
            // 
            this.cbServiceAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServiceAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceAccount.FormattingEnabled = true;
            this.cbServiceAccount.Location = new System.Drawing.Point(72, 16);
            this.cbServiceAccount.Name = "cbServiceAccount";
            this.cbServiceAccount.Size = new System.Drawing.Size(329, 21);
            this.cbServiceAccount.TabIndex = 1;
            // 
            // lblServiceAccount
            // 
            lblServiceAccount.AutoSize = true;
            lblServiceAccount.Location = new System.Drawing.Point(19, 19);
            lblServiceAccount.Name = "lblServiceAccount";
            lblServiceAccount.Size = new System.Drawing.Size(50, 13);
            lblServiceAccount.TabIndex = 0;
            lblServiceAccount.Text = "Account:";
            // 
            // lblSerticePwd
            // 
            lblSerticePwd.AutoSize = true;
            lblSerticePwd.Location = new System.Drawing.Point(14, 83);
            lblSerticePwd.Name = "lblSerticePwd";
            lblSerticePwd.Size = new System.Drawing.Size(56, 13);
            lblSerticePwd.TabIndex = 4;
            lblSerticePwd.Text = "Password:";
            // 
            // tbServicePwd
            // 
            this.tbServicePwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServicePwd.Location = new System.Drawing.Point(72, 80);
            this.tbServicePwd.Name = "tbServicePwd";
            this.tbServicePwd.PasswordChar = '*';
            this.tbServicePwd.Size = new System.Drawing.Size(329, 20);
            this.tbServicePwd.TabIndex = 5;
            // 
            // btnServiceUninstall
            // 
            this.btnServiceUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceUninstall.Location = new System.Drawing.Point(415, 62);
            this.btnServiceUninstall.Name = "btnServiceUninstall";
            this.btnServiceUninstall.Size = new System.Drawing.Size(177, 40);
            this.btnServiceUninstall.TabIndex = 7;
            this.btnServiceUninstall.Text = "Uninstall";
            this.btnServiceUninstall.UseVisualStyleBackColor = true;
            this.btnServiceUninstall.Click += new System.EventHandler(this.btnServiceAction_Click);
            // 
            // btnServiceInstall
            // 
            this.btnServiceInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceInstall.Location = new System.Drawing.Point(415, 16);
            this.btnServiceInstall.Name = "btnServiceInstall";
            this.btnServiceInstall.Size = new System.Drawing.Size(177, 40);
            this.btnServiceInstall.TabIndex = 6;
            this.btnServiceInstall.Text = "Install";
            this.btnServiceInstall.UseVisualStyleBackColor = true;
            this.btnServiceInstall.Click += new System.EventHandler(this.btnServiceAction_Click);
            // 
            // tbServiceName
            // 
            this.tbServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceName.Location = new System.Drawing.Point(80, 50);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(528, 20);
            this.tbServiceName.TabIndex = 4;
            this.tbServiceName.Text = "TestService";
            this.tbServiceName.TextChanged += new System.EventHandler(this.tbServiceName_TextChanged);
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new System.Drawing.Point(3, 53);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new System.Drawing.Size(75, 13);
            lblServiceName.TabIndex = 3;
            lblServiceName.Text = "Service name:";
            // 
            // tbServiceFile
            // 
            this.tbServiceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceFile.BackColor = System.Drawing.SystemColors.Window;
            this.tbServiceFile.Location = new System.Drawing.Point(80, 23);
            this.tbServiceFile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbServiceFile.Name = "tbServiceFile";
            this.tbServiceFile.ReadOnly = true;
            this.tbServiceFile.Size = new System.Drawing.Size(500, 20);
            this.tbServiceFile.TabIndex = 1;
            this.tbServiceFile.Text = ".\\WinServiceTest.exe";
            // 
            // btnServiceSel
            // 
            this.btnServiceSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceSel.Location = new System.Drawing.Point(580, 22);
            this.btnServiceSel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnServiceSel.Name = "btnServiceSel";
            this.btnServiceSel.Size = new System.Drawing.Size(28, 22);
            this.btnServiceSel.TabIndex = 2;
            this.btnServiceSel.Text = "...";
            this.btnServiceSel.UseVisualStyleBackColor = true;
            this.btnServiceSel.Click += new System.EventHandler(this.btnServiceSel_Click);
            // 
            // lblServiceFile
            // 
            lblServiceFile.AutoSize = true;
            lblServiceFile.Location = new System.Drawing.Point(15, 26);
            lblServiceFile.Name = "lblServiceFile";
            lblServiceFile.Size = new System.Drawing.Size(62, 13);
            lblServiceFile.TabIndex = 0;
            lblServiceFile.Text = "Service file:";
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(gbMailSMTP);
            this.tabMail.Controls.Add(this.tbMailBody);
            this.tabMail.Controls.Add(this.tbMailSubject);
            this.tabMail.Controls.Add(this.tbMailCopy);
            this.tabMail.Controls.Add(this.tbMailRcp);
            this.tabMail.Controls.Add(lblMailSubject);
            this.tabMail.Controls.Add(lblMailCopy);
            this.tabMail.Controls.Add(lblMailRcp);
            this.tabMail.Controls.Add(btnMailMAPIsend);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(626, 408);
            this.tabMail.TabIndex = 0;
            this.tabMail.Text = "MAPI & SMTP";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // gbMailSMTP
            // 
            gbMailSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbMailSMTP.Controls.Add(this.nudMailSMPTport);
            gbMailSMTP.Controls.Add(lblMailSMPTport);
            gbMailSMTP.Controls.Add(this.tbMailFrom);
            gbMailSMTP.Controls.Add(lblMailFrom);
            gbMailSMTP.Controls.Add(this.tbMailSMTPpwd);
            gbMailSMTP.Controls.Add(lblMailSMTPpwd);
            gbMailSMTP.Controls.Add(this.tbMailSMTPuser);
            gbMailSMTP.Controls.Add(lblMailSMTPuser);
            gbMailSMTP.Controls.Add(this.tbMailSMTPserver);
            gbMailSMTP.Controls.Add(btnMailSMTPsend);
            gbMailSMTP.Controls.Add(lblMailSMTPserver);
            gbMailSMTP.Location = new System.Drawing.Point(0, 277);
            gbMailSMTP.Name = "gbMailSMTP";
            gbMailSMTP.Size = new System.Drawing.Size(626, 131);
            gbMailSMTP.TabIndex = 8;
            gbMailSMTP.TabStop = false;
            gbMailSMTP.Text = "SMTP usage";
            // 
            // nudMailSMPTport
            // 
            this.nudMailSMPTport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMailSMPTport.Location = new System.Drawing.Point(512, 38);
            this.nudMailSMPTport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudMailSMPTport.Name = "nudMailSMPTport";
            this.nudMailSMPTport.Size = new System.Drawing.Size(106, 20);
            this.nudMailSMPTport.TabIndex = 5;
            this.nudMailSMPTport.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblMailSMPTport
            // 
            lblMailSMPTport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblMailSMPTport.AutoSize = true;
            lblMailSMPTport.Location = new System.Drawing.Point(477, 42);
            lblMailSMPTport.Name = "lblMailSMPTport";
            lblMailSMPTport.Size = new System.Drawing.Size(29, 13);
            lblMailSMPTport.TabIndex = 4;
            lblMailSMPTport.Text = "Port:";
            // 
            // tbMailFrom
            // 
            this.tbMailFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailFrom.Location = new System.Drawing.Point(79, 15);
            this.tbMailFrom.Name = "tbMailFrom";
            this.tbMailFrom.Size = new System.Drawing.Size(539, 20);
            this.tbMailFrom.TabIndex = 1;
            this.tbMailFrom.Text = "hermann@jetsoft.cz";
            // 
            // lblMailFrom
            // 
            lblMailFrom.AutoSize = true;
            lblMailFrom.Location = new System.Drawing.Point(43, 18);
            lblMailFrom.Name = "lblMailFrom";
            lblMailFrom.Size = new System.Drawing.Size(33, 13);
            lblMailFrom.TabIndex = 0;
            lblMailFrom.Text = "From:";
            // 
            // tbMailSMTPpwd
            // 
            this.tbMailSMTPpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPpwd.Location = new System.Drawing.Point(411, 61);
            this.tbMailSMTPpwd.Name = "tbMailSMTPpwd";
            this.tbMailSMTPpwd.PasswordChar = '*';
            this.tbMailSMTPpwd.Size = new System.Drawing.Size(207, 20);
            this.tbMailSMTPpwd.TabIndex = 9;
            this.tbMailSMTPpwd.UseSystemPasswordChar = true;
            // 
            // lblMailSMTPpwd
            // 
            lblMailSMTPpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblMailSMTPpwd.AutoSize = true;
            lblMailSMTPpwd.Location = new System.Drawing.Point(349, 64);
            lblMailSMTPpwd.Name = "lblMailSMTPpwd";
            lblMailSMTPpwd.Size = new System.Drawing.Size(56, 13);
            lblMailSMTPpwd.TabIndex = 8;
            lblMailSMTPpwd.Text = "Password:";
            // 
            // tbMailSMTPuser
            // 
            this.tbMailSMTPuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPuser.Location = new System.Drawing.Point(121, 61);
            this.tbMailSMTPuser.Name = "tbMailSMTPuser";
            this.tbMailSMTPuser.Size = new System.Drawing.Size(222, 20);
            this.tbMailSMTPuser.TabIndex = 7;
            // 
            // lblMailSMTPuser
            // 
            lblMailSMTPuser.AutoSize = true;
            lblMailSMTPuser.Location = new System.Drawing.Point(41, 64);
            lblMailSMTPuser.Name = "lblMailSMTPuser";
            lblMailSMTPuser.Size = new System.Drawing.Size(32, 13);
            lblMailSMTPuser.TabIndex = 6;
            lblMailSMTPuser.Text = "User:";
            // 
            // tbMailSMTPserver
            // 
            this.tbMailSMTPserver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPserver.Location = new System.Drawing.Point(79, 38);
            this.tbMailSMTPserver.Name = "tbMailSMTPserver";
            this.tbMailSMTPserver.Size = new System.Drawing.Size(392, 20);
            this.tbMailSMTPserver.TabIndex = 3;
            this.tbMailSMTPserver.Text = "localhost";
            // 
            // btnMailSMTPsend
            // 
            btnMailSMTPsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnMailSMTPsend.Location = new System.Drawing.Point(8, 91);
            btnMailSMTPsend.Name = "btnMailSMTPsend";
            btnMailSMTPsend.Size = new System.Drawing.Size(610, 32);
            btnMailSMTPsend.TabIndex = 10;
            btnMailSMTPsend.Text = "Send mail by SMTP";
            btnMailSMTPsend.UseVisualStyleBackColor = true;
            btnMailSMTPsend.Click += new System.EventHandler(this.btnMailSMTPsend_Click);
            // 
            // lblMailSMTPserver
            // 
            lblMailSMTPserver.AutoSize = true;
            lblMailSMTPserver.Location = new System.Drawing.Point(4, 42);
            lblMailSMTPserver.Name = "lblMailSMTPserver";
            lblMailSMTPserver.Size = new System.Drawing.Size(72, 13);
            lblMailSMTPserver.TabIndex = 2;
            lblMailSMTPserver.Text = "SMTP server:";
            // 
            // tbMailBody
            // 
            this.tbMailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailBody.Location = new System.Drawing.Point(8, 95);
            this.tbMailBody.Multiline = true;
            this.tbMailBody.Name = "tbMailBody";
            this.tbMailBody.Size = new System.Drawing.Size(610, 135);
            this.tbMailBody.TabIndex = 6;
            this.tbMailBody.Text = "Mail from test application.\r\n\r\nP.H.";
            // 
            // tbMailSubject
            // 
            this.tbMailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSubject.Location = new System.Drawing.Point(73, 69);
            this.tbMailSubject.Name = "tbMailSubject";
            this.tbMailSubject.Size = new System.Drawing.Size(545, 20);
            this.tbMailSubject.TabIndex = 5;
            this.tbMailSubject.Text = "Test mail";
            // 
            // tbMailCopy
            // 
            this.tbMailCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailCopy.Location = new System.Drawing.Point(73, 43);
            this.tbMailCopy.Name = "tbMailCopy";
            this.tbMailCopy.Size = new System.Drawing.Size(545, 20);
            this.tbMailCopy.TabIndex = 3;
            // 
            // tbMailRcp
            // 
            this.tbMailRcp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailRcp.Location = new System.Drawing.Point(73, 17);
            this.tbMailRcp.Name = "tbMailRcp";
            this.tbMailRcp.Size = new System.Drawing.Size(545, 20);
            this.tbMailRcp.TabIndex = 1;
            this.tbMailRcp.Text = "hermann@jetsoft.cz";
            // 
            // lblMailSubject
            // 
            lblMailSubject.AutoSize = true;
            lblMailSubject.Location = new System.Drawing.Point(21, 72);
            lblMailSubject.Name = "lblMailSubject";
            lblMailSubject.Size = new System.Drawing.Size(46, 13);
            lblMailSubject.TabIndex = 4;
            lblMailSubject.Text = "Subject:";
            // 
            // lblMailCopy
            // 
            lblMailCopy.AutoSize = true;
            lblMailCopy.Location = new System.Drawing.Point(21, 46);
            lblMailCopy.Name = "lblMailCopy";
            lblMailCopy.Size = new System.Drawing.Size(46, 13);
            lblMailCopy.TabIndex = 2;
            lblMailCopy.Text = "Copy to:";
            // 
            // lblMailRcp
            // 
            lblMailRcp.AutoSize = true;
            lblMailRcp.Location = new System.Drawing.Point(8, 20);
            lblMailRcp.Name = "lblMailRcp";
            lblMailRcp.Size = new System.Drawing.Size(59, 13);
            lblMailRcp.TabIndex = 0;
            lblMailRcp.Text = "Recepient:";
            // 
            // tabWeb
            // 
            this.tabWeb.Controls.Add(lblWWWcontent);
            this.tabWeb.Controls.Add(btnWWWDownload);
            this.tabWeb.Controls.Add(lblWWWURL);
            this.tabWeb.Controls.Add(this.tbWWWURL);
            this.tabWeb.Controls.Add(this.tbWWWContent);
            this.tabWeb.Location = new System.Drawing.Point(4, 22);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Size = new System.Drawing.Size(626, 408);
            this.tabWeb.TabIndex = 8;
            this.tabWeb.Text = "Web";
            this.tabWeb.UseVisualStyleBackColor = true;
            // 
            // lblWWWcontent
            // 
            lblWWWcontent.AutoSize = true;
            lblWWWcontent.Location = new System.Drawing.Point(8, 48);
            lblWWWcontent.Name = "lblWWWcontent";
            lblWWWcontent.Size = new System.Drawing.Size(71, 13);
            lblWWWcontent.TabIndex = 3;
            lblWWWcontent.Text = "URL content:";
            // 
            // lblWWWURL
            // 
            lblWWWURL.AutoSize = true;
            lblWWWURL.Location = new System.Drawing.Point(8, 23);
            lblWWWURL.Name = "lblWWWURL";
            lblWWWURL.Size = new System.Drawing.Size(32, 13);
            lblWWWURL.TabIndex = 0;
            lblWWWURL.Text = "URL:";
            // 
            // tbWWWURL
            // 
            this.tbWWWURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWWWURL.Location = new System.Drawing.Point(46, 20);
            this.tbWWWURL.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbWWWURL.Name = "tbWWWURL";
            this.tbWWWURL.Size = new System.Drawing.Size(491, 20);
            this.tbWWWURL.TabIndex = 1;
            this.tbWWWURL.Text = "http://www.jetsoft.cz/index.php";
            // 
            // tbWWWContent
            // 
            this.tbWWWContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWWWContent.Location = new System.Drawing.Point(0, 64);
            this.tbWWWContent.Multiline = true;
            this.tbWWWContent.Name = "tbWWWContent";
            this.tbWWWContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWWWContent.Size = new System.Drawing.Size(623, 344);
            this.tbWWWContent.TabIndex = 4;
            // 
            // tabUI
            // 
            this.tabUI.Controls.Add(panelUI);
            this.tabUI.Location = new System.Drawing.Point(4, 22);
            this.tabUI.Name = "tabUI";
            this.tabUI.Size = new System.Drawing.Size(626, 408);
            this.tabUI.TabIndex = 6;
            this.tabUI.Text = "UI & controls";
            this.tabUI.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(gbOtherProcess);
            this.tabOther.Controls.Add(this.tbOtherAppProdVer);
            this.tabOther.Controls.Add(lblOtherAppProdVer);
            this.tabOther.Controls.Add(this.tbOtherAppProdName);
            this.tabOther.Controls.Add(lblOtherAppProdName);
            this.tabOther.Controls.Add(this.tbOtherAppPathExe);
            this.tabOther.Controls.Add(lblOtherAppPathExe);
            this.tabOther.Controls.Add(this.tbOtherAppPathStartup);
            this.tabOther.Controls.Add(lblOtherAppPathStartup);
            this.tabOther.Controls.Add(this.tbOtherDTtoday);
            this.tabOther.Controls.Add(this.tbOtherDTnow);
            this.tabOther.Controls.Add(lblOtherToday);
            this.tabOther.Controls.Add(lblOtherNow);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(626, 408);
            this.tabOther.TabIndex = 9;
            this.tabOther.Text = "Other tests";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // tbOtherAppProdVer
            // 
            this.tbOtherAppProdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherAppProdVer.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherAppProdVer.Location = new System.Drawing.Point(527, 55);
            this.tbOtherAppProdVer.Name = "tbOtherAppProdVer";
            this.tbOtherAppProdVer.ReadOnly = true;
            this.tbOtherAppProdVer.Size = new System.Drawing.Size(90, 20);
            this.tbOtherAppProdVer.TabIndex = 7;
            // 
            // tbOtherAppProdName
            // 
            this.tbOtherAppProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherAppProdName.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherAppProdName.Location = new System.Drawing.Point(145, 55);
            this.tbOtherAppProdName.Name = "tbOtherAppProdName";
            this.tbOtherAppProdName.ReadOnly = true;
            this.tbOtherAppProdName.Size = new System.Drawing.Size(240, 20);
            this.tbOtherAppProdName.TabIndex = 5;
            // 
            // tbOtherAppPathExe
            // 
            this.tbOtherAppPathExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherAppPathExe.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherAppPathExe.Location = new System.Drawing.Point(145, 11);
            this.tbOtherAppPathExe.Name = "tbOtherAppPathExe";
            this.tbOtherAppPathExe.ReadOnly = true;
            this.tbOtherAppPathExe.Size = new System.Drawing.Size(472, 20);
            this.tbOtherAppPathExe.TabIndex = 1;
            // 
            // tbOtherAppPathStartup
            // 
            this.tbOtherAppPathStartup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherAppPathStartup.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherAppPathStartup.Location = new System.Drawing.Point(145, 32);
            this.tbOtherAppPathStartup.Name = "tbOtherAppPathStartup";
            this.tbOtherAppPathStartup.ReadOnly = true;
            this.tbOtherAppPathStartup.Size = new System.Drawing.Size(472, 20);
            this.tbOtherAppPathStartup.TabIndex = 3;
            // 
            // tbOtherDTtoday
            // 
            this.tbOtherDTtoday.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherDTtoday.Location = new System.Drawing.Point(145, 101);
            this.tbOtherDTtoday.Name = "tbOtherDTtoday";
            this.tbOtherDTtoday.ReadOnly = true;
            this.tbOtherDTtoday.Size = new System.Drawing.Size(109, 20);
            this.tbOtherDTtoday.TabIndex = 11;
            // 
            // tbOtherDTnow
            // 
            this.tbOtherDTnow.BackColor = System.Drawing.SystemColors.Window;
            this.tbOtherDTnow.Location = new System.Drawing.Point(145, 81);
            this.tbOtherDTnow.Name = "tbOtherDTnow";
            this.tbOtherDTnow.ReadOnly = true;
            this.tbOtherDTnow.Size = new System.Drawing.Size(109, 20);
            this.tbOtherDTnow.TabIndex = 9;
            // 
            // chbOnTop
            // 
            this.chbOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbOnTop.AutoSize = true;
            this.chbOnTop.Location = new System.Drawing.Point(12, 445);
            this.chbOnTop.Name = "chbOnTop";
            this.chbOnTop.Size = new System.Drawing.Size(109, 17);
            this.chbOnTop.TabIndex = 1;
            this.chbOnTop.Text = "always on the top";
            this.chbOnTop.UseVisualStyleBackColor = true;
            this.chbOnTop.CheckedChanged += new System.EventHandler(this.chbOnTop_CheckedChanged);
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(438, 445);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(196, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbComputer
            // 
            this.tbComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbComputer.Enabled = false;
            this.tbComputer.Location = new System.Drawing.Point(233, 445);
            this.tbComputer.Name = "tbComputer";
            this.tbComputer.Size = new System.Drawing.Size(126, 20);
            this.tbComputer.TabIndex = 5;
            // 
            // tbOtherProcName
            // 
            this.tbOtherProcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherProcName.Location = new System.Drawing.Point(57, 24);
            this.tbOtherProcName.Name = "tbOtherProcName";
            this.tbOtherProcName.Size = new System.Drawing.Size(120, 20);
            this.tbOtherProcName.TabIndex = 1;
            this.tbOtherProcName.Text = "firefox";
            // 
            // tbUI
            // 
            this.tbUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUI.DropDownHeight = 250;
            this.tbUI.Location = new System.Drawing.Point(0, 0);
            this.tbUI.Name = "tbUI";
            this.tbUI.Size = new System.Drawing.Size(307, 21);
            this.tbUI.TabIndex = 8;
            this.tbUI.TextEditable = false;
            this.tbUI.TextValue = "XXX";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.tbComputer);
            this.Controls.Add(lblComputer);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(lblUser);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.chbOnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormMain";
            this.Text = "Test application";
            this.Load += new System.EventHandler(this.FormMain_Load);
            gbLINQtoXML.ResumeLayout(false);
            gbLINQtoXML.PerformLayout();
            gbLINQobj.ResumeLayout(false);
            gbLINQobj.PerformLayout();
            gbLINQds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLINQds)).EndInit();
            gbIOfileWatch.ResumeLayout(false);
            gbIOfileWatch.PerformLayout();
            panelUI.ResumeLayout(false);
            panelUI.PerformLayout();
            panelUITreeBox.ResumeLayout(false);
            panelUITreeBox.PerformLayout();
            pnlLINQ.ResumeLayout(false);
            gbLangDelg.ResumeLayout(false);
            panelLangDelg.ResumeLayout(false);
            gbLangRefl.ResumeLayout(false);
            gbLangRefl.PerformLayout();
            gbOtherProcess.ResumeLayout(false);
            gbOtherProcess.PerformLayout();
            panelOtherProc.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.tabAlg.ResumeLayout(false);
            this.gbAlgCutDiactric.ResumeLayout(false);
            this.gbAlgCutDiactric.PerformLayout();
            gbAlgNum.ResumeLayout(false);
            gbAlgNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgNum)).EndInit();
            gbWrapText.ResumeLayout(false);
            gbWrapText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgWrap)).EndInit();
            this.gbAlgCID.ResumeLayout(false);
            this.gbAlgCID.PerformLayout();
            this.tabLang.ResumeLayout(false);
            this.tabFileIO.ResumeLayout(false);
            this.tabFileIO.PerformLayout();
            this.gbIOzip.ResumeLayout(false);
            this.panelIOzip.ResumeLayout(false);
            this.tabXMLread.ResumeLayout(false);
            this.tabXMLread.PerformLayout();
            this.tabLINQ.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            gbServiceAccnt.ResumeLayout(false);
            gbServiceAccnt.PerformLayout();
            this.tabMail.ResumeLayout(false);
            this.tabMail.PerformLayout();
            gbMailSMTP.ResumeLayout(false);
            gbMailSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailSMPTport)).EndInit();
            this.tabWeb.ResumeLayout(false);
            this.tabWeb.PerformLayout();
            this.tabUI.ResumeLayout(false);
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox chbOnTop;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TabPage tabUI;
        private System.Windows.Forms.ListView listUI;
        private System.Windows.Forms.ColumnHeader hdrCol1;
        private System.Windows.Forms.ColumnHeader hdrCol2;
        private System.Windows.Forms.ColumnHeader hdrCol3;
        private System.Windows.Forms.TreeView treeUI;
        private System.Windows.Forms.TabPage tabLang;
        private System.Windows.Forms.TabPage tabLINQ;
        private System.Windows.Forms.DataGridView dgLINQds;
        private System.Windows.Forms.TextBox tbLINQobj;
        private System.Windows.Forms.ListBox listLINQobj;
        private System.Windows.Forms.RadioButton rbLINQxmlAccnt;
        private System.Windows.Forms.TextBox tbLINQxml;
        private System.Windows.Forms.Button btnLINQselXML;
        private System.Windows.Forms.ListView listLINQxml;
        private System.Windows.Forms.TabPage tabXMLread;
        private System.Windows.Forms.ListView listXMLitems;
        private System.Windows.Forms.TextBox tbXMLFile;
        private System.Windows.Forms.Button btnXMLSel;
        private System.Windows.Forms.TabPage tabFileIO;
        private System.Windows.Forms.Button btnIOfileSel;
        private System.Windows.Forms.TextBox tbIOfileContent;
        private System.Windows.Forms.DateTimePicker dtIOfileModified;
        private System.Windows.Forms.TextBox tbIOfile;
        private System.Windows.Forms.ListView listIO;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.TextBox tbWWWURL;
        private System.Windows.Forms.TextBox tbWWWContent;
        private System.Windows.Forms.TabPage tabMail;
        private System.Windows.Forms.TextBox tbMailBody;
        private System.Windows.Forms.TextBox tbMailSubject;
        private System.Windows.Forms.TextBox tbMailCopy;
        private System.Windows.Forms.TextBox tbMailRcp;
        private System.Windows.Forms.RadioButton rbLINQxmlDeliv;
        private System.Windows.Forms.TextBox tbComputer;
        private System.Windows.Forms.Button btnUImbox;
        private System.Windows.Forms.ListView listUImbox;
        private System.Windows.Forms.TextBox tbOtherDTtoday;
        private System.Windows.Forms.TextBox tbOtherDTnow;
        private System.Windows.Forms.TabPage tabAlg;
        private System.Windows.Forms.NumericUpDown nudAlgWrap;
        private System.Windows.Forms.Button btnAlgWrapText;
        private System.Windows.Forms.TextBox tbAlgWrapText;
        private System.Windows.Forms.TextBox tbAlgWrap;
        private System.Windows.Forms.Button btnAlgNumToText;
        private System.Windows.Forms.TextBox tbAlgNumText;
        private System.Windows.Forms.NumericUpDown nudAlgNum;
        private System.Windows.Forms.Button btnAlgCutDiactric;
        private System.Windows.Forms.TextBox tbAlgDiactricCut;
        private System.Windows.Forms.TextBox tbAlgDiactric;
        private System.Windows.Forms.TextBox tbAlgCID;
        private System.Windows.Forms.Button btnAlgCIDValidity;
        private System.Windows.Forms.Button btnAlgAres;
        private System.Windows.Forms.TextBox tbAlgAdCity;
        private System.Windows.Forms.TextBox tbAlgAdStreet;
        private System.Windows.Forms.TextBox tbAlgAdName;
        private System.Windows.Forms.TextBox tbAlgAdVAT;
        private System.Windows.Forms.TextBox tbAlgAdZip;
        private System.Windows.Forms.GroupBox gbAlgCID;
        private System.Windows.Forms.GroupBox gbAlgCutDiactric;
        private System.Windows.Forms.TextBox tbOtherAppPathStartup;
        private System.Windows.Forms.TextBox tbOtherAppPathExe;
        private System.Windows.Forms.TextBox tbOtherAppProdName;
        private System.Windows.Forms.TextBox tbOtherAppProdVer;
        private System.Windows.Forms.TextBox tbOtherProc;
        private System.Windows.Forms.Button btnLangDelgLambda;
        private System.Windows.Forms.Button btnLangDelgAnonymous;
        private System.Windows.Forms.Button btnOtherMinimizeProcWnd;
        private System.Windows.Forms.Button btnOtherMaximizeProcWnd;
        private System.Windows.Forms.Button btnOtherCloseProcWnd;
        private System.Windows.Forms.Button btnOtherRestoreProcWnd;
        private System.Windows.Forms.TextBox tbOtherProcName;
        private System.Windows.Forms.TextBox tbLangReflResult;
        private System.Windows.Forms.ComboBox cbLangReflType;
        private System.Windows.Forms.TextBox tbLangReflParam2;
        private System.Windows.Forms.ComboBox cbLangReflParam1;
        private System.Windows.Forms.GroupBox gbIOzip;
        private System.Windows.Forms.Button btnIOzip;
        private System.Windows.Forms.Button btnIOunzip;
        private System.Windows.Forms.TableLayoutPanel panelIOzip;
        private System.Windows.Forms.TextBox tbMailSMTPserver;
        private System.Windows.Forms.TextBox tbMailSMTPuser;
        private System.Windows.Forms.TextBox tbMailSMTPpwd;
        private System.Windows.Forms.TextBox tbMailFrom;
        private System.Windows.Forms.NumericUpDown nudMailSMPTport;
        private XXX.TreeBox tbUI;
        private System.Windows.Forms.CheckBox chbUITreeBoxEnabled;
        private System.Windows.Forms.CheckBox chbUITreeBoxEditable;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbServiceFile;
        private System.Windows.Forms.Button btnServiceSel;
        private System.Windows.Forms.TextBox tbServicePwd;
        private System.Windows.Forms.Button btnServiceUninstall;
        private System.Windows.Forms.Button btnServiceInstall;
        private System.Windows.Forms.Button btnServiceStop;
        private System.Windows.Forms.Button btnServiceStart;
        private System.Windows.Forms.TextBox tbServiceStatus;
        private System.Windows.Forms.ComboBox cbServiceAccount;
        private System.Windows.Forms.TextBox tbServiceUser;
        private System.ServiceProcess.ServiceController serviceController;
        private System.Windows.Forms.TabControl tabPanel;
    }    
}

