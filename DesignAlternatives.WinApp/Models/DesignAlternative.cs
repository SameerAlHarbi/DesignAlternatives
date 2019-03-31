using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DesignAlternatives.WinApp.Models
{
    public class DesignAlternative
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? RelatedToWindId { get; set; }

        public DesignOption RelatedToWind { get; set; }

        public int? RelatedToViewId { get; set; }
        public DesignOption RelatedToView { get; set; }

        public int? BuildingFormId { get; set; }
        public DesignOption BuildingForm { get; set; }

        public int? FacadeMaterialId { get; set; }
        public DesignOption FacadeMaterial { get; set; }

        public int? GlazingPercentageId { get; set; }
        public DesignOption GlazingPercentage { get; set; }

        public int? PlanEfficiencyId { get; set; }
        public DesignOption PlanEfficiency { get; set; }

        public int? ShapeComplexityId { get; set; }
        public DesignOption ShapeComplexity { get; set; }

        public int? NumberOfStoreyId { get; set; }
        public DesignOption NumberOfStorey { get; set; }

        public int? AverageStoreyHeightId { get; set; }
        public DesignOption AverageStoreyHeight { get; set; }

        public int? GlazingShapeId { get; set; }
        public DesignOption GlazingShape { get; set; }

        public int? GlazingEfficiencyId { get; set; }
        public DesignOption GlazingEfficiency { get; set; }

        public int? SunBreakersGeometryId { get; set; }
        public DesignOption SunBreakersGeometry { get; set; }

        public int? SpanDimensionId { get; set; }
        public DesignOption SpanDimension { get; set; }

        public int? CirculationAreaId { get; set; }
        public DesignOption CirculationArea { get; set; }
        
        [NotMapped]
        public List<DesignOption> DesignOptionsList => new List<DesignOption>
        {
            RelatedToWind,RelatedToView,BuildingForm,FacadeMaterial,GlazingPercentage,
            PlanEfficiency,ShapeComplexity,NumberOfStorey,AverageStoreyHeight,GlazingShape,
            GlazingEfficiency,SunBreakersGeometry,SpanDimension,CirculationArea
        }.Where(d => d != null).ToList();

        [NotMapped]
        public decimal AccessibilityTotal => DesignOptionsList.Sum(d => d.Accessibility);

        [NotMapped]
        public decimal AccessibilityResult => AccessibilityTotal * 0.102m;

        [NotMapped]
        public decimal AccessibilityPercentage { get; set; }

        [NotMapped]
        public decimal RelationTotal => DesignOptionsList.Sum(d => d.Relation);

        [NotMapped]
        public decimal RelationResult => RelationTotal * 0.106m;

        [NotMapped]
        public decimal RelationPercentage { get; set; }

        [NotMapped]
        public decimal SizeTotal => DesignOptionsList.Sum(d => d.Size);

        [NotMapped]
        public decimal SizeResult => SizeTotal * 0.116m;

        [NotMapped]
        public decimal SizePercentage { get; set; }

        [NotMapped]
        public decimal CostTotal => DesignOptionsList.Sum(d => d.Cost);

        [NotMapped]
        public decimal CostResult => CostTotal * 0.140m;

        [NotMapped]
        public decimal CostPercentage { get; set; }

        [NotMapped]
        public decimal TimeTotal => DesignOptionsList.Sum(d => d.Time);

        [NotMapped]
        public decimal TimeResult => TimeTotal * 0.131m;

        [NotMapped]
        public decimal TimePercentage { get; set; }

        [NotMapped]
        public decimal EnergyTotal => DesignOptionsList.Sum(d => d.Energy);

        [NotMapped]
        public decimal EnergyResult => EnergyTotal * 0.143m;

        [NotMapped]
        public decimal EnergyPercentage { get; set; }

        [NotMapped]
        public decimal MaintenanceTotal => DesignOptionsList.Sum(d => d.Maintenance);

        [NotMapped]
        public decimal MaintenanceResult => MaintenanceTotal * 0.127m;

        [NotMapped]
        public decimal MaintenancePercentage { get; set; }

        [NotMapped]
        public decimal AestheticsTotal => DesignOptionsList.Sum(d => d.Aesthetics);

        [NotMapped]
        public decimal AestheticsResult => AestheticsTotal * 0.135m;

        [NotMapped]
        public decimal AestheticsPercentage { get; set; }

        [NotMapped]
        public decimal Score => AccessibilityResult + RelationResult + SizeResult
            + CostResult + TimeResult + EnergyResult + MaintenanceResult + AestheticsResult;

        [NotMapped]
        public decimal Percentage { get; set; }

        [NotMapped]
        public string PercentageText => $"{Percentage} %";

        [NotMapped]
        public decimal Rank { get; set; }

        [NotMapped]
        public decimal SpaceFunctionalityTotal => AccessibilityTotal + RelationTotal + SizeTotal;

        [NotMapped]
        public decimal SpaceFunctionalityPercentage { get; set; }

        [NotMapped]
        public decimal ConstructionPerformanceTotal => CostTotal + TimeTotal;

        [NotMapped]
        public decimal ConstructionPerformancePercentage { get; set; }

        [NotMapped]
        public decimal OperationPerformanceTotal => EnergyTotal + MaintenanceTotal;

        [NotMapped]
        public decimal OperationPerformancePercentage { get; set; }

    }
}
