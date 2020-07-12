<<<<<<< HEAD
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
        public int Id { get; set; }

        [JsonProperty("Texte")]
        public string Texte { get; set; }

        #endregion

        #region Constructors

        public Reponse()
        {

        }

        public Reponse(int id, string texte)
        {
            Id = id;
            Texte = texte;
        }

        #endregion
    }
}
=======
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
        public int Id { get; set; }

        [JsonProperty("Texte")]
        public string Texte { get; set; }

        #endregion

        #region Constructors

        public Reponse()
        {

        }

        public Reponse(int id, string texte)
        {
            Id = id;
            Texte = texte;
        }


        #endregion
    }
}
>>>>>>> 2748cf2d920bd4848489de486dcb183ad47cba27
