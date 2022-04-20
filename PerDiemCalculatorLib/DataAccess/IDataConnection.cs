using System.Collections.Generic;

namespace PerDiemCalculatorLib
{
    public interface IDataConnection
    {
        List<DestinationModel> GetAllCountries();
    }
}