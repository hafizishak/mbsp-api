using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Iaf.API.Models.WSFCS
{
    [Table("tnr_carrier_grouping")]
    public class TnrCarrierGrouping
    {
        [Key]
        public string die_class_code { get; set; }
        public string grouping_code { get; set; }
        public string color_code { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_on { get; set; }       
        public string die_class_parent_code { get; set; }
    }
}

