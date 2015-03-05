using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFS2013BIAdmin.Console
{
    public static class Jobs
    {
        public static List<string> WarehouseJobs()
        {
            return new List<string>()
            {
                "Build Warehouse Sync",
                "Common Structures Warehouse Sync",
                "Test Management Warehouse Sync",
                "Version Control Warehouse Sync",
                "Work Item Tracking Warehouse Sync"
            };
        }

        public static List<string> JobsState()
        {
            return new List<string>()
            {
                "Enabled",
                "SchedulesDisabled",
                "FullyDisabled"
            };
        }

        public static List<string> AnalysesProcessType()
        {
            return new List<string>()
            {
                "Full",
                "Incremental"
            };
        }
    }
}
