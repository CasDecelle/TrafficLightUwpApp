using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.Services
{
    public interface IMaintenanceService
    {
        IEnumerable<Maintenance> GetAllMaintenances();

        Maintenance GetMaintenanceById(Guid id);

        Maintenance AddMaintenance(Maintenance Maintenance);

        void SaveMaintenance(Maintenance Maintenance);

        void DeleteMaintenance(Maintenance Maintenance);
    }
}
