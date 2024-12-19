using FrontEnactus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FrontEnactus
{
    public partial class WinLogin : Form
    {
        public WinLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AccesoButton_Click(object sender, EventArgs e)
        {
                string username = Username.Text;
                string password = Password.Text;

                using (var context = new enactus_dbEntities())
                {
                    var user = context.usuarios
                        .FirstOrDefault(u => u.nombre_usuario == username && u.password == password);

                    if (user != null)
                    {
                        MessageBox.Show("Login exitoso!");
                        var homeForm = new Home();
                        homeForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                }
        }
    }
}