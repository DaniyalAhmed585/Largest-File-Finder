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

namespace Paper_Practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.Description = "Biggest file found";
            //if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            //{
            //    textBox1.Text = folderBrowserDialog1.SelectedPath;
            //    string[] a = Directory.GetFiles(textBox1.Text);
            //    long[] b = new long[100];
            //    int i = 0;
            //    foreach (string names in a)
            //    {
            //        FileInfo info = new FileInfo(names);
            //        b[i] = info.Length;
            //        i = i + 1;
            //    }
            //    label4.Text = i.ToString() + " file processed";
            //    long largest = b[0];
            //    int k = 0;
            //    for(int j=1;j<=i;j++)
            //    {
            //        if(largest<b[j])
            //        {
            //            largest = b[j];
            //            k = j;
            //        }
            //    }
            //    textBox2.Text = a[k].ToString();
            //    textBox3.Text = largest.ToString() + "KB";
            //}

            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            long l = 0;
            string nam = "";
            int i = 0;
            foreach(FileInfo fi in dir.GetFiles())
            {
                if(fi.Length>l)
                {
                    l = fi.Length;
                    nam = fi.Name;
                }
                i++;
            }
            label5.Text = Convert.ToString(i) + " Files Processed";
            textBox2.Text = nam;
            textBox3.Text = Convert.ToString(l) + " Bytes";
        }
    }
}
