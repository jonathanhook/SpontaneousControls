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

        public override void Update(MotionData data)
        {
            base.Update(data);

            if (start != null && start.Length() != 0.0f)
            {
                Vector3 end = new Vector3(-start.X, -start.Y, -start.Z);

                Vector3 lpDataN, startN, endN;
                Vector3.Normalize(ref lpData, out lpDataN);
                Vector3.Normalize(ref start, out startN);
                Vector3.Normalize(ref end, out endN);

                float total = 1.0f - Vector3.Dot(startN, endN);
                float fromStart = (1.0f - Vector3.Dot(startN, lpDataN)) / total;
                float fromEnd = (1.0f - Vector3.Dot(endN, lpDataN)) / total;

                Vector3 vn = end;
                Vector3 v3 = Vector3.Cross(vn, lpData);
                float sign = Vector3.Dot(v3, start);
                
                Value = MathHelper.Clamp((fromStart + (1.0f - fromEnd)) / 2.0f, 0.0f, 1.0f);
                Console.WriteLine(sign);
            }
        }
    }
}
