using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace ConnectDBTest
{
	public class DataAccess
	{
		public List<StudentModel> GetStudents()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Students")))
			{
				var output = connection.Query<StudentModel>("select * from StudentData_Table").ToList();
				return output;
			}
		}
	}
}
