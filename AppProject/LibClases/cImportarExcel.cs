using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace LibClases
{
    class cImportarExcel
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;
        cEntidad aEntidad;

        private void Cargarexcel(string pRuta, DataGridView pDgv)
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + pRuta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
            MyDataAdapter = new OleDbDataAdapter("Select * from [Hoja1$]", conn);
            dt = new DataTable();
            MyDataAdapter.Fill(dt);
            
            pDgv.DataSource = dt;
            
        }


        public void importar(DataGridView dgv)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xls";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                Cargarexcel(ruta, dgv);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
