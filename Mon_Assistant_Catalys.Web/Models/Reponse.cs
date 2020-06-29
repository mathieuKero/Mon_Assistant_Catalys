﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mon_Assistant_Catalys.Web.Models
{
    public class Reponse
    {
        #region Properties

        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Texte")]
        public string Texte { get; set; }

        #endregion

        #region Constructors

        public Reponse()
        {

        }

        #endregion
    }
}