using System.Collections.Generic;

namespace PerDiemCalculatorLib
{
    public class CSVConnector : IDataConnection
    {
        private const string CountriesFile = "countries.csv";

        public List<DestinationModel> GetAllCountries()
        {
            return CountriesFile.FullFilePath().LoadFile().ConvertToCountries();
        }
    }
}