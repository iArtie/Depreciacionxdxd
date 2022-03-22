using AppCore.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Form1 : Form
    {
        public string SelectedId;
        public int RowSelect;
        public int xdd;
        IActivoServices activoServices;
        public Form1(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

    

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual=double.Parse(txtValorR.Text),
                    VidaUtil= int.Parse(txtVidaU.Text)
                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(txtVidaU.Text) || String.IsNullOrEmpty(txtValorR.Text))
            {
              
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txtValor.Text = String.Empty;
            this.txtValorR.Text = String.Empty;
            this.txtVidaU.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedId = dataGridView1. Rows[e.RowIndex].Cells["ID"].Value.ToString();
                RowSelect = dataGridView1.CurrentRow.Index;
                xdd = e.RowIndex;

                //activoServices.Delete(activoServices.Read()[e.RowIndex]);
                //dataGridView1.DataSource = activoServices.Read();
                //FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                //depreciacion.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            activoServices.Delete(activoServices.Read()[xdd]);            
            dataGridView1.DataSource = activoServices.Read();
            dataGridView1.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual = double.Parse(txtValorR.Text),
                    VidaUtil = int.Parse(txtVidaU.Text),
                    Id = xdd
                };
                activoServices.Update(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
    }
    //XDDDDDDDDDDDDDDDDDD
    //AYUDA
}
