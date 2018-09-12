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
        /// <summary>
        /// Initializes the Scaler Multiplication View/
        /// </summary>
        public uxScalerMultControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dynamically adds or removes a row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxScaler_RowCount_ValueChanged(object sender, EventArgs e)
        {
            uxScaler_Matrix.RowCount = Convert.ToInt32(uxScaler_RowCount.Value);   
        }

        /// <summary>
        /// Dynamically adds or removes a column.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_Scaler_ColCount_ValueChanged(object sender, EventArgs e)
        {
            uxScaler_Matrix.ColumnCount = Convert.ToInt32(ux_Scaler_ColCount.Value);
        }

        /// <summary>
        /// Processes the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux_CalcScalerButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
