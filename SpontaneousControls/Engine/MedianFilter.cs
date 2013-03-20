using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaxControls
{
    class MedianFilter
    {
        public int SampleCount { get; private set; }

        private float[] samples;
        private int ptr;

        public MedianFilter(int sampleCount)
        {
            this.SampleCount = sampleCount;

            ptr = 0;
            samples = new float[SampleCount];
        }

        public void Update(float s)
        {
            ptr = (ptr + 1) % SampleCount;
            samples[ptr] = s;
        }

        public float GetValue()
        {
            float[] sorted = new float[samples.Length];
            samples.CopyTo(sorted, 0);
            Array.Sort<float>(sorted);
            
            return sorted[sorted.Length / 2];
        }
    }
}
