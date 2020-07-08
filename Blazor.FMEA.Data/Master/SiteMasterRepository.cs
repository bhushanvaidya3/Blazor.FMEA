using Blazor.FMEA.Shared.Common;
using Blazor.FMEA.Shared.Models.Master;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Blazor.FMEA.Data.Master
{
    public class SiteMasterRepository : ISiteMasterRepository
    {
        private string FMEADBConnectionstring = "Data Source=VirtualDopey;database=FMEA; uid=Carsuper; pwd=Supercar";

        private int FMEADBTimeout { get; } = 300;

        public IEnumerable<SiteMasterDO> GetAll()
        {
            List<SiteMasterDO> siteMaster = new List<SiteMasterDO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(FMEADBConnectionstring))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "FMEA_SP_GetAllSiteMasterRecords";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandTimeout = FMEADBTimeout;

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            SiteMasterDO sMaster = new SiteMasterDO()
                            {
                                Site_Number = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Site_Number)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Site_Number)),
                                Site_Abbr = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Site_Abbr)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Site_Abbr)),
                                Site_Desc = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Site_Desc)) ? null : reader.GetString(reader.GetOrdinal(FMEAConstants.Site_Desc)),
                                Site_Operational = reader.IsDBNull(reader.GetOrdinal(FMEAConstants.Site_Operational)) ? (Boolean?)null : reader.GetBoolean(reader.GetOrdinal(FMEAConstants.Site_Operational)),
                            };
                            siteMaster.Add(sMaster);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return siteMaster;
        }
    }
}
