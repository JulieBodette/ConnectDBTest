using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace ConnectDBTest
{
	public class DataAccess
	{
		public List<Food> GetFood(string food_group)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
			{
				var output = connection.Query<Food>("select * from Food_Group").ToList();
				return output;
			}
		}
	}
}
