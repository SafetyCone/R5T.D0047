using System;
using System.Threading.Tasks;


namespace R5T.D0047.Default
{
    public class HardCodedCommonValueProvider : ICommonValueProvider
    {
        public const string Value = "dd95f53a-eb8a-48c3-8b85-9e331013d542";


        public Task<string> GetCommonValue()
        {
            return Task.FromResult(HardCodedCommonValueProvider.Value);
        }
    }
}
