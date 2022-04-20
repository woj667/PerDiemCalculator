using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PerDiemCalculatorLib
{
    public static class CSVConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return Environment.CurrentDirectory + "\\" + fileName;
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<DestinationModel> ConvertToCountries(this List<string> lines)
        {
            List<DestinationModel> output = new List<DestinationModel>();

            lines.RemoveAt(0); // remove header

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                DestinationModel c = new DestinationModel();
                c.Id = int.Parse(cols[0]);
                c.Name = cols[1];
                c.Currency = cols[2];
                c.PerDiem = decimal.Parse(cols[3]);
                c.Lodging = decimal.Parse(cols[4]);

                output.Add(c);
            }
            return output;
        }
    }
}