using System;

namespace LMRItemTracker
{
    class TrackerBox : System.Windows.Forms.PictureBox
    {
        public bool Collected { get; set; }
        public bool ForeCollected { get; set; }
        public bool RedrawOnStateChange { get; set; }

        public System.Drawing.Image CollectedImage { get; set; }
        public System.Drawing.Image ShadedImage { get; set; }
        public System.Drawing.Image SolidImage { get; set; }

        public System.Drawing.Image ForeImage { get; set; }

        public TrackerBox()
        {
            Collected = false;
            ForeCollected = false;

            CollectedImage = null;
            ShadedImage = null;
            SolidImage = null;

            ForeImage = null;

            Paint += new System.Windows.Forms.PaintEventHandler(HandlePaint);
        }

        public void ToggleState(bool isCollected)
        {
            Collected = isCollected;
            if(RedrawOnStateChange)
            {
                Redraw();
            }
        }

        public void ToggleForeState(bool isCollected)
        {
            ForeCollected = isCollected;
            if (RedrawOnStateChange)
            {
                Redraw();
            }
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
            if (Collected)
            {
                BackgroundImage = CollectedImage;
            }
            else
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

            if ("solid".Equals(Properties.Settings.Default.BackgroundMode))
            {
                Image = Collected && ForeCollected ? ForeImage : null;
            }
            else
            {
                Image = ForeCollected ? ForeImage : null;
            }

            Visible = !"hide".Equals(Properties.Settings.Default.BackgroundMode) || Collected || ForeCollected;
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
            if (!Collected && "solid".Equals(Properties.Settings.Default.BackgroundMode) && SolidImage != null && !LaMulanaItemTrackerForm.DialogOpen)
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

                Image = null;
                if (ForeCollected && ForeImage != null)
                {
                    e.Graphics.DrawImage(ForeImage, new System.Drawing.Point(0, 0));
                }
            }
        }
    }
}
