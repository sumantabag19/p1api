using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EVA.Contract.Infrastructure
{
    public interface ISelectComplexQuery<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexData();

    }
    public interface ISelectComplexDataById<TEntity> where TEntity : class
    {
        Task<object> GetComplexDataById(int id);
    }

    public interface ISelectComplexSQLQuery<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexDataById(int id, string guid);
    }
    public interface ISelectGuid<TEntity> where TEntity : class
    {
        Task<object> GetComplexDataById(Guid id);
    }
    public interface ISelectComplexDataByQuery<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexDataByQuery(string query);
    }

    public interface IAddComplexQuery<TEntity> where TEntity : class
    {
        Task<int> AddComplexData(TEntity complexdata);
    }

    public interface IUpdateComplexQuery<TEntity> where TEntity : class
    {
        Task<int> UpdateComplexData(int key, TEntity complexdata);

    }
    public interface IDeleteComplexQuery<TEntity> where TEntity : class
    {
        Task<int> DeleteComplexData(TEntity complexdata);
    }
    public interface IDeleteComplexList<TEntity> where TEntity : class
    {
        Task<int> DeleteComplexList(IList<TEntity> complexList);
    }
    public interface IDeleteComplexDataById<TEntity> where TEntity : class
    {
        Task<int> DeleteComplexDataById(int id);
    }

    public interface IDeleteByGuid<TEntity> where TEntity : class
    {
        Task<bool> DeleteComplexDataById(Guid id);
    }

    public interface IUpdateByGuid<TEntity> where TEntity : class
    {
        Task<int> UpdateComplexData(long key, TEntity complexdata);

    }

    public interface IAddListComplexQuery<TEntity> where TEntity : class
    {
        Task<int> AddComplexData(IList<TEntity> complexdata);
    }

    public interface IPostGuidList<TEntity> where TEntity : class
    {
        Task<object> PostGuidList(IList<Guid> list);
    }


    public interface IGetGuidList<TEntity> where TEntity : class
    {
        Task<object> GetGuidList(IList<Guid> list);
    }

    public interface ISelectComplexQueryWithFlag<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetData(object prams, int flag = 1);

    }

    public interface IAddListComplexQueryWithFlag<TEntity> where TEntity : class
    {
        Task<int> AddData(IList<TEntity> complexdata, int flag = 1);
        Task<string> CheckRoleAccess(Guid roleId, string userId, string token, string applicationName, string entityApiUr);

    }

    public interface ISelectComplexListGuid<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexListDataById(Guid organizationId);
    }

    public interface ISelectComplexListByTenantId<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexListDataByTenantId(Guid tenantId, HttpContext httpContext);
    }

    public interface ISelectComplexListId<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetComplexListDataById(int id);
    }


    public interface IAddVirtualEquipmentTemplate<TEntity> where TEntity : class
    {
        Task<int> AddVirtualEquipmentTemplate(TEntity complexdata);
    }

    public interface IUpdateVirtualEquipmentTemplate<TEntity> where TEntity : class
    {
        Task<int> UpdateVirtualEquipmentTemplate(TEntity complexdata);

    }

    public interface IDeleteVirtualEquipmentTemplateById<TEntity> where TEntity : class
    {
        Task<int> DeleteVirtualEquipmentTemplate(int templateId);
    }
}
