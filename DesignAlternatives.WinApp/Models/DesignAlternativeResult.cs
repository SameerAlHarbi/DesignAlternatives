using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAlternatives.WinApp.Models
{
    public class DesignAlternativeResult
    {

        private readonly List<DesignAlternative> _designAlternativesList;

        public DesignAlternativeResult(List<DesignAlternative> designAlternativesList)
        {
            _designAlternativesList = designAlternativesList ?? new List<DesignAlternative>();
        }

        #region Space Functionality

        public DesignAlternative BestSpaceFunctionalityDesign => _designAlternativesList
            .OrderByDescending(d => d.SpaceFunctionalityTotal).FirstOrDefault();

        public string BestSpaceFunctionalityDesignName => BestSpaceFunctionalityDesign != null ? $"{BestSpaceFunctionalityDesign.Name} ({BestSpaceFunctionalityDesign.SpaceFunctionalityTotal})" : "";

        public decimal BestSpaceFunctionalityDesignPercentage => BestSpaceFunctionalityDesign?.SpaceFunctionalityPercentage ?? 0;

        public string BestSpaceFunctionalityDesignPercentageText => BestSpaceFunctionalityDesignPercentage + "%";

        public DesignAlternative BestAccessibilityDesign => _designAlternativesList
            .OrderByDescending(d => d.AccessibilityTotal).FirstOrDefault();

        public string BestAccessibilityDesignName => BestAccessibilityDesign != null ? $"{BestAccessibilityDesign.Name} ({BestAccessibilityDesign.AccessibilityTotal})" : "";

        public decimal BestAccessibilityDesignPercentage => BestAccessibilityDesign?.AccessibilityPercentage ?? 0;

        public string BestAccessibilityDesignPercentageText => BestAccessibilityDesignPercentage + "%";

        public DesignAlternative BestRelationDesign => _designAlternativesList
            .OrderByDescending(d => d.RelationTotal).FirstOrDefault();

        public string BestRelationDesignName => BestRelationDesign != null ? $"{BestRelationDesign.Name} ({BestRelationDesign.RelationTotal})" : "";

        public decimal BestRelationDesignPercentage => BestRelationDesign?.RelationPercentage ?? 0;

        public string BestRelationDesignPercentageText => BestRelationDesignPercentage + "%";

        public DesignAlternative BestSizeDesign => _designAlternativesList
            .OrderByDescending(d => d.SizeTotal).FirstOrDefault();

        public string BestSizeDesignName => BestSizeDesign != null ? $"{BestSizeDesign.Name} ({BestSizeDesign.SizeTotal})" : "";

        public decimal BestSizeDesignPercentage => BestSizeDesign?.SizePercentage ?? 0;

        public string BestSizeDesignPercentageText => BestSizeDesignPercentage + "%";

        #endregion

        #region Construction Performance

        public DesignAlternative BestConstructionPerformanceDesign => _designAlternativesList
            .OrderByDescending(d => d.ConstructionPerformanceTotal).FirstOrDefault();

        public string BestConstructionPerformanceDesignName => BestConstructionPerformanceDesign != null ? $"{BestConstructionPerformanceDesign.Name} ({BestConstructionPerformanceDesign.ConstructionPerformanceTotal})" : "";

        public decimal BestConstructionPerformanceDesignPercentage => BestConstructionPerformanceDesign?.ConstructionPerformancePercentage ?? 0;

        public DesignAlternative BestCosteDesign => _designAlternativesList
            .OrderByDescending(d => d.CostTotal).FirstOrDefault();

        public string BestCosteDesignName => BestCosteDesign != null ? $"{BestCosteDesign.Name} ({BestCosteDesign.CostTotal})" : "";

        public decimal BestCosteDesignPercentage => BestCosteDesign?.CostPercentage ?? 0;

        public DesignAlternative BestTimeDesign => _designAlternativesList
            .OrderByDescending(d => d.TimeTotal).FirstOrDefault();

        public string BestTimeDesignName => BestTimeDesign != null ? $"{BestTimeDesign.Name} ({BestTimeDesign.TimeTotal})" : "";

        public decimal BestTimeDesignPercentage => BestTimeDesign?.TimePercentage ?? 0;

        #endregion

        #region Operation Performance

        public DesignAlternative BestOperationPerformanceDesign => _designAlternativesList
            .OrderByDescending(d => d.OperationPerformanceTotal).FirstOrDefault();

        public string BestOperationPerformanceDesignName => BestOperationPerformanceDesign != null ? $"{BestOperationPerformanceDesign.Name} ({BestOperationPerformanceDesign.OperationPerformanceTotal})" : "";

        public decimal BestOperationPerformanceDesignPercentage => BestOperationPerformanceDesign?.OperationPerformancePercentage ?? 0;

        public DesignAlternative BestEnergyDesign => _designAlternativesList
           .OrderByDescending(d => d.EnergyTotal).FirstOrDefault();

        public string BestEnergyDesignName => BestEnergyDesign != null ? $"{BestEnergyDesign.Name} ({BestEnergyDesign.EnergyTotal})" : "";

        public decimal BestEnergyDesignPercentage => BestEnergyDesign?.EnergyPercentage ?? 0;

        public DesignAlternative BestMaintenanceDesign => _designAlternativesList
           .OrderByDescending(d => d.MaintenanceTotal).FirstOrDefault();

        public string BestMaintenanceDesignName => BestMaintenanceDesign != null ? $"{BestMaintenanceDesign.Name} ({BestMaintenanceDesign.MaintenanceTotal})" : "";

        public decimal BestMaintenanceDesignPercentage => BestMaintenanceDesign?.MaintenancePercentage ?? 0;

        #endregion

        public DesignAlternative BestAestheticsDesign => _designAlternativesList
           .OrderByDescending(d => d.AestheticsTotal).FirstOrDefault();

        public string BestAestheticsDesignName => BestAestheticsDesign != null ? $"{BestAestheticsDesign.Name} ({BestAestheticsDesign.AestheticsTotal})" : "";

        public decimal BestAestheticsDesignPercentage => BestAestheticsDesign?.AestheticsPercentage ?? 0;

    }
}
