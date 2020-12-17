using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Win32Mapi;
using System.Net;
using System.Xml.Linq;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using ICSharpCode.SharpZipLib.Zip;
using System.Net.Mail;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Management;
using System.Text.RegularExpressions;

namespace VariousTest
{
	public partial class FormMain : Form
	{
        private AppSetting appCfg;

        public FormMain()
		{
			InitializeComponent();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
            initTabAlgoritms();
            initTabLang();
            initTabIO();
            initTabXML();
            initTabLINQ();
            initTabUI();
            initTabOther();
            initTabService();

            tbComputer.Text = Environment.MachineName;
            tbUser.Text = Environment.UserName; //= System.Environment.GetEnvironmentVariable("USERNAME");
                                                //          tbUser.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();   // computername/username
            try 
            {
                appCfg = AppSetting.Load();

                // restore window position
                if (appCfg.WindowPosition != Rectangle.Empty)
                {
                    DesktopBounds = appCfg.WindowPosition;
                    if (appCfg.WindowState == FormWindowState.Maximized)
                        WindowState = FormWindowState.Maximized;
                    else
                        WindowState = FormWindowState.Normal;
                }

                if ( chbOnTop.Checked == appCfg.AlwaysOnTop )
                    chbOnTop_CheckedChanged(null, null);
                else
                    chbOnTop.Checked = appCfg.AlwaysOnTop;  // envoke chbOnTop_CheckedChanged automatically
            }
            catch (Exception ex) { GM.ShowErrorMessageBox(this, "Applying application setting failed!", ex); }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            { 
                bsXmlItems.EndEdit();
                dgXmlItems.EndEdit();

                // save window position
                if ( appCfg == null )
                    appCfg = new AppSetting();

                appCfg.WindowPosition = (WindowState == FormWindowState.Normal) ? DesktopBounds : RestoreBounds;
                appCfg.WindowState = WindowState;
                appCfg.AlwaysOnTop = chbOnTop.Checked;
                appCfg.Save();
            }
            catch {}
        }
    
        private void chbOnTop_CheckedChanged(object sender, EventArgs e)
        {
 			TopMost = chbOnTop.Checked;
        }

#region useful algoritms
        private void initTabAlgoritms()
        {
            btnAlgCutDiactric_Click(null, null);
            btnAlgNumToText_Click(null, null);
            btnAlgWrapText_Click(null, null);

//            tbAlgEmailRegex.Text = (?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\]);
        }

