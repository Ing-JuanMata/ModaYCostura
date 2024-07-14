using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class PropertyWB : WriteBehaviour<Property>
    {
        public PropertyWB(DefaultContext context) : base(context)
        {
        }

        public override IApiResponse<Property> Add(Property data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Property> Update(Property data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
