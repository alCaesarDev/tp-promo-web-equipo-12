using System;
using System.Net;
using System.Net.Mail;

namespace Negocio
{
    public class Notificador
    {
        private readonly string remitente = "agustins379@gmail.com";
        private readonly string claveApp = "cjkd zqmz iysr uwqo ";
        private readonly string remitenteNombre = "Premio Gana";

        public void Notificar(string correoDestino)
        {
            try
            {
                string asunto = $"🎉 ¡Felicidades! Ganaste!";
                string cuerpo = $@"
                    <html>
                        <body style='font-family: Arial, sans-serif;'>
                            <h2 style='color:#0078D7;'>¡Felicidades!</h2>
                            <p>
                                Te informamos que has sido uno de los ganadores de nuestra promocion!
                            </p>
                            <p>
                                En las proximas horas te contactaremos para coordinar la entrega.
                                Mientras tanto, te agradecemos por haber participado y formar parte de nuestra comunidad.
                            </p>
                            <p>
                                <b>¡Gracias por confiar en Promo Gana!</b><br/>
                                El equipo de Promo Gana
                            </p>
                        </body>
                    </html>
                ";

                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(remitente, remitenteNombre);
                mensaje.To.Add(correoDestino);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remitente, claveApp);
                smtp.EnableSsl = true;

                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar la notificación: " + ex.Message);
            }
        }
    }
}