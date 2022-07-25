using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Api_Student
{
    public partial class WebForm1 : System.Web.UI.Page
    {

         
        string Posturl = "http://localhost/studentApi/WebService2.asmx/PostAllStudent";
        string Puturl = "http://localhost/studentApi/WebService2.asmx/PutAllStudent";
         string Deleteurl = "http://localhost/studentApi/WebService2.asmx/DeleteAllStudent";
        List<student> studentlist = new List<student>();



        public void SendJSON(string JSONtxt)
        {
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
            Context.Response.Flush();
            Context.Response.Write(JSONtxt);
 
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 
 
 
        protected void Post_btn(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                string SId = id.Text;
                    string Sname = name.Text;
                    string Scourse = course.Text;
                    string Smarks = marks.Text;


                Posturl +=  $"?SId= { SId} &Sname={Sname} &Scourse={Scourse}&Smarks={Smarks}";

                string resText = webClient.DownloadString(Posturl);

                Response.Write(resText);
                Response.Redirect("Get.aspx");



            }
        }

        protected void Put_btn(object sender, EventArgs e)
        {

            using (WebClient webClient = new WebClient())
            {
                string SId = id.Text;
                string Sname = name.Text;
                string Scourse = course.Text;
                string Smarks = marks.Text;

              

                Puturl +=  $"?SId= { SId} &Sname={Sname} &Scourse={Scourse}&Smarks='{Smarks}";
 

                string resText = webClient.DownloadString(Puturl);

                Response.Write(resText);
                Response.Redirect("Get.aspx");




            }


        }

        protected void Delete_btn(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                string SId = id.Text;



                Deleteurl += $"?SId=" + SId;

                string resText = webClient.DownloadString(Deleteurl);
                
                Response.Write(resText);
                Response.Redirect("Get.aspx");

 
        



            }
        }
    }
}




//studentlist = JsonConvert.DeserializeObject<List<student>>(json);
//foreach (student s in studentlist)
//{
//    s.SId = SId;

//    s.Sname = Sname;
//    s.Scourse = Scourse;
//    s.Smarks = Smarks;
//}




//tb.Text = @"<table class='myTable'>
//               <tr>
//                  <th>ID</th>
//                  <th>NAME</th>
//                  <th>COURSE</th>
//                  <th>MARKS</th>
//               </tr>";

//foreach (student s in studentlist)
//{
//    tb.Text += "<tr>";
//    tb.Text += "<td>" + s.SId + "</td>";
//    tb.Text += "<td>" + s.Sname + "</td>";
//    tb.Text += "<td>" + s.Scourse + "</td>";
//    tb.Text += "<td>" + s.Smarks + "</td>";
//    tb.Text += "<tr>";
//}
//tb.Text += "</table>";