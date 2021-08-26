using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Iaf.API.DTO.IDM
{
    public class IdmRackDetailDTO
    {
        public int Id { get; set; }
        public string RackRow { get; set; }
        public string RackColumnOne { get; set; }
        public string RackColumnTwo { get; set; }
        public string RackColumnThree { get; set; }
        public string RackColumnFour { get; set; }
        public string RackColumnFive { get; set; }
        public string RackColumnSix { get; set; }
        public string RackColumnSeven { get; set; }
        public string RackColumnEight { get; set; }
        public string RackColumnNine { get; set; }
        public string RackColumnTen { get; set; }
        public string RackColumnEleven { get; set; }
        public string RackColumnTwelve { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }  
        public IdmRackDTO IdmRack { get; set; }
        public int IdmRackId { get; set; }           
    }
}