        private void btnAlgCutDiactric_Click(object sender, EventArgs e)
        {
            tbAlgDiactricCut.Text = GM.CutDiactric(tbAlgDiactric.Text);
        }
        private void btnAlgNumToText_Click(object sender, EventArgs e)
        {
            tbAlgNumText.Text = GM.NumberToText((int)nudAlgNum.Value);
        }
        private void btnAlgWrapText_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (string sLine in GM.WrapText(tbAlgWrap.Text, (int)nudAlgWrap.Value))
            {
                if (!string.IsNullOrEmpty(s))
                    s += Environment.NewLine;
                s += sLine;
            }
            tbAlgWrapText.Text = s;
        }
        private void btnAlgCIDValidity_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(tbAlgCID.Text) )
            {
                GM.ShowErrorMessageBox(this, "Enter CID first!");
                tbAlgCID.Focus();
                return;
            }
            if ( GM.CheckCID(tbAlgCID.Text) )
                GM.ShowInfoMessageBox(this, string.Format("'{0}' complies Company ID validation algorithm!", tbAlgCID.Text));
            else
                GM.ShowErrorMessageBox(this, string.Format("'{0}' doesn't comply Company ID validation algorithm!", tbAlgCID.Text));
        }
        private void btnAlgAres_Click(object sender, EventArgs e)
        {
            tbAlgAdName.Text = tbAlgAdCity.Text = tbAlgAdStreet.Text = tbAlgAdZip.Text = tbAlgAdVAT.Text = "";

        // check ICO
            if ( string.IsNullOrEmpty(tbAlgCID.Text) )
            {
                GM.ShowErrorMessageBox(this, "Enter Company ID first!");
                tbAlgCID.Focus();
                return;
            }
            if ( !GM.CheckCID(tbAlgCID.Text) && GM.ShowQuestionMessageBox(this, string.Format("'{0}' doesn't comply Company ID validation algorithm. Continue anyway?", tbAlgCID.Text)) != DialogResult.Yes )
            {
                tbAlgCID.Select(0, tbAlgCID.Text.Length);
                tbAlgCID.Focus();
                return;
            }

        // get address from ARES
            string strUrl = string.Format("http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_std.cgi?ico={0}&aktivni=false", tbAlgCID.Text);

            Cursor = Cursors.WaitCursor;
            try
            {
                string s;
                using ( WebClient webCli = new WebClient() )
                    using ( StreamReader r = new StreamReader(webCli.OpenRead(strUrl)))
                        s = r.ReadToEnd();

                XNamespace are = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer/v_1.0.1";
                XNamespace dtt = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4";

                XElement elRoot = XElement.Parse(s);
                XElement elAddr = GetXElement(elRoot, new XName[] {are + "Odpoved", are + "Zaznam"});
                if ( elAddr == null )
                {
                    GM.ShowErrorMessageBox(this, string.Format("No address found in ARES for CID: {0}", tbAlgCID.Text));
                    return;
                }

                // name
                tbAlgAdName.Text = GetXElementValue(elAddr, are + "Obchodni_firma");
                //** address
                elAddr = GetXElement(elAddr, new XName[] {are + "Identifikace", are + "Adresa_ARES"});
                if ( elAddr != null )
                {
                    string strObec = GetXElementValue(elAddr, dtt+"Nazev_obce");
                 // city
                    s = GetXElementValue(elAddr, dtt+"Nazev_mestske_casti");
                    tbAlgAdCity.Text = (s.Length>0)?s:strObec;
                 // street
                    s = GetXElementValue(elAddr, dtt+"Nazev_ulice");
                    tbAlgAdStreet.Text  = (s.Length>0)?s:strObec;
                    //
                    s = GetXElementValue(elAddr, dtt+"Cislo_domovni");
                    if ( s.Length > 0 ) 
                        tbAlgAdStreet.Text += " "+s;
                    s = GetXElementValue(elAddr, dtt+"Cislo_orientacni");
                    if ( s.Length > 0 ) 
                        tbAlgAdStreet.Text += "/"+s;
                 // ZIP
                    tbAlgAdZip.Text = GetXElementValue(elAddr, dtt+"PSC");
                }
                //**DIC
                s = GetXElementValue(elRoot, new XName[] {are+"Odpoved", are+"Zaznam", are+"Priznaky_subjektu"});
                if ( s != null && s.Length > 5 && (s[5] == 'A' || s[5] == 'a') )
                {
                    strUrl = string.Format("http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_bas.cgi?ico={0}&aktivni=false", tbAlgCID.Text);
                    using ( WebClient webCli = new WebClient() )
                        using ( StreamReader r = new StreamReader(webCli.OpenRead(strUrl)))
                            s = r.ReadToEnd();

                    elRoot = XElement.Parse(s);
                    are = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_basic/v_1.0.3";
                    dtt = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3";

                    tbAlgAdVAT.Text = GetXElementValue(elRoot, new XName[] {are+"Odpoved", dtt+"VBAS", dtt+"DIC"});
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, string.Format("Error occured when reading ARES data from '{0}'", strUrl), ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnAlgValidateEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Regex emailRegex = new Regex(tbAlgEmailRegex.Text);
                if (emailRegex.IsMatch(cbAlgEmail.Text))
                    GM.ShowInfoMessageBox(this, string.Format("'{0}' is valid e-mail address", cbAlgEmail.Text));
                else
                {
                    string s = cbAlgEmail.Text;
                    int idx = s.IndexOf('@');
                    if (idx >= 0)
                        try
                        {
                            s = s.Substring(idx + 1);
                            if (IPAddress.TryParse(s, out IPAddress ip) || Dns.GetHostAddresses(s) != null)
                            {
                                GM.ShowErrorMessageBox(this, string.Format("'{0}' is not valid e-mail address for domain: '{1}'", cbAlgEmail.Text, s));
                                return;
                            }
                        }
                        catch { }

                    GM.ShowErrorMessageBox(this, string.Format("'{0}' is not valid e-mail address", cbAlgEmail.Text));
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, string.Format("Error occured when validating '{0}'", cbAlgEmail.Text), ex);
            }
        }

        private XElement GetXElement(XElement parent, params XName[] path)
        {
            XElement elHlp = parent;
            foreach (XName name in path)
            {
                if (elHlp == null)
                    break;
                elHlp = elHlp.Element(name);
            }
            return elHlp;
        }
        private string GetXElementValue(XElement parent, params XName[] path)
        {
            XElement elHlp = GetXElement(parent, path);

            return (elHlp==null)?"":elHlp.Value;
        }
#endregion

#region C# language features
        delegate void DelegateFce();

        Stack<DelegateFce> arrDelgFce = new Stack<DelegateFce>();

        void initTabLang()
        {
        // delegates
            arrDelgFce.Push(delegate() {GM.ShowInfoMessageBox(this, "Delegate 1");});   // anonymous delegate
            arrDelgFce.Push(delegate() {GM.ShowInfoMessageBox(this, "Delegate 2");});
            arrDelgFce.Push(DelgFce3);

            btnLangDelgAnonymous.Click += delegate(object sender, EventArgs e)
			{
				GM.ShowInfoMessageBox(this, "Hallo from anonymous delegate.");
			};

            btnLangDelgLambda.Click += ((sender,e) => GM.ShowInfoMessageBox(this, "Hallo from lambda expression.") );

       // fill data for reflection
            cbLangReflParam1.Items.Add("{0}");
            cbLangReflParam1.Items.Add("{0:0.0}");
            cbLangReflParam1.Items.Add("{0:#.#}");
            cbLangReflParam1.Items.Add("{0:0.#####}");
            cbLangReflParam1.Items.Add("{0:#.#####}");
            cbLangReflParam1.Items.Add("{0:0.00000}");
            cbLangReflParam1.Items.Add("Left7: '{0, -7}' | Right7: '{0, 7}'");
            cbLangReflParam1.Items.Add("Left7: '{0, -7:000}' | Right7: '{0, 7:000}'");
            cbLangReflParam1.Items.Add("IntLeft7: '{0, -7:D3}' | IntRight7: '{0, 7:D3}'");
            cbLangReflParam1.SelectedIndex = 0;

            tbLangReflParam2.Text = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator+"12";

            cbLangReflType.Items.Add("decimal");
            cbLangReflType.Items.Add("int");
            cbLangReflType.Items.Add("string");
            cbLangReflType.SelectedIndex = 0;

            // set handlers till here, so that they are not invoked when putting data to controls
            cbLangReflParam1.TextChanged += cbLangReflData_Changed;
            tbLangReflParam2.TextChanged += cbLangReflData_Changed;
            cbLangReflType.SelectedIndexChanged += cbLangReflData_Changed;

            cbLangReflData_Changed(null, null);

        }
    #region delegates
        void DelgFce3()
        {
            GM.ShowInfoMessageBox(this, "Delegate 3");
        }
        // !!! delegate's BeginInvoke create some resources, so it is recommended to use also EndInvoke, see. in EndDelgTest 
        private void btnLangDelgTest_Click(object sender, EventArgs e)
        {
            if (arrDelgFce.Count > 0)
            {
                DelegateFce f = (DelegateFce)(arrDelgFce.Peek());
                f.BeginInvoke(EndDelgTest, f);
            }
        }
        void EndDelgTest(IAsyncResult ar)
        {
            try
            {
                DelegateFce f = (DelegateFce)ar.AsyncState;
                f.EndInvoke(ar);    // !!! calling of EndInvoke is not necessary, but it is recommended to free resources immediatelly 
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured during EndInvoke!", ex);
            }
            GM.ShowInfoMessageBox(this, "End invoke of the delegate");
        }
        // !!! in contrast to delegate's BeginInvoke, Control.BeginInvoke doesn't create resources (just passes processing to UI thread) 
        // and there is no corresponding EndInvoke - end of delegate can obtained by checking return value IAsyncResult
        private void btnLangDelgGUItest_Click(object sender, EventArgs e)
        {
            if (arrDelgFce.Count > 0)
            {
                DelegateFce f = (DelegateFce)(arrDelgFce.Peek());
                BeginInvoke(f);
            }
        } 
    #endregion

        private void cbLangReflData_Changed(object sender, EventArgs e)
        {
            tbLangReflResult.Text = "";

            MethodInfo mi = null;
            try
            {
                Type t = typeof(string);
                mi = t.GetMethod("Format", new Type[] { typeof(string), typeof(object)} );
                if ( mi == null )
                {
                    GM.ShowErrorMessageBox(this, "Method 'string.Format' not found by reflection!");
                    return;
                }
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Loading method 'string.Format' by reflection failed!", ex);
            }

            try
            {
                switch ( cbLangReflType.Text )
                {
                case "decimal": 
                    decimal d;
                    if ( !decimal.TryParse(tbLangReflParam2.Text, out d) )
                    {
                        GM.ShowErrorMessageBox(this, "Enter decimal value!");
                        tbLangReflParam2.Focus();
                        return;
                    }
                    tbLangReflResult.Text = mi.Invoke(null, new object[] {cbLangReflParam1.Text, d}).ToString();
                    break;
                case "int": 
                    int i;
                    if ( !int.TryParse(tbLangReflParam2.Text, out i) )
                    {
                        GM.ShowErrorMessageBox(this, "Enter int value!");
                        tbLangReflParam2.Focus();
                        return;
                    }
                    tbLangReflResult.Text = mi.Invoke(null, new object[] {cbLangReflParam1.Text, i}).ToString();
                    break;
                default:
                    tbLangReflResult.Text = mi.Invoke(null, new object[] {cbLangReflParam1.Text, tbLangReflParam2.Text}).ToString();
                    break;
                }
            }
            catch(Exception ex)
            {
                tbLangReflResult.Text = "Error: " + ((ex.InnerException==null)?ex.Message:ex.InnerException.Message);

/*                string param2 = tbLangReflParam2.Text;
                switch ( cbLangReflType.Text )
                {
                case "decimal": decimal d; if ( decimal.TryParse(param2, out d) ) param2 = d.ToString(System.Globalization.CultureInfo.InvariantCulture); break;
                case "string":  param2  = '\"'+param2+'\"'; break;
                }
                GM.ReportError(this, ex, string.Format("Error occured when invoking method{0} string.Format(\"{1}\", {2})", Environment.NewLine, cbLangReflParam1.Text, param2));
*/            }
        }

    #region access to private members
		class TestClass
        {
            public TestClass()
            {
                Description = "Bbase class";
            }

            // property with diffrent access modifier for set and get
            string description;
            public String Description
            { 
                private set { description = value; } 
                get { return description; }
            }
            // usage of internal class
            public class InternalClass
            {
                public void SetDescr(TestClass c, string descr)
                {
                    c.Description = descr;
                }
            }
        }
        class DerivedTestClass : TestClass
        {
            public DerivedTestClass()
            {
                InternalClass c = new InternalClass();
                c.SetDescr(this, "Derived class");
            }
        }
		private void btnLangProp_Click(object sender, EventArgs e)
        {
            TestClass c = new DerivedTestClass();

            string s = c.Description;
            // c.Description = "xxx"; cannot be used, because set accessor hase private modifier
            TestClass.InternalClass ic = new TestClass.InternalClass();
            ic.SetDescr(c, "xxx");
        }
    #endregion		

        private void btnLangException_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					throw new Exception("Inner exception message");
				}
				catch (Exception ex)
				{
                    GM.ShowErrorMessageBox(this, "CATCH OF INNER BLOCK", ex);
					throw new Exception("Rethrow from inner catch", ex);
				}
				finally
				{
                    GM.ShowErrorMessageBox(this, "FINALLY OF INNER BLOCK");
				}
			}
			catch(Exception ex)
			{
                GM.ShowErrorMessageBox(this, "CATCH OF OUTER BLOCK", ex);
			}
		}


