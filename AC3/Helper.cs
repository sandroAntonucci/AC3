using System.Globalization;
using CsvHelper;

namespace AC3
{
    public class Helper
    {
        // Crea una llista d'objectes consumAigua des de l'arxiu CSV
        public static List<ConsumAigua> GetCSV(string path)
        {

            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<ConsumAigua>().ToList();
                    return records;
                }
            }

        }
    }
}
