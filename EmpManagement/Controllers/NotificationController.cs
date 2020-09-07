using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmpManagement.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Microsoft.AspNetCore.Authorization;

namespace EmpManagement.Controllers
{
    [Authorize(Roles = "Manager,Technical,Sales")]
    [Route("notification")]
    public class NotificationController : Controller
    {
        public AppDbContext db;
        public NotificationController(AppDbContext _db)
        {
            db = _db;
        }
        [Route("nextindex")]
        public IActionResult NextIndex()
        {
            return View();
        }
        [Route("index")]

        public IActionResult Index() { 
            int Count = db.AlternateEmployee.Select(u => u.Id).Count();
            while (true)
            {
                for (int i = 1; i <= Count; i++)
                {

                    DateTime date = db
             .AlternateEmployee
             .Where(u => u.Id == i)
             .Select(u => u.PassportDate)
             .SingleOrDefault();
                    DateTime a = DateTime.Now;
                    var diff = (a.Subtract(date)).TotalDays;
                    int newdiff = (int)diff;
                    var opp = (date.Subtract(a)).TotalDays;
                    int newopp = (int)opp;
                    //Do what ever you want to do all 10 Minutes




                    //Wait 10 minutes till next execution
                    /* DateTime nextStop = DateTime.Now.AddSeconds(diff);
                     var timeToWait = nextStop - DateTime.Now;
                     var millisToWait = timeToWait.TotalMilliseconds;
                     int miligun = Convert.ToInt32(millisToWait);
                     int miles = -miligun;
                     Thread.Sleep(miles);*/
                    string abc = db.AlternateEmployee.Where(u => u.Id == i).Select(u => u.EmailAddress).SingleOrDefault();
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Test", "hellstar4324@gmail.com"));

                    message.To.Add(new MailboxAddress("yo", abc));
                    message.Subject = "Passport Notification";
                    if (date < DateTime.Now)
                    {
                        string k = "Passport Renewal Date has passed :" + newdiff;
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }
                    else if (date > DateTime.Now)
                    {
                        string k = "Passport Renewal Date is near: " + newopp;
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }
                    else if (date == DateTime.Now)
                    {
                        string k = "Passport Renewal Date Today " ;
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }


                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("hellstar4324@gmail.com", "starhell");
                        client.Send(message);
                        client.Disconnect(true);
                    }


                }
                break;
            }return View();
        } 

    [Route("Salary")]

    public IActionResult Salary()
    {
        int Count = db.AlternateEmployee.Select(u => u.Id).Count();
        while (true)
        {
            for (int i = 1; i <= Count; i++)
            {

                DateTime date = db
         .AlternateEmployee
         .Where(u => u.Id == i)
         .Select(u => u.SalaryDate)
         .SingleOrDefault();
                DateTime a = DateTime.Now; var diff = (a.Subtract(date)).TotalDays;
                    int newdiff = (int)diff;
                    var opp = (date.Subtract(a)).TotalDays;
                    int newopp = (int)opp;
                    //Do what ever you want to do all 10 Minutes




                    //Wait 10 minutes till next execution
                    /* DateTime nextStop = DateTime.Now.AddSeconds(diff);
                     var timeToWait = nextStop - DateTime.Now;
                     var millisToWait = timeToWait.TotalMilliseconds;
                     int miligun = Convert.ToInt32(millisToWait);
                     int miles = -miligun;
                     Thread.Sleep(miles);*/
                    string abc = db.AlternateEmployee.Where(u => u.Id == i).Select(u => u.EmailAddress).SingleOrDefault();
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Test", "hellstar4324@gmail.com"));

                message.To.Add(new MailboxAddress("yo", abc));
                message.Subject = "Salary Notification";
                if (date < DateTime.Now)
                {
                    string k = "Salary Date Has Passed :  " + newdiff;
                    message.Body = new TextPart("plain")

                    {
                        Text = k
                    };
                }
                else if (date > DateTime.Now)
                {
                    string k = "Salary Date is near :"+newopp;
                    message.Body = new TextPart("plain")

                    {
                        Text = k
                    };
                }

                    else if (date == DateTime.Now)
                    {
                        string k = "Salary Date Today ";
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }

                    using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("hellstar4324@gmail.com", "starhell");
                    client.Send(message);
                    client.Disconnect(true);
                }


            }
            break;
        }
        return View();
    }


[Route("Medical")]

