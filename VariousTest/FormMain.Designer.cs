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
            System.Windows.Forms.Label lblUser;
            System.Windows.Forms.Label lblComputer;
            System.Windows.Forms.Label lblOtherProcName;
            System.Windows.Forms.GroupBox gbOtherProcess;
            System.Windows.Forms.Label lblOtherProc;
            System.Windows.Forms.TableLayoutPanel panelOtherProc;
            System.Windows.Forms.Label lblWWWURL;
            System.Windows.Forms.Button btnWWWDownload;
            System.Windows.Forms.Label lblWWWcontent;
            System.Windows.Forms.Button btnMailMAPIsend;
            System.Windows.Forms.Label lblMailRcp;
            System.Windows.Forms.Label lblMailCopy;
            System.Windows.Forms.Label lblMailSubject;
            System.Windows.Forms.GroupBox gbMailSMTP;
            System.Windows.Forms.Label lblMailSMPTport;
            System.Windows.Forms.Label lblMailFrom;
            System.Windows.Forms.Label lblMailSMTPpwd;
            System.Windows.Forms.Label lblMailSMTPuser;
            System.Windows.Forms.Button btnMailSMTPsend;
            System.Windows.Forms.Label lblMailSMTPserver;
            System.Windows.Forms.TableLayoutPanel panelUI;
            System.Windows.Forms.Label lblUImbox;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Subpoložka 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Polozka 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Subpoložka 2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Subpoložka 3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Subpoložka 4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Položka 2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item1Col1",
            "Item1Col2",
            "Item1Col3"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item2Col1",
            "Item2Col2",
            "Item2Col3"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label lblUIlist;
            System.Windows.Forms.Label lblUItree;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panelUITreeBox;
            System.Windows.Forms.Button btnLangMemberAccess;
            System.Windows.Forms.Button btnLangException;
            System.Windows.Forms.GroupBox gbLangRefl;
            System.Windows.Forms.Label lblLangRefl4;
            System.Windows.Forms.Label lblLangRefl3;
            System.Windows.Forms.Label lbLangRefl;
            System.Windows.Forms.Label lblLangRefl2;
            System.Windows.Forms.GroupBox gbLangDelg;
            System.Windows.Forms.TableLayoutPanel panelLangDelg;
            System.Windows.Forms.Button btnLangDelgGUItest;
            System.Windows.Forms.Button btnLangDelgTest;
            System.Windows.Forms.Label lblXML;
            System.Windows.Forms.Button btnXmlSerialize;
            System.Windows.Forms.Button btnXMLParse;
            System.Windows.Forms.Label lblXmlItems;
            System.Windows.Forms.TableLayoutPanel pnlLINQ;
            System.Windows.Forms.GroupBox gbLINQobj;
            System.Windows.Forms.Button btnLINQselObj;
            System.Windows.Forms.Label lblLINQobj;
            System.Windows.Forms.GroupBox gbLINQtoXML;
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lblLinqAddr;
            System.Windows.Forms.Label lblIOclass;
            System.Windows.Forms.Label lblIOdirWatch;
            System.Windows.Forms.Label lblIOfileWatch;
            System.Windows.Forms.Label lblIOfileWatchContent;
            System.Windows.Forms.Label lblIOfileWatchLastWrite;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblServiceFile;
            System.Windows.Forms.Label lblServiceName;
            System.Windows.Forms.GroupBox gbServiceAccnt;
            System.Windows.Forms.Label lblServiceUser;
            System.Windows.Forms.Label lblServiceAccount;
            System.Windows.Forms.Label lblSerticePwd;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblAlgAdStreet;
            System.Windows.Forms.Label lblAlgAdName;
            System.Windows.Forms.Label lblAlgAdCity;
            System.Windows.Forms.Label lblAlgAdVAT;
            System.Windows.Forms.Label lblAlgAdZip;
            System.Windows.Forms.Label lblAlgCID;
            System.Windows.Forms.GroupBox gbWrapText;
            System.Windows.Forms.Label lblAlgWrap;
            System.Windows.Forms.GroupBox gbAlgNum;
            System.Windows.Forms.Label lblLangAppProdVer;
            System.Windows.Forms.Label lblLangAppProdName;
            System.Windows.Forms.Label lblLangAppPathExe;
            System.Windows.Forms.Label lblLangAppPathStartup;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbOtherProcName = new System.Windows.Forms.TextBox();
            this.btnOtherProcMinimize = new System.Windows.Forms.Button();
            this.btnOtherProcMaximize = new System.Windows.Forms.Button();
            this.btnOtherProcClose = new System.Windows.Forms.Button();
            this.btnOtherProcRestore = new System.Windows.Forms.Button();
            this.chbMailSMTPSecure = new System.Windows.Forms.CheckBox();
            this.nudMailSMPTport = new System.Windows.Forms.NumericUpDown();
            this.tbMailFrom = new System.Windows.Forms.TextBox();
            this.tbMailSMTPpwd = new System.Windows.Forms.TextBox();
            this.tbMailSMTPuser = new System.Windows.Forms.TextBox();
            this.tbMailSMTPserver = new System.Windows.Forms.TextBox();
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
            this.tbUI = new XXX.TreeBox();
            this.tbLangReflParam2 = new System.Windows.Forms.TextBox();
            this.cbLangReflParam1 = new System.Windows.Forms.ComboBox();
            this.tbLangReflResult = new System.Windows.Forms.TextBox();
            this.cbLangReflType = new System.Windows.Forms.ComboBox();
            this.btnLangDelgLambda = new System.Windows.Forms.Button();
            this.btnLangDelgAnonymous = new System.Windows.Forms.Button();
            this.tbLINQobj = new System.Windows.Forms.TextBox();
            this.listLINQobj = new System.Windows.Forms.ListBox();
            this.tbLINQxml = new System.Windows.Forms.TextBox();
            this.rbLINQxmlAccnt = new System.Windows.Forms.RadioButton();
            this.rbLINQxmlDeliv = new System.Windows.Forms.RadioButton();
            this.rbLINQxmlAll = new System.Windows.Forms.RadioButton();
            this.listLINQxml = new System.Windows.Forms.ListView();
            this.tbServiceUser = new System.Windows.Forms.TextBox();
            this.cbServiceAccount = new System.Windows.Forms.ComboBox();
            this.tbServicePwd = new System.Windows.Forms.TextBox();
            this.btnServiceUninstall = new System.Windows.Forms.Button();
            this.btnServiceInstall = new System.Windows.Forms.Button();
            this.nudAlgWrap = new System.Windows.Forms.NumericUpDown();
            this.tbAlgWrap = new System.Windows.Forms.TextBox();
            this.tbAlgWrapText = new System.Windows.Forms.TextBox();
            this.btnAlgWrapText = new System.Windows.Forms.Button();
            this.btnAlgNumToText = new System.Windows.Forms.Button();
            this.nudAlgNum = new System.Windows.Forms.NumericUpDown();
            this.tbAlgNumText = new System.Windows.Forms.TextBox();
            this.chbOnTop = new System.Windows.Forms.CheckBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbComputer = new System.Windows.Forms.TextBox();
            this.serviceController = new System.ServiceProcess.ServiceController();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.tbWWWURL = new System.Windows.Forms.TextBox();
            this.tbWWWContent = new System.Windows.Forms.TextBox();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.tbMailBody = new System.Windows.Forms.TextBox();
            this.tbMailSubject = new System.Windows.Forms.TextBox();
            this.tbMailCopy = new System.Windows.Forms.TextBox();
            this.tbMailRcp = new System.Windows.Forms.TextBox();
            this.tabUI = new System.Windows.Forms.TabPage();
            this.tabLang = new System.Windows.Forms.TabPage();
            this.tbLangSysVar = new System.Windows.Forms.GroupBox();
            this.tbLangAppProdVer = new System.Windows.Forms.TextBox();
            this.tbLangAppProdName = new System.Windows.Forms.TextBox();
            this.tbLangAppPathExe = new System.Windows.Forms.TextBox();
            this.tbLangAppPathStartup = new System.Windows.Forms.TextBox();
            this.tabXML = new System.Windows.Forms.TabPage();
            this.dgXmlItems = new System.Windows.Forms.DataGridView();
            this.colXmlItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXmlItemIPaddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXmlItemIPport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuXML = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiEditXml = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDelXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiXmlParse = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiXmlSerialize = new System.Windows.Forms.ToolStripMenuItem();
            this.tbXmlFile = new System.Windows.Forms.TextBox();
            this.btnXmlFileSel = new System.Windows.Forms.Button();
            this.tabLINQ = new System.Windows.Forms.TabPage();
            this.tabFileIO = new System.Windows.Forms.TabPage();
            this.splitIOWatch = new System.Windows.Forms.SplitContainer();
            this.btnIOfileWatchSel = new System.Windows.Forms.Button();
            this.tbIOfileWatchContent = new System.Windows.Forms.TextBox();
            this.tbIOfileWatch = new System.Windows.Forms.TextBox();
            this.dtIOfileWatchModified = new System.Windows.Forms.DateTimePicker();
            this.dgIOdirWatch = new System.Windows.Forms.DataGridView();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIOdirWatchSel = new System.Windows.Forms.Button();
            this.tbIOdirWatch = new System.Windows.Forms.TextBox();
            this.gbIOzip = new System.Windows.Forms.GroupBox();
            this.panelIOzip = new System.Windows.Forms.TableLayoutPanel();
            this.btnIOzip = new System.Windows.Forms.Button();
            this.btnIOunzip = new System.Windows.Forms.Button();
            this.listIO = new System.Windows.Forms.ListView();
            this.tabService = new System.Windows.Forms.TabPage();
            this.tbServiceStatus = new System.Windows.Forms.TextBox();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tbServiceFile = new System.Windows.Forms.TextBox();
            this.btnServiceStop = new System.Windows.Forms.Button();
            this.btnServiceStart = new System.Windows.Forms.Button();
            this.btnServiceSel = new System.Windows.Forms.Button();
            this.tabAlg = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAlgEmailRegex = new System.Windows.Forms.TextBox();
            this.cbAlgEmail = new System.Windows.Forms.ComboBox();
            this.btnAlgEmailRegexValidate = new System.Windows.Forms.Button();
            this.gbAlgCutDiactric = new System.Windows.Forms.GroupBox();
            this.tbAlgDiactric = new System.Windows.Forms.TextBox();
            this.tbAlgDiactricCut = new System.Windows.Forms.TextBox();
            this.btnAlgCutDiactric = new System.Windows.Forms.Button();
            this.gbAlgCID = new System.Windows.Forms.GroupBox();
            this.btnAlgCIDValidity = new System.Windows.Forms.Button();
            this.tbAlgCID = new System.Windows.Forms.TextBox();
            this.tbAlgAdZip = new System.Windows.Forms.TextBox();
            this.btnAlgAres = new System.Windows.Forms.Button();
            this.tbAlgAdCity = new System.Windows.Forms.TextBox();
            this.tbAlgAdVAT = new System.Windows.Forms.TextBox();
            this.tbAlgAdStreet = new System.Windows.Forms.TextBox();
            this.tbAlgAdName = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miApp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miHlp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHlpAbout = new System.Windows.Forms.ToolStripMenuItem();
            lblUser = new System.Windows.Forms.Label();
            lblComputer = new System.Windows.Forms.Label();
            lblOtherProcName = new System.Windows.Forms.Label();
            gbOtherProcess = new System.Windows.Forms.GroupBox();
            lblOtherProc = new System.Windows.Forms.Label();
            panelOtherProc = new System.Windows.Forms.TableLayoutPanel();
            lblWWWURL = new System.Windows.Forms.Label();
            btnWWWDownload = new System.Windows.Forms.Button();
            lblWWWcontent = new System.Windows.Forms.Label();
            btnMailMAPIsend = new System.Windows.Forms.Button();
            lblMailRcp = new System.Windows.Forms.Label();
            lblMailCopy = new System.Windows.Forms.Label();
            lblMailSubject = new System.Windows.Forms.Label();
            gbMailSMTP = new System.Windows.Forms.GroupBox();
            lblMailSMPTport = new System.Windows.Forms.Label();
            lblMailFrom = new System.Windows.Forms.Label();
            lblMailSMTPpwd = new System.Windows.Forms.Label();
            lblMailSMTPuser = new System.Windows.Forms.Label();
            btnMailSMTPsend = new System.Windows.Forms.Button();
            lblMailSMTPserver = new System.Windows.Forms.Label();
            panelUI = new System.Windows.Forms.TableLayoutPanel();
            lblUImbox = new System.Windows.Forms.Label();
            lblUIlist = new System.Windows.Forms.Label();
            lblUItree = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panelUITreeBox = new System.Windows.Forms.Panel();
            btnLangMemberAccess = new System.Windows.Forms.Button();
            btnLangException = new System.Windows.Forms.Button();
            gbLangRefl = new System.Windows.Forms.GroupBox();
            lblLangRefl4 = new System.Windows.Forms.Label();
            lblLangRefl3 = new System.Windows.Forms.Label();
            lbLangRefl = new System.Windows.Forms.Label();
            lblLangRefl2 = new System.Windows.Forms.Label();
            gbLangDelg = new System.Windows.Forms.GroupBox();
            panelLangDelg = new System.Windows.Forms.TableLayoutPanel();
            btnLangDelgGUItest = new System.Windows.Forms.Button();
            btnLangDelgTest = new System.Windows.Forms.Button();
            lblXML = new System.Windows.Forms.Label();
            btnXmlSerialize = new System.Windows.Forms.Button();
            btnXMLParse = new System.Windows.Forms.Button();
            lblXmlItems = new System.Windows.Forms.Label();
            pnlLINQ = new System.Windows.Forms.TableLayoutPanel();
            gbLINQobj = new System.Windows.Forms.GroupBox();
            btnLINQselObj = new System.Windows.Forms.Button();
            lblLINQobj = new System.Windows.Forms.Label();
            gbLINQtoXML = new System.Windows.Forms.GroupBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            label3 = new System.Windows.Forms.Label();
            lblLinqAddr = new System.Windows.Forms.Label();
            lblIOclass = new System.Windows.Forms.Label();
            lblIOdirWatch = new System.Windows.Forms.Label();
            lblIOfileWatch = new System.Windows.Forms.Label();
            lblIOfileWatchContent = new System.Windows.Forms.Label();
            lblIOfileWatchLastWrite = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblServiceFile = new System.Windows.Forms.Label();
            lblServiceName = new System.Windows.Forms.Label();
            gbServiceAccnt = new System.Windows.Forms.GroupBox();
            lblServiceUser = new System.Windows.Forms.Label();
            lblServiceAccount = new System.Windows.Forms.Label();
            lblSerticePwd = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblAlgAdStreet = new System.Windows.Forms.Label();
            lblAlgAdName = new System.Windows.Forms.Label();
            lblAlgAdCity = new System.Windows.Forms.Label();
            lblAlgAdVAT = new System.Windows.Forms.Label();
            lblAlgAdZip = new System.Windows.Forms.Label();
            lblAlgCID = new System.Windows.Forms.Label();
            gbWrapText = new System.Windows.Forms.GroupBox();
            lblAlgWrap = new System.Windows.Forms.Label();
            gbAlgNum = new System.Windows.Forms.GroupBox();
            lblLangAppProdVer = new System.Windows.Forms.Label();
            lblLangAppProdName = new System.Windows.Forms.Label();
            lblLangAppPathExe = new System.Windows.Forms.Label();
            lblLangAppPathStartup = new System.Windows.Forms.Label();
            gbOtherProcess.SuspendLayout();
            panelOtherProc.SuspendLayout();
            gbMailSMTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailSMPTport)).BeginInit();
            panelUI.SuspendLayout();
            panelUITreeBox.SuspendLayout();
            gbLangRefl.SuspendLayout();
            gbLangDelg.SuspendLayout();
            panelLangDelg.SuspendLayout();
            pnlLINQ.SuspendLayout();
            gbLINQobj.SuspendLayout();
            gbLINQtoXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbServiceAccnt.SuspendLayout();
            gbWrapText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgWrap)).BeginInit();
            gbAlgNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgNum)).BeginInit();
            this.tabOther.SuspendLayout();
            this.tabWeb.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.tabUI.SuspendLayout();
            this.tabLang.SuspendLayout();
            this.tbLangSysVar.SuspendLayout();
            this.tabXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgXmlItems)).BeginInit();
            this.contextMenuXML.SuspendLayout();
            this.tabLINQ.SuspendLayout();
            this.tabFileIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitIOWatch)).BeginInit();
            this.splitIOWatch.Panel1.SuspendLayout();
            this.splitIOWatch.Panel2.SuspendLayout();
            this.splitIOWatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIOdirWatch)).BeginInit();
            this.gbIOzip.SuspendLayout();
            this.panelIOzip.SuspendLayout();
            this.tabService.SuspendLayout();
            this.tabAlg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAlgCutDiactric.SuspendLayout();
            this.gbAlgCID.SuspendLayout();
            this.tabs.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(366, 482);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(67, 13);
            lblUser.TabIndex = 2;
            lblUser.Text = "Current user:";
            // 
            // lblComputer
            // 
            lblComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblComputer.AutoSize = true;
            lblComputer.Location = new System.Drawing.Point(143, 482);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new System.Drawing.Size(84, 13);
            lblComputer.TabIndex = 4;
            lblComputer.Text = "Computer name:";
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
            // gbOtherProcess
            // 
            gbOtherProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbOtherProcess.Controls.Add(this.tbOtherProcName);
            gbOtherProcess.Controls.Add(lblOtherProc);
            gbOtherProcess.Controls.Add(panelOtherProc);
            gbOtherProcess.ForeColor = System.Drawing.SystemColors.Highlight;
            gbOtherProcess.Location = new System.Drawing.Point(0, 3);
            gbOtherProcess.Name = "gbOtherProcess";
            gbOtherProcess.Size = new System.Drawing.Size(776, 67);
            gbOtherProcess.TabIndex = 12;
            gbOtherProcess.TabStop = false;
            gbOtherProcess.Text = "Process";
            // 
            // tbOtherProcName
            // 
            this.tbOtherProcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOtherProcName.Location = new System.Drawing.Point(57, 24);
            this.tbOtherProcName.Name = "tbOtherProcName";
            this.tbOtherProcName.Size = new System.Drawing.Size(332, 20);
            this.tbOtherProcName.TabIndex = 1;
            this.tbOtherProcName.Text = "chrome";
            // 
            // lblOtherProc
            // 
            lblOtherProc.AutoSize = true;
            lblOtherProc.ForeColor = System.Drawing.SystemColors.ControlText;
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
            panelOtherProc.Controls.Add(this.btnOtherProcMinimize, 0, 0);
            panelOtherProc.Controls.Add(this.btnOtherProcMaximize, 1, 0);
            panelOtherProc.Controls.Add(this.btnOtherProcClose, 3, 0);
            panelOtherProc.Controls.Add(this.btnOtherProcRestore, 2, 0);
            panelOtherProc.Location = new System.Drawing.Point(395, 17);
            panelOtherProc.Name = "panelOtherProc";
            panelOtherProc.RowCount = 1;
            panelOtherProc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelOtherProc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            panelOtherProc.Size = new System.Drawing.Size(373, 35);
            panelOtherProc.TabIndex = 2;
            // 
            // btnOtherProcMinimize
            // 
            this.btnOtherProcMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherProcMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherProcMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtherProcMinimize.Location = new System.Drawing.Point(1, 1);
            this.btnOtherProcMinimize.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherProcMinimize.Name = "btnOtherProcMinimize";
            this.btnOtherProcMinimize.Size = new System.Drawing.Size(91, 33);
            this.btnOtherProcMinimize.TabIndex = 0;
            this.btnOtherProcMinimize.Text = "Minimize";
            this.btnOtherProcMinimize.UseVisualStyleBackColor = true;
            this.btnOtherProcMinimize.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherProcMaximize
            // 
            this.btnOtherProcMaximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherProcMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherProcMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtherProcMaximize.Location = new System.Drawing.Point(94, 1);
            this.btnOtherProcMaximize.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherProcMaximize.Name = "btnOtherProcMaximize";
            this.btnOtherProcMaximize.Size = new System.Drawing.Size(91, 33);
            this.btnOtherProcMaximize.TabIndex = 1;
            this.btnOtherProcMaximize.Text = "Maximize";
            this.btnOtherProcMaximize.UseVisualStyleBackColor = true;
            this.btnOtherProcMaximize.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherProcClose
            // 
            this.btnOtherProcClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherProcClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherProcClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtherProcClose.Location = new System.Drawing.Point(280, 1);
            this.btnOtherProcClose.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherProcClose.Name = "btnOtherProcClose";
            this.btnOtherProcClose.Size = new System.Drawing.Size(92, 33);
            this.btnOtherProcClose.TabIndex = 3;
            this.btnOtherProcClose.Text = "Close";
            this.btnOtherProcClose.UseVisualStyleBackColor = true;
            this.btnOtherProcClose.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
            // 
            // btnOtherProcRestore
            // 
            this.btnOtherProcRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherProcRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherProcRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtherProcRestore.Location = new System.Drawing.Point(187, 1);
            this.btnOtherProcRestore.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtherProcRestore.Name = "btnOtherProcRestore";
            this.btnOtherProcRestore.Size = new System.Drawing.Size(91, 33);
            this.btnOtherProcRestore.TabIndex = 2;
            this.btnOtherProcRestore.Text = "Restore";
            this.btnOtherProcRestore.UseVisualStyleBackColor = true;
            this.btnOtherProcRestore.Click += new System.EventHandler(this.btnOtherProcWnd_Click);
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
            // btnWWWDownload
            // 
            btnWWWDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnWWWDownload.Location = new System.Drawing.Point(687, 19);
            btnWWWDownload.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            btnWWWDownload.Name = "btnWWWDownload";
            btnWWWDownload.Size = new System.Drawing.Size(81, 22);
            btnWWWDownload.TabIndex = 2;
            btnWWWDownload.Text = "Download";
            btnWWWDownload.UseVisualStyleBackColor = true;
            btnWWWDownload.Click += new System.EventHandler(this.btnWWWDownload_Click);
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
            // btnMailMAPIsend
            // 
            btnMailMAPIsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnMailMAPIsend.Location = new System.Drawing.Point(8, 251);
            btnMailMAPIsend.Name = "btnMailMAPIsend";
            btnMailMAPIsend.Size = new System.Drawing.Size(760, 32);
            btnMailMAPIsend.TabIndex = 7;
            btnMailMAPIsend.Text = "Send mail by simple MAPI";
            btnMailMAPIsend.UseVisualStyleBackColor = true;
            btnMailMAPIsend.Click += new System.EventHandler(this.btnMailMAPIsend_Click);
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
            // lblMailCopy
            // 
            lblMailCopy.AutoSize = true;
            lblMailCopy.Location = new System.Drawing.Point(21, 46);
            lblMailCopy.Name = "lblMailCopy";
            lblMailCopy.Size = new System.Drawing.Size(46, 13);
            lblMailCopy.TabIndex = 2;
            lblMailCopy.Text = "Copy to:";
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
            // gbMailSMTP
            // 
            gbMailSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbMailSMTP.Controls.Add(this.chbMailSMTPSecure);
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
            gbMailSMTP.ForeColor = System.Drawing.SystemColors.Highlight;
            gbMailSMTP.Location = new System.Drawing.Point(1, 289);
            gbMailSMTP.Name = "gbMailSMTP";
            gbMailSMTP.Size = new System.Drawing.Size(775, 134);
            gbMailSMTP.TabIndex = 8;
            gbMailSMTP.TabStop = false;
            gbMailSMTP.Text = "SMTP usage";
            // 
            // chbMailSMTPSecure
            // 
            this.chbMailSMTPSecure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMailSMTPSecure.AutoSize = true;
            this.chbMailSMTPSecure.Checked = true;
            this.chbMailSMTPSecure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMailSMTPSecure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbMailSMTPSecure.Location = new System.Drawing.Point(581, 39);
            this.chbMailSMTPSecure.Name = "chbMailSMTPSecure";
            this.chbMailSMTPSecure.Size = new System.Drawing.Size(183, 17);
            this.chbMailSMTPSecure.TabIndex = 6;
            this.chbMailSMTPSecure.Text = "requires secure connection (SSL)";
            this.chbMailSMTPSecure.UseVisualStyleBackColor = true;
            // 
            // nudMailSMPTport
            // 
            this.nudMailSMPTport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMailSMPTport.Location = new System.Drawing.Point(373, 38);
            this.nudMailSMPTport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudMailSMPTport.Name = "nudMailSMPTport";
            this.nudMailSMPTport.Size = new System.Drawing.Size(55, 20);
            this.nudMailSMPTport.TabIndex = 5;
            this.nudMailSMPTport.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // lblMailSMPTport
            // 
            lblMailSMPTport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblMailSMPTport.AutoSize = true;
            lblMailSMPTport.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMailSMPTport.Location = new System.Drawing.Point(338, 42);
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
            this.tbMailFrom.Size = new System.Drawing.Size(688, 20);
            this.tbMailFrom.TabIndex = 1;
            this.tbMailFrom.Text = "pavel.hermann@post.cz";
            // 
            // lblMailFrom
            // 
            lblMailFrom.AutoSize = true;
            lblMailFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMailFrom.Location = new System.Drawing.Point(43, 18);
            lblMailFrom.Name = "lblMailFrom";
            lblMailFrom.Size = new System.Drawing.Size(33, 13);
            lblMailFrom.TabIndex = 0;
            lblMailFrom.Text = "From:";
            // 
            // tbMailSMTPpwd
            // 
            this.tbMailSMTPpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPpwd.Location = new System.Drawing.Point(373, 60);
            this.tbMailSMTPpwd.Name = "tbMailSMTPpwd";
            this.tbMailSMTPpwd.PasswordChar = '*';
            this.tbMailSMTPpwd.Size = new System.Drawing.Size(207, 20);
            this.tbMailSMTPpwd.TabIndex = 10;
            this.tbMailSMTPpwd.UseSystemPasswordChar = true;
            // 
            // lblMailSMTPpwd
            // 
            lblMailSMTPpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblMailSMTPpwd.AutoSize = true;
            lblMailSMTPpwd.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMailSMTPpwd.Location = new System.Drawing.Point(311, 63);
            lblMailSMTPpwd.Name = "lblMailSMTPpwd";
            lblMailSMTPpwd.Size = new System.Drawing.Size(56, 13);
            lblMailSMTPpwd.TabIndex = 9;
            lblMailSMTPpwd.Text = "Password:";
            // 
            // tbMailSMTPuser
            // 
            this.tbMailSMTPuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPuser.Location = new System.Drawing.Point(79, 61);
            this.tbMailSMTPuser.Name = "tbMailSMTPuser";
            this.tbMailSMTPuser.Size = new System.Drawing.Size(222, 20);
            this.tbMailSMTPuser.TabIndex = 8;
            // 
            // lblMailSMTPuser
            // 
            lblMailSMTPuser.AutoSize = true;
            lblMailSMTPuser.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMailSMTPuser.Location = new System.Drawing.Point(41, 64);
            lblMailSMTPuser.Name = "lblMailSMTPuser";
            lblMailSMTPuser.Size = new System.Drawing.Size(32, 13);
            lblMailSMTPuser.TabIndex = 7;
            lblMailSMTPuser.Text = "User:";
            // 
            // tbMailSMTPserver
            // 
            this.tbMailSMTPserver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSMTPserver.Location = new System.Drawing.Point(79, 38);
            this.tbMailSMTPserver.Name = "tbMailSMTPserver";
            this.tbMailSMTPserver.Size = new System.Drawing.Size(222, 20);
            this.tbMailSMTPserver.TabIndex = 3;
            this.tbMailSMTPserver.Text = "smtp.gmail.com";
            // 
            // btnMailSMTPsend
            // 
            btnMailSMTPsend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnMailSMTPsend.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMailSMTPsend.Location = new System.Drawing.Point(8, 94);
            btnMailSMTPsend.Name = "btnMailSMTPsend";
            btnMailSMTPsend.Size = new System.Drawing.Size(759, 32);
            btnMailSMTPsend.TabIndex = 11;
            btnMailSMTPsend.Text = "Send mail by SMTP";
            btnMailSMTPsend.UseVisualStyleBackColor = true;
            btnMailSMTPsend.Click += new System.EventHandler(this.btnMailSMTPsend_Click);
            // 
            // lblMailSMTPserver
            // 
            lblMailSMTPserver.AutoSize = true;
            lblMailSMTPserver.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMailSMTPserver.Location = new System.Drawing.Point(4, 42);
            lblMailSMTPserver.Name = "lblMailSMTPserver";
            lblMailSMTPserver.Size = new System.Drawing.Size(72, 13);
            lblMailSMTPserver.TabIndex = 2;
            lblMailSMTPserver.Text = "SMTP server:";
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
            panelUI.Size = new System.Drawing.Size(776, 423);
            panelUI.TabIndex = 0;
            // 
            // btnUImbox
            // 
            this.btnUImbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUImbox.Location = new System.Drawing.Point(3, 392);
            this.btnUImbox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnUImbox.Name = "btnUImbox";
            this.btnUImbox.Size = new System.Drawing.Size(382, 28);
            this.btnUImbox.TabIndex = 6;
            this.btnUImbox.Text = "Call message box";
            this.btnUImbox.UseVisualStyleBackColor = true;
            this.btnUImbox.Click += new System.EventHandler(this.btnUImbox_Click);
            // 
            // lblUImbox
            // 
            lblUImbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUImbox.AutoSize = true;
            lblUImbox.ForeColor = System.Drawing.SystemColors.Highlight;
            lblUImbox.Location = new System.Drawing.Point(3, 203);
            lblUImbox.Name = "lblUImbox";
            lblUImbox.Size = new System.Drawing.Size(100, 13);
            lblUImbox.TabIndex = 4;
            lblUImbox.Text = "Message Box Icons";
            // 
            // listUImbox
            // 
            this.listUImbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUImbox.FullRowSelect = true;
            this.listUImbox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listUImbox.HideSelection = false;
            this.listUImbox.Location = new System.Drawing.Point(3, 219);
            this.listUImbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listUImbox.Name = "listUImbox";
            this.listUImbox.Size = new System.Drawing.Size(382, 173);
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
            this.treeUI.Location = new System.Drawing.Point(391, 23);
            this.treeUI.Name = "treeUI";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Subpoložka 1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Polozka 1";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Subpoložka 2";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Subpoložka 3";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Subpoložka 4";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Položka 2";
            this.treeUI.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6});
            this.treeUI.Size = new System.Drawing.Size(382, 170);
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
            this.listUI.Size = new System.Drawing.Size(382, 170);
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
            // lblUIlist
            // 
            lblUIlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            lblUIlist.AutoSize = true;
            lblUIlist.ForeColor = System.Drawing.SystemColors.Highlight;
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
            lblUItree.ForeColor = System.Drawing.SystemColors.Highlight;
            lblUItree.Location = new System.Drawing.Point(391, 7);
            lblUItree.Name = "lblUItree";
            lblUItree.Size = new System.Drawing.Size(116, 13);
            lblUItree.TabIndex = 2;
            lblUItree.Text = "Owner drawn tree view";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(391, 203);
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
            panelUITreeBox.Location = new System.Drawing.Point(391, 219);
            panelUITreeBox.Name = "panelUITreeBox";
            panelUITreeBox.Size = new System.Drawing.Size(382, 170);
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
            // tbUI
            // 
            this.tbUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUI.DropDownHeight = 250;
            this.tbUI.Location = new System.Drawing.Point(0, 0);
            this.tbUI.Name = "tbUI";
            this.tbUI.Size = new System.Drawing.Size(382, 21);
            this.tbUI.TabIndex = 8;
            this.tbUI.TextEditable = false;
            this.tbUI.TextValue = "XXX";
            // 
            // btnLangMemberAccess
            // 
            btnLangMemberAccess.Location = new System.Drawing.Point(14, 285);
            btnLangMemberAccess.Name = "btnLangMemberAccess";
            btnLangMemberAccess.Size = new System.Drawing.Size(174, 38);
            btnLangMemberAccess.TabIndex = 1;
            btnLangMemberAccess.Text = "Private member access test";
            btnLangMemberAccess.UseVisualStyleBackColor = true;
            btnLangMemberAccess.Click += new System.EventHandler(this.btnLangProp_Click);
            // 
            // btnLangException
            // 
            btnLangException.Location = new System.Drawing.Point(191, 285);
            btnLangException.Name = "btnLangException";
            btnLangException.Size = new System.Drawing.Size(174, 38);
            btnLangException.TabIndex = 2;
            btnLangException.Text = "Inner exception test";
            btnLangException.UseVisualStyleBackColor = true;
            btnLangException.Click += new System.EventHandler(this.btnLangException_Click);
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
            gbLangRefl.ForeColor = System.Drawing.SystemColors.Highlight;
            gbLangRefl.Location = new System.Drawing.Point(0, 0);
            gbLangRefl.Name = "gbLangRefl";
            gbLangRefl.Size = new System.Drawing.Size(776, 90);
            gbLangRefl.TabIndex = 0;
            gbLangRefl.TabStop = false;
            gbLangRefl.Text = "Reflection";
            // 
            // tbLangReflParam2
            // 
            this.tbLangReflParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangReflParam2.Location = new System.Drawing.Point(582, 18);
            this.tbLangReflParam2.Name = "tbLangReflParam2";
            this.tbLangReflParam2.Size = new System.Drawing.Size(77, 20);
            this.tbLangReflParam2.TabIndex = 3;
            this.tbLangReflParam2.Text = "1";
            // 
            // lblLangRefl4
            // 
            lblLangRefl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl4.AutoSize = true;
            lblLangRefl4.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangRefl4.Location = new System.Drawing.Point(757, 19);
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
            this.cbLangReflParam1.Size = new System.Drawing.Size(480, 21);
            this.cbLangReflParam1.TabIndex = 1;
            // 
            // lblLangRefl3
            // 
            lblLangRefl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl3.AutoSize = true;
            lblLangRefl3.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangRefl3.Location = new System.Drawing.Point(662, 22);
            lblLangRefl3.Margin = new System.Windows.Forms.Padding(0);
            lblLangRefl3.Name = "lblLangRefl3";
            lblLangRefl3.Size = new System.Drawing.Size(18, 13);
            lblLangRefl3.TabIndex = 4;
            lblLangRefl3.Text = "as";
            // 
            // lbLangRefl
            // 
            lbLangRefl.AutoSize = true;
            lbLangRefl.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tbLangReflResult.Size = new System.Drawing.Size(671, 33);
            this.tbLangReflResult.TabIndex = 7;
            // 
            // cbLangReflType
            // 
            this.cbLangReflType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLangReflType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLangReflType.FormattingEnabled = true;
            this.cbLangReflType.Location = new System.Drawing.Point(683, 18);
            this.cbLangReflType.Name = "cbLangReflType";
            this.cbLangReflType.Size = new System.Drawing.Size(71, 21);
            this.cbLangReflType.TabIndex = 5;
            // 
            // lblLangRefl2
            // 
            lblLangRefl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangRefl2.AutoSize = true;
            lblLangRefl2.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangRefl2.Location = new System.Drawing.Point(563, 21);
            lblLangRefl2.Margin = new System.Windows.Forms.Padding(0);
            lblLangRefl2.Name = "lblLangRefl2";
            lblLangRefl2.Size = new System.Drawing.Size(18, 13);
            lblLangRefl2.TabIndex = 2;
            lblLangRefl2.Text = "\", ";
            // 
            // gbLangDelg
            // 
            gbLangDelg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbLangDelg.Controls.Add(panelLangDelg);
            gbLangDelg.ForeColor = System.Drawing.SystemColors.Highlight;
            gbLangDelg.Location = new System.Drawing.Point(0, 176);
            gbLangDelg.Name = "gbLangDelg";
            gbLangDelg.Size = new System.Drawing.Size(776, 93);
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
            panelLangDelg.Size = new System.Drawing.Size(761, 61);
            panelLangDelg.TabIndex = 15;
            // 
            // btnLangDelgLambda
            // 
            this.btnLangDelgLambda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLangDelgLambda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLangDelgLambda.Location = new System.Drawing.Point(380, 30);
            this.btnLangDelgLambda.Margin = new System.Windows.Forms.Padding(0);
            this.btnLangDelgLambda.Name = "btnLangDelgLambda";
            this.btnLangDelgLambda.Size = new System.Drawing.Size(381, 31);
            this.btnLangDelgLambda.TabIndex = 3;
            this.btnLangDelgLambda.Text = "Delegate realized as lambda expression";
            this.btnLangDelgLambda.UseVisualStyleBackColor = true;
            // 
            // btnLangDelgAnonymous
            // 
            this.btnLangDelgAnonymous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLangDelgAnonymous.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLangDelgAnonymous.Location = new System.Drawing.Point(0, 30);
            this.btnLangDelgAnonymous.Margin = new System.Windows.Forms.Padding(0);
            this.btnLangDelgAnonymous.Name = "btnLangDelgAnonymous";
            this.btnLangDelgAnonymous.Size = new System.Drawing.Size(380, 31);
            this.btnLangDelgAnonymous.TabIndex = 2;
            this.btnLangDelgAnonymous.Text = "Anonymous delegate";
            this.btnLangDelgAnonymous.UseVisualStyleBackColor = true;
            // 
            // btnLangDelgGUItest
            // 
            btnLangDelgGUItest.Dock = System.Windows.Forms.DockStyle.Fill;
            btnLangDelgGUItest.ForeColor = System.Drawing.SystemColors.ControlText;
            btnLangDelgGUItest.Location = new System.Drawing.Point(380, 0);
            btnLangDelgGUItest.Margin = new System.Windows.Forms.Padding(0);
            btnLangDelgGUItest.Name = "btnLangDelgGUItest";
            btnLangDelgGUItest.Size = new System.Drawing.Size(381, 30);
            btnLangDelgGUItest.TabIndex = 1;
            btnLangDelgGUItest.Text = "Control.BeginInvoke - GUI test";
            btnLangDelgGUItest.UseVisualStyleBackColor = true;
            btnLangDelgGUItest.Click += new System.EventHandler(this.btnLangDelgGUItest_Click);
            // 
            // btnLangDelgTest
            // 
            btnLangDelgTest.Dock = System.Windows.Forms.DockStyle.Fill;
            btnLangDelgTest.ForeColor = System.Drawing.SystemColors.ControlText;
            btnLangDelgTest.Location = new System.Drawing.Point(0, 0);
            btnLangDelgTest.Margin = new System.Windows.Forms.Padding(0);
            btnLangDelgTest.Name = "btnLangDelgTest";
            btnLangDelgTest.Size = new System.Drawing.Size(380, 30);
            btnLangDelgTest.TabIndex = 0;
            btnLangDelgTest.Text = "Delegate\'s BeginInvoke test";
            btnLangDelgTest.UseVisualStyleBackColor = true;
            btnLangDelgTest.Click += new System.EventHandler(this.btnLangDelgTest_Click);
            // 
            // lblXML
            // 
            lblXML.AutoSize = true;
            lblXML.Location = new System.Drawing.Point(20, 21);
            lblXML.Name = "lblXML";
            lblXML.Size = new System.Drawing.Size(48, 13);
            lblXML.TabIndex = 0;
            lblXML.Text = "XML file:";
            // 
            // btnXmlSerialize
            // 
            btnXmlSerialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnXmlSerialize.Location = new System.Drawing.Point(611, 41);
            btnXmlSerialize.Name = "btnXmlSerialize";
            btnXmlSerialize.Size = new System.Drawing.Size(160, 36);
            btnXmlSerialize.TabIndex = 6;
            btnXmlSerialize.Text = "Save - serialize items to file";
            btnXmlSerialize.UseVisualStyleBackColor = true;
            btnXmlSerialize.Click += new System.EventHandler(this.onXmlSerialize_Click);
            // 
            // btnXMLParse
            // 
            btnXMLParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnXMLParse.Location = new System.Drawing.Point(445, 41);
            btnXMLParse.Name = "btnXMLParse";
            btnXMLParse.Size = new System.Drawing.Size(160, 36);
            btnXMLParse.TabIndex = 5;
            btnXMLParse.Text = "Load - parse items from file";
            btnXMLParse.UseVisualStyleBackColor = true;
            btnXMLParse.Click += new System.EventHandler(this.onXMLParse_Click);
            // 
            // lblXmlItems
            // 
            lblXmlItems.AutoSize = true;
            lblXmlItems.Location = new System.Drawing.Point(3, 66);
            lblXmlItems.Name = "lblXmlItems";
            lblXmlItems.Size = new System.Drawing.Size(125, 13);
            lblXmlItems.TabIndex = 3;
            lblXmlItems.Text = "XML items (F2 - edit cell):";
            // 
            // pnlLINQ
            // 
            pnlLINQ.ColumnCount = 2;
            pnlLINQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.Controls.Add(gbLINQobj, 0, 0);
            pnlLINQ.Controls.Add(gbLINQtoXML, 1, 0);
            pnlLINQ.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLINQ.Location = new System.Drawing.Point(3, 3);
            pnlLINQ.Name = "pnlLINQ";
            pnlLINQ.RowCount = 1;
            pnlLINQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            pnlLINQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            pnlLINQ.Size = new System.Drawing.Size(770, 417);
            pnlLINQ.TabIndex = 1;
            // 
            // gbLINQobj
            // 
            gbLINQobj.Controls.Add(btnLINQselObj);
            gbLINQobj.Controls.Add(this.tbLINQobj);
            gbLINQobj.Controls.Add(lblLINQobj);
            gbLINQobj.Controls.Add(this.listLINQobj);
            gbLINQobj.Dock = System.Windows.Forms.DockStyle.Fill;
            gbLINQobj.ForeColor = System.Drawing.SystemColors.Highlight;
            gbLINQobj.Location = new System.Drawing.Point(3, 3);
            gbLINQobj.Name = "gbLINQobj";
            gbLINQobj.Size = new System.Drawing.Size(379, 411);
            gbLINQobj.TabIndex = 0;
            gbLINQobj.TabStop = false;
            gbLINQobj.Text = "LINQ to Objects";
            // 
            // btnLINQselObj
            // 
            btnLINQselObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnLINQselObj.ForeColor = System.Drawing.SystemColors.ControlText;
            btnLINQselObj.Location = new System.Drawing.Point(348, 30);
            btnLINQselObj.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            btnLINQselObj.Name = "btnLINQselObj";
            btnLINQselObj.Size = new System.Drawing.Size(28, 22);
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
            this.tbLINQobj.Location = new System.Drawing.Point(3, 31);
            this.tbLINQobj.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbLINQobj.Name = "tbLINQobj";
            this.tbLINQobj.ReadOnly = true;
            this.tbLINQobj.Size = new System.Drawing.Size(345, 20);
            this.tbLINQobj.TabIndex = 1;
            // 
            // lblLINQobj
            // 
            lblLINQobj.AutoSize = true;
            lblLINQobj.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLINQobj.Location = new System.Drawing.Point(0, 16);
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
            this.listLINQobj.Location = new System.Drawing.Point(3, 53);
            this.listLINQobj.Name = "listLINQobj";
            this.listLINQobj.Size = new System.Drawing.Size(373, 354);
            this.listLINQobj.TabIndex = 3;
            // 
            // gbLINQtoXML
            // 
            gbLINQtoXML.Controls.Add(splitContainer1);
            gbLINQtoXML.Dock = System.Windows.Forms.DockStyle.Fill;
            gbLINQtoXML.ForeColor = System.Drawing.SystemColors.Highlight;
            gbLINQtoXML.Location = new System.Drawing.Point(388, 3);
            gbLINQtoXML.Name = "gbLINQtoXML";
            gbLINQtoXML.Size = new System.Drawing.Size(379, 411);
            gbLINQtoXML.TabIndex = 1;
            gbLINQtoXML.TabStop = false;
            gbLINQtoXML.Text = "LINQ to XML";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 16);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(this.tbLINQxml);
            splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.rbLINQxmlAccnt);
            splitContainer1.Panel2.Controls.Add(lblLinqAddr);
            splitContainer1.Panel2.Controls.Add(this.rbLINQxmlDeliv);
            splitContainer1.Panel2.Controls.Add(this.rbLINQxmlAll);
            splitContainer1.Panel2.Controls.Add(this.listLINQxml);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new System.Drawing.Size(373, 392);
            splitContainer1.SplitterDistance = 150;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(3, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 0;
            label3.Text = "Xml data:";
            // 
            // tbLINQxml
            // 
            this.tbLINQxml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLINQxml.BackColor = System.Drawing.SystemColors.Window;
            this.tbLINQxml.Location = new System.Drawing.Point(0, 21);
            this.tbLINQxml.Margin = new System.Windows.Forms.Padding(0);
            this.tbLINQxml.Multiline = true;
            this.tbLINQxml.Name = "tbLINQxml";
            this.tbLINQxml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLINQxml.Size = new System.Drawing.Size(373, 129);
            this.tbLINQxml.TabIndex = 1;
            this.tbLINQxml.Text = resources.GetString("tbLINQxml.Text");
            this.tbLINQxml.TextChanged += new System.EventHandler(this.onLINQxml_Changed);
            // 
            // rbLINQxmlAccnt
            // 
            this.rbLINQxmlAccnt.AutoSize = true;
            this.rbLINQxmlAccnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLINQxmlAccnt.Location = new System.Drawing.Point(209, 3);
            this.rbLINQxmlAccnt.Name = "rbLINQxmlAccnt";
            this.rbLINQxmlAccnt.Size = new System.Drawing.Size(74, 17);
            this.rbLINQxmlAccnt.TabIndex = 2;
            this.rbLINQxmlAccnt.Text = "A-account";
            this.rbLINQxmlAccnt.UseVisualStyleBackColor = true;
            this.rbLINQxmlAccnt.CheckedChanged += new System.EventHandler(this.onLINQxml_Changed);
            // 
            // lblLinqAddr
            // 
            lblLinqAddr.AutoSize = true;
            lblLinqAddr.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLinqAddr.Location = new System.Drawing.Point(2, 3);
            lblLinqAddr.Name = "lblLinqAddr";
            lblLinqAddr.Size = new System.Drawing.Size(123, 13);
            lblLinqAddr.TabIndex = 0;
            lblLinqAddr.Text = "Show addresses of type:";
            // 
            // rbLINQxmlDeliv
            // 
            this.rbLINQxmlDeliv.AutoSize = true;
            this.rbLINQxmlDeliv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLINQxmlDeliv.Location = new System.Drawing.Point(131, 3);
            this.rbLINQxmlDeliv.Name = "rbLINQxmlDeliv";
            this.rbLINQxmlDeliv.Size = new System.Drawing.Size(72, 17);
            this.rbLINQxmlDeliv.TabIndex = 1;
            this.rbLINQxmlDeliv.Text = "D-delivery";
            this.rbLINQxmlDeliv.UseVisualStyleBackColor = true;
            this.rbLINQxmlDeliv.CheckedChanged += new System.EventHandler(this.onLINQxml_Changed);
            // 
            // rbLINQxmlAll
            // 
            this.rbLINQxmlAll.AutoSize = true;
            this.rbLINQxmlAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLINQxmlAll.Location = new System.Drawing.Point(289, 3);
            this.rbLINQxmlAll.Name = "rbLINQxmlAll";
            this.rbLINQxmlAll.Size = new System.Drawing.Size(35, 17);
            this.rbLINQxmlAll.TabIndex = 3;
            this.rbLINQxmlAll.Text = "all";
            this.rbLINQxmlAll.UseVisualStyleBackColor = true;
            this.rbLINQxmlAll.CheckedChanged += new System.EventHandler(this.onLINQxml_Changed);
            // 
            // listLINQxml
            // 
            this.listLINQxml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLINQxml.GridLines = true;
            this.listLINQxml.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listLINQxml.HideSelection = false;
            this.listLINQxml.Location = new System.Drawing.Point(0, 26);
            this.listLINQxml.Margin = new System.Windows.Forms.Padding(0);
            this.listLINQxml.Name = "listLINQxml";
            this.listLINQxml.Size = new System.Drawing.Size(373, 201);
            this.listLINQxml.TabIndex = 4;
            this.listLINQxml.UseCompatibleStateImageBehavior = false;
            this.listLINQxml.View = System.Windows.Forms.View.Details;
            // 
            // lblIOclass
            // 
            lblIOclass.AutoSize = true;
            lblIOclass.ForeColor = System.Drawing.SystemColors.Highlight;
            lblIOclass.Location = new System.Drawing.Point(3, 6);
            lblIOclass.Name = "lblIOclass";
            lblIOclass.Size = new System.Drawing.Size(121, 13);
            lblIOclass.TabIndex = 0;
            lblIOclass.Text = "Path && Directory classes";
            // 
            // lblIOdirWatch
            // 
            lblIOdirWatch.AutoSize = true;
            lblIOdirWatch.Location = new System.Drawing.Point(3, 10);
            lblIOdirWatch.Name = "lblIOdirWatch";
            lblIOdirWatch.Size = new System.Drawing.Size(101, 13);
            lblIOdirWatch.TabIndex = 0;
            lblIOdirWatch.Text = "Directory to monitor:";
            // 
            // lblIOfileWatch
            // 
            lblIOfileWatch.AutoSize = true;
            lblIOfileWatch.Location = new System.Drawing.Point(6, 9);
            lblIOfileWatch.Name = "lblIOfileWatch";
            lblIOfileWatch.Size = new System.Drawing.Size(75, 13);
            lblIOfileWatch.TabIndex = 0;
            lblIOfileWatch.Text = "File to monitor:";
            // 
            // lblIOfileWatchContent
            // 
            lblIOfileWatchContent.AutoSize = true;
            lblIOfileWatchContent.Location = new System.Drawing.Point(16, 32);
            lblIOfileWatchContent.Name = "lblIOfileWatchContent";
            lblIOfileWatchContent.Size = new System.Drawing.Size(65, 13);
            lblIOfileWatchContent.TabIndex = 2;
            lblIOfileWatchContent.Text = "File content:";
            // 
            // lblIOfileWatchLastWrite
            // 
            lblIOfileWatchLastWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblIOfileWatchLastWrite.AutoSize = true;
            lblIOfileWatchLastWrite.Location = new System.Drawing.Point(170, 32);
            lblIOfileWatchLastWrite.Name = "lblIOfileWatchLastWrite";
            lblIOfileWatchLastWrite.Size = new System.Drawing.Size(55, 13);
            lblIOfileWatchLastWrite.TabIndex = 3;
            lblIOfileWatchLastWrite.Text = "Last write:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.Highlight;
            label4.Location = new System.Drawing.Point(2, 222);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 13);
            label4.TabIndex = 0;
            label4.Text = "File watcher";
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
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new System.Drawing.Point(3, 53);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new System.Drawing.Size(75, 13);
            lblServiceName.TabIndex = 3;
            lblServiceName.Text = "Service name:";
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
            gbServiceAccnt.Size = new System.Drawing.Size(768, 113);
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
            this.tbServiceUser.Size = new System.Drawing.Size(497, 20);
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
            this.cbServiceAccount.Size = new System.Drawing.Size(497, 21);
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
            this.tbServicePwd.Size = new System.Drawing.Size(497, 20);
            this.tbServicePwd.TabIndex = 5;
            // 
            // btnServiceUninstall
            // 
            this.btnServiceUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceUninstall.Location = new System.Drawing.Point(583, 62);
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
            this.btnServiceInstall.Location = new System.Drawing.Point(583, 16);
            this.btnServiceInstall.Name = "btnServiceInstall";
            this.btnServiceInstall.Size = new System.Drawing.Size(177, 40);
            this.btnServiceInstall.TabIndex = 6;
            this.btnServiceInstall.Text = "Install";
            this.btnServiceInstall.UseVisualStyleBackColor = true;
            this.btnServiceInstall.Click += new System.EventHandler(this.btnServiceAction_Click);
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
            // lblAlgAdStreet
            // 
            lblAlgAdStreet.AutoSize = true;
            lblAlgAdStreet.Location = new System.Drawing.Point(179, 42);
            lblAlgAdStreet.Name = "lblAlgAdStreet";
            lblAlgAdStreet.Size = new System.Drawing.Size(38, 13);
            lblAlgAdStreet.TabIndex = 6;
            lblAlgAdStreet.Text = "Street:";
            // 
            // lblAlgAdName
            // 
            lblAlgAdName.AutoSize = true;
            lblAlgAdName.Location = new System.Drawing.Point(179, 21);
            lblAlgAdName.Name = "lblAlgAdName";
            lblAlgAdName.Size = new System.Drawing.Size(38, 13);
            lblAlgAdName.TabIndex = 4;
            lblAlgAdName.Text = "Name:";
            // 
            // lblAlgAdCity
            // 
            lblAlgAdCity.AutoSize = true;
            lblAlgAdCity.Location = new System.Drawing.Point(190, 63);
            lblAlgAdCity.Name = "lblAlgAdCity";
            lblAlgAdCity.Size = new System.Drawing.Size(27, 13);
            lblAlgAdCity.TabIndex = 8;
            lblAlgAdCity.Text = "City:";
            // 
            // lblAlgAdVAT
            // 
            lblAlgAdVAT.AutoSize = true;
            lblAlgAdVAT.Location = new System.Drawing.Point(32, 59);
            lblAlgAdVAT.Name = "lblAlgAdVAT";
            lblAlgAdVAT.Size = new System.Drawing.Size(45, 13);
            lblAlgAdVAT.TabIndex = 2;
            lblAlgAdVAT.Text = "VAT ID:";
            // 
            // lblAlgAdZip
            // 
            lblAlgAdZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAlgAdZip.AutoSize = true;
            lblAlgAdZip.Location = new System.Drawing.Point(571, 64);
            lblAlgAdZip.Name = "lblAlgAdZip";
            lblAlgAdZip.Size = new System.Drawing.Size(25, 13);
            lblAlgAdZip.TabIndex = 10;
            lblAlgAdZip.Text = "Zip:";
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
            gbWrapText.Size = new System.Drawing.Size(776, 125);
            gbWrapText.TabIndex = 2;
            gbWrapText.TabStop = false;
            // 
            // nudAlgWrap
            // 
            this.nudAlgWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAlgWrap.Location = new System.Drawing.Point(661, 31);
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
            this.tbAlgWrap.Size = new System.Drawing.Size(643, 46);
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
            this.tbAlgWrapText.Size = new System.Drawing.Size(643, 46);
            this.tbAlgWrapText.TabIndex = 1;
            // 
            // btnAlgWrapText
            // 
            this.btnAlgWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgWrapText.Location = new System.Drawing.Point(661, 53);
            this.btnAlgWrapText.Name = "btnAlgWrapText";
            this.btnAlgWrapText.Size = new System.Drawing.Size(104, 33);
            this.btnAlgWrapText.TabIndex = 4;
            this.btnAlgWrapText.Text = "Wrap text";
            this.btnAlgWrapText.UseVisualStyleBackColor = true;
            this.btnAlgWrapText.Click += new System.EventHandler(this.btnAlgWrapText_Click);
            // 
            // lblAlgWrap
            // 
            lblAlgWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblAlgWrap.AutoSize = true;
            lblAlgWrap.Location = new System.Drawing.Point(661, 17);
            lblAlgWrap.Name = "lblAlgWrap";
            lblAlgWrap.Size = new System.Drawing.Size(104, 13);
            lblAlgWrap.TabIndex = 2;
            lblAlgWrap.Text = "Required line length:";
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
            gbAlgNum.Size = new System.Drawing.Size(776, 53);
            gbAlgNum.TabIndex = 1;
            gbAlgNum.TabStop = false;
            // 
            // btnAlgNumToText
            // 
            this.btnAlgNumToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgNumToText.Location = new System.Drawing.Point(661, 15);
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
            this.tbAlgNumText.Size = new System.Drawing.Size(558, 20);
            this.tbAlgNumText.TabIndex = 1;
            // 
            // lblLangAppProdVer
            // 
            lblLangAppProdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblLangAppProdVer.AutoSize = true;
            lblLangAppProdVer.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangAppProdVer.Location = new System.Drawing.Point(531, 66);
            lblLangAppProdVer.Name = "lblLangAppProdVer";
            lblLangAppProdVer.Size = new System.Drawing.Size(137, 13);
            lblLangAppProdVer.TabIndex = 18;
            lblLangAppProdVer.Text = "Application.ProductVersion:";
            // 
            // lblLangAppProdName
            // 
            lblLangAppProdName.AutoSize = true;
            lblLangAppProdName.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangAppProdName.Location = new System.Drawing.Point(15, 66);
            lblLangAppProdName.Name = "lblLangAppProdName";
            lblLangAppProdName.Size = new System.Drawing.Size(130, 13);
            lblLangAppProdName.TabIndex = 16;
            lblLangAppProdName.Text = "Application.ProductName:";
            // 
            // lblLangAppPathExe
            // 
            lblLangAppPathExe.AutoSize = true;
            lblLangAppPathExe.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangAppPathExe.Location = new System.Drawing.Point(5, 22);
            lblLangAppPathExe.Name = "lblLangAppPathExe";
            lblLangAppPathExe.Size = new System.Drawing.Size(140, 13);
            lblLangAppPathExe.TabIndex = 12;
            lblLangAppPathExe.Text = "Application.ExecutablePath:";
            // 
            // lblLangAppPathStartup
            // 
            lblLangAppPathStartup.AutoSize = true;
            lblLangAppPathStartup.ForeColor = System.Drawing.SystemColors.ControlText;
            lblLangAppPathStartup.Location = new System.Drawing.Point(22, 43);
            lblLangAppPathStartup.Name = "lblLangAppPathStartup";
            lblLangAppPathStartup.Size = new System.Drawing.Size(121, 13);
            lblLangAppPathStartup.TabIndex = 14;
            lblLangAppPathStartup.Text = "Application.StartupPath:";
            // 
            // chbOnTop
            // 
            this.chbOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbOnTop.AutoSize = true;
            this.chbOnTop.Location = new System.Drawing.Point(9, 480);
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
            this.tbUser.BackColor = System.Drawing.SystemColors.Window;
            this.tbUser.Location = new System.Drawing.Point(438, 478);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(315, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbComputer
            // 
            this.tbComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbComputer.BackColor = System.Drawing.SystemColors.Window;
            this.tbComputer.Location = new System.Drawing.Point(233, 478);
            this.tbComputer.Name = "tbComputer";
            this.tbComputer.ReadOnly = true;
            this.tbComputer.Size = new System.Drawing.Size(126, 20);
            this.tbComputer.TabIndex = 5;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(gbOtherProcess);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(776, 423);
            this.tabOther.TabIndex = 9;
            this.tabOther.Text = "Other tests";
            this.tabOther.UseVisualStyleBackColor = true;
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
            this.tabWeb.Size = new System.Drawing.Size(776, 423);
            this.tabWeb.TabIndex = 8;
            this.tabWeb.Text = "Web";
            this.tabWeb.UseVisualStyleBackColor = true;
            // 
            // tbWWWURL
            // 
            this.tbWWWURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWWWURL.Location = new System.Drawing.Point(46, 20);
            this.tbWWWURL.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbWWWURL.Name = "tbWWWURL";
            this.tbWWWURL.Size = new System.Drawing.Size(641, 20);
            this.tbWWWURL.TabIndex = 1;
            this.tbWWWURL.Text = "https://www.w3.org/html/";
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
            this.tbWWWContent.Size = new System.Drawing.Size(776, 356);
            this.tbWWWContent.TabIndex = 4;
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
            this.tabMail.Size = new System.Drawing.Size(776, 423);
            this.tabMail.TabIndex = 0;
            this.tabMail.Text = "MAPI & SMTP";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // tbMailBody
            // 
            this.tbMailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailBody.Location = new System.Drawing.Point(8, 95);
            this.tbMailBody.Multiline = true;
            this.tbMailBody.Name = "tbMailBody";
            this.tbMailBody.Size = new System.Drawing.Size(760, 150);
            this.tbMailBody.TabIndex = 6;
            this.tbMailBody.Text = "Mail from test application.\r\n\r\nP.H.";
            // 
            // tbMailSubject
            // 
            this.tbMailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailSubject.Location = new System.Drawing.Point(73, 69);
            this.tbMailSubject.Name = "tbMailSubject";
            this.tbMailSubject.Size = new System.Drawing.Size(695, 20);
            this.tbMailSubject.TabIndex = 5;
            this.tbMailSubject.Text = "Test mail";
            // 
            // tbMailCopy
            // 
            this.tbMailCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailCopy.Location = new System.Drawing.Point(73, 43);
            this.tbMailCopy.Name = "tbMailCopy";
            this.tbMailCopy.Size = new System.Drawing.Size(695, 20);
            this.tbMailCopy.TabIndex = 3;
            // 
            // tbMailRcp
            // 
            this.tbMailRcp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMailRcp.Location = new System.Drawing.Point(73, 17);
            this.tbMailRcp.Name = "tbMailRcp";
            this.tbMailRcp.Size = new System.Drawing.Size(695, 20);
            this.tbMailRcp.TabIndex = 1;
            this.tbMailRcp.Text = "pavel.hermann@post.cz";
            // 
            // tabUI
            // 
            this.tabUI.Controls.Add(panelUI);
            this.tabUI.Location = new System.Drawing.Point(4, 22);
            this.tabUI.Name = "tabUI";
            this.tabUI.Size = new System.Drawing.Size(776, 423);
            this.tabUI.TabIndex = 6;
            this.tabUI.Text = "UI & controls";
            this.tabUI.UseVisualStyleBackColor = true;
            // 
            // tabLang
            // 
            this.tabLang.Controls.Add(gbLangDelg);
            this.tabLang.Controls.Add(this.tbLangSysVar);
            this.tabLang.Controls.Add(gbLangRefl);
            this.tabLang.Controls.Add(btnLangException);
            this.tabLang.Controls.Add(btnLangMemberAccess);
            this.tabLang.Location = new System.Drawing.Point(4, 22);
            this.tabLang.Name = "tabLang";
            this.tabLang.Size = new System.Drawing.Size(776, 423);
            this.tabLang.TabIndex = 4;
            this.tabLang.Text = "C# features";
            this.tabLang.UseVisualStyleBackColor = true;
            // 
            // tbLangSysVar
            // 
            this.tbLangSysVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangSysVar.Controls.Add(this.tbLangAppProdVer);
            this.tbLangSysVar.Controls.Add(this.tbLangAppProdName);
            this.tbLangSysVar.Controls.Add(this.tbLangAppPathExe);
            this.tbLangSysVar.Controls.Add(this.tbLangAppPathStartup);
            this.tbLangSysVar.Controls.Add(lblLangAppProdVer);
            this.tbLangSysVar.Controls.Add(lblLangAppProdName);
            this.tbLangSysVar.Controls.Add(lblLangAppPathExe);
            this.tbLangSysVar.Controls.Add(lblLangAppPathStartup);
            this.tbLangSysVar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbLangSysVar.Location = new System.Drawing.Point(0, 82);
            this.tbLangSysVar.Name = "tbLangSysVar";
            this.tbLangSysVar.Size = new System.Drawing.Size(776, 102);
            this.tbLangSysVar.TabIndex = 3;
            this.tbLangSysVar.TabStop = false;
            this.tbLangSysVar.Text = "System variables";
            // 
            // tbLangAppProdVer
            // 
            this.tbLangAppProdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangAppProdVer.BackColor = System.Drawing.SystemColors.Window;
            this.tbLangAppProdVer.Location = new System.Drawing.Point(674, 63);
            this.tbLangAppProdVer.Name = "tbLangAppProdVer";
            this.tbLangAppProdVer.ReadOnly = true;
            this.tbLangAppProdVer.Size = new System.Drawing.Size(90, 20);
            this.tbLangAppProdVer.TabIndex = 19;
            // 
            // tbLangAppProdName
            // 
            this.tbLangAppProdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangAppProdName.BackColor = System.Drawing.SystemColors.Window;
            this.tbLangAppProdName.Location = new System.Drawing.Point(146, 63);
            this.tbLangAppProdName.Name = "tbLangAppProdName";
            this.tbLangAppProdName.ReadOnly = true;
            this.tbLangAppProdName.Size = new System.Drawing.Size(379, 20);
            this.tbLangAppProdName.TabIndex = 17;
            // 
            // tbLangAppPathExe
            // 
            this.tbLangAppPathExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangAppPathExe.BackColor = System.Drawing.SystemColors.Window;
            this.tbLangAppPathExe.Location = new System.Drawing.Point(146, 19);
            this.tbLangAppPathExe.Name = "tbLangAppPathExe";
            this.tbLangAppPathExe.ReadOnly = true;
            this.tbLangAppPathExe.Size = new System.Drawing.Size(618, 20);
            this.tbLangAppPathExe.TabIndex = 13;
            // 
            // tbLangAppPathStartup
            // 
            this.tbLangAppPathStartup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLangAppPathStartup.BackColor = System.Drawing.SystemColors.Window;
            this.tbLangAppPathStartup.Location = new System.Drawing.Point(146, 40);
            this.tbLangAppPathStartup.Name = "tbLangAppPathStartup";
            this.tbLangAppPathStartup.ReadOnly = true;
            this.tbLangAppPathStartup.Size = new System.Drawing.Size(618, 20);
            this.tbLangAppPathStartup.TabIndex = 15;
            // 
            // tabXML
            // 
            this.tabXML.Controls.Add(this.dgXmlItems);
            this.tabXML.Controls.Add(lblXmlItems);
            this.tabXML.Controls.Add(this.tbXmlFile);
            this.tabXML.Controls.Add(btnXMLParse);
            this.tabXML.Controls.Add(btnXmlSerialize);
            this.tabXML.Controls.Add(lblXML);
            this.tabXML.Controls.Add(this.btnXmlFileSel);
            this.tabXML.Location = new System.Drawing.Point(4, 22);
            this.tabXML.Name = "tabXML";
            this.tabXML.Size = new System.Drawing.Size(776, 423);
            this.tabXML.TabIndex = 3;
            this.tabXML.Text = "XML";
            this.tabXML.UseVisualStyleBackColor = true;
            // 
            // dgXmlItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgXmlItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgXmlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgXmlItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgXmlItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXmlItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXmlItemName,
            this.colXmlItemIPaddr,
            this.colXmlItemIPport});
            this.dgXmlItems.ContextMenuStrip = this.contextMenuXML;
            this.dgXmlItems.Location = new System.Drawing.Point(5, 82);
            this.dgXmlItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgXmlItems.MultiSelect = false;
            this.dgXmlItems.Name = "dgXmlItems";
            this.dgXmlItems.RowHeadersWidth = 24;
            this.dgXmlItems.RowTemplate.Height = 30;
            this.dgXmlItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgXmlItems.Size = new System.Drawing.Size(766, 339);
            this.dgXmlItems.TabIndex = 30;
            this.dgXmlItems.TabStop = false;
            this.dgXmlItems.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgXMLItems_CellMouseDown);
            this.dgXmlItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgXMLItems_DataError);
            // 
            // colXmlItemName
            // 
            this.colXmlItemName.DataPropertyName = "Name";
            this.colXmlItemName.HeaderText = "Name";
            this.colXmlItemName.MinimumWidth = 80;
            this.colXmlItemName.Name = "colXmlItemName";
            // 
            // colXmlItemIPaddr
            // 
            this.colXmlItemIPaddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colXmlItemIPaddr.DataPropertyName = "IPaddr";
            this.colXmlItemIPaddr.HeaderText = "IP address";
            this.colXmlItemIPaddr.MinimumWidth = 50;
            this.colXmlItemIPaddr.Name = "colXmlItemIPaddr";
            // 
            // colXmlItemIPport
            // 
            this.colXmlItemIPport.DataPropertyName = "IPport";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colXmlItemIPport.DefaultCellStyle = dataGridViewCellStyle2;
            this.colXmlItemIPport.HeaderText = "IP port";
            this.colXmlItemIPport.MinimumWidth = 100;
            this.colXmlItemIPport.Name = "colXmlItemIPport";
            this.colXmlItemIPport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXmlItemIPport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuXML
            // 
            this.contextMenuXML.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiEditXml,
            this.cmiDelXml,
            this.toolStripSeparator1,
            this.cmiXmlParse,
            this.cmiXmlSerialize});
            this.contextMenuXML.Name = "contextMenuProd";
            this.contextMenuXML.Size = new System.Drawing.Size(191, 98);
            // 
            // cmiEditXml
            // 
            this.cmiEditXml.Name = "cmiEditXml";
            this.cmiEditXml.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cmiEditXml.Size = new System.Drawing.Size(190, 22);
            this.cmiEditXml.Text = "Edit";
            this.cmiEditXml.Click += new System.EventHandler(this.onEditXml_Click);
            // 
            // cmiDelXml
            // 
            this.cmiDelXml.Name = "cmiDelXml";
            this.cmiDelXml.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmiDelXml.Size = new System.Drawing.Size(190, 22);
            this.cmiDelXml.Text = "Delete";
            this.cmiDelXml.Click += new System.EventHandler(this.onDelXml_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // cmiXmlParse
            // 
            this.cmiXmlParse.Name = "cmiXmlParse";
            this.cmiXmlParse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.cmiXmlParse.Size = new System.Drawing.Size(190, 22);
            this.cmiXmlParse.Text = "Parse from file";
            this.cmiXmlParse.Click += new System.EventHandler(this.onXMLParse_Click);
            // 
            // cmiXmlSerialize
            // 
            this.cmiXmlSerialize.Name = "cmiXmlSerialize";
            this.cmiXmlSerialize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cmiXmlSerialize.Size = new System.Drawing.Size(190, 22);
            this.cmiXmlSerialize.Text = "Serialize to file";
            this.cmiXmlSerialize.Click += new System.EventHandler(this.onXmlSerialize_Click);
            // 
            // tbXmlFile
            // 
            this.tbXmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXmlFile.BackColor = System.Drawing.SystemColors.Window;
            this.tbXmlFile.Location = new System.Drawing.Point(74, 17);
            this.tbXmlFile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbXmlFile.Name = "tbXmlFile";
            this.tbXmlFile.ReadOnly = true;
            this.tbXmlFile.Size = new System.Drawing.Size(669, 20);
            this.tbXmlFile.TabIndex = 1;
            // 
            // btnXmlFileSel
            // 
            this.btnXmlFileSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXmlFileSel.Location = new System.Drawing.Point(743, 16);
            this.btnXmlFileSel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnXmlFileSel.Name = "btnXmlFileSel";
            this.btnXmlFileSel.Size = new System.Drawing.Size(28, 22);
            this.btnXmlFileSel.TabIndex = 2;
            this.btnXmlFileSel.Text = "...";
            this.btnXmlFileSel.UseVisualStyleBackColor = true;
            this.btnXmlFileSel.Click += new System.EventHandler(this.btnXMLSel_Click);
            // 
            // tabLINQ
            // 
            this.tabLINQ.Controls.Add(pnlLINQ);
            this.tabLINQ.Location = new System.Drawing.Point(4, 22);
            this.tabLINQ.Name = "tabLINQ";
            this.tabLINQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabLINQ.Size = new System.Drawing.Size(776, 423);
            this.tabLINQ.TabIndex = 10;
            this.tabLINQ.Text = "LINQ";
            this.tabLINQ.UseVisualStyleBackColor = true;
            // 
            // tabFileIO
            // 
            this.tabFileIO.Controls.Add(label4);
            this.tabFileIO.Controls.Add(this.splitIOWatch);
            this.tabFileIO.Controls.Add(this.gbIOzip);
            this.tabFileIO.Controls.Add(lblIOclass);
            this.tabFileIO.Controls.Add(this.listIO);
            this.tabFileIO.Location = new System.Drawing.Point(4, 22);
            this.tabFileIO.Name = "tabFileIO";
            this.tabFileIO.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileIO.Size = new System.Drawing.Size(776, 423);
            this.tabFileIO.TabIndex = 7;
            this.tabFileIO.Text = "File IO";
            this.tabFileIO.UseVisualStyleBackColor = true;
            // 
            // splitIOWatch
            // 
            this.splitIOWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitIOWatch.Location = new System.Drawing.Point(0, 237);
            this.splitIOWatch.Name = "splitIOWatch";
            // 
            // splitIOWatch.Panel1
            // 
            this.splitIOWatch.Panel1.Controls.Add(this.btnIOfileWatchSel);
            this.splitIOWatch.Panel1.Controls.Add(this.tbIOfileWatchContent);
            this.splitIOWatch.Panel1.Controls.Add(lblIOfileWatchLastWrite);
            this.splitIOWatch.Panel1.Controls.Add(lblIOfileWatchContent);
            this.splitIOWatch.Panel1.Controls.Add(this.tbIOfileWatch);
            this.splitIOWatch.Panel1.Controls.Add(this.dtIOfileWatchModified);
            this.splitIOWatch.Panel1.Controls.Add(lblIOfileWatch);
            this.splitIOWatch.Panel1MinSize = 200;
            // 
            // splitIOWatch.Panel2
            // 
            this.splitIOWatch.Panel2.Controls.Add(lblIOdirWatch);
            this.splitIOWatch.Panel2.Controls.Add(this.dgIOdirWatch);
            this.splitIOWatch.Panel2.Controls.Add(this.btnIOdirWatchSel);
            this.splitIOWatch.Panel2.Controls.Add(this.tbIOdirWatch);
            this.splitIOWatch.Panel2MinSize = 200;
            this.splitIOWatch.Size = new System.Drawing.Size(776, 183);
            this.splitIOWatch.SplitterDistance = 382;
            this.splitIOWatch.TabIndex = 1;
            // 
            // btnIOfileWatchSel
            // 
            this.btnIOfileWatchSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIOfileWatchSel.Location = new System.Drawing.Point(351, 5);
            this.btnIOfileWatchSel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnIOfileWatchSel.Name = "btnIOfileWatchSel";
            this.btnIOfileWatchSel.Size = new System.Drawing.Size(28, 22);
            this.btnIOfileWatchSel.TabIndex = 6;
            this.btnIOfileWatchSel.Text = "...";
            this.btnIOfileWatchSel.UseVisualStyleBackColor = true;
            this.btnIOfileWatchSel.Click += new System.EventHandler(this.btnIOfileWatchSel_Click);
            // 
            // tbIOfileWatchContent
            // 
            this.tbIOfileWatchContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIOfileWatchContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbIOfileWatchContent.Location = new System.Drawing.Point(6, 52);
            this.tbIOfileWatchContent.Multiline = true;
            this.tbIOfileWatchContent.Name = "tbIOfileWatchContent";
            this.tbIOfileWatchContent.ReadOnly = true;
            this.tbIOfileWatchContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIOfileWatchContent.Size = new System.Drawing.Size(373, 128);
            this.tbIOfileWatchContent.TabIndex = 5;
            // 
            // tbIOfileWatch
            // 
            this.tbIOfileWatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIOfileWatch.BackColor = System.Drawing.SystemColors.Window;
            this.tbIOfileWatch.Enabled = false;
            this.tbIOfileWatch.Location = new System.Drawing.Point(87, 6);
            this.tbIOfileWatch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbIOfileWatch.Name = "tbIOfileWatch";
            this.tbIOfileWatch.ReadOnly = true;
            this.tbIOfileWatch.Size = new System.Drawing.Size(264, 20);
            this.tbIOfileWatch.TabIndex = 1;
            this.tbIOfileWatch.Text = "C:\\AUTOEXEC.BAT ";
            // 
            // dtIOfileWatchModified
            // 
            this.dtIOfileWatchModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIOfileWatchModified.CustomFormat = "\"d.M.yyy HH:mm:ss\"";
            this.dtIOfileWatchModified.Enabled = false;
            this.dtIOfileWatchModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIOfileWatchModified.Location = new System.Drawing.Point(228, 29);
            this.dtIOfileWatchModified.Name = "dtIOfileWatchModified";
            this.dtIOfileWatchModified.Size = new System.Drawing.Size(151, 20);
            this.dtIOfileWatchModified.TabIndex = 4;
            // 
            // dgIOdirWatch
            // 
            this.dgIOdirWatch.AllowUserToAddRows = false;
            this.dgIOdirWatch.AllowUserToDeleteRows = false;
            this.dgIOdirWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgIOdirWatch.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgIOdirWatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgIOdirWatch.ColumnHeadersHeight = 30;
            this.dgIOdirWatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEvent,
            this.colTime,
            this.colFileName});
            this.dgIOdirWatch.Location = new System.Drawing.Point(3, 52);
            this.dgIOdirWatch.Name = "dgIOdirWatch";
            this.dgIOdirWatch.ReadOnly = true;
            this.dgIOdirWatch.RowHeadersVisible = false;
            this.dgIOdirWatch.Size = new System.Drawing.Size(384, 128);
            this.dgIOdirWatch.TabIndex = 3;
            // 
            // colEvent
            // 
            this.colEvent.DataPropertyName = "Event";
            this.colEvent.HeaderText = "Event";
            this.colEvent.Name = "colEvent";
            this.colEvent.ReadOnly = true;
            this.colEvent.Width = 80;
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = "- -";
            this.colTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTime.Width = 80;
            // 
            // colFileName
            // 
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "File name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // btnIOdirWatchSel
            // 
            this.btnIOdirWatchSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIOdirWatchSel.Location = new System.Drawing.Point(359, 5);
            this.btnIOdirWatchSel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnIOdirWatchSel.Name = "btnIOdirWatchSel";
            this.btnIOdirWatchSel.Size = new System.Drawing.Size(28, 22);
            this.btnIOdirWatchSel.TabIndex = 2;
            this.btnIOdirWatchSel.Text = "...";
            this.btnIOdirWatchSel.UseVisualStyleBackColor = true;
            this.btnIOdirWatchSel.Click += new System.EventHandler(this.btnIOdirWatchSel_Click);
            // 
            // tbIOdirWatch
            // 
            this.tbIOdirWatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIOdirWatch.Location = new System.Drawing.Point(104, 6);
            this.tbIOdirWatch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tbIOdirWatch.Name = "tbIOdirWatch";
            this.tbIOdirWatch.ReadOnly = true;
            this.tbIOdirWatch.Size = new System.Drawing.Size(255, 20);
            this.tbIOdirWatch.TabIndex = 1;
            // 
            // gbIOzip
            // 
            this.gbIOzip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIOzip.Controls.Add(this.panelIOzip);
            this.gbIOzip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbIOzip.Location = new System.Drawing.Point(0, 152);
            this.gbIOzip.Name = "gbIOzip";
            this.gbIOzip.Size = new System.Drawing.Size(776, 64);
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
            this.panelIOzip.Size = new System.Drawing.Size(757, 36);
            this.panelIOzip.TabIndex = 2;
            // 
            // btnIOzip
            // 
            this.btnIOzip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIOzip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIOzip.Location = new System.Drawing.Point(3, 3);
            this.btnIOzip.Name = "btnIOzip";
            this.btnIOzip.Size = new System.Drawing.Size(372, 30);
            this.btnIOzip.TabIndex = 0;
            this.btnIOzip.Text = "Zip file...";
            this.btnIOzip.UseVisualStyleBackColor = true;
            this.btnIOzip.Click += new System.EventHandler(this.btnIOzip_Click);
            // 
            // btnIOunzip
            // 
            this.btnIOunzip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIOunzip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIOunzip.Location = new System.Drawing.Point(381, 3);
            this.btnIOunzip.Name = "btnIOunzip";
            this.btnIOunzip.Size = new System.Drawing.Size(373, 30);
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
            this.listIO.Size = new System.Drawing.Size(776, 127);
            this.listIO.TabIndex = 1;
            this.listIO.UseCompatibleStateImageBehavior = false;
            this.listIO.View = System.Windows.Forms.View.Details;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.tbServiceStatus);
            this.tabService.Controls.Add(this.tbServiceName);
            this.tabService.Controls.Add(this.tbServiceFile);
            this.tabService.Controls.Add(label2);
            this.tabService.Controls.Add(this.btnServiceStop);
            this.tabService.Controls.Add(this.btnServiceStart);
            this.tabService.Controls.Add(gbServiceAccnt);
            this.tabService.Controls.Add(lblServiceName);
            this.tabService.Controls.Add(this.btnServiceSel);
            this.tabService.Controls.Add(lblServiceFile);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(776, 423);
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
            this.tbServiceStatus.Size = new System.Drawing.Size(494, 86);
            this.tbServiceStatus.TabIndex = 7;
            // 
            // tbServiceName
            // 
            this.tbServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceName.Location = new System.Drawing.Point(80, 50);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(658, 20);
            this.tbServiceName.TabIndex = 4;
            this.tbServiceName.Text = "TestService";
            this.tbServiceName.TextChanged += new System.EventHandler(this.tbServiceName_TextChanged);
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
            this.tbServiceFile.Size = new System.Drawing.Size(658, 20);
            this.tbServiceFile.TabIndex = 1;
            this.tbServiceFile.Text = ".\\WinServiceTest.exe";
            // 
            // btnServiceStop
            // 
            this.btnServiceStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceStop.Location = new System.Drawing.Point(591, 267);
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
            this.btnServiceStart.Location = new System.Drawing.Point(591, 222);
            this.btnServiceStart.Name = "btnServiceStart";
            this.btnServiceStart.Size = new System.Drawing.Size(177, 40);
            this.btnServiceStart.TabIndex = 8;
            this.btnServiceStart.Text = "Start";
            this.btnServiceStart.UseVisualStyleBackColor = true;
            this.btnServiceStart.Click += new System.EventHandler(this.btnServiceAction_Click);
            // 
            // btnServiceSel
            // 
            this.btnServiceSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceSel.Location = new System.Drawing.Point(740, 22);
            this.btnServiceSel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnServiceSel.Name = "btnServiceSel";
            this.btnServiceSel.Size = new System.Drawing.Size(28, 22);
            this.btnServiceSel.TabIndex = 2;
            this.btnServiceSel.Text = "...";
            this.btnServiceSel.UseVisualStyleBackColor = true;
            this.btnServiceSel.Click += new System.EventHandler(this.btnServiceSel_Click);
            // 
            // tabAlg
            // 
            this.tabAlg.Controls.Add(this.groupBox1);
            this.tabAlg.Controls.Add(this.gbAlgCutDiactric);
            this.tabAlg.Controls.Add(gbAlgNum);
            this.tabAlg.Controls.Add(gbWrapText);
            this.tabAlg.Controls.Add(this.gbAlgCID);
            this.tabAlg.Location = new System.Drawing.Point(4, 22);
            this.tabAlg.Name = "tabAlg";
            this.tabAlg.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlg.Size = new System.Drawing.Size(776, 423);
            this.tabAlg.TabIndex = 11;
            this.tabAlg.Text = "Algorithms";
            this.tabAlg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbAlgEmailRegex);
            this.groupBox1.Controls.Add(this.cbAlgEmail);
            this.groupBox1.Controls.Add(this.btnAlgEmailRegexValidate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-mail validation using by RegEx";
            // 
            // tbAlgEmailRegex
            // 
            this.tbAlgEmailRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgEmailRegex.Location = new System.Drawing.Point(12, 19);
            this.tbAlgEmailRegex.Multiline = true;
            this.tbAlgEmailRegex.Name = "tbAlgEmailRegex";
            this.tbAlgEmailRegex.Size = new System.Drawing.Size(462, 70);
            this.tbAlgEmailRegex.TabIndex = 19;
            this.tbAlgEmailRegex.Text = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=" +
    "[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0" +
    "-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
            // 
            // cbAlgEmail
            // 
            this.cbAlgEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlgEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbAlgEmail.FormattingEnabled = true;
            this.cbAlgEmail.Items.AddRange(new object[] {
            "hermann@post.cz",
            "pavel.hermann@post.cz",
            ".hermann@post.cz",
            "@post.cz",
            "603603603@post.cz",
            "603603603@192.168.10.202",
            "cz@.cz",
            "cz@cz.cz",
            "cz@cz.cz.cz.cz.cz"});
            this.cbAlgEmail.Location = new System.Drawing.Point(480, 20);
            this.cbAlgEmail.Name = "cbAlgEmail";
            this.cbAlgEmail.Size = new System.Drawing.Size(175, 69);
            this.cbAlgEmail.TabIndex = 18;
            // 
            // btnAlgEmailRegexValidate
            // 
            this.btnAlgEmailRegexValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgEmailRegexValidate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlgEmailRegexValidate.Location = new System.Drawing.Point(666, 19);
            this.btnAlgEmailRegexValidate.Name = "btnAlgEmailRegexValidate";
            this.btnAlgEmailRegexValidate.Size = new System.Drawing.Size(102, 32);
            this.btnAlgEmailRegexValidate.TabIndex = 17;
            this.btnAlgEmailRegexValidate.Text = "Validate email";
            this.btnAlgEmailRegexValidate.UseVisualStyleBackColor = true;
            this.btnAlgEmailRegexValidate.Click += new System.EventHandler(this.btnAlgValidateEmail_Click);
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
            this.gbAlgCutDiactric.Size = new System.Drawing.Size(776, 71);
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
            this.tbAlgDiactric.Size = new System.Drawing.Size(643, 20);
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
            this.tbAlgDiactricCut.Size = new System.Drawing.Size(643, 20);
            this.tbAlgDiactricCut.TabIndex = 1;
            // 
            // btnAlgCutDiactric
            // 
            this.btnAlgCutDiactric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgCutDiactric.Location = new System.Drawing.Point(661, 18);
            this.btnAlgCutDiactric.Name = "btnAlgCutDiactric";
            this.btnAlgCutDiactric.Size = new System.Drawing.Size(104, 39);
            this.btnAlgCutDiactric.TabIndex = 2;
            this.btnAlgCutDiactric.Text = "Cut diactric";
            this.btnAlgCutDiactric.UseVisualStyleBackColor = true;
            this.btnAlgCutDiactric.Click += new System.EventHandler(this.btnAlgCutDiactric_Click);
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
            this.gbAlgCID.Size = new System.Drawing.Size(776, 101);
            this.gbAlgCID.TabIndex = 3;
            this.gbAlgCID.TabStop = false;
            // 
            // btnAlgCIDValidity
            // 
            this.btnAlgCIDValidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgCIDValidity.Location = new System.Drawing.Point(663, 17);
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
            this.tbAlgCID.Location = new System.Drawing.Point(83, 17);
            this.tbAlgCID.Name = "tbAlgCID";
            this.tbAlgCID.Size = new System.Drawing.Size(87, 20);
            this.tbAlgCID.TabIndex = 1;
            this.tbAlgCID.Text = "69368457";
            // 
            // tbAlgAdZip
            // 
            this.tbAlgAdZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdZip.Location = new System.Drawing.Point(601, 61);
            this.tbAlgAdZip.Name = "tbAlgAdZip";
            this.tbAlgAdZip.ReadOnly = true;
            this.tbAlgAdZip.Size = new System.Drawing.Size(54, 20);
            this.tbAlgAdZip.TabIndex = 11;
            // 
            // btnAlgAres
            // 
            this.btnAlgAres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlgAres.Location = new System.Drawing.Point(663, 49);
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
            this.tbAlgAdCity.Location = new System.Drawing.Point(221, 60);
            this.tbAlgAdCity.Name = "tbAlgAdCity";
            this.tbAlgAdCity.ReadOnly = true;
            this.tbAlgAdCity.Size = new System.Drawing.Size(343, 20);
            this.tbAlgAdCity.TabIndex = 9;
            // 
            // tbAlgAdVAT
            // 
            this.tbAlgAdVAT.Location = new System.Drawing.Point(83, 56);
            this.tbAlgAdVAT.Name = "tbAlgAdVAT";
            this.tbAlgAdVAT.ReadOnly = true;
            this.tbAlgAdVAT.Size = new System.Drawing.Size(87, 20);
            this.tbAlgAdVAT.TabIndex = 3;
            // 
            // tbAlgAdStreet
            // 
            this.tbAlgAdStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdStreet.Location = new System.Drawing.Point(221, 39);
            this.tbAlgAdStreet.Name = "tbAlgAdStreet";
            this.tbAlgAdStreet.ReadOnly = true;
            this.tbAlgAdStreet.Size = new System.Drawing.Size(434, 20);
            this.tbAlgAdStreet.TabIndex = 7;
            // 
            // tbAlgAdName
            // 
            this.tbAlgAdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlgAdName.Location = new System.Drawing.Point(221, 18);
            this.tbAlgAdName.Name = "tbAlgAdName";
            this.tbAlgAdName.ReadOnly = true;
            this.tbAlgAdName.Size = new System.Drawing.Size(434, 20);
            this.tbAlgAdName.TabIndex = 5;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabAlg);
            this.tabs.Controls.Add(this.tabService);
            this.tabs.Controls.Add(this.tabFileIO);
            this.tabs.Controls.Add(this.tabLINQ);
            this.tabs.Controls.Add(this.tabXML);
            this.tabs.Controls.Add(this.tabLang);
            this.tabs.Controls.Add(this.tabUI);
            this.tabs.Controls.Add(this.tabMail);
            this.tabs.Controls.Add(this.tabWeb);
            this.tabs.Controls.Add(this.tabOther);
            this.tabs.Location = new System.Drawing.Point(0, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(784, 449);
            this.tabs.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miApp,
            this.miHlp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(784, 24);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "menuMain";
            // 
            // miApp
            // 
            this.miApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAppExit});
            this.miApp.Name = "miApp";
            this.miApp.Size = new System.Drawing.Size(80, 20);
            this.miApp.Text = "&Application";
            // 
            // miAppExit
            // 
            this.miAppExit.Name = "miAppExit";
            this.miAppExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miAppExit.Size = new System.Drawing.Size(135, 22);
            this.miAppExit.Text = "Exit";
            this.miAppExit.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // miHlp
            // 
            this.miHlp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miHlp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHlpAbout});
            this.miHlp.Name = "miHlp";
            this.miHlp.Size = new System.Drawing.Size(44, 20);
            this.miHlp.Text = "&Help";
            this.miHlp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miHlpAbout
            // 
            this.miHlpAbout.Name = "miHlpAbout";
            this.miHlpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miHlpAbout.Size = new System.Drawing.Size(135, 22);
            this.miHlpAbout.Text = "About...";
            this.miHlpAbout.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.tbComputer);
            this.Controls.Add(lblComputer);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(lblUser);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.chbOnTop);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Test application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            gbOtherProcess.ResumeLayout(false);
            gbOtherProcess.PerformLayout();
            panelOtherProc.ResumeLayout(false);
            gbMailSMTP.ResumeLayout(false);
            gbMailSMTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMailSMPTport)).EndInit();
            panelUI.ResumeLayout(false);
            panelUI.PerformLayout();
            panelUITreeBox.ResumeLayout(false);
            panelUITreeBox.PerformLayout();
            gbLangRefl.ResumeLayout(false);
            gbLangRefl.PerformLayout();
            gbLangDelg.ResumeLayout(false);
            panelLangDelg.ResumeLayout(false);
            pnlLINQ.ResumeLayout(false);
            gbLINQobj.ResumeLayout(false);
            gbLINQobj.PerformLayout();
            gbLINQtoXML.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            gbServiceAccnt.ResumeLayout(false);
            gbServiceAccnt.PerformLayout();
            gbWrapText.ResumeLayout(false);
            gbWrapText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgWrap)).EndInit();
            gbAlgNum.ResumeLayout(false);
            gbAlgNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlgNum)).EndInit();
            this.tabOther.ResumeLayout(false);
            this.tabWeb.ResumeLayout(false);
            this.tabWeb.PerformLayout();
            this.tabMail.ResumeLayout(false);
            this.tabMail.PerformLayout();
            this.tabUI.ResumeLayout(false);
            this.tabLang.ResumeLayout(false);
            this.tbLangSysVar.ResumeLayout(false);
            this.tbLangSysVar.PerformLayout();
            this.tabXML.ResumeLayout(false);
            this.tabXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgXmlItems)).EndInit();
            this.contextMenuXML.ResumeLayout(false);
            this.tabLINQ.ResumeLayout(false);
            this.tabFileIO.ResumeLayout(false);
            this.tabFileIO.PerformLayout();
            this.splitIOWatch.Panel1.ResumeLayout(false);
            this.splitIOWatch.Panel1.PerformLayout();
            this.splitIOWatch.Panel2.ResumeLayout(false);
            this.splitIOWatch.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitIOWatch)).EndInit();
            this.splitIOWatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIOdirWatch)).EndInit();
            this.gbIOzip.ResumeLayout(false);
            this.panelIOzip.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.tabAlg.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAlgCutDiactric.ResumeLayout(false);
            this.gbAlgCutDiactric.PerformLayout();
            this.gbAlgCID.ResumeLayout(false);
            this.gbAlgCID.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox chbOnTop;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbComputer;
        private System.ServiceProcess.ServiceController serviceController;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TextBox tbOtherProcName;
        private System.Windows.Forms.Button btnOtherProcMinimize;
        private System.Windows.Forms.Button btnOtherProcMaximize;
        private System.Windows.Forms.Button btnOtherProcClose;
        private System.Windows.Forms.Button btnOtherProcRestore;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.TextBox tbWWWURL;
        private System.Windows.Forms.TextBox tbWWWContent;
        private System.Windows.Forms.TabPage tabMail;
        private System.Windows.Forms.NumericUpDown nudMailSMPTport;
        private System.Windows.Forms.TextBox tbMailFrom;
        private System.Windows.Forms.TextBox tbMailSMTPpwd;
        private System.Windows.Forms.TextBox tbMailSMTPuser;
        private System.Windows.Forms.TextBox tbMailSMTPserver;
        private System.Windows.Forms.TextBox tbMailBody;
        private System.Windows.Forms.TextBox tbMailSubject;
        private System.Windows.Forms.TextBox tbMailCopy;
        private System.Windows.Forms.TextBox tbMailRcp;
        private System.Windows.Forms.TabPage tabUI;
        private System.Windows.Forms.Button btnUImbox;
        private System.Windows.Forms.ListView listUImbox;
        private System.Windows.Forms.TreeView treeUI;
        private System.Windows.Forms.ListView listUI;
        private System.Windows.Forms.ColumnHeader hdrCol1;
        private System.Windows.Forms.ColumnHeader hdrCol2;
        private System.Windows.Forms.ColumnHeader hdrCol3;
        private System.Windows.Forms.CheckBox chbUITreeBoxEditable;
        private System.Windows.Forms.CheckBox chbUITreeBoxEnabled;
        private XXX.TreeBox tbUI;
        private System.Windows.Forms.TabPage tabLang;
        private System.Windows.Forms.Button btnLangDelgLambda;
        private System.Windows.Forms.Button btnLangDelgAnonymous;
        private System.Windows.Forms.TextBox tbLangReflParam2;
        private System.Windows.Forms.ComboBox cbLangReflParam1;
        private System.Windows.Forms.TextBox tbLangReflResult;
        private System.Windows.Forms.ComboBox cbLangReflType;
        private System.Windows.Forms.TabPage tabXML;
        private System.Windows.Forms.DataGridView dgXmlItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXmlItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXmlItemIPaddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXmlItemIPport;
        private System.Windows.Forms.TextBox tbXmlFile;
        private System.Windows.Forms.Button btnXmlFileSel;
        private System.Windows.Forms.TabPage tabLINQ;
        private System.Windows.Forms.TextBox tbLINQobj;
        private System.Windows.Forms.ListBox listLINQobj;
        private System.Windows.Forms.TextBox tbLINQxml;
        private System.Windows.Forms.RadioButton rbLINQxmlAccnt;
        private System.Windows.Forms.RadioButton rbLINQxmlDeliv;
        private System.Windows.Forms.RadioButton rbLINQxmlAll;
        private System.Windows.Forms.ListView listLINQxml;
        private System.Windows.Forms.TabPage tabFileIO;
        private System.Windows.Forms.SplitContainer splitIOWatch;
        private System.Windows.Forms.Button btnIOfileWatchSel;
        private System.Windows.Forms.TextBox tbIOfileWatchContent;
        private System.Windows.Forms.TextBox tbIOfileWatch;
        private System.Windows.Forms.DateTimePicker dtIOfileWatchModified;
        private System.Windows.Forms.DataGridView dgIOdirWatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.Button btnIOdirWatchSel;
        private System.Windows.Forms.TextBox tbIOdirWatch;
        private System.Windows.Forms.GroupBox gbIOzip;
        private System.Windows.Forms.TableLayoutPanel panelIOzip;
        private System.Windows.Forms.Button btnIOzip;
        private System.Windows.Forms.Button btnIOunzip;
        private System.Windows.Forms.ListView listIO;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TextBox tbServiceStatus;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbServiceFile;
        private System.Windows.Forms.Button btnServiceStop;
        private System.Windows.Forms.Button btnServiceStart;
        private System.Windows.Forms.TextBox tbServiceUser;
        private System.Windows.Forms.ComboBox cbServiceAccount;
        private System.Windows.Forms.TextBox tbServicePwd;
        private System.Windows.Forms.Button btnServiceUninstall;
        private System.Windows.Forms.Button btnServiceInstall;
        private System.Windows.Forms.Button btnServiceSel;
        private System.Windows.Forms.TabPage tabAlg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAlgEmailRegex;
        private System.Windows.Forms.ComboBox cbAlgEmail;
        private System.Windows.Forms.Button btnAlgEmailRegexValidate;
        private System.Windows.Forms.GroupBox gbAlgCutDiactric;
        private System.Windows.Forms.TextBox tbAlgDiactric;
        private System.Windows.Forms.TextBox tbAlgDiactricCut;
        private System.Windows.Forms.Button btnAlgCutDiactric;
        private System.Windows.Forms.Button btnAlgNumToText;
        private System.Windows.Forms.NumericUpDown nudAlgNum;
        private System.Windows.Forms.TextBox tbAlgNumText;
        private System.Windows.Forms.NumericUpDown nudAlgWrap;
        private System.Windows.Forms.TextBox tbAlgWrap;
        private System.Windows.Forms.TextBox tbAlgWrapText;
        private System.Windows.Forms.Button btnAlgWrapText;
        private System.Windows.Forms.GroupBox gbAlgCID;
        private System.Windows.Forms.Button btnAlgCIDValidity;
        private System.Windows.Forms.TextBox tbAlgCID;
        private System.Windows.Forms.TextBox tbAlgAdZip;
        private System.Windows.Forms.Button btnAlgAres;
        private System.Windows.Forms.TextBox tbAlgAdCity;
        private System.Windows.Forms.TextBox tbAlgAdVAT;
        private System.Windows.Forms.TextBox tbAlgAdStreet;
        private System.Windows.Forms.TextBox tbAlgAdName;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miApp;
        private System.Windows.Forms.ToolStripMenuItem miAppExit;
        private System.Windows.Forms.ToolStripMenuItem miHlp;
        private System.Windows.Forms.ToolStripMenuItem miHlpAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuXML;
        private System.Windows.Forms.ToolStripMenuItem cmiEditXml;
        private System.Windows.Forms.ToolStripMenuItem cmiDelXml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmiXmlParse;
        private System.Windows.Forms.ToolStripMenuItem cmiXmlSerialize;
        private System.Windows.Forms.CheckBox chbMailSMTPSecure;
        private System.Windows.Forms.GroupBox tbLangSysVar;
        private System.Windows.Forms.TextBox tbLangAppProdVer;
        private System.Windows.Forms.TextBox tbLangAppProdName;
        private System.Windows.Forms.TextBox tbLangAppPathExe;
        private System.Windows.Forms.TextBox tbLangAppPathStartup;
    }    
}

