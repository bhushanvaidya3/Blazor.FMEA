using Blazor.FMEA.Shared.Common;
using Blazor.FMEA.Shared.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Blazor.FMEA.Data.Master
{
    public class ProductMasterRepository : IProductMasterRepository
    {
        private string FMEADBConnectionstring = "Data Source=VirtualDopey;database=FMEA; uid=Carsuper; pwd=Supercar";

        private int FMEADBTimeout { get; } = 300;

        public IEnumerable<ProductMasterDO> GetAll()
        {
            List<ProductMasterDO> ProductMaster = new List<ProductMasterDO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_GetAllProductRecords";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ProductMasterDO pMaster = new ProductMasterDO()
                            {
                                Product_Class = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Product_Class)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Product_Class)),
                                Essex_Specification = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Essex_Specification)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Essex_Specification)),
                            };
                            ProductMaster.Add(pMaster);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ProductMaster;
        }

        public ProductMasterDO UpdateProductMaster(ProductMasterDO prodObj)
        {
            string site_op = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_UpdateProduct";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;
                        command.Parameters.AddWithValue("@Product_Class", prodObj.Product_Class);
                        command.Parameters.AddWithValue("@Essex_Specification", prodObj.Essex_Specification);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return prodObj;
        }

        public int DeleteProductMaster(string Product_Class)
        {
            using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_DeleteProductRecord";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;
                        command.Parameters.AddWithValue("@Product_Class", Product_Class);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return 1;
        }

        public ProductMasterDO CreateProductMaster(ProductMasterDO prodObj)
        {
            string site_op = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_InsertProductRecord";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;
                        command.Parameters.AddWithValue("@Product_Class", prodObj.Product_Class);
                        command.Parameters.AddWithValue("@Essex_Specification", prodObj.Essex_Specification);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return prodObj;
        }
    }
}
