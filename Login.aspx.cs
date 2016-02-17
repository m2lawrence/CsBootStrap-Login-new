using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "m")
        {
            if (txtPassword.Text == "m")
            {
                //then do this:
                Response.Redirect("Default2.aspx");
            }
            else
            {
                lblError.Text = "try again.";
            }
        }
        else
        {
            //blank the label
            lblError.Text = "";
        }
    }
}