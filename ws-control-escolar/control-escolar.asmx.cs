using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ws_control_escolar
{
    /// <summary>
    /// Summary description for control_escolar
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class control_escolar : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]

        public string Mensajito_Para_Ti()
        {
            try
            {
                var correcta = "Eres Tu Fran?? si?? Te amooooo.";
                return correcta;
            }
            catch (Exception)
            {

                var error = "Lo siento no hay conexion... pero igual te amo.";
                return error;
            }
        }
    }
}
