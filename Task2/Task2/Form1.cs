using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSelectedItems.SelectedIndex != -1)
                lbSelectedItems.Items.RemoveAt(lbSelectedItems.SelectedIndex);
            else
                MessageBox.Show("Будь ласка, спочатку виберіть елемент у списку!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbSelectedItems.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selected = cbMelodies.SelectedItem.ToString();

            if (lbSelectedItems.Items.Contains(selected))
            {
                MessageBox.Show("Цей твір уже є у вашому списку!", "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbSelectedItems.Items.Add(selected);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
