using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Devtalk.EF.CodeFirst;

namespace juegosMVC.Models
{
    public class ContextInitializer
    {
        public static void Init()
        {
            Database.SetInitializer(new DontDropDbJustCreateTablesIfModelChanged<Context>());
        }
    }
}