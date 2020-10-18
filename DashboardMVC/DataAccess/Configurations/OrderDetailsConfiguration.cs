using DashboardMVC.DataAccess.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardMVC.DataAccess.Configurations
{
    public class OrderDetailsConfiguration : EntityConfiguration<OrderDetails>
    {
        public OrderDetailsConfiguration()
        {
            Property(o => o.Quatity).IsRequired();
        }
    }
}