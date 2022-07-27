﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2
{
    public partial class Assignment_part2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator2.MaximumValue = DateTime.Today.ToShortDateString();
            RangeValidator2.MinimumValue = DateTime.Today.ToShortDateString();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Save.html");
            }
            else
            {
                Response.Write("ERROR OCCURED");
            }
        }
    }
}