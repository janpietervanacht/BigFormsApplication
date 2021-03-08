using Model.ConstantsAndEnums;
using System;

namespace BigFormsApplication.Extensions
{
    internal static class ExtensionInfra
    {
        public static string ToDutchDateFormat(this DateTime date)
        {
            return date.ToString("dd MMMM yyyy", Const.cCultureDutch); 
        }  
    }
}