public IActionResult Medical()
{
    int Count = db.AlternateEmployee.Select(u => u.Id).Count();
    while (true)
    {
        for (int i = 1; i <= Count; i++)
        {

            DateTime date = db
     .AlternateEmployee
     .Where(u => u.Id == i)
     .Select(u => u.MedicalInsuranceDate)
     .SingleOrDefault();
            DateTime a = DateTime.Now; var diff = (a.Subtract(date)).TotalDays;
                    int newdiff = (int)diff;
                    var opp = (date.Subtract(a)).TotalDays;
                    int newopp = (int)opp;

                    //Do what ever you want to do all 10 Minutes




                    //Wait 10 minutes till next execution
                    /* DateTime nextStop = DateTime.Now.AddSeconds(diff);
                     var timeToWait = nextStop - DateTime.Now;
                     var millisToWait = timeToWait.TotalMilliseconds;
                     int miligun = Convert.ToInt32(millisToWait);
                     int miles = -miligun;
                     Thread.Sleep(miles);*/
                    string abc = db.AlternateEmployee.Where(u => u.Id == i).Select(u => u.EmailAddress).SingleOrDefault();
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test", "hellstar4324@gmail.com"));

            message.To.Add(new MailboxAddress("yo", abc));
            message.Subject = "Medical Insurance Notification";
            if (date < DateTime.Now)
            {
                string k = "Medical Insurance Date has passed : "+ newdiff;
                message.Body = new TextPart("plain")

                {
                    Text = k
                };
            }
            else if (date > DateTime.Now)
            {
                string k = "Medical Insurance Date is near"+ newopp;
                message.Body = new TextPart("plain")

                {
                    Text = k
                };
            }
                    else if (date == DateTime.Now)
                    {
                        string k = "Medical Insurance Date Today ";
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }


                    using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("hellstar4324@gmail.com", "starhell");
                client.Send(message);
                client.Disconnect(true);
            }


        }
        break;
    }
    return View();
}


        [Route("Timeline")]

        public IActionResult Timeline()
        {
            int Count = db.Timeline.Select(u => u.Id).Count();
            while (true)
            {
                for (int i = 1; i <= Count; i++)
                {

                    DateTime date = db
             .Timeline
             .Where(u => u.Id == i)
             .Select(u => u.Date)
             .SingleOrDefault();
                    DateTime a = DateTime.Now; var diff = (a.Subtract(date)).TotalDays;
                    int newdiff = (int)diff;
                    var opp = (date.Subtract(a)).TotalDays;
                    int newopp = (int)opp;

                    //Do what ever you want to do all 10 Minutes




                    //Wait 10 minutes till next execution
                    /* DateTime nextStop = DateTime.Now.AddSeconds(diff);
                     var timeToWait = nextStop - DateTime.Now;
                     var millisToWait = timeToWait.TotalMilliseconds;
                     int miligun = Convert.ToInt32(millisToWait);
                     int miles = -miligun;
                     Thread.Sleep(miles);*/
                    string abc = db.Timeline.Where(u => u.Id == i).Select(u => u.Email).SingleOrDefault();

                   string ghi = db.Timeline.Where(u => u.Id == i).Select(u => u.Event).SingleOrDefault();
                    DateTime xyz = db.Timeline.Where(u => u.Id == i).Select(u => u.Deadline).SingleOrDefault();
                    string def = db.Timeline.Where(u => u.Id == i).Select(u => u.Objective).SingleOrDefault();
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Test", "hellstar4324@gmail.com"));

                    message.To.Add(new MailboxAddress("yo", abc));
                    message.Subject = "Timeline Work";
                    if (xyz < DateTime.Now)
                    {
                        string k = "Deadline is passed";
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }
                    else if (xyz > DateTime.Now)
                    {
                        string k = "Deadline is near " + newopp;
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }
                    else if (xyz == DateTime.Now)
                    {
                        string k = def + "To be Done By" + xyz + "for " + ghi;
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }


                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("hellstar4324@gmail.com", "starhell");
                        client.Send(message);
                        client.Disconnect(true);
                    }


                }
                break;
            }
            return View();
        }
        [Route("Eida")]

public IActionResult Eida()
{
    int Count = db.AlternateEmployee.Select(u => u.Id).Count();
    while (true)
    {
        for (int i = 1; i <= Count; i++)
        {

            DateTime date = db
     .AlternateEmployee
     .Where(u => u.Id == i)
     .Select(u => u.EidaDate)
     .SingleOrDefault();
            DateTime a = DateTime.Now; var diff = (a.Subtract(date)).TotalDays;
                    int newdiff = (int)diff;
                    var opp = (date.Subtract(a)).TotalDays;
                    int newopp = (int)opp;
                    //Do what ever you want to do all 10 Minutes




                    //Wait 10 minutes till next execution
                    /* DateTime nextStop = DateTime.Now.AddSeconds(diff);
                     var timeToWait = nextStop - DateTime.Now;
                     var millisToWait = timeToWait.TotalMilliseconds;
                     int miligun = Convert.ToInt32(millisToWait);
                     int miles = -miligun;
                     Thread.Sleep(miles);*/
                    string abc = db.AlternateEmployee.Where(u => u.Id == i).Select(u => u.EmailAddress).SingleOrDefault();
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test", "hellstar4324@gmail.com"));

            message.To.Add(new MailboxAddress("yo", abc));
            message.Subject = "Eida Card Notification";
            if (date < DateTime.Now)
            {
                string k = "Eida Card Date has passed : "+ newdiff;
                message.Body = new TextPart("plain")

                {
                    Text = k
                };
            }
            else if (date > DateTime.Now)
            {
                string k = "Eida Card Date is near : " + newopp;
                message.Body = new TextPart("plain")

                {
                    Text = k
                };
            }
                    else if (date == DateTime.Now)
                    {
                        string k = "Eida Card Date Today ";
                        message.Body = new TextPart("plain")

                        {
                            Text = k
                        };
                    }


                    using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("hellstar4324@gmail.com", "starhell");
                client.Send(message);
                client.Disconnect(true);
            }


        }
        break;
    }
    return View();
} }


        }