using System;
using System.Collections.Generic;
using biapicore.Models;

namespace biapicore
{
    public class BusinessAreasDataStore
    {
        public static BusinessAreasDataStore Current { get; } = new BusinessAreasDataStore();

        public List<BusinessAreasDTO> BusinessAreas { get; set; }


        public BusinessAreasDataStore()
        {
            BusinessAreas = new List<BusinessAreasDTO>()
            {
                new BusinessAreasDTO
                {
                    BusinessAreaCode = "0510",
                    BusinessAreaName = "Bolivia"
                },
                new BusinessAreasDTO
                {
                    BusinessAreaCode = "0240",
                    BusinessAreaName = "Argentina"
                },
                new BusinessAreasDTO
                {
                    BusinessAreaCode = "0540",
                    BusinessAreaName = "Brazil"
                }
            };
        }
    }

}
