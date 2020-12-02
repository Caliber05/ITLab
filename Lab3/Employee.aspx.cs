using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3Question1
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<String> IDs = new List<string>() { "170905079", "170905078", "170905077", "170905076" };
                EmployeeIDList.DataSource = IDs;
                EmployeeIDList.DataBind();
            }
            
        }

        protected void EligibleButtonClick(object sender, EventArgs e)
        {
            DateTime enteredDate = DateTime.Parse(DOJTextBox.Text); ;
            DateTime today = DateTime.Now.Date;
            if (enteredDate.AddYears(5) <= today)
                ResponseLabel.Text = "Eligible";
            else
                ResponseLabel.Text = "Not Eligible";
        }
        protected void EmployeeSelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeImage.ImageUrl = "/images/" + EmployeeIDList.SelectedItem.Value + ".jpg";
   
        }

    }
}
