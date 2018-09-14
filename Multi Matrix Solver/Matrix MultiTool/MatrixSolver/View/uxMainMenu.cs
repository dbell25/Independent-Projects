using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixSolver
{
    public delegate void IScaler();

    public partial class uxMainMenu : Form
    {
        /// <summary>
        /// Initializes a new uxMainMenu form.
        /// </summary>
        public uxMainMenu(IScaler scale)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Menu button to invoke the scaler multiplication tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScalerMult_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxMainMenu_Display.Controls.Count != 0) RemoveControl();
            var control = new View.User_Controls.uxScalerMultControl();
            uxMainMenu_Display.Controls.Add(control);
            uxMainMenu_Display.Show();
        }

        /// <summary>
        /// Returns to default screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControl();
        }

        /// <summary>
        /// Removes added controls from the display panel.
        /// </summary>
        public void RemoveControl()
        {
            if (uxMainMenu_Display.Controls.Count != 0) uxMainMenu_Display.Controls.RemoveAt(0);
        }
    }
}
