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

        System.Collections.Hashtable hashenglish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashfrench = new System.Collections.Hashtable();
        System.Collections.Hashtable hashdutch = new System.Collections.Hashtable();
        System.Collections.Hashtable hashfinnish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashchinese = new System.Collections.Hashtable();
        System.Collections.Hashtable hashgerman = new System.Collections.Hashtable();
        System.Collections.Hashtable hashgreek = new System.Collections.Hashtable();
        System.Collections.Hashtable hashhindi = new System.Collections.Hashtable();
        System.Collections.Hashtable hashitalian = new System.Collections.Hashtable();
        System.Collections.Hashtable hashjapanese = new System.Collections.Hashtable();
        System.Collections.Hashtable hashpolish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashrussian = new System.Collections.Hashtable();
        System.Collections.Hashtable hashspanish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashswedish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashturkish = new System.Collections.Hashtable();
        System.Collections.Hashtable hashwelsh = new System.Collections.Hashtable();
        System.Collections.Hashtable hashportugese = new System.Collections.Hashtable();
        System.Collections.Hashtable hashurdu = new System.Collections.Hashtable();
        


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
                hashenglish = LoadLanguage6(LANG_PATH + "english.xml"); 
                writer = new System.IO.StreamWriter(LANG_PATH + "english.xml", false, System.Text.Encoding.UTF8);
                writer.Write(XML_HEADER);
                writer.Flush();
            }

            System.Collections.Hashtable language_streams = new System.Collections.Hashtable();
            System.Collections.Hashtable language_hashes = new System.Collections.Hashtable();

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
                                hashchinese = LoadLanguage6(LANG_PATH + "zh-CHT.xml");
                                language_hashes.Add("zh-cht", hashchinese);
                                chinesewriter = new System.IO.StreamWriter(LANG_PATH + "zh-CHT.xml", false, System.Text.Encoding.UTF8);
                                chinesewriter.Write(XML_HEADER);
                                chinesewriter.Flush();
                                language_streams.Add("zh-cht", chinesewriter);
                                break;
                            case "nl":
                                hashdutch = LoadLanguage6(LANG_PATH + "nl.xml");
                                dutchwriter = new System.IO.StreamWriter(LANG_PATH + "nl.xml", false, System.Text.Encoding.UTF8);
                                dutchwriter.Write(XML_HEADER);
                                dutchwriter.Flush();
                                language_streams.Add("nl", dutchwriter);
                                language_hashes.Add("nl", hashdutch);
                                break;
                            case "fi":
                                hashfinnish = LoadLanguage6(LANG_PATH + "fi.xml");
                                finnishwriter = new System.IO.StreamWriter(LANG_PATH + "fi.xml", false, System.Text.Encoding.UTF8);
                                finnishwriter.Write(XML_HEADER);
                                finnishwriter.Flush();
                                language_streams.Add("fi", finnishwriter);
                                language_hashes.Add("fi", hashfinnish);
                                break;
                            case "fr":
                                hashfrench = LoadLanguage6(LANG_PATH + "fr.xml");
                                frenchwriter = new System.IO.StreamWriter(LANG_PATH + "fr.xml", false, System.Text.Encoding.UTF8);
                                frenchwriter.Write(XML_HEADER);
                                frenchwriter.Flush();
                                language_streams.Add("fr", frenchwriter);
                                language_hashes.Add("fr", hashfrench);
                                break;
                            case "de":
                                hashgerman = LoadLanguage6(LANG_PATH + "de.xml");
                                germanwriter = new System.IO.StreamWriter(LANG_PATH + "de.xml", false, System.Text.Encoding.UTF8);
                                germanwriter.Write(XML_HEADER);
                                germanwriter.Flush();
                                language_streams.Add("de", germanwriter);
                                language_hashes.Add("de", hashgerman);
                                break;
                            case "el":
                                hashgreek = LoadLanguage6(LANG_PATH + "el.xml");
                                greekwriter = new System.IO.StreamWriter(LANG_PATH + "el.xml", false, System.Text.Encoding.UTF8);
                                greekwriter.Write(XML_HEADER);
                                greekwriter.Flush();
                                language_streams.Add("el", greekwriter);
                                language_hashes.Add("el", hashgreek);
                                break;
                            case "hi":
                                hashhindi = LoadLanguage6(LANG_PATH + "hi.xml");
                                hindiwriter = new System.IO.StreamWriter(LANG_PATH + "hi.xml", false, System.Text.Encoding.UTF8);
                                hindiwriter.Write(XML_HEADER);
                                hindiwriter.Flush();
                                language_streams.Add("hi", hindiwriter);
                                language_hashes.Add("hi", hashhindi);
                                break;
                            case "it":
                                hashitalian = LoadLanguage6(LANG_PATH + "it.xml");
                                italianwriter = new System.IO.StreamWriter(LANG_PATH + "it.xml", false, System.Text.Encoding.UTF8);
                                italianwriter.Write(XML_HEADER);
                                italianwriter.Flush();
                                language_streams.Add("it", italianwriter);
                                language_hashes.Add("it", hashitalian);
                                break;
                            case "ja":
                                hashjapanese = LoadLanguage6(LANG_PATH + "ja.xml");
                                japanesewriter = new System.IO.StreamWriter(LANG_PATH + "ja.xml", false, System.Text.Encoding.UTF8);
                                japanesewriter.Write(XML_HEADER);
                                japanesewriter.Flush();
                                language_streams.Add("ja", japanesewriter);
                                language_hashes.Add("ja", hashjapanese);
                                break;
                            case "pl":
                                hashpolish = LoadLanguage6(LANG_PATH + "pl.xml");
                                polishwriter = new System.IO.StreamWriter(LANG_PATH + "pl.xml", false, System.Text.Encoding.UTF8);
                                polishwriter.Write(XML_HEADER);
                                polishwriter.Flush();
                                language_streams.Add("pl", polishwriter);
                                language_hashes.Add("pl", hashpolish);
                                break;
                            case "ru":
                                hashrussian = LoadLanguage6(LANG_PATH + "ru.xml");
                                russianwriter = new System.IO.StreamWriter(LANG_PATH + "ru.xml", false, System.Text.Encoding.UTF8);
                                russianwriter.Write(XML_HEADER);
                                russianwriter.Flush();
                                language_streams.Add("ru", russianwriter);
                                language_hashes.Add("ru", hashrussian);
                                break;
                            case "es":
                                hashspanish = LoadLanguage6(LANG_PATH + "es.xml");
                                spanishwriter = new System.IO.StreamWriter(LANG_PATH + "es.xml", false, System.Text.Encoding.UTF8);
                                spanishwriter.Write(XML_HEADER);
                                spanishwriter.Flush();
                                language_streams.Add("es", spanishwriter);
                                language_hashes.Add("es", hashspanish);
                                break;
                            case "sv":
                                hashswedish = LoadLanguage6(LANG_PATH + "sv.xml");
                                swedishwriter = new System.IO.StreamWriter(LANG_PATH + "sv.xml", false, System.Text.Encoding.UTF8);
                                swedishwriter.Write(XML_HEADER);
                                swedishwriter.Flush();
                                language_streams.Add("sv", swedishwriter);
                                language_hashes.Add("sv", hashswedish);
                                break;
                            case "tr":
                                hashturkish = LoadLanguage6(LANG_PATH + "tr.xml");
                                turkishwriter = new System.IO.StreamWriter(LANG_PATH + "tr.xml", false, System.Text.Encoding.UTF8);
                                turkishwriter.Write(XML_HEADER);
                                turkishwriter.Flush();
                                language_streams.Add("tr", turkishwriter);
                                language_hashes.Add("tr", hashturkish);
                                break;
                            case "cy":
                                hashwelsh = LoadLanguage6(LANG_PATH + "cy.xml");
                                welshwriter = new System.IO.StreamWriter(LANG_PATH + "cy.xml", false, System.Text.Encoding.UTF8);
                                welshwriter.Write(XML_HEADER);
                                welshwriter.Flush();
                                language_streams.Add("cy", welshwriter);
                                language_hashes.Add("cy", hashwelsh);
                                break;
                            case "pt":
                                hashportugese = LoadLanguage6(LANG_PATH + "pt.xml");
                                portuguesewriter = new System.IO.StreamWriter(LANG_PATH + "pt.xml", false, System.Text.Encoding.UTF8);
                                portuguesewriter.Write(XML_HEADER);
                                portuguesewriter.Flush();
                                language_streams.Add("pt", portuguesewriter);
                                language_hashes.Add("pt", hashportugese);
                                break;
                            case "ur":
                                hashurdu = LoadLanguage6(LANG_PATH + "ur.xml");
                                urduwriter = new System.IO.StreamWriter(LANG_PATH + "ur.xml", false, System.Text.Encoding.UTF8);
                                urduwriter.Write(XML_HEADER);
                                urduwriter.Flush();
                                language_streams.Add("ur", urduwriter);
                                language_hashes.Add("ur", hashurdu);
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
                            xml_element = ParseFunction(intFunction, "", hashenglish);
                            writer.Write("<" + sform + ">" + System.Environment.NewLine + xml_element + "</" + sform + ">" + System.Environment.NewLine);
                            writer.Flush();
                        }
                        foreach (object k in language_streams.Keys)
                        {
                            lbstatus.Text = "Processing " + (string)k + ": " + sform;
                            xml_element = ParseFunction(intFunction, (string)k, ((System.Collections.Hashtable)((System.Collections.Hashtable)language_hashes[(string)k])[sform]));
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

        private string ParseFunction(string function2parse, string language, System.Collections.Hashtable langhash)
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
                        data = data.TrimEnd("+ \"".ToCharArray());
                        xx += 1;
                        tdata = lines[xx].Trim(" \";".ToCharArray());
                        //data += " " + tdata;
                        do
                        {
                            if (tdata.EndsWith("+"))
                            {
                                data += " " + tdata.TrimEnd("+ \"".ToCharArray());
                                xx += 1;
                                tdata = lines[xx].Trim(" \";".ToCharArray());
                            }
                            else { tdata = ""; }
                        } while (tdata.EndsWith("+"));
                       data = data.TrimEnd("+ \"".ToCharArray()) + " " +  tdata;
                       
                    }

                    data = data.Replace("\\'", "'").Replace("\\n", System.Environment.NewLine).Replace("\\r", "");

                    if (System.Text.RegularExpressions.Regex.IsMatch(data.Trim(" \";".ToCharArray()), @"^[0-9]{3}\$.") == false &&
                        System.Text.RegularExpressions.Regex.IsMatch(data.Trim(" \";".ToCharArray()), @"^[0-9]{3}$") == false)
                    {
                        string[] parts = nameval.Split(".".ToCharArray());
                        if (parts.Length > 2)
                        {
                            System.Xml.Linq.XElement element = null;
                            if (langhash[parts[1].Trim()] != null)
                            {
                                element = new System.Xml.Linq.XElement(parts[1].Trim(),
                                            langhash[parts[1].Trim()]);
                            }
                            else
                            {
                                element = new System.Xml.Linq.XElement(parts[1].Trim(),
                                               DoTranslation(data, language));
                            }
                            vars += element.ToString() + System.Environment.NewLine;

                            //"<" + parts[1].Trim() + ">\n" + parts[parts.Length - 1].Substring(parts[parts.Length - 1].IndexOf("=") + 1).Trim(" \";".ToCharArray()) + "</" + parts[1].Trim() + ">" + System.Environment.NewLine;
                        }
                        else
                        {
                            System.Xml.Linq.XElement element = null;

                            if (langhash[parts[0].Trim()] != null)
                            {
                                element = new System.Xml.Linq.XElement(parts[0].Trim(),
                                                langhash[parts[0].Trim()]);
                            }
                            else
                            {
                                element = new System.Xml.Linq.XElement(parts[0].Trim(),
                                                DoTranslation(data, language));

                            }
                            vars += element.ToString() + System.Environment.NewLine;
                            //"<" + parts[0].Trim() + ">\n" + parts[parts.Length - 1].Substring(parts[parts.Length - 1].IndexOf("=") + 1).Trim(" \n\";".ToCharArray()) + "</" + parts[0].Trim() + ">\n" + System.Environment.NewLine;
                        }
                    }
                }
            }
            return vars;
        }

        private System.Collections.Hashtable LoadLanguage6(string sfile)
        {
            
            System.Collections.Hashtable language_table = new System.Collections.Hashtable();
            if (System.IO.File.Exists(sfile) == true)
            {
                System.Xml.XmlDocument objXML = new System.Xml.XmlDocument();
                objXML.Load(sfile);
                //System.Windows.Forms.MessageBox.Show(objXML.InnerXml);
                System.Xml.XmlNodeList objNodes = objXML.SelectNodes("/marcedit/*");
                if (objNodes.Count > 0)
                {

                    foreach (System.Xml.XmlNode node in objNodes)
                    {
                        System.Xml.XmlNodeList nodelist2 = node.SelectNodes("*");
                        System.Collections.Hashtable form_list = new System.Collections.Hashtable();
                        foreach (System.Xml.XmlNode node2 in nodelist2)
                        {
                            form_list.Add(node2.Name, node2.InnerText);
                        }
                        language_table.Add(node.Name, form_list);
                    }
                }
                return language_table;
            }
            return null;
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
