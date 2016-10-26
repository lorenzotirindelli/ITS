using Lorenzo.Northwind.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorenzo.Northwind.Data
{
	public interface IDataAccess
	{
		string ConnectionString { get; }

		IEnumerable<Category> GetCategories();

		Category GetCategory(int id);
	}
}
