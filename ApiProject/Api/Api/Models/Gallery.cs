using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Gallery
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string [] Images { get; set; }


    }
}