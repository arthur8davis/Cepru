using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using LibClases;

namespace LibFormularios
{
    public partial class frmMostrarDatos : LibFormularios.frmPadre
    {
        //Atributos
        private OleDbConnection aConexion;
        private OleDbDataAdapter aDataAdapter;
        private DataTable aDataTable;
        //private cEntidad aEntidad;
        private string aux;
        public frmMostrarDatos()
        {
            InitializeComponent();
        }
        //Metodo que nos permite importaar un archivo excel a nuestro datagrid
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

                //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + ruta + "';Extended Properties=\"Excel 8.0 xml; HDR = Yes\"";
                //string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + ruta + "';Extended Properties=\"Excel 12.0  ;HDR=Yes\"";
                //string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + ruta + "';Extended Properties=Excel 12.0;";



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
            string arreglo = linea.Substring(0,6);
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
            string arreglo2 = linea.Substring(6, 50);
            dgvDatos.Rows.Insert(posicion, arreglo, arreglo2);
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
                    
                    if (Regex.IsMatch(archivo, @"[3]")){
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
                        lecturaTxt(2, archivo, aux);
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

        public void buscarErrorIdentidad()
        {
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos[1, i].Value.ToString().Length != 8)
                { //Si el codigo del alumno no es 8
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    
                }
                //Si los nombres de los alumnos una expresion de mas como ,;. y + o si el nombre esta vacio
                /*else if (Regex.IsMatch(dgvDatos[1, i].Value.ToString(), exp) || dgvDatos[1, i].Value.ToString() == "")
                {
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }*/
            }
        }

        public void buscarErrorExcel()
        {
            string exp = @"[,\.\+\;]"; //Expresion regular
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos[0, i].Value.ToString().Length != 8)
                { //Si el codigo del alumno no es 8
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                //Si los nombres de los alumnos una expresion de mas como ,;. y + o si el nombre esta vacio
                else if (Regex.IsMatch(dgvDatos[1, i].Value.ToString(), exp) || dgvDatos[1, i].Value.ToString() == "")
                {
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBuscar.SelectedItem.ToString() == "Excel")
            {
                ImportarExcel();
                buscarErrorExcel();
                aux = "excel";
                MessageBox.Show(aux);
            }
            else
            {
                CargarArchivoTxt();
                buscarErrorIdentidad();
            }
            /*switch (cbBuscar.SelectedItem.ToString())
            {
                case "Excel":
                    ImportarExcel();
                    break;
                case "Texto":
                    ImportarTexto();
                    bre
            }*/
        }
        public void GrabarExcel()
        {
            try
            {
                if (dgvDatos.Columns.Count == 3)
                {
                    IniciarEntidad(new cEscuela());
                    for (int i = 0; i < dgvDatos.Rows.Count; i++)
                    {//Recorremos todo el datagrid e insertamos cada fila a nuestra BD de nuestro archivo de carreras
                        string[] Atributos = { dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString() };
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show("OPERACION REALIZADA EXISTOSAMENTE", "CONFIRMACION");
                }
                else {
                    //char separador = '-';
                    for (int i = 0; i < dgvDatos.Rows.Count; i++)
                    {//Recorremos todo el datagrid e insertamos cada fila a nuestra BD de nuestros postulantes
                        //IniciarEntidad(new CAlumno());
                       // string[] Nombre = dgvDatos[1, i].Value.ToString().Split(separador);
                        //string[] Atributos = { dgvDatos[0, i].Value.ToString(), Nombre[0], Nombre[1], Nombre[2], dgvDatos[2, i].Value.ToString() };
                        //aEntidad.Insertar(Atributos);
                        IniciarEntidad(new cPostulante());
                        if (dgvDatos[6, i].Value.ToString() == "1")
                        {
                            string[] Atributos2 = { dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Masculino", dgvDatos[7, i].Value.ToString(), "no" };
                            aEntidad.Insertar(Atributos2);
                        }
                        else
                        {
                            string[] Atributos2 = { dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Femenino", dgvDatos[7, i].Value.ToString(), "no" };
                            aEntidad.Insertar(Atributos2);
                        }
                    }

                    MessageBox.Show("OPERACION REALIZADA EXISTOSAMENTE", "CONFIRMACION");
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case "excel":
                    GrabarExcel();
                    break;
                case "faltantes":
                    IniciarEntidad(new cFaltante());
                    Grabar();
                    break;
                case "identidad":
                    IniciarEntidad(new cIdentidad());
                    break;
                case "respuesta":
                    IniciarEntidad(new cRespuestaAlumno());
                    break;
                case "clave":
                    IniciarEntidad(new cClaveRespuesta());
                    break;

            }
            if (aux == "excel")
            {
                GrabarExcel();
            }
            if(aux == "faltantes")
            {
                Grabar();
            }
        }

        int colum;
        int fila;
        /// <summary>
        /// carga el valor de una celda al texbox para su correccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCorecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //creo que antes de llenar el dgvcorrecion se debe guardar los datos antes de corregir
            try
            {
                TxtCorreccion.Text = dgvCorecciones.CurrentCell.Value.ToString();
                fila = dgvCorecciones.CurrentCell.RowIndex;
                colum = dgvCorecciones.CurrentCell.ColumnIndex;
            }
            catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pasar los datos corregidos del DgvCorreccion al DgvDatos
            //guardar un reporte de correcciones
        }

        private void BtnCorregir_Click(object sender, EventArgs e)
        {
            dgvCorecciones[colum, fila].Value = TxtCorreccion.Text;
            
        }
    }
}
