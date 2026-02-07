namespace CRUD.Models.Dtos
{
    public class OrderUpdateDto
    {
        //public int OrderId { get; set; }

        //public string CustomerId { get; set; }

        //public int? EmployeeId { get; set; }

        //public DateTime? OrderDate { get; set; }

    
        public int? ShipVia { get; set; } //出貨方式

        public decimal? Freight { get; set; }  //出貨金額

        public string ShipName { get; set; } //收件人名稱

        public string ShipAddress { get; set; } //出貨地址

        public string ShipCity { get; set; } //出貨城市

        public string ShipRegion { get; set; } //出貨地區

        public string ShipPostalCode { get; set; } //郵遞區號

        public string ShipCountry { get; set; }//出貨國家

        public DateTime? RequiredDate { get; set; } //客戶要求出貨日期

        public DateTime? ShippedDate { get; set; } //實際出貨日期

    }
}
