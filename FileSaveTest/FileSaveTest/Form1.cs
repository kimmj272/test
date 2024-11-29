using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSaveTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTextFile();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void SaveTextFile()
        {
            bool bCheck = true;
            int nCount = 50;
            float fValue = 3.14f;
            string str = "안녕하세요";

            StreamWriter fw = new StreamWriter("textdata1.txt");

            fw.WriteLine(bCheck);
            fw.WriteLine(nCount);
            fw.WriteLine(fValue);
            fw.WriteLine(str);

            fw.Close();
        }

        private void LoadTextFile()
        {
            txtResult.Text = ""; 

            StreamReader fr = new StreamReader("textdata1.txt");

            string sCheck = fr.ReadLine();
            string sCount = fr.ReadLine();
            string sValue = fr.ReadLine();
            string sStr = fr.ReadLine();

            fr.Close();

            bool bCheck = bool.Parse(sCheck);
            int nCount = int.Parse(sCount);
            float fValue = float.Parse(sValue);
            string str = sStr;

            txtResult.Text += ("Check = " + bCheck + "\n");
            txtResult.Text += ("Count = " + nCount + "\n");
            txtResult.Text += ("Value = " + fValue + "\n");
            txtResult.Text += ("Str = " + str + "\n");
        }

        private void SaveInform()
        {
            StreamWriter fw = new StreamWriter("textdata1.txt");

            fw.WriteLine(tbName.Text);
            fw.WriteLine(tbNumber.Text);
            fw.WriteLine(tbNickName.Text);
            fw.WriteLine(tbEmail.Text);

            fw.Close();
        }
    }
}
