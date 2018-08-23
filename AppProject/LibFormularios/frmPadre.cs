using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using LibClases;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace LibFormularios
{
    public partial class frmPadre : Form
    {
        SqlConnection cn;
        private OleDbConnection aConexion;
        private OleDbDataAdapter aDataAdapter;
        private DataTable aDataTable;
        private string aux;
        //=================== ATRIBUTOS ==========================
        protected cEntidad aEntidad;

        //=================== METODOS ==========================
        //------------------ Constructor -----------------------
        public frmPadre()
        {
            InitializeComponent();
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
            } catch
            {

            }
        }

        //------------------- Metodos base------------------------
        /// <summary>
        /// Metodo Virtual que permite indicar que valores del formulario
        /// deben ir a la tabla relacionada. Los valores deben ser definidos
        /// en el mismo orden en que estan considerados en la base de datos.
        /// Es obligatorio redefinir este metodo en todos los herederos de frmPadre.
        /// </summary>
        /// <returns>Arreglo de strings con los valores que deben ir a la tabla</returns>
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }


        //---------------------------------------------
        public void IniciarEntidad(cEntidad pEntidad)
        {
            //----- Indicar con que entidad trabaja el formulario
            aEntidad = pEntidad;
        }

        //---------------------------------------------
        public virtual void InicializarAtributoClave()
        {
            //-- Dar valores a los controles relacionados al atributo clave
        }

        //---------------------------------------------
        public virtual void InicializarAtributoNoClave()
        {
            //-- Dar valores a los controles relacionados al atributo no clave
        }

        public virtual void InicializarAtributos()
        {
            //-- Dar valores inicial a todos los atributos del formulario
            InicializarAtributoClave();
            InicializarAtributoNoClave();
        }

        //------------------------
        public virtual void MostrarDatos()
        {   //-- Visualiza la informacion de un registro en el formulario
        }

        //---------------------
        public virtual void ListarRegistros()
        {   //-- lista todos los registros de la tabla relacionada
        }

        //--------------------------
        public virtual bool EsRegistroValido()
        {   //-- verifica que los datos esten completos en el formulario
            return true;
        }

        //-----------------

        public virtual void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave 
            string[] Atributos = AsignarValoresAtributos();
            // 	 Verificar si existe clave primaria
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //	 Registro existente, Recuperar Atributos y mostrarlos
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave
                InicializarAtributoNoClave();
            }
        }

        public virtual string NombreTabla()
        {
            return null;//Obtener el nombre de la| tabla
        }
        public virtual DataTable Tabla()
        {
            return null;//Obtener el datatable
        }
        //----------------------------
        public virtual void Grabar()
        {
            try
            {
                cn.Open();
                SqlBulkCopy importar = default(SqlBulkCopy);
                importar = new SqlBulkCopy(cn);
                importar.DestinationTableName = NombreTabla();
                importar.WriteToServer(Tabla());
                cn.Close();
                MessageBox.Show("LOS DATOS SE GUARDARON EXITOSAMENTE", "CONFIRMACION");
                Close();
            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString()/*"ERROR AL GUARDAR LOS DATOS"*/);
            }
        }

        //----------------------------

        public void ImportarExcel()
        {
            string ruta = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel Files |*.xls;*.xlsx";
                open.Title = "Seleccione el archivo de Escuelas o Carreras";
                //Si se abrio el open y se presiono abrir
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Si la ruta no es vacia se almacene en ruta
                    if (open.FileName.Equals("") == false)
                    {
                        ruta = open.FileName;
                    }
                    aConexion = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + ruta + "';Extended Properties=Excel 12.0;");
                    //aConexion = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + ruta + "';Extended Properties=Excel 12.0;");
                    //aConexion = new OleDbConnection(cadenaConexionArchivoExcel);
                    aConexion.Open();
                    aDataAdapter = new OleDbDataAdapter("Select * from [Hoja1$]", aConexion);

                    aDataTable = new DataTable();
                    aDataAdapter.Fill(aDataTable);
                    aConexion.Close();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = aDataTable;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        public void lecturaTxt(int col, string ruta, string tipo)
        {
            StreamReader reader = new StreamReader(ruta);
            string sline = "";
            int fila = 0;
            dgvDatos.Rows.Clear();
            dgvDatos.AllowUserToAddRows = false;
            do
            {
                sline = reader.ReadLine();
                if (sline != null)
                {
                    if (fila == 0)
                    {
                        dgvDatos.ColumnCount = col;
                        //dgvErrores.ColumnCount = col;--agregar una columna al dgv
                        switch (tipo)
                        {
                            case "faltante":
                                agregarFilaFaltantes(sline, fila);
                                break;
                            case "identidad":
                                agregarFilaIdentidad(sline, fila);
                                break;
                            case "respuesta":
                                agregarFilaRespuesta(sline, fila);
                                break;
                            case "clave":
                                agregarFilaClave(sline, fila);
                                break;

                        }
                        //                        agregarfila(sline, fila);
                        //nombrarTablaTitulo(sline.Split(Caracter));
                        fila += 1;
                    }
                    else
                    {
                        switch (tipo)
                        {
                            case "faltante":
                                agregarFilaFaltantes(sline, fila);
                                break;
                            case "identidad":
                                agregarFilaIdentidad(sline, fila);
                                break;
                            case "respuesta":
                                agregarFilaRespuesta(sline, fila);
                                break;
                            case "clave":
                                agregarFilaClave(sline, fila);
                                break;

                        }
                        //                        agregarfila(sline, fila);
                        //nombrarTablaTitulo(sline.Split(Caracter));
                        fila += 1;
                    }
                }
            } while (!(sline == null));
            reader.Close();

        }

        public void agregarFilaFaltantes(string linea, int posicion)
        {
            string arreglo = linea.Substring(0, 8);
            dgvDatos.Rows.Insert(posicion, arreglo);
        }
        public void agregarFilaIdentidad(string linea, int posicion)
        {
            string arreglo = linea.Substring(0, 6);
            string arreglo2 = linea.Substring(6, 8);
            dgvDatos.Rows.Insert(posicion, arreglo, arreglo2.Trim());

        }
        public void agregarFilaRespuesta(string linea, int posicion)
        {
            string arreglo = linea.Substring(0, 6);
            string arreglo2 = linea.Substring(6, 1);
            string arreglo3 = linea.Substring(8, 50);
            dgvDatos.Rows.Insert(posicion, arreglo, arreglo2, arreglo3);
        }
        public void agregarFilaClave(string linea, int posicion)
        {
            string arreglo = linea.Substring(0, 1);
            string arreglo2 = linea.Substring(1, 50);
            dgvDatos.Rows.Insert(posicion, arreglo, arreglo2);
        }


        public void CargarArchivoTxt()
        {
            string archivo = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "txt Files |*.txt;*.sdf";
                //open.Title = "Seleccione el archivo de Escuelas o Carreras";
                open.ShowDialog();
                if (!string.IsNullOrEmpty(open.FileName))
                {

                    archivo = open.FileName;

                    if (Regex.IsMatch(archivo, @"[3]"))
                    {
                        aux = "faltante";
                        lecturaTxt(1, archivo, aux);
                        MessageBox.Show(aux);
                    }
                    else if (Regex.IsMatch(archivo, @"[4]"))
                    {
                        aux = "identidad";
                        lecturaTxt(2, archivo, aux);
                        MessageBox.Show(aux);
                    }
                    else if (Regex.IsMatch(archivo, @"[5]"))
                    {
                        aux = "respuesta";
                        lecturaTxt(3, archivo, aux);
                        MessageBox.Show(aux);
                    }
                    else //if (Regex.IsMatch(archivo, @"[6]"))
                    {
                        aux = "clave";
                        lecturaTxt(2, archivo, aux);
                        MessageBox.Show(aux);
                    }
                    //archivo.Split()
                    //MessageBox.Show(archivo);
                    //lecturaTxt(';', archivo);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        //=================== EVENTOS ==========================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
