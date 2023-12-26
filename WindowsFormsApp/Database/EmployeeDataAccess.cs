using System.Data;
using System.Data.SqlServerCe;
using WindowsFormsApp.Model;

namespace Win02.DataBase
{
  public class EmployeeDataAccess
  {
    private static SqlCeConnection connection = new SqlCeConnection(@"Data Source=C:\Projects\CRUD_EmployeeRegistration\WindowsFormsApp\Database\database.sdf");

    public static DataTable SearchEmployees()
    {
      SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter("SELECT * FROM Employees", connection);
      DataSet dataSet = new DataSet();

      dataAdapter.Fill(dataSet);

      return dataSet.Tables[0];
    }

    [System.Obsolete]
    public static bool SaveEmployee(Employees employees)
    {
      string sql = "INSERT INTO [Employees](Name, Email, Salary, Sex, TypeOfContract, RegistrationDate) VALUES(@Name, @Email, @Salary, @Sex, @TypeOfContract, @RegistrationDate)";

      SqlCeCommand command = new SqlCeCommand(sql, connection);

      command.Parameters.Add("@Name", employees.Name);
      command.Parameters.Add("@Email", employees.Email);
      command.Parameters.Add("@Salary", employees.Salary);
      command.Parameters.Add("@Sex", employees.Sex);
      command.Parameters.Add("@TypeOfContract", employees.TypeOfContract);
      command.Parameters.Add("@RegistrationDate", employees.RegistrationDate);

      connection.Open();

      if (command.ExecuteNonQuery() > 0)
      {
        connection.Close();
        return true;
      }
      else
      {
        connection.Close();
        return false;
      }
    }

    [System.Obsolete]
    public static bool ToUpdateEmployee(Employees employees)
    {
      string sql = "UPDATE [Employees] SET Name = @Name, Email = @Email, Salary = @Salary, Sex = @Sex, TypeOfContract = @TypeOfContract, UpdateDate = @UpdateDate WHERE Id = @Id ";

      SqlCeCommand command = new SqlCeCommand(sql, connection);
      command.Parameters.Add("@Id", employees.Id);
      command.Parameters.Add("@Name", employees.Name);
      command.Parameters.Add("@Email", employees.Email);
      command.Parameters.Add("@Salary", employees.Salary);
      command.Parameters.Add("@Sex", employees.Sex);
      command.Parameters.Add("@TypeOfContract", employees.TypeOfContract);
      command.Parameters.Add("@UpdateDate", employees.UpdateDate);

      connection.Open();

      if (command.ExecuteNonQuery() > 0)
      {
        connection.Close();
        return true;
      }
      else
      {
        connection.Close();
        return false;
      }
    }

    [System.Obsolete]
    public static Employees PickUpEmployee(int id)
    {
      string sql = "SELECT * FROM [Employees] WHERE Id = @id";

      SqlCeCommand command = new SqlCeCommand(sql, connection);

      command.Parameters.Add("@Id", id);

      connection.Open();

      SqlCeDataReader response = command.ExecuteReader();

      Employees employees = new Employees();

      while (response.Read())
      {
        employees.Id = response.GetInt32(0);
        employees.Name = response.GetString(1);
        employees.Email = response.GetString(2);
        employees.Salary = response.GetDecimal(3);
        employees.Sex = response.GetString(4);
        employees.TypeOfContract = response.GetString(5);
        employees.RegistrationDate = response.GetDateTime(6);
      }

      connection.Close();

      return employees;
    }

    [System.Obsolete]
    public static bool DeleteEmployee(int id)
    {
      string sql = "DELETE FROM [Employees] WHERE Id = @id";

      SqlCeCommand command = new SqlCeCommand(sql, connection);

      command.Parameters.Add("@Id", id);

      connection.Open();

      if (command.ExecuteNonQuery() > 0)
      {
        connection.Close();
        return true;
      }
      else
      {
        connection.Close();
        return false;
      }
    }
  }
}