#endregion

#region IO, file system usage
        delegate void DelgUpdateFile();

		private FileSystemWatcher fileWatcher = new FileSystemWatcher();

        private void initTabIO()
        {
    #region Path & Directory classes
            listIO.Columns.Add("Name", 100);
            listIO.Columns.Add("Value", -1);

            ListViewGroup lvg;
            StringBuilder sb = new StringBuilder(100);
        // directory
            lvg = new ListViewGroup("Directory class");
            listIO.Groups.Add(lvg);
            ////
            listIO.Items.Add(new ListViewItem(new string[] {"GetCurrentDirectory", Directory.GetCurrentDirectory()}, lvg));
            ////
            sb.Length = 0;
            foreach (string drive in Directory.GetLogicalDrives())
            {
                if (sb.Length > 0)
                    sb.Append("  ");
                sb.Append(drive);
            }
            listIO.Items.Add(new ListViewItem(new string[] {"GetLogicalDrives", sb.ToString()}, lvg));
        // path
            lvg = new ListViewGroup("Path class");
            listIO.Groups.Add(lvg);
            ////
            sb.Length = 0;
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (sb.Length > 0)
                    sb.Append("  ");
                sb.Append(c);
            }
            listIO.Items.Add(new ListViewItem(new string[] {"GetInvalidFileNameChars", sb.ToString()}, lvg));
            ////
            sb.Length = 0;
            foreach (char c in Path.GetInvalidPathChars())
            {
                if (sb.Length > 0)
                    sb.Append("  ");
                sb.Append(c);
            }
            listIO.Items.Add(new ListViewItem(new string[] {"GetInvalidPathChars", sb.ToString()}, lvg));
            ////
            listIO.Items.Add(new ListViewItem(new string[] {"VolumeSeparatorChar", Path.VolumeSeparatorChar.ToString()}, lvg));
            listIO.Items.Add(new ListViewItem(new string[] {"DirectorySeparatorChar", Path.DirectorySeparatorChar.ToString()}, lvg));
            listIO.Items.Add(new ListViewItem(new string[] {"AltDirectorySeparatorChar", Path.AltDirectorySeparatorChar.ToString()}, lvg));
            listIO.Items.Add(new ListViewItem(new string[] {"GetTempPath", Path.GetTempPath()}, lvg));
            listIO.Items.Add(new ListViewItem(new string[] {"GetTempFileName", Path.GetTempFileName()}, lvg));
            listIO.Items.Add(new ListViewItem(new string[] {"GetRandomFileName", Path.GetRandomFileName()}, lvg));

        /////
            listIO.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listIO.Columns[0].Width += 10;
            listIO.Columns[1].Width = -1;
    #endregion        

        // file watcher initialization
		    fileWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.FileName;
		    fileWatcher.Changed += new FileSystemEventHandler(fileWatch_Changed);

		    WatchedFileChanged(false);
        }

    #region zipping 
        private void btnIOzip_Click(object sender, EventArgs e)
        {
            string inFile = "";
            string outFile = "";
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select file to zip...";
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                inFile = dlg.FileName;
            }
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select target directory...";
                try { dlg.SelectedPath = Path.GetDirectoryName(inFile); } catch {}
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                outFile = Path.Combine(dlg.SelectedPath, Path.GetFileNameWithoutExtension(inFile) + ".zip");
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                // read input file
                byte[] data = File.ReadAllBytes(inFile);

                // create output file
                using (ZipOutputStream oZipStream = new ZipOutputStream(File.Create(outFile))) // create zip stream
                {
                    //oZipStream.SetLevel(9); // maximum compression

                    // create entry
                    /*                    // simple solution
                                        oZipStream.PutNextEntry(new ZipEntry(Path.GetFileNameWithoutExtension(inFile)));
                    */
                    // more complex, but better solution - set Size and the crc
                    // the information about the size and crc should be stored in the header, if it is not set it is automatically written in the footer. (in this case size == crc == -1 in the header)
                    // !!! Some ZIP programs have problems with zip files that don't store the size and crc in the header and may fail when decommpressing thus file.
                    ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new ICSharpCode.SharpZipLib.Checksums.Crc32();
                    crc.Reset();
                    crc.Update(data);
                    ZipEntry entry = new ZipEntry(Path.GetFileName(inFile));
                    entry.DateTime = DateTime.Now;
                    entry.Size = data.Length;
                    entry.Crc = crc.Value;

                    oZipStream.PutNextEntry(entry);

                    // write data
                    oZipStream.Write(data, 0, data.Length);
                    oZipStream.Finish();
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured when zipping file", ex);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            GM.ShowInfoMessageBox(this, string.Format("'{1}'{0}{0}successfully zipped to{0}{0}'{2}'", Environment.NewLine, inFile, outFile));
        }
        private void btnIOunzip_Click(object sender, EventArgs e)
        {
            string inFile = "";
            string outDir = "";
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select file to unzip...";
                dlg.Filter = "ZIP files (*.zip)|*.zip|All files (*.*) |*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                inFile = dlg.FileName;
            }
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select target directory...";
                try { dlg.SelectedPath = Path.GetDirectoryName(inFile); }
                catch { }
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                outDir = dlg.SelectedPath;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                // read input file
                byte[] data;
                string s;

                using (ZipInputStream iZipStream = new ZipInputStream(File.Open(inFile, FileMode.Open)))
                {
                    ZipEntry entry;
                    while ((entry = iZipStream.GetNextEntry()) != null)
                    {
                        if (entry.IsDirectory)
                        {
                            s = Path.Combine(outDir, entry.Name);
                            if (!Directory.Exists(s))
                                Directory.CreateDirectory(s);
                        }
                        else if (entry.IsFile)
                        {
                            data = new byte[entry.Size];
                            iZipStream.Read(data, (int)entry.Offset, (int)entry.Size);
                            s = Path.Combine(outDir, entry.Name);
                            if (!File.Exists(s))
                                File.WriteAllBytes(s, data);
                            else
                            {
                                if ( GM.ShowQuestionMessageBox(this, string.Format("File '{1}' already exists.{0}{0}Overwite?", Environment.NewLine, s)) != DialogResult.Yes )
                                    return;
                                File.WriteAllBytes(s, data);
                            }
                        }
                        iZipStream.CloseEntry();
                    }
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured when unzipping file", ex);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            GM.ShowInfoMessageBox(this, string.Format("'{1}'{0}{0}successfully unzipped to directory {0}{0}'{2}'", Environment.NewLine, inFile, outDir));
        }
    #endregion
    #region file watcher
        private void btnIOfileWatchSel_Click(object sender, EventArgs e)
        {
            using ( OpenFileDialog dlg = new OpenFileDialog() )
            {
                try { dlg.InitialDirectory = Path.GetDirectoryName(tbIOfile.Text); }
                catch { }
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                tbIOfile.Text = dlg.FileName;
            }

            WatchedFileChanged(true);
        }
        private void fileWatch_Changed(object sender, FileSystemEventArgs e)
        {
            UpdateWatchedFile();
        }
        private void WatchedFileChanged(bool bReport)
        {
            fileWatcher.EnableRaisingEvents = false;
            tbIOfileContent.Text = "";
            if (!File.Exists(tbIOfile.Text))
            {
                if (bReport)
                    GM.ShowErrorMessageBox(this, "File '" + tbIOfile.Text + "' doesn't exists");
                return;
            }

            fileWatcher.Path = Path.GetDirectoryName(tbIOfile.Text.Trim());
            fileWatcher.Filter = Path.GetFileName(tbIOfile.Text.Trim());
            fileWatcher.EnableRaisingEvents = true;

            UpdateWatchedFile();
        }
        private void UpdateWatchedFile()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DelgUpdateFile(UpdateWatchedFile));
                return;
            }

            tbIOfileContent.Text = "";
            try
            {
                StringBuilder sb = new StringBuilder();
                // simple solution
                foreach (string line in File.ReadAllLines(tbIOfile.Text))
                {
                    if (sb.Length > 0)
                        sb.Append(Environment.NewLine); //" \r\n" 
                    sb.Append(line);
                }
                /*              // stream usage solution  
                                using (StreamReader sr = new StreamReader(tbIOfile.Text))
                                {
                                    dtIOfileModified.Value = File.GetLastWriteTime(tbIOfile.Text);
                                    string line;
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        if ( sb.Length > 0 )
                                            sb.Append(Environment.NewLine);
                                        sb.Append(line);
                                    }
                                }
                */
                tbIOfileContent.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, string.Format("Error occured when reading file '{0}'", tbIOfile.Text), ex);
            }
        }
    #endregion
