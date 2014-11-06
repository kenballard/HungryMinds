using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kmb.HungryMinds.Models
{
    public abstract class IdentifiedModel
    {
        public IdentifiedModel()
        {
            IsActive = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        private string _urlName = null;
        public string UrlName
        {
            get
            {
                _urlName = _urlName ?? HttpUtility.UrlEncode(Name.ToLower().Replace(' ', '-'));
                return _urlName;
            }
        }

        public bool IsActive { get; set; }
    }
}