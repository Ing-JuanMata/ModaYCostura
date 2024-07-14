using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using Npgsql;

namespace ModaYCostura.Service.Utils
{
    public class WriteBehaviour<T> where T : class
    {
        protected readonly DefaultContext _context;
        public WriteBehaviour(DefaultContext context)
        {
            _context = context;
        }

        public virtual IApiResponse<T> Add(T data)
        {
            var newData = _context.Add(data).Entity;
            _context.SaveChanges();
            return new ApiSuccess<T>(newData);
        }

        public virtual IApiResponse<T> Update(T data)
        {
            try
            {
                _context.Update(data);
                _context.SaveChanges();
                return new ApiSuccess<T>(data);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<T>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<T>(ex.Message);
            }
        }
    }
}