#endregion

#region XML related methods
	    public class XmlTestItem
	    {
            public string Name { get; set; }
            public string IPaddr { get; set; }
            public int IPport { get; set; }

            public XmlTestItem() : this("none", "192.168.1.1", 815)
		    {
		    }
		    public XmlTestItem(string name, string addr, int port)
            {
		        Name   = name;
		        IPaddr = addr;
		        IPport = port;
            }
	    }
	    public class XmlTestData
	    {
            public string Name;

//		    [XmlElement( typeof(XmlItemData) )]
//          public ArrayList ArrItems = new ArrayList();
		    [XmlElement(ElementName = "Item")]
            public List<XmlTestItem> ArrItems = new List<XmlTestItem>();

            public XmlTestData()
		    {
		    }
            public void Reset()
            {
                Name = "TestData";
                ArrItems.Clear();
            }
        }

        private XmlTestData xmlData;
        private BindingSource bsXmlItems;

        private void initTabXML()
        {
            tbXmlFile.Text = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName), "TestData.xml");

            // init default data
            xmlData =  new XmlTestData();
            xmlData.ArrItems.Add(new XmlTestItem("Test name 1", "192.168.1.1", 815));
            xmlData.ArrItems.Add(new XmlTestItem("Test name 2", "192.168.10.100", 850));
            xmlData.ArrItems.Add(new XmlTestItem("Test name 3", "192.168.10.202", 900));

            bsXmlItems = new BindingSource(xmlData.ArrItems, "");  // ~ bsLines = new BindingSource(); bsLines.DataSource = xmlData.ArrItems;
            dgXmlItems.AutoGenerateColumns = false;
            dgXmlItems.DataSource = bsXmlItems;
            // style 
            dgXmlItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            dgXmlItems.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));

            foreach (DataGridViewColumn col in dgXmlItems.Columns)
                col.HeaderCell.Style.Alignment = col.DefaultCellStyle.Alignment;  // ensure right alignment for headers
        }
        private void btnXMLSel_Click(object sender, EventArgs e)
		{
			using ( OpenFileDialog dlg = new OpenFileDialog() )
            {
                dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*) |*.*";
                dlg.FilterIndex = 1;
			    try { dlg.InitialDirectory = Path.GetDirectoryName(tbIOfile.Text); } catch {}
			    if (dlg.ShowDialog() != DialogResult.OK)
				    return;

			    tbXmlFile.Text = dlg.FileName;
            }
		}
		private void btnXMLParse_Click(object sender, EventArgs e)
		{
            if ( String.IsNullOrEmpty(tbXmlFile.Text) )
            {
                GM.ShowErrorMessageBox(this, "Enter XML file path!");
                tbXmlFile.Focus();
                return;
            }
            if ( !File.Exists(tbXmlFile.Text) )
            {
                GM.ShowErrorMessageBox(this, string.Format("File '{0}' doesn't exist!", tbXmlFile.Text));
                tbXmlFile.Focus();
                return;
            }

            bsXmlItems.EndEdit();
            dgXmlItems.EndEdit();

            if (xmlData.ArrItems.Count > 0 && GM.ShowQuestionMessageBox(this, "Really to delete current data and load new from file?") != DialogResult.Yes)
                return;

            Cursor = Cursors.WaitCursor;
            try
            {
                dgXmlItems.DataSource = null;

                bsXmlItems.SuspendBinding();
                xmlData.Reset();

                XElement elRoot = XElement.Load(tbXmlFile.Text);
                foreach(XElement elItem in elRoot.Elements())
                    xmlData.ArrItems.Add(new XmlTestItem
                    {
                        Name   = GM.GetXElementValue(elItem, "Name"),
                        IPaddr = GM.GetXElementValue(elItem, "IPaddr"),
                        IPport = GM.GetXElementInt(elItem, "IPport")
                    });

/* version with DOM objects
              XmlTestItem itmData;
                using (StreamReader stream = new StreamReader(tbXmlFile.Text))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(stream);
                    foreach (XmlNode node in doc.SelectNodes("XmlTestData/Item"))
                    {
                        itmData = new XmlTestItem();
                        itmData.Name = Convert.ToString(node.SelectSingleNode("Name").FirstChild.Value);
                        itmData.IPaddr = Convert.ToString(node.SelectSingleNode("IPaddr").FirstChild.Value);
                        itmData.IPport = Convert.ToInt32(node.SelectSingleNode("IPport").FirstChild.Value);

                        xmlData.ArrItems.Add(itmData);
                    }
                }
*/            }
            catch (Exception ex) { GM.ShowErrorMessageBox(this, string.Format("Error occured during parsing XML file '{0}'!", tbXmlFile.Text), ex); }
            finally 
            {
                bsXmlItems.ResumeBinding();
                dgXmlItems.DataSource = bsXmlItems;

                dgXmlItems.Refresh();
                dgXmlItems.Focus();

                Cursor = Cursors.Default; 
            }
        }

        private void btnXmlSerialize_Click(object sender, EventArgs e)
		{
			try
			{
                bsXmlItems.EndEdit();
                dgXmlItems.EndEdit();
                if (bsXmlItems.Count == dgXmlItems.Rows.Count)
                    bsXmlItems.RemoveAt(bsXmlItems.Count - 1);

                if (bsXmlItems.Count < 1)
                {
                    GM.ShowErrorMessageBox(this, "No data to save!");
                    dgXmlItems.Focus();
                    return;
                }

                XmlSerializer xml = new XmlSerializer(typeof(XmlTestData));
				using ( StreamWriter sw = new StreamWriter(tbXmlFile.Text) ) 
				{
					xml.Serialize(sw, xmlData);
    				GM.ShowInfoMessageBox(this, string.Format("XML file '{0}' saved successfully!", tbXmlFile.Text));
				}
			}
			catch(Exception ex) { GM.ShowErrorMessageBox(this, string.Format("Error occured during serializing to XML file '{0}'!", tbXmlFile.Text), ex); }
        }
        private void dgXMLItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewColumn col = dgXmlItems.Columns[e.ColumnIndex];
            if (col.DefaultCellStyle.Format == "N0" || col == colXmlItemIPport)
            {
                DataGridViewCell c = dgXmlItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (c != null)
                {
                    string strValue = c.EditedFormattedValue.ToString();
                    int ipPort = 0;

                    if (!int.TryParse(strValue, out ipPort))
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < strValue.Length; i++)
                            if (Char.IsDigit(strValue[i]))
                                sb.Append(strValue[i]);
                        if (sb.Length > 0)
                            int.TryParse(sb.ToString(), out ipPort);
                    }

                    c.Value = ipPort;
                    return;
                }
            }
            e.ThrowException = true;
        }
        private void dgXMLItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // set selection after right mouse click - to hightlight row
            if (e.Button == MouseButtons.Right)
            {
                DataGridView dg = sender as DataGridView;
                if (!dg.Focused)
                    dg.Focus();
                if (dg != null && e.RowIndex >= 0 && e.RowIndex < dg.Rows.Count && !dg.Rows[e.RowIndex].Selected) // already selected 
                    dg.CurrentCell = dg.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dgXMLItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < xmlData.ArrItems.Count() && (e.ColumnIndex == dgXmlItems.Columns.Count))
            {
                XmlTestItem itm = xmlData.ArrItems[e.RowIndex];

//                UpdateGridLines(e.RowIndex);
            }
        }
