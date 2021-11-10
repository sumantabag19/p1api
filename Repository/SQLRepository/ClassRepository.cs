using AutoMapper;
using EVA.Contract;
using EVA.Contract.Operations.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestApplication.Contract.Repository;
using TestApplication.Dto.Student;
using TestApplication.Models;

namespace TestApplication.Repository.SQLRepository
{
    public class ClassRepository : IClassRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IUnitOfWork UnitOfWork { get; set; }
        private readonly IMapper _mapper;


        public ClassRepository(IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;

        }

        public async Task<ClassMasterAddDto> Add(ClassMasterAddDto classAdd)
        {
            var strategy = UnitOfWork.DataContext.Database.CreateExecutionStrategy();
            try
            {
                var response = await strategy.ExecuteAsync(async () =>
                {
                    using (var transaction = UnitOfWork.DataContext.Database.BeginTransaction())
                    {




                        var reportGroupMaster = _mapper.Map<ClassMaster>(classAdd);
                        await UnitOfWork.DataContext.Set<ClassMaster>().AddAsync(reportGroupMaster);
                        await UnitOfWork.DataContext.SaveChangesAsync();
                        classAdd.ClassMasterId = reportGroupMaster.ClassMasterId;


                        transaction.Commit();
                        return classAdd;
                    }
                });
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
           
            return classAdd;
        }

        public Task<IList<ClassMaster>> SelectAsync(Expression<Func<ClassMaster, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteComplexDataById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateComplexData(long key, ClassMaster complexdata)
        {
            throw new NotImplementedException();
        }

        public Task<ClassMaster> FirstOrDefaultAsync(Expression<Func<ClassMaster, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ClassMaster>> GetAllHeader()
        {
            var DataFromDb = await UnitOfWork.DataContext.Set<ClassMaster>().AsNoTracking()
                                                   .ToListAsync();
            return DataFromDb;
        }

        public async Task<ClassMaster> Get(long id)
        {
            var DataFromDb = await UnitOfWork.DataContext.Set<ClassMaster>().AsNoTracking()
                                                  .FirstOrDefaultAsync(o => o.ClassMasterId == id);
            return DataFromDb;
        }
    }
}
