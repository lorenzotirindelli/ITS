using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lorenzo.Northwind.Data.Models;
using System.Data.SqlClient;

namespace Lorenzo.Northwind.Data
{
	public class SqlDataAccess : IDataAccess
	{
		public string ConnectionString { get; private set; }

		public SqlDataAccess(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		public IEnumerable<Category> GetCategories()
		{
			List<Category> result = new List<Category>();

			using (var connection = new SqlConnection(this.ConnectionString))
			{
				connection.Open();

				var query = @"
SELECT [CategoryID]
      ,[CategoryName]
      ,[Description]
      ,[Picture]
  FROM [dbo].[Categories]";

				//using (var command = new SqlCommand(query, connection))
				using (var command = connection.CreateCommand())
				{
					command.CommandText = query;
					command.CommandType = System.Data.CommandType.Text;

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var category = new Category();
							category.Id = (int)reader["CategoryID"];
							//Ritornano tutte lo stesso dato
							//category.Id = reader.GetInt32(0);
							//category.Id = reader.GetInt32(reader.GetOrdinal("CategoryID"));
							//category.Id = (int)reader.GetValue(0);
							//category.Id = (int)reader.GetValue(reader.GetOrdinal("CategoryID"));
							category.Name = reader["CategoryName"] as string;
							category.Description = reader["Description"] as string;

							result.Add(category);
						}
					}

				}

			}

			return result;

		}

		public Category GetCategory(int id)
		{

			using (var connection = new SqlConnection(this.ConnectionString))
			{
				connection.Open();

				var query = @"
SELECT [CategoryID]
      ,[CategoryName]
      ,[Description]
      ,[Picture]
  FROM [dbo].[Categories]
WHERE CategoryID = @mioNomeCheVoglioId";

				//using (var command = new SqlCommand(query, connection))
				using (var command = connection.CreateCommand())
				{
					command.CommandText = query;
					command.CommandType = System.Data.CommandType.Text;

					command.Parameters.Add(new SqlParameter("@mioNomeCheVoglioId", id));

					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							var category = new Category();
							category.Id = (int)reader["CategoryID"];
							category.Name = reader["CategoryName"] as string;
							category.Description = reader["Description"] as string;

							return category;
						}
					}

				}

			}

			//E' il return nel caso non ci sia una category da ritornare
			//Nel program posso mettere un if (x != null) e gestire la
			return null;
		}
	}
}
