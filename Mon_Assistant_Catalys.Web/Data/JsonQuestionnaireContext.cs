using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
        private Questionnaire _Questionnaire { get; set; }

        #endregion


        #region Constructors

        public JsonQuestionnaireContext() => this._Questionnaire = new Questionnaire();

        #endregion

        public void LoadData()
        {
            string path = @"C:\temp\Config.json";

            using (StreamReader reader = new StreamReader(path))
            {
                

                //Questionnaire questionnaire = new Questionnaire();

                string json = reader.ReadToEnd();

                JObject obj = JObject.Parse(json);
                JArray array = (JArray)obj["Search"];
                Questionnaire content = array.ToObject<Questionnaire>();

                //questionnaire.Add(content);

            

            }

        }

    }
}