using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Devtalk.EF.CodeFirst;

namespace ventaMVC.Models
{
    public class ContextInitializer : DontDropDbJustCreateTablesIfModelChanged<Context>
    {
        public static void Init()
        {
            Database.SetInitializer(new DontDropDbJustCreateTablesIfModelChanged<Context>());

        }
    }
}