using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdioCalculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtHex.Text))
            {
                try
                {
                    int value = Convert.ToInt32(this.txtHex.Text, 16);
                    this.txtDeci.Text = value.ToString();
                    Clipboard.SetText(this.txtDeci.Text);
                }
                catch(Exception ex)
                {
                    this.MsgBox(ex.Message);
                }
            }
        }

        private void btnDeci_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtDeci.Text))
            {
                try
                {
                    int value = Convert.ToInt32(this.txtDeci.Text, 10);
                    string text = Convert.ToString(value, 16);
                    this.txtHex.Text = $"0x{text}";
                    Clipboard.SetText(this.txtHex.Text);
                }
                catch(Exception ex)
                {
                    this.MsgBox(ex.Message);
                }
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            IDataObject ido = Clipboard.GetDataObject();
            string[] formats = ido.GetFormats();
            foreach(string format in formats)
            {
                object obj = ido.GetData(format);

            }
            string text = Clipboard.GetText();
            this.txtHex.Text = text;
            this.txtDeci.Text = text;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
