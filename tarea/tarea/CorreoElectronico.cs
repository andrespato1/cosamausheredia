using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace tarea
{
    class CorreoElectronico
    {
        /*
         * Atributos necesarios para enviar el correo electronico
         * asiendo uso de la libreria
         */
        MailMessage email = new MailMessage();
        SmtpClient webService = new SmtpClient();

        /*
         * METODO ENVIAR FACTURACION POR CORREO
         * Este metodo recibe el email del destinatario y ruta de la factura formato pdf para 
         * ser adjuntada al correo electronico
         */
        public void enviarFacturacionPorCorreoElectronico(string destinatario, string ruta){
            try{
                email.To.Clear();
                email.Body = "Estimado cliente por este medio se le envia la facturacion de su pedido. Gracias por preferirnos";
                email.Subject = "Facturacion de pedidos";
                email.IsBodyHtml = true;
                email.To.Add(destinatario.Trim());
                if (ruta != ""){
                     System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    email.Attachments.Add(archivo);
                 }
                email.From = new MailAddress("TrabajosUniversitariosTEC@gmail.com");
                webService.Credentials = new NetworkCredential("TrabajosUniversitariosTEC@gmail.com", "trabajosu1234567");
                webService.Host = "smtp.gmail.com";
                webService.Port = 587;
                webService.EnableSsl = true;
                webService.Send(email);
                MessageBox.Show("La facturacion del pedido a sido enviada por correo electronico");
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Fallo la facturacion del pedido intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
