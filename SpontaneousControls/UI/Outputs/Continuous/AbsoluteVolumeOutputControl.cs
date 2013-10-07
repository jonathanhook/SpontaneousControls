using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Outputs.Continuous;

namespace SpontaneousControls.UI.Outputs.Continuous
{
    public partial class AbsoluteVolumeOutputControl : UserControl
    {
        private AbsoluteVolumeOutput output;

        public AbsoluteVolumeOutputControl(AbsoluteVolumeOutput output)
        {
            InitializeComponent();

            this.output = output;
        }
    }
}
