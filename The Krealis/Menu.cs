using Learn_CSh_Windows_Forms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_CSh_Windows_Forms
{
    public partial class Menu : Form
    {
        public string playerName;
        public int playerClass; //0 - Mage, 1 - Warrior, 2 - Archer

        public Menu()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] {"Mage",
                        "Warrior",
                        "Archer"});
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Icon = Resources.zutrineRune1;
            Text = "The Krealis";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            playerName = textBox1.Text;
            if(playerName == "FearKeeper" && !comboBox1.Items.Contains("FearKeeper"))
            {
                comboBox1.Items.Add("FearKeeper");
            }
            label2.Text = playerName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerClass = comboBox1.SelectedIndex;
            label5.Text = $"The {new List<string> () {"Mage", "Warrior", "Archer", "FearKeeper"}[playerClass]}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (playerName != null && playerClass != null)
                this.Close();
        }
    }
}
