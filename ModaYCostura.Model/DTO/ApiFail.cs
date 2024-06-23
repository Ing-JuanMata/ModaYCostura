using ModaYCostura.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaYCostura.Model.DTO
{
    public class ApiFail<T> : IApiResponse<T>
    {
        public ApiFail() { }
        public ApiFail(string message)
        {
            Message = message;
        }
        public bool Success { get; set; } = false;
        public T Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string> Messages { get; set; } = new();
    }
}
