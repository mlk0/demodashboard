using System.Linq;
using System.Web.Mvc;
using DashboardApp.Models;
using Newtonsoft.Json;

namespace DashboardApp.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      var db = new DashboardAppEntities();



      //var dashboardReport = new DashboardReport
      //{
      //  NewComments = db.Comments.Count(),
      //  NewTasks = db.Tasks.Count(),
      //  NewOrders = db.Orders.Count(),
      //  SupportTickets = db.SupportTickets.Count()
      //};

            var dashboardReportJsonString = @"{'NewComments':87,'NewTasks':27,'NewOrders':781,'SupportTickets':54}";
            var dashboardReport = JsonConvert.DeserializeObject<DashboardReport>(dashboardReportJsonString);

      ViewBag.Title = "Home";
      return View(dashboardReport);
    }
  }
}
