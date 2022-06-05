using Maria.TestTask.MeasurementPlanner.Model;
using System.Collections.Generic;

namespace Maria.TestTask.MeasurementPlanner.UI.Data
{
    public interface IMeasurementRepository
    {
        IEnumerable<Measuring> GetAll();
    }
}
