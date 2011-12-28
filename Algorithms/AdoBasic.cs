using System;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;

namespace Algorithms
{
	internal class AdoBasic
	{
		public SqlConnection GetConnection()
		{
			return new SqlConnection("Data Source=afsst120;Initial Catalog=PolicyApp;Integrated Security=True");
		}
	}

	[TestFixture]
	public class AdoBasicTest
	{
		public void ExecuteScalarTest()
		{
			using (SqlConnection conn = new AdoBasic().GetConnection())
			{
				conn.Open();
				SqlCommand sqlCommand = conn.CreateCommand();
				var newCommand = new SqlCommand();
				newCommand.Connection = conn;
				newCommand.CommandText = "select count(*) from Policy";

				sqlCommand.CommandText = "select count(*) from Policy";
				var olo = (int) sqlCommand.ExecuteScalar();
				Assert.Greater(olo, 10);
			}
		}

		[Test]
		public void AdapterTest()
		{
			using (SqlConnection conn = new AdoBasic().GetConnection())
			{
				conn.Open();
				SqlCommand sqlCommand = conn.CreateCommand();
				sqlCommand.CommandText = "select top(10) * from Policy";
				var adapter = new SqlDataAdapter(sqlCommand);
				var ds = new DataSet();
				adapter.Fill(ds);
				Assert.AreEqual(10, ds.Tables[0].Rows.Count);
			}
		}

		[Test]
		public void ReaderTest()
		{
			using (SqlConnection conn = new AdoBasic().GetConnection())
			{
				conn.Open();
				SqlCommand sqlCommand = conn.CreateCommand();
				sqlCommand.CommandText = "select top(10) * from Policy";
				using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
				{
					while (sqlDataReader.Read())
					{
						Console.WriteLine(sqlDataReader[0]);
					}
				}
			}
		}
	}
}