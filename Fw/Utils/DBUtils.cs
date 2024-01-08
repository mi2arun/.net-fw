
using System.Data.SqlClient;

namespace Fw.Utils
{

	public static class DbUtils
	{
		private static readonly string connectionString = "Data Source=DESKTOP-N7O59QR\\SQLEXPRESS;Initial Catalog=temp_db;Integrated Security=True";

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}

	}

}