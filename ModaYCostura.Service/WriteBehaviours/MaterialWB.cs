using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class MaterialWB : WriteBehaviour<Material>
    {
        public MaterialWB(DefaultContext context) : base(context) { }

        public override IApiResponse<Material> Add(Material data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Material> Update(Material data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
