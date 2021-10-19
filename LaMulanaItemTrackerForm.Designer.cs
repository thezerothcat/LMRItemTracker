using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace LMRItemTracker
{
    public partial class LaMulanaItemTrackerForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaMulanaItemTrackerForm));
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.formColorDialog = new System.Windows.Forms.ColorDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUncollectedItemColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemPanel6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncollectedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAmmoCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeathCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDeathCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLastItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSpauldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hermesBoots = new LMRItemTracker.TrackerBox();
            this.grappleClaw = new LMRItemTracker.TrackerBox();
            this.feather = new LMRItemTracker.TrackerBox();
            this.scanner = new LMRItemTracker.TrackerBox();
            this.readerPanel = new LMRItemTracker.ItemTextPanel();
            this.reader = new LMRItemTracker.TrackerBox();
            this.translationTablets = new LMRItemTracker.TrackerLabel();
            this.holyGrail = new LMRItemTracker.MultiStateTrackerBox();
            this.mirai = new LMRItemTracker.TrackerBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.spaulderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.spaulderLabel = new System.Windows.Forms.Label();
            this.spaulderCount = new System.Windows.Forms.Label();
            this.totalSpauldersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.totalSpauldersLabel = new System.Windows.Forms.Label();
            this.totalSpauldersCount = new System.Windows.Forms.Label();
            this.overviewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lastItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lastItemLabel = new System.Windows.Forms.Label();
            this.lastItem1 = new System.Windows.Forms.PictureBox();
            this.lastItem2 = new System.Windows.Forms.PictureBox();
            this.lastItem3 = new System.Windows.Forms.PictureBox();
            this.deathPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deathLabel = new System.Windows.Forms.Label();
            this.deathCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bronzeMirror = new LMRItemTracker.TrackerBox();
            this.fruitOfEden = new LMRItemTracker.TrackerBox();
            this.twinStatue = new LMRItemTracker.TrackerBox();
            this.keyOfEternity = new LMRItemTracker.TrackerBox();
            this.helmet = new LMRItemTracker.TrackerBox();
            this.planeModel = new LMRItemTracker.TrackerBox();
            this.crystalSkull = new LMRItemTracker.TrackerBox();
            this.dimensionalKey = new LMRItemTracker.TrackerBox();
            this.pochetteKey = new LMRItemTracker.TrackerBox();
            this.iceCape = new LMRItemTracker.TrackerBox();
            this.scalesphere = new LMRItemTracker.TrackerBox();
            this.cogOfTheSoul = new LMRItemTracker.TrackerBox();
            this.dragonBone = new LMRItemTracker.TrackerBox();
            this.serpentStaff = new LMRItemTracker.TrackerBox();
            this.mulanaTalisman = new LMRItemTracker.TrackerBox();
            this.womanStatue = new LMRItemTracker.MultiStateTrackerBox();
            this.pepper = new LMRItemTracker.TrackerBox();
            this.talisman = new LMRItemTracker.TrackerBox();
            this.diary = new LMRItemTracker.TrackerBox();
            this.miniDoll = new LMRItemTracker.TrackerBox();
            this.treasures = new LMRItemTracker.TrackerBox();
            this.anchor = new LMRItemTracker.TrackerBox();
            this.keyFairy = new LMRItemTracker.KeyFairyTrackerBox();
            this.isisPendant = new LMRItemTracker.TrackerBox();
            this.eyeOfTruth = new LMRItemTracker.TrackerBox();
            this.magatamaJewel = new LMRItemTracker.TrackerBox();
            this.torude = new LMRItemTracker.TrackerBox();
            this.shrinePanel = new LMRItemTracker.ItemTextPanel();
            this.skullWall = new LMRItemTracker.TrackerBox();
            this.skullWallCount = new LMRItemTracker.TrackerLabel();
            this.secretTreasureOfLife = new LMRItemTracker.TrackerBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.originSeal = new LMRItemTracker.TrackerBox();
            this.birthSeal = new LMRItemTracker.TrackerBox();
            this.lifeSeal = new LMRItemTracker.TrackerBox();
            this.deathSeal = new LMRItemTracker.TrackerBox();
            this.bookOfTheDead = new LMRItemTracker.TrackerBox();
            this.ring = new LMRItemTracker.TrackerBox();
            this.fairyClothes = new LMRItemTracker.TrackerBox();
            this.msx2 = new LMRItemTracker.TrackerBox();
            this.scriptures = new LMRItemTracker.TrackerBox();
            this.crucifix = new LMRItemTracker.TrackerBox();
            this.perfume = new LMRItemTracker.TrackerBox();
            this.glove = new LMRItemTracker.TrackerBox();
            this.bracelet = new LMRItemTracker.TrackerBox();
            this.spaulder = new LMRItemTracker.TrackerBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.whip = new LMRItemTracker.MultiStateTrackerBox();
            this.knife = new LMRItemTracker.TrackerBox();
            this.axe = new LMRItemTracker.TrackerBox();
            this.katana = new LMRItemTracker.TrackerBox();
            this.shield = new LMRItemTracker.MultiStateTrackerBox();
            this.gauntlet = new LMRItemTracker.TrackerBox();
            this.pistolPanel = new LMRItemTracker.PistolPanel();
            this.pistolAmmoCount = new LMRItemTracker.PistolAmmoTrackerLabel();
            this.pistol = new LMRItemTracker.TrackerBox();
            this.shurikenPanel = new LMRItemTracker.ItemTextPanel();
            this.shurikenAmmoCount = new LMRItemTracker.TrackerLabel();
            this.shuriken = new LMRItemTracker.TrackerBox();
            this.rollingShurikenPanel = new LMRItemTracker.ItemTextPanel();
            this.rollingShurikenAmmoCount = new LMRItemTracker.TrackerLabel();
            this.rollingShuriken = new LMRItemTracker.TrackerBox();
            this.caltropsPanel = new LMRItemTracker.ItemTextPanel();
            this.caltropsAmmoCount = new LMRItemTracker.TrackerLabel();
            this.caltrops = new LMRItemTracker.TrackerBox();
            this.flareGunPanel = new LMRItemTracker.ItemTextPanel();
            this.flareGunAmmoCount = new LMRItemTracker.TrackerLabel();
            this.flareGun = new LMRItemTracker.TrackerBox();
            this.chakramPanel = new LMRItemTracker.ItemTextPanel();
            this.chakramAmmoCount = new LMRItemTracker.TrackerLabel();
            this.chakram = new LMRItemTracker.TrackerBox();
            this.earthSpearPanel = new LMRItemTracker.ItemTextPanel();
            this.earthSpearAmmoCount = new LMRItemTracker.TrackerLabel();
            this.earthSpear = new LMRItemTracker.TrackerBox();
            this.bombPanel = new LMRItemTracker.ItemTextPanel();
            this.bombAmmoCount = new LMRItemTracker.TrackerLabel();
            this.bomb = new LMRItemTracker.TrackerBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.ocarina = new LMRItemTracker.TrackerBox();
            this.mantra = new LMRItemTracker.TrackerBox();
            this.vessel = new LMRItemTracker.MultiStateTrackerBox();
            this.keySword = new LMRItemTracker.KeySwordTrackerBox();
            this.lampOfTime = new LMRItemTracker.MultiStateTrackerBox();
            this.mapsPanel = new LMRItemTracker.ItemTextPanel();
            this.mapCount = new LMRItemTracker.TrackerLabel();
            this.maps = new LMRItemTracker.TrackerBox();
            this.ankhJewelPanel = new LMRItemTracker.ItemTextPanel();
            this.ankhJewels = new LMRItemTracker.TrackerBox();
            this.ankhJewelCount = new LMRItemTracker.TrackerLabel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.shellHorn = new LMRItemTracker.TrackerBox();
            this.waterproofCase = new LMRItemTracker.TrackerBox();
            this.heatproofCase = new LMRItemTracker.TrackerBox();
            this.swimsuit = new LMRItemTracker.TrackerBox();
            this.djedPillar = new LMRItemTracker.TrackerBox();
            this.mantraSingle = new LMRItemTracker.TrackerBox();
            this.xmailer = new LMRItemTracker.TrackerBox();
            this.yagomap = new LMRItemTracker.TrackerBox();
            this.yagostr = new LMRItemTracker.TrackerBox();
            this.bunemon = new LMRItemTracker.TrackerBox();
            this.bunplus = new LMRItemTracker.TrackerBox();
            this.guild = new LMRItemTracker.TrackerBox();
            this.beolamu = new LMRItemTracker.TrackerBox();
            this.emusic = new LMRItemTracker.TrackerBox();
            this.randc = new LMRItemTracker.TrackerBox();
            this.capstar = new LMRItemTracker.TrackerBox();
            this.deathv = new LMRItemTracker.TrackerBox();
            this.move = new LMRItemTracker.TrackerBox();
            this.mekuri = new LMRItemTracker.TrackerBox();
            this.bounce = new LMRItemTracker.TrackerBox();
            this.miracle = new LMRItemTracker.TrackerBox();
            this.lamulana = new LMRItemTracker.TrackerBox();
            this.bossPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amphisbaena = new LMRItemTracker.TrackerBox();
            this.sakit = new LMRItemTracker.TrackerBox();
            this.ellmac = new LMRItemTracker.TrackerBox();
            this.bahamut = new LMRItemTracker.TrackerBox();
            this.viy = new LMRItemTracker.TrackerBox();
            this.palenque = new LMRItemTracker.TrackerBox();
            this.baphomet = new LMRItemTracker.TrackerBox();
            this.tiamat = new LMRItemTracker.TrackerBox();
            this.itemColorDialog = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).BeginInit();
            this.readerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holyGrail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.spaulderPanel.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.totalSpauldersPanel.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            this.lastItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem3)).BeginInit();
            this.deathPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMirror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOfEden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twinStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyOfEternity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalesphere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulanaTalisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isisPendant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOfTruth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatamaJewel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torude)).BeginInit();
            this.shrinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skullWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretTreasureOfLife)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOfTheDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairyClothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucifix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaulder)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauntlet)).BeginInit();
            this.pistolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).BeginInit();
            this.shurikenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shuriken)).BeginInit();
            this.rollingShurikenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollingShuriken)).BeginInit();
            this.caltropsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caltrops)).BeginInit();
            this.flareGunPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flareGun)).BeginInit();
            this.chakramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chakram)).BeginInit();
            this.earthSpearPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthSpear)).BeginInit();
            this.bombPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTime)).BeginInit();
            this.mapsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maps)).BeginInit();
            this.ankhJewelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ankhJewels)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shellHorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterproofCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatproofCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimsuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djedPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantraSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagomap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagostr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunplus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beolamu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bounce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miracle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamulana)).BeginInit();
            this.bossPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amphisbaena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellmac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahamut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palenque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baphomet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiamat)).BeginInit();
            this.SuspendLayout();
            // 
            // textColorDialog
            // 
            this.textColorDialog.AnyColor = true;
            this.textColorDialog.SolidColorOnly = true;
            // 
            // formColorDialog
            // 
            this.formColorDialog.AnyColor = true;
            this.formColorDialog.SolidColorOnly = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.layoutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(340, 24);
            this.menu.TabIndex = 109;
            this.menu.Text = "Settings";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.restoreDefaultsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.settingsToolStripMenuItem.Text = "File";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.SaveSettings);
            // 
            // restoreDefaultsToolStripMenuItem
            // 
            this.restoreDefaultsToolStripMenuItem.Name = "restoreDefaultsToolStripMenuItem";
            this.restoreDefaultsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restoreDefaultsToolStripMenuItem.Text = "Restore Defaults";
            this.restoreDefaultsToolStripMenuItem.Click += new System.EventHandler(this.RestoreDefaultSettings);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColorToolStripMenuItem,
            this.changeTextColorToolStripMenuItem,
            this.changeUncollectedItemColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.SelectFormColor);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change Text Color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.SelectTextColor);
            // 
            // changeUncollectedItemColorToolStripMenuItem
            // 
            this.changeUncollectedItemColorToolStripMenuItem.Name = "changeUncollectedItemColorToolStripMenuItem";
            this.changeUncollectedItemColorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.changeUncollectedItemColorToolStripMenuItem.Text = "Change Uncollected Item Color";
            this.changeUncollectedItemColorToolStripMenuItem.Click += new System.EventHandler(this.SelectItemColor);
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.uncollectedItemsToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.showAmmoCountToolStripMenuItem,
            this.showDeathCountToolStripMenuItem,
            this.clearDeathCountToolStripMenuItem,
            this.showLastItemToolStripMenuItem,
            this.clearLastItemToolStripMenuItem,
            this.clearSpauldersToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemPanel1ToolStripMenuItem,
            this.addItemPanel2ToolStripMenuItem,
            this.addItemPanel3ToolStripMenuItem,
            this.addItemPanel4ToolStripMenuItem,
            this.addItemPanel5ToolStripMenuItem,
            this.addItemPanel6ToolStripMenuItem});
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            // 
            // addItemPanel1ToolStripMenuItem
            // 
            this.addItemPanel1ToolStripMenuItem.Name = "addItemPanel1ToolStripMenuItem";
            this.addItemPanel1ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel1ToolStripMenuItem.Text = "Panel 1";
            // 
            // addItemPanel2ToolStripMenuItem
            // 
            this.addItemPanel2ToolStripMenuItem.Name = "addItemPanel2ToolStripMenuItem";
            this.addItemPanel2ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel2ToolStripMenuItem.Text = "Panel 2";
            // 
            // addItemPanel3ToolStripMenuItem
            // 
            this.addItemPanel3ToolStripMenuItem.Name = "addItemPanel3ToolStripMenuItem";
            this.addItemPanel3ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel3ToolStripMenuItem.Text = "Panel 3";
            // 
            // addItemPanel4ToolStripMenuItem
            // 
            this.addItemPanel4ToolStripMenuItem.Name = "addItemPanel4ToolStripMenuItem";
            this.addItemPanel4ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel4ToolStripMenuItem.Text = "Panel 4";
            // 
            // addItemPanel5ToolStripMenuItem
            // 
            this.addItemPanel5ToolStripMenuItem.Name = "addItemPanel5ToolStripMenuItem";
            this.addItemPanel5ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel5ToolStripMenuItem.Text = "Panel 5";
            // 
            // addItemPanel6ToolStripMenuItem
            // 
            this.addItemPanel6ToolStripMenuItem.Name = "addItemPanel6ToolStripMenuItem";
            this.addItemPanel6ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addItemPanel6ToolStripMenuItem.Text = "Panel 6";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            // 
            // uncollectedItemsToolStripMenuItem
            // 
            this.uncollectedItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shadedImageToolStripMenuItem,
            this.solidImageToolStripMenuItem,
            this.noImageToolStripMenuItem,
            this.hideImageToolStripMenuItem});
            this.uncollectedItemsToolStripMenuItem.Name = "uncollectedItemsToolStripMenuItem";
            this.uncollectedItemsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.uncollectedItemsToolStripMenuItem.Text = "Uncollected Items";
            // 
            // shadedImageToolStripMenuItem
            // 
            this.shadedImageToolStripMenuItem.Name = "shadedImageToolStripMenuItem";
            this.shadedImageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.shadedImageToolStripMenuItem.Text = "Shaded Image";
            this.shadedImageToolStripMenuItem.Click += new System.EventHandler(this.setShadedUncollected);
            // 
            // solidImageToolStripMenuItem
            // 
            this.solidImageToolStripMenuItem.Name = "solidImageToolStripMenuItem";
            this.solidImageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.solidImageToolStripMenuItem.Text = "Solid Color";
            this.solidImageToolStripMenuItem.Click += new System.EventHandler(this.setSolidUncollected);
            // 
            // noImageToolStripMenuItem
            // 
            this.noImageToolStripMenuItem.Name = "noImageToolStripMenuItem";
            this.noImageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.noImageToolStripMenuItem.Text = "No Image";
            this.noImageToolStripMenuItem.Click += new System.EventHandler(this.setBlankUncollected);
            // 
            // hideImageToolStripMenuItem
            // 
            this.hideImageToolStripMenuItem.Name = "hideImageToolStripMenuItem";
            this.hideImageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hideImageToolStripMenuItem.Text = "Hide";
            this.hideImageToolStripMenuItem.Click += new System.EventHandler(this.setHideUncollected);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.toggleTopMost);
            // 
            // showAmmoCountToolStripMenuItem
            // 
            this.showAmmoCountToolStripMenuItem.Name = "showAmmoCountToolStripMenuItem";
            this.showAmmoCountToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showAmmoCountToolStripMenuItem.Text = "Show Ammo Count";
            this.showAmmoCountToolStripMenuItem.Click += new System.EventHandler(this.toggleAmmoCount);
            // 
            // showDeathCountToolStripMenuItem
            // 
            this.showDeathCountToolStripMenuItem.Name = "showDeathCountToolStripMenuItem";
            this.showDeathCountToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showDeathCountToolStripMenuItem.Text = "Show Death Count";
            this.showDeathCountToolStripMenuItem.Click += new System.EventHandler(this.toggleDeathCount);
            // 
            // clearDeathCountToolStripMenuItem
            // 
            this.clearDeathCountToolStripMenuItem.Name = "clearDeathCountToolStripMenuItem";
            this.clearDeathCountToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearDeathCountToolStripMenuItem.Text = "Clear Death Count";
            this.clearDeathCountToolStripMenuItem.Click += new System.EventHandler(this.resetDeathCount);
            // 
            // showLastItemToolStripMenuItem
            // 
            this.showLastItemToolStripMenuItem.Name = "showLastItemToolStripMenuItem";
            this.showLastItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showLastItemToolStripMenuItem.Text = "Show Recent Items";
            this.showLastItemToolStripMenuItem.Click += new System.EventHandler(this.toggleShowLastItem);
            // 
            // clearLastItemToolStripMenuItem
            // 
            this.clearLastItemToolStripMenuItem.Name = "clearLastItemToolStripMenuItem";
            this.clearLastItemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearLastItemToolStripMenuItem.Text = "Clear Recent Items";
            this.clearLastItemToolStripMenuItem.Click += new System.EventHandler(this.clearLastItem);
            // 
            // clearSpauldersToolStripMenuItem
            // 
            this.clearSpauldersToolStripMenuItem.Name = "clearSpauldersToolStripMenuItem";
            this.clearSpauldersToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clearSpauldersToolStripMenuItem.Text = "Clear Spaulders";
            this.clearSpauldersToolStripMenuItem.Click += new System.EventHandler(this.resetSpaulderCount);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.hermesBoots);
            this.flowLayoutPanel1.Controls.Add(this.grappleClaw);
            this.flowLayoutPanel1.Controls.Add(this.feather);
            this.flowLayoutPanel1.Controls.Add(this.scanner);
            this.flowLayoutPanel1.Controls.Add(this.readerPanel);
            this.flowLayoutPanel1.Controls.Add(this.holyGrail);
            this.flowLayoutPanel1.Controls.Add(this.mirai);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel1, true);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 106);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 56);
            this.flowLayoutPanel1.TabIndex = 110;
            this.flowLayoutPanel1.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // hermesBoots
            // 
            this.hermesBoots.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
            this.hermesBoots.Collected = false;
            this.hermesBoots.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_hermesboots;
            this.hermesBoots.ForeCollected = false;
            this.hermesBoots.ForeImage = null;
            this.hermesBoots.Location = new System.Drawing.Point(0, 0);
            this.hermesBoots.Margin = new System.Windows.Forms.Padding(0);
            this.hermesBoots.Name = "hermesBoots";
            this.hermesBoots.RedrawOnStateChange = true;
            this.hermesBoots.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
            this.hermesBoots.Size = new System.Drawing.Size(40, 40);
            this.hermesBoots.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_solid;
            this.hermesBoots.TabIndex = 44;
            this.hermesBoots.TabStop = false;
            // 
            // grappleClaw
            // 
            this.grappleClaw.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
            this.grappleClaw.Collected = false;
            this.grappleClaw.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw;
            this.grappleClaw.ForeCollected = false;
            this.grappleClaw.ForeImage = null;
            this.grappleClaw.Location = new System.Drawing.Point(40, 0);
            this.grappleClaw.Margin = new System.Windows.Forms.Padding(0);
            this.grappleClaw.Name = "grappleClaw";
            this.grappleClaw.RedrawOnStateChange = true;
            this.grappleClaw.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
            this.grappleClaw.Size = new System.Drawing.Size(40, 40);
            this.grappleClaw.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_solid;
            this.grappleClaw.TabIndex = 45;
            this.grappleClaw.TabStop = false;
            // 
            // feather
            // 
            this.feather.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
            this.feather.Collected = false;
            this.feather.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_feather;
            this.feather.ForeCollected = false;
            this.feather.ForeImage = null;
            this.feather.Location = new System.Drawing.Point(80, 0);
            this.feather.Margin = new System.Windows.Forms.Padding(0);
            this.feather.Name = "feather";
            this.feather.RedrawOnStateChange = true;
            this.feather.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
            this.feather.Size = new System.Drawing.Size(40, 40);
            this.feather.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_feather_solid;
            this.feather.TabIndex = 46;
            this.feather.TabStop = false;
            // 
            // scanner
            // 
            this.scanner.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
            this.scanner.Collected = false;
            this.scanner.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_handscanner;
            this.scanner.ForeCollected = false;
            this.scanner.ForeImage = null;
            this.scanner.Location = new System.Drawing.Point(120, 0);
            this.scanner.Margin = new System.Windows.Forms.Padding(0);
            this.scanner.Name = "scanner";
            this.scanner.RedrawOnStateChange = true;
            this.scanner.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
            this.scanner.Size = new System.Drawing.Size(40, 40);
            this.scanner.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_handscanner_solid;
            this.scanner.TabIndex = 1;
            this.scanner.TabStop = false;
            // 
            // readerPanel
            // 
            this.readerPanel.Controls.Add(this.reader);
            this.readerPanel.Controls.Add(this.translationTablets);
            this.readerPanel.Item = this.reader;
            this.readerPanel.Label = this.translationTablets;
            this.readerPanel.Location = new System.Drawing.Point(160, 0);
            this.readerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.readerPanel.Name = "readerPanel";
            this.readerPanel.Size = new System.Drawing.Size(40, 56);
            this.readerPanel.TabIndex = 111;
            this.readerPanel.TreatAsAmmo = false;
            // 
            // reader
            // 
            this.reader.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
            this.reader.Collected = false;
            this.reader.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_reader;
            this.reader.Dock = System.Windows.Forms.DockStyle.Top;
            this.reader.ForeCollected = false;
            this.reader.ForeImage = null;
            this.reader.Location = new System.Drawing.Point(0, 0);
            this.reader.Name = "reader";
            this.reader.RedrawOnStateChange = false;
            this.reader.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
            this.reader.Size = new System.Drawing.Size(40, 40);
            this.reader.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_software_solid;
            this.reader.TabIndex = 2;
            this.reader.TabStop = false;
            // 
            // translationTablets
            // 
            this.translationTablets.Count = 0;
            this.translationTablets.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.translationTablets.FormatString = "{0}%";
            this.translationTablets.Location = new System.Drawing.Point(0, 40);
            this.translationTablets.Max = 100;
            this.translationTablets.Name = "translationTablets";
            this.translationTablets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.translationTablets.Size = new System.Drawing.Size(40, 16);
            this.translationTablets.TabIndex = 48;
            this.translationTablets.Text = "0%";
            this.translationTablets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.translationTablets.TreatAsAmmo = false;
            this.translationTablets.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // holyGrail
            // 
            this.holyGrail.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            this.holyGrail.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_holygrail2,
        global::LMRItemTracker.Properties.Resources.Icon_holygrail3,
        global::LMRItemTracker.Properties.Resources.Icon_holygrail};
            this.holyGrail.Location = new System.Drawing.Point(200, 0);
            this.holyGrail.Margin = new System.Windows.Forms.Padding(0);
            this.holyGrail.Name = "holyGrail";
            this.holyGrail.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            this.holyGrail.Size = new System.Drawing.Size(40, 40);
            this.holyGrail.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_holygrail_solid;
            this.holyGrail.TabIndex = 114;
            this.holyGrail.TabStop = false;
            // 
            // mirai
            // 
            this.mirai.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
            this.mirai.Collected = false;
            this.mirai.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_mirai;
            this.mirai.ForeCollected = false;
            this.mirai.ForeImage = null;
            this.mirai.Location = new System.Drawing.Point(240, 0);
            this.mirai.Margin = new System.Windows.Forms.Padding(0);
            this.mirai.Name = "mirai";
            this.mirai.RedrawOnStateChange = true;
            this.mirai.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
            this.mirai.Size = new System.Drawing.Size(40, 40);
            this.mirai.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_software_solid;
            this.mirai.TabIndex = 115;
            this.mirai.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.spaulderPanel);
            this.mainPanel.Controls.Add(this.overviewPanel);
            this.mainPanel.Controls.Add(this.flowLayoutPanel1);
            this.mainPanel.Controls.Add(this.flowLayoutPanel2);
            this.mainPanel.Controls.Add(this.flowLayoutPanel3);
            this.mainPanel.Controls.Add(this.flowLayoutPanel4);
            this.mainPanel.Controls.Add(this.flowLayoutPanel5);
            this.mainPanel.Controls.Add(this.flowLayoutPanel6);
            this.mainPanel.Controls.Add(this.bossPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanel.Size = new System.Drawing.Size(340, 798);
            this.mainPanel.TabIndex = 111;
            this.mainPanel.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // spaulderPanel
            // 
            this.spaulderPanel.AutoSize = true;
            this.spaulderPanel.Controls.Add(this.flowLayoutPanel8);
            this.spaulderPanel.Controls.Add(this.flowLayoutPanel9);
            this.mainPanel.SetFlowBreak(this.spaulderPanel, true);
            this.spaulderPanel.Location = new System.Drawing.Point(10, 10);
            this.spaulderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.spaulderPanel.Name = "spaulderPanel";
            this.spaulderPanel.Size = new System.Drawing.Size(305, 40);
            this.spaulderPanel.TabIndex = 120;
            this.spaulderPanel.WrapContents = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.spaulderPanel.SetFlowBreak(this.flowLayoutPanel8, true);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel8.TabIndex = 118;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel9.Controls.Add(this.spaulderLabel);
            this.flowLayoutPanel9.Controls.Add(this.spaulderCount);
            this.flowLayoutPanel9.Controls.Add(this.totalSpauldersPanel);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(305, 40);
            this.flowLayoutPanel9.TabIndex = 119;
            this.flowLayoutPanel9.WrapContents = false;
            // 
            // spaulderLabel
            // 
            this.spaulderLabel.AutoSize = true;
            this.spaulderLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.spaulderLabel.Location = new System.Drawing.Point(3, 0);
            this.spaulderLabel.MinimumSize = new System.Drawing.Size(0, 40);
            this.spaulderLabel.Name = "spaulderLabel";
            this.spaulderLabel.Size = new System.Drawing.Size(123, 40);
            this.spaulderLabel.TabIndex = 0;
            this.spaulderLabel.Text = "Times Spaulder\'d:";
            this.spaulderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spaulderLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spaulderCount_MouseClick);
            // 
            // spaulderCount
            // 
            this.spaulderCount.AutoSize = true;
            this.spaulderCount.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.spaulderCount.Location = new System.Drawing.Point(132, 0);
            this.spaulderCount.MinimumSize = new System.Drawing.Size(0, 40);
            this.spaulderCount.Name = "spaulderCount";
            this.spaulderCount.Size = new System.Drawing.Size(15, 40);
            this.spaulderCount.TabIndex = 1;
            this.spaulderCount.Text = "0";
            this.spaulderCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spaulderCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spaulderCount_MouseClick);
            // 
            // totalSpauldersPanel
            // 
            this.totalSpauldersPanel.AutoSize = true;
            this.totalSpauldersPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.totalSpauldersPanel.Controls.Add(this.totalSpauldersLabel);
            this.totalSpauldersPanel.Controls.Add(this.totalSpauldersCount);
            this.totalSpauldersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalSpauldersPanel.Location = new System.Drawing.Point(167, 0);
            this.totalSpauldersPanel.Margin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.totalSpauldersPanel.Name = "totalSpauldersPanel";
            this.totalSpauldersPanel.Size = new System.Drawing.Size(138, 40);
            this.totalSpauldersPanel.TabIndex = 120;
            this.totalSpauldersPanel.WrapContents = false;
            // 
            // totalSpauldersLabel
            // 
            this.totalSpauldersLabel.AutoSize = true;
            this.totalSpauldersLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.totalSpauldersLabel.Location = new System.Drawing.Point(3, 0);
            this.totalSpauldersLabel.MinimumSize = new System.Drawing.Size(0, 40);
            this.totalSpauldersLabel.Name = "totalSpauldersLabel";
            this.totalSpauldersLabel.Size = new System.Drawing.Size(111, 40);
            this.totalSpauldersLabel.TabIndex = 0;
            this.totalSpauldersLabel.Text = "Total Spaulders:";
            this.totalSpauldersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalSpauldersCount
            // 
            this.totalSpauldersCount.AutoSize = true;
            this.totalSpauldersCount.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.totalSpauldersCount.Location = new System.Drawing.Point(120, 0);
            this.totalSpauldersCount.MinimumSize = new System.Drawing.Size(0, 40);
            this.totalSpauldersCount.Name = "totalSpauldersCount";
            this.totalSpauldersCount.Size = new System.Drawing.Size(15, 40);
            this.totalSpauldersCount.TabIndex = 1;
            this.totalSpauldersCount.Text = "0";
            this.totalSpauldersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overviewPanel
            // 
            this.overviewPanel.AutoSize = true;
            this.overviewPanel.Controls.Add(this.lastItemPanel);
            this.overviewPanel.Controls.Add(this.deathPanel);
            this.mainPanel.SetFlowBreak(this.overviewPanel, true);
            this.overviewPanel.Location = new System.Drawing.Point(10, 50);
            this.overviewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(303, 56);
            this.overviewPanel.TabIndex = 119;
            this.overviewPanel.WrapContents = false;
            // 
            // lastItemPanel
            // 
            this.lastItemPanel.AutoSize = true;
            this.lastItemPanel.Controls.Add(this.lastItemLabel);
            this.lastItemPanel.Controls.Add(this.lastItem1);
            this.lastItemPanel.Controls.Add(this.lastItem2);
            this.lastItemPanel.Controls.Add(this.lastItem3);
            this.overviewPanel.SetFlowBreak(this.lastItemPanel, true);
            this.lastItemPanel.Location = new System.Drawing.Point(0, 0);
            this.lastItemPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.lastItemPanel.Name = "lastItemPanel";
            this.lastItemPanel.Size = new System.Drawing.Size(219, 40);
            this.lastItemPanel.TabIndex = 118;
            // 
            // lastItemLabel
            // 
            this.lastItemLabel.AutoSize = true;
            this.lastItemLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lastItemLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lastItemLabel.Location = new System.Drawing.Point(0, 0);
            this.lastItemLabel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lastItemLabel.Name = "lastItemLabel";
            this.lastItemLabel.Size = new System.Drawing.Size(94, 40);
            this.lastItemLabel.TabIndex = 115;
            this.lastItemLabel.Text = "Recent Items:";
            this.lastItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastItemLabel.Click += new System.EventHandler(this.changeLanguage);
            this.lastItemLabel.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // lastItem1
            // 
            this.lastItem1.Location = new System.Drawing.Point(99, 0);
            this.lastItem1.Margin = new System.Windows.Forms.Padding(0);
            this.lastItem1.Name = "lastItem1";
            this.lastItem1.Size = new System.Drawing.Size(40, 40);
            this.lastItem1.TabIndex = 114;
            this.lastItem1.TabStop = false;
            // 
            // lastItem2
            // 
            this.lastItem2.Location = new System.Drawing.Point(139, 0);
            this.lastItem2.Margin = new System.Windows.Forms.Padding(0);
            this.lastItem2.Name = "lastItem2";
            this.lastItem2.Size = new System.Drawing.Size(40, 40);
            this.lastItem2.TabIndex = 116;
            this.lastItem2.TabStop = false;
            // 
            // lastItem3
            // 
            this.lastItem3.Location = new System.Drawing.Point(179, 0);
            this.lastItem3.Margin = new System.Windows.Forms.Padding(0);
            this.lastItem3.Name = "lastItem3";
            this.lastItem3.Size = new System.Drawing.Size(40, 40);
            this.lastItem3.TabIndex = 117;
            this.lastItem3.TabStop = false;
            // 
            // deathPanel
            // 
            this.deathPanel.AutoSize = true;
            this.deathPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deathPanel.Controls.Add(this.deathLabel);
            this.deathPanel.Controls.Add(this.deathCount);
            this.deathPanel.Location = new System.Drawing.Point(227, 0);
            this.deathPanel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.deathPanel.Name = "deathPanel";
            this.deathPanel.Size = new System.Drawing.Size(76, 40);
            this.deathPanel.TabIndex = 119;
            this.deathPanel.WrapContents = false;
            this.deathPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deathCount_MouseClick);
            // 
            // deathLabel
            // 
            this.deathLabel.AutoSize = true;
            this.deathLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.deathLabel.Location = new System.Drawing.Point(3, 0);
            this.deathLabel.MinimumSize = new System.Drawing.Size(0, 40);
            this.deathLabel.Name = "deathLabel";
            this.deathLabel.Size = new System.Drawing.Size(49, 40);
            this.deathLabel.TabIndex = 0;
            this.deathLabel.Text = "Death:";
            this.deathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deathLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deathCount_MouseClick);
            // 
            // deathCount
            // 
            this.deathCount.AutoSize = true;
            this.deathCount.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.deathCount.Location = new System.Drawing.Point(58, 0);
            this.deathCount.MinimumSize = new System.Drawing.Size(0, 40);
            this.deathCount.Name = "deathCount";
            this.deathCount.Size = new System.Drawing.Size(15, 40);
            this.deathCount.TabIndex = 1;
            this.deathCount.Text = "0";
            this.deathCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deathCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deathCount_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.bronzeMirror);
            this.flowLayoutPanel2.Controls.Add(this.fruitOfEden);
            this.flowLayoutPanel2.Controls.Add(this.twinStatue);
            this.flowLayoutPanel2.Controls.Add(this.keyOfEternity);
            this.flowLayoutPanel2.Controls.Add(this.helmet);
            this.flowLayoutPanel2.Controls.Add(this.planeModel);
            this.flowLayoutPanel2.Controls.Add(this.crystalSkull);
            this.flowLayoutPanel2.Controls.Add(this.dimensionalKey);
            this.flowLayoutPanel2.Controls.Add(this.pochetteKey);
            this.flowLayoutPanel2.Controls.Add(this.iceCape);
            this.flowLayoutPanel2.Controls.Add(this.scalesphere);
            this.flowLayoutPanel2.Controls.Add(this.cogOfTheSoul);
            this.flowLayoutPanel2.Controls.Add(this.dragonBone);
            this.flowLayoutPanel2.Controls.Add(this.serpentStaff);
            this.flowLayoutPanel2.Controls.Add(this.mulanaTalisman);
            this.flowLayoutPanel2.Controls.Add(this.womanStatue);
            this.flowLayoutPanel2.Controls.Add(this.pepper);
            this.flowLayoutPanel2.Controls.Add(this.talisman);
            this.flowLayoutPanel2.Controls.Add(this.diary);
            this.flowLayoutPanel2.Controls.Add(this.miniDoll);
            this.flowLayoutPanel2.Controls.Add(this.treasures);
            this.flowLayoutPanel2.Controls.Add(this.anchor);
            this.flowLayoutPanel2.Controls.Add(this.keyFairy);
            this.flowLayoutPanel2.Controls.Add(this.isisPendant);
            this.flowLayoutPanel2.Controls.Add(this.eyeOfTruth);
            this.flowLayoutPanel2.Controls.Add(this.magatamaJewel);
            this.flowLayoutPanel2.Controls.Add(this.torude);
            this.flowLayoutPanel2.Controls.Add(this.shrinePanel);
            this.flowLayoutPanel2.Controls.Add(this.secretTreasureOfLife);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel2, true);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 170);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 176);
            this.flowLayoutPanel2.TabIndex = 112;
            this.flowLayoutPanel2.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // bronzeMirror
            // 
            this.bronzeMirror.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
            this.bronzeMirror.Collected = false;
            this.bronzeMirror.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror;
            this.bronzeMirror.ForeCollected = false;
            this.bronzeMirror.ForeImage = null;
            this.bronzeMirror.Location = new System.Drawing.Point(0, 0);
            this.bronzeMirror.Margin = new System.Windows.Forms.Padding(0);
            this.bronzeMirror.Name = "bronzeMirror";
            this.bronzeMirror.RedrawOnStateChange = true;
            this.bronzeMirror.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
            this.bronzeMirror.Size = new System.Drawing.Size(40, 40);
            this.bronzeMirror.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_solid;
            this.bronzeMirror.TabIndex = 38;
            this.bronzeMirror.TabStop = false;
            // 
            // fruitOfEden
            // 
            this.fruitOfEden.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
            this.fruitOfEden.Collected = false;
            this.fruitOfEden.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden;
            this.fruitOfEden.ForeCollected = false;
            this.fruitOfEden.ForeImage = null;
            this.fruitOfEden.Location = new System.Drawing.Point(40, 0);
            this.fruitOfEden.Margin = new System.Windows.Forms.Padding(0);
            this.fruitOfEden.Name = "fruitOfEden";
            this.fruitOfEden.RedrawOnStateChange = true;
            this.fruitOfEden.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
            this.fruitOfEden.Size = new System.Drawing.Size(40, 40);
            this.fruitOfEden.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_solid;
            this.fruitOfEden.TabIndex = 39;
            this.fruitOfEden.TabStop = false;
            // 
            // twinStatue
            // 
            this.twinStatue.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
            this.twinStatue.Collected = false;
            this.twinStatue.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_twinstatue;
            this.twinStatue.ForeCollected = false;
            this.twinStatue.ForeImage = null;
            this.twinStatue.Location = new System.Drawing.Point(80, 0);
            this.twinStatue.Margin = new System.Windows.Forms.Padding(0);
            this.twinStatue.Name = "twinStatue";
            this.twinStatue.RedrawOnStateChange = true;
            this.twinStatue.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
            this.twinStatue.Size = new System.Drawing.Size(40, 40);
            this.twinStatue.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_solid;
            this.twinStatue.TabIndex = 40;
            this.twinStatue.TabStop = false;
            // 
            // keyOfEternity
            // 
            this.keyOfEternity.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
            this.keyOfEternity.Collected = false;
            this.keyOfEternity.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity;
            this.keyOfEternity.ForeCollected = false;
            this.keyOfEternity.ForeImage = null;
            this.keyOfEternity.Location = new System.Drawing.Point(120, 0);
            this.keyOfEternity.Margin = new System.Windows.Forms.Padding(0);
            this.keyOfEternity.Name = "keyOfEternity";
            this.keyOfEternity.RedrawOnStateChange = true;
            this.keyOfEternity.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
            this.keyOfEternity.Size = new System.Drawing.Size(40, 40);
            this.keyOfEternity.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_solid;
            this.keyOfEternity.TabIndex = 41;
            this.keyOfEternity.TabStop = false;
            // 
            // helmet
            // 
            this.helmet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
            this.helmet.Collected = false;
            this.helmet.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_helmet;
            this.helmet.ForeCollected = false;
            this.helmet.ForeImage = null;
            this.helmet.Location = new System.Drawing.Point(160, 0);
            this.helmet.Margin = new System.Windows.Forms.Padding(0);
            this.helmet.Name = "helmet";
            this.helmet.RedrawOnStateChange = true;
            this.helmet.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
            this.helmet.Size = new System.Drawing.Size(40, 40);
            this.helmet.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_helmet_solid;
            this.helmet.TabIndex = 51;
            this.helmet.TabStop = false;
            // 
            // planeModel
            // 
            this.planeModel.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            this.planeModel.Collected = false;
            this.planeModel.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_planemodel;
            this.planeModel.ForeCollected = false;
            this.planeModel.ForeImage = null;
            this.planeModel.Location = new System.Drawing.Point(200, 0);
            this.planeModel.Margin = new System.Windows.Forms.Padding(0);
            this.planeModel.Name = "planeModel";
            this.planeModel.RedrawOnStateChange = true;
            this.planeModel.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            this.planeModel.Size = new System.Drawing.Size(40, 40);
            this.planeModel.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_planemodel_solid;
            this.planeModel.TabIndex = 52;
            this.planeModel.TabStop = false;
            // 
            // crystalSkull
            // 
            this.crystalSkull.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            this.crystalSkull.Collected = false;
            this.crystalSkull.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_crystalskull;
            this.crystalSkull.ForeCollected = false;
            this.crystalSkull.ForeImage = null;
            this.crystalSkull.Location = new System.Drawing.Point(240, 0);
            this.crystalSkull.Margin = new System.Windows.Forms.Padding(0);
            this.crystalSkull.Name = "crystalSkull";
            this.crystalSkull.RedrawOnStateChange = true;
            this.crystalSkull.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            this.crystalSkull.Size = new System.Drawing.Size(40, 40);
            this.crystalSkull.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_solid;
            this.crystalSkull.TabIndex = 57;
            this.crystalSkull.TabStop = false;
            // 
            // dimensionalKey
            // 
            this.dimensionalKey.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
            this.dimensionalKey.Collected = false;
            this.dimensionalKey.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey;
            this.dimensionalKey.ForeCollected = false;
            this.dimensionalKey.ForeImage = null;
            this.dimensionalKey.Location = new System.Drawing.Point(280, 0);
            this.dimensionalKey.Margin = new System.Windows.Forms.Padding(0);
            this.dimensionalKey.Name = "dimensionalKey";
            this.dimensionalKey.RedrawOnStateChange = true;
            this.dimensionalKey.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
            this.dimensionalKey.Size = new System.Drawing.Size(40, 40);
            this.dimensionalKey.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_solid;
            this.dimensionalKey.TabIndex = 56;
            this.dimensionalKey.TabStop = false;
            // 
            // pochetteKey
            // 
            this.pochetteKey.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
            this.pochetteKey.Collected = false;
            this.pochetteKey.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_pochettekey;
            this.pochetteKey.ForeCollected = false;
            this.pochetteKey.ForeImage = null;
            this.pochetteKey.Location = new System.Drawing.Point(0, 40);
            this.pochetteKey.Margin = new System.Windows.Forms.Padding(0);
            this.pochetteKey.Name = "pochetteKey";
            this.pochetteKey.RedrawOnStateChange = true;
            this.pochetteKey.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
            this.pochetteKey.Size = new System.Drawing.Size(40, 40);
            this.pochetteKey.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_solid;
            this.pochetteKey.TabIndex = 65;
            this.pochetteKey.TabStop = false;
            // 
            // iceCape
            // 
            this.iceCape.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
            this.iceCape.Collected = false;
            this.iceCape.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_icecape;
            this.iceCape.ForeCollected = false;
            this.iceCape.ForeImage = null;
            this.iceCape.Location = new System.Drawing.Point(40, 40);
            this.iceCape.Margin = new System.Windows.Forms.Padding(0);
            this.iceCape.Name = "iceCape";
            this.iceCape.RedrawOnStateChange = true;
            this.iceCape.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
            this.iceCape.Size = new System.Drawing.Size(40, 40);
            this.iceCape.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_icecape_solid;
            this.iceCape.TabIndex = 80;
            this.iceCape.TabStop = false;
            // 
            // scalesphere
            // 
            this.scalesphere.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
            this.scalesphere.Collected = false;
            this.scalesphere.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_scalesphere;
            this.scalesphere.ForeCollected = false;
            this.scalesphere.ForeImage = null;
            this.scalesphere.Location = new System.Drawing.Point(80, 40);
            this.scalesphere.Margin = new System.Windows.Forms.Padding(0);
            this.scalesphere.Name = "scalesphere";
            this.scalesphere.RedrawOnStateChange = true;
            this.scalesphere.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
            this.scalesphere.Size = new System.Drawing.Size(40, 40);
            this.scalesphere.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_solid;
            this.scalesphere.TabIndex = 94;
            this.scalesphere.TabStop = false;
            // 
            // cogOfTheSoul
            // 
            this.cogOfTheSoul.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.cogOfTheSoul.Collected = false;
            this.cogOfTheSoul.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul;
            this.cogOfTheSoul.ForeCollected = false;
            this.cogOfTheSoul.ForeImage = null;
            this.cogOfTheSoul.Location = new System.Drawing.Point(120, 40);
            this.cogOfTheSoul.Margin = new System.Windows.Forms.Padding(0);
            this.cogOfTheSoul.Name = "cogOfTheSoul";
            this.cogOfTheSoul.RedrawOnStateChange = true;
            this.cogOfTheSoul.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.cogOfTheSoul.Size = new System.Drawing.Size(40, 40);
            this.cogOfTheSoul.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_solid;
            this.cogOfTheSoul.TabIndex = 53;
            this.cogOfTheSoul.TabStop = false;
            // 
            // dragonBone
            // 
            this.dragonBone.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            this.dragonBone.Collected = false;
            this.dragonBone.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_dragonbone;
            this.dragonBone.ForeCollected = false;
            this.dragonBone.ForeImage = null;
            this.dragonBone.Location = new System.Drawing.Point(160, 40);
            this.dragonBone.Margin = new System.Windows.Forms.Padding(0);
            this.dragonBone.Name = "dragonBone";
            this.dragonBone.RedrawOnStateChange = true;
            this.dragonBone.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            this.dragonBone.Size = new System.Drawing.Size(40, 40);
            this.dragonBone.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_solid;
            this.dragonBone.TabIndex = 68;
            this.dragonBone.TabStop = false;
            // 
            // serpentStaff
            // 
            this.serpentStaff.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
            this.serpentStaff.Collected = false;
            this.serpentStaff.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff;
            this.serpentStaff.ForeCollected = false;
            this.serpentStaff.ForeImage = null;
            this.serpentStaff.Location = new System.Drawing.Point(200, 40);
            this.serpentStaff.Margin = new System.Windows.Forms.Padding(0);
            this.serpentStaff.Name = "serpentStaff";
            this.serpentStaff.RedrawOnStateChange = true;
            this.serpentStaff.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
            this.serpentStaff.Size = new System.Drawing.Size(40, 40);
            this.serpentStaff.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_solid;
            this.serpentStaff.TabIndex = 95;
            this.serpentStaff.TabStop = false;
            // 
            // mulanaTalisman
            // 
            this.mulanaTalisman.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            this.mulanaTalisman.Collected = false;
            this.mulanaTalisman.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman;
            this.mulanaTalisman.ForeCollected = false;
            this.mulanaTalisman.ForeImage = null;
            this.mulanaTalisman.Location = new System.Drawing.Point(240, 40);
            this.mulanaTalisman.Margin = new System.Windows.Forms.Padding(0);
            this.mulanaTalisman.Name = "mulanaTalisman";
            this.mulanaTalisman.RedrawOnStateChange = true;
            this.mulanaTalisman.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            this.mulanaTalisman.Size = new System.Drawing.Size(40, 40);
            this.mulanaTalisman.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_solid;
            this.mulanaTalisman.TabIndex = 27;
            this.mulanaTalisman.TabStop = false;
            // 
            // womanStatue
            // 
            this.womanStatue.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
            this.womanStatue.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_maternitystatue,
        global::LMRItemTracker.Properties.Resources.Icon_womanstatue};
            this.womanStatue.Location = new System.Drawing.Point(280, 40);
            this.womanStatue.Margin = new System.Windows.Forms.Padding(0);
            this.womanStatue.Name = "womanStatue";
            this.womanStatue.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
            this.womanStatue.Size = new System.Drawing.Size(40, 40);
            this.womanStatue.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_solid;
            this.womanStatue.TabIndex = 117;
            this.womanStatue.TabStop = false;
            // 
            // pepper
            // 
            this.pepper.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
            this.pepper.Collected = false;
            this.pepper.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_pepper;
            this.pepper.ForeCollected = false;
            this.pepper.ForeImage = null;
            this.pepper.Location = new System.Drawing.Point(0, 80);
            this.pepper.Margin = new System.Windows.Forms.Padding(0);
            this.pepper.Name = "pepper";
            this.pepper.RedrawOnStateChange = true;
            this.pepper.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
            this.pepper.Size = new System.Drawing.Size(40, 40);
            this.pepper.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_pepper_solid;
            this.pepper.TabIndex = 76;
            this.pepper.TabStop = false;
            // 
            // talisman
            // 
            this.talisman.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            this.talisman.Collected = false;
            this.talisman.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_talisman;
            this.talisman.ForeCollected = false;
            this.talisman.ForeImage = null;
            this.talisman.Location = new System.Drawing.Point(40, 80);
            this.talisman.Margin = new System.Windows.Forms.Padding(0);
            this.talisman.Name = "talisman";
            this.talisman.RedrawOnStateChange = true;
            this.talisman.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            this.talisman.Size = new System.Drawing.Size(40, 40);
            this.talisman.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_talisman_solid;
            this.talisman.TabIndex = 25;
            this.talisman.TabStop = false;
            // 
            // diary
            // 
            this.diary.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            this.diary.Collected = false;
            this.diary.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_diary;
            this.diary.ForeCollected = false;
            this.diary.ForeImage = null;
            this.diary.Location = new System.Drawing.Point(80, 80);
            this.diary.Margin = new System.Windows.Forms.Padding(0);
            this.diary.Name = "diary";
            this.diary.RedrawOnStateChange = true;
            this.diary.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            this.diary.Size = new System.Drawing.Size(40, 40);
            this.diary.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_diary_solid;
            this.diary.TabIndex = 26;
            this.diary.TabStop = false;
            // 
            // miniDoll
            // 
            this.miniDoll.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
            this.miniDoll.Collected = false;
            this.miniDoll.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_minidoll;
            this.miniDoll.ForeCollected = false;
            this.miniDoll.ForeImage = null;
            this.miniDoll.Location = new System.Drawing.Point(120, 80);
            this.miniDoll.Margin = new System.Windows.Forms.Padding(0);
            this.miniDoll.Name = "miniDoll";
            this.miniDoll.RedrawOnStateChange = true;
            this.miniDoll.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
            this.miniDoll.Size = new System.Drawing.Size(40, 40);
            this.miniDoll.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_minidoll_solid;
            this.miniDoll.TabIndex = 78;
            this.miniDoll.TabStop = false;
            // 
            // treasures
            // 
            this.treasures.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            this.treasures.Collected = false;
            this.treasures.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_treasures;
            this.treasures.ForeCollected = false;
            this.treasures.ForeImage = null;
            this.treasures.Location = new System.Drawing.Point(160, 80);
            this.treasures.Margin = new System.Windows.Forms.Padding(0);
            this.treasures.Name = "treasures";
            this.treasures.RedrawOnStateChange = true;
            this.treasures.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            this.treasures.Size = new System.Drawing.Size(40, 40);
            this.treasures.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_treasures_solid;
            this.treasures.TabIndex = 47;
            this.treasures.TabStop = false;
            // 
            // anchor
            // 
            this.anchor.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
            this.anchor.Collected = false;
            this.anchor.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_anchor;
            this.anchor.ForeCollected = false;
            this.anchor.ForeImage = null;
            this.anchor.Location = new System.Drawing.Point(200, 80);
            this.anchor.Margin = new System.Windows.Forms.Padding(0);
            this.anchor.Name = "anchor";
            this.anchor.RedrawOnStateChange = true;
            this.anchor.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
            this.anchor.Size = new System.Drawing.Size(40, 40);
            this.anchor.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_anchor_solid;
            this.anchor.TabIndex = 87;
            this.anchor.TabStop = false;
            // 
            // keyFairy
            // 
            this.keyFairy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank;
            this.keyFairy.Location = new System.Drawing.Point(240, 80);
            this.keyFairy.Margin = new System.Windows.Forms.Padding(0);
            this.keyFairy.Name = "keyFairy";
            this.keyFairy.Size = new System.Drawing.Size(40, 40);
            this.keyFairy.TabIndex = 49;
            this.keyFairy.TabStop = false;
            // 
            // isisPendant
            // 
            this.isisPendant.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            this.isisPendant.Collected = false;
            this.isisPendant.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_isispendant;
            this.isisPendant.ForeCollected = false;
            this.isisPendant.ForeImage = null;
            this.isisPendant.Location = new System.Drawing.Point(280, 80);
            this.isisPendant.Margin = new System.Windows.Forms.Padding(0);
            this.isisPendant.Name = "isisPendant";
            this.isisPendant.RedrawOnStateChange = true;
            this.isisPendant.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            this.isisPendant.Size = new System.Drawing.Size(40, 40);
            this.isisPendant.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_isispendant_solid;
            this.isisPendant.TabIndex = 42;
            this.isisPendant.TabStop = false;
            // 
            // eyeOfTruth
            // 
            this.eyeOfTruth.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
            this.eyeOfTruth.Collected = false;
            this.eyeOfTruth.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth;
            this.eyeOfTruth.ForeCollected = false;
            this.eyeOfTruth.ForeImage = null;
            this.eyeOfTruth.Location = new System.Drawing.Point(0, 120);
            this.eyeOfTruth.Margin = new System.Windows.Forms.Padding(0);
            this.eyeOfTruth.Name = "eyeOfTruth";
            this.eyeOfTruth.RedrawOnStateChange = true;
            this.eyeOfTruth.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
            this.eyeOfTruth.Size = new System.Drawing.Size(40, 40);
            this.eyeOfTruth.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_solid;
            this.eyeOfTruth.TabIndex = 77;
            this.eyeOfTruth.TabStop = false;
            // 
            // magatamaJewel
            // 
            this.magatamaJewel.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
            this.magatamaJewel.Collected = false;
            this.magatamaJewel.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel;
            this.magatamaJewel.ForeCollected = false;
            this.magatamaJewel.ForeImage = null;
            this.magatamaJewel.Location = new System.Drawing.Point(40, 120);
            this.magatamaJewel.Margin = new System.Windows.Forms.Padding(0);
            this.magatamaJewel.Name = "magatamaJewel";
            this.magatamaJewel.RedrawOnStateChange = true;
            this.magatamaJewel.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
            this.magatamaJewel.Size = new System.Drawing.Size(40, 40);
            this.magatamaJewel.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_solid;
            this.magatamaJewel.TabIndex = 79;
            this.magatamaJewel.TabStop = false;
            // 
            // torude
            // 
            this.torude.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
            this.torude.Collected = false;
            this.torude.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_torude;
            this.torude.ForeCollected = false;
            this.torude.ForeImage = null;
            this.torude.Location = new System.Drawing.Point(80, 120);
            this.torude.Margin = new System.Windows.Forms.Padding(0);
            this.torude.Name = "torude";
            this.torude.RedrawOnStateChange = true;
            this.torude.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
            this.torude.Size = new System.Drawing.Size(40, 40);
            this.torude.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_software_solid;
            this.torude.TabIndex = 96;
            this.torude.TabStop = false;
            // 
            // shrinePanel
            // 
            this.shrinePanel.Controls.Add(this.skullWall);
            this.shrinePanel.Controls.Add(this.skullWallCount);
            this.shrinePanel.Item = this.skullWall;
            this.shrinePanel.Label = this.skullWallCount;
            this.shrinePanel.Location = new System.Drawing.Point(120, 120);
            this.shrinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.shrinePanel.Name = "shrinePanel";
            this.shrinePanel.Size = new System.Drawing.Size(40, 56);
            this.shrinePanel.TabIndex = 115;
            this.shrinePanel.TreatAsAmmo = false;
            // 
            // skullWall
            // 
            this.skullWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skullWall.BackgroundImage")));
            this.skullWall.Collected = true;
            this.skullWall.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_skullwall;
            this.skullWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.skullWall.ForeCollected = false;
            this.skullWall.ForeImage = null;
            this.skullWall.Location = new System.Drawing.Point(0, 0);
            this.skullWall.Margin = new System.Windows.Forms.Padding(0);
            this.skullWall.Name = "skullWall";
            this.skullWall.RedrawOnStateChange = false;
            this.skullWall.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_skullwall;
            this.skullWall.Size = new System.Drawing.Size(40, 40);
            this.skullWall.SolidImage = null;
            this.skullWall.TabIndex = 35;
            this.skullWall.TabStop = false;
            // 
            // skullWallCount
            // 
            this.skullWallCount.Count = 0;
            this.skullWallCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skullWallCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.skullWallCount.FormatString = "{0}/{1}";
            this.skullWallCount.Location = new System.Drawing.Point(0, 40);
            this.skullWallCount.Max = 4;
            this.skullWallCount.Name = "skullWallCount";
            this.skullWallCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skullWallCount.Size = new System.Drawing.Size(40, 16);
            this.skullWallCount.TabIndex = 67;
            this.skullWallCount.Text = "0/4";
            this.skullWallCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skullWallCount.TreatAsAmmo = false;
            this.skullWallCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // secretTreasureOfLife
            // 
            this.secretTreasureOfLife.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_secrettreasureoflife_blank;
            this.secretTreasureOfLife.Collected = false;
            this.secretTreasureOfLife.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_secrettreasureoflife;
            this.secretTreasureOfLife.ForeCollected = false;
            this.secretTreasureOfLife.ForeImage = null;
            this.secretTreasureOfLife.Location = new System.Drawing.Point(160, 120);
            this.secretTreasureOfLife.Margin = new System.Windows.Forms.Padding(0);
            this.secretTreasureOfLife.Name = "secretTreasureOfLife";
            this.secretTreasureOfLife.RedrawOnStateChange = true;
            this.secretTreasureOfLife.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_secrettreasureoflife_blank;
            this.secretTreasureOfLife.Size = new System.Drawing.Size(40, 40);
            this.secretTreasureOfLife.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_secrettreasureoflife_solid;
            this.secretTreasureOfLife.TabIndex = 118;
            this.secretTreasureOfLife.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.originSeal);
            this.flowLayoutPanel3.Controls.Add(this.birthSeal);
            this.flowLayoutPanel3.Controls.Add(this.lifeSeal);
            this.flowLayoutPanel3.Controls.Add(this.deathSeal);
            this.flowLayoutPanel3.Controls.Add(this.bookOfTheDead);
            this.flowLayoutPanel3.Controls.Add(this.ring);
            this.flowLayoutPanel3.Controls.Add(this.fairyClothes);
            this.flowLayoutPanel3.Controls.Add(this.msx2);
            this.flowLayoutPanel3.Controls.Add(this.scriptures);
            this.flowLayoutPanel3.Controls.Add(this.crucifix);
            this.flowLayoutPanel3.Controls.Add(this.perfume);
            this.flowLayoutPanel3.Controls.Add(this.glove);
            this.flowLayoutPanel3.Controls.Add(this.bracelet);
            this.flowLayoutPanel3.Controls.Add(this.spaulder);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel3, true);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 354);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(320, 80);
            this.flowLayoutPanel3.TabIndex = 117;
            this.flowLayoutPanel3.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // originSeal
            // 
            this.originSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            this.originSeal.Collected = false;
            this.originSeal.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_originseal;
            this.originSeal.ForeCollected = false;
            this.originSeal.ForeImage = null;
            this.originSeal.Location = new System.Drawing.Point(0, 0);
            this.originSeal.Margin = new System.Windows.Forms.Padding(0);
            this.originSeal.Name = "originSeal";
            this.originSeal.RedrawOnStateChange = true;
            this.originSeal.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            this.originSeal.Size = new System.Drawing.Size(40, 40);
            this.originSeal.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_solid;
            this.originSeal.TabIndex = 60;
            this.originSeal.TabStop = false;
            // 
            // birthSeal
            // 
            this.birthSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            this.birthSeal.Collected = false;
            this.birthSeal.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal;
            this.birthSeal.ForeCollected = false;
            this.birthSeal.ForeImage = null;
            this.birthSeal.Location = new System.Drawing.Point(40, 0);
            this.birthSeal.Margin = new System.Windows.Forms.Padding(0);
            this.birthSeal.Name = "birthSeal";
            this.birthSeal.RedrawOnStateChange = true;
            this.birthSeal.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            this.birthSeal.Size = new System.Drawing.Size(40, 40);
            this.birthSeal.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_solid;
            this.birthSeal.TabIndex = 61;
            this.birthSeal.TabStop = false;
            // 
            // lifeSeal
            // 
            this.lifeSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            this.lifeSeal.Collected = false;
            this.lifeSeal.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal;
            this.lifeSeal.ForeCollected = false;
            this.lifeSeal.ForeImage = null;
            this.lifeSeal.Location = new System.Drawing.Point(80, 0);
            this.lifeSeal.Margin = new System.Windows.Forms.Padding(0);
            this.lifeSeal.Name = "lifeSeal";
            this.lifeSeal.RedrawOnStateChange = true;
            this.lifeSeal.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            this.lifeSeal.Size = new System.Drawing.Size(40, 40);
            this.lifeSeal.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_solid;
            this.lifeSeal.TabIndex = 62;
            this.lifeSeal.TabStop = false;
            // 
            // deathSeal
            // 
            this.deathSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            this.deathSeal.Collected = false;
            this.deathSeal.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal;
            this.deathSeal.ForeCollected = false;
            this.deathSeal.ForeImage = null;
            this.deathSeal.Location = new System.Drawing.Point(120, 0);
            this.deathSeal.Margin = new System.Windows.Forms.Padding(0);
            this.deathSeal.Name = "deathSeal";
            this.deathSeal.RedrawOnStateChange = true;
            this.deathSeal.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            this.deathSeal.Size = new System.Drawing.Size(40, 40);
            this.deathSeal.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_solid;
            this.deathSeal.TabIndex = 63;
            this.deathSeal.TabStop = false;
            // 
            // bookOfTheDead
            // 
            this.bookOfTheDead.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
            this.bookOfTheDead.Collected = false;
            this.bookOfTheDead.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead;
            this.bookOfTheDead.ForeCollected = false;
            this.bookOfTheDead.ForeImage = null;
            this.bookOfTheDead.Location = new System.Drawing.Point(160, 0);
            this.bookOfTheDead.Margin = new System.Windows.Forms.Padding(0);
            this.bookOfTheDead.Name = "bookOfTheDead";
            this.bookOfTheDead.RedrawOnStateChange = true;
            this.bookOfTheDead.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
            this.bookOfTheDead.Size = new System.Drawing.Size(40, 40);
            this.bookOfTheDead.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_solid;
            this.bookOfTheDead.TabIndex = 69;
            this.bookOfTheDead.TabStop = false;
            // 
            // ring
            // 
            this.ring.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
            this.ring.Collected = false;
            this.ring.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_ring;
            this.ring.ForeCollected = false;
            this.ring.ForeImage = null;
            this.ring.Location = new System.Drawing.Point(200, 0);
            this.ring.Margin = new System.Windows.Forms.Padding(0);
            this.ring.Name = "ring";
            this.ring.RedrawOnStateChange = true;
            this.ring.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
            this.ring.Size = new System.Drawing.Size(40, 40);
            this.ring.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_ring_solid;
            this.ring.TabIndex = 55;
            this.ring.TabStop = false;
            // 
            // fairyClothes
            // 
            this.fairyClothes.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
            this.fairyClothes.Collected = false;
            this.fairyClothes.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes;
            this.fairyClothes.ForeCollected = false;
            this.fairyClothes.ForeImage = null;
            this.fairyClothes.Location = new System.Drawing.Point(240, 0);
            this.fairyClothes.Margin = new System.Windows.Forms.Padding(0);
            this.fairyClothes.Name = "fairyClothes";
            this.fairyClothes.RedrawOnStateChange = true;
            this.fairyClothes.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
            this.fairyClothes.Size = new System.Drawing.Size(40, 40);
            this.fairyClothes.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_solid;
            this.fairyClothes.TabIndex = 72;
            this.fairyClothes.TabStop = false;
            // 
            // msx2
            // 
            this.msx2.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
            this.msx2.Collected = false;
            this.msx2.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_msx2;
            this.msx2.ForeCollected = false;
            this.msx2.ForeImage = null;
            this.msx2.Location = new System.Drawing.Point(280, 0);
            this.msx2.Margin = new System.Windows.Forms.Padding(0);
            this.msx2.Name = "msx2";
            this.msx2.RedrawOnStateChange = true;
            this.msx2.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
            this.msx2.Size = new System.Drawing.Size(40, 40);
            this.msx2.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_msx2_solid;
            this.msx2.TabIndex = 91;
            this.msx2.TabStop = false;
            // 
            // scriptures
            // 
            this.scriptures.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
            this.scriptures.Collected = false;
            this.scriptures.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_scriptures;
            this.scriptures.ForeCollected = false;
            this.scriptures.ForeImage = null;
            this.scriptures.Location = new System.Drawing.Point(0, 40);
            this.scriptures.Margin = new System.Windows.Forms.Padding(0);
            this.scriptures.Name = "scriptures";
            this.scriptures.RedrawOnStateChange = true;
            this.scriptures.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
            this.scriptures.Size = new System.Drawing.Size(40, 40);
            this.scriptures.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_scriptures_solid;
            this.scriptures.TabIndex = 70;
            this.scriptures.TabStop = false;
            // 
            // crucifix
            // 
            this.crucifix.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
            this.crucifix.Collected = false;
            this.crucifix.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_crucifix;
            this.crucifix.ForeCollected = false;
            this.crucifix.ForeImage = null;
            this.crucifix.Location = new System.Drawing.Point(40, 40);
            this.crucifix.Margin = new System.Windows.Forms.Padding(0);
            this.crucifix.Name = "crucifix";
            this.crucifix.RedrawOnStateChange = true;
            this.crucifix.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
            this.crucifix.Size = new System.Drawing.Size(40, 40);
            this.crucifix.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_crucifix_solid;
            this.crucifix.TabIndex = 71;
            this.crucifix.TabStop = false;
            // 
            // perfume
            // 
            this.perfume.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
            this.perfume.Collected = false;
            this.perfume.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_perfume;
            this.perfume.ForeCollected = false;
            this.perfume.ForeImage = null;
            this.perfume.Location = new System.Drawing.Point(80, 40);
            this.perfume.Margin = new System.Windows.Forms.Padding(0);
            this.perfume.Name = "perfume";
            this.perfume.RedrawOnStateChange = true;
            this.perfume.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
            this.perfume.Size = new System.Drawing.Size(40, 40);
            this.perfume.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_perfume_solid;
            this.perfume.TabIndex = 92;
            this.perfume.TabStop = false;
            // 
            // glove
            // 
            this.glove.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
            this.glove.Collected = false;
            this.glove.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_glove;
            this.glove.ForeCollected = false;
            this.glove.ForeImage = null;
            this.glove.Location = new System.Drawing.Point(120, 40);
            this.glove.Margin = new System.Windows.Forms.Padding(0);
            this.glove.Name = "glove";
            this.glove.RedrawOnStateChange = true;
            this.glove.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
            this.glove.Size = new System.Drawing.Size(40, 40);
            this.glove.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_glove_solid;
            this.glove.TabIndex = 88;
            this.glove.TabStop = false;
            // 
            // bracelet
            // 
            this.bracelet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
            this.bracelet.Collected = false;
            this.bracelet.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bracelet;
            this.bracelet.ForeCollected = false;
            this.bracelet.ForeImage = null;
            this.bracelet.Location = new System.Drawing.Point(160, 40);
            this.bracelet.Margin = new System.Windows.Forms.Padding(0);
            this.bracelet.Name = "bracelet";
            this.bracelet.RedrawOnStateChange = true;
            this.bracelet.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
            this.bracelet.Size = new System.Drawing.Size(40, 40);
            this.bracelet.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_bracelet_solid;
            this.bracelet.TabIndex = 73;
            this.bracelet.TabStop = false;
            // 
            // spaulder
            // 
            this.spaulder.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
            this.spaulder.Collected = false;
            this.spaulder.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_spaulder;
            this.spaulder.ForeCollected = false;
            this.spaulder.ForeImage = null;
            this.spaulder.Location = new System.Drawing.Point(200, 40);
            this.spaulder.Margin = new System.Windows.Forms.Padding(0);
            this.spaulder.Name = "spaulder";
            this.spaulder.RedrawOnStateChange = true;
            this.spaulder.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
            this.spaulder.Size = new System.Drawing.Size(40, 40);
            this.spaulder.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_spaulder_solid;
            this.spaulder.TabIndex = 100;
            this.spaulder.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.whip);
            this.flowLayoutPanel4.Controls.Add(this.knife);
            this.flowLayoutPanel4.Controls.Add(this.axe);
            this.flowLayoutPanel4.Controls.Add(this.katana);
            this.flowLayoutPanel4.Controls.Add(this.shield);
            this.flowLayoutPanel4.Controls.Add(this.gauntlet);
            this.flowLayoutPanel4.Controls.Add(this.pistolPanel);
            this.flowLayoutPanel4.Controls.Add(this.shurikenPanel);
            this.flowLayoutPanel4.Controls.Add(this.rollingShurikenPanel);
            this.flowLayoutPanel4.Controls.Add(this.caltropsPanel);
            this.flowLayoutPanel4.Controls.Add(this.flareGunPanel);
            this.flowLayoutPanel4.Controls.Add(this.chakramPanel);
            this.flowLayoutPanel4.Controls.Add(this.earthSpearPanel);
            this.flowLayoutPanel4.Controls.Add(this.bombPanel);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel4, true);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(10, 442);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(320, 112);
            this.flowLayoutPanel4.TabIndex = 115;
            this.flowLayoutPanel4.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // whip
            // 
            this.whip.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_whip;
            this.whip.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_flailwhip,
        global::LMRItemTracker.Properties.Resources.Icon_chainwhip,
        global::LMRItemTracker.Properties.Resources.Icon_whip};
            this.whip.Location = new System.Drawing.Point(0, 0);
            this.whip.Margin = new System.Windows.Forms.Padding(0);
            this.whip.Name = "whip";
            this.whip.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_whip_blank;
            this.whip.Size = new System.Drawing.Size(40, 40);
            this.whip.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_whip_solid;
            this.whip.TabIndex = 84;
            this.whip.TabStop = false;
            // 
            // knife
            // 
            this.knife.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
            this.knife.Collected = false;
            this.knife.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_knife;
            this.knife.ForeCollected = false;
            this.knife.ForeImage = null;
            this.knife.Location = new System.Drawing.Point(40, 0);
            this.knife.Margin = new System.Windows.Forms.Padding(0);
            this.knife.Name = "knife";
            this.knife.RedrawOnStateChange = true;
            this.knife.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
            this.knife.Size = new System.Drawing.Size(40, 40);
            this.knife.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_knife_solid;
            this.knife.TabIndex = 90;
            this.knife.TabStop = false;
            // 
            // axe
            // 
            this.axe.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
            this.axe.Collected = false;
            this.axe.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_axe;
            this.axe.ForeCollected = false;
            this.axe.ForeImage = null;
            this.axe.Location = new System.Drawing.Point(80, 0);
            this.axe.Margin = new System.Windows.Forms.Padding(0);
            this.axe.Name = "axe";
            this.axe.RedrawOnStateChange = true;
            this.axe.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
            this.axe.Size = new System.Drawing.Size(40, 40);
            this.axe.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_axe_solid;
            this.axe.TabIndex = 81;
            this.axe.TabStop = false;
            // 
            // katana
            // 
            this.katana.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
            this.katana.Collected = false;
            this.katana.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_katana;
            this.katana.ForeCollected = false;
            this.katana.ForeImage = null;
            this.katana.Location = new System.Drawing.Point(120, 0);
            this.katana.Margin = new System.Windows.Forms.Padding(0);
            this.katana.Name = "katana";
            this.katana.RedrawOnStateChange = true;
            this.katana.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
            this.katana.Size = new System.Drawing.Size(40, 40);
            this.katana.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_katana_solid;
            this.katana.TabIndex = 89;
            this.katana.TabStop = false;
            // 
            // shield
            // 
            this.shield.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            this.shield.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_angelshield,
        global::LMRItemTracker.Properties.Resources.Icon_silvershield,
        global::LMRItemTracker.Properties.Resources.Icon_silvershield2,
        global::LMRItemTracker.Properties.Resources.Icon_buckler};
            this.shield.Location = new System.Drawing.Point(160, 0);
            this.shield.Margin = new System.Windows.Forms.Padding(0);
            this.shield.Name = "shield";
            this.shield.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            this.shield.Size = new System.Drawing.Size(40, 40);
            this.shield.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_buckler_solid;
            this.shield.TabIndex = 118;
            this.shield.TabStop = false;
            // 
            // gauntlet
            // 
            this.gauntlet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
            this.gauntlet.Collected = false;
            this.gauntlet.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_gauntlet;
            this.gauntlet.ForeCollected = false;
            this.gauntlet.ForeImage = null;
            this.gauntlet.Location = new System.Drawing.Point(200, 0);
            this.gauntlet.Margin = new System.Windows.Forms.Padding(0);
            this.gauntlet.Name = "gauntlet";
            this.gauntlet.RedrawOnStateChange = true;
            this.gauntlet.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
            this.gauntlet.Size = new System.Drawing.Size(40, 40);
            this.gauntlet.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_solid;
            this.gauntlet.TabIndex = 74;
            this.gauntlet.TabStop = false;
            // 
            // pistolPanel
            // 
            this.pistolPanel.Controls.Add(this.pistolAmmoCount);
            this.pistolPanel.Controls.Add(this.pistol);
            this.pistolPanel.Item = this.pistol;
            this.pistolPanel.Label = this.pistolAmmoCount;
            this.pistolPanel.Location = new System.Drawing.Point(240, 0);
            this.pistolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pistolPanel.Name = "pistolPanel";
            this.pistolPanel.Size = new System.Drawing.Size(40, 56);
            this.pistolPanel.TabIndex = 109;
            // 
            // pistolAmmoCount
            // 
            this.pistolAmmoCount.BulletCount = 0;
            this.pistolAmmoCount.ClipCount = 0;
            this.pistolAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pistolAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.pistolAmmoCount.Name = "pistolAmmoCount";
            this.pistolAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pistolAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.pistolAmmoCount.TabIndex = 68;
            this.pistolAmmoCount.Text = "0:0";
            this.pistolAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pistolAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // pistol
            // 
            this.pistol.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_pistol_blank;
            this.pistol.Collected = false;
            this.pistol.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_pistol;
            this.pistol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pistol.ForeCollected = false;
            this.pistol.ForeImage = null;
            this.pistol.Location = new System.Drawing.Point(0, 0);
            this.pistol.Margin = new System.Windows.Forms.Padding(0);
            this.pistol.Name = "pistol";
            this.pistol.RedrawOnStateChange = false;
            this.pistol.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_pistol_blank;
            this.pistol.Size = new System.Drawing.Size(40, 40);
            this.pistol.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_pistol_solid;
            this.pistol.TabIndex = 93;
            this.pistol.TabStop = false;
            // 
            // shurikenPanel
            // 
            this.shurikenPanel.Controls.Add(this.shurikenAmmoCount);
            this.shurikenPanel.Controls.Add(this.shuriken);
            this.shurikenPanel.Item = this.shuriken;
            this.shurikenPanel.Label = this.shurikenAmmoCount;
            this.shurikenPanel.Location = new System.Drawing.Point(280, 0);
            this.shurikenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.shurikenPanel.Name = "shurikenPanel";
            this.shurikenPanel.Size = new System.Drawing.Size(40, 56);
            this.shurikenPanel.TabIndex = 110;
            this.shurikenPanel.TreatAsAmmo = true;
            // 
            // shurikenAmmoCount
            // 
            this.shurikenAmmoCount.Count = 0;
            this.shurikenAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.shurikenAmmoCount.FormatString = "{0}";
            this.shurikenAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.shurikenAmmoCount.Max = 150;
            this.shurikenAmmoCount.Name = "shurikenAmmoCount";
            this.shurikenAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shurikenAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.shurikenAmmoCount.TabIndex = 94;
            this.shurikenAmmoCount.Text = "0";
            this.shurikenAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shurikenAmmoCount.TreatAsAmmo = false;
            this.shurikenAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // shuriken
            // 
            this.shuriken.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_shuriken_blank;
            this.shuriken.Collected = false;
            this.shuriken.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_shuriken;
            this.shuriken.Dock = System.Windows.Forms.DockStyle.Top;
            this.shuriken.ForeCollected = false;
            this.shuriken.ForeImage = null;
            this.shuriken.Location = new System.Drawing.Point(0, 0);
            this.shuriken.Margin = new System.Windows.Forms.Padding(0);
            this.shuriken.Name = "shuriken";
            this.shuriken.RedrawOnStateChange = false;
            this.shuriken.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_shuriken_blank;
            this.shuriken.Size = new System.Drawing.Size(40, 40);
            this.shuriken.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_shuriken_solid;
            this.shuriken.TabIndex = 97;
            this.shuriken.TabStop = false;
            // 
            // rollingShurikenPanel
            // 
            this.rollingShurikenPanel.Controls.Add(this.rollingShurikenAmmoCount);
            this.rollingShurikenPanel.Controls.Add(this.rollingShuriken);
            this.rollingShurikenPanel.Item = this.rollingShuriken;
            this.rollingShurikenPanel.Label = this.rollingShurikenAmmoCount;
            this.rollingShurikenPanel.Location = new System.Drawing.Point(0, 56);
            this.rollingShurikenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rollingShurikenPanel.Name = "rollingShurikenPanel";
            this.rollingShurikenPanel.Size = new System.Drawing.Size(40, 56);
            this.rollingShurikenPanel.TabIndex = 111;
            this.rollingShurikenPanel.TreatAsAmmo = true;
            // 
            // rollingShurikenAmmoCount
            // 
            this.rollingShurikenAmmoCount.Count = 0;
            this.rollingShurikenAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rollingShurikenAmmoCount.FormatString = "{0}";
            this.rollingShurikenAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.rollingShurikenAmmoCount.Max = 100;
            this.rollingShurikenAmmoCount.Name = "rollingShurikenAmmoCount";
            this.rollingShurikenAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rollingShurikenAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.rollingShurikenAmmoCount.TabIndex = 98;
            this.rollingShurikenAmmoCount.Text = "0";
            this.rollingShurikenAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rollingShurikenAmmoCount.TreatAsAmmo = false;
            this.rollingShurikenAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // rollingShuriken
            // 
            this.rollingShuriken.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_blank;
            this.rollingShuriken.Collected = false;
            this.rollingShuriken.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken;
            this.rollingShuriken.Dock = System.Windows.Forms.DockStyle.Top;
            this.rollingShuriken.ForeCollected = false;
            this.rollingShuriken.ForeImage = null;
            this.rollingShuriken.Location = new System.Drawing.Point(0, 0);
            this.rollingShuriken.Margin = new System.Windows.Forms.Padding(0);
            this.rollingShuriken.Name = "rollingShuriken";
            this.rollingShuriken.RedrawOnStateChange = false;
            this.rollingShuriken.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_blank;
            this.rollingShuriken.Size = new System.Drawing.Size(40, 40);
            this.rollingShuriken.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_solid;
            this.rollingShuriken.TabIndex = 98;
            this.rollingShuriken.TabStop = false;
            // 
            // caltropsPanel
            // 
            this.caltropsPanel.Controls.Add(this.caltropsAmmoCount);
            this.caltropsPanel.Controls.Add(this.caltrops);
            this.caltropsPanel.Item = this.caltrops;
            this.caltropsPanel.Label = this.caltropsAmmoCount;
            this.caltropsPanel.Location = new System.Drawing.Point(40, 56);
            this.caltropsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.caltropsPanel.Name = "caltropsPanel";
            this.caltropsPanel.Size = new System.Drawing.Size(40, 56);
            this.caltropsPanel.TabIndex = 112;
            this.caltropsPanel.TreatAsAmmo = true;
            // 
            // caltropsAmmoCount
            // 
            this.caltropsAmmoCount.Count = 0;
            this.caltropsAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.caltropsAmmoCount.FormatString = "{0}";
            this.caltropsAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.caltropsAmmoCount.Max = 80;
            this.caltropsAmmoCount.Name = "caltropsAmmoCount";
            this.caltropsAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.caltropsAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.caltropsAmmoCount.TabIndex = 99;
            this.caltropsAmmoCount.Text = "0";
            this.caltropsAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.caltropsAmmoCount.TreatAsAmmo = true;
            this.caltropsAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // caltrops
            // 
            this.caltrops.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_caltrops_blank;
            this.caltrops.Collected = false;
            this.caltrops.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_caltrops;
            this.caltrops.Dock = System.Windows.Forms.DockStyle.Top;
            this.caltrops.ForeCollected = false;
            this.caltrops.ForeImage = null;
            this.caltrops.Location = new System.Drawing.Point(0, 0);
            this.caltrops.Margin = new System.Windows.Forms.Padding(0);
            this.caltrops.Name = "caltrops";
            this.caltrops.RedrawOnStateChange = false;
            this.caltrops.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_caltrops_blank;
            this.caltrops.Size = new System.Drawing.Size(40, 40);
            this.caltrops.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_caltrops_solid;
            this.caltrops.TabIndex = 99;
            this.caltrops.TabStop = false;
            // 
            // flareGunPanel
            // 
            this.flareGunPanel.Controls.Add(this.flareGunAmmoCount);
            this.flareGunPanel.Controls.Add(this.flareGun);
            this.flareGunPanel.Item = this.flareGun;
            this.flareGunPanel.Label = this.flareGunAmmoCount;
            this.flareGunPanel.Location = new System.Drawing.Point(80, 56);
            this.flareGunPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flareGunPanel.Name = "flareGunPanel";
            this.flareGunPanel.Size = new System.Drawing.Size(40, 56);
            this.flareGunPanel.TabIndex = 113;
            this.flareGunPanel.TreatAsAmmo = true;
            // 
            // flareGunAmmoCount
            // 
            this.flareGunAmmoCount.Count = 0;
            this.flareGunAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.flareGunAmmoCount.FormatString = "{0}";
            this.flareGunAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.flareGunAmmoCount.Max = 80;
            this.flareGunAmmoCount.Name = "flareGunAmmoCount";
            this.flareGunAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flareGunAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.flareGunAmmoCount.TabIndex = 112;
            this.flareGunAmmoCount.Text = "0";
            this.flareGunAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.flareGunAmmoCount.TreatAsAmmo = false;
            this.flareGunAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // flareGun
            // 
            this.flareGun.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_flaregun_blank;
            this.flareGun.Collected = false;
            this.flareGun.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_flaregun;
            this.flareGun.Dock = System.Windows.Forms.DockStyle.Top;
            this.flareGun.ForeCollected = false;
            this.flareGun.ForeImage = null;
            this.flareGun.Location = new System.Drawing.Point(0, 0);
            this.flareGun.Margin = new System.Windows.Forms.Padding(0);
            this.flareGun.Name = "flareGun";
            this.flareGun.RedrawOnStateChange = false;
            this.flareGun.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_flaregun_blank;
            this.flareGun.Size = new System.Drawing.Size(40, 40);
            this.flareGun.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_flaregun_solid;
            this.flareGun.TabIndex = 86;
            this.flareGun.TabStop = false;
            // 
            // chakramPanel
            // 
            this.chakramPanel.Controls.Add(this.chakramAmmoCount);
            this.chakramPanel.Controls.Add(this.chakram);
            this.chakramPanel.Item = this.chakram;
            this.chakramPanel.Label = this.chakramAmmoCount;
            this.chakramPanel.Location = new System.Drawing.Point(120, 56);
            this.chakramPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chakramPanel.Name = "chakramPanel";
            this.chakramPanel.Size = new System.Drawing.Size(40, 56);
            this.chakramPanel.TabIndex = 114;
            this.chakramPanel.TreatAsAmmo = true;
            // 
            // chakramAmmoCount
            // 
            this.chakramAmmoCount.Count = 0;
            this.chakramAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chakramAmmoCount.FormatString = "{0}";
            this.chakramAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.chakramAmmoCount.Max = 10;
            this.chakramAmmoCount.Name = "chakramAmmoCount";
            this.chakramAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chakramAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.chakramAmmoCount.TabIndex = 112;
            this.chakramAmmoCount.Text = "0";
            this.chakramAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chakramAmmoCount.TreatAsAmmo = false;
            this.chakramAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // chakram
            // 
            this.chakram.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_chakram_blank;
            this.chakram.Collected = false;
            this.chakram.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_chakram;
            this.chakram.Dock = System.Windows.Forms.DockStyle.Top;
            this.chakram.ForeCollected = false;
            this.chakram.ForeImage = null;
            this.chakram.Location = new System.Drawing.Point(0, 0);
            this.chakram.Margin = new System.Windows.Forms.Padding(0);
            this.chakram.Name = "chakram";
            this.chakram.RedrawOnStateChange = false;
            this.chakram.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_chakram_blank;
            this.chakram.Size = new System.Drawing.Size(40, 40);
            this.chakram.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_chakram_solid;
            this.chakram.TabIndex = 83;
            this.chakram.TabStop = false;
            // 
            // earthSpearPanel
            // 
            this.earthSpearPanel.Controls.Add(this.earthSpearAmmoCount);
            this.earthSpearPanel.Controls.Add(this.earthSpear);
            this.earthSpearPanel.Item = this.earthSpear;
            this.earthSpearPanel.Label = this.earthSpearAmmoCount;
            this.earthSpearPanel.Location = new System.Drawing.Point(160, 56);
            this.earthSpearPanel.Margin = new System.Windows.Forms.Padding(0);
            this.earthSpearPanel.Name = "earthSpearPanel";
            this.earthSpearPanel.Size = new System.Drawing.Size(40, 56);
            this.earthSpearPanel.TabIndex = 115;
            this.earthSpearPanel.TreatAsAmmo = true;
            // 
            // earthSpearAmmoCount
            // 
            this.earthSpearAmmoCount.Count = 0;
            this.earthSpearAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.earthSpearAmmoCount.FormatString = "{0}";
            this.earthSpearAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.earthSpearAmmoCount.Max = 80;
            this.earthSpearAmmoCount.Name = "earthSpearAmmoCount";
            this.earthSpearAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.earthSpearAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.earthSpearAmmoCount.TabIndex = 112;
            this.earthSpearAmmoCount.Text = "0";
            this.earthSpearAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.earthSpearAmmoCount.TreatAsAmmo = false;
            this.earthSpearAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // earthSpear
            // 
            this.earthSpear.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_earthspear_blank;
            this.earthSpear.Collected = false;
            this.earthSpear.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_earthspear;
            this.earthSpear.Dock = System.Windows.Forms.DockStyle.Top;
            this.earthSpear.ForeCollected = false;
            this.earthSpear.ForeImage = null;
            this.earthSpear.Location = new System.Drawing.Point(0, 0);
            this.earthSpear.Margin = new System.Windows.Forms.Padding(0);
            this.earthSpear.Name = "earthSpear";
            this.earthSpear.RedrawOnStateChange = false;
            this.earthSpear.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_earthspear_blank;
            this.earthSpear.Size = new System.Drawing.Size(40, 40);
            this.earthSpear.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_earthspear_solid;
            this.earthSpear.TabIndex = 85;
            this.earthSpear.TabStop = false;
            // 
            // bombPanel
            // 
            this.bombPanel.Controls.Add(this.bombAmmoCount);
            this.bombPanel.Controls.Add(this.bomb);
            this.bombPanel.Item = this.bomb;
            this.bombPanel.Label = this.bombAmmoCount;
            this.bombPanel.Location = new System.Drawing.Point(200, 56);
            this.bombPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bombPanel.Name = "bombPanel";
            this.bombPanel.Size = new System.Drawing.Size(40, 56);
            this.bombPanel.TabIndex = 116;
            this.bombPanel.TreatAsAmmo = true;
            // 
            // bombAmmoCount
            // 
            this.bombAmmoCount.Count = 0;
            this.bombAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bombAmmoCount.FormatString = "{0}";
            this.bombAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.bombAmmoCount.Max = 30;
            this.bombAmmoCount.Name = "bombAmmoCount";
            this.bombAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.bombAmmoCount.TabIndex = 112;
            this.bombAmmoCount.Text = "0";
            this.bombAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bombAmmoCount.TreatAsAmmo = false;
            this.bombAmmoCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // bomb
            // 
            this.bomb.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            this.bomb.Collected = false;
            this.bomb.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bomb;
            this.bomb.Dock = System.Windows.Forms.DockStyle.Top;
            this.bomb.ForeCollected = false;
            this.bomb.ForeImage = null;
            this.bomb.Location = new System.Drawing.Point(0, 0);
            this.bomb.Margin = new System.Windows.Forms.Padding(0);
            this.bomb.Name = "bomb";
            this.bomb.RedrawOnStateChange = false;
            this.bomb.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            this.bomb.Size = new System.Drawing.Size(40, 40);
            this.bomb.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_bomb_solid;
            this.bomb.TabIndex = 54;
            this.bomb.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.ocarina);
            this.flowLayoutPanel5.Controls.Add(this.mantra);
            this.flowLayoutPanel5.Controls.Add(this.vessel);
            this.flowLayoutPanel5.Controls.Add(this.keySword);
            this.flowLayoutPanel5.Controls.Add(this.lampOfTime);
            this.flowLayoutPanel5.Controls.Add(this.mapsPanel);
            this.flowLayoutPanel5.Controls.Add(this.ankhJewelPanel);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel5, true);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(10, 562);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(280, 56);
            this.flowLayoutPanel5.TabIndex = 115;
            this.flowLayoutPanel5.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // ocarina
            // 
            this.ocarina.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            this.ocarina.Collected = false;
            this.ocarina.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina;
            this.ocarina.ForeCollected = false;
            this.ocarina.ForeImage = null;
            this.ocarina.Location = new System.Drawing.Point(0, 0);
            this.ocarina.Margin = new System.Windows.Forms.Padding(0);
            this.ocarina.Name = "ocarina";
            this.ocarina.RedrawOnStateChange = true;
            this.ocarina.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            this.ocarina.Size = new System.Drawing.Size(40, 40);
            this.ocarina.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_solid;
            this.ocarina.TabIndex = 30;
            this.ocarina.TabStop = false;
            // 
            // mantra
            // 
            this.mantra.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantra.Collected = false;
            this.mantra.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_mantra;
            this.mantra.ForeCollected = false;
            this.mantra.ForeImage = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_small;
            this.mantra.Location = new System.Drawing.Point(40, 0);
            this.mantra.Margin = new System.Windows.Forms.Padding(0);
            this.mantra.Name = "mantra";
            this.mantra.RedrawOnStateChange = true;
            this.mantra.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantra.Size = new System.Drawing.Size(40, 40);
            this.mantra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mantra.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_software_solid;
            this.mantra.TabIndex = 31;
            this.mantra.TabStop = false;
            // 
            // vessel
            // 
            this.vessel.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            this.vessel.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind_green,
        global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind_red,
        global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind,
        global::LMRItemTracker.Properties.Resources.Icon_vessel};
            this.vessel.Location = new System.Drawing.Point(80, 0);
            this.vessel.Margin = new System.Windows.Forms.Padding(0);
            this.vessel.Name = "vessel";
            this.vessel.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            this.vessel.Size = new System.Drawing.Size(40, 40);
            this.vessel.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_vessel_solid;
            this.vessel.TabIndex = 119;
            this.vessel.TabStop = false;
            // 
            // keySword
            // 
            this.keySword.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
            this.keySword.Location = new System.Drawing.Point(120, 0);
            this.keySword.Margin = new System.Windows.Forms.Padding(0);
            this.keySword.Name = "keySword";
            this.keySword.Size = new System.Drawing.Size(40, 40);
            this.keySword.TabIndex = 33;
            this.keySword.TabStop = false;
            // 
            // lampOfTime
            // 
            this.lampOfTime.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            this.lampOfTime.CollectedImages = new System.Drawing.Bitmap[] {
        global::LMRItemTracker.Properties.Resources.Icon_lampoftime,
        global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit};
            this.lampOfTime.Location = new System.Drawing.Point(160, 0);
            this.lampOfTime.Margin = new System.Windows.Forms.Padding(0);
            this.lampOfTime.Name = "lampOfTime";
            this.lampOfTime.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            this.lampOfTime.Size = new System.Drawing.Size(40, 40);
            this.lampOfTime.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_solid;
            this.lampOfTime.TabIndex = 120;
            this.lampOfTime.TabStop = false;
            // 
            // mapsPanel
            // 
            this.mapsPanel.Controls.Add(this.mapCount);
            this.mapsPanel.Controls.Add(this.maps);
            this.mapsPanel.Item = this.maps;
            this.mapsPanel.Label = this.mapCount;
            this.mapsPanel.Location = new System.Drawing.Point(200, 0);
            this.mapsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mapsPanel.Name = "mapsPanel";
            this.mapsPanel.Size = new System.Drawing.Size(40, 56);
            this.mapsPanel.TabIndex = 113;
            this.mapsPanel.TreatAsAmmo = false;
            // 
            // mapCount
            // 
            this.mapCount.Count = 0;
            this.mapCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mapCount.FormatString = "{0}/{1}";
            this.mapCount.Location = new System.Drawing.Point(-6, 40);
            this.mapCount.Max = 17;
            this.mapCount.Name = "mapCount";
            this.mapCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mapCount.Size = new System.Drawing.Size(52, 16);
            this.mapCount.TabIndex = 23;
            this.mapCount.Text = "0/17";
            this.mapCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mapCount.TreatAsAmmo = false;
            this.mapCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // maps
            // 
            this.maps.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Collected = true;
            this.maps.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Dock = System.Windows.Forms.DockStyle.Top;
            this.maps.ForeCollected = false;
            this.maps.ForeImage = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_small;
            this.maps.Location = new System.Drawing.Point(0, 0);
            this.maps.Margin = new System.Windows.Forms.Padding(0);
            this.maps.Name = "maps";
            this.maps.RedrawOnStateChange = false;
            this.maps.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Size = new System.Drawing.Size(40, 40);
            this.maps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maps.SolidImage = null;
            this.maps.TabIndex = 24;
            this.maps.TabStop = false;
            // 
            // ankhJewelPanel
            // 
            this.ankhJewelPanel.Controls.Add(this.ankhJewels);
            this.ankhJewelPanel.Controls.Add(this.ankhJewelCount);
            this.ankhJewelPanel.Item = this.ankhJewels;
            this.ankhJewelPanel.Label = this.ankhJewelCount;
            this.ankhJewelPanel.Location = new System.Drawing.Point(240, 0);
            this.ankhJewelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ankhJewelPanel.Name = "ankhJewelPanel";
            this.ankhJewelPanel.Size = new System.Drawing.Size(40, 56);
            this.ankhJewelPanel.TabIndex = 114;
            this.ankhJewelPanel.TreatAsAmmo = false;
            // 
            // ankhJewels
            // 
            this.ankhJewels.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel_blank;
            this.ankhJewels.Collected = false;
            this.ankhJewels.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            this.ankhJewels.Dock = System.Windows.Forms.DockStyle.Top;
            this.ankhJewels.ForeCollected = false;
            this.ankhJewels.ForeImage = null;
            this.ankhJewels.Location = new System.Drawing.Point(0, 0);
            this.ankhJewels.Margin = new System.Windows.Forms.Padding(0);
            this.ankhJewels.Name = "ankhJewels";
            this.ankhJewels.RedrawOnStateChange = false;
            this.ankhJewels.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel_blank;
            this.ankhJewels.Size = new System.Drawing.Size(40, 40);
            this.ankhJewels.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel_solid;
            this.ankhJewels.TabIndex = 29;
            this.ankhJewels.TabStop = false;
            // 
            // ankhJewelCount
            // 
            this.ankhJewelCount.Count = 0;
            this.ankhJewelCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ankhJewelCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ankhJewelCount.FormatString = "{0}";
            this.ankhJewelCount.Location = new System.Drawing.Point(0, 40);
            this.ankhJewelCount.Max = 9;
            this.ankhJewelCount.Name = "ankhJewelCount";
            this.ankhJewelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ankhJewelCount.Size = new System.Drawing.Size(40, 16);
            this.ankhJewelCount.TabIndex = 28;
            this.ankhJewelCount.Text = "0";
            this.ankhJewelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ankhJewelCount.TreatAsAmmo = false;
            this.ankhJewelCount.DoubleClick += new System.EventHandler(this.SelectTextColor);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.shellHorn);
            this.flowLayoutPanel6.Controls.Add(this.waterproofCase);
            this.flowLayoutPanel6.Controls.Add(this.heatproofCase);
            this.flowLayoutPanel6.Controls.Add(this.swimsuit);
            this.flowLayoutPanel6.Controls.Add(this.djedPillar);
            this.flowLayoutPanel6.Controls.Add(this.mantraSingle);
            this.flowLayoutPanel6.Controls.Add(this.xmailer);
            this.flowLayoutPanel6.Controls.Add(this.yagomap);
            this.flowLayoutPanel6.Controls.Add(this.yagostr);
            this.flowLayoutPanel6.Controls.Add(this.bunemon);
            this.flowLayoutPanel6.Controls.Add(this.bunplus);
            this.flowLayoutPanel6.Controls.Add(this.guild);
            this.flowLayoutPanel6.Controls.Add(this.beolamu);
            this.flowLayoutPanel6.Controls.Add(this.emusic);
            this.flowLayoutPanel6.Controls.Add(this.randc);
            this.flowLayoutPanel6.Controls.Add(this.capstar);
            this.flowLayoutPanel6.Controls.Add(this.deathv);
            this.flowLayoutPanel6.Controls.Add(this.move);
            this.flowLayoutPanel6.Controls.Add(this.mekuri);
            this.flowLayoutPanel6.Controls.Add(this.bounce);
            this.flowLayoutPanel6.Controls.Add(this.miracle);
            this.flowLayoutPanel6.Controls.Add(this.lamulana);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel6, true);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(10, 626);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(320, 120);
            this.flowLayoutPanel6.TabIndex = 120;
            // 
            // shellHorn
            // 
            this.shellHorn.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_shellhorn_blank;
            this.shellHorn.Collected = false;
            this.shellHorn.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_shellhorn;
            this.shellHorn.ForeCollected = false;
            this.shellHorn.ForeImage = null;
            this.shellHorn.Location = new System.Drawing.Point(0, 0);
            this.shellHorn.Margin = new System.Windows.Forms.Padding(0);
            this.shellHorn.Name = "shellHorn";
            this.shellHorn.RedrawOnStateChange = true;
            this.shellHorn.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_shellhorn_blank;
            this.shellHorn.Size = new System.Drawing.Size(40, 40);
            this.shellHorn.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_shellhorn_solid;
            this.shellHorn.TabIndex = 112;
            this.shellHorn.TabStop = false;
            // 
            // waterproofCase
            // 
            this.waterproofCase.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_waterproofcase_blank;
            this.waterproofCase.Collected = false;
            this.waterproofCase.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_waterproofcase;
            this.waterproofCase.ForeCollected = false;
            this.waterproofCase.ForeImage = null;
            this.waterproofCase.Location = new System.Drawing.Point(40, 0);
            this.waterproofCase.Margin = new System.Windows.Forms.Padding(0);
            this.waterproofCase.Name = "waterproofCase";
            this.waterproofCase.RedrawOnStateChange = true;
            this.waterproofCase.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_waterproofcase_blank;
            this.waterproofCase.Size = new System.Drawing.Size(40, 40);
            this.waterproofCase.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_waterproofcase_solid;
            this.waterproofCase.TabIndex = 117;
            this.waterproofCase.TabStop = false;
            // 
            // heatproofCase
            // 
            this.heatproofCase.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_heatproofcase_blank;
            this.heatproofCase.Collected = false;
            this.heatproofCase.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_heatproofcase;
            this.heatproofCase.ForeCollected = false;
            this.heatproofCase.ForeImage = null;
            this.heatproofCase.Location = new System.Drawing.Point(80, 0);
            this.heatproofCase.Margin = new System.Windows.Forms.Padding(0);
            this.heatproofCase.Name = "heatproofCase";
            this.heatproofCase.RedrawOnStateChange = true;
            this.heatproofCase.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_heatproofcase_blank;
            this.heatproofCase.Size = new System.Drawing.Size(40, 40);
            this.heatproofCase.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_heatproofcase_solid;
            this.heatproofCase.TabIndex = 118;
            this.heatproofCase.TabStop = false;
            // 
            // swimsuit
            // 
            this.swimsuit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_swimsuit_blank;
            this.swimsuit.Collected = false;
            this.swimsuit.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_swimsuit;
            this.swimsuit.ForeCollected = false;
            this.swimsuit.ForeImage = null;
            this.swimsuit.Location = new System.Drawing.Point(120, 0);
            this.swimsuit.Margin = new System.Windows.Forms.Padding(0);
            this.swimsuit.Name = "swimsuit";
            this.swimsuit.RedrawOnStateChange = true;
            this.swimsuit.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_swimsuit_blank;
            this.swimsuit.Size = new System.Drawing.Size(40, 40);
            this.swimsuit.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_swimsuit_solid;
            this.swimsuit.TabIndex = 121;
            this.swimsuit.TabStop = false;
            // 
            // djedPillar
            // 
            this.djedPillar.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_blank;
            this.djedPillar.Collected = false;
            this.djedPillar.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
            this.djedPillar.ForeCollected = false;
            this.djedPillar.ForeImage = null;
            this.djedPillar.Location = new System.Drawing.Point(160, 0);
            this.djedPillar.Margin = new System.Windows.Forms.Padding(0);
            this.djedPillar.Name = "djedPillar";
            this.djedPillar.RedrawOnStateChange = true;
            this.djedPillar.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_blank;
            this.djedPillar.Size = new System.Drawing.Size(40, 40);
            this.djedPillar.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_solid;
            this.djedPillar.TabIndex = 119;
            this.djedPillar.TabStop = false;
            // 
            // mantraSingle
            // 
            this.mantraSingle.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantraSingle.Collected = false;
            this.mantraSingle.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_mantra;
            this.mantraSingle.ForeCollected = false;
            this.mantraSingle.ForeImage = null;
            this.mantraSingle.Location = new System.Drawing.Point(200, 0);
            this.mantraSingle.Margin = new System.Windows.Forms.Padding(0);
            this.mantraSingle.Name = "mantraSingle";
            this.mantraSingle.RedrawOnStateChange = true;
            this.mantraSingle.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantraSingle.Size = new System.Drawing.Size(40, 40);
            this.mantraSingle.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_software_solid;
            this.mantraSingle.TabIndex = 120;
            this.mantraSingle.TabStop = false;
            // 
            // xmailer
            // 
            this.xmailer.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_xmailer_blank;
            this.xmailer.Collected = false;
            this.xmailer.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_xmailer;
            this.xmailer.ForeCollected = false;
            this.xmailer.ForeImage = null;
            this.xmailer.Location = new System.Drawing.Point(240, 0);
            this.xmailer.Margin = new System.Windows.Forms.Padding(0);
            this.xmailer.Name = "xmailer";
            this.xmailer.RedrawOnStateChange = true;
            this.xmailer.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_xmailer_blank;
            this.xmailer.Size = new System.Drawing.Size(40, 40);
            this.xmailer.SolidImage = ((System.Drawing.Image)(resources.GetObject("xmailer.SolidImage")));
            this.xmailer.TabIndex = 122;
            this.xmailer.TabStop = false;
            // 
            // yagomap
            // 
            this.yagomap.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_yagomap_blank;
            this.yagomap.Collected = false;
            this.yagomap.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_yagomap;
            this.yagomap.ForeCollected = false;
            this.yagomap.ForeImage = null;
            this.yagomap.Location = new System.Drawing.Point(280, 0);
            this.yagomap.Margin = new System.Windows.Forms.Padding(0);
            this.yagomap.Name = "yagomap";
            this.yagomap.RedrawOnStateChange = true;
            this.yagomap.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_yagomap_blank;
            this.yagomap.Size = new System.Drawing.Size(40, 40);
            this.yagomap.SolidImage = ((System.Drawing.Image)(resources.GetObject("yagomap.SolidImage")));
            this.yagomap.TabIndex = 123;
            this.yagomap.TabStop = false;
            // 
            // yagostr
            // 
            this.yagostr.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_yagostr_blank;
            this.yagostr.Collected = false;
            this.yagostr.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_yagostr;
            this.yagostr.ForeCollected = false;
            this.yagostr.ForeImage = null;
            this.yagostr.Location = new System.Drawing.Point(0, 40);
            this.yagostr.Margin = new System.Windows.Forms.Padding(0);
            this.yagostr.Name = "yagostr";
            this.yagostr.RedrawOnStateChange = true;
            this.yagostr.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_yagostr_blank;
            this.yagostr.Size = new System.Drawing.Size(40, 40);
            this.yagostr.SolidImage = ((System.Drawing.Image)(resources.GetObject("yagostr.SolidImage")));
            this.yagostr.TabIndex = 124;
            this.yagostr.TabStop = false;
            // 
            // bunemon
            // 
            this.bunemon.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bunemon_blank;
            this.bunemon.Collected = false;
            this.bunemon.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bunemon;
            this.bunemon.ForeCollected = false;
            this.bunemon.ForeImage = null;
            this.bunemon.Location = new System.Drawing.Point(40, 40);
            this.bunemon.Margin = new System.Windows.Forms.Padding(0);
            this.bunemon.Name = "bunemon";
            this.bunemon.RedrawOnStateChange = true;
            this.bunemon.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bunemon_blank;
            this.bunemon.Size = new System.Drawing.Size(40, 40);
            this.bunemon.SolidImage = ((System.Drawing.Image)(resources.GetObject("bunemon.SolidImage")));
            this.bunemon.TabIndex = 125;
            this.bunemon.TabStop = false;
            // 
            // bunplus
            // 
            this.bunplus.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bunplus_blank;
            this.bunplus.Collected = false;
            this.bunplus.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bunplus;
            this.bunplus.ForeCollected = false;
            this.bunplus.ForeImage = null;
            this.bunplus.Location = new System.Drawing.Point(80, 40);
            this.bunplus.Margin = new System.Windows.Forms.Padding(0);
            this.bunplus.Name = "bunplus";
            this.bunplus.RedrawOnStateChange = true;
            this.bunplus.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bunplus_blank;
            this.bunplus.Size = new System.Drawing.Size(40, 40);
            this.bunplus.SolidImage = ((System.Drawing.Image)(resources.GetObject("bunplus.SolidImage")));
            this.bunplus.TabIndex = 126;
            this.bunplus.TabStop = false;
            // 
            // guild
            // 
            this.guild.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_guild_blank;
            this.guild.Collected = false;
            this.guild.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_guild;
            this.guild.ForeCollected = false;
            this.guild.ForeImage = null;
            this.guild.Location = new System.Drawing.Point(120, 40);
            this.guild.Margin = new System.Windows.Forms.Padding(0);
            this.guild.Name = "guild";
            this.guild.RedrawOnStateChange = true;
            this.guild.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_guild_blank;
            this.guild.Size = new System.Drawing.Size(40, 40);
            this.guild.SolidImage = ((System.Drawing.Image)(resources.GetObject("guild.SolidImage")));
            this.guild.TabIndex = 127;
            this.guild.TabStop = false;
            // 
            // beolamu
            // 
            this.beolamu.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_beolamu_blank;
            this.beolamu.Collected = false;
            this.beolamu.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_beolamu;
            this.beolamu.ForeCollected = false;
            this.beolamu.ForeImage = null;
            this.beolamu.Location = new System.Drawing.Point(160, 40);
            this.beolamu.Margin = new System.Windows.Forms.Padding(0);
            this.beolamu.Name = "beolamu";
            this.beolamu.RedrawOnStateChange = true;
            this.beolamu.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_beolamu_blank;
            this.beolamu.Size = new System.Drawing.Size(40, 40);
            this.beolamu.SolidImage = global::LMRItemTracker.Properties.Resources.Icon_beolamu_solid;
            this.beolamu.TabIndex = 129;
            this.beolamu.TabStop = false;
            // 
            // emusic
            // 
            this.emusic.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_emusic_blank;
            this.emusic.Collected = false;
            this.emusic.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_emusic;
            this.emusic.ForeCollected = false;
            this.emusic.ForeImage = null;
            this.emusic.Location = new System.Drawing.Point(200, 40);
            this.emusic.Margin = new System.Windows.Forms.Padding(0);
            this.emusic.Name = "emusic";
            this.emusic.RedrawOnStateChange = true;
            this.emusic.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_emusic_blank;
            this.emusic.Size = new System.Drawing.Size(40, 40);
            this.emusic.SolidImage = ((System.Drawing.Image)(resources.GetObject("emusic.SolidImage")));
            this.emusic.TabIndex = 128;
            this.emusic.TabStop = false;
            // 
            // randc
            // 
            this.randc.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_randc_blank;
            this.randc.Collected = false;
            this.randc.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_randc;
            this.randc.ForeCollected = false;
            this.randc.ForeImage = null;
            this.randc.Location = new System.Drawing.Point(240, 40);
            this.randc.Margin = new System.Windows.Forms.Padding(0);
            this.randc.Name = "randc";
            this.randc.RedrawOnStateChange = true;
            this.randc.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_randc_blank;
            this.randc.Size = new System.Drawing.Size(40, 40);
            this.randc.SolidImage = ((System.Drawing.Image)(resources.GetObject("randc.SolidImage")));
            this.randc.TabIndex = 130;
            this.randc.TabStop = false;
            // 
            // capstar
            // 
            this.capstar.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            this.capstar.Collected = false;
            this.capstar.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_capstar;
            this.capstar.ForeCollected = false;
            this.capstar.ForeImage = null;
            this.capstar.Location = new System.Drawing.Point(280, 40);
            this.capstar.Margin = new System.Windows.Forms.Padding(0);
            this.capstar.Name = "capstar";
            this.capstar.RedrawOnStateChange = true;
            this.capstar.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            this.capstar.Size = new System.Drawing.Size(40, 40);
            this.capstar.SolidImage = ((System.Drawing.Image)(resources.GetObject("capstar.SolidImage")));
            this.capstar.TabIndex = 131;
            this.capstar.TabStop = false;
            // 
            // deathv
            // 
            this.deathv.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_deathv_blank;
            this.deathv.Collected = false;
            this.deathv.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_deathv;
            this.deathv.ForeCollected = false;
            this.deathv.ForeImage = null;
            this.deathv.Location = new System.Drawing.Point(0, 80);
            this.deathv.Margin = new System.Windows.Forms.Padding(0);
            this.deathv.Name = "deathv";
            this.deathv.RedrawOnStateChange = true;
            this.deathv.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_deathv_blank;
            this.deathv.Size = new System.Drawing.Size(40, 40);
            this.deathv.SolidImage = ((System.Drawing.Image)(resources.GetObject("deathv.SolidImage")));
            this.deathv.TabIndex = 132;
            this.deathv.TabStop = false;
            // 
            // move
            // 
            this.move.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_move_blank;
            this.move.Collected = false;
            this.move.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_move;
            this.move.ForeCollected = false;
            this.move.ForeImage = null;
            this.move.Location = new System.Drawing.Point(40, 80);
            this.move.Margin = new System.Windows.Forms.Padding(0);
            this.move.Name = "move";
            this.move.RedrawOnStateChange = true;
            this.move.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_move_blank;
            this.move.Size = new System.Drawing.Size(40, 40);
            this.move.SolidImage = ((System.Drawing.Image)(resources.GetObject("move.SolidImage")));
            this.move.TabIndex = 133;
            this.move.TabStop = false;
            // 
            // mekuri
            // 
            this.mekuri.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mekuri_blank;
            this.mekuri.Collected = false;
            this.mekuri.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_mekuri;
            this.mekuri.ForeCollected = false;
            this.mekuri.ForeImage = null;
            this.mekuri.Location = new System.Drawing.Point(80, 80);
            this.mekuri.Margin = new System.Windows.Forms.Padding(0);
            this.mekuri.Name = "mekuri";
            this.mekuri.RedrawOnStateChange = true;
            this.mekuri.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_mekuri_blank;
            this.mekuri.Size = new System.Drawing.Size(40, 40);
            this.mekuri.SolidImage = ((System.Drawing.Image)(resources.GetObject("mekuri.SolidImage")));
            this.mekuri.TabIndex = 134;
            this.mekuri.TabStop = false;
            // 
            // bounce
            // 
            this.bounce.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_bounce_blank;
            this.bounce.Collected = false;
            this.bounce.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_bounce;
            this.bounce.ForeCollected = false;
            this.bounce.ForeImage = null;
            this.bounce.Location = new System.Drawing.Point(120, 80);
            this.bounce.Margin = new System.Windows.Forms.Padding(0);
            this.bounce.Name = "bounce";
            this.bounce.RedrawOnStateChange = true;
            this.bounce.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_bounce_blank;
            this.bounce.Size = new System.Drawing.Size(40, 40);
            this.bounce.SolidImage = ((System.Drawing.Image)(resources.GetObject("bounce.SolidImage")));
            this.bounce.TabIndex = 135;
            this.bounce.TabStop = false;
            // 
            // miracle
            // 
            this.miracle.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_miracle_blank;
            this.miracle.Collected = false;
            this.miracle.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_miracle;
            this.miracle.ForeCollected = false;
            this.miracle.ForeImage = null;
            this.miracle.Location = new System.Drawing.Point(160, 80);
            this.miracle.Margin = new System.Windows.Forms.Padding(0);
            this.miracle.Name = "miracle";
            this.miracle.RedrawOnStateChange = true;
            this.miracle.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_miracle_blank;
            this.miracle.Size = new System.Drawing.Size(40, 40);
            this.miracle.SolidImage = ((System.Drawing.Image)(resources.GetObject("miracle.SolidImage")));
            this.miracle.TabIndex = 136;
            this.miracle.TabStop = false;
            // 
            // lamulana
            // 
            this.lamulana.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lamulana_blank;
            this.lamulana.Collected = false;
            this.lamulana.CollectedImage = global::LMRItemTracker.Properties.Resources.Icon_lamulana;
            this.lamulana.ForeCollected = false;
            this.lamulana.ForeImage = null;
            this.lamulana.Location = new System.Drawing.Point(200, 80);
            this.lamulana.Margin = new System.Windows.Forms.Padding(0);
            this.lamulana.Name = "lamulana";
            this.lamulana.RedrawOnStateChange = true;
            this.lamulana.ShadedImage = global::LMRItemTracker.Properties.Resources.Icon_lamulana_blank;
            this.lamulana.Size = new System.Drawing.Size(40, 40);
            this.lamulana.SolidImage = ((System.Drawing.Image)(resources.GetObject("lamulana.SolidImage")));
            this.lamulana.TabIndex = 137;
            this.lamulana.TabStop = false;
            // 
            // bossPanel
            // 
            this.bossPanel.AutoSize = true;
            this.bossPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bossPanel.Controls.Add(this.amphisbaena);
            this.bossPanel.Controls.Add(this.sakit);
            this.bossPanel.Controls.Add(this.ellmac);
            this.bossPanel.Controls.Add(this.bahamut);
            this.bossPanel.Controls.Add(this.viy);
            this.bossPanel.Controls.Add(this.palenque);
            this.bossPanel.Controls.Add(this.baphomet);
            this.bossPanel.Controls.Add(this.tiamat);
            this.mainPanel.SetFlowBreak(this.bossPanel, true);
            this.bossPanel.Location = new System.Drawing.Point(10, 754);
            this.bossPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bossPanel.MaximumSize = new System.Drawing.Size(280, 0);
            this.bossPanel.Name = "bossPanel";
            this.bossPanel.Size = new System.Drawing.Size(280, 34);
            this.bossPanel.TabIndex = 112;
            this.bossPanel.DoubleClick += new System.EventHandler(this.SelectFormColor);
            // 
            // amphisbaena
            // 
            this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
            this.amphisbaena.Collected = false;
            this.amphisbaena.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena;
            this.amphisbaena.ForeCollected = false;
            this.amphisbaena.ForeImage = global::LMRItemTracker.Properties.Resources.Boss_sealed;
            this.amphisbaena.Location = new System.Drawing.Point(0, 0);
            this.amphisbaena.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.amphisbaena.Name = "amphisbaena";
            this.amphisbaena.RedrawOnStateChange = true;
            this.amphisbaena.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
            this.amphisbaena.Size = new System.Drawing.Size(34, 34);
            this.amphisbaena.SolidImage = null;
            this.amphisbaena.TabIndex = 13;
            this.amphisbaena.TabStop = false;
            // 
            // sakit
            // 
            this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
            this.sakit.Collected = false;
            this.sakit.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_sakit;
            this.sakit.ForeCollected = false;
            this.sakit.ForeImage = global::LMRItemTracker.Properties.Resources.Boss_sealed;
            this.sakit.Location = new System.Drawing.Point(35, 0);
            this.sakit.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.sakit.Name = "sakit";
            this.sakit.RedrawOnStateChange = true;
            this.sakit.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
            this.sakit.Size = new System.Drawing.Size(34, 34);
            this.sakit.SolidImage = null;
            this.sakit.TabIndex = 8;
            this.sakit.TabStop = false;
            // 
            // ellmac
            // 
            this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
            this.ellmac.Collected = false;
            this.ellmac.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac;
            this.ellmac.ForeCollected = false;
            this.ellmac.ForeImage = ((System.Drawing.Image)(resources.GetObject("ellmac.ForeImage")));
            this.ellmac.Location = new System.Drawing.Point(70, 0);
            this.ellmac.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.ellmac.Name = "ellmac";
            this.ellmac.RedrawOnStateChange = true;
            this.ellmac.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
            this.ellmac.Size = new System.Drawing.Size(34, 34);
            this.ellmac.SolidImage = null;
            this.ellmac.TabIndex = 17;
            this.ellmac.TabStop = false;
            // 
            // bahamut
            // 
            this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
            this.bahamut.Collected = false;
            this.bahamut.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut;
            this.bahamut.ForeCollected = false;
            this.bahamut.ForeImage = ((System.Drawing.Image)(resources.GetObject("bahamut.ForeImage")));
            this.bahamut.Location = new System.Drawing.Point(105, 0);
            this.bahamut.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.bahamut.Name = "bahamut";
            this.bahamut.RedrawOnStateChange = true;
            this.bahamut.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
            this.bahamut.Size = new System.Drawing.Size(34, 34);
            this.bahamut.SolidImage = null;
            this.bahamut.TabIndex = 18;
            this.bahamut.TabStop = false;
            // 
            // viy
            // 
            this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
            this.viy.Collected = false;
            this.viy.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_viy;
            this.viy.ForeCollected = false;
            this.viy.ForeImage = ((System.Drawing.Image)(resources.GetObject("viy.ForeImage")));
            this.viy.Location = new System.Drawing.Point(140, 0);
            this.viy.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.viy.Name = "viy";
            this.viy.RedrawOnStateChange = true;
            this.viy.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
            this.viy.Size = new System.Drawing.Size(34, 34);
            this.viy.SolidImage = null;
            this.viy.TabIndex = 22;
            this.viy.TabStop = false;
            // 
            // palenque
            // 
            this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
            this.palenque.Collected = false;
            this.palenque.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_palenque;
            this.palenque.ForeCollected = false;
            this.palenque.ForeImage = ((System.Drawing.Image)(resources.GetObject("palenque.ForeImage")));
            this.palenque.Location = new System.Drawing.Point(175, 0);
            this.palenque.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.palenque.Name = "palenque";
            this.palenque.RedrawOnStateChange = true;
            this.palenque.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
            this.palenque.Size = new System.Drawing.Size(34, 34);
            this.palenque.SolidImage = null;
            this.palenque.TabIndex = 21;
            this.palenque.TabStop = false;
            // 
            // baphomet
            // 
            this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
            this.baphomet.Collected = false;
            this.baphomet.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet;
            this.baphomet.ForeCollected = false;
            this.baphomet.ForeImage = ((System.Drawing.Image)(resources.GetObject("baphomet.ForeImage")));
            this.baphomet.Location = new System.Drawing.Point(210, 0);
            this.baphomet.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.baphomet.Name = "baphomet";
            this.baphomet.RedrawOnStateChange = true;
            this.baphomet.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
            this.baphomet.Size = new System.Drawing.Size(34, 34);
            this.baphomet.SolidImage = null;
            this.baphomet.TabIndex = 20;
            this.baphomet.TabStop = false;
            // 
            // tiamat
            // 
            this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
            this.tiamat.Collected = false;
            this.tiamat.CollectedImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat;
            this.tiamat.ForeCollected = false;
            this.tiamat.ForeImage = ((System.Drawing.Image)(resources.GetObject("tiamat.ForeImage")));
            this.tiamat.Location = new System.Drawing.Point(245, 0);
            this.tiamat.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tiamat.Name = "tiamat";
            this.tiamat.RedrawOnStateChange = true;
            this.tiamat.ShadedImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
            this.tiamat.Size = new System.Drawing.Size(34, 34);
            this.tiamat.SolidImage = null;
            this.tiamat.TabIndex = 19;
            this.tiamat.TabStop = false;
            // 
            // itemColorDialog
            // 
            this.itemColorDialog.AnyColor = true;
            this.itemColorDialog.SolidColorOnly = true;
            // 
            // LaMulanaItemTrackerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 783);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.HelpButton = true;
            this.Name = "LaMulanaItemTrackerForm";
            this.Text = "Item Tracker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LaMulanaItemTrackerForm_Load);
            this.DoubleClick += new System.EventHandler(this.SelectFormColor);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).EndInit();
            this.readerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holyGrail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.spaulderPanel.ResumeLayout(false);
            this.spaulderPanel.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.totalSpauldersPanel.ResumeLayout(false);
            this.totalSpauldersPanel.PerformLayout();
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            this.lastItemPanel.ResumeLayout(false);
            this.lastItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastItem3)).EndInit();
            this.deathPanel.ResumeLayout(false);
            this.deathPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMirror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOfEden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twinStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyOfEternity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalesphere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulanaTalisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isisPendant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOfTruth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatamaJewel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torude)).EndInit();
            this.shrinePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skullWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretTreasureOfLife)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOfTheDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairyClothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucifix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaulder)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.whip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauntlet)).EndInit();
            this.pistolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).EndInit();
            this.shurikenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shuriken)).EndInit();
            this.rollingShurikenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rollingShuriken)).EndInit();
            this.caltropsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caltrops)).EndInit();
            this.flareGunPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flareGun)).EndInit();
            this.chakramPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chakram)).EndInit();
            this.earthSpearPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.earthSpear)).EndInit();
            this.bombPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ocarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTime)).EndInit();
            this.mapsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maps)).EndInit();
            this.ankhJewelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ankhJewels)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shellHorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterproofCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatproofCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimsuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djedPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantraSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagomap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagostr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunplus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beolamu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bounce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miracle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamulana)).EndInit();
            this.bossPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amphisbaena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellmac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahamut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palenque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baphomet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiamat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Assembly _assembly;
        private Stream _xmlStream;

        private TrackerBox scanner;
        private TrackerBox reader;
        private TrackerBox sakit;
        private TrackerBox amphisbaena;
        private TrackerBox ellmac;
        private TrackerBox bahamut;
        private TrackerBox tiamat;
        private TrackerBox baphomet;
        private TrackerBox palenque;
        private TrackerBox viy;
        private TrackerBox maps;
        private TrackerBox mulanaTalisman;
        private TrackerBox talisman;

        private bool gameStarted;

        private List<String> allItems;

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new LMRItemTracker.LaMulanaItemTrackerForm());
        }

        private ColorDialog textColorDialog;
        private TrackerBox ankhJewels;
        private TrackerLabel ankhJewelCount;
        private TrackerBox ocarina;
        private TrackerBox mantra;
        private TrackerBox skullWall;
        private TrackerBox bronzeMirror;
        private TrackerBox fruitOfEden;
        private TrackerBox twinStatue;
        private TrackerBox keyOfEternity;
        private TrackerBox isisPendant;
        private TrackerBox grappleClaw;
        private TrackerBox hermesBoots;
        private TrackerBox feather;
        private TrackerBox treasures;
        private TrackerLabel translationTablets;
        private KeyFairyTrackerBox keyFairy;
        private TrackerBox helmet;
        private TrackerBox planeModel;
        private TrackerBox cogOfTheSoul;
        private TrackerBox bomb;
        private TrackerBox ring;
        private TrackerBox dimensionalKey;
        private TrackerBox crystalSkull;
        private ColorDialog formColorDialog;
        private TrackerBox originSeal;
        private TrackerBox birthSeal;
        private TrackerBox lifeSeal;
        private TrackerBox deathSeal;
        private TrackerBox pochetteKey;
        private TrackerLabel skullWallCount;
        private TrackerBox dragonBone;
        private TrackerBox bookOfTheDead;
        private TrackerBox scriptures;
        private TrackerBox crucifix;
        private TrackerBox fairyClothes;
        private TrackerBox bracelet;
        private TrackerBox gauntlet;
        private TrackerBox pepper;
        private TrackerBox eyeOfTruth;
        private TrackerBox miniDoll;
        private TrackerBox magatamaJewel;
        private TrackerBox iceCape;
        private TrackerBox axe;
        private TrackerBox chakram;
        private TrackerBox earthSpear;
        private TrackerBox flareGun;
        private TrackerBox anchor;
        private TrackerBox glove;
        private TrackerBox katana;
        private TrackerBox knife;
        private TrackerBox msx2;
        private TrackerBox perfume;
        private TrackerBox pistol;
        private TrackerBox scalesphere;
        private TrackerBox serpentStaff;
        private TrackerBox torude;
        private TrackerBox spaulder;
        private TrackerBox shuriken;
        private TrackerBox rollingShuriken;
        private TrackerBox caltrops;
        private TrackerBox diary;
        private MenuStrip menu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveSettingsToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private ItemTextPanel readerPanel;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripMenuItem layoutToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel mainPanel;
        private ItemTextPanel mapsPanel;
        private ItemTextPanel ankhJewelPanel;
        private ItemTextPanel shrinePanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel bossPanel;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem addItemPanel1ToolStripMenuItem;
        private ToolStripMenuItem addItemPanel2ToolStripMenuItem;
        private ToolStripMenuItem addItemPanel3ToolStripMenuItem;
        private ToolStripMenuItem addItemPanel4ToolStripMenuItem;
        private ToolStripMenuItem addItemPanel5ToolStripMenuItem;
        private ToolStripMenuItem restoreDefaultsToolStripMenuItem;
        private FlowLayoutPanel lastItemPanel;
        private PictureBox lastItem1;
        private Label lastItemLabel;
        private ToolStripMenuItem showLastItemToolStripMenuItem;
        private FlowLayoutPanel overviewPanel;
        private ToolStripMenuItem clearLastItemToolStripMenuItem;
        private TrackerLabel mapCount;
        private PictureBox lastItem2;
        private PictureBox lastItem3;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem uncollectedItemsToolStripMenuItem;
        private ToolStripMenuItem noImageToolStripMenuItem;
        private ToolStripMenuItem shadedImageToolStripMenuItem;
        private ToolStripMenuItem showAmmoCountToolStripMenuItem;
        private PistolPanel pistolPanel;
        private PistolAmmoTrackerLabel pistolAmmoCount;
        private ItemTextPanel shurikenPanel;
        private TrackerLabel shurikenAmmoCount;
        private ItemTextPanel rollingShurikenPanel;
        private TrackerLabel rollingShurikenAmmoCount;
        private ItemTextPanel caltropsPanel;
        private ItemTextPanel flareGunPanel;
        private ItemTextPanel chakramPanel;
        private ItemTextPanel earthSpearPanel;
        private ItemTextPanel bombPanel;
        private TrackerLabel caltropsAmmoCount;
        private TrackerLabel flareGunAmmoCount;
        private TrackerLabel chakramAmmoCount;
        private TrackerLabel earthSpearAmmoCount;
        private TrackerLabel bombAmmoCount;
        private ToolStripMenuItem hideImageToolStripMenuItem;
        private TrackerBox shellHorn;
        private TrackerBox waterproofCase;
        private TrackerBox heatproofCase;
        private TrackerBox djedPillar;
        private TrackerBox mantraSingle;
        private TrackerBox swimsuit;
        private TrackerBox xmailer;
        private TrackerBox yagomap;
        private TrackerBox yagostr;
        private TrackerBox bunemon;
        private TrackerBox bunplus;
        private TrackerBox guild;
        private TrackerBox emusic;
        private TrackerBox beolamu;
        private TrackerBox randc;
        private TrackerBox capstar;
        private TrackerBox deathv;
        private TrackerBox move;
        private TrackerBox mekuri;
        private TrackerBox bounce;
        private TrackerBox miracle;
        private TrackerBox lamulana;
        private FlowLayoutPanel flowLayoutPanel6;
        private ToolStripMenuItem addItemPanel6ToolStripMenuItem;
        private ToolStripMenuItem showDeathCountToolStripMenuItem;
        private FlowLayoutPanel deathPanel;
        private Label deathLabel;
        private Label deathCount;
        private ToolStripMenuItem clearDeathCountToolStripMenuItem;
        private ColorDialog itemColorDialog;
        private ToolStripMenuItem changeUncollectedItemColorToolStripMenuItem;
        private ToolStripMenuItem solidImageToolStripMenuItem;
        private MultiStateTrackerBox whip;
        private MultiStateTrackerBox holyGrail;
        private TrackerBox mirai;
        private MultiStateTrackerBox womanStatue;
        private MultiStateTrackerBox shield;
        private MultiStateTrackerBox vessel;
        private KeySwordTrackerBox keySword;
        private MultiStateTrackerBox lampOfTime;
        private FlowLayoutPanel spaulderPanel;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label spaulderLabel;
        private Label spaulderCount;
        private ToolStripMenuItem clearSpauldersToolStripMenuItem;
        private FlowLayoutPanel totalSpauldersPanel;
        private Label totalSpauldersLabel;
        private Label totalSpauldersCount;
        private TrackerBox secretTreasureOfLife;
    }
}