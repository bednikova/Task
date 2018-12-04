using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Model
    {
        public int ModelId { get; set; }

        public string Name { get; set; }

        public ICollection<OwnersModels> OwnersModels { get; set; }

    }
}