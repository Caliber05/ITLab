using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3Question1
{
    public partial class Captcha : System.Web.UI.Page
    {

        public static int failed = 0;
        string solution = "nvhoxdm";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaptchaImage.ImageUrl = "/images/captcha1.png";
            }
        }

        protected void CaptchaSubmiatClicked(object sender, EventArgs e)
        {

            string answer = CaptchaResponseTextBox.Text;
            if (answer.Equals(solution))
            {
                ResponseLabel.Text = "Valid!";
                failed = 0;
            }
            else
            {
                failed += 1;
                if(failed >= 3)
                {
                    CaptchaResponseTextBox.Enabled = false;
                    ResponseLabel.Text = "Invalid Captcha entered 3 times.<br/ >Disabling Input Field!";
                }
                else
                {
                    ResponseLabel.Text = "Invalid Captcha!";
                }
            }
                
        }
        
    }
}
