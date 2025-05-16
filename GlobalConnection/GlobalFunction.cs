using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Html;
using warehousesystem.Model;

namespace warehousesystem.GlobalConnection
{
    public class GlobalFunction
    {
        public static DataTable FillTable(DevExpress.XtraGrid.GridControl gridCtrl, string queryP)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConnString))
            {
                connection.Open();
                string query = queryP;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gridCtrl.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

    }
}
