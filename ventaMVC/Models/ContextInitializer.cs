using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ventaMVC.Models
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        public static void Init()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
    }
}