using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using K8SApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace K8SApi.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase{
        private IElementService _elementSvc;

        public ElementsController(IElementService elementSvc){
            this._elementSvc = elementSvc;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Element>> Get(){
//            return new string[] { "value1", "value2" };
            return Ok(_elementSvc.ElementList);
        }

        // GET api/values/5
        [HttpGet("version")]
        public ActionResult<string> GetVersion()
        {
            return "v2.1.6";
        }

    }
}
