﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atikerhakiki
{
    public partial class Arac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.TBLARACSBTableAdapter dt = new DataSet2TableAdapters.TBLARACSBTableAdapter();
            dt.AraçEkle(Convert.ToDateTime( TextBox1.Text),TextBox2.Text, TextBox3.Text, TextBox4.Text,TextBox5.Text);
        }
    }
}