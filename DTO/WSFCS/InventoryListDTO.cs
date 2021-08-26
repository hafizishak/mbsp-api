namespace Iaf.API.DTO.WSFCS
{
    public class InventoryListDTO
    {
        public string bisness_unit { get; set; }
        public string supplier_carrier_tape_pn { get; set; }
        public string Part_Number { get; set; }
        public string Description { get; set; }
        public string unit { get; set; }
        public string qty { get; set; }
        public string Machine_Running { get; set; }
        public string Reorder { get; set; }
        public string qty_in { get; set; }
        public string qty_out { get; set; }
    }
}