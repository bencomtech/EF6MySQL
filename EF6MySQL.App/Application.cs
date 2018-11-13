using EF6MySQL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF6MySQL.App
{
    public class Application
    {
        public void Run()
        {
            using (MasterDataEntities db = new MasterDataEntities())
            {
                List<province> provinces = db.provinces
                    .Where(it => it.REGION_ID == "02")
                    .ToList();

                Console.WriteLine("Total: {0}", provinces.Count);
            }
        }
    }
}