#endregion

#region LINQ related methods
        private void initTabLINQ()
        {
            // LINQ to XML
            listLINQxml.Columns.Add("Name", 130);
            listLINQxml.Columns.Add("Street", 130);
            listLINQxml.Columns.Add("City", 100);
            listLINQxml.Columns.Add("ZIP", 80);
            listLINQxml.Columns.Add("Country", -2);

            if ( !rbLINQxmlAll.Checked )
                rbLINQxmlAll.Checked = true;
            else
                onLINQxml_Changed(null, null);

            // LINQ to Objects
            tbLINQobj.Text = Directory.GetCurrentDirectory();
            UpdateLINQtoObjList();

//            // LINQ to DataSet
//            UpdateLINQtoDataSet();
        }
        private void onLINQxml_Changed(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            listLINQxml.BeginUpdate();
            try
            {
                listLINQxml.Items.Clear();
                if ( string.IsNullOrEmpty(tbLINQxml.Text) )
                    return;

                XElement root = XElement.Parse(tbLINQxml.Text);
                IEnumerable<XElement> addrQ;
                if ( rbLINQxmlDeliv.Checked ) 
                    addrQ = from a in root.Elements("Address") where (string)a.Attribute("Type")=="D" orderby (string)a.Element("Name") select a;
                else if ( rbLINQxmlAccnt.Checked )
                    addrQ = root.Elements("Address").Where(a=>(a.Attribute("Type").Value=="A")).OrderBy(a=>(string)a.Element("Name"));
                else
                    addrQ = root.Elements("Address").OrderBy(a=>a.Element("Name").Value);

                foreach(var a in addrQ )
                    listLINQxml.Items.Add(new ListViewItem(new string[] {a.Element("Name").Value, (string)a.Element("Street"), (string)a.Element("City"), (string)a.Element("Zip"), (string)a.Element("Country")}));
            }
            catch(Exception ex)
            {
                if ( !tbLINQxml.Focused )
                    GM.ShowErrorMessageBox(this, "Error occured when running LINQ to XML", ex);
            }
            finally 
            {
                Cursor = Cursors.Default;
                listLINQxml.EndUpdate();
            }
        }
		private void btnLINQxmlSel_Click(object sender, EventArgs e)
		{
			using ( OpenFileDialog dlg = new OpenFileDialog() )
            {
                dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*) |*.*";
                dlg.FilterIndex = 1;
			    try { dlg.InitialDirectory = Path.GetDirectoryName(tbLINQxml.Text); } catch {}
			    if (dlg.ShowDialog() != DialogResult.OK)
				    return;

			    tbLINQxml.Text = dlg.FileName;
            }

            onLINQxml_Changed(null,null);
		}
        private void btnLINQselObj_Click(object sender, EventArgs e)
        {
            using ( FolderBrowserDialog dlg = new FolderBrowserDialog() )
            {
			    try { dlg.SelectedPath = Path.GetDirectoryName(tbLINQobj.Text); } catch { }
			    if (dlg.ShowDialog() != DialogResult.OK)
				    return;

			    tbLINQobj.Text = dlg.SelectedPath;
            }
            UpdateLINQtoObjList();
        }
        private void UpdateLINQtoObjList()
        {
            Cursor = Cursors.WaitCursor;
            listLINQobj.BeginUpdate();
            try
            {
                listLINQobj.Items.Clear();

                FileInfo [] arrFile = new DirectoryInfo(tbLINQobj.Text).GetFiles("*.*");
                var filesQ = from f in arrFile
//                             where f.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase)
                             orderby f.Name
                             select f.Name;
                foreach(string fileName in filesQ)
                    listLINQobj.Items.Add(fileName);
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured when running LINQ to Objects", ex);
            }
            finally 
            {
                Cursor = Cursors.Default;
                listLINQobj.EndUpdate();
            }
        }
