using DesignAlternatives.WinApp.DataAccess;
using DesignAlternatives.WinApp.Models;
using DesignAlternatives.WinApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading;
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
                        .OrderBy(d => d.Name)
                        .ToListAsync();

                nudAlternativesNumber.Value = allDesignAlternatives.Count > 0 ? allDesignAlternatives.Count : 1;

                var totalScores = allDesignAlternatives.Sum(d => d.Score);

                decimal accessibilityAddedValue = allDesignAlternatives.Max(d => d.AccessibilityAddedValue);
                var totalAccessibilities = allDesignAlternatives.Sum(d => d.AccessibilityTotal + accessibilityAddedValue);

                decimal relationAddedValue = allDesignAlternatives.Max(d => d.RelationAddedValue);
                var totalRelations = allDesignAlternatives.Sum(d => d.RelationTotal + relationAddedValue);

                decimal sizeAddedValue = allDesignAlternatives.Max(d => d.SizeAddedValue);
                var totalSizes = allDesignAlternatives.Sum(d => d.SizeTotal + sizeAddedValue);

                var totalSpaceFunctionalities = totalAccessibilities + totalRelations + totalSizes;

                decimal costAddedValue = allDesignAlternatives.Max(d => d.CostAddedValue);
                var totalCost = allDesignAlternatives.Sum(d => d.CostTotal + costAddedValue);

                decimal timeAddedValue = allDesignAlternatives.Max(d => d.TimeAddedValue);
                var totalTime = allDesignAlternatives.Sum(d => d.TimeTotal + timeAddedValue);

                var totalConstructionsPerformances = totalCost + totalTime;

                decimal energyAddedValue = allDesignAlternatives.Max(d => d.EnergyAddedValue);
                var totalEnergy = allDesignAlternatives.Sum(d => d.EnergyTotal + energyAddedValue);

                decimal maintenanceAddedValue = allDesignAlternatives.Max(d => d.MaintenanceAddedValue);
                var totalMaintenance = allDesignAlternatives.Sum(d => d.MaintenanceTotal + maintenanceAddedValue);

                var totalOperationPerformances = totalMaintenance + totalEnergy;

                decimal aestheticsAddedValue = allDesignAlternatives.Max(d => d.AestheticsAddedValue);
                var totalAestheticses = allDesignAlternatives.Sum(d => d.AestheticsTotal + aestheticsAddedValue);

                if (totalScores > 0)
                {
                    int rank = 1;
                    foreach (var designAlternative in allDesignAlternatives.OrderByDescending(d => d.Score))
                    {
                        designAlternative.Rank = rank++;
                        designAlternative.Percentage = decimal.Round((designAlternative.Score / totalScores) * 100m, 2, MidpointRounding.AwayFromZero);

                        designAlternative.AccessibilityPercentage = totalAccessibilities > 0 ?
                            decimal.Round(((designAlternative.AccessibilityTotal + accessibilityAddedValue) / totalAccessibilities) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.RelationPercentage = totalRelations > 0 ?
                            decimal.Round(((designAlternative.RelationTotal + relationAddedValue) / totalRelations) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.SizePercentage = totalSizes > 0 ?
                            decimal.Round(((designAlternative.SizeTotal + sizeAddedValue) / totalSizes) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.SpaceFunctionalityPercentage = totalSpaceFunctionalities > 0 ?
                            decimal.Round(((designAlternative.SpaceFunctionalityTotal +
                                accessibilityAddedValue + relationAddedValue + sizeAddedValue) / totalSpaceFunctionalities) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.CostPercentage = totalCost > 0 ?
                            decimal.Round(((designAlternative.CostTotal + costAddedValue) / totalCost) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.TimePercentage = totalTime > 0 ?
                            decimal.Round(((designAlternative.TimeTotal + timeAddedValue) / totalTime) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.ConstructionPerformancePercentage = totalConstructionsPerformances > 0 ?
                            decimal.Round(((designAlternative.ConstructionPerformanceTotal +
                                costAddedValue + timeAddedValue) / totalConstructionsPerformances) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.EnergyPercentage = totalEnergy > 0 ?
                            decimal.Round(((designAlternative.EnergyTotal + energyAddedValue) / totalEnergy) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.MaintenancePercentage = totalMaintenance > 0 ?
                           decimal.Round(((designAlternative.MaintenanceTotal + maintenanceAddedValue) / totalMaintenance) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.OperationPerformancePercentage = totalOperationPerformances > 0 ?
                            decimal.Round(((designAlternative.OperationPerformanceTotal +
                                energyAddedValue + maintenanceAddedValue)/ totalOperationPerformances) * 100m, 2, MidpointRounding.AwayFromZero) : 0;

                        designAlternative.AestheticsPercentage = totalAestheticses > 0 ?
                            decimal.Round(((designAlternative.AestheticsTotal + aestheticsAddedValue) / totalAestheticses) * 100m, 2, MidpointRounding.AwayFromZero) : 0;
                    }
                }
                designAlternativeResult = new DesignAlternativeResult(allDesignAlternatives);
                designAlternativeResultBindingSource.DataSource = designAlternativeResult;
                designAlternativeResultBindingSource.ResetBindings(false);

                designAlternativeBindingSource.DataSource = allDesignAlternatives;
                designAlternativeBindingSource.ResetBindings(false);

                this.rdSpaceFunctionality.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            //if(new frmSettings().ShowDialog() == DialogResult.OK)
            // {
            new frmSettings().ShowDialog();
                await loadDesignOptions();
                await refreshData();
            //}
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
                    newAlternatives.Add(new DesignAlternative {
                        Name = $"{letters[i]}"
                    });
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var loadingForm = new frmLoading();
            loadingForm.ShowDialog();
            //Thread.Sleep(3000);

            //System.Threading.Thread.CurrentThread.

            Score.Visible = true;
            Percentage.Visible = true;
            Rank.Visible = true;

            //MessageBox.Show("Ok");
            //loadingForm.DialogResult = DialogResult.OK;

            Cursor = Cursors.Default;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void rdSpaceFunctionality_CheckedChanged(object sender, EventArgs e)
        {
            var rd = sender as RadioButton;
            if (!rd.Checked)
            {
                return;
            }

            var subCriterias = new List<SubCriteria>()
            {
                new SubCriteria
                {
                    Name="Accessibility",
                    BestDesignName = designAlternativeResult.BestAccessibilityDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestAccessibilityDesignPercentageText,
                    Criteria = "Space"
                },
                new SubCriteria
                {
                    Name="Relation",
                    BestDesignName = designAlternativeResult.BestRelationDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestRelationDesignPercentageText,
                    Criteria = "Space"
                },
                new SubCriteria
                {
                    Name="Size",
                    BestDesignName = designAlternativeResult.BestSizeDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestSizeDesignPercentageText,
                    Criteria = "Space"
                },
                new SubCriteria
                {
                    Name="Cost",
                    BestDesignName = designAlternativeResult.BestCosteDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestCosteDesignPercentageText,
                    Criteria = "Construction"
                },
                new SubCriteria
                {
                    Name="Time",
                    BestDesignName = designAlternativeResult.BestTimeDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestTimeDesignPercentageText,
                    Criteria = "Construction"
                },
                new SubCriteria
                {
                    Name="Energy",
                    BestDesignName = designAlternativeResult.BestEnergyDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestEnergyDesignPercentageText,
                    Criteria = "Operation"
                },
                new SubCriteria
                {
                    Name="Maintenance",
                    BestDesignName = designAlternativeResult.BestMaintenanceDesignName,
                    BestDesignRelativeIndex = designAlternativeResult.BestMaintenanceDesignPercentageText,
                    Criteria = "Operation"
                },
            };

            string selectedCriteria = "";

            if(rd == rdSpaceFunctionality)
            {
                lblBestCriteria.Text = designAlternativeResult.BestSpaceFunctionalityDesignName;
                lblBestCriteriaPercentage.Text = designAlternativeResult.BestSpaceFunctionalityDesignPercentageText;

                selectedCriteria = "Space";
            }
            else if (rd == rdConstructionPerformance)
            {
                lblBestCriteria.Text = designAlternativeResult.BestConstructionPerformanceDesignName;
                lblBestCriteriaPercentage.Text = designAlternativeResult.BestConstructionPerformanceDesignPercentageText;

                selectedCriteria = "Construction";
            }
            else if (rd == rdOperationPerformance)
            {
                lblBestCriteria.Text = designAlternativeResult.BestOperationPerformanceDesignName;
                lblBestCriteriaPercentage.Text = designAlternativeResult.BestOperationPerformanceDesignPercentageText;

                selectedCriteria = "Operation";
            }
            else if (rd == rdAethiticas)
            {
                lblBestCriteria.Text = designAlternativeResult.BestAestheticsDesignName;
                lblBestCriteriaPercentage.Text = designAlternativeResult.BestAestheticsDesignPercentageText;
            }


            subCriteriaBindingSource.DataSource = subCriterias.Where(s => s.Criteria == selectedCriteria).ToList();
            subCriteriaBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmOptionDialog().ShowDialog();
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }
    }
}
