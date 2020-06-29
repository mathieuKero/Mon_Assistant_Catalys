﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mon_Assistant_Catalys.Web.Models
{
    /// <summary>
    /// Ensemble des questions réponses des questionnaire. Les données sont incluses dans la classe Questionnaire
    /// </summary>
    public class Question
    {

        #region Properties
       
        [JsonProperty("IdQuestion")]
        public int IdQuestion { get; set; }

        [JsonProperty("Texte")]
        public string Texte { get; set; }

        [JsonProperty("IdReponseParent")]
        public long? IdReponseParent { get; set; }

        [JsonProperty("IdPosition")]
        public long IdPosition { get; set; }

        [JsonProperty("Reponses")]
        public Reponse[] Reponses { get; set; }

        #endregion

        #region Constructors
        public Question()
        {

        }

        #endregion

        /* Gestion du flux question réponses

        public Question PreviousQuestion { get; set; }
        public Question RootQuestion => this.PreviousQuestion != null ? this.PreviousQuestion.RootQuestion : this;


        public Question this[string answer]
        {
            get
            {
                if (this.Answers.ContainsKey(answer))
                {
                    return this.Answers[answer];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (!this.Answers.ContainsKey(answer))
                {
                    this.Answers.Add(answer, value);
                }
                else
                {
                    this.Answers[answer] = value;
                }
            }
        }

        public Question()
        {
            Question q = this;

            q.Answers["A"]
            q["A"]["B"].
            }

        */
    }

}