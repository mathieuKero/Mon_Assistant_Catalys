using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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