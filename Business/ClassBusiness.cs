using AutoMapper;
using EVA.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Common.Utilities.ResponseExtension;
using TestApplication.Contract.Business;
using TestApplication.Contract.Repository;
using TestApplication.Dto.Student;
using TestApplication.Models;

namespace TestApplication.Business
{
    public class ClassBusiness : IClassBusiness
    {

        #region Private Variable
        private readonly IClassRepository _ClassRepository;
        private readonly IConfigurationRoot _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ClassBusiness(IClassRepository classRepository, IConfigurationRoot configuration, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _ClassRepository = classRepository;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
          
        }
        #endregion

        public IUnitOfWork UnitOfWork
        {
            get { return _ClassRepository.UnitOfWork; }
            set
            {
                _ClassRepository.UnitOfWork = value;
            }
        }

       

        

       

        public async Task<BaseResponse<ClassMasterAddDto>> Add(ClassMasterAddDto classAdd)
        {
            BaseResponse<ClassMasterAddDto> response = new BaseResponse<ClassMasterAddDto>();
            ClassMasterAddDto reportGroupToReturn = new ClassMasterAddDto();



            reportGroupToReturn = await _ClassRepository.Add(classAdd);

            if (reportGroupToReturn == null)
                return response.Failure(ResponseEnum.Err_DataSaveFailed);

            return response.Success(reportGroupToReturn, ResponseEnum.Common_DataSaveMsg);



            return response.Success(reportGroupToReturn, ResponseEnum.Common_DataSaveMsg);
        }

        public async Task<BaseResponse<ClassMasterAddDto>> Get(long id)
        {
            BaseResponse<ClassMasterAddDto> response = new BaseResponse<ClassMasterAddDto>();
            var data = await _ClassRepository.Get(id);

            if (data == null)
                return response.Failure(ResponseEnum.Common_DataNotFound);

            var dataReturn = _mapper.Map<ClassMasterAddDto>(data);
            return response.Success(dataReturn, ResponseEnum.Common_DataFetchSuccess);
        }

        public async Task<BaseResponse<List<ClassMasterAddDto>>> GetAll()
        {
            BaseResponse<List<ClassMasterAddDto>> response = new BaseResponse<List<ClassMasterAddDto>>();
            var data = await _ClassRepository.GetAllHeader();

            if (data == null)
                return response.Failure(ResponseEnum.Common_DataNotFound);

            var dataReturn = _mapper.Map<List<ClassMasterAddDto>>(data);
            return response.Success(dataReturn, ResponseEnum.Common_DataFetchSuccess);
        }
    }
}