/*        private void UpdateLINQtoDataSet()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dtAddr = new DataTable();

                string connStr = string.Format("Data Source='{0}';Password='{1}';", "TestDB.sdf", "xxx");
                using ( SqlCeConnection conn = new SqlCeConnection(connStr) )
                {
                    SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Address", conn);
                    da.Fill(dtAddr);
                }

                var addrQ = from a in dtAddr.AsEnumerable()
                            orderby a.Field<string>("addr_name")
                            select a;

                int col;
                col = dgLINQds.Columns.Add("addr_name", "Name");    dgLINQds.Columns[col].DataPropertyName = "addr_name";
                col = dgLINQds.Columns.Add("addr_street", "Street");dgLINQds.Columns[col].DataPropertyName = "addr_street";
                col = dgLINQds.Columns.Add("addr_city", "City");    dgLINQds.Columns[col].DataPropertyName = "addr_city";
                col = dgLINQds.Columns.Add("addr_zip", "ZIP");      dgLINQds.Columns[col].DataPropertyName = "addr_zip";
                col = dgLINQds.Columns.Add("addr_ICO", "ICO");      dgLINQds.Columns[col].DataPropertyName = "addr_ICO";
                col = dgLINQds.Columns.Add("addr_DIC", "DIC");      dgLINQds.Columns[col].DataPropertyName = "addr_DIC";

                dgLINQds.AutoGenerateColumns = false;
                dgLINQds.DataSource = addrQ.AsDataView();
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured when running LINQ to DataSet", ex);
            }
            finally 
            {
                Cursor = Cursors.Default;
            }
        }
*/
#endregion	
        
