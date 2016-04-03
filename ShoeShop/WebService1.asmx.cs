using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ShoeShop.App_Data;
namespace ShoeShop
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataClasses1DataContext db = new DataClasses1DataContext();   
        [WebMethod]
        public List<Menu> getMenu()
        {
            var menu = db.Menus;
            List<Menu> lst = new List<Menu>();
            if (menu.Count() > 0)
            {
                foreach (var i in menu)
                {
                    lst.Add(i);
                }
            }
            else
            {
                lst = null;
            }
            
            return lst;
        }
        
    }
}
