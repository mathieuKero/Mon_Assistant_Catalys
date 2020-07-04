using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Mon_Assistant_Catalys.Web.Models
{
    /// <summary>
    ///     Cette classe va lire les données du questionnaire. C'est une sorte de classe d'accès aux données comme on le ferait avec la DAO
    /// </summary>
    public class JsonQuestionnaireContext
    {
        #region Fields

        /// <summary>
        ///     Questionnaire.
        /// </summary>
        private Questionnaire Questionnaire { get; set; }

        private static JsonQuestionnaireContext instance = null;

        #endregion


        #region Constructors

        public JsonQuestionnaireContext()
        {
            
        }

        //public JsonQuestionnaireContext()
        //{
        //    this.Questionnaire = new Questionnaire();
        //}

        #endregion

        /// <summary>
        ///     Récupération des données du fichier Json et insertion dans Questionnaire
        /// </summary>
        public void LoadData()
        {
            string path = "Files\\data_1_CURRENT.json";

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                this.Questionnaire = (Questionnaire)serializer.Deserialize(file, typeof(Questionnaire));
            }

           // EditData(1);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="Id"></param>
        public void FindData(int Id)
        {



        }

        /// <summary>
        ///     Edition d'une partie du questionnaire ( Question / Réponse )
        /// </summary>
        /// <param name="Id"></param>
        public void EditData(int id)
        {
            /// Réflexion : Récupérer le json avec loaddata puis modifier ? ou alors modifier les données des classes puis mettre à jour le json à partir des classes ?
            /// A VOIR
            Question question = new Question();
            Reponse reponse = new Reponse();


            if (question == null)
            {
                reponse = this.Questionnaire.Questions.Select(x => x.Reponses.FirstOrDefault(c => c.Id == id)).ToList().FirstOrDefault();
            }
            

        }

        public void AddData()
        {

        }
        
        //TODO : Virer, cette fonction sert seuelement aux tests en cas d'erreurs du fichier JSON

        //public void initialiseJsonPaskonSaitJamaisOnRegardeVersLeHaut()
        //{

        //    Reponse r1 = new Reponse();
        //    r1.Id = 1;
        //    r1.Texte = "Réponse 1";

        //    Reponse r2 = new Reponse();
        //    r2.Id = 2;
        //    r2.Texte = "Réponse 2";

        //    Reponse r3 = new Reponse();
        //    r3.Id = 3;
        //    r3.Texte = "Réponse 3";

        //    Reponse r4 = new Reponse();
        //    r4.Id = 4;
        //    r4.Texte = "Réponse 4";

        //    Reponse r5 = new Reponse();
        //    r5.Id = 5;
        //    r5.Texte = "Réponse 5";

        //    Reponse r6 = new Reponse();
        //    r6.Id = 6;
        //    r6.Texte = "Réponse 6";

        //    Reponse r7 = new Reponse();
        //    r7.Id = 7;
        //    r7.Texte = "Réponse 7";

        //    ArrayList repQ1 = new ArrayList();
        //    repQ1.Add(r1);
        //    repQ1.Add(r2);

        //    Question q1 = new Question(1, "Question 1", null, 1, repQ1);

        //    Question q2 = new Question();
        //    q2.IdPosition = 2;
        //    q2.IdQuestion = 2;
        //    q2.Texte = "question 2";

        //    ArrayList repQ2 = new ArrayList();
        //    repQ2.Add(r3);
        //    repQ2.Add(r4);
        //    q2.IdReponseParent = 1;
        //    q2.Reponses = repQ2;

        //    Question q3 = new Question();
        //    q3.IdPosition = 2;
        //    q3.IdQuestion = 3;
        //    q3.Texte = "question 3";

        //    ArrayList repQ3 = new ArrayList();
        //    repQ3.Add(r5);
        //    repQ3.Add(r6);
        //    repQ3.Add(r7);
        //    q3.IdReponseParent = 2;
        //    q3.Reponses = repQ3;

        //    Questionnaire questionnaire = new Questionnaire();
        //    questionnaire.Nom = "Mon super questionnaire";
        //    questionnaire.IdQuestionnaire = 1;
        //    //Dictionary<int, Question> questions = new Dictionary<int, Question>();
        //    //questions.Add(q1.IdQuestion, q1);
        //    //questions.Add(q2.IdQuestion, q2);
        //    //questions.Add(q3.IdQuestion, q3);
        //    questionnaire.Questions = new ArrayList();
        //    questionnaire.Questions.Add(q1);
        //    questionnaire.Questions.Add(q2);
        //    questionnaire.Questions.Add(q3);

        //    // serialize JSON to a string and then write string to a file
        //    //File.WriteAllText(@"C:\Temp\temp.json", JsonConvert.SerializeObject(questionnaire));

        //    // serialize JSON directly to a file
        //    using (StreamWriter file = File.CreateText(@"C:\Temp\data_1_CURRENT.json"))
        //    {
        //        JsonSerializer serializer = new JsonSerializer();
        //        serializer.Serialize(file, questionnaire);
        //    }

        //}

        #region Properties

        public static JsonQuestionnaireContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JsonQuestionnaireContext();
                }
                return instance;
            }
        }

        #endregion


    }
}