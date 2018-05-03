using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixSolver.View.User_Controls
{
    public partial class uxScalerMultControl : UserControl
    {
        public uxScalerMultControl()
        {
            InitializeComponent();
        }

        private void uxScaler_RowCount_ValueChanged(object sender, EventArgs e)
        {
            uxScaler_Matrix.RowCount = Convert.ToInt32(uxScaler_RowCount.Value);   
        }

        private void ux_Scaler_ColCount_ValueChanged(object sender, EventArgs e)
        {
            uxScaler_Matrix.ColumnCount = Convert.ToInt32(ux_Scaler_ColCount.Value);
        }
    }
}
