namespace LMRItemTracker
{
    class ItemTextPanel : System.Windows.Forms.Panel
    {
        private static System.Drawing.Size NO_AMMO_HEIGHT = new System.Drawing.Size(40, 40);
        private static System.Drawing.Size AMMO_HEIGHT = new System.Drawing.Size(40, 56);

        public TrackerBox Item { get; set; }
        public TrackerLabel Label { get; set; }
        public bool TreatAsAmmo { get; set; }

        public ItemTextPanel()
        {
            Item = null;
            Label = null;
            TreatAsAmmo = false;
        }

        public void UpdateCount(bool isAdd)
        {
            Label.UpdateCount(Label.Count + (isAdd ? 1 : -1));
            Redraw();
        }

        public void UpdateCount(int newCount)
        {
            Label.UpdateCount(newCount);
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
            if (TreatAsAmmo && !Properties.Settings.Default.ShowAmmoCount)
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
                Label.Visible = !TreatAsAmmo;
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
