
using SpontaneousControls.Engine.Outputs.Discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpontaneousControls.Engine.Outputs.Continuous
{
    public class AbsoluteVolumeOutput : ContinuousOuput
    {
        public int MAX = 100;

        new public static string FreindlyName
        {
            get
            {
                return "Volume";
            }
        }

        private int volume;

        public AbsoluteVolumeOutput()
        {
            volume = 0;
        }

        public override void Trigger(float value)
        {
            int target = (int)(value * (float)MAX);

            while (volume < target)
            {
                SpontaneousControls.Engine.Outputs.Discrete.Keyboard.GetInstance().Tap((System.Windows.Forms.Keys)175);
                volume++;
            }

            while (volume > target)
            {
                SpontaneousControls.Engine.Outputs.Discrete.Keyboard.GetInstance().Tap((System.Windows.Forms.Keys)174);
                volume--;
            }
        }
    }
}
