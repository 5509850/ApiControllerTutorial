using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Http;
using ApiControllerTutorial.Models;

namespace ApiControllerTutorial.Controllers
{
    public class OdataController : ApiController
    {
        [Queryable]
        public IQueryable<Topic> Get()
        {
            return new
                EnumerableQuery<Topic>(
                new Collection<Topic>
                    {
                        new Topic{ Id = 1, Title = "1"},
                        new Topic{ Id = 2, Title = "2"},
                        new Topic{ Id = 3, Title = "3"},
                        new Topic{ Id = 4, Title = "4"},
                        new Topic{ Id = 5, Title = "5"}
                    });
        }
    }
}