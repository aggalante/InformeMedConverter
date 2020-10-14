#region Copyright © 2014, Critical Health

// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InformeMedConverter.Model
{
    public class DefaultParametersFactory
    {
        public const string Delimiter = ";";

        public static string FilePath = Application.StartupPath + "\\Config\\DefaultParametersConfig_{0}.txt";

        public static string LineDelimiter = Environment.NewLine;

        public static string DefaultCulture = "es-ES";

        private static readonly Dictionary<string, ParameterType> ParameterTypesDictionary = new Dictionary<string, ParameterType>
        {
            {  "B", ParameterType.Bioquimica },
            {"H", ParameterType.Hematologia},
            { "MT", ParameterType.MarcadoresTumorales  },
            {"SO", ParameterType.SedimentoOrina },
            { "TRO" ,ParameterType.TiraReactivaOrina },
            { "U", ParameterType.Urgencias }
        };


        public static ComboboxItem[] GetAvailableLanguages()
        {
            List<ComboboxItem> languages = new List<ComboboxItem>
            {
                new ComboboxItem("es-ES", "ESP"),
                new ComboboxItem("ca-ES", "CAT")
            };

            return languages.ToArray();

        }

        public static List<ParameterData> GetDefaultParameters(string language)
        {
            List<ParameterData> result = new List<ParameterData>();

            string fileName = string.Format(FilePath, language);

            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                string allData = sr.ReadToEnd();
                string[] rows = allData.Split(LineDelimiter.ToCharArray());
                foreach (string r in rows)
                {
                    string[] items = r.Split(Delimiter.ToCharArray());
                    if (items.Length > 0 && !Extensions.IsNullOrWhiteSpace(items[0]))
                    {
                        ParameterType type = GetParameterType(items[0]);
                        string parameter = items.Length > 1 ? items[1] : string.Empty;
                        string unit = items.Length > 2 ? items[2] : string.Empty;

                        result.Add(new ParameterData(type, parameter, string.Empty, unit));
                    }
                }
            }

            return result;
        }

        private static ParameterType GetParameterType(string parameterAbbrev)
        {
            return ParameterTypesDictionary[parameterAbbrev];
        }
    }
}
