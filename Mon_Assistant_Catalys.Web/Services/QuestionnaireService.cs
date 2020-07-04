using Mon_Assistant_Catalys.Web.Models;

namespace Mon_Assistant_Catalys.Web.Services
{
    /// <summary>
    ///     Liaison vers les données et appel des fonction. 
    ///     C'est une couche intermédiaire entre les models / views vers le dossier data.
    /// </summary>
    public class QuestionnaireService
    {
        private JsonQuestionnaireContext jsonContext = JsonQuestionnaireContext.Instance;

        private readonly Questionnaire questionnaire = new Questionnaire();

        public QuestionnaireService()
        {
           this.questionnaire = jsonContext.LoadData();
        }

    }
}
