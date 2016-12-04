using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMotor.Frm
{
    public partial class FrmHarvest : Form
    {
        public FrmHarvest()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("a"))
            {
                he.SetAttribute("target", "_self");
            }
        }
    }
}
