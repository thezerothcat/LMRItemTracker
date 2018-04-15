using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LMRItemTracker
{
    public partial class LaMulanaItemTrackerForm : Form
    {
        private BackgroundWorker flagListener;

        public LaMulanaItemTrackerForm()
        {
            InitializeComponent();
            ScaleImages(this);
            this.mantrasRecited = false;
            this.keySwordCollected = false;
            this.miracleCollected = false;
            this.mekuriCollected = false;
            this.gameStarted = false;

            this.settingsBackup = new SettingsBackup();

            updateAlwaysOnTop();
            updateFormSize();
            updateFormColor();
            updateTextColor();
            updateShowLastItem();
            updateShowDeathCount();
            updateBackgroundMode();
            if("shaded".Equals(Properties.Settings.Default.BackgroundMode))
            {
                readerPanel.Size = new System.Drawing.Size(40, 56);
            }
            else
            {
                readerPanel.Size = new System.Drawing.Size(40, 40);
            }
            updateShowAmmoCount();
            InitializePossibleItems();
            InitializeFormPanels();
            InitializeMenuOptions();
            InitializeBackgroundWorker();
        }

        private void ScaleImages(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is PictureBox p)
                {
                    p.BackgroundImageLayout = ImageLayout.Zoom;
                    p.SizeMode = PictureBoxSizeMode.Zoom;
                }
                ScaleImages(c);
            }
        }

        private void InitializeBackgroundWorker()
        {
            flagListener = new BackgroundWorker();
            flagListener.DoWork += new DoWorkEventHandler(flagListener_DoWork);
        }

        private void InitializePossibleItems()
        {
            this.allItems = new List<String>(92);
            this.allItems.Add("Anchor");
            this.allItems.Add("Ankh Jewels");
            this.allItems.Add("Axe");
            this.allItems.Add("Birth Seal");
            this.allItems.Add("Bomb");
            this.allItems.Add("Book of the Dead");
            this.allItems.Add("Bracelet");
            this.allItems.Add("Bronze Mirror");
            this.allItems.Add("beolamu.exe");
            this.allItems.Add("bounce.exe");
            this.allItems.Add("bunemon.exe");
            this.allItems.Add("bunplus.com");
            this.allItems.Add("Caltrops");
            this.allItems.Add("capstar.exe");
            this.allItems.Add("Chakram");
            this.allItems.Add("Cog of the Soul");
            this.allItems.Add("Crucifix");
            this.allItems.Add("Crystal Skull");
            this.allItems.Add("Death Seal");
            this.allItems.Add("deathv.exe");
            this.allItems.Add("Diary");
            this.allItems.Add("Dimensional Key");
            this.allItems.Add("Djed Pillar");
            this.allItems.Add("Dragon Bone");
            this.allItems.Add("Earth Spear");
            this.allItems.Add("emusic.exe");
            this.allItems.Add("Eye of Truth");
            this.allItems.Add("Fairy Clothes");
            this.allItems.Add("Feather");
            this.allItems.Add("Flare Gun");
            this.allItems.Add("Fruit of Eden");
            this.allItems.Add("Gauntlet");
            this.allItems.Add("Glove");
            this.allItems.Add("reader.exe");
            this.allItems.Add("Grapple Claw");
            this.allItems.Add("guild.exe");
            this.allItems.Add("Hand Scanner");
            this.allItems.Add("Heatproof Case");
            this.allItems.Add("Helmet");
            this.allItems.Add("Hermes' Boots");
            this.allItems.Add("Holy Grail");
            this.allItems.Add("Ice Cape");
            this.allItems.Add("Isis' Pendant");
            this.allItems.Add("Katana");
            this.allItems.Add("Key Fairy Combo");
            this.allItems.Add("Key of Eternity");
            this.allItems.Add("Key Sword");
            this.allItems.Add("Knife");
            this.allItems.Add("Lamp of Time");
            this.allItems.Add("lamulana.exe");
            this.allItems.Add("Life Seal");
            this.allItems.Add("Magatama Jewel");
            this.allItems.Add("Mantra/Djed Pillar");
            this.allItems.Add("mantra.exe");
            this.allItems.Add("Maps");
            this.allItems.Add("mekuri.exe");
            this.allItems.Add("Mini Doll");
            this.allItems.Add("miracle.exe");
            this.allItems.Add("mirai.exe");
            this.allItems.Add("Mobile Super X2");
            this.allItems.Add("move.exe");
            this.allItems.Add("Mulana Talisman");
            this.allItems.Add("Origin Seal");
            this.allItems.Add("Pepper");
            this.allItems.Add("Perfume");
            this.allItems.Add("Philosopher's Ocarina");
            this.allItems.Add("Pistol");
            this.allItems.Add("Plane Model");
            this.allItems.Add("Pochette Key");
            this.allItems.Add("Provocative Bathing Suit");
            this.allItems.Add("randc.exe");
            this.allItems.Add("Ring");
            this.allItems.Add("Rolling Shuriken");
            this.allItems.Add("Scalesphere");
            this.allItems.Add("Scriptures");
            this.allItems.Add("Serpent Staff");
            this.allItems.Add("Shield");
            this.allItems.Add("Shell Horn");
            this.allItems.Add("Shrine Wall Removal");
            this.allItems.Add("Shuriken");
            this.allItems.Add("Spaulder");
            this.allItems.Add("Talisman");
            this.allItems.Add("torude.exe");
            this.allItems.Add("Treasures");
            this.allItems.Add("Twin Statue");
            this.allItems.Add("Vessel/Medicine");
            this.allItems.Add("Waterproof Case");
            this.allItems.Add("Whip");
            this.allItems.Add("Woman Statue");
            this.allItems.Add("xmailer.exe");
            this.allItems.Add("yagomap.exe");
            this.allItems.Add("yagostr.exe");
        }

        private void InitializeFormPanels()
        {
            foreach (String item in this.allItems)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    SetStartingImage(item);
                    control.Parent = null;
                }
            }

            List<String> itemsInPanel = new List<String>(Properties.Settings.Default.Panel1Contents.Split(','));
            for(int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if(control != null)
                {
                    flowLayoutPanel1.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if(flowLayoutPanel1.Controls.Count < 1)
            {
                flowLayoutPanel1.Visible = false;
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel2Contents.Split(','));
            for (int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel2.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if (flowLayoutPanel2.Controls.Count < 1)
            {
                flowLayoutPanel2.Visible = false;
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel3Contents.Split(','));
            for (int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel3.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if (flowLayoutPanel3.Controls.Count < 1)
            {
                flowLayoutPanel3.Visible = false;
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel4Contents.Split(','));
            for (int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel4.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if (flowLayoutPanel4.Controls.Count < 1)
            {
                flowLayoutPanel4.Visible = false;
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel5Contents.Split(','));
            for (int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel5.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if (flowLayoutPanel5.Controls.Count < 1)
            {
                flowLayoutPanel5.Visible = false;
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel6Contents.Split(','));
            for (int index = 0; index < itemsInPanel.Count; index++)
            {
                String item = itemsInPanel[index];
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel6.Controls.Add(control);
                    control.Margin = new Padding(0);
                    control.TabIndex = index;
                }
            }
            if (flowLayoutPanel6.Controls.Count < 1)
            {
                flowLayoutPanel6.Visible = false;
            }

            if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
            {
                foreach (Control control in bossPanel.Controls)
                {
                    control.Visible = false;
                }
            }
            else if(Properties.Settings.Default.BackgroundMode.Equals("blank"))
            {
                foreach (Control control in bossPanel.Controls)
                {
                    SetBackgroundImage((PictureBox)control, null);
                }
            }
        }

        private void SetStartingImage(String item)
        {
            PictureBox blankImage = GetBlankImagePictureBox(item);
            if (blankImage != null)
            {
                if ("Mantra/Djed Pillar".Equals(item))
                {
                    blankImage.BackgroundImage = getBlankImage(getFlagName(item));
                    blankImage.Image = null;
                    Control control = GetControl(item);
                    if (control != null && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                    {
                        control.Visible = false;
                    }
                }
                else if ("Whip".Equals(item))
                {
                    whipsPanel.Controls.Add(whip);
                    whipsPanel.Controls.Remove(chainWhip);
                    whipsPanel.Controls.Remove(flailWhip);

                    whipCollected = true;
                    chainWhipCollected = false;

                    blankImage.BackgroundImage = null;
                    blankImage.Image = getFoundImage(getFlagName(item));
                }
                else
                {
                    blankImage.BackgroundImage = null;
                    blankImage.Image = getBlankImage(getFlagName(item));
                    Control control = GetControl(item);
                    if (control != null && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                    {
                        control.Visible = false;
                    }
                }

                if ("Vessel/Medicine".Equals(item))
                {
                    if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        vesselPanel.Controls.Remove(vessel);
                    }
                }
                if ("Lamp of Time".Equals(item))
                {
                    if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        lampOfTimePanel.Controls.Remove(lampOfTime);
                    }
                }
                if ("Woman Statue".Equals(item))
                {
                    if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        womanPanel.Controls.Remove(maternityStatue);
                    }
                }
                if ("Shield".Equals(item))
                {
                    bucklerCollected = false;
                    fakeShieldCollected = false;
                    silverShieldCollected = false;

                    if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        shieldsPanel.Controls.Remove(buckler);
                    }
                    shieldsPanel.Controls.Remove(fakeSilverShield);
                    shieldsPanel.Controls.Remove(silverShield);
                    shieldsPanel.Controls.Remove(angelShield);
                }
            }
        }
        private void InitializeMenuOptions()
        {
            foreach (String item in this.allItems)
            {
                addItemPanel1ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel1)));
                addItemPanel2ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel2)));
                addItemPanel3ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel3)));
                addItemPanel4ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel4)));
                addItemPanel5ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel5)));
                addItemPanel6ToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.addItemToPanel6)));
                removeItemToolStripMenuItem.DropDownItems.Add(CreateMenuItem(item, new System.EventHandler(this.removeItemFromPanel)));
            }
        }

        private void flagListener_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            try
            {
                e.Result = LMRItemTracker.Program.DoStuff(this, this._xmlStream);
            }
            catch (Exception ex)
            {
                ShowMessage("Unexpected error: " + ex.Message);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private String getItemName(String flagName)
        {
            if ("w-scanner".Equals(flagName))
            {
                return "Hand Scanner";
            }
            else if ("w-grail".Equals(flagName))
            {
                return "Holy Grail";
            }
            else if ("w-doll".Equals(flagName))
            {
                return "Mini Doll";
            }
            else if ("w-magatama".Equals(flagName))
            {
                return "Magatama Jewel";
            }
            else if ("w-pepper".Equals(flagName))
            {
                return "Pepper";
            }
            else if ("w-woman".Equals(flagName))
            {
                return "Woman Statue";
            }
            else if ("w-serpent".Equals(flagName))
            {
                return "Serpent Staff";
            }
            else if ("w-glove".Equals(flagName))
            {
                return "Glove";
            }
            else if ("w-crucifix".Equals(flagName))
            {
                return "Crucifix";
            }
            else if ("w-eye-truth".Equals(flagName))
            {
                return "Eye of Truth";
            }
            else if ("w-scale".Equals(flagName))
            {
                return "Scalesphere";
            }
            else if ("w-gauntlet".Equals(flagName))
            {
                return "Gauntlet";
            }
            else if ("w-anchor".Equals(flagName))
            {
                return "Anchor";
            }
            else if ("w-book".Equals(flagName))
            {
                return "Book of the Dead";
            }
            else if ("w-clothes".Equals(flagName))
            {
                return "Fairy Clothes";
            }
            else if ("w-scriptures".Equals(flagName))
            {
                return "Scriptures";
            }
            else if ("w-bracelet".Equals(flagName))
            {
                return "Bracelet";
            }
            else if ("w-perfume".Equals(flagName))
            {
                return "Perfume";
            }
            else if ("w-spaulder".Equals(flagName))
            {
                return "Spaulder";
            }
            else if ("w-icecape".Equals(flagName))
            {
                return "Ice Cape";
            }
            else if ("w-talisman".Equals(flagName))
            {
                return "Talisman";
            }
            else if ("w-diary".Equals(flagName))
            {
                return "Diary";
            }
            else if ("w-mulanatalisman".Equals(flagName))
            {
                return "Mulana Talisman";
            }
            else if ("w-dimension-key".Equals(flagName))
            {
                return "Dimensional Key";
            }
            else if ("w-cog".Equals(flagName))
            {
                return "Cog of the Soul";
            }
            else if ("w-cskull".Equals(flagName))
            {
                return "Crystal Skull";
            }
            else if ("w-endless-key".Equals(flagName))
            {
                return "Key of Eternity";
            }
            else if ("w-isispendant".Equals(flagName))
            {
                return "Isis' Pendant";
            }
            else if ("w-helmet".Equals(flagName))
            {
                return "Helmet";
            }
            else if ("w-grapple".Equals(flagName))
            {
                return "Grapple Claw";
            }
            else if ("w-mirror".Equals(flagName))
            {
                return "Bronze Mirror";
            }
            else if ("w-ring".Equals(flagName))
            {
                return "Ring";
            }
            else if ("w-plane".Equals(flagName))
            {
                return "Plane Model";
            }
            else if ("w-ocarina".Equals(flagName))
            {
                return "Philosopher's Ocarina";
            }
            else if ("w-feather".Equals(flagName))
            {
                return "Feather";
            }
            else if ("w-hermes".Equals(flagName))
            {
                return "Hermes' Boots";
            }
            else if ("w-fruit".Equals(flagName))
            {
                return "Fruit of Eden";
            }
            else if ("w-twin-statue".Equals(flagName))
            {
                return "Twin Statue";
            }
            else if ("w-treasures".Equals(flagName))
            {
                return "Treasures";
            }
            else if ("w-pochettekey".Equals(flagName))
            {
                return "Pochette Key";
            }
            else if ("w-msx2".Equals(flagName))
            {
                return "Mobile Super X2";
            }
            else if ("w-shell-horn".Equals(flagName))
            {
                return "Shell Horn";
            }
            else if ("w-heat-case".Equals(flagName))
            {
                return "Heatproof Case";
            }
            else if ("w-water-case".Equals(flagName))
            {
                return "Waterproof Case";
            }
            else if ("w-djed".Equals(flagName))
            {
                return "Djed Pillar";
            }
            else if ("w-dragonbone".Equals(flagName))
            {
                return "Dragon Bone";
            }
            else if ("w-seal1".Equals(flagName))
            {
                return "Origin Seal";
            }
            else if ("w-seal2".Equals(flagName))
            {
                return "Birth Seal";
            }
            else if ("w-seal3".Equals(flagName))
            {
                return "Life Seal";
            }
            else if ("w-seal4".Equals(flagName))
            {
                return "Death Seal";
            }
            else if ("w-soft-beolamu".Equals(flagName))
            {
                return "beolamu.exe";
            }
            else if ("w-soft-bounce".Equals(flagName))
            {
                return "bounce.exe";
            }
            else if ("w-soft-bunemon".Equals(flagName))
            {
                return "bunemon.exe";
            }
            else if ("w-soft-bunplus".Equals(flagName))
            {
                return "bunplus.com";
            }
            else if ("w-soft-capstar".Equals(flagName))
            {
                return "capstar.exe";
            }
            else if ("w-soft-deathv".Equals(flagName))
            {
                return "deathv.exe";
            }
            else if ("w-soft-emusic".Equals(flagName))
            {
                return "emusic.exe";
            }
            else if ("w-soft-guild".Equals(flagName))
            {
                return "guild.exe";
            }
            else if ("w-soft-lamulana".Equals(flagName))
            {
                return "lamulana.exe";
            }
            else if ("w-soft-mantra".Equals(flagName))
            {
                return "mantra.exe";
            }
            else if ("w-soft-mekuri".Equals(flagName))
            {
                return "mekuri.exe";
            }
            else if ("w-soft-mirai".Equals(flagName))
            {
                return "mirai.exe";
            }
            else if ("w-soft-miracle".Equals(flagName))
            {
                return "miracle.exe";
            }
            else if ("w-soft-move".Equals(flagName))
            {
                return "move.exe";
            }
            else if ("w-soft-randc".Equals(flagName))
            {
                return "randc.exe";
            }
            else if ("w-soft-reader".Equals(flagName))
            {
                return "reader.exe";
            }
            else if ("w-soft-torude".Equals(flagName))
            {
                return "torude.exe";
            }
            else if ("w-soft-xmailer".Equals(flagName))
            {
                return "xmailer.exe";
            }
            else if ("w-soft-yagomap".Equals(flagName))
            {
                return "yagomap.exe";
            }
            else if ("w-soft-yagostr".Equals(flagName))
            {
                return "yagostr.exe";
            }
            else if ("w-main-axe".Equals(flagName))
            {
                return "Axe";
            }
            else if ("w-main-knife".Equals(flagName))
            {
                return "Knife";
            }
            else if ("w-main-katana".Equals(flagName))
            {
                return "Katana";
            }
            else if ("w-sub-shuriken".Equals(flagName))
            {
                return "Shuriken";
            }
            else if ("w-sub-rshuriken".Equals(flagName))
            {
                return "Rolling Shuriken";
            }
            else if ("w-sub-caltrops".Equals(flagName))
            {
                return "Caltrops";
            }
            else if ("w-sub-spear".Equals(flagName))
            {
                return "Earth Spear";
            }
            else if ("w-sub-flare".Equals(flagName))
            {
                return "Flare Gun";
            }
            else if ("w-sub-bomb".Equals(flagName))
            {
                return "Bomb";
            }
            else if ("w-sub-chakram".Equals(flagName))
            {
                return "Chakram";
            }
            else if ("w-sub-pistol".Equals(flagName))
            {
                return "Pistol";
            }
            else if ("ankh-jewels".Equals(flagName))
            {
                return "Ankh Jewels";
            }
            else if ("shield-buckler".Equals(flagName))
            {
                return "Buckler";
            }
            else if ("whip".Equals(flagName))
            {
                return "Whip";
            }
            return null;
        }

        public void toggleItem(string flagName, bool isAdd)
        {
            if ("w-scanner".Equals(flagName) || "w-doll".Equals(flagName) || "w-magatama".Equals(flagName)
                || "w-cog".Equals(flagName) || "w-pochettekey".Equals(flagName) || "w-cskull".Equals(flagName)
                || "w-pepper".Equals(flagName) || "w-woman".Equals(flagName) || "w-endless-key".Equals(flagName)
                || "w-serpent".Equals(flagName) || "w-talisman".Equals(flagName) || "w-diary".Equals(flagName)
                || "w-mulanatalisman".Equals(flagName))
            {
                // Usable items with no special image handling
                SetImage(flagName, isAdd);
            }
            else if ("w-msx2".Equals(flagName) || "w-heat-case".Equals(flagName) || "w-water-case".Equals(flagName)
                || "w-shell-horn".Equals(flagName) || "w-glove".Equals(flagName) || "w-grail".Equals(flagName)
                || "w-isispendant".Equals(flagName) || "w-crucifix".Equals(flagName) || "w-helmet".Equals(flagName)
                || "w-grapple".Equals(flagName) || "w-mirror".Equals(flagName) || "w-eye-truth".Equals(flagName)
                || "w-ring".Equals(flagName) || "w-scale".Equals(flagName) || "w-gauntlet".Equals(flagName)
                || "w-anchor".Equals(flagName) || "w-treasures".Equals(flagName) || "w-plane".Equals(flagName)
                || "w-ocarina".Equals(flagName) || "w-feather".Equals(flagName) || "w-book".Equals(flagName)
                || "w-clothes".Equals(flagName) || "w-scriptures".Equals(flagName) || "w-hermes".Equals(flagName)
                || "w-fruit".Equals(flagName) || "w-twin-statue".Equals(flagName) || "w-bracelet".Equals(flagName)
                || "w-perfume".Equals(flagName) || "w-spaulder".Equals(flagName) || "w-dimension-key".Equals(flagName)
                || "w-icecape".Equals(flagName))
            {
                // Non-usable items with no special image handling
                SetImage(flagName, isAdd);
            }
            else if ("w-main-chain".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(whipsPanel, true);
                }
                chainWhipCollected = isAdd;
                updateWhips();
            }
            else if ("w-main-flail".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(whipsPanel, true);
                }
                flailWhipCollected = isAdd;
                updateWhips();
            }
            else if ("w-main-keysword".Equals(flagName))
            {
                this.keySwordCollected = isAdd;
                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(GetControl("Key Sword"), isAdd);
                }

                if (isAdd)
                {
                    if (this.mantrasRecited)
                    {
                        SetImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened);
                    }
                    else
                    {
                        SetImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword);
                    }
                }
                else
                {
                    SetImage(keySword, getBlankImage("w-main-keysword"));
                }
            }
            else if (flagName.StartsWith("w-main-"))
            {
                SetImage(flagName, isAdd);
            }
            else if (flagName.StartsWith("w-sub-"))
            {
                toggleSubWeapon(flagName, isAdd);
            }
            else if ("w-soft-mantra".Equals(flagName))
            {
                SetImage(flagName, isAdd);

                if (isAdd)
                {
                    SetBackgroundImage(mantra, getFoundImage(flagName));
                }
                else
                {
                    SetBackgroundImage(mantra, getBlankImage("w-soft-mantra-combo"));
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    bool showMantraPillarCombo = mantra.Image != null || mantra.BackgroundImage != null;
                    toggleVisibility(mantra, showMantraPillarCombo);
                }
            }
            else if (flagName.StartsWith("w-soft-"))
            {
                SetImage(flagName, isAdd);
                if ("w-soft-mekuri".Equals(flagName))
                {
                    if (isAdd)
                    {
                        this.mekuriCollected = true;
                        if (this.miracleCollected)
                        {
                            SetImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy);
                        }
                    }
                    else
                    {
                        this.mekuriCollected = false;
                        SetImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank);
                    }
                }
                else if ("w-soft-miracle".Equals(flagName))
                {
                    if (isAdd)
                    {
                        this.miracleCollected = true;
                        if (this.mekuriCollected)
                        {
                            SetImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy);
                        }
                    }
                    else
                    {
                        this.miracleCollected = false;
                        SetImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank);
                    }
                }
                else if("w-soft-reader".Equals(flagName))
                {
                    if(!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        if (isAdd)
                        {
                            readerPanel.Invoke(new Action(() =>
                            {
                                readerPanel.Size = new System.Drawing.Size(40, 56);
                            }));
                        }
                        else
                        {
                            readerPanel.Invoke(new Action(() =>
                            {
                                readerPanel.Size = new System.Drawing.Size(40, 40);
                            }));
                        }
                    }
                }
                else if ("w-soft-yagomap".Equals(flagName))
                {
                    UpdateCount(skullWallCount, isAdd, 4);
                }
                else if ("w-soft-yagostr".Equals(flagName))
                {
                    UpdateCount(skullWallCount, isAdd, 4);
                    if (isAdd)
                    {
                        SetImage(yagostr, getFoundImage(flagName));
                    }
                    else
                    {
                        SetImage(yagomap, getBlankImage(flagName));
                    }
                }
            }
            else if ("w-seal1".Equals(flagName) || "w-seal2".Equals(flagName) || "w-seal3".Equals(flagName) || "w-seal4".Equals(flagName))
            {
                SetImage(flagName, isAdd);
            }
            else if ("w-maternity".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(womanPanel, true);
                }
                //toggleVisibility(maternityStatue, isAdd);
                UpdatePanelControls(womanPanel, maternityStatue, womanStatue, isAdd);
            }
            else if ("w-vessel".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(vesselPanel, true);
                }

                UpdatePanelControls(vesselPanel, vessel, vesselNotFound, isAdd);
            }
            else if ("w-lamp".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(lampOfTimePanel, isAdd);
                }

                UpdatePanelControls(lampOfTimePanel, lampOfTime, lampOfTimeNotFound, isAdd);
            }
            else if ("w-djed".Equals(flagName))
            {
                SetImage(flagName, isAdd);
                if (isAdd)
                {
                    SetImage(mantra, global::LMRItemTracker.Properties.Resources.Icon_djedpillar_small);
                }
                else
                {
                    SetImage(mantra, null);
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    bool showMantraPillarCombo = mantra.Image != null || mantra.BackgroundImage != null;
                    toggleVisibility(mantra, showMantraPillarCombo);
                }
            }
            else if ("w-dragonbone".Equals(flagName))
            {
                UpdateCount(skullWallCount, isAdd, 4);
                SetImage(flagName, isAdd);
            }
            else if ("w-medicine-yellow".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind);
                }
                else
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_vessel); // todo: what if we don't have vessel?
                }
            }
            else if ("w-medicine-green".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind_green);
                }
                else
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_vessel); // todo: what if we don't have vessel?
                }
            }
            else if ("w-medicine-red".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind_red);
                }
                else
                {
                    SetImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_vessel); // todo: what if we don't have vessel?
                }
            }
        }

        private void UpdatePanelControls(Control panel, Control foundControl, Control blankControl, bool isAdd)
        {
            if (isAdd)
            {
                panel.Invoke(new Action(() =>
                {
                    panel.Controls.Add(foundControl);
                    panel.Controls.Remove(blankControl);
                }));
            }
            else
            {
                panel.Invoke(new Action(() =>
                {
                    panel.Controls.Add(blankControl);
                    panel.Controls.Remove(foundControl);
                }));
            }
        }

        private void toggleSubWeapon(string flagName, bool isAdd)
        {
            SetImage(flagName, isAdd);
            if ("w-sub-shuriken".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(shurikenPanel, isAdd);
                }
            }
            else if ("w-sub-rshuriken".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(rollingShurikenPanel, isAdd);
                }
            }
            else if ("w-sub-caltrops".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(caltropsPanel, isAdd);
                }
            }
            else if ("w-sub-spear".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(earthSpearPanel, isAdd);
                }
            }
            else if ("w-sub-flare".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(flareGunPanel, isAdd);
                }
            }
            else if ("w-sub-bomb".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(bombPanel, isAdd);
                }
            }
            else if ("w-sub-chakram".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(chakramPanel, isAdd);
                }
            }
            else if ("w-sub-pistol".Equals(flagName))
            {
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(pistolPanel, isAdd);
                }
            }
        }

        public void toggleGrail(string flagName, bool isAdd)
        {
            if ("invtr-grailfull".Equals(flagName))
            {
                toggleVisibility(grailFull, isAdd);
            }
            else if ("invtr-grailbr".Equals(flagName))
            {
                toggleVisibility(grailBroken, isAdd);
            }
        }

        internal void updateShield(string flagName, bool isAdd)
        {
            if ("shield-buckler".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(shieldsPanel, true);
                }
                bucklerCollected = isAdd;
                SetImage(flagName, isAdd);
                updateShields();
            }
            else if ("shield-silver".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(shieldsPanel, true);
                }
                silverShieldCollected = isAdd;
                updateShields();
            }
            else if ("shield-fake".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(shieldsPanel, true);
                }
                fakeShieldCollected = isAdd;
                updateShields();
            }
            else if ("shield-angel".Equals(flagName))
            {
                if (isAdd && Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(shieldsPanel, true);
                }
                angelShieldCollected = isAdd;
                updateShields();
            }
        }

        private void updateWhips()
        {
            whipsPanel.Invoke(new Action(() =>
            {
                if (flailWhipCollected)
                {
                    whipsPanel.Controls.Add(flailWhip);
                }
                else
                {
                    whipsPanel.Controls.Remove(flailWhip);
                }
                if (chainWhipCollected)
                {
                    whipsPanel.Controls.Add(chainWhip);
                }
                else
                {
                    whipsPanel.Controls.Remove(chainWhip);
                }
                if (whipCollected)
                {
                    whipsPanel.Controls.Add(whip);
                }
                else
                {
                    whipsPanel.Controls.Remove(whip);
                }
                whipsPanel.Refresh();
            }));
        }

        private void updateShields()
        {
            shieldsPanel.Invoke(new Action(() =>
            {
                if (angelShieldCollected)
                {
                    shieldsPanel.Controls.Add(angelShield);
                }
                else
                {
                    shieldsPanel.Controls.Remove(angelShield);
                }
                if (silverShieldCollected)
                {
                    shieldsPanel.Controls.Add(silverShield);
                }
                else
                {
                    shieldsPanel.Controls.Remove(silverShield);
                }
                if (fakeShieldCollected)
                {
                    shieldsPanel.Controls.Add(fakeSilverShield);
                }
                else
                {
                    shieldsPanel.Controls.Remove(fakeSilverShield);
                }
                if (bucklerCollected)
                {
                    shieldsPanel.Controls.Add(buckler);
                }
                else if(!angelShieldCollected && !silverShieldCollected && !fakeShieldCollected && "shaded".Equals(Properties.Settings.Default.BackgroundMode))
                {
                    shieldsPanel.Controls.Add(buckler);
                }
                else
                {
                    shieldsPanel.Controls.Remove(buckler);
                }
                shieldsPanel.Refresh();
            }));
        }

        internal void updateLampOfTime(string displayname, bool isAdd)
        {
            if ("invus-lamp-lit".Equals(displayname))
            {
                if (isAdd)
                {
                    SetImage(lampOfTime, global::LMRItemTracker.Properties.Resources.Icon_lampoftime);
                }
            }
            else if ("invus-lamp-unlit".Equals(displayname))
            {
                if (isAdd)
                {
                    SetImage(lampOfTime, global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit);
                }
            }
        }

        internal void updateTranslationTablets(byte cur)
        {
            translationTablets.Invoke(new Action(() =>
            {
                if(cur == 3)
                {
                    translationTablets.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                    translationTablets.Text = "100%";
                }
                else
                {
                    translationTablets.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
                    if (cur == 2)
                    {
                        translationTablets.Text = "60%";
                    }
                    else if (cur == 1)
                    {
                        translationTablets.Text = "20%";
                    }
                    else if (cur == 0)
                    {
                        translationTablets.Text = "0%";
                    }
                }
                translationTablets.Refresh();
            }));
        }

        public void setGameStarted(bool gameStarted)
        {
            this.gameStarted = gameStarted;
        }

        internal void UpdateLastItem(string flagName)
        {
            if(this.gameStarted)
            {
                lastItemPanel.Invoke(new Action(() =>
                {
                    System.Drawing.Bitmap lastItemImage = getFoundImage(flagName);
                    if (lastItemImage != null)
                    {
                        System.Drawing.Image lastItemImageTemp = lastItem2.Image;
                        if (lastItemImageTemp != null)
                        {
                            lastItem3.Image = lastItemImageTemp;
                            lastItem3.BackgroundImage = lastItem2.BackgroundImage;
                            lastItem2.Image = lastItem1.Image;
                            lastItem2.BackgroundImage = lastItem1.BackgroundImage;
                        }
                        else
                        {
                            lastItemImageTemp = lastItem1.Image;
                            if (lastItemImageTemp != null)
                            {
                                lastItem2.Image = lastItemImageTemp;
                                lastItem2.BackgroundImage = lastItem1.BackgroundImage;
                            }
                        }

                        lastItem1.Image = lastItemImage;
                        if ("w-map-shrine".Equals(flagName))
                        {
                            lastItem1.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
                        }
                        else
                        {
                            lastItem1.BackgroundImage = null;
                        }
                        lastItem1.Refresh();
                        lastItem2.Refresh();
                        lastItem3.Refresh();
                    }
                }));
            }
        }

        public void toggleBoss(string itemName, bool isAdd)
        {
            if ("boss-amphisbaena".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Boss_amphisbaena);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(amphisbaena, null);
                    }
                    else
                    {
                        SetBackgroundImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(amphisbaena, isAdd);
                }
            }
            else if ("boss-sakit".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(sakit, global::LMRItemTracker.Properties.Resources.Boss_sakit);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(sakit, null);
                    }
                    else
                    {
                        SetBackgroundImage(sakit, global::LMRItemTracker.Properties.Resources.Boss_sakit_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(sakit, isAdd);
                }
            }
            else if ("boss-ellmac".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(ellmac, global::LMRItemTracker.Properties.Resources.Boss_ellmac);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(ellmac, null);
                    }
                    else
                    {
                        SetBackgroundImage(ellmac, global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(ellmac, isAdd);
                }
            }
            else if ("boss-bahamut".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(bahamut, global::LMRItemTracker.Properties.Resources.Boss_bahamut);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(bahamut, null);
                    }
                    else
                    {
                        SetBackgroundImage(bahamut, global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(bahamut, isAdd);
                }
            }
            else if ("boss-viy".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(viy, global::LMRItemTracker.Properties.Resources.Boss_viy);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(viy, null);
                    }
                    else
                    {
                        SetBackgroundImage(viy, global::LMRItemTracker.Properties.Resources.Boss_viy_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(viy, isAdd);
                }
            }
            else if ("boss-palenque".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(palenque, global::LMRItemTracker.Properties.Resources.Boss_palenque);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(palenque, null);
                    }
                    else
                    {
                        SetBackgroundImage(palenque, global::LMRItemTracker.Properties.Resources.Boss_palenque_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(palenque, isAdd);
                }
            }
            else if ("boss-baphomet".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(baphomet, global::LMRItemTracker.Properties.Resources.Boss_baphomet);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(baphomet, null);
                    }
                    else
                    {
                        SetBackgroundImage(baphomet, global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(baphomet, isAdd);
                }
            }
            else if ("boss-tiamat".Equals(itemName))
            {
                if (isAdd)
                {
                    SetBackgroundImage(tiamat, global::LMRItemTracker.Properties.Resources.Boss_tiamat);
                }
                else
                {
                    if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
                    {
                        SetBackgroundImage(tiamat, null);
                    }
                    else
                    {
                        SetBackgroundImage(tiamat, global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank);
                    }
                }

                if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
                {
                    toggleVisibility(tiamat, isAdd);
                }
            }
        }

        public void toggleWhip(Boolean isAdd)
        {
            SetImage("whip", isAdd);
        }

        public void toggleMap(string flagName, Boolean isAdd)
        {
            UpdateCount(mapCount, isAdd, 17);
            if ("w-map-shrine".Equals(flagName))
            {
                UpdateCount(skullWallCount, isAdd, 4);
                if (isAdd)
                {
                    SetImage(maps, getFoundImage(flagName));
                }
                else
                {
                    SetImage(maps, null);
                }
            }
        }

        public void toggleMantra(string flagName, bool isAdd)
        {
            if ("mantra-keysword".Equals(flagName))
            {
                if (isAdd)
                {
                    this.mantrasRecited = true;
                    if (this.keySwordCollected)
                    {
                        SetImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened);
                    }
                }
                else
                {
                    this.mantrasRecited = false;
                    if (this.keySwordCollected)
                    {
                        SetImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword);
                    }
                }
            }
            else if ("mantra-amphisbaena".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(amphisbaena, null);
                }
            }
            else if ("mantra-sakit".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(sakit, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(sakit, null);
                }
            }
            else if ("mantra-ellmac".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(ellmac, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(ellmac, null);
                }
            }
            else if ("mantra-bahamut".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(bahamut, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(bahamut, null);
                }
            }
            else if ("mantra-viy".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(viy, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(viy, null);
                }
            }
            else if ("mantra-palenque".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(palenque, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(palenque, null);
                }
            }
            else if ("mantra-baphomet".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(baphomet, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(baphomet, null);
                }
            }
            else if ("mantra-tiamat".Equals(flagName))
            {
                if (isAdd)
                {
                    SetImage(tiamat, global::LMRItemTracker.Properties.Resources.Boss_sealed);
                }
                else
                {
                    SetImage(tiamat, null);
                }
            }
        }

        public void setAmmoCount(string flagName, int newCount)
        {
            if("ammo-shuriken".Equals(flagName))
            {
                UpdateCount(shurikenAmmoCount, newCount, 150);
            }
            else if ("ammo-roll-shuriken".Equals(flagName))
            {
                UpdateCount(rollingShurikenAmmoCount, newCount, 100);
            }
            else if ("ammo-spear".Equals(flagName))
            {
                UpdateCount(earthSpearAmmoCount, newCount, 80);
            }
            else if ("ammo-flare".Equals(flagName))
            {
                UpdateCount(flareGunAmmoCount, newCount, 80);
            }
            else if ("ammo-bomb".Equals(flagName))
            {
                UpdateCount(bombAmmoCount, newCount, 30);
            }
            else if ("ammo-chakram".Equals(flagName))
            {
                UpdateCount(chakramAmmoCount, newCount, 10);
            }
            else if ("ammo-caltrop".Equals(flagName))
            {
                UpdateCount(caltropsAmmoCount, newCount, 80);
            }
            else if ("ammo-clip".Equals(flagName))
            {
                updatePistolAmmoCount(pistolAmmoCount, true, newCount);
            }
            else if ("ammo-bullet".Equals(flagName))
            {
                updatePistolAmmoCount(pistolAmmoCount, false, newCount);
            }
            else if ("ankh-jewels".Equals(flagName))
            {
                bool isAdd = newCount != 0;
                SetImage(flagName, isAdd);
                if (Properties.Settings.Default.ShowAmmoCount)
                {
                    UpdateTextVisibility(ankhJewelPanel, isAdd);
                }
                UpdateCount(ankhJewelCount, newCount, 8);
            }
        }

        public void updateDeathCount(bool isAdd)
        {
            if (isAdd)
            {
                Properties.Settings.Default.DeathCount += 1;
            }
            else
            {
                Properties.Settings.Default.DeathCount -= 1;
            }
            UpdateCount(deathCount, Properties.Settings.Default.DeathCount, int.MaxValue);
        }

        private void LaMulanaItemTrackerForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;

                // Upgrade settings from 1.0.11 where item names were different.
                Properties.Settings.Default.Panel1Contents = Properties.Settings.Default.Panel1Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Panel2Contents = Properties.Settings.Default.Panel2Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Panel3Contents = Properties.Settings.Default.Panel3Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Panel4Contents = Properties.Settings.Default.Panel4Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Panel5Contents = Properties.Settings.Default.Panel5Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Panel6Contents = Properties.Settings.Default.Panel6Contents.Replace("Hermes Boots", "Hermes' Boots").Replace("Glyph Reader", "reader.exe");
                Properties.Settings.Default.Save();

                updateAlwaysOnTop();
                updateFormSize();
                updateFormColor();
                updateTextColor();
                updateShowLastItem();
                updateShowDeathCount();
                updateShowAmmoCount();
                if ("shaded".Equals(Properties.Settings.Default.BackgroundMode))
                {
                    readerPanel.Size = new System.Drawing.Size(40, 56);
                }
                else
                {
                    readerPanel.Size = new System.Drawing.Size(40, 40);
                }


                InitializeFormPanels();
            }

            try
            {
                this._assembly = Assembly.GetExecutingAssembly();
                this._xmlStream = _assembly.GetManifestResourceStream("LMRItemTracker.names.xml");
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }

            flagListener.RunWorkerAsync();
        }

        private void LaMulanaItemTrackerForm_DoubleClick(object sender, EventArgs e)
        {
            if (formColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackgroundColor = formColorDialog.Color;
                updateFormColor();
            }
        }

        private void textDoubleClick(object sender, EventArgs e)
        {
            if (textColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextColor = textColorDialog.Color;
                updateTextColor();
            }
        }

        private void addItemToPanel1(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel1.Controls.Count;
                    flowLayoutPanel1.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel1.Visible = true;

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, true);

                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private void addItemToPanel2(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel2.Controls.Count;
                    flowLayoutPanel2.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel2.Visible = true;

                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private void addItemToPanel3(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel3.Controls.Count;
                    flowLayoutPanel3.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel3.Visible = true;

                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private void addItemToPanel4(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel4.Controls.Count;
                    flowLayoutPanel4.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel4.Visible = true;

                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private void addItemToPanel5(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel5.Controls.Count;
                    flowLayoutPanel5.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel5.Visible = true;

                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private void addItemToPanel6(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    control.TabIndex = flowLayoutPanel6.Controls.Count;
                    flowLayoutPanel6.Controls.Add(control);
                    control.Margin = new Padding(0);
                    flowLayoutPanel6.Visible = true;

                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                }
            }
        }

        private void removeItemFromPanel(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if (control == null)
                {
                    MessageBox.Show("Problem removing " + itemName + " from panel");
                }
                else
                {
                    Control parent = control.Parent;
                    control.Parent = null;
                    if(parent.Controls.Count < 1)
                    {
                        parent.Visible = false;
                    }
                    else
                    {
                        for (int index = 0; index < parent.Controls.Count; index++)
                        {
                            parent.Controls[index].TabIndex = index;
                        }
                    }
                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                    Properties.Settings.Default.Panel6Contents = rebuildPanelContents(Properties.Settings.Default.Panel6Contents, itemName, false);
                }
            }
        }

        private System.Drawing.Bitmap getFoundImage(string flagName)
        {
            if (flagName.StartsWith("w-orb-"))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_sacredorb;
            }
            else if ("w-map-shrine".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dragonbone_small;
            }
            else if (flagName.StartsWith("w-map-"))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_map;
            }
            else if ("ankh-jewels".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            }
            else if ("w-scanner".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_handscanner;
            }
            else if ("w-grail".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_holygrail;
            }
            else if ("w-doll".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_minidoll;
            }
            else if ("w-magatama".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_magatamajewel;
            }
            else if ("w-pepper".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pepper;
            }
            else if ("w-woman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_womanstatue;
            }
            else if ("w-serpent".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_serpentstaff;
            }
            else if ("w-glove".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_glove;
            }
            else if ("w-crucifix".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_crucifix;
            }
            else if ("w-eye-truth".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth;
            }
            else if ("w-scale".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_scalesphere;
            }
            else if ("w-gauntlet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_gauntlet;
            }
            else if ("w-anchor".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_anchor;
            }
            else if ("w-book".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bookofthedead;
            }
            else if ("w-clothes".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_fairyclothes;
            }
            else if ("w-scriptures".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_scriptures;
            }
            else if ("w-bracelet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bracelet;
            }
            else if ("w-perfume".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_perfume;
            }
            else if ("w-spaulder".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_spaulder;
            }
            else if ("w-icecape".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_icecape;
            }
            else if ("w-talisman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_talisman;
            }
            else if ("w-diary".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_diary;
            }
            else if ("w-mulanatalisman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman;
            }
            else if ("w-dimension-key".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey;
            }
            else if ("w-djed".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
            }
            else if ("w-cog".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul;
            }
            else if ("w-dragonbone".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dragonbone;
            }
            else if ("w-cskull".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_crystalskull;
            }
            else if ("w-endless-key".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_keyofeternity;
            }
            else if ("w-isispendant".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_isispendant;
            }
            else if ("w-helmet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_helmet;
            }
            else if ("w-grapple".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_grappleclaw;
            }
            else if ("w-mirror".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bronzemirror;
            }
            else if ("w-ring".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_ring;
            }
            else if ("w-plane".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_planemodel;
            }
            else if ("w-ocarina".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina;
            }
            else if ("w-feather".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_feather;
            }
            else if ("w-hermes".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_hermesboots;
            }
            else if ("w-fruit".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_fruitofeden;
            }
            else if ("w-twin-statue".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_twinstatue;
            }
            else if ("w-treasures".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_treasures;
            }
            else if ("w-pochettekey".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pochettekey;
            }
            else if ("w-msx2".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_msx2;
            }
            else if ("w-vessel".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_vessel;
            }
            else if ("w-water-case".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_waterproofcase;
            }
            else if ("w-heat-case".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_heatproofcase;
            }
            else if ("w-shell-horn".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_shellhorn;
            }
            else if ("w-main-chain".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_chainwhip;
            }
            else if ("w-main-flail".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_flailwhip;
            }
            else if ("w-main-axe".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_axe;
            }
            else if ("w-main-knife".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_knife;
            }
            else if ("w-main-katana".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_katana;
            }
            else if ("w-main-keysword".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_keysword;
            }
            else if ("w-sub-shuriken".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_shuriken;
            }
            else if ("w-sub-rshuriken".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken;
            }
            else if ("w-sub-caltrops".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_caltrops;
            }
            else if ("w-sub-spear".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_earthspear;
            }
            else if ("w-sub-flare".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_flaregun;
            }
            else if ("w-sub-bomb".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bomb;
            }
            else if ("w-sub-chakram".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_chakram;
            }
            else if ("w-sub-pistol".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pistol;
            }
            else if ("w-seal1".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_originseal;
            }
            else if ("w-seal2".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_birthseal;
            }
            else if ("w-seal3".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lifeseal;
            }
            else if ("w-seal4".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_deathseal;
            }
            else if ("w-soft-reader".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_reader;
            }
            else if ("w-soft-mantra".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mantra;
            }
            else if ("w-soft-torude".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_torude;
            }
            else if ("w-soft-mekuri".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mekuri;
            }
            else if ("w-soft-miracle".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_miracle;
            }
            else if ("w-soft-mirai".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mirai;
            }
            else if ("w-soft-yagomap".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_yagomap;
            }
            else if ("w-soft-yagostr".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_yagostr;
            }
            else if ("w-soft-xmailer".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_xmailer;
            }
            else if ("w-soft-bunemon".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bunemon;
            }
            else if ("w-soft-bunplus".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bunplus;
            }
            else if ("w-soft-guild".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_guild;
            }
            else if ("w-soft-emusic".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_emusic;
            }
            else if ("w-soft-beolamu".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_beolamu;
            }
            else if ("w-soft-randc".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_randc;
            }
            else if ("w-soft-deathv".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_deathv;
            }
            else if ("w-soft-capstar".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_capstar;
            }
            else if ("w-soft-move".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_move;
            }
            else if ("w-soft-bounce".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bounce;
            }
            else if ("w-soft-lamulana".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lamulana;
            }
            else if ("shield-buckler".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_buckler;
            }
            else if ("shield-silver".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_silvershield;
            }
            else if ("shield-fake".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_silvershield2;
            }
            else if ("shield-angel".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_angelshield;
            }
            else if ("w-lamp".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lampoftime;
            }
            else if ("w-forbidden".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_swimsuit;
            }
            else if ("whip".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_whip;
            }
            return null;
        }

        private String getFlagName(string itemName)
        {
            if ("Hand Scanner".Equals(itemName))
            {
                return "w-scanner";
            }
            else if ("Holy Grail".Equals(itemName))
            {
                return "w-grail";
            }
            else if ("Mini Doll".Equals(itemName))
            {
                return "w-doll";
            }
            else if ("Magatama Jewel".Equals(itemName))
            {
                return "w-magatama";
            }
            else if ("Pepper".Equals(itemName))
            {
                return "w-pepper";
            }
            else if ("Woman Statue".Equals(itemName))
            {
                return "w-woman";
            }
            else if ("Serpent Staff".Equals(itemName))
            {
                return "w-serpent";
            }
            else if ("Glove".Equals(itemName))
            {
                return "w-glove";
            }
            else if ("Crucifix".Equals(itemName))
            {
                return "w-crucifix";
            }
            else if ("Eye of Truth".Equals(itemName))
            {
                return "w-eye-truth";
            }
            else if ("Scalesphere".Equals(itemName))
            {
                return "w-scale";
            }
            else if ("Gauntlet".Equals(itemName))
            {
                return "w-gauntlet";
            }
            else if ("Anchor".Equals(itemName))
            {
                return "w-anchor";
            }
            else if ("Book of the Dead".Equals(itemName))
            {
                return "w-book";
            }
            else if ("Fairy Clothes".Equals(itemName))
            {
                return "w-clothes";
            }
            else if ("Scriptures".Equals(itemName))
            {
                return "w-scriptures";
            }
            else if ("Bracelet".Equals(itemName))
            {
                return "w-bracelet";
            }
            else if ("Perfume".Equals(itemName))
            {
                return "w-perfume";
            }
            else if ("Spaulder".Equals(itemName))
            {
                return "w-spaulder";
            }
            else if ("Ice Cape".Equals(itemName))
            {
                return "w-icecape";
            }
            else if ("Talisman".Equals(itemName))
            {
                return "w-talisman";
            }
            else if ("Diary".Equals(itemName))
            {
                return "w-diary";
            }
            else if ("Mulana Talisman".Equals(itemName))
            {
                return "w-mulanatalisman";
            }
            else if ("Dimensional Key".Equals(itemName))
            {
                return "w-dimension-key";
            }
            else if ("Djed Pillar".Equals(itemName))
            {
                return "w-djed";
            }
            else if ("Cog of the Soul".Equals(itemName))
            {
                return "w-cog";
            }
            else if ("Dragon Bone".Equals(itemName))
            {
                return "w-dragonbone";
            }
            else if ("Crystal Skull".Equals(itemName))
            {
                return "w-cskull";
            }
            else if ("Key of Eternity".Equals(itemName))
            {
                return "w-endless-key";
            }
            else if ("Isis' Pendant".Equals(itemName))
            {
                return "w-isispendant";
            }
            else if ("Helmet".Equals(itemName))
            {
                return "w-helmet";
            }
            else if ("Grapple Claw".Equals(itemName))
            {
                return "w-grapple";
            }
            else if ("Bronze Mirror".Equals(itemName))
            {
                return "w-mirror";
            }
            else if ("Ring".Equals(itemName))
            {
                return "w-ring";
            }
            else if ("Plane Model".Equals(itemName))
            {
                return "w-plane";
            }
            else if ("Philosopher's Ocarina".Equals(itemName))
            {
                return "w-ocarina";
            }
            else if ("Feather".Equals(itemName))
            {
                return "w-feather";
            }
            else if ("Hermes' Boots".Equals(itemName))
            {
                return "w-hermes";
            }
            else if ("Fruit of Eden".Equals(itemName))
            {
                return "w-fruit";
            }
            else if ("Twin Statue".Equals(itemName))
            {
                return "w-twin-statue";
            }
            else if ("Treasures".Equals(itemName))
            {
                return "w-treasures";
            }
            else if ("Pochette Key".Equals(itemName))
            {
                return "w-pochettekey";
            }
            else if ("Mobile Super X2".Equals(itemName))
            {
                return "w-msx2";
            }
            else if ("Vessel/Medicine".Equals(itemName))
            {
                return "w-vessel";
            }
            else if ("Lamp of Time".Equals(itemName))
            {
                return "w-lamp";
            }
            else if ("Ankh Jewels".Equals(itemName))
            {
                return "ankh-jewels";
            }
            else if ("Waterproof Case".Equals(itemName))
            {
                return "w-water-case";
            }
            else if ("Heatproof Case".Equals(itemName))
            {
                return "w-heat-case";
            }
            else if ("Shell Horn".Equals(itemName))
            {
                return "w-shell-horn";
            }
            else if ("Whip".Equals(itemName))
            {
                return "whip";
            }
            else if ("Axe".Equals(itemName))
            {
                return "w-main-axe";
            }
            else if ("Knife".Equals(itemName))
            {
                return "w-main-knife";
            }
            else if ("Katana".Equals(itemName))
            {
                return "w-main-katana";
            }
            else if ("Key Sword".Equals(itemName))
            {
                return "w-main-keysword";
            }
            else if ("Shuriken".Equals(itemName))
            {
                return "w-sub-shuriken";
            }
            else if ("Rolling Shuriken".Equals(itemName))
            {
                return "w-sub-rshuriken";
            }
            else if ("Caltrops".Equals(itemName))
            {
                return "w-sub-caltrops";
            }
            else if ("Earth Spear".Equals(itemName))
            {
                return "w-sub-spear";
            }
            else if ("Flare Gun".Equals(itemName))
            {
                return "w-sub-flare";
            }
            else if ("Bomb".Equals(itemName))
            {
                return "w-sub-bomb";
            }
            else if ("Chakram".Equals(itemName))
            {
                return "w-sub-chakram";
            }
            else if ("Pistol".Equals(itemName))
            {
                return "w-sub-pistol";
            }
            else if ("Origin Seal".Equals(itemName))
            {
                return "w-seal1";
            }
            else if ("Birth Seal".Equals(itemName))
            {
                return "w-seal2";
            }
            else if ("Life Seal".Equals(itemName))
            {
                return "w-seal3";
            }
            else if ("Death Seal".Equals(itemName))
            {
                return "w-seal4";
            }
            else if ("reader.exe".Equals(itemName))
            {
                return "w-soft-reader";
            }
            else if ("mantra.exe".Equals(itemName))
            {
                return "w-soft-mantra";
            }
            else if ("Mantra/Djed Pillar".Equals(itemName))
            {
                return "w-soft-mantra";
            }
            else if ("torude.exe".Equals(itemName))
            {
                return "w-soft-torude";
            }
            else if ("mekuri.exe".Equals(itemName))
            {
                return "w-soft-mekuri";
            }
            else if ("miracle.exe".Equals(itemName))
            {
                return "w-soft-miracle";
            }
            else if ("mirai.exe".Equals(itemName))
            {
                return "w-soft-mirai";
            }
            else if ("yagomap.exe".Equals(itemName))
            {
                return "w-soft-yagomap";
            }
            else if ("yagostr.exe".Equals(itemName))
            {
                return "w-soft-yagostr";
            }
            else if ("xmailer.exe".Equals(itemName))
            {
                return "w-soft-xmailer";
            }
            else if ("bunemon.exe".Equals(itemName))
            {
                return "w-soft-bunemon";
            }
            else if ("bunplus.com".Equals(itemName))
            {
                return "w-soft-bunplus";
            }
            else if ("guild.exe".Equals(itemName))
            {
                return "w-soft-guild";
            }
            else if ("emusic.exe".Equals(itemName))
            {
                return "w-soft-emusic";
            }
            else if ("beolamu.exe".Equals(itemName))
            {
                return "w-soft-beolamu";
            }
            else if ("randc.exe".Equals(itemName))
            {
                return "w-soft-randc";
            }
            else if ("deathv.exe".Equals(itemName))
            {
                return "w-soft-deathv";
            }
            else if ("capstar.exe".Equals(itemName))
            {
                return "w-soft-capstar";
            }
            else if ("move.exe".Equals(itemName))
            {
                return "w-soft-move";
            }
            else if ("bounce.exe".Equals(itemName))
            {
                return "w-soft-bounce";
            }
            else if ("lamulana.exe".Equals(itemName))
            {
                return "w-soft-lamulana";
            }
            else if ("Shield".Equals(itemName))
            {
                return "shield-buckler";
            }
            else if ("Buckler".Equals(itemName))
            {
                return "shield-buckler";
            }
            else if ("Silver Shield".Equals(itemName))
            {
                return "shield-silver";
            }
            else if ("Fake Silver Shield".Equals(itemName))
            {
                return "shield-fake";
            }
            else if ("Angel Shield".Equals(itemName))
            {
                return "shield-angel";
            }
            else if ("Provocative Bathing Suit".Equals(itemName))
            {
                return "w-forbidden";
            }
            return null;
        }

        private System.Drawing.Bitmap getBlankImage(string flagName)
        {
            if (!Properties.Settings.Default.BackgroundMode.Equals("shaded"))
            {
                if ("w-soft-mantra-combo".Equals(flagName))
                {
                    return null;
                }
                return null;
            }

            if ("ankh-jewels".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_ankhjewel_blank;
            }
            if ("w-scanner".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
            }
            else if ("w-grail".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            }
            else if ("w-doll".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
            }
            else if ("w-magatama".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
            }
            else if ("w-pepper".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
            }
            else if ("w-woman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
            }
            else if ("w-serpent".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
            }
            else if ("w-glove".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
            }
            else if ("w-crucifix".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
            }
            else if ("w-eye-truth".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
            }
            else if ("w-scale".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
            }
            else if ("w-gauntlet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
            }
            else if ("w-anchor".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
            }
            else if ("w-book".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
            }
            else if ("w-clothes".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
            }
            else if ("w-scriptures".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
            }
            else if ("w-bracelet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
            }
            else if ("w-perfume".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
            }
            else if ("w-spaulder".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
            }
            else if ("w-icecape".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
            }
            else if ("w-talisman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            }
            else if ("w-diary".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            }
            else if ("w-mulanatalisman".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            }
            else if ("w-dimension-key".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
            }
            else if ("w-djed".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_djedpillar_blank;
            }
            else if ("w-cog".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            }
            else if ("w-dragonbone".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            }
            else if ("w-cskull".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            }
            else if ("w-endless-key".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
            }
            else if ("w-isispendant".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            }
            else if ("w-helmet".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
            }
            else if ("w-grapple".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
            }
            else if ("w-mirror".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
            }
            else if ("w-ring".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
            }
            else if ("w-plane".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            }
            else if ("w-ocarina".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            }
            else if ("w-feather".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
            }
            else if ("w-hermes".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
            }
            else if ("w-fruit".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
            }
            else if ("w-twin-statue".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
            }
            else if ("w-treasures".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            }
            else if ("w-pochettekey".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
            }
            else if ("w-msx2".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
            }
            else if ("w-lamp".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            }
            else if ("w-main-axe".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
            }
            else if ("w-main-keysword".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
            }
            else if ("w-main-knife".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
            }
            else if ("w-main-katana".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
            }
            else if ("w-sub-shuriken".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_shuriken_blank;
            }
            else if ("w-sub-rshuriken".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_blank;
            }
            else if ("w-sub-caltrops".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_caltrops_blank;
            }
            else if ("w-sub-spear".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_earthspear_blank;
            }
            else if ("w-sub-flare".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_flaregun_blank;
            }
            else if ("w-sub-bomb".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            }
            else if ("w-sub-chakram".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_chakram_blank;
            }
            else if ("w-sub-pistol".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_pistol_blank;
            }
            else if ("w-seal1".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            }
            else if ("w-seal2".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            }
            else if ("w-seal3".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            }
            else if ("w-seal4".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            }
            else if ("w-soft-reader".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
            }
            else if ("w-soft-mantra".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            }
            else if ("w-soft-torude".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
            }
            else if ("w-soft-mirai".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
            }
            else if ("w-soft-miracle".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_miracle_blank;
            }
            else if ("w-soft-yagomap".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_yagomap_blank;
            }
            else if ("w-soft-yagostr".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_yagostr_blank;
            }
            else if ("w-soft-xmailer".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_xmailer_blank;
            }
            else if ("w-soft-bunemon".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bunemon_blank;
            }
            else if ("w-soft-bunplus".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bunplus_blank;
            }
            else if ("w-soft-guild".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_guild_blank;
            }
            else if ("w-soft-emusic".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_emusic_blank;
            }
            else if ("w-soft-beolamu".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_beolamu_blank;
            }
            else if ("w-soft-randc".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_randc_blank;
            }
            else if ("w-soft-mekuri".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_mekuri_blank;
            }
            else if ("w-soft-deathv".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_deathv_blank;
            }
            else if ("w-soft-capstar".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            }
            else if ("w-soft-move".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_move_blank;
            }
            else if ("w-soft-bounce".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_bounce_blank;
            }
            else if ("w-soft-lamulana".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lamulana_blank;
            }
            else if ("shield-buckler".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            }
            else if ("w-forbidden".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_swimsuit_blank;
            }
            else if ("whip".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_whip_blank;
            }
            else if ("w-vessel".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            }
            else if ("w-shell-horn".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_shellhorn_blank;
            }
            else if ("w-heat-case".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_heatproofcase_blank;
            }
            else if ("w-water-case".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_waterproofcase_blank;
            }
            return null;
        }

        public Control GetControl(String itemName)
        {
            if ("Hermes' Boots".Equals(itemName))
            {
                return hermesBoots;
            }
            if ("Grapple Claw".Equals(itemName))
            {
                return grappleClaw;
            }
            if ("Feather".Equals(itemName))
            {
                return feather;
            }
            if ("Hand Scanner".Equals(itemName))
            {
                return scanner;
            }
            if ("mirai.exe".Equals(itemName))
            {
                return mirai;
            }
            if ("Bronze Mirror".Equals(itemName))
            {
                return bronzeMirror;
            }
            if ("Fruit of Eden".Equals(itemName))
            {
                return fruitOfEden;
            }
            if ("Twin Statue".Equals(itemName))
            {
                return twinStatue;
            }
            if ("Key of Eternity".Equals(itemName))
            {
                return keyOfEternity;
            }
            if ("Helmet".Equals(itemName))
            {
                return helmet;
            }
            if ("Plane Model".Equals(itemName))
            {
                return planeModel;
            }
            if ("Crystal Skull".Equals(itemName))
            {
                return crystalSkull;
            }
            if ("Dimensional Key".Equals(itemName))
            {
                return dimensionalKey;
            }
            if ("Djed Pillar".Equals(itemName))
            {
                return djedPillar;
            }
            if ("Pochette Key".Equals(itemName))
            {
                return pochetteKey;
            }
            if ("Ice Cape".Equals(itemName))
            {
                return iceCape;
            }
            if ("Scalesphere".Equals(itemName))
            {
                return scalesphere;
            }
            if ("Cog of the Soul".Equals(itemName))
            {
                return cogOfTheSoul;
            }
            if ("Dragon Bone".Equals(itemName))
            {
                return dragonBone;
            }
            if ("Serpent Staff".Equals(itemName))
            {
                return serpentStaff;
            }
            if ("Mulana Talisman".Equals(itemName))
            {
                return mulanaTalisman;
            }
            if ("Pepper".Equals(itemName))
            {
                return pepper;
            }
            if ("Talisman".Equals(itemName))
            {
                return talisman;
            }
            if ("Diary".Equals(itemName))
            {
                return diary;
            }
            if ("Mini Doll".Equals(itemName))
            {
                return miniDoll;
            }
            if ("Treasures".Equals(itemName))
            {
                return treasures;
            }
            if ("Anchor".Equals(itemName))
            {
                return anchor;
            }
            if ("Isis' Pendant".Equals(itemName))
            {
                return isisPendant;
            }
            if ("Eye of Truth".Equals(itemName))
            {
                return eyeOfTruth;
            }
            if ("Magatama Jewel".Equals(itemName))
            {
                return magatamaJewel;
            }
            if ("torude.exe".Equals(itemName))
            {
                return torude;
            }
            if ("Origin Seal".Equals(itemName))
            {
                return originSeal;
            }
            if ("Birth Seal".Equals(itemName))
            {
                return birthSeal;
            }
            if ("Life Seal".Equals(itemName))
            {
                return lifeSeal;
            }
            if ("Death Seal".Equals(itemName))
            {
                return deathSeal;
            }
            if ("Book of the Dead".Equals(itemName))
            {
                return bookOfTheDead;
            }
            if ("Ring".Equals(itemName))
            {
                return ring;
            }
            if ("Fairy Clothes".Equals(itemName))
            {
                return fairyClothes;
            }
            if ("Mobile Super X2".Equals(itemName))
            {
                return msx2;
            }
            if ("Scriptures".Equals(itemName))
            {
                return scriptures;
            }
            if ("Crucifix".Equals(itemName))
            {
                return crucifix;
            }
            if ("Perfume".Equals(itemName))
            {
                return perfume;
            }
            if ("Bracelet".Equals(itemName))
            {
                return bracelet;
            }
            if ("Glove".Equals(itemName))
            {
                return glove;
            }
            if ("Spaulder".Equals(itemName))
            {
                return spaulder;
            }
            if ("Knife".Equals(itemName))
            {
                return knife;
            }
            if ("Axe".Equals(itemName))
            {
                return axe;
            }
            if ("Katana".Equals(itemName))
            {
                return katana;
            }
            if ("Gauntlet".Equals(itemName))
            {
                return gauntlet;
            }
            if ("Philosopher's Ocarina".Equals(itemName))
            {
                return ocarina;
            }
            if ("Shell Horn".Equals(itemName))
            {
                return shellHorn;
            }
            if ("Waterproof Case".Equals(itemName))
            {
                return waterproofCase;
            }
            if ("Heatproof Case".Equals(itemName))
            {
                return heatproofCase;
            }
            if ("xmailer.exe".Equals(itemName))
            {
                return xmailer;
            }
            if ("mantra.exe".Equals(itemName))
            {
                return mantraSingle;
            }
            if ("yagomap.exe".Equals(itemName))
            {
                return yagomap;
            }
            if ("yagostr.exe".Equals(itemName))
            {
                return yagostr;
            }
            if ("bunemon.exe".Equals(itemName))
            {
                return bunemon;
            }
            if ("bunplus.com".Equals(itemName))
            {
                return bunplus;
            }
            if ("guild.exe".Equals(itemName))
            {
                return guild;
            }
            if ("emusic.exe".Equals(itemName))
            {
                return emusic;
            }
            if ("beolamu.exe".Equals(itemName))
            {
                return beolamu;
            }
            if ("deathv.exe".Equals(itemName))
            {
                return deathv;
            }
            if ("randc.exe".Equals(itemName))
            {
                return randc;
            }
            if ("capstar.exe".Equals(itemName))
            {
                return capstar;
            }
            if ("move.exe".Equals(itemName))
            {
                return move;
            }
            if ("mekuri.exe".Equals(itemName))
            {
                return mekuri;
            }
            if ("bounce.exe".Equals(itemName))
            {
                return bounce;
            }
            if ("miracle.exe".Equals(itemName))
            {
                return miracle;
            }
            if ("lamulana.exe".Equals(itemName))
            {
                return lamulana;
            }
            if ("Provocative Bathing Suit".Equals(itemName))
            {
                return swimsuit;
            }
            if ("reader.exe".Equals(itemName))
            {
                return readerPanel;
            }
            if ("Woman Statue".Equals(itemName))
            {
                return womanPanel;
            }
            if ("Key Fairy Combo".Equals(itemName))
            {
                return keyFairy;
            }
            if ("Shrine Wall Removal".Equals(itemName))
            {
                return shrinePanel;
            }
            if ("Holy Grail".Equals(itemName))
            {
                return grailPanel;
            }
            if ("Whip".Equals(itemName))
            {
                return whipsPanel;
            }
            if ("Shield".Equals(itemName))
            {
                return shieldsPanel;
            }
            if ("Shuriken".Equals(itemName))
            {
                return shurikenPanel;
            }
            if ("Rolling Shuriken".Equals(itemName))
            {
                return rollingShurikenPanel;
            }
            if ("Caltrops".Equals(itemName))
            {
                return caltropsPanel;
            }
            if ("Flare Gun".Equals(itemName))
            {
                return flareGunPanel;
            }
            if ("Chakram".Equals(itemName))
            {
                return chakramPanel;
            }
            if ("Earth Spear".Equals(itemName))
            {
                return earthSpearPanel;
            }
            if ("Bomb".Equals(itemName))
            {
                return bombPanel;
            }
            if ("Pistol".Equals(itemName))
            {
                return pistolPanel;
            }
            if ("Buckler".Equals(itemName))
            {
                return shieldsPanel;
            }
            if ("Mantra/Djed Pillar".Equals(itemName))
            {
                return mantra;
            }
            if ("Vessel/Medicine".Equals(itemName))
            {
                return vesselPanel;
            }
            if ("Key Sword".Equals(itemName))
            {
                return keySword;
            }
            if ("Lamp of Time".Equals(itemName))
            {
                return lampOfTimePanel;
            }
            if ("Maps".Equals(itemName))
            {
                return mapsPanel;
            }
            if ("Ankh Jewels".Equals(itemName))
            {
                return ankhJewelPanel;
            }
            return null;
        }

        public PictureBox GetFoundImagePictureBox(String itemName)
        {
            if ("Lamp of Time".Equals(itemName))
            {
                return lampOfTime;
            }
            if ("Vessel/Medicine".Equals(itemName))
            {
                return vessel;
            }
            return GetBlankImagePictureBox(itemName);
        }

        public PictureBox GetBlankImagePictureBox(String itemName)
        {
            if ("Whip".Equals(itemName))
            {
                return whip;
            }
            if ("Knife".Equals(itemName))
            {
                return knife;
            }
            if ("Key Sword".Equals(itemName))
            {
                return keySword;
            }
            if ("Axe".Equals(itemName))
            {
                return axe;
            }
            if ("Katana".Equals(itemName))
            {
                return katana;
            }
            if ("Shuriken".Equals(itemName))
            {
                return shuriken;
            }
            if ("Rolling Shuriken".Equals(itemName))
            {
                return rollingShuriken;
            }
            if ("Earth Spear".Equals(itemName))
            {
                return earthSpear;
            }
            if ("Flare Gun".Equals(itemName))
            {
                return flareGun;
            }
            if ("Bomb".Equals(itemName))
            {
                return bomb;
            }
            if ("Chakram".Equals(itemName))
            {
                return chakram;
            }
            if ("Caltrops".Equals(itemName))
            {
                return caltrops;
            }
            if ("Pistol".Equals(itemName))
            {
                return pistol;
            }
            if ("Buckler".Equals(itemName))
            {
                return buckler;
            }
            if ("Shield".Equals(itemName))
            {
                return buckler;
            }
            if ("Ankh Jewels".Equals(itemName))
            {
                return ankhJewels;
            }
            if ("Hand Scanner".Equals(itemName))
            {
                return scanner;
            }
            if ("Djed Pillar".Equals(itemName))
            {
                return djedPillar;
            }
            if ("Mini Doll".Equals(itemName))
            {
                return miniDoll;
            }
            if ("Magatama Jewel".Equals(itemName))
            {
                return magatamaJewel;
            }
            if ("Cog of the Soul".Equals(itemName))
            {
                return cogOfTheSoul;
            }
            if ("Lamp of Time".Equals(itemName))
            {
                return lampOfTimeNotFound;
            }
            if ("Pochette Key".Equals(itemName))
            {
                return pochetteKey;
            }
            if ("Dragon Bone".Equals(itemName))
            {
                return dragonBone;
            }
            if ("Crystal Skull".Equals(itemName))
            {
                return crystalSkull;
            }
            if ("Vessel/Medicine".Equals(itemName))
            {
                return vesselNotFound;
            }
            if ("Pepper".Equals(itemName))
            {
                return pepper;
            }
            if ("Woman Statue".Equals(itemName))
            {
                return womanStatue;
            }
            if ("Key of Eternity".Equals(itemName))
            {
                return keyOfEternity;
            }
            if ("Serpent Staff".Equals(itemName))
            {
                return serpentStaff;
            }
            if ("Talisman".Equals(itemName))
            {
                return talisman;
            }
            if ("Diary".Equals(itemName))
            {
                return diary;
            }
            if ("Mulana Talisman".Equals(itemName))
            {
                return mulanaTalisman;
            }
            if ("Mobile Super X2".Equals(itemName))
            {
                return msx2;
            }
            if ("Waterproof Case".Equals(itemName))
            {
                return waterproofCase;
            }
            if ("Heatproof Case".Equals(itemName))
            {
                return heatproofCase;
            }
            if ("Shell Horn".Equals(itemName))
            {
                return shellHorn;
            }
            if ("Glove".Equals(itemName))
            {
                return glove;
            }
            if ("Holy Grail".Equals(itemName))
            {
                return grail;
            }
            if ("Isis' Pendant".Equals(itemName))
            {
                return isisPendant;
            }
            if ("Crucifix".Equals(itemName))
            {
                return crucifix;
            }
            if ("Helmet".Equals(itemName))
            {
                return helmet;
            }
            if ("Grapple Claw".Equals(itemName))
            {
                return grappleClaw;
            }
            if ("Bronze Mirror".Equals(itemName))
            {
                return bronzeMirror;
            }
            if ("Eye of Truth".Equals(itemName))
            {
                return eyeOfTruth;
            }
            if ("Ring".Equals(itemName))
            {
                return ring;
            }
            if ("Scalesphere".Equals(itemName))
            {
                return scalesphere;
            }
            if ("Gauntlet".Equals(itemName))
            {
                return gauntlet;
            }
            if ("Treasures".Equals(itemName))
            {
                return treasures;
            }
            if ("Anchor".Equals(itemName))
            {
                return anchor;
            }
            if ("Plane Model".Equals(itemName))
            {
                return planeModel;
            }
            if ("Philosopher's Ocarina".Equals(itemName))
            {
                return ocarina;
            }
            if ("Feather".Equals(itemName))
            {
                return feather;
            }
            if ("Book of the Dead".Equals(itemName))
            {
                return bookOfTheDead;
            }
            if ("Fairy Clothes".Equals(itemName))
            {
                return fairyClothes;
            }
            if ("Scriptures".Equals(itemName))
            {
                return scriptures;
            }
            if ("Hermes' Boots".Equals(itemName))
            {
                return hermesBoots;
            }
            if ("Fruit of Eden".Equals(itemName))
            {
                return fruitOfEden;
            }
            if ("Twin Statue".Equals(itemName))
            {
                return twinStatue;
            }
            if ("Bracelet".Equals(itemName))
            {
                return bracelet;
            }
            if ("Perfume".Equals(itemName))
            {
                return perfume;
            }
            if ("Spaulder".Equals(itemName))
            {
                return spaulder;
            }
            if ("Dimensional Key".Equals(itemName))
            {
                return dimensionalKey;
            }
            if ("Ice Cape".Equals(itemName))
            {
                return iceCape;
            }
            if ("Origin Seal".Equals(itemName))
            {
                return originSeal;
            }
            if ("Birth Seal".Equals(itemName))
            {
                return birthSeal;
            }
            if ("Life Seal".Equals(itemName))
            {
                return lifeSeal;
            }
            if ("Death Seal".Equals(itemName))
            {
                return deathSeal;
            }
            if ("reader.exe".Equals(itemName))
            {
                return reader;
            }
            if ("xmailer.exe".Equals(itemName))
            {
                return xmailer;
            }
            if ("yagomap.exe".Equals(itemName))
            {
                return yagomap;
            }
            if ("yagostr.exe".Equals(itemName))
            {
                return yagostr;
            }
            if ("bunemon.exe".Equals(itemName))
            {
                return bunemon;
            }
            if ("bunplus.com".Equals(itemName))
            {
                return bunplus;
            }
            if ("torude.exe".Equals(itemName))
            {
                return torude;
            }
            if ("guild.exe".Equals(itemName))
            {
                return guild;
            }
            if ("mantra.exe".Equals(itemName))
            {
                return mantraSingle;
            }
            if ("emusic.exe".Equals(itemName))
            {
                return emusic;
            }
            if ("beolamu.exe".Equals(itemName))
            {
                return beolamu;
            }
            if ("deathv.exe".Equals(itemName))
            {
                return deathv;
            }
            if ("randc.exe".Equals(itemName))
            {
                return randc;
            }
            if ("capstar.exe".Equals(itemName))
            {
                return capstar;
            }
            if ("move.exe".Equals(itemName))
            {
                return move;
            }
            if ("mekuri.exe".Equals(itemName))
            {
                return mekuri;
            }
            if ("bounce.exe".Equals(itemName))
            {
                return bounce;
            }
            if ("miracle.exe".Equals(itemName))
            {
                return miracle;
            }
            if ("mirai.exe".Equals(itemName))
            {
                return mirai;
            }
            if ("lamulana.exe".Equals(itemName))
            {
                return lamulana;
            }
            if ("Provocative Bathing Suit".Equals(itemName))
            {
                return swimsuit;
            }
            if ("Mantra/Djed Pillar".Equals(itemName))
            {
                return mantra;
            }
            return null;
        }

        private ToolStripMenuItem CreateMenuItem(String itemName, EventHandler eventHandler)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Text = itemName;
            if (eventHandler != null)
            {
                menuItem.Click += eventHandler;
            }
            return menuItem;
        }

        private String rebuildPanelContents(String currentSettingString, String itemName, Boolean add)
        {
            List<String> itemsInPanel = new List<String>(currentSettingString.Split(','));
            itemsInPanel.Remove(itemName); // In case it's already there (re-adding will move an item to the end)
            if (add)
            {
                itemsInPanel.Add(itemName);
            }
            return String.Join(",", itemsInPanel);
        }

        private void updateFormSize()
        {
            this.Width = Properties.Settings.Default.FormWidth;
            this.Height = Properties.Settings.Default.FormHeight;
        }

        private void updateBackgroundMode()
        {
            if (Properties.Settings.Default.BackgroundMode.Equals("shaded"))
            {
                shadedImageToolStripMenuItem.Checked = true;
                noImageToolStripMenuItem.Checked = false;
                hideImageToolStripMenuItem.Checked = false;
            }
            else if (Properties.Settings.Default.BackgroundMode.Equals("blank"))
            {
                shadedImageToolStripMenuItem.Checked = false;
                noImageToolStripMenuItem.Checked = true;
                hideImageToolStripMenuItem.Checked = false;
            }
            else
            {
                shadedImageToolStripMenuItem.Checked = false;
                noImageToolStripMenuItem.Checked = false;
                hideImageToolStripMenuItem.Checked = true;
            }
        }

        private void updateShowLastItem()
        {
            if(Properties.Settings.Default.ShowLastItem)
            {
                if(lastItemPanel.Parent == null)
                {
                    overviewPanel.Controls.Add(lastItemPanel);
                }
            }
            else
            {
                lastItemPanel.Parent = null;
            }
            showLastItemToolStripMenuItem.Checked = Properties.Settings.Default.ShowLastItem;
        }

        private void updateAlwaysOnTop()
        {
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
            alwaysOnTopToolStripMenuItem.Checked = Properties.Settings.Default.AlwaysOnTop;
        }

        private void updateShowAmmoCount()
        {
            shurikenPanel.Size = GetAmmoPanelSize(shurikenAmmoCount.Text);
            rollingShurikenPanel.Size = GetAmmoPanelSize(rollingShurikenAmmoCount.Text);
            caltropsPanel.Size = GetAmmoPanelSize(caltropsAmmoCount.Text);
            flareGunPanel.Size = GetAmmoPanelSize(flareGunAmmoCount.Text);
            chakramPanel.Size = GetAmmoPanelSize(chakramAmmoCount.Text);
            earthSpearPanel.Size = GetAmmoPanelSize(earthSpearAmmoCount.Text);
            bombPanel.Size = GetAmmoPanelSize(bombAmmoCount.Text);
            pistolPanel.Size = GetAmmoPanelSize(pistolAmmoCount.Text);
            ankhJewelPanel.Size = GetAmmoPanelSize(ankhJewelCount.Text);

            showAmmoCountToolStripMenuItem.Checked = Properties.Settings.Default.ShowAmmoCount;
        }

        private void updateShowDeathCount()
        {
            showDeathCountToolStripMenuItem.Checked = Properties.Settings.Default.ShowDeathCount;
            UpdateCount(deathCount, Properties.Settings.Default.DeathCount, int.MaxValue);
            deathPanel.Visible = Properties.Settings.Default.ShowDeathCount;
        }

        private System.Drawing.Size GetAmmoPanelSize(String panelCountText)
        {
            if (!Properties.Settings.Default.ShowAmmoCount && !panelCountText.Contains("%"))
                return new System.Drawing.Size(40, 40);
            else if ("shaded".Equals(Properties.Settings.Default.BackgroundMode))
                return new System.Drawing.Size(40, 56);
            else if ("0".Equals(panelCountText) || "0:0".Equals(panelCountText) || "0%".Equals(panelCountText))
                return new System.Drawing.Size(40, 40);
            return new System.Drawing.Size(40, 56);
        }

        private void updateFormColor()
        {
            this.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        private void updateTextColor()
        {
            this.mapCount.ForeColor = Properties.Settings.Default.TextColor;
            this.ankhJewelCount.ForeColor = Properties.Settings.Default.TextColor;
            this.translationTablets.ForeColor = Properties.Settings.Default.TextColor;
            this.skullWallCount.ForeColor = Properties.Settings.Default.TextColor;
            this.lastItemLabel.ForeColor = Properties.Settings.Default.TextColor;
            this.deathLabel.ForeColor = Properties.Settings.Default.TextColor;
            this.deathCount.ForeColor = Properties.Settings.Default.TextColor;
            this.shurikenAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.rollingShurikenAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.caltropsAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.flareGunAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.chakramAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.earthSpearAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.bombAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
            this.pistolAmmoCount.ForeColor = Properties.Settings.Default.TextColor;
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.Save();
            settingsBackup = new SettingsBackup();
        }

        private void restoreDefaultSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.Panel1Contents = "Hermes' Boots,Grapple Claw,Feather,Hand Scanner,reader.exe,Holy Grail,mirai.exe";
            Properties.Settings.Default.Panel2Contents = "Bronze Mirror,Fruit of Eden,Twin Statue,Key of Eternity,Helmet,Plane Model,Crystal Skull,Dimensional Key,Pochette Key,Ice Cape,Scalesphere,Cog of the Soul,Dragon Bone,Serpent Staff,Mulana Talisman,Woman Statue,Pepper,Talisman,Diary,Mini Doll,Treasures,Anchor,Key Fairy Combo,Isis' Pendant,Eye of Truth,Magatama Jewel,torude.exe,Shrine Wall Removal";
            Properties.Settings.Default.Panel3Contents = "Origin Seal,Birth Seal,Life Seal,Death Seal,Book of the Dead,Ring,Fairy Clothes,Mobile Super X2,Scriptures,Crucifix,Perfume,Glove,Bracelet,Spaulder";
            Properties.Settings.Default.Panel4Contents = "Whip,Knife,Axe,Katana,Shield,Gauntlet,Pistol,Shuriken,Rolling Shuriken,Caltrops,Flare Gun,Chakram,Earth Spear,Bomb";
            Properties.Settings.Default.Panel5Contents = "Philosopher's Ocarina,Mantra/Djed Pillar,Vessel/Medicine,Key Sword,Lamp of Time,Maps,Ankh Jewels";
            Properties.Settings.Default.BackgroundColor = System.Drawing.SystemColors.Control;
            Properties.Settings.Default.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            Properties.Settings.Default.FormWidth = 356;
            Properties.Settings.Default.FormHeight = 822;
            Properties.Settings.Default.BackgroundMode = "shaded";
            Properties.Settings.Default.ShowLastItem = true;
            Properties.Settings.Default.AlwaysOnTop = true;
            Properties.Settings.Default.ShowAmmoCount = true;
            Properties.Settings.Default.ShowDeathCount = true;
            Properties.Settings.Default.DeathCount = 0;

            updateAlwaysOnTop();
            updateShowAmmoCount();
            updateFormSize();
            updateFormColor();
            updateTextColor();
            updateShowLastItem();
            InitializeFormPanels();
            this.Refresh();
        }

        private void toggleVisibility(Control control, bool visible)
        {
            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new Action(() =>
                    {
                        if (control.Visible != visible)
                        {
                            int controlIndex = control.TabIndex;
                            control.Visible = visible;
                            if (control.HasChildren)
                            {
                                foreach (Control child in control.Controls)
                                {
                                    control.Controls.SetChildIndex(child, child.TabIndex);
                                }
                            }
                            control.Refresh();
                        }
                    }));
                }
                else
                {
                    if (control.Visible != visible)
                    {
                        // In case this isn't an active form control right now.
                        int controlIndex = control.TabIndex;
                        if (control.HasChildren)
                        {
                            foreach (Control child in control.Controls)
                            {
                                control.Controls.SetChildIndex(child, child.TabIndex);
                            }
                        }
                        control.Visible = visible;
                    }
                }
            }
        }

        private void SetImage(String flagName, bool isAdd)
        {
            String itemName = getItemName(flagName);
            if (Properties.Settings.Default.BackgroundMode.Equals("hide"))
            {
                toggleVisibility(GetControl(itemName), isAdd);
            }

            if (isAdd)
            {
                SetImage(GetFoundImagePictureBox(itemName), getFoundImage(flagName));
            }
            else
            {
                SetImage(GetBlankImagePictureBox(getItemName(flagName)), getBlankImage(flagName));
            }
        }

        private void SetImage(PictureBox pictureBox, System.Drawing.Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() =>
                {
                    pictureBox.Image = image;
                    pictureBox.Refresh();
                }));
            }
            else
            {
                // In case this isn't an active form control right now.
                pictureBox.Image = image;
            }
        }

        private void UpdateTextVisibility(Control panel, bool showText)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() =>
                {
                    if (showText)
                    {
                        panel.Size = new System.Drawing.Size(40, 56);
                    }
                    else if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                    {
                        panel.Size = new System.Drawing.Size(40, 40);
                    }
                }));
            }
            else
            {
                // In case this isn't an active form control right now.
                if (showText)
                {
                    panel.Size = new System.Drawing.Size(40, 56);
                }
                else if (!"shaded".Equals(Properties.Settings.Default.BackgroundMode))
                {
                    panel.Size = new System.Drawing.Size(40, 40);
                }
            }
        }

        private void SetBackgroundImage(PictureBox pictureBox, System.Drawing.Image image)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() =>
                {
                    pictureBox.BackgroundImage = image;
                    pictureBox.Refresh();
                }));
            }
            else
            {
                pictureBox.BackgroundImage = image;
            }
        }

        private void UpdateCount(Label label, bool isAdd, int max)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() =>
                {
                    int existingCount = Int32.Parse(label.Text.Substring(0, label.Text.IndexOf('/')));
                    if (isAdd)
                    {
                        if (existingCount < max)
                        {
                            label.Text = (existingCount + 1) + "/" + max;
                            label.Refresh();
                        }
                    }
                    else
                    {
                        if (existingCount > 0)
                        {
                            label.Text = (existingCount - 1) + "/" + max;
                            label.Refresh();
                        }
                    }
                }));
            }
            else
            {
                // In case this is not a current component
                int existingCount = Int32.Parse(label.Text.Substring(0, label.Text.IndexOf('/')));
                if (isAdd)
                {
                    if (existingCount < max)
                    {
                        label.Text = (existingCount + 1) + "/" + max;
                    }
                }
                else
                {
                    if (existingCount > 0)
                    {
                        label.Text = (existingCount - 1) + "/" + max;
                    }
                }
            }
        }

        private void UpdateCount(Label label, int newCount, int max)
        {
            if (newCount >= 0 && newCount <= max)
            {
                if (label.InvokeRequired)
                {
                    label.Invoke(new Action(() =>
                    {
                        label.Text = "" + newCount;
                        label.Refresh();
                    }));
                }
                else
                {
                    label.Text = "" + newCount;
                }
            }
        }

        private void updatePistolAmmoCount(Label label, bool clip, int newCount)
        {
            if (clip)
            {
                if (newCount >= 0 && newCount <= 3)
                {
                    if (label.InvokeRequired)
                    {
                        label.Invoke(new Action(() =>
                        {
                            label.Text = newCount + ":" + label.Text.Substring(label.Text.IndexOf(':'));
                            label.Refresh();
                        }));
                    }
                    else
                    {
                        label.Text = newCount + ":" + label.Text.Substring(label.Text.IndexOf(':'));
                    }
                }
            }
            else if (newCount >= 0 && newCount <= 6)
            {
                if (label.InvokeRequired)
                {
                    label.Invoke(new Action(() =>
                    {
                        label.Text = label.Text.Substring(0, label.Text.IndexOf(':')) + ":" + newCount;
                        label.Refresh();
                    }));
                }
                else
                {
                    label.Text = label.Text.Substring(0, label.Text.IndexOf(':')) + ":" + newCount;
                }
            }
        }

        private void toggleShowLastItem(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowLastItem = !Properties.Settings.Default.ShowLastItem;
            updateShowLastItem();
        }

        private void clearLastItem(object sender, EventArgs e)
        {
            lastItem1.Invoke(new Action(() =>
            {
                lastItem1.Image = null;
                lastItem1.BackgroundImage = null;
                lastItem1.Refresh();
            }));
            lastItem2.Invoke(new Action(() =>
            {
                lastItem2.Image = null;
                lastItem2.BackgroundImage = null;
                lastItem2.Refresh();
            }));
            lastItem3.Invoke(new Action(() =>
            {
                lastItem3.Image = null;
                lastItem3.BackgroundImage = null;
                lastItem3.Refresh();
            }));
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            lastItemLabel.Invoke(new Action(() =>
            {
                if(lastItemLabel.Text.Equals("Recent Items:"))
                {
                    lastItemLabel.Text = "最近:";
                }
                else
                {
                    lastItemLabel.Text = "Recent Items:";
                }
                lastItemLabel.Refresh();
            }));
        }

        private void toggleTopMost(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysOnTop = !Properties.Settings.Default.AlwaysOnTop;
            updateAlwaysOnTop();
        }

        private void toggleAmmoCount(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowAmmoCount = !Properties.Settings.Default.ShowAmmoCount;
            updateShowAmmoCount();
        }

        private void toggleDeathCount(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowDeathCount = !Properties.Settings.Default.ShowDeathCount;
            updateShowDeathCount();
        }

        private void setHideUncollected(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundMode = "hide";
            Properties.Settings.Default.Save();
            updateBackgroundMode();
            MessageBox.Show("Your settings have been saved. Please restart to allow them to take effect.");
        }

        private void setBlankUncollected(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundMode = "blank";
            Properties.Settings.Default.Save();
            updateBackgroundMode();
            MessageBox.Show("Your settings have been saved. Please restart to allow them to take effect.");
        }

        private void setShadedUncollected(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundMode = "shaded";
            Properties.Settings.Default.Save();
            updateBackgroundMode();
            MessageBox.Show("Your settings have been saved. Please restart to allow them to take effect.");
        }

        private void resetDeathCount(object sender, EventArgs e)
        {
            Properties.Settings.Default.DeathCount = 0;
            UpdateCount(deathCount, Properties.Settings.Default.DeathCount, int.MaxValue);
        }

        private void deathCount_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                updateDeathCount(true);
            }
            else if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                updateDeathCount(false);
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            settingsBackup.RestoreSettings();
            Properties.Settings.Default.Save();
        }
    }
}