#region Windows service usage
        private void initTabService()
        {
            cbServiceAccount.Items.Add(new CBItem("Local system", (int)ServiceAccount.LocalSystem));
            cbServiceAccount.Items.Add(new CBItem("Local service", (int)ServiceAccount.LocalService));
            cbServiceAccount.Items.Add(new CBItem("Network service", (int)ServiceAccount.NetworkService));
            cbServiceAccount.Items.Add(new CBItem("User", (int)ServiceAccount.User));
            cbServiceAccount.SelectedIndex = 0;

            tbServiceName_TextChanged(null, null);
        }

        private void tbServiceName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbServiceName.Text))
            {
                serviceController.ServiceName = tbServiceName.Text;

                try
                {
                    serviceController.Refresh();
                    if (serviceController.ServiceHandle != null)
                    {
                        // try to get login account of installed service
                        ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(string.Format("SELECT startname FROM Win32_Service where Name='{0}'", tbServiceName.Text));
                        foreach (ManagementObject moService in theSearcher.Get())
                        {
                            tbServiceUser.Text = ""; tbServicePwd.Text = "";

                            String accntName = moService.GetPropertyValue("startname").ToString().ToLower();
                            int selAccnt = (int)ServiceAccount.LocalSystem;
                            if (accntName.Contains("local system") || accntName.Contains("localsystem")) selAccnt = (int)ServiceAccount.LocalSystem;
                            else if (accntName.Contains("local service") || accntName.Contains("localservice")) selAccnt = (int)ServiceAccount.LocalService;
                            else if (accntName.Contains("network service") || accntName.Contains("networkservice")) selAccnt = (int)ServiceAccount.NetworkService;
                            else { selAccnt = (int)ServiceAccount.User; tbServiceUser.Text = moService.GetPropertyValue("startname").ToString(); }

                            for (int i = 0; i < cbServiceAccount.Items.Count; i++)
                                if (((CBItem)cbServiceAccount.Items[i]).Value == selAccnt)
                                {
                                    cbServiceAccount.SelectedIndex = i;
                                    break;
                                }

                            break;
                        }
                    }
                }
                catch (Exception ex) { }
                updateServiceStatus();
            }
        }
        private void btnServiceSel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = Path.GetDirectoryName(tbServiceFile.Text);
                dlg.Title = "Select windows service executable...";
                dlg.Filter = "exe files (*.exe)|*.exe";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                tbServiceFile.Text = dlg.FileName;
            }
        }
        private void btnServiceAction_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (sender == btnServiceInstall)
                {
                    if (!File.Exists(tbServiceFile.Text))
                    {
                        GM.ShowErrorMessageBox(this, string.Format("File '{0}' doesn't exist!", tbServiceFile.Text));
                        tbServiceFile.Focus();
                        return;
                    }
                    CBItem selAccnt = cbServiceAccount.SelectedItem as CBItem;
                    if (selAccnt == null)
                    {
                        GM.ShowErrorMessageBox(this, "Select service account!");
                        cbServiceAccount.Focus();
                        return;
                    }
                    using (ServiceProcessInstaller procSrvInst = new ServiceProcessInstaller())
                    using (ServiceInstaller srvIns = new ServiceInstaller())
                    {
                        procSrvInst.Account = (ServiceAccount)selAccnt.Value;
                        procSrvInst.Username = tbUser.Text;
                        procSrvInst.Password = tbServicePwd.Text;

                        InstallContext context = new System.Configuration.Install.InstallContext("", new string[] { String.Format("/assemblypath={0}", tbServiceFile.Text) });
                        srvIns.Context = context;
                        srvIns.DisplayName = tbServiceName.Text;
                        srvIns.Description = "Service installed from Various test";
                        srvIns.ServiceName = tbServiceName.Text;
                        srvIns.StartType = ServiceStartMode.Automatic;
                        srvIns.Parent = procSrvInst;

                        System.Collections.Specialized.ListDictionary state = new System.Collections.Specialized.ListDictionary();
                        srvIns.Install(state);
                    }
                }
                else if (sender == btnServiceUninstall)
                {
                    if (serviceController.CanStop)
                        serviceController.Stop();

                    serviceController.Close();
                    serviceController = null;
                    GC.Collect();

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
	                startInfo.FileName = "sc.exe";
	                startInfo.Arguments = String.Format("delete \"{0}\"", tbServiceName.Text);;
                    using ( Process p = Process.Start(startInfo) )
                        p.WaitForExit(15000);

/*                    using (ServiceInstaller srvIns = new ServiceInstaller())
                    {
                        srvIns.Context = new System.Configuration.Install.InstallContext("", null);
                        srvIns.ServiceName = tbServiceName.Text;

                        srvIns.Uninstall(null);
                    }
*/ 
                    serviceController = new ServiceController(tbServiceName.Text);
                }
                else if (sender == btnServiceStart)
                {
                    if (serviceController.Status == ServiceControllerStatus.Stopped || serviceController.Status == ServiceControllerStatus.Paused)
                    {
                        serviceController.Start();
                        updateServiceStatus();

                        serviceController.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
                    }
                }
                else if (sender == btnServiceStop)
                {
                    if (serviceController.CanStop)
                    {
                        serviceController.Stop();
                        updateServiceStatus();

                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 30));
                    }
                }
                updateServiceStatus();
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Error occured when handling service", ex);
            }
            finally { Cursor = Cursors.Default; }
        }
        private void updateServiceStatus()
        {
            try
            {
                if (serviceController == null)
                {
                    tbServiceStatus.Text = "";

                    btnServiceInstall.Enabled = btnServiceUninstall.Enabled = btnServiceStart.Enabled = btnServiceStop.Enabled = false;
                }
                else
                {
                    serviceController.Refresh();

                    tbServiceStatus.Text = serviceController.Status.ToString();

                    cbServiceAccount.Enabled = tbServiceUser.Enabled = tbServicePwd.Enabled = btnServiceInstall.Enabled = (serviceController.ServiceHandle == null);
                    btnServiceUninstall.Enabled = (serviceController.ServiceHandle != null && serviceController.Status == ServiceControllerStatus.Stopped);
                    btnServiceStart.Enabled = (serviceController.Status == ServiceControllerStatus.Stopped || serviceController.Status == ServiceControllerStatus.Paused);
                    btnServiceStop.Enabled = (serviceController.Status == ServiceControllerStatus.Running);
                }
            }
            catch (Exception ex)
            {
                tbServiceStatus.Text = ex.Message;
                if ( ex.InnerException != null && !String.IsNullOrEmpty(ex.InnerException.Message) )
                    tbServiceStatus.Text += (Environment.NewLine+ex.InnerException.Message);
                cbServiceAccount.Enabled = tbServiceUser.Enabled = tbServicePwd.Enabled = btnServiceInstall.Enabled = true;
                btnServiceUninstall.Enabled = false;
                btnServiceStart.Enabled = false;
                btnServiceStop.Enabled = false;
            }
        }
#endregion

