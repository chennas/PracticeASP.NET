using System;
using System.Text;
using System.Web;
using System.Web.UI;

namespace GetClientLocation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetClientLocation();
            GetServerVariables();
        }

        private void GetServerVariables()
        {
            HttpContext context = HttpContext.Current;
            StringBuilder htmlContent = new StringBuilder();
            htmlContent.Append("<table border='2'><tbody>");
            htmlContent.Append("<th>");
            htmlContent.Append("ServerVariableName");
            htmlContent.Append("</th>");
            htmlContent.Append("<th>");
            htmlContent.Append("ServerVariableValue");
            htmlContent.Append("</th>");

            foreach (string item in context.Request.ServerVariables)
            {
                htmlContent.Append("<tr>");

                htmlContent.Append("<td>");
                htmlContent.Append(item);
                htmlContent.Append("</td>");

                htmlContent.Append("<td>");
                htmlContent.Append(context.Request.ServerVariables[item]);
                htmlContent.Append("</td>");

                htmlContent.Append("</tr>");
            }
            htmlContent.Append("</tbody>");
            htmlContent.Append("</table>");
            ServerVariables.InnerHtml = htmlContent.ToString();
        }

        /// <summary>
        /// Gets the client location.
        /// </summary>
        /// <returns></returns>
        private string GetClientLocation()
        {
            System.Web.HttpContext context = HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] address = ipAddress.Split(',');
                if (address.Length > 0)
                {
                    return address[0];
                }
            }
            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}