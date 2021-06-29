using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Profile_Backup
{
    public partial class Form1 : Form
    {

        String userFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
        String currectDirectory = Directory.GetCurrentDirectory();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1;
            //Consigue la ruta del usuario actual
            String userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            //Recoge el nombre de usuario y lo settea en el textbox1
            string userName = Environment.UserName;
            label5.Text = (userName);

        }


        private void button1_Click(object sender, EventArgs e)
        {

            bool active = true;
            progressBar1.Value = 0;

            Process p = new Process();
            // p.StartInfo.Arguments = string.Format("/C Robocopy /s /v /w:1 /r:1 /is /it",  "%userprofile%", "%username%");
            p.StartInfo.Arguments = string.Format("/C robocopy C:\\prueba %username% /s /v /w:1 /r:1 /is /it");
           // p.StartInfo.Arguments = string.Format("/C robocopy %userprofile% %username% /s /v /w:1 /r:1 /is /it");
            p.StartInfo.FileName = "CMD.EXE";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = true;
            p.Start();
            p.WaitForExit();
            active = false;

            if (active == false)
            {
                progressBar1.Value = 1;
                MessageBox.Show("The copy has been completed");
            }
            
            Process.Start("explorer.exe", currectDirectory);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/antonio-castillo");
        }


    }
}
