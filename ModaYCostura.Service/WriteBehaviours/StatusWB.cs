using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class StatusWB : WriteBehaviour<Status>
    {
        public StatusWB(DefaultContext context) : base(context)
        {
        }

        public override IApiResponse<Status> Add(Status data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Status> Update(Status data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
