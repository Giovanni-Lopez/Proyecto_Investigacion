using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Investigacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando variable
            string nombre = "";
            double salario = 0, incrementoAño = 0.05, incrementoCategoria = 0, incremento=0; 
            int año = 0, categoria = 0;
            
            try
            {
                //Capturando datos del campo nombre
                nombre = txtNombre.Text;            
                // Validando campos que no esten vacios
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Debe completar el nombre del empleado");
                    return;
                }

                //Capturando datos del campo salario
                salario = Convert.ToDouble(txtSalario.Text);
                // Validando que el sueldo sea mayor a cero
                if (salario <= 0)
                {
                    MessageBox.Show("El salario debe ser mayor a cero");
                    return;
                }


                //Capturando datos del campo año
                año = int.Parse(txtAño.Text);
                //Validadando que sea año mayor a 0                

                if (año <= 0)
                {
                    MessageBox.Show("El año ingresado no es valido,\nFavor Ingresar año nuevamente");
                    return;
                }

                //Validando que se seleccione alguna categoria
                if (cbxCate.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha seleccionado ninguna categoria!!");
                    return;
                }

                //Incremento de e salario 
                categoria = cbxCate.SelectedIndex + 1;
                switch (categoria)
                { 
                    //Calculo para Categoria 1
                    case 1:
                        incrementoAño = incrementoAño * año;
                        incrementoCategoria = 0.15;
                        incremento = incrementoAño + incrementoCategoria;
                        salario = salario + incremento;
                        MessageBox.Show("Nombre: "+nombre+
                            "\n ");

                    break;
                }

                
                




            }
            catch (Exception error)
            {
                MessageBox.Show(String.Format("Mensaje: {0}", error.Message));
            }



        }       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtAño.Text = string.Empty;
            cbxCate.SelectedIndex = -1;
        }
    }
}
