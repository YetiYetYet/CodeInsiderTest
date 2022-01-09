using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BolloreTest.Controllers
{
    [Inspector]
    public class AvengersController : Controller
    {
        //Il est interdit de toucher au code ci-dessous !!!
        private class SincèreAttribute: Attribute { }
        private class MenteurAttribute : Attribute { }
        
        [Sincère]
        public string Thor()
        {
            return "Je me suis pris un marteau sur la tête";
        }

        [Menteur]
        public string Loki()
        {
            return "j'aime le vert, les animaux et le calme";
        }

        [Menteur]
        public string Ultron()
        {
            return "Je vais tous vous détruire";
        }

        [Sincère]
        public string IronMan()
        {
            return "J'aime foncer droit dans le mur";
        }

        [Sincère]
        public string CaptainAmerica()
        {
            return "Je defends mon pays quoiqu'il advienne de moi";
        }
    }
}