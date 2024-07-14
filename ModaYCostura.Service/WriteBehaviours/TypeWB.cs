using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class TypeWB : WriteBehaviour<Model.Models.Type>
    {
        public TypeWB(DefaultContext context) : base(context)
        {
        }

        public override IApiResponse<Model.Models.Type> Add(Model.Models.Type data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Model.Models.Type> Update(Model.Models.Type data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
