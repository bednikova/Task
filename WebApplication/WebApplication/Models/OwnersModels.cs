using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class OwnersModels
    {
        public int OwnersModelsId { get; set; }
        public string Description { get; set; }
        
        public int OwnersId { get; set; }
        public Owners Owners { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }


    }
}