using System;
using System.Collections.Generic;

namespace TestApplication.Common.Utilities.ResponseExtension
{

    public class BaseResponse<T>
    {

        /// <summary>
        /// Code for the success or failure
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Message represent the code.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// To tell UI if the call to the service is successful or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Rows affected from the completion of the operation. Default is zero; and if Success is false
        /// </summary>
        public long RecordsAffected { get; set; }

        /// <summary>
        /// Additional data
        /// </summary>
        public Dictionary<string, object> OutputData { get; set; }

    }
    public static class BaseResposneExtension
    {

        public static BaseResponse<T> Success<T>(this BaseResponse<T> value, T data, ResponseEnum responseEnum)
        {
            return new BaseResponse<T>
            {
                Success = true,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                Data = data,
            };
        }
        public static BaseResponse<T> Success<T>(this BaseResponse<T> value, T data, ResponseEnum responseEnum, long recordsAffected)
        {
            return new BaseResponse<T>
            {
                Success = true,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                Data = data,
                RecordsAffected = recordsAffected
            };
        }
        public static BaseResponse<T> Success<T>(this BaseResponse<T> value, T data, ResponseEnum responseEnum, long recordsAffected, Dictionary<string, object> outputData)
        {
            return new BaseResponse<T>
            {
                Success = true,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                Data = data,
                RecordsAffected = recordsAffected,
                OutputData = outputData
            };
        }
        public static BaseResponse<T> Failure<T>(this BaseResponse<T> value, string message)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Code = -1,
                Message = message
            };
        }
        public static BaseResponse<T> Failure<T>(this BaseResponse<T> value, ResponseEnum responseEnum)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription()
            };
        }
        public static BaseResponse<T> Failure<T>(this BaseResponse<T> value, T data, ResponseEnum responseEnum)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                Data = data
            };
        }
        public static BaseResponse<T> Failure<T>(this BaseResponse<T> value, ResponseEnum responseEnum, Dictionary<string, object> outputData)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                OutputData = outputData
            };
        }
        public static BaseResponse<T> Failure<T>(this BaseResponse<T> value, T data, ResponseEnum responseEnum, Dictionary<string, object> outputData)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Code = (int)responseEnum,
                Message = responseEnum.GetDescription(),
                Data = data,
                OutputData = outputData
            };
        }
    }
}
