// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

Console.WriteLine("Let's get down to the business:");
ListBusinesses();

void ListBusinesses()
{
	using (SqlConnection conn = new	SqlConnection(
        //"Server=LAPTOP-5LC5ROF4\\SQLEXPRESS;Database=DbProject;User Id=Uczen;Password=; Trusted_Connection=False"
        "Data Source=LAPTOP-5LC5ROF4\\SQLEXPRESS;Initial Catalog=DbProject;User id=Uczen;Password=;Integrated Security=True;MultipleActiveResultSets=True"

        ))
	{
		using (SqlCommand cmd = new SqlCommand("select_items",conn))
		{
			cmd.CommandType = CommandType.StoredProcedure;
			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int id = reader.GetInt32('id');
				string fullname = reader.GetString("fullname");
				DateTime dob = reader.GetDateTime("Dob");
				DateTime dob = null;
				if ()
				{

				}

            }
		}
	}
}