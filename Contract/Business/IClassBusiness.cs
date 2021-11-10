using EVA.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Common.Utilities.ResponseExtension;
using TestApplication.Dto.Student;

namespace TestApplication.Contract.Business
{
    public interface IClassBusiness
    {
        IUnitOfWork UnitOfWork { get; set; }
        Task<BaseResponse<ClassMasterAddDto>> Add(ClassMasterAddDto classAdd);
        Task<BaseResponse<List<ClassMasterAddDto>>> GetAll();
        Task<BaseResponse<ClassMasterAddDto>> Get(long id);



    }
}
