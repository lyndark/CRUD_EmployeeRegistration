using System;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using Win02.DataBase;
using System.ComponentModel;

namespace WindowsFormsApp
{
  public partial class EmployeeRegistration : Form
  {
    private Form1 form1;
    private Employees emp;

    public EmployeeRegistration(Form1 mainScreen)
    {
      form1 = mainScreen;
      InitializeComponent();
    }

    [Obsolete]
    public EmployeeRegistration(Form1 mainScreen, int Id)
    {
      form1 = mainScreen;
      InitializeComponent();


      emp = EmployeeDataAccess.PickUpEmployee(Id);
      EmployeeForScreen(emp);
    }

    private void EmployeeForScreen(Employees employees)
    {
      txtName.Text = employees.Name.Trim();
      txtEmail.Text = employees.Email.Trim();
      txtSalary.Text = employees.Salary.ToString();


      if (employees.Sex == "M")
      {
        rbMale.Checked = true;
      }
      else
      {
        rbFemale.Checked = true;
      };

      if (employees.TypeOfContract == "CLT")
      {
        rbCLT.Checked = true;
      }
      else if (employees.TypeOfContract == "PJ")
      {
        rbPJ.Checked = true;
      }
      else
      {
        rbAutonomous.Checked = true;
      }
    }

    [Obsolete]
    private void btnSave_Click(object sender, EventArgs e)
    {
      Employees employees = new Employees();

      if (emp != null)
      {
        employees = emp;
        employees.UpdateDate = DateTime.Now;
      }
      else
      {
        employees = new Employees();
        employees.RegistrationDate = DateTime.Now;
      }

      employees.Name = txtName.Text.Trim();
      employees.Email = txtEmail.Text.Trim();
      employees.Salary = decimal.Parse(txtSalary.Text);
      employees.Sex = (rbMale.Checked) ? "M" : "F";
      employees.TypeOfContract = (rbCLT.Checked) ? "CLT" : (rbPJ.Checked) ? "PJ" : "AUT";

      List<ValidationResult> listErrors = new List<ValidationResult>();
      ValidationContext validationContext = new ValidationContext(employees);
      bool validated = Validator.TryValidateObject(employees, validationContext, listErrors, true);

      if (validated)
      {
        bool result;
        if (emp != null)
        {
          result = EmployeeDataAccess.ToUpdateEmployee(employees);
        }
        else
        {
          result = EmployeeDataAccess.SaveEmployee(employees);
        }

        if (result)
        {
          form1.UpdateTable();
          this.Close();
        }
        else
        {
          lblErrors.Text = "Erro na inserção de dados";
        }
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (ValidationResult validationResult in listErrors)
        {
          stringBuilder.Append(validationResult.ErrorMessage + "\n");
        }

        lblErrors.Text = stringBuilder.ToString();
      }
    }
  }
}
