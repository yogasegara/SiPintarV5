using System.Collections.Generic;
using System.Linq;

namespace AppBusiness.Data.Responses
{
    public static class AppResponse
    {

        #region Field

        public static dynamic _result { get; set;}

        #endregion

        #region response for GET Method

        public static dynamic ResponseGetData( IEnumerable<dynamic> data)
        {
            _result = new System.Dynamic.ExpandoObject();
            _result.status = "success";
            _result.system_msg = data.Count() == 0 ? "Tidak Ada Data" : "";
            _result.ui_msg = data.Count() == 0 ? "Tidak Ada Data" : "";
            _result.record = data.Count();
            _result.data = data;
            return _result;
        }

        public static dynamic ResponseErrorGetData(string errorMsg)
        {
            _result = new System.Dynamic.ExpandoObject();
            _result.status = "error";
            _result.system_msg = errorMsg;
            _result.ui_msg = "";
            _result.record = 0;
            _result.data = null;
            return _result;
        }

        #endregion
    }
}
