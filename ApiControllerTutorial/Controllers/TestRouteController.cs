using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ApiControllerTutorial.Models;

namespace ApiControllerTutorial.Controllers
{
    public class TestRouteController : ApiController
    {
        [ActionName("topic")]
        public string GetTopic(int id)
        {
            return String.Format("Topic {0}", id);
        }

        public string GetComment(int id)
        {
            return String.Format("Comment {0}", id);
        }
    }
}