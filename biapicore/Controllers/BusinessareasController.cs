using System;
using System.Collections.Generic;
using System.Linq;
using biapicore.Models;
using Microsoft.AspNetCore.Mvc;

namespace biapicore
{
    [Route("api/[controller]")]
    public class BusinessareasController : Controller
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(BusinessAreasDataStore.Current.BusinessAreas);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(string id)
        {
            BusinessAreasDTO businessArea = BusinessAreasDataStore.Current.BusinessAreas.FirstOrDefault(r => r.BusinessAreaCode == id);
            if (businessArea != null)
            {
                return Ok(businessArea);
            }
            else
            {
                return NotFound("Not Found");
            }

        }


    }
}
