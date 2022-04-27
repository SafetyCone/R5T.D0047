using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0047
{
    /// <summary>
    /// Service that always returns a common value accross multipe entry-points.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ICommonValueProvider : IServiceDefinition
    {
        Task<string> GetCommonValue();
    }
}
