using Google.Api.Ads.Common.Lib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace TestApplication.Common.Utilities
{
    public class BuildConnectionString : IBuildConnectionString
    {
        #region Variable and property declaration
        /// <summary>
        /// properties
        /// </summary>
        IOptions<AppConfig> _config { get; set; }
        private IConfigurationRoot _configurationRoot;
        #endregion


        #region Constructor
        /// <summary>
        /// Initialize App settings
        /// </summary>
        /// <param name="config"></param>
        /// <param name="configurationRoot"></param>
        public BuildConnectionString(IConfigurationRoot configurationRoot, IOptions<AppConfig> config)
        {
            this._config = config;
            this._configurationRoot = configurationRoot;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Prepared connection string
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public string PreparedConnection(string tenantDB)
        {
            string connectionString = _configurationRoot.GetConnectionString("TenantDBConnection");
            string databaseName = string.Empty;
            if (!string.IsNullOrWhiteSpace(tenantDB))
            {
                databaseName = tenantDB;
                //databaseName = DatabaseIsOnline(organizationName);
                if (!string.IsNullOrWhiteSpace(databaseName))
                {
                    string[] splitConnectionString = connectionString.Split(";");
                    for (int index = 0; index < splitConnectionString.Length; index++)
                    {
                        if (splitConnectionString[index].Contains("Initial Catalog"))
                        {
                            splitConnectionString[index] = "Initial Catalog=" + databaseName;
                            break;
                        }
                    }



                    connectionString = string.Join(";", splitConnectionString);
                    return connectionString;
                }
            }

            return connectionString;
        }


        /// <summary>
        /// Check for Database against organization
        /// </summary>
        /// <param name="server"></param>
        /// <param name="DataBaseName"></param>
        /// <returns></returns>
        private string DatabaseIsOnline(string organizationName)
        {
            string databaseName = string.Empty;
            try
            {
                string[] orgNameArray = organizationName.Split('.');
                organizationName = organizationName.Replace((string)("." + orgNameArray.GetValue(orgNameArray.Length - 1)), null);
                //databaseName = _config.Value.ShardDatabaseName.Replace(_config.Value.MsSqlPrototypeDb, organizationName.Replace(organizationName.Split('.')[0] + '.', null));
            }
            catch (Exception ex)
            {
                databaseName = string.Empty;
            }
            return databaseName;
        }
        #endregion
    }
}
