using RestWithASPNET5.HyperMedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNET5.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
