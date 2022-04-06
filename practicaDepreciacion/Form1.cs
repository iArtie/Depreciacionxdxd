using AppCore.IServices;
using AppCore.Services;
using Domain.Entities;
using Domain.Enum;
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
        public int awa;
        IEmpleadoServices empleadoServices;
        IActivoServices activoServices;
        int index;
        public Form1(IActivoServices ActivoServices, IEmpleadoServices EmpleadoServices)
        {
            this.activoServices = ActivoServices;
            this.empleadoServices = EmpleadoServices;
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
            if (verificado == false || cmbEmpelado.Text == "Agregar")
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {
                EstadoActivo n = (EstadoActivo)Enum.GetValues(typeof(EstadoActivo)).GetValue(cmbEstado.SelectedIndex);
                string empxd = cmbEmpelado.SelectedItem.ToString();
                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual = double.Parse(txtValorR.Text),
                    VidaUtil = int.Parse(txtVidaU.Text),
                    Descripcion = txtDesc.Text,
                    Codigo = System.Guid.NewGuid().ToString(),
                    Estado = n.ToString(),
                    Empleado = empxd

                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(txtVidaU.Text) || String.IsNullOrEmpty(txtValorR.Text) || String.IsNullOrEmpty(txtDesc.Text) || cmbEstado == null)
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
            this.txtDesc.Text = String.Empty;
            this.cmbEstado.Text = "";
            this.cmbEmpelado.Text = String.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            index = -1;
            Empleado empleado;
            FrmEmpleado Empleadoqwq = new FrmEmpleado(index);
            Empleadoqwq.empleadoServices = empleadoServices;
            dataGridView1.DataSource = activoServices.Read();
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoActivo));
            AgregarItems();
            
            //cmbEmpelado.Items.Add(empleado.Nombres);
        }

        public void AgregarItems()
        {
            List<Empleado> empleadoxd = empleadoServices.Read();
            for (int i = 0; i < empleadoxd.Count; i++)
            {
                cmbEmpelado.Items.Add(empleadoxd[i].Nombres);
            }
            cmbEmpelado.Items.Add("Agregar");
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            activoServices.Delete(activoServices.Read()[awa]);
            dataGridView1.DataSource = activoServices.Read();
            //dataGridView1.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            
            bool verificado = verificar();
            if (textoID.Text == " ")
            {
                MessageBox.Show("Tiene que seleccionar un objeto para modificar");
            }else if (verificado == false || cmbEmpelado.Text == "Agregar")
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
               
            }
            else
            {
                int sandia = Int32.Parse(textoID.Text);
                EstadoActivo n = (EstadoActivo)Enum.GetValues(typeof(EstadoActivo)).GetValue(cmbEstado.SelectedIndex);
                string empxd = cmbEmpelado.SelectedItem.ToString();
                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual = double.Parse(txtValorR.Text),
                    VidaUtil = int.Parse(txtVidaU.Text),
                    Descripcion = txtDesc.Text,
                    Codigo = System.Guid.NewGuid().ToString(),
                    Estado = n.ToString(),
                    Empleado = empxd,
                    Id = xdd
                };
                activoServices.Update(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();


            }
        }

        private void TextoID_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedId = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                RowSelect = dataGridView1.CurrentRow.Index;
                //xdd = e.RowIndex;
                xdd = (int)dataGridView1.CurrentRow.Cells[0].Value;
                awa = e.RowIndex;
                textoID.Text = xdd.ToString();
                //activoServices.Delete(activoServices.Read()[e.RowIndex]);
                //dataGridView1.DataSource = activoServices.Read();
                //FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                //depreciacion.ShowDialog();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        



  

        private void CmbEmpelado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FrmEmpleado Empleadoqwq = new FrmEmpleado(index);

            if (cmbEmpelado.Text == "Agregar")
            {
                index = -1;
                
                //Application.Run(new FrmEmpleado(iwi.Resolve<IEmpleadoServices>()));
                Empleadoqwq.empleadoServices = empleadoServices;
                Empleadoqwq.activoServices = activoServices;
                Empleadoqwq.Show();
                limpiar();
                
                cmbEmpelado.Text = String.Empty;
                Hide();
            }
           
           // cmbEmpelado.Items.Clear();
          
            
            //AgregarItems();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //XDDDDDDDDDDDDDDDDDD

      
    }
}
