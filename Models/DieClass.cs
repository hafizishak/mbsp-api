using System.ComponentModel.DataAnnotations;
using System;
using Iaf.API.Models;

namespace Iaf.API.Models
{
    public class DieClass
    {
        public string die_class_code { get; set; }
        public string die_class_description { get; set; }
        public string customer_code { get; set; }
        public string product_code { get; set; }        
    }
}