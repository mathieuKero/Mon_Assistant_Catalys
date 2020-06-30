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

        public void LoadData()
        {
            string path = "Files\\data_1_CURRENT.json";
            
            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                this.Questionnaire = (Questionnaire)serializer.Deserialize(file, typeof(Questionnaire));
            }

            if (File.OpenText(path) != null)
            {
                var settings = new JsonSerializerSettings
                {
                    Error = (sender, args) =>
                    {
                        if (System.Diagnostics.Debugger.IsAttached)
                        {
                            System.Diagnostics.Debugger.Break();
                        }
                    }
                };

                StreamReader file = File.OpenText(path);

                object result = JsonConvert.DeserializeObject<Questionnaire>(file.ReadToEnd(), settings);
            }

        }

        public void initialiseJsonPaskonSaitJamaisOnRegardeVersLeHaut()
        {

            Reponse r1 = new Reponse();
            r1.Id = 1;
            r1.Texte = "Réponse 1";

            Reponse r2 = new Reponse();
            r2.Id = 2;
            r2.Texte = "Réponse 2";

            Reponse r3 = new Reponse();
            r3.Id = 3;
            r3.Texte = "Réponse 3";

            Reponse r4 = new Reponse();
            r4.Id = 4;
            r4.Texte = "Réponse 4";

            Reponse r5 = new Reponse();
            r5.Id = 5;
            r5.Texte = "Réponse 5";

            Reponse r6 = new Reponse();
            r6.Id = 6;
            r6.Texte = "Réponse 6";

            Reponse r7 = new Reponse();
            r7.Id = 7;
            r7.Texte = "Réponse 7";


            Question q1 = new Question();
            q1.IdPosition = 1;
            q1.IdQuestion = 1;
            q1.Texte = "question 1";

            ArrayList array1 = new ArrayList();
            
            array1.Add(r1);
            array1.Add(r2);

            q1.Reponses = (Reponse[])array1;

            Question q2 = new Question();
            q2.IdPosition = 2;
            q2.IdQuestion = 2;
            q2.Texte = "question 2";
            q2.Reponses[0] = r3;
            q2.Reponses[1] = r4;
            q2.IdReponseParent = 1;

            Question q3 = new Question();
            q3.IdPosition = 2;
            q3.IdQuestion = 3;
            q3.Texte = "question 3";
            q3.Reponses[0] = r5;
            q3.Reponses[1] = r6;
            q3.Reponses[2] = r7;
            q3.IdReponseParent = 2;


            Questionnaire questionnaire = new Questionnaire();
            questionnaire.Nom = "Mon super questionnaire";
            questionnaire.IdQuestionnaire = 1;
            questionnaire.Questions[0] = q1;
            questionnaire.Questions[1] = q2;
            questionnaire.Questions[2] = q3;

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"C:\Temp\temp.json", JsonConvert.SerializeObject(questionnaire));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"C:\Temp\temp.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, questionnaire);
            }

        }

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