using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AssetDBWebApi.Models;

namespace AssetDBWebApi.Controllers
{
    public class DBContextHelper
    {
        private static AssetDBAzureSampleEntities db = new AssetDBAzureSampleEntities();

        public static AssetDBAzureSampleEntities Db
        {
            get { return db; }
            set { db = value; }
        }
    }
}