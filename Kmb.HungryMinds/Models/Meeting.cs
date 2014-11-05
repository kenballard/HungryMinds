using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kmb.HungryMinds.Models
{
    public class Meeting : IdentifiedModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}