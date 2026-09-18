using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace poladtask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Dictionary<string, string> users = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string inUser = textBox1.Text;
            string inPass = textBox2.Text;

            if (users.ContainsKey(inUser) && users[inUser] == inPass)
            {
                MessageBox.Show("Uğurla daxil oldunuz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!users.ContainsKey(inUser))
            {
                MessageBox.Show("Bu istifadəçi mövcud deyil", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Parol yanlışdır", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string newUser = textBox3.Text;
            string newPass = textBox4.Text;

            if (string.IsNullOrEmpty(newUser) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Xana boş ola bilməz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.ContainsKey(newUser))
            {
                MessageBox.Show("Bu istifadəçi artıq mövcuddur!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            users.Add(newUser, newPass);
            MessageBox.Show("Uğurla qeydiyyatdan keçdiniz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox3.Clear();
            textBox4.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}