using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HaiwellClipboard
{
    public partial class FrmMain : Form
    {
        public Dictionary<string, string> Dict { get; set; } = new Dictionary<string, string>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.tmr.Start();
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            IDataObject ido = Clipboard.GetDataObject();
            string[] formats = ido.GetFormats();
            if(formats.Length > 0)
            {
                object value = null;
                foreach(string format in formats)
                {
                    DataFormats.Format fmat = DataFormats.GetFormat(format);

                    switch (format)
                    {
                        case "System.String":
                            value = ido.GetData(format);
                            break;
                        case "UnicodeText":
                            value = ido.GetData(format);
                            break;
                        case "Text":
                            value = ido.GetData(format);
                            break;
                        case "Locale":
                            value = ido.GetData(format);
                            break;
                        case "OEMText":
                            value = ido.GetData(format);
                            break;
                        case "Rich Text Format":
                            value = ido.GetData(format);
                            break;
                        case "PartData":
                            value = ido.GetData(format);
                            if(value is MemoryStream)
                            {
                                StreamReader sr = new StreamReader(value as MemoryStream);
                                value = sr.ReadToEnd();

                            }
                            break;
                        case "svgdata":
                            value = ido.GetData(format);
                            break;
                        case "VisualStudioEditorOperationsLineCutCopyClipboardTag":
                            value = ido.GetData(format);
                            break;
                        case "System.Drawing.Bitmap":
                            value = ido.GetData(format);
                            Bitmap bmp = value as Bitmap;
                            MemoryStream ms = new MemoryStream();
                            bmp.Save(ms, ImageFormat.Png);
                            ms.Seek(0, SeekOrigin.Begin);
                            string md5 = HwCommon.Md5(ms);
                            if(this.BackgroundImage != null)
                            {
                                MemoryStream mms = new MemoryStream();
                                this.BackgroundImage.Save(mms, ImageFormat.Png);
                                mms.Seek(0, SeekOrigin.Begin);
                                string mmd5 = HwCommon.Md5(mms);
                                if(mmd5 != md5)
                                {
                                    this.BackgroundImage = bmp;
                                }
                            }
                            else
                            {
                                this.BackgroundImage = bmp;
                            }

                            break;
                        default:
                            value = ido.GetData(format);
                            break;
                    }
                    if (value != null)
                    {
                        string str = value.ToString();
                        string md5 = HwCommon.Md5(str);
                        if (!this.Dict.ContainsKey(md5))
                        {
                            this.Dict.Add(md5, str);
                            this.richTextBox1.AppendText(value.ToString());
                            this.richTextBox1.AppendText(Environment.NewLine);
                            this.richTextBox1.Focus();
                        }
                    }
                   
                }
            }
        }
    }
}
