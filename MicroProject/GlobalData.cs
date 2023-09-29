using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MicroProject
{
    public class GlobalData
    {
        public static string UserName,BillNo;
        public static string Password;
        public static string TotPrice;
        public static string Table;
        public static SqlDataAdapter DA = new SqlDataAdapter();
        public static DataSet DS=new DataSet();
        public static SqlCommandBuilder CB = new SqlCommandBuilder();
        public static SqlDataReader DR;
        public static DataRow Dr;
    }
}
