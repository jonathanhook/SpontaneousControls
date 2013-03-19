using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine;

namespace SpontaneousControls.UI
{
    public partial class SpontaneousControlsUI : Form
    {
        public SpontaneousControlsUI()
        {
            InitializeComponent();

            ControlManager.GetInstance();
        }
    }
}
