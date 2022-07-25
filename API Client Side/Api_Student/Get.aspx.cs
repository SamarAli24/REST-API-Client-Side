using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Api_Student
{
    public partial class Get : System.Web.UI.Page
    {
        string Geturl = "http://localhost/studentApi/WebService2.asmx/getAllStudent";
        List<student> studentlist = new List<student>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void display(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {

                string json = webClient.DownloadString(Geturl);
                studentlist = JsonConvert.DeserializeObject<List<student>>(json);

                tb.Text = @"<table class='myTable'>
                               <tr>
                                  <th>ID</th>
                                  <th>NAME</th>
                                  <th>COURSE</th>
                                  <th>MARKS</th>
                               </tr>";

                foreach (student s in studentlist)
                {
                    tb.Text += "<tr>";
                    tb.Text += "<td>" + s.SId + "</td>";
                    tb.Text += "<td>" + s.Sname + "</td>";
                    tb.Text += "<td>" + s.Scourse + "</td>";
                    tb.Text += "<td>" + s.Smarks + "</td>";
                    tb.Text += "<tr>";
                }
                tb.Text += "</table>";

            }

        }

    }
}