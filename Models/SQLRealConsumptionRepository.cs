using SimulateEl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniatiative_train.Models
{
    public class SQLRealConsumptionRepository : IRealConsumptionRepository
    {
        private AppDBContext context { get; }
        public SQLRealConsumptionRepository(AppDBContext context)
        {
            this.context = context;
        }

        public RealConsumption GetRealConsumption(string time)
        {
            return (RealConsumption)context.RealConsumptions.Where(z => z.Timeframe.Equals(time));
        }

        public IEnumerable<RealConsumption> GetAllRealConsumptions()
        {
            return context.RealConsumptions;
        }
    }
    }

