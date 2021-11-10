using EVA.Contract;
using EVA.Contract.Infrastructure;
using EVA.Contract.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Dto.Student;
using TestApplication.Models;

namespace TestApplication.Contract.Repository
{
    public interface IClassRepository: ISelectService<ClassMaster>, IDeleteByGuid<ClassMaster>, IUpdateByGuid<ClassMaster>, ISelectFirstOrDefaultService<ClassMaster>
    {
        IUnitOfWork UnitOfWork { get; set; }
        Task<ClassMasterAddDto> Add(ClassMasterAddDto classAdd);
        Task<List<ClassMaster>> GetAllHeader();
        Task<ClassMaster> Get(long id);


    }
}
