using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api
{
    public class FeedBack
    {
       
       
        public string name { get; set; }
        public string feedBack { get; set; }
        public int numberLike { get; set; }
        public string city { get; set; }
        public DateTime date { get; set; }
        
        
        
        public FeedBack()
        { }
        
        

        
    }
}