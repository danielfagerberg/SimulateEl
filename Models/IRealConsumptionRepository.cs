using SimulateEl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniatiative_train.Models
{
    public interface IRealConsumptionRepository
    {
        RealConsumption GetRealConsumption(string id);
        IEnumerable<RealConsumption> GetAllRealConsumptions();
    }
}
