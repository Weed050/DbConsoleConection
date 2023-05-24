// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

Console.WriteLine("Let's get down to the business:");
ListBusinesses();

void ListBusinesses()
{
	using (SqlConnection conn = new	SqlConnection(
       
        "Data Source=LAPTOP-XXXXXXX\\SQLEXPRESS;Initial Catalog=DBName;User id=UserName;Password=;Integrated Security=True;MultipleActiveResultSets=True"

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
