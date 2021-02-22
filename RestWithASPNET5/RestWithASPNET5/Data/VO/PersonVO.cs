﻿using RestWithASPNET5.HyperMedia;
using RestWithASPNET5.HyperMedia.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestWithASPNET5.Data.VO
{ 

    public class PersonVO : ISupportsHyperMedia
    {


        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }

}
