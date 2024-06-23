using ModaYCostura.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.DTO
{
    public class ApiSuccess<T> : IApiResponse<T>
    {
        public ApiSuccess(T data) => Data = data;

        public bool Success { get; set; } = true;
        public T Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string> Messages { get; set; } = new();
    }
}
