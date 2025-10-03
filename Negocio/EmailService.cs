using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class EmailService
    {
        private MailMessage email;
        private SmtpClient server;


        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("69c56aff64628d", "****bd0e");
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "sandbox.smtp.mailtrap.io";
        }

        public void armarCorreo(string emailDestino)
        {
            
                email = new MailMessage();
                email.From = new MailAddress("noresponder@ecommercepremiosganaya.com");
                email.To.Add(emailDestino);
                email.IsBodyHtml = true;
                email.Body = "<h1> Felicidades </h1>" +
                             "<p>Has ganado un premio en nuestra plataforma .</p>" +
                             "<p>Atentamente,</p>" +
                             "<p>El equipo de E-commerce Premios Ganaya</p>";

           
        }

        public void enviarEmail()
        {

            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
