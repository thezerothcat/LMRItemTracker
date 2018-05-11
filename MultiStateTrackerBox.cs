using System;

namespace LMRItemTracker
{
    class MultiStateTrackerBox : System.Windows.Forms.PictureBox
    {
        public System.Drawing.Bitmap[] CollectedImages { get; set; }
        public System.Drawing.Image ShadedImage { get; set; }
        public System.Drawing.Image SolidImage { get; set; }

        private bool[] Collected;

        public MultiStateTrackerBox()
        {
            Collected = null;

            CollectedImages = null;
            ShadedImage = null;
            SolidImage = null;

            Paint += new System.Windows.Forms.PaintEventHandler(HandlePaint);
        }

        public void ToggleState(bool isCollected, int index)
        {
            if(Collected == null)
            {
                Collected = new bool[CollectedImages.Length];
            }
            Collected[index] = isCollected;
            Redraw();
        }

        private void DetermineImage()
        {
            bool collectedAny = false;
            for (int i = 0; i < Collected.Length; i++)
            {
                if(Collected[i])
                {
                    BackgroundImage = CollectedImages[i];
                    collectedAny = true;
                    break;
                }
            }

            if (!collectedAny)
            {
                string mode = Properties.Settings.Default.BackgroundMode;
                if ("shaded".Equals(mode))
                {
                    BackgroundImage = ShadedImage;
                }
                else if ("solid".Equals(mode))
                {
                    if (SolidImage == null)
                    {
                        BackgroundImage = ShadedImage;
                    }
                    else
                    {
                        BackgroundImage = SolidImage;
                    }
                }
                else
                {
                    BackgroundImage = null;
                }
            }

            Visible = !"hide".Equals(Properties.Settings.Default.BackgroundMode) || collectedAny;
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
            bool collectedAny = false;
            if(Collected != null)
            {
                for (int i = 0; i < Collected.Length; i++)
                {
                    if (Collected[i])
                    {
                        collectedAny = true;
                        break;
                    }
                }
            }

            if (!collectedAny && "solid".Equals(Properties.Settings.Default.BackgroundMode) && SolidImage != null)
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
                e.Graphics.DrawImage(SolidImage, new System.Drawing.Rectangle(0, 0, 40, 40), 0, 0, 40, 40, System.Drawing.GraphicsUnit.Pixel, imageAttributes);
            }
        }
    }
}
