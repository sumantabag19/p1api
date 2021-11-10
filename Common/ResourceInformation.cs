using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace TestApplication.Common.Helper
{
    public static class ResourceInformation
    {
        /// <summary>
        /// This method is used to get the resource string value by name
        /// </summary>
        /// <param name="name">name of the string</param>
        /// <returns></returns>
        public static string GetResourceValue(string name)
        {
            var rm = new ResourceManager("EVA.Common.BaseMessages", System.Reflection.Assembly.GetExecutingAssembly());
            return rm.GetString(name);
        }
    }

}
