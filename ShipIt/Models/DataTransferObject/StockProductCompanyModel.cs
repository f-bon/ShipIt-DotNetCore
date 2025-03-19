using System.Data;

namespace ShipIt.Models.DataTransferObject
{
    public class StockProductCompanyModel
    {
        // Stock
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int held { get; set; }


        // Company - GCP
        public string Gcp { get; set; }
        public string GcpName { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        
        //product
        public int Id { get; set; }
        public string Gtin { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int LowerThreshold { get; set; }
        public bool Discontinued { get; set; }
        public int MinimumOrderQuantity { get; set; }
       
        public StockProductCompanyModel(IDataReader dataReader): base(dataReader) { }
        public StockProductCompanyModel() {}
    }
}