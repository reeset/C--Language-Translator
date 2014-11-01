using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace lang_files
{
    public partial class Form1 : Form
    {

        public const string XML_HEADER = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" + 
                                         "<marcedit language=\"\">\n";
        //public const string LANG_PATH = @"c:\users\reeset\desktop\languagefiles\";
        private string LANG_PATH = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            

            LANG_PATH = textBox2.Text;
            System.IO.StreamWriter writer = null;

            if (rdEnglish.Checked == true)
            {
                writer = new System.IO.StreamWriter(LANG_PATH + "english.xml", false, System.Text.Encoding.UTF8);
                writer.Write(XML_HEADER);
                writer.Flush();
            }

            System.Collections.Hashtable language_streams = new System.Collections.Hashtable();

            System.IO.StreamWriter frenchwriter = null;
            System.IO.StreamWriter dutchwriter = null;
            System.IO.StreamWriter finnishwriter = null;
            System.IO.StreamWriter chinesewriter = null;
            System.IO.StreamWriter germanwriter = null;
            System.IO.StreamWriter greekwriter  = null;
            System.IO.StreamWriter hindiwriter = null;
            System.IO.StreamWriter italianwriter = null;
            System.IO.StreamWriter japanesewriter = null;
            System.IO.StreamWriter polishwriter = null;
            System.IO.StreamWriter russianwriter = null;
            System.IO.StreamWriter spanishwriter = null;
            System.IO.StreamWriter swedishwriter = null;
            System.IO.StreamWriter turkishwriter = null;
            System.IO.StreamWriter welshwriter = null;
            System.IO.StreamWriter portuguesewriter = null;
            System.IO.StreamWriter urduwriter = null;


            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.CheckBox))
                {
                    if (((System.Windows.Forms.CheckBox)c).Checked == true) {
                        switch (((System.Windows.Forms.CheckBox)c).Tag.ToString().ToLower())
                        {
                            case "zh-cht":
                                chinesewriter = new System.IO.StreamWriter(LANG_PATH + "zh-CHT.xml", false, System.Text.Encoding.UTF8);
                                chinesewriter.Write(XML_HEADER);
                                chinesewriter.Flush();
                                language_streams.Add("zh-CHT", chinesewriter);
                                break;
                            case "nl":
                                dutchwriter = new System.IO.StreamWriter(LANG_PATH + "nl.xml", false, System.Text.Encoding.UTF8);
                                dutchwriter.Write(XML_HEADER);
                                dutchwriter.Flush();
                                language_streams.Add("nl", dutchwriter);
                                break;
                            case "fi":
                                finnishwriter = new System.IO.StreamWriter(LANG_PATH + "fi.xml", false, System.Text.Encoding.UTF8);
                                finnishwriter.Write(XML_HEADER);
                                finnishwriter.Flush();
                                language_streams.Add("fi", finnishwriter);
                                break;
                            case "fr":
                                frenchwriter = new System.IO.StreamWriter(LANG_PATH + "fr.xml", false, System.Text.Encoding.UTF8);
                                frenchwriter.Write(XML_HEADER);
                                frenchwriter.Flush();
                                language_streams.Add("fr", frenchwriter);
                                break;
                            case "de":
                                germanwriter = new System.IO.StreamWriter(LANG_PATH + "de.xml", false, System.Text.Encoding.UTF8);
                                germanwriter.Write(XML_HEADER);
                                germanwriter.Flush();
                                language_streams.Add("de", germanwriter);
                                break;
                            case "el":
                                greekwriter = new System.IO.StreamWriter(LANG_PATH + "el.xml", false, System.Text.Encoding.UTF8);
                                greekwriter.Write(XML_HEADER);
                                greekwriter.Flush();
                                language_streams.Add("el", greekwriter);
                                break;
                            case "hi":
                                hindiwriter = new System.IO.StreamWriter(LANG_PATH + "hi.xml", false, System.Text.Encoding.UTF8);
                                hindiwriter.Write(XML_HEADER);
                                hindiwriter.Flush();
                                language_streams.Add("hi", hindiwriter);
                                break;
                            case "it":
                                italianwriter = new System.IO.StreamWriter(LANG_PATH + "it.xml", false, System.Text.Encoding.UTF8);
                                italianwriter.Write(XML_HEADER);
                                italianwriter.Flush();
                                language_streams.Add("it", italianwriter);
                                break;
                            case "ja":
                                japanesewriter = new System.IO.StreamWriter(LANG_PATH + "ja.xml", false, System.Text.Encoding.UTF8);
                                japanesewriter.Write(XML_HEADER);
                                japanesewriter.Flush();
                                language_streams.Add("ja", japanesewriter);
                                break;
                            case "pl":
                                polishwriter = new System.IO.StreamWriter(LANG_PATH + "pl.xml", false, System.Text.Encoding.UTF8);
                                polishwriter.Write(XML_HEADER);
                                polishwriter.Flush();
                                language_streams.Add("pl", polishwriter);
                                break;
                            case "ru":
                                russianwriter = new System.IO.StreamWriter(LANG_PATH + "ru.xml", false, System.Text.Encoding.UTF8);
                                russianwriter.Write(XML_HEADER);
                                russianwriter.Flush();
                                language_streams.Add("ru", russianwriter);
                                break;
                            case "es":
                                spanishwriter = new System.IO.StreamWriter(LANG_PATH + "es.xml", false, System.Text.Encoding.UTF8);
                                spanishwriter.Write(XML_HEADER);
                                spanishwriter.Flush();
                                language_streams.Add("es", spanishwriter);
                                break;
                            case "sv":
                                swedishwriter = new System.IO.StreamWriter(LANG_PATH + "sv.xml", false, System.Text.Encoding.UTF8);
                                swedishwriter.Write(XML_HEADER);
                                swedishwriter.Flush();
                                language_streams.Add("sv", swedishwriter);
                                break;
                            case "tr":
                                turkishwriter = new System.IO.StreamWriter(LANG_PATH + "tr.xml", false, System.Text.Encoding.UTF8);
                                turkishwriter.Write(XML_HEADER);
                                turkishwriter.Flush();
                                language_streams.Add("tr", turkishwriter);
                                break;
                            case "cy":
                                welshwriter = new System.IO.StreamWriter(LANG_PATH + "cy.xml", false, System.Text.Encoding.UTF8);
                                welshwriter.Write(XML_HEADER);
                                welshwriter.Flush();
                                language_streams.Add("cy", welshwriter);
                                break;
                            case "pt":
                                portuguesewriter = new System.IO.StreamWriter(LANG_PATH + "pt.xml", false, System.Text.Encoding.UTF8);
                                portuguesewriter.Write(XML_HEADER);
                                portuguesewriter.Flush();
                                language_streams.Add("pt", portuguesewriter);
                                break;
                            case "ur":
                                urduwriter = new System.IO.StreamWriter(LANG_PATH + "ur.xml", false, System.Text.Encoding.UTF8);
                                urduwriter.Write(XML_HEADER);
                                urduwriter.Flush();
                                language_streams.Add("ur", urduwriter);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            string[] csproj_files = new string[comboBox1.Items.Count];
            comboBox1.Items.CopyTo(csproj_files, 0);

            foreach (string csproj_file in csproj_files)
            {
                xmldoc.Load(csproj_file);
                XmlNamespaceManager mgr = new XmlNamespaceManager(xmldoc.NameTable);
                mgr.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");
                string snamespace = xmldoc.SelectSingleNode("//x:PropertyGroup/x:RootNamespace", mgr).InnerText;
                
                foreach (XmlNode item in xmldoc.SelectNodes("//x:ItemGroup/x:Compile", mgr))
                {
                    string test = "";
                    if (item.Attributes["Include"] != null)
                    {
                        //System.Windows.Forms.MessageBox.Show(item.InnerXml);
                        test = item.Attributes["Include"].InnerText.ToString();
                    }
                    //System.Windows.Forms.MessageBox.Show(System.IO.Path.GetDirectoryName(textBox1.Text));
                    string intFunction = IsInitializeComponent(System.IO.Path.GetDirectoryName(csproj_file) + System.IO.Path.DirectorySeparatorChar.ToString() + test);

                    if (intFunction.Trim().Length > 0)
                    {
                        string sform = snamespace + "_" + test.Substring(0, test.IndexOf("."));
                        string xml_element = String.Empty;
                        //System.Windows.Forms.MessageBox.Show(intFunction.Length.ToString());
                        if (rdEnglish.Checked == true)
                        {
                            xml_element = ParseFunction(intFunction, "");
                            writer.Write("<" + sform + ">" + System.Environment.NewLine + xml_element + "</" + sform + ">" + System.Environment.NewLine);
                            writer.Flush();
                        }
                        foreach (object k in language_streams.Keys)
                        {
                            lbstatus.Text = "Processing " + (string)k + ": " + sform;
                            xml_element = ParseFunction(intFunction, (string)k);
                            ((System.IO.StreamWriter)language_streams[(string)k]).Write("<" + sform + ">" + System.Environment.NewLine + xml_element + "</" + sform + ">" + System.Environment.NewLine);
                            ((System.IO.StreamWriter)language_streams[(string)k]).Flush();
                            System.Windows.Forms.Application.DoEvents();
                        }
                    }
                }
            }
            if (rdEnglish.Checked == true)
            {
                writer.Write("</marcedit>");
                writer.Close();
            }

            foreach (object k in language_streams.Keys)
            {
                ((System.IO.StreamWriter)language_streams[(string)k]).Write("</marcedit>");
                ((System.IO.StreamWriter)language_streams[(string)k]).Close();
            }

            System.Windows.Forms.MessageBox.Show("Finished");
            
        }

        private string DoTranslation(string p, string language)
        {

            if (language.Trim().Length == 0)
            {
                return p;
            }

            string clientID = Properties.Settings.clientID;
            string clientSecret = Properties.Settings.clientSecret;


            AdmAccessToken admToken;
            string headerValue = string.Empty;
                                    //Get Client Id and Client Secret from https://datamarket.azure.com/developer/applications/
                                    //Refer obtaining AccessToken (http://msdn.microsoft.com/en-us/library/hh454950.aspx) 
            AdmAuthentication admAuth = new AdmAuthentication(clientID, clientSecret);
            try
            {
                admToken = admAuth.GetAccessToken();
                // Create a header with the access_token property of the returned token
                headerValue = "Bearer " + admToken.access_token;
            }
            catch { }
            

            //System.Windows.Forms.MessageBox.Show(headerValue);

            //string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(text) + "&from=" + from + "&to=" + to;
            //string authToken = "Bearer" + " " + admToken.access_token;

            //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            //httpWebRequest.Headers.Add("Authorization", authToken);


            string text = p;
            string from = "en";
            string to = language;

            string uri = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + System.Web.HttpUtility.UrlEncode(text) + "&from=" + from + "&to=" + to;
            string authToken = headerValue;

            System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Authorization", authToken);

            System.Net.WebResponse response = null;
            try
            {
                response = httpWebRequest.GetResponse();
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    System.Runtime.Serialization.DataContractSerializer dcs = new System.Runtime.Serialization.DataContractSerializer(Type.GetType("System.String"));
                    string translation = (string)dcs.ReadObject(stream);
                    return translation;
                    //Console.WriteLine("Translation for source text '{0}' from {1} to {2} is", text, "en", "de");
                    //Console.WriteLine(translation);
                }
            }
            catch { }
            return p;

        }

        private string IsInitializeComponent(string p)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(p, true);
            string blog = reader.ReadToEnd();
            string function2parse = String.Empty;
            reader.Close();

            int start = blog.IndexOf("#region Windows Form Designer generated code");
            int end = 0;
            if (start > -1)
            {
                end = blog.IndexOf("#endregion", start);
            }

            if (start > -1)
            {
                function2parse = blog.Substring(start, (end - start));
            }
            return function2parse;
        }

        private string ParseFunction(string function2parse, string language)
        {
            string vars = String.Empty;
            function2parse = function2parse.Replace(System.Environment.NewLine, "\n");
            string[] lines = function2parse.Split("\n".ToCharArray());
            for (int xx = 0; xx < lines.Length; xx++) 
            {
                if (lines[xx].IndexOf(".Text ") > -1 && lines[xx].IndexOf(".txt") < 0)
                {
                    string nameval = lines[xx].Substring(0, lines[xx].IndexOf(".Text =") + ".Text =".Length);
                    string data = lines[xx].Substring(nameval.Length);
                    data = System.Text.RegularExpressions.Regex.Replace(data, "([^ ]?)(&)([^ ]?)", "$1$3").Trim(" \";".ToCharArray());

                    if (data.EndsWith("+"))
                    {
                        string tdata = string.Empty;
                        do
                        {
                            data = data.TrimEnd("+ \"".ToCharArray());
                            xx += 1;
                            tdata = lines[xx].Trim(" \";".ToCharArray());
                            data += tdata;
                            if (tdata.EndsWith("+"))
                            {
                                xx += 1;
                                tdata = lines[xx].Trim(" \";".ToCharArray());
                            }
                            else { tdata = ""; }
                        } while (tdata.EndsWith("+"));
                       data = data.TrimEnd("+ \"".ToCharArray()) + tdata;
                       
                    }

                    data = data.Replace("\\'", "'").Replace("\\n", System.Environment.NewLine).Replace("\\r", "");

                    if (System.Text.RegularExpressions.Regex.IsMatch(data.Trim(" \";".ToCharArray()), @"^[0-9]{3}\$.") == false &&
                        System.Text.RegularExpressions.Regex.IsMatch(data.Trim(" \";".ToCharArray()), @"^[0-9]{3}$") == false)
                    {
                        string[] parts = nameval.Split(".".ToCharArray());
                        if (parts.Length > 2)
                        {
                            
                            System.Xml.Linq.XElement element = new System.Xml.Linq.XElement(parts[1].Trim(),
                                           DoTranslation(data, language));

                            vars += element.ToString();

                            //"<" + parts[1].Trim() + ">\n" + parts[parts.Length - 1].Substring(parts[parts.Length - 1].IndexOf("=") + 1).Trim(" \";".ToCharArray()) + "</" + parts[1].Trim() + ">" + System.Environment.NewLine;
                        }
                        else
                        {
                            System.Xml.Linq.XElement element = new System.Xml.Linq.XElement(parts[0].Trim(),
                                            DoTranslation(data, language));

                            vars += element.ToString();
                            //"<" + parts[0].Trim() + ">\n" + parts[parts.Length - 1].Substring(parts[parts.Length - 1].IndexOf("=") + 1).Trim(" \n\";".ToCharArray()) + "</" + parts[0].Trim() + ">\n" + System.Environment.NewLine;
                        }
                    }
                }
            }
            return vars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            ///C:\Users\reeset\Dropbox\Symlinked marcedit\net_marcedit\C#\MProgram\MarcEdit\MarcEdit.csproj
            openFileDialog1.Filter = "C# Project files (*.csproj)|*.csproj|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Length > 0)
            {
                comboBox1.Items.Add(openFileDialog1.FileName);
            }
        }

        private void cmdDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;
            if (textBox2.Text.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) == false)
            {
                textBox2.Text += System.IO.Path.DirectorySeparatorChar.ToString();
            }
        }
    }
}
