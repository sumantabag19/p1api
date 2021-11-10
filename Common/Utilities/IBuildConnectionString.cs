using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication.Common.Utilities
{
    /// <summary>
    /// Implement the insterface for build connection string
    /// </summary>
    public interface IBuildConnectionString
    {
        /// <summary>
        /// Prepared Connection stirng 
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        string PreparedConnection(string databaseName);
    }
}
