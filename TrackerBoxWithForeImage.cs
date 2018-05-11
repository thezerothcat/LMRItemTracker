using System;

namespace LMRItemTracker
{
    class TrackerBoxWithForeImage : TrackerBox
    {
        public bool ForeCollected { get; set; }
        public System.Drawing.Image ForeImage { get; set; }

        public TrackerBoxWithForeImage()
        {
            ForeCollected = false;
            ForeImage = null;
        }

        protected override void DetermineImage()
        {
            base.DetermineImage();
            Image = ForeCollected ? ForeImage : null;
        }
    }
}
