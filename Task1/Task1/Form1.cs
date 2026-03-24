using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
            string.IsNullOrWhiteSpace(txtPass.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPass.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Логін: {txtLogin.Text}");
            result.AppendLine($"eMail: {txtEmail.Text}@{cbServer.SelectedItem}");
            result.AppendLine($"Статус: Акаунт успішно створено");
            result.AppendLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
            result.AppendLine("==============================");

            txtOutput.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) if (c is TextBox) c.Text = "";
            cbServer.SelectedIndex = 0;
            txtOutput.Text = "";
        }
    }
}
