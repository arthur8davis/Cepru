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

namespace LibFormularios
{
    public partial class frmCorrecciones : Form
    {
        
        private DataView aDatos;
        public frmCorrecciones()
        {
            InitializeComponent();
        }

        // Modulo para leer datos segun selccion del combo

        // Modulo para recuperar la lista de errores

        // Agregar un modulo para guardar los detalles de las correcciones

        //Metodos para la busqueda
        private void RecuperarDatos()
        {
            if (CbCoincidencias.SelectedValue.ToString() =="Escuelas")
            {
                aDatos = new DataView(/*recuperar de SQL los datos de escuelas*/);
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Postulantes")
            {
                aDatos = new DataView(/*recuperar de SQL los datos de Postulantes*/);
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Identidad")
            {
                aDatos = new DataView(/*recuperar de SQL los datos de Identidad*/);
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Respuestas Alumnos")
            {
                aDatos = new DataView(/*recuperar de SQL los datos de Respuestas alumnos*/);
            }

        }
        private void FiltrarDatos()
        {
            if (CbCoincidencias.SelectedValue.ToString() == "Escuelas")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "codigo like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Postulantes")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "codigo like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Identidad")
            {
                //Crear el filtro adecuado
                string Filtro = "";
                Filtro = "CodTarjeta like '" + tbCoincidencia.Text.Trim() + "%'";
                //Aplicar filtro
                aDatos.RowFilter = Filtro;
            }
            if (CbCoincidencias.SelectedValue.ToString() == "Respuestas Alumnos")
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
        }
    }

   
    

}
