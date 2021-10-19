namespace LMRItemTracker
{
    class TrackerLabel : System.Windows.Forms.Label
    {
        private static System.Drawing.Font SMALL_FONT = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        private static System.Drawing.Font LARGE_FONT = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

        public int Count { get; set; }
        public int Max { get; set; }
        public string FormatString { get; set; }
        public bool TreatAsAmmo { get; set; }
        public int MaxDisplay { get; set; }

        public TrackerLabel()
        {
            Count = 0;
            FormatString = "{0}";
        }

        public void UpdateCount(int newCount)
        {
            if (newCount >= 0 && newCount <= Max)
            {
                if (InvokeRequired)
                {
                    Invoke(new System.Action(() =>
                    {
                        Count = newCount;
                        Text = string.Format(FormatString, newCount, MaxDisplay);
                        Font = Text.Length > 3 ? SMALL_FONT : LARGE_FONT;
                        Refresh();
                    }));
                }
                else
                {
                    Count = newCount;
                    Text = string.Format(FormatString, Count, MaxDisplay);
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