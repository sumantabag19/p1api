using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EVA.Contract
{
    public class Parameters
    {
        public string ParameterName { get; set; }
        //public string Value { get; set; }
        public string ParamKey { get; set; }
        public ParameterDirection ParameterDirection { get; set; }
        public SqlDbType ParameterType { get; set; }
        public Object Value { get; set; }
        public Parameters()
        {

        }
        public Parameters(string paramKey, object value)
        {
            ParamKey = paramKey;
            Value = value;
            ParameterDirection = ParameterDirection.Input;
        }
        public Parameters(string paramKey, object value, ParameterDirection parameterDirection)
        {
            ParamKey = paramKey;
            Value = value;
            ParameterDirection = parameterDirection;
        }
    }
}
