using System.Data;
using ShipIt.Models.DataModels;


namespace ShipIt.Models.DataTransferObject
{
    public class StockProductCompanyModel : DataModel
    {
        public StockDataModel stockDataModel;
        public CompanyDataModel companyDataModel;
        public ProductDataModel productDataModel;

        public StockProductCompanyModel(IDataReader dataReader) { 
            stockDataModel = new StockDataModel(dataReader);
            companyDataModel = new CompanyDataModel(dataReader);
            productDataModel = new ProductDataModel(dataReader);

        }
        public StockProductCompanyModel() {}
    }
}