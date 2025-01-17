﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Libraryproject1.Models
{
    [MetadataType(typeof(publishermetaData))]
    public partial class publisher
    {
        public class publishermetaData
        {
            [DisplayName("Publisher Name")]
            public string name { get; set; }

            [DisplayName("Adress")]
            public string address { get; set; }

            [DisplayName("Contact")]
            public string phone { get; set; }
        }
    }
}