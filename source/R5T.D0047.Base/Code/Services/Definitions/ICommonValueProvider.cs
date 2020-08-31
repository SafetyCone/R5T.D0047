using System;
using System.Threading.Tasks;


namespace R5T.D0047
{
    /// <summary>
    /// Service that always returns a common value accross multipe entry-points.
    /// </summary>
    public interface ICommonValueProvider
    {
        Task<string> GetCommonValue();
    }
}
