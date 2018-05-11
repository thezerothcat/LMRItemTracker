using System;

namespace LMRItemTracker
{
    class KeyFairyTrackerBox : System.Windows.Forms.PictureBox
    {
        private bool miracleCollected;
        private bool mekuriCollected;

        public KeyFairyTrackerBox()
        {
            miracleCollected = false;
            mekuriCollected = false;

            Paint += new System.Windows.Forms.PaintEventHandler(HandlePaint);
        }

        public void ToggleState(bool isCollected, bool isMiracle)
        {
            if(isMiracle)
            {
                miracleCollected = isCollected;
            }
            else
            {
                mekuriCollected = isCollected;
            }
            Redraw();
        }

        protected virtual void DetermineImage()
        {
            if (miracleCollected && mekuriCollected)
            {
                BackgroundImage = Properties.Resources.Icon_keyfairy;
            }
            else
            {
                string mode = Properties.Settings.Default.BackgroundMode;
                if ("shaded".Equals(mode))
                {
                    BackgroundImage = Properties.Resources.Icon_keyfairy_blank;
                }
                else if ("solid".Equals(mode))
                {
                    BackgroundImage = Properties.Resources.Icon_keyfairy_solid;
                }
                else
                {
                    BackgroundImage = null;
                }
            }

            Visible = !"hide".Equals(Properties.Settings.Default.BackgroundMode) || (miracleCollected && mekuriCollected);
        }

        public void Redraw()
        {
            if (InvokeRequired)
            {
                Invoke(new System.Action(() =>
                {
                    DetermineImage();
                    Refresh();
                }));
            }
            else
            {
                DetermineImage();
                Refresh();
            }
        }

        private void HandlePaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    UpdateImage(e);
                }));
            }
            else
            {
                UpdateImage(e);
            }
        }

        private void UpdateImage(System.Windows.Forms.PaintEventArgs e)
        {
            if (!miracleCollected && !mekuriCollected && "solid".Equals(Properties.Settings.Default.BackgroundMode))
            {
                e.Graphics.Clear(Properties.Settings.Default.BackgroundColor);
                System.Drawing.Imaging.ImageAttributes imageAttributes = new System.Drawing.Imaging.ImageAttributes();
                System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
                    new float[][]{
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {Properties.Settings.Default.ItemColor.R / 255.0f,
                                Properties.Settings.Default.ItemColor.G / 255.0f,
                                Properties.Settings.Default.ItemColor.B / 255.0f,
                                0, 1}
                        });

                imageAttributes.SetColorMatrix(colorMatrix);
                e.Graphics.DrawImage(Properties.Resources.Icon_keysword_solid, new System.Drawing.Rectangle(0, 0, 40, 40), 0, 0, 40, 40, System.Drawing.GraphicsUnit.Pixel, imageAttributes);
            }
        }
    }
}
