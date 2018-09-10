using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using HtmlAgilityPack;

namespace Computer_Science_prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var website = @"https://findajob.dwp.gov.uk/search?q=&w=London";

            HtmlWeb site = new HtmlWeb();

            var JobSite = site.Load(website);

            var node = JobSite.DocumentNode.SelectNodes("/html/body/div[@id='main']/main/div[@class='grid-row']/div[@id='search_results']/div[@class='search-result']");

            string temp = "";

            foreach (var child in node)
            {
                richTextBox1.Text = temp + Environment.NewLine + (child.InnerText);
                temp = temp + child.InnerText;
            }

            
            

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
