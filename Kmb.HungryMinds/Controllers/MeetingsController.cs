using Kmb.HungryMinds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kmb.HungryMinds.Controllers
{
    public class MeetingsController : CrudController<IMeetingRepository, Meeting>
    {
        public MeetingsController() : base(new MeetingRepository())
        {

        }

    }
}
