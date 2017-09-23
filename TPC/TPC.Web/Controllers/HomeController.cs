using System.Net.Mail;
using System.Text;
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

            SmtpClient client = new SmtpClient(ConfigSettings.Instance.SmptpServer, int.Parse(ConfigSettings.Instance.SmptpPort));

            string subject = $"tpc.media - Получено новое сообщение";
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Имя: {messageVm.Name}");
            sb.AppendLine("<br/>");
            sb.AppendLine($"Почтовый адрес: {messageVm.Email}");
            sb.AppendLine("<br/>");
            sb.AppendLine("Текст сообщения:");
            sb.AppendLine("<br/>");
            sb.AppendLine(messageVm.Message);

            string to = ConfigSettings.Instance.IsTestMode
                ? ConfigSettings.Instance.TestRecipient
                : ConfigSettings.Instance.Recipient;


            MailMessage message = new MailMessage("robot@tpc.media", to);

            message.Subject = subject;
            message.Body = sb.ToString();

            message.IsBodyHtml = true;


            client.Send(message);

            return Json(true);
        }
    }
}