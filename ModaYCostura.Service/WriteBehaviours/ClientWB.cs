using ModaYCostura.Data;
using ModaYCostura.Model.DTO;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;
using Npgsql;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class ClientWB : WriteBehaviour<Client>
    {
        public ClientWB(DefaultContext context) : base(context) { }

        private bool ClientExists(string phone)
        {
            return _context.Clients.Where(c => c.Phone == phone).Any();
        }


        public override IApiResponse<Client> Add(Client client)
        {
            if (ClientExists(client.Phone)) return new ApiFail<Client>("P01");
            client.LastUpdate = DateTime.Now;
            return base.Add(client);
        }

        public override IApiResponse<Client> Update(Client client)
        {
            try
            {
                if (ClientExists(client.Phone)) return new ApiFail<Client>("P01");
                client.LastUpdate = DateTime.Now;
                return base.Update(client);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is PostgresException exception)
                {
                    return new ApiFail<Client>($"SQLCode: {exception.SqlState}");
                }
                return new ApiFail<Client>(ex.Message);
            }
        }
    }
}