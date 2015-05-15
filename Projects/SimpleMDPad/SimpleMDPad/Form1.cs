using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkdownSharp;

namespace SimpleMDPad
{
    public partial class Form1 : Form
    {
        private static readonly Markdown MdWorker = new Markdown();


        public Form1()
        {
            InitializeComponent();
            webBrowser1.DocumentText = "<html></html>";
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            var markdown = new Markdown();
            webBrowser1.DocumentText = markdown.Transform(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = MdWorker.Transform(textBox1.Text);
        }
    }
}
