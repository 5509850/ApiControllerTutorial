using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ApiControllerTutorial.Models;

namespace ApiControllerTutorial.Controllers
{
    public class TopicController : ApiController
    {
        public ICollection<Topic> Get()
        {
            return new Collection<Topic>
                       {
                           new Topic { Id = 1, Title = "Топик 1"},
                           new Topic { Id = 2, Title = "Топик 2"}
                       };
        } 

        public Topic Get(int id)
        {
            return new Topic
                       {
                           Id = id,
                           Title = String.Format("Топик {0}", id)
                       };
        }

        public HttpResponseMessage Put(Topic model)
        {
            if(String.IsNullOrEmpty(model.Title))
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            /*Логика сохранения*/

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public string Delete(int id)
        {
            return String.Format("Топик {0} удален!", id);
        }
    }
}