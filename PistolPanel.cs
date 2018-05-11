namespace LMRItemTracker
{
    class PistolPanel : System.Windows.Forms.Panel
    {
        private static System.Drawing.Size NO_AMMO_HEIGHT = new System.Drawing.Size(40, 40);
        private static System.Drawing.Size AMMO_HEIGHT = new System.Drawing.Size(40, 56);

        public TrackerBox Item { get; set; }
        public PistolAmmoTrackerLabel Label { get; set; }

        public PistolPanel()
        {
            Item = null;
            Label = null;
        }

        public void UpdateCount(int newCount, bool isClip)
        {
            Label.UpdateCount(newCount, isClip);
            Redraw();
        }

        public void ToggleState(bool isAdd)
        {
            Item.ToggleState(isAdd);
            Redraw();
        }

        public void Redraw()
        {
            if (InvokeRequired)
            {
                Invoke(new System.Action(() =>
                {
                    UpdatePanel();
                    Item.Redraw();
                    Refresh();
                }));
            }
            else
            {
                UpdatePanel();
                Item.Redraw();
                Refresh();
            }

        }

        private void UpdatePanel()
        {
            if (!Properties.Settings.Default.ShowAmmoCount)
            {
                Size = NO_AMMO_HEIGHT;
            }
            else if (Item.Collected)
            {
                Size = AMMO_HEIGHT;
                Label.Visible = true;
            }
            else if (!"hide".Equals(Properties.Settings.Default.BackgroundMode))
            {
                Size = AMMO_HEIGHT;
                Label.Visible = false;
            }
            else
            {
                Size = NO_AMMO_HEIGHT;
            }

            if (!Item.Collected && "hide".Equals(Properties.Settings.Default.BackgroundMode))
            {
                Visible = false;
            }
            else
            {
                Visible = true;
            }
        }
    }
}
