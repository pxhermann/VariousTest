using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XXX
{
    public partial class TreeBox : UserControl
    {
        public const string ITEM_SEP = "->";
        private ToolStripControlHost treeViewHost = null;
        private ToolStripDropDown dropDown = null;
        private DateTime lastDropDownClose = DateTime.Now; // helper variable to block dropDown immediatelly after closing, see. ToogleDropDown

        public TreeBox()
        {
            InitializeComponent();

            Tree.BorderStyle = BorderStyle.None;
            Tree.HideSelection = false;
            Tree.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            treeViewHost = new ToolStripControlHost(Tree);

        // create drop down and add it
            dropDown = new ToolStripDropDown();
            dropDown.Items.Add(treeViewHost);
            dropDown.AutoClose = true;  // close drop down after pressing Esc or losing focus
            dropDown.Closed += delegate(object sender, ToolStripDropDownClosedEventArgs e) { lastDropDownClose = DateTime.Now; System.Diagnostics.Trace.WriteLine("TreeBox: dropDown closed"); };

            GotFocus  += new EventHandler(TreeBox_StateChanged);
            LostFocus += new EventHandler(TreeBox_StateChanged);
            EnabledChanged += new EventHandler(TreeBox_StateChanged);
        }

#region properties
        [Description("Text shown in text box")]
        public string TextValue
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        private int dropDownHeight = 100;
        [Description("The height, in pixels, of the drop-down tree view")]
        public int DropDownHeight
        {
            get { return dropDownHeight; }
            set { dropDownHeight = value; }
        }
#endregion

#region design related methods
        // do not allow to increase height - similarly as ComboBox
        private void TreeBox_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(Size.Width, panelTop.Height);
        }
        void TreeBox_StateChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("TreeBox: "+(Focused?"focused":"not focused")+(Enabled?"enabled":"not enabled"));

            if ( Enabled )
            {
                lblText.BackColor = Focused ? SystemColors.Highlight : SystemColors.Window;
                lblText.ForeColor = Focused ? SystemColors.HighlightText : SystemColors.WindowText;
            }
            else
            {
                lblText.BackColor = SystemColors.Control;
                lblText.ForeColor = SystemColors.ControlDark;
            }
        }
        private void lblText_Paint(object sender, PaintEventArgs e)
        {
            if (Focused)
            {
                Rectangle r = lblText.ClientRectangle;
                r.Width -= 1;
                r.Height -= 1;
                e.Graphics.DrawRectangle(SystemPens.Window, r);
                r.Inflate(-1, -1);
                e.Graphics.DrawRectangle(SystemPens.Window, r);
                r.Width += 1;
                r.Height += 1;
                ControlPaint.DrawFocusRectangle(e.Graphics, r);
            }
        }
        private void lblBtn_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawComboButton(e.Graphics, lblBtn.ClientRectangle, Enabled?ButtonState.Normal:ButtonState.Inactive);
//            ButtonRenderer.DrawButton(e.Graphics, lblBtn.ClientRectangle, lblBtn.Text, lblBtn.Font, false, System.Windows.Forms.VisualStyles.PushButtonState.Hot);
        }
#endregion
        
#region behaviour related methods
        private void panelTop_Click(object sender, EventArgs e)
        {
            Focus();
            ToogleDropDown();
        }
        private void tree_KeyDown(object sender, KeyEventArgs e)
        {
            switch (  e.KeyData )
            {
            case Keys.F4:
                System.Diagnostics.Trace.WriteLine("TreeBox: KeyDown F4");
                dropDown.Close();
                e.Handled = true;
                break;
            case Keys.Enter:
                System.Diagnostics.Trace.WriteLine("TreeBox: KeyDown enter");
                if ( dropDown != null && dropDown.Visible && Tree.SelectedNode != null )
                {
                    if( Tree.SelectedNode.Nodes.Count > 0 )     
                        Tree.SelectedNode.Toggle();
                    else
                        SelectAndClose(Tree.SelectedNode);
                    e.Handled = true;
                }
                break;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ( keyData == Keys.F4 )
            {
                System.Diagnostics.Trace.WriteLine("TreeBox: ProcessCmdKey F4");
                ToogleDropDown();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectAndClose(e.Node);
        }
#endregion

#region helper methods		        
        private void SelectAndClose(TreeNode selNode)
        {
            if ( selNode != null && (selNode.Nodes == null || selNode.Nodes.Count == 0) )
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(selNode.Text); 
                for ( TreeNode tn = selNode.Parent; tn != null; tn = tn.Parent )
                    sb.Insert(0, tn.Text+ITEM_SEP);

                TextValue = sb.ToString();

                dropDown.Close();
                Focus();
            }
        }
        private void ToogleDropDown()
        {
            if ( dropDown != null && dropDown.Visible )
            {
                System.Diagnostics.Trace.WriteLine("TreeBox: ToggleDropDown: close");
                dropDown.Close();
            }
            else if ( (DateTime.Now-lastDropDownClose).TotalMilliseconds > 250 )
            {
                System.Diagnostics.Trace.WriteLine("TreeBox: ToggleDropDown: show");
                treeViewHost.Width = Tree.Width = this.Width;
                treeViewHost.Height = Tree.Height = dropDownHeight; 

                if ( !string.IsNullOrEmpty(TextValue) )
                {
                    Tree.BeginUpdate();
                    try
                    {
                        TreeNodeCollection list = Tree.Nodes; 
                        foreach(string s in TextValue.Split(new string[] {ITEM_SEP}, StringSplitOptions.RemoveEmptyEntries))
                            foreach(TreeNode tn in list)
                                if ( tn.Text == s )
                                {
                                    list = tn.Nodes;
                                    Tree.SelectedNode = tn;
                                    break;
                                }
                        if ( Tree.SelectedNode != null )
                            Tree.SelectedNode.EnsureVisible();
                    }
                    finally
                    {
                        Tree.EndUpdate();
                    }
                }

                dropDown.Show(this, 0, panelTop.Bottom + 1);
                Tree.Focus();
            }
            else
                System.Diagnostics.Trace.WriteLine(string.Format("TreeBox: ToggleDropDown: milliseconds from last drop close: {0}", (DateTime.Now-lastDropDownClose).TotalMilliseconds));
        }
#endregion    
    }
}
