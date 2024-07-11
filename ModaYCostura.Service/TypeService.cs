using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using Npgsql;

namespace ModaYCostura.Service
{
    public class TypeService
    {
        private readonly DefaultContext _context;
        public TypeService(DefaultContext context) { _context = context; }

        public IApiResponse<IEnumerable<Model.Models.Type>> GetAll() => new ApiSuccess<IEnumerable<Model.Models.Type>>(_context.Types.ToList());

        public IApiResponse<Model.Models.Type> Add(Model.Models.Type type)
        {
            if (_context.Types.Where(p => p.Name == type.Name).Any()) return new ApiFail<Model.Models.Type>("P02");
            var newType = _context.Types.Add(type).Entity;
            _context.SaveChanges();
            return new ApiSuccess<Model.Models.Type>(newType);
        }

        public IApiResponse<Model.Models.Type> Update(Model.Models.Type type)
        {
            try
            {
                _context.Types.Update(type);
                _context.SaveChanges();
                return new ApiSuccess<Model.Models.Type>(type);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Model.Models.Type>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Model.Models.Type>(ex.Message);
            }
        }
    }
}
