using System.Windows.Forms;

namespace WindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      UpdateTable();
    }

    public void UpdateTable()
    {
      dgvEmployeeTable.DataSource = Win02.DataBase.EmployeeDataAccess.SearchEmployees();
    }

    private void btnNew_Click(object sender, System.EventArgs e)
    {
      new EmployeeRegistration(this).Show();
    }

    [System.Obsolete]
    private void btnToEdit_Click(object sender, System.EventArgs e)
    {
      int id = (int) dgvEmployeeTable.SelectedRows[0].Cells[0].Value;
      new EmployeeRegistration(this, id).Show();
    }

    [System.Obsolete]
    private void btnDelete_Click(object sender, System.EventArgs e)
    {
      int id = (int)dgvEmployeeTable.SelectedRows[0].Cells[0].Value;
      Win02.DataBase.EmployeeDataAccess.DeleteEmployee(id);
      UpdateTable();
    }
  }
}
