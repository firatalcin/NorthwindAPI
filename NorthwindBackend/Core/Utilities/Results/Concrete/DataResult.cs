using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; }

        public bool Success { get; }

        public string Message { get; }

        public DataResult(T data, bool success, string message)
        {
            Data = data;
            Success = success;  
            Message = message;
        }

        public DataResult(T data, bool success): this(data, success, null)
        {

        }


    }
}