#region sending e-mail - Simple MAPI & SMPT
		private void btnMailMAPIsend_Click(object sender, EventArgs e)
		{
			Mapi mapi = new Mapi();
            string s;
            // add recepients
            {
                bool isRcp = false;
                foreach(string rcp in tbMailRcp.Text.Split(';'))
                {
                    s = rcp.Trim();
                    if ( s.Length > 0 )
                    {
        			    mapi.AddRecip(s, "SMTP:"+s, false);
                        isRcp = true;
                    }
                }
                if ( !isRcp )
                {
                    GM.ShowErrorMessageBox(this, "Enter recepient!");
                    tbMailRcp.Focus();
                    return;
                }
            }
            // add copy to
            foreach(string cpy in tbMailCopy.Text.Split(';'))
            {
                s = cpy.Trim();
                if ( s.Length > 0 )
    			    mapi.AddRecip(s, "SMTP:"+s, true);
            }
            // send mail
			mapi.Send(IntPtr.Zero, this.Handle, tbMailSubject.Text, tbMailBody.Text, Mapi.MapiDialog|Mapi.MapiLogonUI);
		}
        private void btnMailSMTPsend_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(tbMailFrom.Text) )
            {
                GM.ShowErrorMessageBox(this, "Enter from address!");
                tbMailFrom.Focus();
                return;
            }
            if ( string.IsNullOrEmpty(tbMailSMTPserver.Text) )
            {
                GM.ShowErrorMessageBox(this, "Enter SMTP server!");
                tbMailSMTPserver.Focus();
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                string s;

                // add recepients
                {
                    bool isRcp = false;
                    foreach(string rcp in tbMailRcp.Text.Split(';'))
                    {
                        s = rcp.Trim();
                        if ( s.Length > 0 )
                        {
        			        mail.To.Add(s);
                            isRcp = true;
                        }
                    }
                    if ( !isRcp )
                    {
                        GM.ShowErrorMessageBox(this, "Enter recepient!");
                        tbMailRcp.Focus();
                        return;
                    }
                }
                // add copy to
                foreach(string cpy in tbMailCopy.Text.Split(';'))
                {
                    s = cpy.Trim();
                    if ( s.Length > 0 )
    			        mail.CC.Add(s);
                }
                // send mail
                mail.From = new MailAddress(tbMailFrom.Text, tbMailFrom.Text);
                mail.Subject = tbMailSubject.Text;
                mail.Body = tbMailBody.Text;

                int port = (int)nudMailSMPTport.Value;
                SmtpClient smtp = new SmtpClient(tbMailSMTPserver.Text, (port < 1)?25:port);
                // set authentication data - are required by most smtp servers
                if ( string.IsNullOrEmpty(tbMailSMTPuser.Text) && string.IsNullOrEmpty(tbMailSMTPpwd.Text) )
                    smtp.Credentials = CredentialCache.DefaultNetworkCredentials;
                else 
                    smtp.Credentials = new System.Net.NetworkCredential(tbMailSMTPuser.Text, tbMailSMTPpwd.Text);

                Cursor = Cursors.WaitCursor;
                smtp.Send(mail);

                GM.ShowInfoMessageBox(this, "Mail successfully sent!");
            }
            catch(Exception ex)
            {
                GM.ShowErrorMessageBox(this, "Sending mail by SMTP failed!", ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
#endregion  

#region WWW
        private void btnWWWDownload_Click(object sender, EventArgs e)
        {
            tbWWWContent.Text = "";
            Cursor = Cursors.WaitCursor;
            try
            {
                WebClient webCli = new WebClient();
                using (StreamReader sr = new StreamReader(webCli.OpenRead(tbWWWURL.Text)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        tbWWWContent.Text += line;
                        tbWWWContent.Text += Environment.NewLine;//"\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, string.Format("Error occured when reading content of URL '{0}'!", tbWWWURL.Text), ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
#endregion

#region UI
        private void initTabUI()
        {
            tbUI.Tree.Nodes.Add("Item1").Nodes.Add("SubItem1");
            tbUI.Tree.Nodes.Add("Item2");
            tbUI.TextValue = "Item1->SubItem1";

            chbUITreeBoxEnabled.Checked = true;
            chbUITreeBoxEditable.Checked = true;
            ////
            listUImbox.Items.Clear();

            listUImbox.Columns.Add("Name", 90);
            listUImbox.Columns.Add("Value", -2);

            ListViewItem lvi;
            foreach (FieldInfo fi in typeof(MessageBoxIcon).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                string s = string.Format("{0}  ({1})", fi.GetRawConstantValue(), fi.GetValue(null));
                lvi = new ListViewItem(new string[] {fi.Name, s});
                lvi.Tag = fi.GetValue(null);
                listUImbox.Items.Add(lvi);
            }
            if ( listUImbox.Items.Count > 0 )
                listUImbox.Items[0].Selected = true;

/* using ListBox          
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Value", typeof(MessageBoxIcon));

            foreach (FieldInfo fi in typeof(MessageBoxIcon).GetFields(BindingFlags.Public | BindingFlags.Static))
                tbl.Rows.Add(fi.Name, fi.GetValue(null));
            listUImbox.DataSource = tbl;
            listUImbox.ValueMember = "Value";
            listUImbox.DisplayMember = "Name";

            if ( listUImbox.Items.Count > 0 )
                listUImbox.SelectedIndex = 0;
*/
        }

        private void btnUImbox_Click(object sender, EventArgs e)
        {
            if ( listUImbox.SelectedItems.Count < 0 )
            {
                GM.ShowErrorMessageBox(this, "Select message box icon first!");
                listUImbox.Focus();
                return;
            }
            MessageBoxIcon mbi = (MessageBoxIcon)listUImbox.SelectedItems[0].Tag;
            MessageBox.Show(this, "MessageBoxIcon."+listUImbox.SelectedItems[0].SubItems[0].Text, Application.ProductName, MessageBoxButtons.OK, mbi);

            listUImbox.Focus();
        }
        private void listUImbox_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                btnUImbox_Click(null, null);
                e.Handled = true;
            }
        }

        // simulate tree list using by owner-draw tree
		private void treeUI_DrawNode(object sender, DrawTreeNodeEventArgs e)
		{
			Graphics g = e.Graphics;

			try
			{
				Rectangle r = e.Bounds;
				if ( r.Width > 0 && r.Height > 0 )
				{
					r.Offset(0, 1);
					g.DrawString(e.Node.Text, treeUI.Font, e.Node.IsSelected?SystemBrushes.HighlightText:SystemBrushes.ControlText, r);

					if ( e.Node.Parent != null )
					{
						r = new Rectangle(200, e.Bounds.Top, treeUI.Right-200, e.Bounds.Height);
						r.Offset(0, 1);

						g.DrawString("xxxxxx", treeUI.Font, e.Node.IsSelected?SystemBrushes.HighlightText:SystemBrushes.ControlText, r);
					}
				}
			}
			catch(Exception ex)
			{
#if DEBUG
                GM.ShowErrorMessageBox(this, "Error occured during tree owner drawing", ex);
#endif
            }
        }

        private void chbUITreeBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            tbUI.Enabled = chbUITreeBoxEnabled.Checked;
        }
        private void chbUITreeBoxEditable_CheckedChanged(object sender, EventArgs e)
        {
            tbUI.TextEditable = chbUITreeBoxEditable.Checked;
        }

#endregion    

#region other test
        private void initTabOther()
        {
            tbOtherAppPathExe.Text = Application.ExecutablePath;
            tbOtherAppPathStartup.Text = Application.StartupPath;
            tbOtherAppProdName.Text = Application.ProductName;
            tbOtherAppProdVer.Text = Application.ProductVersion;

            tbOtherDTtoday.Text = DateTime.Today.ToString();
            tbOtherDTnow.Text   = DateTime.Now.ToString();
        }

#endregion

#region process handling
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private void btnOtherProcWnd_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] arrProc = Process.GetProcessesByName(tbOtherProcName.Text);
                if (arrProc.Length < 1)
                {
                    GM.ShowErrorMessageBox(this, string.Format("No instance of the process '{0}' found!", tbOtherProcName.Text));
                    return;
                }
                foreach (Process proc in arrProc)
                {
                    if (proc.MainWindowHandle == IntPtr.Zero)
                    {
                        if (arrProc.Length == 1)
                        {
                            GM.ShowErrorMessageBox(this, string.Format("Process '{0}' has no main window to minimize!", tbOtherProcName.Text));
                            break;
                        }
                        continue;
                    }

                    if (sender == btnOtherMinimizeProcWnd) ShowWindow(proc.MainWindowHandle, 6); // 6 ~ SW_MINIMIZE
                    else if (sender == btnOtherMaximizeProcWnd) ShowWindow(proc.MainWindowHandle, 3); // 6 ~ SW_MAXIMIZE
                    else if (sender == btnOtherRestoreProcWnd) ShowWindow(proc.MainWindowHandle, 9); // 9 ~ SW_RESTORE
                    else if (sender == btnOtherCloseProcWnd 
                            && GM.ShowQuestionMessageBox(this, string.Format("Really to close window '{0}'?", proc.MainWindowTitle))==DialogResult.Yes)
                        proc.Kill();
                }
            }
            catch (Exception ex)
            {
                GM.ShowErrorMessageBox(this, string.Format("Error occured when trying to handle window for the process '{0}'", tbOtherProcName.Text), ex);
            }
        }
        #endregion
    }
}