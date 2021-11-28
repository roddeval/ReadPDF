using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadPDF.Logic
{
    public partial class ucTextInput : UserControl
    {
        public ucTextInput()
        {
            InitializeComponent();
        }

        private void ucTextInput_Load(object sender, EventArgs e)
        {
            ShowText();
        }

        public string LabelContent { set; get; }
        public string TextBoxContent { set; get; }
        public string LabelKey { set; get; }
        public string LabelValue { set; get; }

        public void ShowText()
        {
            if (string.IsNullOrEmpty(LabelContent) == false)
                label1.Text = LabelContent;
            if (string.IsNullOrEmpty(TextBoxContent) == false)
                textBox1.Text = TextBoxContent;
            if (string.IsNullOrEmpty(LabelKey) == false)
                lblKey.Text = string.Format("Key: {0}",LabelKey);
            if (string.IsNullOrEmpty(LabelValue) == false)
                lblValue.Text = string.Format("Value: {0}",LabelValue);
        }

    }
}
