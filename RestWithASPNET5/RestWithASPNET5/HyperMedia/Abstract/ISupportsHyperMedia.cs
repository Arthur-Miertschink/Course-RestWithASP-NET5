using System.Collections.Generic;

namespace RestWithASPNET5.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
