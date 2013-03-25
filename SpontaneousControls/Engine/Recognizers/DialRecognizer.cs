using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpontaneousControls.Engine.Recognizers
{
    public class DialRecognizer : ContinuousValueRecognizer
    {
        private const string SLIDER_OUTPUT_FRIENDLY_NAME = "On value changed";

        public delegate void ValueChangedHandler(object sender, float value);
        public event ValueChangedHandler ValueChanged;

        private Vector3 start;
        private Vector3 quarter;

        new public static string FreindlyName
        {
            get
            {
                return "Dial";
            }
        }

        public DialRecognizer()
        {
            OutputFriendlyName = SLIDER_OUTPUT_FRIENDLY_NAME;
        }

        public void SaveStart()
        {
            start = lpData;
        }

        public void SaveQuarter()
        {
            quarter = lpData;
        }

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (start != null && 
                start.Length() != 0.0f &&
                quarter != null &&
                quarter.Length() != 0.0f)
            {
                Vector3 lpDataN, startN, quarterN;
                Vector3.Normalize(ref lpData, out lpDataN);
                Vector3.Normalize(ref start, out startN);
                Vector3.Normalize(ref quarter, out quarterN);

                float fromStart = (float)Math.Abs(Vector3.Dot(startN, lpDataN) - 1.0f) / (float)(Math.PI / 2.0);
                float fromQuarter = (float)Math.Abs(Vector3.Dot(quarterN, lpDataN) - 1.0f) / (float)(Math.PI / 2.0);

                if (fromQuarter <= 0.5f)
                {
                    Value = MathHelper.Clamp(fromStart / 2.0f, 0.0f, 1.0f);
                }
                else
                {
                    Value = MathHelper.Clamp(1.0f - (fromStart / 2.0f), 0.0f, 1.0f);
                }

                if (IsOutputEnabled && Output != null)
                {
                    Output.Trigger(Value);
                }

                if (ValueChanged != null)
                {
                    ValueChanged(this, Value);
                }

                Console.WriteLine(Value);
            }
        }
    }
}
