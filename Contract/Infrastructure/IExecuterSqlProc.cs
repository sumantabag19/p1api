using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace EVA.Contract.Operations.Repository
{
    /// <summary>
    /// Use this interface to execute stored procedures for complex data type
    /// </summary>
    /// <typeparam name="QueryEntity"></typeparam>
    public interface IExecuterSqlProc
    {
        IUnitOfWork uow { get; set; }
        /// <summary>
        /// Execute stored procedures for complex data type
        /// </summary>
        /// <param name="query">Procedure Name</param>
        /// <param name="sqlParam"></param>
        /// <returns></returns>
        //Task<List<ComplexEntity>> ExecuteProcedureAsync<T>(string procName, params T[] sqlParam) where T : class;



        /// <summary>
        /// Execute stored procedures for complex data type
        /// </summary>
        /// <param name="query">Procedure Name</param>
        /// <param name="sqlParam"></param>
        /// <returns></returns>
        Task<List<ComplexEntity>> ExecuteProcedureAsync<ComplexEntity>(string procName, IEnumerable<Parameters> sqlParam) where ComplexEntity : class;
        Task<int> ExceuteProcedureNonQueryAsync(string procName, IEnumerable<Parameters> Parameters = null);

      
        Task<List<List<dynamic>>> ExecuteMultipleResults(string procName, List<Microsoft.Data.SqlClient.SqlParameter> parameters, params Type[] types);

        /// <summary>
        /// Execute procedure using reader on databse to get record
        /// </summary>
        /// <param name="procName">Procedure Name</param>
        /// <returns></returns>
        Task<List<ComplexEntity>> ExecuteAsync<ComplexEntity>(string procName) where ComplexEntity : class;





    }
}
