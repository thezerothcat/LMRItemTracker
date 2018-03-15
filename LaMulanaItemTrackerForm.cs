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

            this.buckler.VisibleChanged += new System.EventHandler(this.setBucklerIndex);
            this.silverShield.VisibleChanged += new System.EventHandler(this.setSilverShieldIndex);
            this.angelShield.VisibleChanged += new System.EventHandler(this.setAngelShieldIndex);
            this.chainWhip.VisibleChanged += new System.EventHandler(this.setChainWhipIndex);
            this.flailWhip.VisibleChanged += new System.EventHandler(this.setFlailWhipIndex);

            updateFormSize();
            updateFormColor();
            updateTextColor();
            updateLastItem();
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
            this.allItems = new List<String>(70);
            this.allItems.Add("Anchor");
            this.allItems.Add("Ankh Jewels");
            this.allItems.Add("Axe");
            this.allItems.Add("Birth Seal");
            this.allItems.Add("Bomb");
            this.allItems.Add("Book of the Dead");
            this.allItems.Add("Bracelet");
            this.allItems.Add("Bronze Mirror");
            this.allItems.Add("Caltrops");
            this.allItems.Add("Chakram");
            this.allItems.Add("Cog of the Soul");
            this.allItems.Add("Crucifix");
            this.allItems.Add("Crystal Skull");
            this.allItems.Add("Death Seal");
            this.allItems.Add("Diary");
            this.allItems.Add("Dimensional Key");
            this.allItems.Add("Dragon Bone");
            this.allItems.Add("Earth Spear");
            this.allItems.Add("Eye of Truth");
            this.allItems.Add("Fairy Clothes");
            this.allItems.Add("Feather");
            this.allItems.Add("Flare Gun");
            this.allItems.Add("Fruit of Eden");
            this.allItems.Add("Gauntlet");
            this.allItems.Add("Glove");
            this.allItems.Add("Glyph Reader");
            this.allItems.Add("Grapple Claw");
            this.allItems.Add("Hand Scanner");
            this.allItems.Add("Helmet");
            this.allItems.Add("Hermes Boots");
            this.allItems.Add("Holy Grail");
            this.allItems.Add("Ice Cape");
            this.allItems.Add("Isis' Pendant");
            this.allItems.Add("Katana");
            this.allItems.Add("Key Fairy Combo");
            this.allItems.Add("Key of Eternity");
            this.allItems.Add("Key Sword");
            this.allItems.Add("Knife");
            this.allItems.Add("Lamp of Time");
            this.allItems.Add("Life Seal");
            this.allItems.Add("Magatama Jewel");
            this.allItems.Add("Mantra/Djed Pillar");
            this.allItems.Add("Maps");
            this.allItems.Add("Mini Doll");
            this.allItems.Add("mirai.exe");
            this.allItems.Add("Mobile Super X2");
            this.allItems.Add("Mulana Talisman");
            this.allItems.Add("Origin Seal");
            this.allItems.Add("Pepper");
            this.allItems.Add("Perfume");
            this.allItems.Add("Philosopher's Ocarina");
            this.allItems.Add("Pistol");
            this.allItems.Add("Plane Model");
            this.allItems.Add("Pochette Key");
            this.allItems.Add("Ring");
            this.allItems.Add("Rolling Shuriken");
            this.allItems.Add("Scalesphere");
            this.allItems.Add("Scriptures");
            this.allItems.Add("Serpent Staff");
            this.allItems.Add("Shield");
            this.allItems.Add("Shrine Wall Removal");
            this.allItems.Add("Shuriken");
            this.allItems.Add("Spaulder");
            this.allItems.Add("Talisman");
            this.allItems.Add("torude.exe");
            this.allItems.Add("Treasures");
            this.allItems.Add("Twin Statue");
            this.allItems.Add("Vessel/Medicine");
            this.allItems.Add("Whip");
            this.allItems.Add("Woman Statue");
        }

        private void InitializeFormPanels()
        {
            foreach (String item in this.allItems)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    control.Parent = null;
                }
            }

            List<String> itemsInPanel = new List<String>(Properties.Settings.Default.Panel1Contents.Split(','));
            foreach(String item in itemsInPanel)
            {
                Control control = GetControl(item);
                if(control != null)
                {
                    flowLayoutPanel1.Controls.Add(control);
                    control.Margin = new Padding(0);
                }
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel2Contents.Split(','));
            foreach (String item in itemsInPanel)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel2.Controls.Add(control);
                    control.Margin = new Padding(0);
                }
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel3Contents.Split(','));
            foreach (String item in itemsInPanel)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel3.Controls.Add(control);
                    control.Margin = new Padding(0);
                }
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel4Contents.Split(','));
            foreach (String item in itemsInPanel)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel4.Controls.Add(control);
                    control.Margin = new Padding(0);
                }
            }

            itemsInPanel = new List<String>(Properties.Settings.Default.Panel5Contents.Split(','));
            foreach (String item in itemsInPanel)
            {
                Control control = GetControl(item);
                if (control != null)
                {
                    flowLayoutPanel5.Controls.Add(control);
                    control.Margin = new Padding(0);
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
            e.Result = LMRItemTracker.Program.DoStuff(this, this._xmlStream);
        }

        public void toggleItem(string flagName, bool isAdd)
        {
            if (flagName.StartsWith("w-main-"))
            {
                toggleMainWeapon(flagName, isAdd);
            }
            else if (flagName.StartsWith("w-sub-"))
            {
                toggleSubWeapon(flagName, isAdd);
            }
            else if (flagName.StartsWith("w-soft-"))
            {
                toggleSoftware(flagName, isAdd);
            }
            else if (flagName.StartsWith("w-seal"))
            {
                toggleSeal(flagName, isAdd);
            }
            else if ("w-maternity".Equals(flagName))
            {
                toggleImage(maternityStatue, isAdd);
            }
            else if ("w-vessel".Equals(flagName))
            {
                toggleImage(vesselNotFound, !isAdd);
            }
            else if ("w-lamp".Equals(flagName))
            {
                toggleImage(lampOfTimeNotFound, !isAdd);
            }
            else if ("w-scanner".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(scanner, getFoundImage(flagName));
                }
                else
                {
                    setImage(scanner, getBlankImage(flagName));
                }
            }
            else if ("w-grail".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(grail, getFoundImage(flagName));
                }
                else
                {
                    setImage(grail, getBlankImage(flagName));
                }
            }
            else if ("w-doll".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(miniDoll, getFoundImage(flagName));
                }
                else
                {
                    setImage(miniDoll, getBlankImage(flagName));
                }
            }
            else if ("w-magatama".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(magatamaJewel, getFoundImage(flagName));
                }
                else
                {
                    setImage(magatamaJewel, getBlankImage(flagName));
                }
            }
            else if ("w-pepper".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(pepper, getFoundImage(flagName));
                }
                else
                {
                    setImage(pepper, getBlankImage(flagName));
                }
            }
            else if ("w-woman".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(womanStatue, getFoundImage(flagName));
                }
                else
                {
                    setImage(womanStatue, getBlankImage(flagName));
                }
            }
            else if ("w-serpent".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(serpentStaff, getFoundImage(flagName));
                }
                else
                {
                    setImage(serpentStaff, getBlankImage(flagName));
                }
            }
            else if ("w-glove".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(glove, getFoundImage(flagName));
                }
                else
                {
                    setImage(glove, getBlankImage(flagName));
                }
            }
            else if ("w-crucifix".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(crucifix, getFoundImage(flagName));
                }
                else
                {
                    setImage(crucifix, getBlankImage(flagName));
                }
            }
            else if ("w-eye-truth".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(eyeOfTruth, getFoundImage(flagName));
                }
                else
                {
                    setImage(eyeOfTruth, getBlankImage(flagName));
                }
            }
            else if ("w-scale".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(scalesphere, getFoundImage(flagName));
                }
                else
                {
                    setImage(scalesphere, getBlankImage(flagName));
                }
            }
            else if ("w-gauntlet".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(gauntlet, getFoundImage(flagName));
                }
                else
                {
                    setImage(gauntlet, getBlankImage(flagName));
                }
            }
            else if ("w-anchor".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(anchor, getFoundImage(flagName));
                }
                else
                {
                    setImage(anchor, getBlankImage(flagName));
                }
            }
            else if ("w-book".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(bookOfTheDead, getFoundImage(flagName));
                }
                else
                {
                    setImage(bookOfTheDead, getBlankImage(flagName));
                }
            }
            else if ("w-clothes".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(fairyClothes, getFoundImage(flagName));
                }
                else
                {
                    setImage(fairyClothes, getBlankImage(flagName));
                }
            }
            else if ("w-scriptures".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(scriptures, getFoundImage(flagName));
                }
                else
                {
                    setImage(scriptures, getBlankImage(flagName));
                }
            }
            else if ("w-bracelet".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(bracelet, getFoundImage(flagName));
                }
                else
                {
                    setImage(bracelet, getBlankImage(flagName));
                }
            }
            else if ("w-perfume".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(perfume, getFoundImage(flagName));
                }
                else
                {
                    setImage(perfume, getBlankImage(flagName));
                }
            }
            else if ("w-spaulder".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(spaulder, getFoundImage(flagName));
                }
                else
                {
                    setImage(spaulder, getBlankImage(flagName));
                }
            }
            else if ("w-icecape".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(iceCape, getFoundImage(flagName));
                }
                else
                {
                    setImage(iceCape, getBlankImage(flagName));
                }
            }
            else if ("w-talisman".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(talisman, getFoundImage(flagName));
                }
                else
                {
                    setImage(talisman, getBlankImage(flagName));
                }
            }
            else if ("w-diary".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(diary, getFoundImage(flagName));
                }
                else
                {
                    setImage(diary, getBlankImage(flagName));
                }
            }
            else if ("w-mulanatalisman".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(mulanaTalisman, getFoundImage(flagName));
                }
                else
                {
                    setImage(mulanaTalisman, getBlankImage(flagName));
                }
            }
            else if ("w-dimension-key".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(dimensionalKey, getFoundImage(flagName));
                }
                else
                {
                    setImage(dimensionalKey, getBlankImage(flagName));
                }
            }
            else if ("w-djed".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(mantra, global::LMRItemTracker.Properties.Resources.Icon_djedpillar_small);
                }
                else
                {
                    setImage(mantra, null);
                }
            }
            else if ("w-cog".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(cogOfTheSoul, getFoundImage(flagName));
                }
                else
                {
                    setImage(cogOfTheSoul, getBlankImage(flagName));
                }
            }
            else if ("w-dragonbone".Equals(flagName))
            {
                updateCount(skullWallCount, isAdd, 4);
                if (isAdd)
                {
                    setImage(dragonBone, getFoundImage(flagName));
                }
                else
                {
                    setImage(dragonBone, getBlankImage(flagName));
                }
            }
            else if ("w-cskull".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(crystalSkull, getFoundImage(flagName));
                }
                else
                {
                    setImage(crystalSkull, getBlankImage(flagName));
                }
            }
            else if ("w-endless-key".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(keyOfEternity, getFoundImage(flagName));
                }
                else
                {
                    setImage(keyOfEternity, getBlankImage(flagName));
                }
            }
            else if ("w-isispendant".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(isisPendant, getFoundImage(flagName));
                }
                else
                {
                    setImage(isisPendant, getBlankImage(flagName));
                }
            }
            else if ("w-helmet".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(helmet, getFoundImage(flagName));
                }
                else
                {
                    setImage(helmet, getBlankImage(flagName));
                }
            }
            else if ("w-grapple".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(grappleClaw, getFoundImage(flagName));
                }
                else
                {
                    setImage(grappleClaw, getBlankImage(flagName));
                }
            }
            else if ("w-mirror".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(bronzeMirror, getFoundImage(flagName));
                }
                else
                {
                    setImage(bronzeMirror, getBlankImage(flagName));
                }
            }
            else if ("w-ring".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(ring, getFoundImage(flagName));
                }
                else
                {
                    setImage(ring, getBlankImage(flagName));
                }
            }
            else if ("w-plane".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(planeModel, getFoundImage(flagName));
                }
                else
                {
                    setImage(planeModel, getBlankImage(flagName));
                }
            }
            else if ("w-ocarina".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(ocarina, getFoundImage(flagName));
                }
                else
                {
                    setImage(ocarina, getBlankImage(flagName));
                }
            }
            else if ("w-feather".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(feather, getFoundImage(flagName));
                }
                else
                {
                    setImage(feather, getBlankImage(flagName));
                }
            }
            else if ("w-hermes".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(hermesBoots, getFoundImage(flagName));
                }
                else
                {
                    setImage(hermesBoots, getBlankImage(flagName));
                }
            }
            else if ("w-fruit".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(fruitOfEden, getFoundImage(flagName));
                }
                else
                {
                    setImage(fruitOfEden, getBlankImage(flagName));
                }
            }
            else if ("w-twin-statue".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(twinStatue, getFoundImage(flagName));
                }
                else
                {
                    setImage(twinStatue, getBlankImage(flagName));
                }
            }
            else if ("w-treasures".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(treasures, getFoundImage(flagName));
                }
                else
                {
                    setImage(treasures, getBlankImage(flagName));
                }
            }
            else if ("w-pochettekey".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(pochetteKey, getFoundImage(flagName));
                }
                else
                {
                    setImage(pochetteKey, getBlankImage(flagName));
                }
            }
            else if ("w-msx2".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(msx2, getFoundImage(flagName));
                }
                else
                {
                    setImage(msx2, getBlankImage(flagName));
                }
            }
            else if ("w-medicine".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind);
                }
                else
                {
                    setImage(vessel, global::LMRItemTracker.Properties.Resources.Icon_vessel); // todo: what if we don't have vessel?
                }
            }
        }

        private void toggleMainWeapon(string flagName, bool isAdd)
        {
            if ("w-main-chain".Equals(flagName))
            {
                toggleImage(chainWhip, isAdd);
            }
            else if ("w-main-flail".Equals(flagName))
            {
                toggleImage(flailWhip, isAdd);
            }
            else if ("w-main-axe".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(axe, getFoundImage(flagName));
                }
                else
                {
                    setImage(axe, getBlankImage(flagName));
                }
            }
            else if ("w-main-knife".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(knife, getFoundImage(flagName));
                }
                else
                {
                    setImage(knife, getBlankImage(flagName));
                }
            }
            else if ("w-main-katana".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(katana, getFoundImage(flagName));
                }
                else
                {
                    setImage(katana, getBlankImage(flagName));
                }
            }
            else if ("w-main-keysword".Equals(flagName))
            {
                this.keySwordCollected = isAdd;
                if (isAdd)
                {
                    if (this.mantrasRecited)
                    {
                        setImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened);
                    }
                    else
                    {
                        setImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword);
                    }
                }
                else
                {
                    setImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword_blank);
                }
            }
        }

        private void toggleSubWeapon(string flagName, bool isAdd)
        {
            if ("w-sub-shuriken".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(shuriken, getFoundImage(flagName));
                }
                else
                {
                    setImage(shuriken, getBlankImage(flagName));
                }
            }
            else if ("w-sub-rshuriken".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(rollingShuriken, getFoundImage(flagName));
                }
                else
                {
                    setImage(rollingShuriken, getBlankImage(flagName));
                }
            }
            else if ("w-sub-caltrops".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(caltrops, getFoundImage(flagName));
                }
                else
                {
                    setImage(caltrops, getBlankImage(flagName));
                }
            }
            else if ("w-sub-spear".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(earthSpear, getFoundImage(flagName));
                }
                else
                {
                    setImage(earthSpear, getBlankImage(flagName));
                }
            }
            else if ("w-sub-flare".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(flareGun, getFoundImage(flagName));
                }
                else
                {
                    setImage(flareGun, getBlankImage(flagName));
                }
            }
            else if ("w-sub-bomb".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(bomb, getFoundImage(flagName));
                }
                else
                {
                    setImage(bomb, getBlankImage(flagName));
                }
            }
            else if ("w-sub-chakram".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(chakram, getFoundImage(flagName));
                }
                else
                {
                    setImage(chakram, getBlankImage(flagName));
                }
            }
            else if ("w-sub-pistol".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(pistol, getFoundImage(flagName));
                }
                else
                {
                    setImage(pistol, getBlankImage(flagName));
                }
            }

        }

        private void toggleSeal(string flagName, bool isAdd)
        {
            if ("w-seal1".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(originSeal, getFoundImage(flagName));
                }
                else
                {
                    setImage(originSeal, getBlankImage(flagName));
                }
            }
            else if ("w-seal2".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(birthSeal, getFoundImage(flagName));
                }
                else
                {
                    setImage(birthSeal, getBlankImage(flagName));
                }
            }
            else if ("w-seal3".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(lifeSeal, getFoundImage(flagName));
                }
                else
                {
                    setImage(lifeSeal, getBlankImage(flagName));
                }
            }
            else if ("w-seal4".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(deathSeal, getFoundImage(flagName));
                }
                else
                {
                    setImage(deathSeal, getBlankImage(flagName));
                }
            }
        }

        private void toggleSoftware(string flagName, bool isAdd)
        {
            if ("w-soft-reader".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(reader, getFoundImage(flagName));
                }
                else
                {
                    setImage(reader, getBlankImage(flagName));
                }
            }
            else if("w-soft-mantra".Equals(flagName))
            {
                if (isAdd)
                {
                    setBackgroundImage(mantra, getFoundImage(flagName));
                }
                else
                {
                    setBackgroundImage(mantra, getBlankImage(flagName));
                }
            }
            else if ("w-soft-torude".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(torude, getFoundImage(flagName));
                }
                else
                {
                    setImage(torude, getBlankImage(flagName));
                }
            }
            else if ("w-soft-mekuri".Equals(flagName))
            {
                if (isAdd)
                {
                    this.mekuriCollected = true;
                    if (this.miracleCollected)
                    {
                        setImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy);
                    }
                }
                else
                {
                    this.mekuriCollected = false;
                    setImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank);
                }
            }
            else if ("w-soft-miracle".Equals(flagName))
            {
                if (isAdd)
                {
                    this.miracleCollected = true;
                    if (this.mekuriCollected)
                    {
                        setImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy);
                    }
                }
                else
                {
                    this.miracleCollected = false;
                    setImage(keyFairy, global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank);
                }
            }
            else if ("w-soft-mirai".Equals(flagName))
            {
                if (isAdd)
                {
                    setImage(mirai, getFoundImage(flagName));
                }
                else
                {
                    setImage(mirai, getBlankImage(flagName));
                }
            }
            else if ("w-soft-yagomap".Equals(flagName) || "w-soft-yagostr".Equals(flagName))
            {
                updateCount(skullWallCount, isAdd, 4);
            }
        }

        internal void updateShield(string displayname, bool isAdd)
        {
            if ("shield-buckler".Equals(displayname))
            {
                if (isAdd)
                {
                    setImage(buckler, getFoundImage(displayname));
                }
                else
                {
                    setImage(buckler, getBlankImage(displayname));
                }
            }
            else if ("shield-silver".Equals(displayname))
            {
                toggleImage(silverShield, isAdd);
            }
            else if ("shield-fake".Equals(displayname))
            {
                toggleImage(fakeSilverShield, isAdd);
            }
            else if ("shield-angel".Equals(displayname))
            {
                toggleImage(angelShield, isAdd);
            }
        }

        internal void updateLampOfTime(string displayname, bool isAdd)
        {
            if ("invus-lamp-lit".Equals(displayname))
            {
                if (isAdd)
                {
                    setImage(lampOfTime, global::LMRItemTracker.Properties.Resources.Icon_lampoftime);
                }
            }
            else if ("invus-lamp-unlit".Equals(displayname))
            {
                if (isAdd)
                {
                    setImage(lampOfTime, global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit);
                }
            }
        }

        internal void updateTranslationTablets(byte cur)
        {
            translationTablets.Invoke(new Action(() =>
            {
                translationTablets.Text = cur + "/3";
                translationTablets.Refresh();
            }));
        }

        public void setGameStarted(bool gameStarted)
        {
            this.gameStarted = gameStarted;
        }

        internal void updateLastItem(string flagName)
        {
            if(this.gameStarted)
            {
                lastItem.Invoke(new Action(() =>
                {
                    System.Drawing.Bitmap lastItemImage = getFoundImage(flagName);
                    if(lastItemImage != null)
                    {
                        lastItem.Image = lastItemImage;
                        if ("w-map-shrine".Equals(flagName))
                        {
                            lastItem.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
                        }
                        else
                        {
                            lastItem.BackgroundImage = null;
                        }
                        lastItem.Refresh();
                    }
                }));
            }
        }

        public void updateAnkhJewels(ushort cur)
        {
            ankhJewelCount.Invoke(new Action(() =>
            {
                ankhJewelCount.Text = "" + cur;
                ankhJewelCount.Refresh();
            }));
        }

        public void toggleBoss(string itemName, bool isAdd)
        {
            if ("boss-amphisbaena".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Boss_amphisbaena);
                }
                else
                {
                    setBackgroundImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank);
                }
            }
            else if ("boss-sakit".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(sakit, global::LMRItemTracker.Properties.Resources.Boss_sakit);
                }
                else
                {
                    setBackgroundImage(sakit, global::LMRItemTracker.Properties.Resources.Boss_sakit_blank);
                }
            }
            else if ("boss-ellmac".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(ellmac, global::LMRItemTracker.Properties.Resources.Boss_ellmac);
                }
                else
                {
                    setBackgroundImage(ellmac, global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank);
                }
            }
            else if ("boss-bahamut".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(bahamut, global::LMRItemTracker.Properties.Resources.Boss_bahamut);
                }
                else
                {
                    setBackgroundImage(bahamut, global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank);
                }
            }
            else if ("boss-viy".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(viy, global::LMRItemTracker.Properties.Resources.Boss_viy);
                }
                else
                {
                    setBackgroundImage(viy, global::LMRItemTracker.Properties.Resources.Boss_viy_blank);
                }
            }
            else if ("boss-palenque".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(palenque, global::LMRItemTracker.Properties.Resources.Boss_palenque);
                }
                else
                {
                    setBackgroundImage(palenque, global::LMRItemTracker.Properties.Resources.Boss_palenque_blank);
                }
            }
            else if ("boss-baphomet".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(baphomet, global::LMRItemTracker.Properties.Resources.Boss_baphomet);
                }
                else
                {
                    setBackgroundImage(baphomet, global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank);
                }
            }
            else if ("boss-tiamat".Equals(itemName))
            {
                if (isAdd)
                {
                    setBackgroundImage(tiamat, global::LMRItemTracker.Properties.Resources.Boss_tiamat);
                }
                else
                {
                    setBackgroundImage(tiamat, global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank);
                }
            }
        }

        public void toggleMap(string flagName, Boolean isAdd)
        {
            updateCount(mapCount, isAdd, 17);
            if ("w-map-shrine".Equals(flagName))
            {
                updateCount(skullWallCount, isAdd, 4);
                if (isAdd)
                {
                    setImage(maps, getFoundImage(flagName));
                }
                else
                {
                    setImage(maps, null);
                }
            }
        }

        public void toggleMantra(string itemName, bool isAdd)
        {
            if ("mantra-keysword".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mantrasRecited = true;
                    if (this.keySwordCollected)
                    {
                        setImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened);
                    }
                }
                else
                {
                    this.mantrasRecited = false;
                    if (this.keySwordCollected)
                    {
                        setImage(keySword, global::LMRItemTracker.Properties.Resources.Icon_keysword);
                    }
                }
            }
            else if ("mantra-amphisbaena".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(amphisbaena, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(amphisbaena, null);
                }
            }
            else if ("mantra-sakit".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(sakit, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(sakit, null);
                }
            }
            else if ("mantra-ellmac".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(ellmac, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(ellmac, null);
                }
            }
            else if ("mantra-bahamut".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(bahamut, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(bahamut, null);
                }
            }
            else if ("mantra-viy".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(viy, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(viy, null);
                }
            }
            else if ("mantra-palenque".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(palenque, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(palenque, null);
                }
            }
            else if ("mantra-baphomet".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(baphomet, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(baphomet, null);
                }
            }
            else if ("mantra-tiamat".Equals(itemName))
            {
                if (isAdd)
                {
                    setImage(tiamat, global::LMRItemTracker.Properties.Resources.Icon_djedpillar);
                }
                else
                {
                    setImage(tiamat, null);
                }
            }
        }

        private void LaMulanaItemTrackerForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
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
            if(sender is ToolStripMenuItem)
            {
                String itemName = ((ToolStripMenuItem)sender).Text;
                Control control = GetControl(itemName);
                if(control == null)
                {
                    MessageBox.Show("Problem adding " + itemName + " to panel");
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(control);
                    control.Margin = new Padding(0);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, true);

                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
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
                    flowLayoutPanel2.Controls.Add(control);
                    control.Margin = new Padding(0);

                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
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
                    flowLayoutPanel3.Controls.Add(control);
                    control.Margin = new Padding(0);

                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
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
                    flowLayoutPanel4.Controls.Add(control);
                    control.Margin = new Padding(0);

                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
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
                    flowLayoutPanel5.Controls.Add(control);
                    control.Margin = new Padding(0);

                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, true);

                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
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
                    control.Parent = null;
                    Properties.Settings.Default.Panel1Contents = rebuildPanelContents(Properties.Settings.Default.Panel1Contents, itemName, false);
                    Properties.Settings.Default.Panel2Contents = rebuildPanelContents(Properties.Settings.Default.Panel2Contents, itemName, false);
                    Properties.Settings.Default.Panel3Contents = rebuildPanelContents(Properties.Settings.Default.Panel3Contents, itemName, false);
                    Properties.Settings.Default.Panel4Contents = rebuildPanelContents(Properties.Settings.Default.Panel4Contents, itemName, false);
                    Properties.Settings.Default.Panel5Contents = rebuildPanelContents(Properties.Settings.Default.Panel5Contents, itemName, false);
                }
            }
        }

        private System.Drawing.Bitmap getFoundImage(string flagName)
        {
            if (flagName.StartsWith("w-jewel-"))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            }
            else if (flagName.StartsWith("w-orb-"))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_sacredorb;
            }
            else if (flagName.StartsWith("w-map-"))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_map;
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
                return global::LMRItemTracker.Properties.Resources.Icon_silvershield;
            }
            else if ("shield-angel".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_angelshield;
            }
            else if ("w-lamp".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_lampoftime;
            }
            else if ("w-map-shrine".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_dragonbone_small;
            }
            return null;
        }

        private System.Drawing.Bitmap getBlankImage(string flagName)
        {
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
            else if ("w-main-axe".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
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
            else if ("shield-buckler".Equals(flagName))
            {
                return global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            }
            return null;
        }

        public Control GetControl(String itemName)
        {
            if ("Hermes Boots".Equals(itemName))
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
            if ("Holy Grail".Equals(itemName))
            {
                return grail;
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
            if ("Shuriken".Equals(itemName))
            {
                return shuriken;
            }
            if ("Rolling Shuriken".Equals(itemName))
            {
                return rollingShuriken;
            }
            if ("Caltrops".Equals(itemName))
            {
                return caltrops;
            }
            if ("Flare Gun".Equals(itemName))
            {
                return flareGun;
            }
            if ("Chakram".Equals(itemName))
            {
                return chakram;
            }
            if ("Earth Spear".Equals(itemName))
            {
                return earthSpear;
            }
            if ("Bomb".Equals(itemName))
            {
                return bomb;
            }
            if ("Pistol".Equals(itemName))
            {
                return pistol;
            }
            if ("Philosopher's Ocarina".Equals(itemName))
            {
                return ocarina;
            }

            if ("Glyph Reader".Equals(itemName))
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
            if ("Whip".Equals(itemName))
            {
                return whipsPanel;
            }
            if ("Shield".Equals(itemName))
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

        private void updateLastItem()
        {
            if(Properties.Settings.Default.ShowLastItem)
            {
                if(lastItemPanel.Parent == null)
                {
                    lastItemWrapperPanel.Controls.Add(lastItemPanel);
                }
            }
            else
            {
                lastItemPanel.Parent = null;
            }
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
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.Save();
        }

        private void restoreDefaultSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.Panel1Contents = "Hermes Boots,Grapple Claw,Feather,Hand Scanner,Glyph Reader,Holy Grail,mirai.exe";
            Properties.Settings.Default.Panel2Contents = "Bronze Mirror,Fruit of Eden,Twin Statue,Key of Eternity,Helmet,Plane Model,Crystal Skull,Dimensional Key,Pochette Key,Ice Cape,Scalesphere,Cog of the Soul,Dragon Bone,Serpent Staff,Mulana Talisman,Woman Statue,Pepper,Talisman,Diary,Mini Doll,Treasures,Anchor,Key Fairy Combo,Isis' Pendant,Eye of Truth,Magatama Jewel,torude.exe,Shrine Wall Removal";
            Properties.Settings.Default.Panel3Contents = "Origin Seal,Birth Seal,Life Seal,Death Seal,Book of the Dead,Ring,Fairy Clothes,Mobile Super X2,Scriptures,Crucifix,Perfume,Glove,Bracelet,Spaulder";
            Properties.Settings.Default.Panel4Contents = "Whip,Knife,Axe,Katana,Shield,Gauntlet,Pistol,Shuriken,Rolling Shuriken,Caltrops,Flare Gun,Chakram,Earth Spear,Bomb";
            Properties.Settings.Default.Panel5Contents = "Philosopher's Ocarina,Mantra/Djed Pillar,Vessel/Medicine,Key Sword,Lamp of Time,Maps,Ankh Jewels";
            Properties.Settings.Default.BackgroundColor = System.Drawing.SystemColors.Control;
            Properties.Settings.Default.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            Properties.Settings.Default.FormWidth = 320;
            Properties.Settings.Default.FormHeight = 662;
            Properties.Settings.Default.ShowLastItem = true;

            updateFormSize();
            updateFormColor();
            updateTextColor();
            updateLastItem();
            InitializeFormPanels();
        }

        private void toggleImage(PictureBox pictureBox, bool visible)
        {
            pictureBox.Invoke(new Action(() =>
            {
                if (pictureBox.Visible != visible)
                {
                    pictureBox.Visible = visible;
                    pictureBox.Refresh();
                }
            }));
        }

        private void setImage(PictureBox pictureBox, System.Drawing.Image image)
        {
            pictureBox.Invoke(new Action(() =>
            {
                pictureBox.Image = image;
                pictureBox.Refresh();
            }));
        }

        private void setBackgroundImage(PictureBox pictureBox, System.Drawing.Image image)
        {
            pictureBox.Invoke(new Action(() =>
            {
                pictureBox.BackgroundImage = image;
                pictureBox.Refresh();
            }));
        }

        private void updateCount(Label label, bool isAdd, int max)
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

        private void setFlailWhipIndex(object sender, EventArgs e)
        {
            whipsPanel.Controls.SetChildIndex(flailWhip, 0);
        }
        private void setChainWhipIndex(object sender, EventArgs e)
        {
            whipsPanel.Controls.SetChildIndex(chainWhip, 1);
        }

        private void setAngelShieldIndex(object sender, EventArgs e)
        {
            shieldsPanel.Controls.SetChildIndex(angelShield, 0);
        }
        private void setSilverShieldIndex(object sender, EventArgs e)
        {
            shieldsPanel.Controls.SetChildIndex(silverShield, 1);
        }
        private void setFakeSilverShieldIndex(object sender, EventArgs e)
        {
            shieldsPanel.Controls.SetChildIndex(fakeSilverShield, 2);
        }
        private void setBucklerIndex(object sender, EventArgs e)
        {
            shieldsPanel.Controls.SetChildIndex(buckler, 3);
        }

        private void toggleLastItemDisplay(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowLastItem = !Properties.Settings.Default.ShowLastItem;
            updateLastItem();
        }

        private void clearLastItem(object sender, EventArgs e)
        {
            lastItem.Invoke(new Action(() =>
            {
                lastItem.Image = null;
                lastItem.BackgroundImage = null;
                lastItem.Refresh();
            }));
        }
    }
}
