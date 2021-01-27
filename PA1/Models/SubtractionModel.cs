using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PA1.Models
{
    public class SubtractionModel
    {
        [Range(-9999999999999, 9999999999999)]
        public float Minuend { get; set; }
        [Range(-9999999999999, 9999999999999)]
        public float Subtrahend { get; set; }
    }
}