using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIIFMFv2_FE.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int error = 0, string message = "")
        {
            switch (error)
            {
                case 000:
                    ViewBag.Title = "";
                    ViewBag.Description = "";
                    break;

                // Errores 400 
                /* error 404. Es uno de los códigos de estado HTTP más populares, lamentablemente, y 
                 * significa que la página que has escrito en la barra de direcciones no existe. Pero hay más.
                 * Los errores 4xx significan que el cliente ha errado la petición al servidor, 
                 * bien porque has escrito mal la dirección o por un problema de tu navegador o de tu conexión a 
                 * internet. Veamos los códigos más populares.*/
                case 400:
                    ViewBag.Title = "400 Bad Request";
                    ViewBag.Description = "La solicitud contiene sintaxis errónea.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 401:
                case 403:
                    ViewBag.Title = "401 Unauthorized / 403 Forbidden";
                    ViewBag.Description = "Cuando intentas acceder a una página web mediante usuario y contraseña pero no tienes permisos suficiente para ello.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 404:
                    ViewBag.Title = "404 Not Found";
                    ViewBag.Description = " Recurso no encontrado. O bien tecleaste mal la dirección o bien esa página fue eliminada del servidor donde estaba alojada.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 408:
                    ViewBag.Title = "408 Request Timeout";
                    ViewBag.Description = "Suele ocurrir al demorarse la petición de acceso a una página.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 410:
                    ViewBag.Title = "410 Gone";
                    ViewBag.Description = "El recurso solicitado no está disponible. Sirve cuando se ha eliminado un elemento, pero habitualmente vemos más el código 404.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 451:
                    ViewBag.Title = "451 Unavailable for Legal Reasons";
                    ViewBag.Description = "El contenido fue eliminado a petición judicial o como consecuencia de la sentencia de un tribunal.";
                    ViewBag.ErrorServidor = message;
                    break;

                /* Errores de servidor: Error 500 en adelante
                 * Los errores 5xx tienen que ver con el servidor que hospeda las páginas web a las que queremos acceder. 
                 * Junto con los códigos de estado HTTP 4xx, son los que más vemos en nuestro navegador web.
                 */

                case 500:
                    ViewBag.Title = "500 Internal Server Error";
                    ViewBag.Description = "Cuando una aplicación o servicio no funcionan por motivos ajenos al servidor.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 501:
                    ViewBag.Title = "501 Not Implemented";
                    ViewBag.Description = "El servidor no soporta una funcionalidad necesaria para satisfacer la petición del cliente. Puede ocurrir con servidores antiguos o desactualizados.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 503:
                    ViewBag.Title = "503 Service unavailable";
                    ViewBag.Description = "El servidor no puede satisfacer la petición porque está congestionado (demasiadas peticiones) o está ocupado con tareas de mantenimiento.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 507:
                    ViewBag.Title = "507 Insufficient Storage";
                    ViewBag.Description = "Te lo puedes encontrar en un servidor privado cuando no hay espacio suficiente de almacenamiento.";
                    ViewBag.ErrorServidor = message;
                    break;
                case 509:
                    ViewBag.Title = "509 Bandwidth Limit Exceeded";
                    ViewBag.Description = "Parecido al anterior, tiene que ver con el ancho de banda empleado.";
                    ViewBag.ErrorServidor = message;
                    break;

                default:
                    ViewBag.Title = "Error desconocido";
                    ViewBag.Description = "Algo salio muy mal :( ..";
                    ViewBag.ErrorServidor = message;
                    break;
            }

            return View("~/views/error/_ErrorPage.cshtml");
        }
    }
}