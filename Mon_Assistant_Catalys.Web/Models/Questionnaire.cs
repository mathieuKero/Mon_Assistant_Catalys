﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mon_Assistant_Catalys.Web.Models
{
    /// <summary>
    /// COntiens les informations relatives au questionnaire (Liste des questionReponses etc.)
    /// </summary>
    public class Questionnaire
    {

        #region Properties

        private string Nom { get; set; }

        private int IdQuestionnaire { get; set; }

        public System.Collections.Generic.Dictionary<string, Questionnaire> QuestionReponse { get; set; }

        #endregion

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="Questionnaire"/>.
        /// </summary>
        public Questionnaire()
        {

        }

    }
}
