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
    public partial class frmPadre : Form
    {
        //=================== ATRIBUTOS ==========================
        protected cEntidad aEntidad;

        //=================== METODOS ==========================
        //------------------ Constructor -----------------------
        public frmPadre()
        {
            InitializeComponent();
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

        //----------------------------
        public virtual void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //-- Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                        aEntidad.Actualizar(Atributos);
                    else
                        aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        //----------------------------
        

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
