namespace LMRItemTracker
{
    class PistolAmmoTrackerLabel : System.Windows.Forms.Label
    {
        protected static System.Drawing.Font SMALL_FONT = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        protected static System.Drawing.Font LARGE_FONT = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

        private static int CLIP_MAX = 3;
        private static int BULLET_MAX = 6;

        public int ClipCount { get; set; }
        public int BulletCount { get; set; }

        public PistolAmmoTrackerLabel()
        {
            ClipCount = 0;
            BulletCount = 0;
        }

        public void UpdateCount(int newCount, bool clip)
        {
            if (newCount >= 0 && newCount <= (clip ? CLIP_MAX : BULLET_MAX))
            {
                if (InvokeRequired)
                {
                    Invoke(new System.Action(() =>
                    {
                        if(clip)
                        {
                            ClipCount = newCount;
                        }
                        else
                        {
                            BulletCount = newCount;
                        }
                        Text = string.Format("{0}:{1}", ClipCount, BulletCount);
                        Font = Text.Length > 3 ? SMALL_FONT : LARGE_FONT;
                        Refresh();
                    }));
                }
                else
                {
                    if (clip)
                    {
                        ClipCount = newCount;
                    }
                    else
                    {
                        BulletCount = newCount;
                    }
                    Text = string.Format("{0}:{1}", ClipCount, BulletCount);
                    Font = Text.Length > 3 ? SMALL_FONT : LARGE_FONT;
                }
            }
        }

        public void UpdateTextColor()
        {
            ForeColor = Properties.Settings.Default.TextColor;
        }
    }
}