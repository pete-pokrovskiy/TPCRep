using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using TPC.Web.Infrastructure;
using TPC.Web.Infrastructure.Filters;
using TPC.Web.ViewModels;

namespace TPC.Web.Controllers
{
    
    public class HomeController : Controller
    {
        [UnderConstructionFilter]
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult UnderConstruction()
        {
            return View();
        }

        public JsonResult SendMessage(MessageViewModel messageVm)
        {
            //TODO: создать запись в базе

            //TODO: Отправить сообщение получателям

            SmtpClient client = new SmtpClient(ConfigSettings.Instance.SmptpServer);

            MailMessage message = new MailMessage("robot@tpc.ru", messageVm.Email);

            message.Body = string.Format("{0} sent message: {1}", messageVm.Name, messageVm.Message);

            client.Send(message);

            return Json(true);
        }

        public ActionResult TestPortfolio()
        {
            return View("PortfolioPages/TestItem");
        }
    }
}