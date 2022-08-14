using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer.Connection
{
    public class DbConnection
    {
      public static  SqlConnection sqlConnection=new SqlConnection(@"Data Source=DESKTOP-T0I7RRL; Initial Catalog=DbAkademiFilmDizi; integrated Security=True; ");
    }
}
