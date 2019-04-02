using DesignAlternatives.WinApp.DataAccess;
using DesignAlternatives.WinApp.Models;
using DesignAlternatives.WinApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignAlternatives.WinApp
{
    public partial class frmMain : Form
    {
        private readonly DesignAlternativesDb designAlternativesDb;
        private DesignAlternativeResult designAlternativeResult;

        public frmMain()
        {
            InitializeComponent();
            designAlternativesDb = new DesignAlternativesDb();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            await loadDesignOptions();
            await refreshData();
        }

        private async Task loadDesignOptions()
        {
            try
            {
                var allDesignOptions = await designAlternativesDb.DesignOptions.Include(d => d.SubCategory).ToListAsync();

                relatedToWindBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Related To Wind").ToList();
                relatedToViewBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Related To View").ToList();

                buildingFormBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Building Form").ToList();
                facadeMaterialBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Facade Material").ToList();
                glazingPercentageBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Glazing Percentage (G/W Ratio)").ToList();

                planEfficiencyBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Plan Efficiency (W/F Ratio)").ToList();
                shapeComplexityBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Shape Complexity").ToList();

                numberOfStoreyBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Number of Storey").ToList();
                averageStoreyHeightBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Average Storey Height").ToList();

                glazingShapeBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Glazing Shape").ToList();
                glazingEfficiencyBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Glazing Efficiency").ToList();
                sunBreakersGeometryBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Sun-Breakers Geometry").ToList();

                spanDimensionBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Span Dimension").ToList();
                circulationAreaBindingSource.DataSource = allDesignOptions.Where(d => d.SubCategory.Name == "Circulation Area (C/F Ratio)").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task refreshData()
        {
            try
            {
                var allDesignAlternatives = await designAlternativesDb
                        .DesignAlternatives
                        .Include(d => d.RelatedToWind)
                        .Include(d => d.RelatedToView)
                        .Include(d => d.BuildingForm)
                        .Include(d => d.FacadeMaterial)
                        .Include(d => d.GlazingPercentage)
                        .Include(d => d.PlanEfficiency)
                        .Include(d => d.ShapeComplexity)
                        .Include(d => d.GlazingShape)
                        .Include(d => d.GlazingEfficiency)
                        .Include(d => d.SunBreakersGeometry)
                        .Include(d => d.NumberOfStorey)
                        .Include(d => d.AverageStoreyHeight)
                        .Include(d => d.SpanDimension)
                        .Include(d => d.CirculationArea)
                        .ToListAsync();

                nudAlternativesNumber.Value = allDesignAlternatives.Count > 0 ? allDesignAlternatives.Count : 1;

                var totalScores = allDesignAlternatives.Sum(d => d.Score);

                 var totalSpaceFunctionalities = allDesignAlternatives.Sum(d => d.SpaceFunctionalityTotal);
                 var totalConstructionsPerformances = allDesignAlternatives.Sum(d => d.ConstructionPerformanceTotal);
                 var totalOperationPerformances = allDesignAlternatives.Sum(d => d.OperationPerformanceTotal);
                 var totalAestheticses = allDesignAlternatives.Sum(d => d.AestheticsTotal);

                var totalAccessibilities = allDesignAlternatives.Sum(d => d.AccessibilityTotal);
                var totalRelations = allDesignAlternatives.Sum(d => d.RelationTotal);
                var totalSizes = allDesignAlternatives.Sum(d => d.SizeTotal);

                var totalCost = allDesignAlternatives.Sum(d => d.CostTotal);
                var totalTime = allDesignAlternatives.Sum(d => d.TimeTotal);

                var totalEnergy = allDesignAlternatives.Sum(d => d.EnergyTotal);
                var totalMaintenance = allDesignAlternatives.Sum(d => d.MaintenanceTotal);

                var totalAesthetics = allDesignAlternatives.Sum(d => d.AestheticsTotal);

                if (totalScores > 0)
                {
                    int rank = 1;
                    foreach (var designAlternative in allDesignAlternatives.OrderByDescending(d => d.Score))
                    {
                        designAlternative.Rank = rank++;
                        designAlternative.Percentage = decimal.Round((designAlternative.Score / totalScores) * 100m, 2, MidpointRounding.AwayFromZero);

                        designAlternative.SpaceFunctionalityPercentage = totalSpaceFunctionalities > 0 ?
                            decimal.Round((designAlternative.SpaceFunctionalityTotal / totalSpaceFunctionalities) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.ConstructionPerformancePercentage = totalConstructionsPerformances > 0 ?
                            decimal.Round((designAlternative.ConstructionPerformanceTotal / totalConstructionsPerformances) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.OperationPerformancePercentage = totalOperationPerformances > 0 ?
                            decimal.Round((designAlternative.OperationPerformanceTotal / totalOperationPerformances) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.AestheticsPercentage = totalAestheticses > 0 ?
                            decimal.Round((designAlternative.AestheticsTotal / totalAestheticses) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.AccessibilityPercentage = totalAccessibilities > 0 ?
                            decimal.Round((designAlternative.AccessibilityTotal / totalAccessibilities) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.RelationPercentage = totalRelations > 0 ?
                           decimal.Round((designAlternative.AccessibilityTotal / totalRelations) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.SizePercentage = totalSizes > 0 ?
                           decimal.Round((designAlternative.SizeTotal / totalSizes) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.CostPercentage = totalCost > 0 ?
                          decimal.Round((designAlternative.SizeTotal / totalCost) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.TimePercentage = totalTime > 0 ?
                          decimal.Round((designAlternative.TimeTotal / totalTime) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.EnergyPercentage = totalEnergy > 0 ?
                          decimal.Round((designAlternative.EnergyTotal / totalEnergy) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.MaintenancePercentage = totalMaintenance > 0 ?
                          decimal.Round((designAlternative.MaintenanceTotal / totalMaintenance) * 100m, 2, MidpointRounding.AwayFromZero) : 0;
                    }
                }
                designAlternativeResult = new DesignAlternativeResult(allDesignAlternatives);
                designAlternativeResultBindingSource.DataSource = designAlternativeResult;
                designAlternativeResultBindingSource.ResetBindings(false);

                designAlternativeBindingSource.DataSource = allDesignAlternatives;
                designAlternativeBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var currentAlternatives = await designAlternativesDb.DesignAlternatives.ToListAsync();
                if (currentAlternatives.Count > 0 && MessageBox.Show("Are you sure to reset design alternatives data ?", "Design Alternatives", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                var newAlternatives = new List<DesignAlternative>();

                char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

                for (int i = 0; i < (int)nudAlternativesNumber.Value; i++)
                {
                    newAlternatives.Add(new DesignAlternative { Name = $"{letters[i]}" });
                }


                designAlternativesDb.DesignAlternatives.RemoveRange(currentAlternatives);

                designAlternativesDb.DesignAlternatives.AddRange(newAlternatives);

                designAlternativesDb.SaveChanges();

                MessageBox.Show("Don", Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await refreshData();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(designAlternativeBindingSource.Current == null)
            {
                return;
            }

            try
            {
                designAlternativesDb.SaveChanges();
                await refreshData();

                MessageBox.Show("Save Successfull", Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}
