namespace XXX
{
    partial class TreeBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBtn = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.Tree = new System.Windows.Forms.TreeView();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.lblBtn);
            this.panelTop.Controls.Add(this.lblText);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(254, 21);
            this.panelTop.TabIndex = 0;
            this.panelTop.Click += new System.EventHandler(this.panelTop_Click);
            // 
            // lblBtn
            // 
            this.lblBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lblBtn.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblBtn.Location = new System.Drawing.Point(234, 0);
            this.lblBtn.Name = "lblBtn";
            this.lblBtn.Size = new System.Drawing.Size(16, 17);
            this.lblBtn.TabIndex = 1;
            this.lblBtn.Text = "q";
            this.lblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.lblBtn_Paint);
            this.lblBtn.Click += new System.EventHandler(this.panelTop_Click);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.BackColor = System.Drawing.SystemColors.Window;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(234, 17);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Paint += new System.Windows.Forms.PaintEventHandler(this.lblText_Paint);
            this.lblText.Click += new System.EventHandler(this.panelTop_Click);
            // 
            // Tree
            // 
            this.Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tree.HideSelection = false;
            this.Tree.Location = new System.Drawing.Point(3, 23);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(248, 67);
            this.Tree.TabIndex = 1;
            this.Tree.Visible = false;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            this.Tree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
            // 
            // TreeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.panelTop);
            this.Name = "TreeBox";
            this.Size = new System.Drawing.Size(254, 93);
            this.SizeChanged += new System.EventHandler(this.TreeBox_SizeChanged);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblBtn;
        public System.Windows.Forms.TreeView Tree;
    }
}
