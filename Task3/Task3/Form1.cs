using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
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
            if (clbMelodies.CheckedItems.Count == 0)
            {
                MessageBox.Show("Будь ласка, позначте хоча б один твір галочкою!", "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int addedCount = 0;

            foreach (object item in clbMelodies.CheckedItems)
            {
                string selected = item.ToString();

                if (!lbSelectedItems.Items.Contains(selected))
                {
                    lbSelectedItems.Items.Add(selected);
                    addedCount++;
                }
            }

            if (addedCount == 0)
            {
                MessageBox.Show("Всі обрані твори вже є у вашому списку.", "Інфо");
            }

            for (int i = 0; i < clbMelodies.Items.Count; i++) clbMelodies.SetItemChecked(i, false);
        }
    }
}
