using Mon_Assistant_Catalys.Web.Models;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
=======
>>>>>>> 2748cf2d920bd4848489de486dcb183ad47cba27

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

<<<<<<< HEAD
=======
        public QuestionnaireService()
        {
           this.questionnaire = jsonContext.LoadData();
        }

>>>>>>> 2748cf2d920bd4848489de486dcb183ad47cba27
    }
}