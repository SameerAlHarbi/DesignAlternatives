using DesignAlternatives.WinApp.DataAccess;
using DesignAlternatives.WinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignAlternatives.WinApp
{
    public partial class frmSettings : Form
    {
        private readonly DesignAlternativesDb designAlternativesDb;

        public frmSettings()
        {
            InitializeComponent();
            designAlternativesDb = new DesignAlternativesDb();
        }

        private async void frmSettings_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = await designAlternativesDb.Categories.Include(c => c.SubCategories.Select(s => s.designOptions)).ToListAsync();
        }

        private async void btnResetDefaults_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete all data and start again ?",
                "Design Alternatives Factory Reset",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                    await initializeConstantsData();
        }

        private async Task initializeConstantsData()
        {
            var categories = new List<Category>()
            {
                new Category
                {
                    Name="Building Orientation",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Related To Wind",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Likely Wind (North Western)",
                                    Accessibility=0.50m,
                                    Relation=0.70m,
                                    Size=0.90m,
                                    Cost=0.50m,
                                    Time=0.70m,
                                    Energy=0.90m,
                                    Maintenance = 0.50m,
                                    Aesthetics = 0.10m
                                },
                                new DesignOption
                                {
                                    Name="Unlikely Wind (South Eastern)",
                                    Accessibility= -0.30m,
                                    Relation=-0.50m,
                                    Size=-0.70m,
                                    Cost=-0.30m,
                                    Time=-0.50m,
                                    Energy=-0.90m,
                                    Maintenance =-0.30m,
                                    Aesthetics = -0.10m
                                },
                            }
                        },
                        new SubCategory
                        {
                            Name = "Related To View",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Good View (Garden-Sea-Street)",
                                    Accessibility=0.50m,
                                    Relation=0.70m,
                                    Size=0.90m,
                                    Cost=0.30m,
                                    Time=0.50m,
                                    Energy=-0.50m,
                                    Maintenance = 0.70m,
                                    Aesthetics = 0.90m
                                },
                                new DesignOption
                                {
                                    Name="Bad View (Neighborhood)",
                                    Accessibility=-0.50m,
                                    Relation=-0.50m,
                                    Size=-0.70m,
                                    Cost=-0.10m,
                                    Time=-0.70m,
                                    Energy=0.70m,
                                    Maintenance = -0.50m,
                                    Aesthetics = -0.70m
                                },
                            }
                        },
                    }
                },
                new Category
                {
                    Name="Building Envelope",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Building Form",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Simple (Regular)",
                                    Accessibility=0.90m,
                                    Relation=0.90m,
                                    Size=0.90m,
                                    Cost=0.90m,
                                    Time=0.70m,
                                    Energy=-0.50m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.70m
                                },
                                new DesignOption
                                {
                                    Name="Normal (Moderate)",
                                    Accessibility=0.50m,
                                    Relation=0.50m,
                                    Size=0.70m,
                                    Cost=0.50m,
                                    Time=0.50m,
                                    Energy=-0.30m,
                                    Maintenance = 0.50m,
                                    Aesthetics = 0.50m
                                },
                                new DesignOption
                                {
                                    Name="Complex (Sharp)",
                                    Accessibility=-0.70m,
                                    Relation=-0.70m,
                                    Size=-0.90m,
                                    Cost=-0.90m,
                                    Time=-0.90m,
                                    Energy=0.70m,
                                    Maintenance = -0.90m,
                                    Aesthetics = 0.90m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Facade Material",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Precast Concrete",
                                    Accessibility=0.30m,
                                    Relation=0.30m,
                                    Size=0.50m,
                                    Cost=0.70m,
                                    Time=0.90m,
                                    Energy=-0.50m,
                                    Maintenance = 0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="Block (Concrete)",
                                    Accessibility=0.10m,
                                    Relation=0.10m,
                                    Size=0.30m,
                                    Cost=0.50m,
                                    Time=-0.50m,
                                    Energy=0.50m,
                                    Maintenance = 0.30m,
                                    Aesthetics = 0.50m
                                },
                                new DesignOption
                                {
                                    Name="Brick (Stone)",
                                    Accessibility=-0.10m,
                                    Relation=0.50m,
                                    Size=-0.10m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=0.90m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.90m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Glazing Percentage (G/W Ratio)",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Small (<20%)",
                                    Accessibility=0.50m,
                                    Relation=0.50m,
                                    Size=0.70m,
                                    Cost=0.70m,
                                    Time=0.50m,
                                    Energy=0.90m,
                                    Maintenance = 0.30m,
                                    Aesthetics = -0.90m
                                },
                                new DesignOption
                                {
                                    Name="Medium (20-50%)",
                                    Accessibility=0.30m,
                                    Relation=-0.30m,
                                    Size=-0.50m,
                                    Cost=-0.50m,
                                    Time=-0.30m,
                                    Energy=-0.70m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name=" Large (>50%)",
                                    Accessibility=-0.10m,
                                    Relation=-0.50m,
                                    Size=-0.70m,
                                    Cost=-0.90m,
                                    Time=-0.50m,
                                    Energy=-0.90m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.90m
                                }
                            }
                        }
                    }
                },
                new Category
                {
                    Name="Plan Shape and Complexity",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Plan Efficiency (W/F Ratio)",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Not-Efficient (<70%)",
                                    Accessibility=-0.30m,
                                    Relation=-0.90m,
                                    Size=-0.70m,
                                    Cost=0.70m,
                                    Time=0.90m,
                                    Energy=-0.50m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.30m
                                },
                                new DesignOption
                                {
                                    Name="Acceptable (70-90%)",
                                    Accessibility=0.50m,
                                    Relation=0.50m,
                                    Size=0.50m,
                                    Cost=-0.70m,
                                    Time=-0.50m,
                                    Energy=0.70m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.10m
                                },
                                new DesignOption
                                {
                                    Name="Efficient (>90%)",
                                    Accessibility=0.70m,
                                    Relation=0.90m,
                                    Size=0.90m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=0.90m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.50m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Shape Complexity",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Simple (Regular)",
                                    Accessibility=0.70m,
                                    Relation=0.90m,
                                    Size=0.90m,
                                    Cost=0.90m,
                                    Time=0.70m,
                                    Energy=-0.90m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.30m
                                },
                                new DesignOption
                                {
                                    Name="Normal ( Moderate)",
                                    Accessibility=0.50m,
                                    Relation=0.70m,
                                    Size=0.50m,
                                    Cost=-0.50m,
                                    Time=0.50m,
                                    Energy=0.50m,
                                    Maintenance = 0.50m,
                                    Aesthetics = 0.50m
                                },
                                new DesignOption
                                {
                                    Name="Complex (Irregular)",
                                    Accessibility=-0.70m,
                                    Relation=-0.90m,
                                    Size=-0.90m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=0.90m,
                                    Maintenance = -0.90m,
                                    Aesthetics = 0.70m
                                }
                            }
                        }
                    }
                },
                new Category
                {
                    Name="Storey and Height",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Number of Storey",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Low-Rise (1-2 Storeys)",
                                    Accessibility=0.90m,
                                    Relation=0.70m,
                                    Size=0.50m,
                                    Cost=0.90m,
                                    Time=0.90m,
                                    Energy=0.70m,
                                    Maintenance = 0.90m,
                                    Aesthetics = -0.70m
                                },
                                new DesignOption
                                {
                                    Name="Medium-Rise (3-4 Storeys)",
                                    Accessibility=0.50m,
                                    Relation=0.50m,
                                    Size=-0.30m,
                                    Cost=0.50m,
                                    Time=0.50m,
                                    Energy=-0.50m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="High-Rise (>4 Storeys))",
                                    Accessibility=-0.50m,
                                    Relation=-0.30m,
                                    Size=-0.50m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=-0.70m,
                                    Maintenance = -0.90m,
                                    Aesthetics = 0.90m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Average Storey Height",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Low (<3.00m)",
                                    Accessibility=-0.50m,
                                    Relation=-0.50m,
                                    Size=-0.50m,
                                    Cost=0.70m,
                                    Time=0.70m,
                                    Energy=0.70m,
                                    Maintenance = 0.50m,
                                    Aesthetics = -0.90m
                                },
                                new DesignOption
                                {
                                    Name="Normal (3.00-4.00m)",
                                    Accessibility=0.50m,
                                    Relation=0.30m,
                                    Size=0.10m,
                                    Cost=0.50m,
                                    Time=0.50m,
                                    Energy=-0.50m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="High (>4.00m)",
                                    Accessibility=0.70m,
                                    Relation=0.50m,
                                    Size=0.30m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=-0.70m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.90m
                                }
                            }
                        }
                    }
                },
                new Category
                {
                    Name="Windows Glazing",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Glazing Shape",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Regular Shape",
                                    Accessibility=0.30m,
                                    Relation=0.30m,
                                    Size=0.50m,
                                    Cost=0.70m,
                                    Time=0.90m,
                                    Energy=-0.70m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.50m
                                },
                                new DesignOption
                                {
                                    Name="Semi-Regular Shape",
                                    Accessibility=-0.30m,
                                    Relation=-0.10m,
                                    Size=-0.50m,
                                    Cost=-0.70m,
                                    Time=-0.50m,
                                    Energy=0.50m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="Irregular Shape",
                                    Accessibility=-0.50m,
                                    Relation=-0.30m,
                                    Size=-0.70m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=0.70m,
                                    Maintenance = -0.90m,
                                    Aesthetics = 0.90m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Glazing Efficiency",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Low Efficiency",
                                    Accessibility=-0.10m,
                                    Relation=-0.10m,
                                    Size=-0.30m,
                                    Cost=0.70m,
                                    Time=0.50m,
                                    Energy=-0.90m,
                                    Maintenance = 0.30m,
                                    Aesthetics = -0.50m
                                },
                                new DesignOption
                                {
                                    Name="Medium Efficiency",
                                    Accessibility=0.10m,
                                    Relation=0.10m,
                                    Size=0.10m,
                                    Cost=-0.50m,
                                    Time=-0.30m,
                                    Energy=0.70m,
                                    Maintenance = -0.30m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="High Efficiency",
                                    Accessibility=0.30m,
                                    Relation=0.30m,
                                    Size=0.30m,
                                    Cost=-0.90m,
                                    Time=-0.50m,
                                    Energy=0.90m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.90m
                                }
                            }
                        },
                        new SubCategory
                        {
                            Name = "Sun-Breakers Geometry",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Simple Shape (1-Panel)",
                                    Accessibility=0.30m,
                                    Relation=0.10m,
                                    Size=0.30m,
                                    Cost=0.90m,
                                    Time=0.70m,
                                    Energy=0.50m,
                                    Maintenance = 0.70m,
                                    Aesthetics = 0.50m
                                },
                                new DesignOption
                                {
                                    Name="Normal Shape (2-Panels)",
                                    Accessibility=-0.10m,
                                    Relation=-0.10m,
                                    Size=-0.10m,
                                    Cost=-0.70m,
                                    Time=-0.50m,
                                    Energy=0.70m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="Complex Shape (3-Panels)",
                                    Accessibility=-0.30m,
                                    Relation=-0.30m,
                                    Size=-0.30m,
                                    Cost=-0.90m,
                                    Time=-0.70m,
                                    Energy=0.90m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.90m
                                }
                            }
                        }
                    }
                },
                new Category
                {
                    Name="Floor Spans",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Span Dimension",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Short (<4.50m)",
                                    Accessibility=-0.30m,
                                    Relation=-0.30m,
                                    Size=-0.50m,
                                    Cost=0.50m,
                                    Time=0.70m,
                                    Energy=0.70m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.50m
                                },
                                new DesignOption
                                {
                                    Name="Medium (4.50-6.50m)",
                                    Accessibility=0.50m,
                                    Relation=0.70m,
                                    Size=0.70m,
                                    Cost=0.70m,
                                    Time=0.50m,
                                    Energy=0.50m,
                                    Maintenance = 0.50m,
                                    Aesthetics = 0.70m
                                },
                                new DesignOption
                                {
                                    Name="Long (>6.50m)",
                                    Accessibility=0.70m,
                                    Relation=0.50m,
                                    Size=-0.30m,
                                    Cost=-0.50m,
                                    Time=-0.50m,
                                    Energy=-0.70m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.90m
                                }
                            }
                        }
                    }
                },
                new Category
                {
                    Name="Circulation Space",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory
                        {
                            Name = "Circulation Area (C/F Ratio)",
                            designOptions = new List<DesignOption>
                            {
                                new DesignOption
                                {
                                    Name="Low (<15%)",
                                    Accessibility=-0.90m,
                                    Relation=-0.70m,
                                    Size=0.70m,
                                    Cost=0.50m,
                                    Time=0.70m,
                                    Energy=0.70m,
                                    Maintenance = 0.70m,
                                    Aesthetics = -0.50m
                                },
                                new DesignOption
                                {
                                    Name="Normal (15-25%)",
                                    Accessibility=0.70m,
                                    Relation=0.50m,
                                    Size=0.50m,
                                    Cost=0.30m,
                                    Time=0.50m,
                                    Energy=-0.50m,
                                    Maintenance = -0.50m,
                                    Aesthetics = 0.50m
                                },
                                new DesignOption
                                {
                                    Name="High (>25%)",
                                    Accessibility=0.90m,
                                    Relation=0.70m,
                                    Size=-0.70m,
                                    Cost=-0.70m,
                                    Time=-0.70m,
                                    Energy=-0.90m,
                                    Maintenance = -0.70m,
                                    Aesthetics = 0.70m
                                }
                            }
                        }
                    }
                }
            };

            try
            {
                var allDesignAlternatives = await designAlternativesDb.DesignAlternatives.ToListAsync();
                var currentCategories = await designAlternativesDb.Categories.Include(c => c.SubCategories.Select(s => s.designOptions)).ToListAsync();

                designAlternativesDb.DesignAlternatives.RemoveRange(allDesignAlternatives);
                designAlternativesDb.Categories.RemoveRange(currentCategories);

                designAlternativesDb.Categories.AddRange(categories);

                designAlternativesDb.SaveChanges();
                categoryBindingSource.DataSource = await designAlternativesDb.Categories.Include(c => c.SubCategories.Select(s => s.designOptions)).ToListAsync();
                categoryBindingSource.ResetBindings(false);
                MessageBox.Show("Reset Default Successfull" ,"Design Alternatives", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Design Alternatives", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            designAlternativesDb.SaveChanges();
            MessageBox.Show("Save Successfull", "Design Alternatives", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
