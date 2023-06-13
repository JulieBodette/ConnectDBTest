using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;

namespace ConnectDBTest
{
	public class DataAccess
	{
		public static string CnnVal(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

		public List<StudentModel> GetStudents()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DataAccess.CnnVal("Students")))
			{
				var output = connection.Query<StudentModel>("select * from Students").ToList();
				return output;
			}
		}
	}
}
