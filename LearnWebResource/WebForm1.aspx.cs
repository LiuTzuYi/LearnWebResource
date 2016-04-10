using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace LearnWebResource
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Page.ClientScript.RegisterClientScriptResource(typeof(LearnWebResource.WebForm1), "LearnWebResource.Resource.Y37.jpg");

            string resourceJPGURL=this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.Y37.jpg");
            string resourceGIFURL=this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.giraffe.gif");
            string resourcePNGURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.medical.png");
            string resourceICOURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.fyle.ico");
            string resourceBMPURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.05_ok.bmp");
            string resourceJavaScriptURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.js10.js");
            string resourceHTMLURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebREsource.Resource.HtmlPage1.html");

            this.Page.ClientScript.RegisterClientScriptInclude("myScript", resourceJavaScriptURL);


            ScriptManager.RegisterClientScriptResource( this, typeof(LearnWebResource.WebForm1), "LearnWebResource.Resource.js10.js");


            Response.Write(resourceHTMLURL);

            string resourceCSSURL = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.StyleSheet1.css");



            //this.Page.ClientScript.RegisterClientScriptInclude("LearnWebResource.Resource.js10.js", resourceJavaScriptURL);

            //ClientScriptManager cs = Page.ClientScript;
            //Type rsType = this.GetType();
            //cs.RegisterClientScriptInclude("MyScript", cs.GetWebResourceUrl(typeof(LearnWebResource.WebForm1), "LearnWebResource.Resource.js10.js"));
            


         

          
            //Response.Write(resourceJavaScriptURL);
            // Response.Write(resourceURL);
            //Image1.ImageUrl = resourceJPGURL;
            Image1.ImageUrl = resourceBMPURL;
            //Response.Write(resourceGIFURL);
            //Response.Write("---------------------------------------------------------");
            //Response.Write(resourceJPGURL);
            //Response.Write("---------------------------------------------------------");
            //Response.Write(resourcePNGURL);






            string link_template = "<link rel='stylesheet' text='text/css' href='{0}' />";
            string link_location = Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1), "LearnWebResource.Resource.StyleSheet1.css");
            LiteralControl ltlLink = new LiteralControl(String.Format(link_template, link_location));
            //((HtmlControl.HtmlHead)Page.Header).Controls.Add(ltlLink);
            this.Page.Controls.Add(ltlLink);

            HtmlAnchor a = new HtmlAnchor();
            a.HRef = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1), "LearnWebResource.Resource.HtmlPage1.html");
            a.InnerText = "HtmlPage1";
            this.Controls.Add(new LiteralControl("<br />"));
            this.Controls.Add(a);

            HtmlAnchor b = new HtmlAnchor();
            b.HRef = this.Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm1),"LearnWebResource.Resource.WebForm2.aspx");
            b.InnerText = "WebForm2.aspx";
            this.Controls.Add(new LiteralControl("<br/>"));
            this.Controls.Add(b);
        }
    }
}