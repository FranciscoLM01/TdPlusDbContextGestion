using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class Result<T>
    {
        public Result(T data, bool succeeded, string errorCode, string errorMessage)
        {
            Data = data;
            Succeeded = succeeded;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public bool Succeeded { get; set; }
        public T Data { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
