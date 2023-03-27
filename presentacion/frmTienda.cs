using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmTienda : Form
    {
        List<Articulo> listaArticulo;
        public frmTienda()
        {
            InitializeComponent();
        }

        private void frmTienda_Load(object sender, EventArgs e)
        {
            cargar();
            cboxCampo.Items.Add("Código");
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxTienda.Load(imagen);
            }
            catch (Exception)
            {
                pboxTienda.Load("https://crawfordroofing.com.au/wp-content/uploads/2018/04/No-image-available.jpg");
                
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulos articulos = new frmArticulos();
            articulos.ShowDialog();
            cargar();
        }

        private void brnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmArticulos modificar = new frmArticulos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor");
                cboxCriterio.Items.Add("Menor");
                cboxCriterio.Items.Add("Igual");
            }

            else
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Comienza");
                cboxCriterio.Items.Add("Termina");
                cboxCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())               
                    return;
                
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtbFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private bool validarFiltro()
        {
            if (cboxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }
            if (cboxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar");
                return true;
            }
            if (cboxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtbFiltro.Text))
                {
                    MessageBox.Show("Debe ingresar un valor numerico ");
                    return true;
                }
                if (!(soloNumeros(txtbFiltro.Text)))
                {
                    MessageBox.Show("Debe ingresar solo numeros ");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
