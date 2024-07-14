using ModaYCostura.Data;
using ModaYCostura.Model.Interfaces;
using ModaYCostura.Model.Models;
using ModaYCostura.Service.Utils;

namespace ModaYCostura.Service.WriteBehaviours
{
    public class LocalizationWB : WriteBehaviour<Localization>
    {
        public LocalizationWB(DefaultContext context) : base(context) { }

        public override IApiResponse<Localization> Add(Localization data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Add(data);
        }

        public override IApiResponse<Localization> Update(Localization data)
        {
            data.LastUpdate = DateTime.Now;
            return base.Update(data);
        }
    }
}
