using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSHConnector
{
    public partial class Form1 : Form
    {
        // !write the version on the next line!
        string version = "1.0";
        
        public Form1()
        {
            InitializeComponent();
            label5.Text = "Version: " + version;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The password will be required later.", "Where is the password field?");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SSHConnector version" + version + "\nDeveloped by AleG\nUsing OpenSSH Windows Client by Microsoft (https://github.com/PowerShell/openssh-portable)\nThanks for using this program!", "SSHConnector info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string hostname = textBox2.Text;
            // string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string path = "cmd";
            Process.Start(path, @"/c C:\SSHConnector\ssh.exe " + username + "@" + hostname); 
            //, username + "@" + hostname);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
