using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private ContactRepository con = new ContactRepository();
        private void Obtener_datos_Click(object sender, EventArgs e)
        {
            var cliente = con.ObtenerTodos();
            Contact_database.DataSource = cliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Contact crearContact()
        {
            var contact = new Contact
            {
                Name = textBox1.Text,
                Mobile = textBox2.Text,
                Address = textBox3.Text,
            };
            return contact;
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            var contac = crearContact();
            var resultado = con.InsertarContact(contac);
            MessageBox.Show($"se inserto " + resultado);
        }
    }
}
