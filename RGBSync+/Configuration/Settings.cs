using System.Collections.Generic;
using RGBSyncPlus.Model;

namespace RGBSyncPlus.Configuration
{
    public class Settings
    {
        #region Constants

        public const int CURRENT_VERSION = 1;

        #endregion

        #region Properties & Fields

        public int Version { get; set; } = 0;

        public double UpdateRate { get; set; } = 30.0;

        public bool MinimizeToTray { get; set; } = false;

        public bool EnableClient { get; set; } = false;

        public bool EnableServer { get; set; } = false;

        public List<SyncGroup> SyncGroups { get; set; } = new List<SyncGroup>();

        #endregion
    }
}
