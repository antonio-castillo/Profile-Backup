using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Backup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Consigue la ruta del usuario actual
            String userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            //Recoge el nombre de usuario y lo settea en el textbox1
            string userName = Environment.UserName;
            textBox1.Text = (userName);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Robocopy



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/antonio-castillo");
        }
    }
}
