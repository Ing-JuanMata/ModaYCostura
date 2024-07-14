using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class UnitWB : WriteBehaviour<Unit>
    {
        public UnitWB(DefaultContext context) : base(context)
        {
        }

        public override IApiResponse<Unit> Add(Unit data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Unit> Update(Unit data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
