using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMRItemTracker
{
    class SettingsBackup
    {
        int BackgroundColor { get; }
        int TextColor { get; }
        int FormWidth { get; }
        int FormHeight { get; }
        bool AlwaysOnTop { get; }
        bool ShowLastItem { get; }
        bool ShowAmmoCount { get; }
        bool ShowDeathCount { get; }
        string Panel1Contents { get; }
        string Panel2Contents { get; }
        string Panel3Contents { get; }
        string Panel4Contents { get; }
        string Panel5Contents { get; }
        string Panel6Contents { get; }

        public SettingsBackup()
        {
            BackgroundColor = Properties.Settings.Default.BackgroundColor.ToArgb();
            TextColor = Properties.Settings.Default.TextColor.ToArgb();
            FormWidth = Properties.Settings.Default.FormWidth;
            FormHeight = Properties.Settings.Default.FormHeight;
            ShowLastItem = Properties.Settings.Default.ShowLastItem;
            AlwaysOnTop = Properties.Settings.Default.AlwaysOnTop;
            ShowAmmoCount = Properties.Settings.Default.ShowAmmoCount;
            ShowDeathCount = Properties.Settings.Default.ShowDeathCount;

            Panel1Contents = Properties.Settings.Default.Panel1Contents;
            Panel2Contents = Properties.Settings.Default.Panel2Contents;
            Panel3Contents = Properties.Settings.Default.Panel3Contents;
            Panel4Contents = Properties.Settings.Default.Panel4Contents;
            Panel5Contents = Properties.Settings.Default.Panel5Contents;
            Panel6Contents = Properties.Settings.Default.Panel6Contents;
        }

        public void RestoreSettings()
        {
            Properties.Settings.Default.BackgroundColor = System.Drawing.Color.FromArgb(BackgroundColor);
            Properties.Settings.Default.TextColor = System.Drawing.Color.FromArgb(TextColor);
            Properties.Settings.Default.FormWidth = FormWidth;
            Properties.Settings.Default.FormHeight = FormHeight;
            Properties.Settings.Default.AlwaysOnTop = AlwaysOnTop;
            Properties.Settings.Default.ShowLastItem = ShowLastItem;
            Properties.Settings.Default.ShowAmmoCount = ShowAmmoCount;
            Properties.Settings.Default.ShowDeathCount = ShowDeathCount;

            Properties.Settings.Default.Panel1Contents = Panel1Contents;
            Properties.Settings.Default.Panel2Contents = Panel2Contents;
            Properties.Settings.Default.Panel3Contents = Panel3Contents;
            Properties.Settings.Default.Panel4Contents = Panel4Contents;
            Properties.Settings.Default.Panel5Contents = Panel5Contents;
            Properties.Settings.Default.Panel6Contents = Panel6Contents;
        }
    }
}
