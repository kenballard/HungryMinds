using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kmb.HungryMinds.Models
{
    public abstract class IdentifiedModel
    {
        public int Id { get; set; }
    }
}