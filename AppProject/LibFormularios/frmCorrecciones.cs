using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;
using System.Configuration;
using System.Data.SqlClient;

namespace LibFormularios
{
    public partial class frmCorrecciones : Form
    {
        SqlConnection cn;
        private DataView aDatos;
        private DataTable dt;
        private SqlDataAdapter aAdaptador = new SqlDataAdapter();
        
        public frmCorrecciones()
        {
            InitializeComponent();
            
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
            }
            catch
            {


            }
        }

 

        private DataTable BuscarDatos(string Tabla)
        {
            
            string CadenaConsulta = "select * from "+Tabla;
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, cn);
            dt = new DataTable();
            aAdaptador.Fill(dt);
            return dt;
        }

        private void FiltrarErrores()
        {
            BuscarDatos("TErrores");
            if (cboSelccionCorreccion.SelectedItem.ToString() == "Escuelas")
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("CodError", typeof(string));
                dt2.Columns.Add("Carrera", typeof(string));
                dt2.Columns.Add("Nombre", typeof(string));
                dt2.Columns.Add("Grupo", typeof(string));
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].ToString()!=" ")
                    {
                        dt2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());

                    }
                }
            }
            if (cboSelccionCorreccion.SelectedItem.ToString() == "Postulantes")
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("CodError", typeof(string));
                dt2.Columns.Add("Codigo", typeof(string));
                dt2.Columns.Add("Nombre", typeof(string));
                dt2.Columns.Add("Carrera", typeof(string));
                dt2.Columns.Add("Ciclo", typeof(string));
                dt2.Columns.Add("Aula Examen", typeof(string));
                dt2.Columns.Add("Carpeta", typeof(string));
                dt2.Columns.Add("Sexo", typeof(string));
                dt2.Columns.Add("Grupo", typeof(char));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][4].ToString() != " ")
                    {
                        dt2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString());

                    }
                }
                dgvCorecciones.DataSource = dt2;
            }
            if (cboSelccionCorreccion.SelectedItem.ToString() == "Indetidades")
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("CodError", typeof(string));
                dt2.Columns.Add("Codigo de Tarjeta", typeof(string));
                dt2.Columns.Add("Codigo de Postulante", typeof(string));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][12].ToString() != " ")
                    {
                        dt2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString());

                    }
                }
                dgvCorecciones.DataSource = dt2;
            }
            if (cboSelccionCorreccion.SelectedItem.ToString() == "Respuestas de alumnos")
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("CodError", typeof(string));
                dt2.Columns.Add("Codido Tarjeta", typeof(string));
                dt2.Columns.Add("Tema", typeof(string));
                dt2.Columns.Add("Respuesta", typeof(string));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][14].ToString() != " ")
                    {
                        dt2.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString());

                    }
                }
                dgvCorecciones.DataSource = dt2;
            }

        }
        private void RecuperarDatos()
        {
            if (CbCoincidencias.SelectedItem.ToString() =="Escuelas")
            {
                BuscarDatos("TEscuelas");
                dgvCoincidencias.DataSource = dt;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Postulantes")
            {
                BuscarDatos("TPostulante");
                dgvCoincidencias.DataSource = dt;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Identidad")
            {
                BuscarDatos("Tidentidad");
                dgvCoincidencias.DataSource = dt;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Respuestas Alumnos")
            {
                BuscarDatos("TRespuesta");
                dgvCoincidencias.DataSource = dt;
            }

        }
        private void FiltrarDatos()
        {
            
            if (CbCoincidencias.SelectedItem.ToString() == "Escuelas")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "codigo like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Postulantes")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "codigo like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Identidad")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "CodTarjeta like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedItem.ToString() == "Respuestas Alumnos")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "CodTarjeta '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }

        }
        
        private void CbCoincidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RecuperarDatos();
            aDatos = dt.DefaultView;
        }

        private void cboSelccionCorreccion_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrarErrores();

        }

        private void tbCoincidencia_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        int colum;
        int fila;
        private void dgvCorecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCorreccion.Text = dgvCorecciones.CurrentCell.Value.ToString();
                fila = dgvCorecciones.CurrentCell.RowIndex;
                colum = dgvCorecciones.CurrentCell.ColumnIndex;
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnCorregir_Click(object sender, EventArgs e)
        {
            dgvCorecciones[colum, fila].Value = TxtCorreccion.Text;
            MessageBox.Show("Elemento Corregido");
            TxtCorreccion.Text = null;

        }

        private void BtnGuardarCorrecciones_Click(object sender, EventArgs e)
        {
            if (dgvCorecciones.RowCount > 0)
            {
                string cadenaActualizar;
                if (cboSelccionCorreccion.SelectedItem.ToString() == "Escuelas")
                {

                    try
                    {
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Update TErrores set obs = '" + " Se realizo una Correccion a: " + dgvCorecciones[1, i].Value.ToString() + " " + dgvCorecciones[2, i].Value.ToString() + " " + dgvCorecciones[3, i].Value.ToString()
                                                + "'"
                                                + " where Codigo = '" + dgvCorecciones[0, i].Value.ToString() + "'";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Insert into  TEscuelas values ('" + dgvCorecciones[1, i].Value.ToString() + "','" + dgvCorecciones[2, i].Value.ToString() + "','" + dgvCorecciones[3, i].Value.ToString() + "')";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("Datos Corregidos");
                    }
                    catch (Exception)
                    {


                    }



                }
                if (cboSelccionCorreccion.SelectedItem.ToString() == "Postulantes")
                {
                    try
                    {
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Update TErrores set obs = '" + "Se realizo una Correccion a: " + dgvCorecciones[1, i].Value.ToString() + " " + dgvCorecciones[2, i].Value.ToString() + " " + dgvCorecciones[3, i].Value.ToString() + " " + dgvCorecciones[4, i].Value.ToString() + " " + dgvCorecciones[5, i].Value.ToString() + " " + dgvCorecciones[6, i].Value.ToString() + " " + dgvCorecciones[7, i].Value.ToString() + " " + dgvCorecciones[8, i].Value.ToString()
                                                + "'"
                                                + " where Codigo = '" + dgvCorecciones[0, i].Value.ToString() + "'";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }

                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Insert into  TPostulante values ('" + dgvCorecciones[1, i].Value.ToString() + "','" + dgvCorecciones[2, i].Value.ToString() + "','" + dgvCorecciones[3, i].Value.ToString() + "','" + dgvCorecciones[4, i].Value.ToString() + "','" + dgvCorecciones[5, i].Value.ToString() + "','" + dgvCorecciones[6, i].Value.ToString() + "','" + dgvCorecciones[7, i].Value.ToString() + "','" + dgvCorecciones[8, i].Value.ToString() + "')";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("Datos Corregidos");

                    }
                    catch (Exception)
                    {


                    }
                }
                if (cboSelccionCorreccion.SelectedItem.ToString() == "Identidad")
                {
                    try
                    {
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Update TErrores set obs = '" + "Se realizo una Correccion a: " + dgvCorecciones[1, i].Value.ToString() + " " + dgvCorecciones[2, i].Value.ToString()
                                                + "'"
                                                + " where Codigo = '" + dgvCorecciones[0, i].Value.ToString() + "'";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Insert into  TIdentidad values ('" + dgvCorecciones[1, i].Value.ToString() + "','" + dgvCorecciones[2, i].Value.ToString() + "')";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("Datos Corregidos");

                    }
                    catch (Exception)
                    {


                    }
                }
                if (cboSelccionCorreccion.SelectedItem.ToString() == "Respuestas Alumnos")
                {
                    try
                    {
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Update TErrores set obs = '" + "Se realizo una Correccion a: " + dgvCorecciones[1, i].Value.ToString() + " " + dgvCorecciones[2, i].Value.ToString() + " " + dgvCorecciones[3, i].Value.ToString()
                                                + "'"
                                                + " where Codigo = '" + dgvCorecciones[0, i].Value.ToString() + "'";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        for (int i = 0; i < dgvCorecciones.RowCount; i++)
                        {
                            cn.Open();
                            cadenaActualizar = "Insert into  TRespuesta values ('" + dgvCorecciones[1, i].Value.ToString() + "','" + dgvCorecciones[2, i].Value.ToString() + "','" + dgvCorecciones[3, i].Value.ToString() + "')";
                            SqlCommand oComando = new SqlCommand(cadenaActualizar, cn);
                            oComando.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("Datos Corregidos");
                    }
                    catch (Exception)
                    {


                    }
                }
            }


            else
                MessageBox.Show("No hay datos que para guardar");
        }
    }
}
