using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace DashboardMVC.DataAccess.Entitites
{
    public class OrderDetails : IEntity
    {
        public int ID { get; set; }
        public int Quatity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}