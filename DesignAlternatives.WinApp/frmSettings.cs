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
            categoryBindingSource.DataSource = await designAlternativesDb.Categories.Include(c => c.SubCategories).ToListAsync();
        }
    }
}
