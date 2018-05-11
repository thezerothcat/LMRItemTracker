using System;

namespace LMRItemTracker
{
    class KeySwordTrackerBox : System.Windows.Forms.PictureBox
    {
        private bool keySwordCollected;
        private bool mantrasRecited;

        public KeySwordTrackerBox()
        {
            keySwordCollected = false;
            mantrasRecited = false;

            Paint += new System.Windows.Forms.PaintEventHandler(HandlePaint);
        }

        public void ToggleState(bool isCollected, bool isKeySword)
        {
            if(isKeySword)
            {
                keySwordCollected = isCollected;
            }
            else
            {
                mantrasRecited = isCollected;
            }
            Redraw();
        }

        public void Redraw()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
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

        private void DetermineImage()
        {
            if (keySwordCollected && mantrasRecited)
            {
                BackgroundImage = Properties.Resources.Icon_keysword_awakened;
            }
            else if (keySwordCollected)
            {
                BackgroundImage = Properties.Resources.Icon_keysword;
            }
            else
            {
                string mode = Properties.Settings.Default.BackgroundMode;
                if ("shaded".Equals(mode))
                {
                    BackgroundImage = Properties.Resources.Icon_keysword_blank;
                }
                else if ("solid".Equals(mode))
                {
                    BackgroundImage = Properties.Resources.Icon_keysword_solid;
                }
                else
                {
                    BackgroundImage = null;
                }
            }

            Visible = !"hide".Equals(Properties.Settings.Default.BackgroundMode) || keySwordCollected;
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
            if (!keySwordCollected && "solid".Equals(Properties.Settings.Default.BackgroundMode))
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
