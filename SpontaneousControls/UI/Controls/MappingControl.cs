using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine;

namespace SpontaneousControls.UI.Controls
{
    public partial class MappingControl : UserControl
    {
        private Mapping mapping;

        public MappingControl()
        {
            InitializeComponent();

            mapping = new Mapping(0);

            ControlManager.GetInstance().RegisterMapping(mapping);
        }

        private void sensorIdBox_ValueChanged(object sender, EventArgs e)
        {
            mapping.SensorId = (int)sensorIdBox.Value;
        }

    }
}
