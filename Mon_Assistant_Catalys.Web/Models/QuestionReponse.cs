using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mon_Assistant_Catalys.Web.Models
{
    /// <summary>
    /// Ensemble des questions réponses des questionnaire. Les données sont incluses dans la classe Questionnaire
    /// </summary>
    public class QuestionReponse
    {

        #region Properties
        private int IdQuestion { get; set; }
        private string TexteQuestion { get; set; }
        private int IdReponseReponseParent { get; set; }
        private int IdReponsePosition { get; set; }
        public System.Collections.Generic.Dictionary<string, QuestionReponse> Reponse { get; set; }

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
