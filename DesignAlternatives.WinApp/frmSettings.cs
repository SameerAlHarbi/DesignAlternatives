using DesignAlternatives.WinApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
