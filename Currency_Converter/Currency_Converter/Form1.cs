using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=1+usd+to+try&oq=1+&aqs=chrome.0.69i59l3j69i57j69i60l2j69i61j69i60.7759j0j4&sourceid=chrome&ie=UTF-8");
        }
    }
}
