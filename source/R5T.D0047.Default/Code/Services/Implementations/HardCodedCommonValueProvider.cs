using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0047.Default
{[ServiceImplementationMarker]
    public class HardCodedCommonValueProvider : ICommonValueProvider,IServiceImplementation
    {
        public const string Value = "dd95f53a-eb8a-48c3-8b85-9e331013d542";


        public Task<string> GetCommonValue()
        {
            return Task.FromResult(HardCodedCommonValueProvider.Value);
        }
    }
}
