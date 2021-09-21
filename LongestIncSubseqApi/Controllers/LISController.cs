using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LongestIncSubseqApi.Controllers
{
    public class LISController : Controller
    {

        private readonly ILogger<LISController> _logger;

        public LISController(ILogger<LISController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string GetLongestIncSubseq([FromBody] string inputValues)
        {
            LIS objLongIncSubseq = new LIS();
            // Validating the User input for Digits and spaces only
            Regex rgx = new Regex(@"^[\d\s]+$");
            

            if (!String.IsNullOrEmpty(inputValues) && rgx.IsMatch(inputValues))
            {
                  objLongIncSubseq.LISFlow(inputValues);
                
            }
            else
            {
                
            }
            return objLongIncSubseq.output;
        }
    }
}
