using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.ankhJewelCount = new System.Windows.Forms.Label();
            this.translationTablets = new System.Windows.Forms.Label();
            this.formColorDialog = new System.Windows.Forms.ColorDialog();
            this.skullWallCount = new System.Windows.Forms.Label();
            this.shieldsPanel = new System.Windows.Forms.Panel();
            this.buckler = new System.Windows.Forms.PictureBox();
            this.angelShield = new System.Windows.Forms.PictureBox();
            this.fakeSilverShield = new System.Windows.Forms.PictureBox();
            this.silverShield = new System.Windows.Forms.PictureBox();
            this.whipsPanel = new System.Windows.Forms.Panel();
            this.flailWhip = new System.Windows.Forms.PictureBox();
            this.chainWhip = new System.Windows.Forms.PictureBox();
            this.whip = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.noImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAmmoCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeathCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDeathCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLastItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hermesBoots = new System.Windows.Forms.PictureBox();
            this.grappleClaw = new System.Windows.Forms.PictureBox();
            this.feather = new System.Windows.Forms.PictureBox();
            this.scanner = new System.Windows.Forms.PictureBox();
            this.readerPanel = new System.Windows.Forms.Panel();
            this.reader = new System.Windows.Forms.PictureBox();
            this.grailPanel = new System.Windows.Forms.Panel();
            this.grailBroken = new System.Windows.Forms.PictureBox();
            this.grailFull = new System.Windows.Forms.PictureBox();
            this.grail = new System.Windows.Forms.PictureBox();
            this.mirai = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.bronzeMirror = new System.Windows.Forms.PictureBox();
            this.fruitOfEden = new System.Windows.Forms.PictureBox();
            this.twinStatue = new System.Windows.Forms.PictureBox();
            this.keyOfEternity = new System.Windows.Forms.PictureBox();
            this.helmet = new System.Windows.Forms.PictureBox();
            this.planeModel = new System.Windows.Forms.PictureBox();
            this.crystalSkull = new System.Windows.Forms.PictureBox();
            this.dimensionalKey = new System.Windows.Forms.PictureBox();
            this.pochetteKey = new System.Windows.Forms.PictureBox();
            this.iceCape = new System.Windows.Forms.PictureBox();
            this.scalesphere = new System.Windows.Forms.PictureBox();
            this.cogOfTheSoul = new System.Windows.Forms.PictureBox();
            this.dragonBone = new System.Windows.Forms.PictureBox();
            this.serpentStaff = new System.Windows.Forms.PictureBox();
            this.mulanaTalisman = new System.Windows.Forms.PictureBox();
            this.womanPanel = new System.Windows.Forms.Panel();
            this.maternityStatue = new System.Windows.Forms.PictureBox();
            this.womanStatue = new System.Windows.Forms.PictureBox();
            this.pepper = new System.Windows.Forms.PictureBox();
            this.talisman = new System.Windows.Forms.PictureBox();
            this.diary = new System.Windows.Forms.PictureBox();
            this.miniDoll = new System.Windows.Forms.PictureBox();
            this.treasures = new System.Windows.Forms.PictureBox();
            this.anchor = new System.Windows.Forms.PictureBox();
            this.keyFairy = new System.Windows.Forms.PictureBox();
            this.isisPendant = new System.Windows.Forms.PictureBox();
            this.eyeOfTruth = new System.Windows.Forms.PictureBox();
            this.magatamaJewel = new System.Windows.Forms.PictureBox();
            this.torude = new System.Windows.Forms.PictureBox();
            this.shrinePanel = new System.Windows.Forms.Panel();
            this.skullWall = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.originSeal = new System.Windows.Forms.PictureBox();
            this.birthSeal = new System.Windows.Forms.PictureBox();
            this.lifeSeal = new System.Windows.Forms.PictureBox();
            this.deathSeal = new System.Windows.Forms.PictureBox();
            this.bookOfTheDead = new System.Windows.Forms.PictureBox();
            this.ring = new System.Windows.Forms.PictureBox();
            this.fairyClothes = new System.Windows.Forms.PictureBox();
            this.msx2 = new System.Windows.Forms.PictureBox();
            this.scriptures = new System.Windows.Forms.PictureBox();
            this.crucifix = new System.Windows.Forms.PictureBox();
            this.perfume = new System.Windows.Forms.PictureBox();
            this.glove = new System.Windows.Forms.PictureBox();
            this.bracelet = new System.Windows.Forms.PictureBox();
            this.spaulder = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.knife = new System.Windows.Forms.PictureBox();
            this.axe = new System.Windows.Forms.PictureBox();
            this.katana = new System.Windows.Forms.PictureBox();
            this.gauntlet = new System.Windows.Forms.PictureBox();
            this.pistolPanel = new System.Windows.Forms.Panel();
            this.pistolAmmoCount = new System.Windows.Forms.Label();
            this.pistol = new System.Windows.Forms.PictureBox();
            this.shurikenPanel = new System.Windows.Forms.Panel();
            this.shurikenAmmoCount = new System.Windows.Forms.Label();
            this.shuriken = new System.Windows.Forms.PictureBox();
            this.rollingShurikenPanel = new System.Windows.Forms.Panel();
            this.rollingShurikenAmmoCount = new System.Windows.Forms.Label();
            this.rollingShuriken = new System.Windows.Forms.PictureBox();
            this.caltropsPanel = new System.Windows.Forms.Panel();
            this.caltropsAmmoCount = new System.Windows.Forms.Label();
            this.caltrops = new System.Windows.Forms.PictureBox();
            this.flareGunPanel = new System.Windows.Forms.Panel();
            this.flareGunAmmoCount = new System.Windows.Forms.Label();
            this.flareGun = new System.Windows.Forms.PictureBox();
            this.chakramPanel = new System.Windows.Forms.Panel();
            this.chakramAmmoCount = new System.Windows.Forms.Label();
            this.chakram = new System.Windows.Forms.PictureBox();
            this.earthSpearPanel = new System.Windows.Forms.Panel();
            this.earthSpearAmmoCount = new System.Windows.Forms.Label();
            this.earthSpear = new System.Windows.Forms.PictureBox();
            this.bombPanel = new System.Windows.Forms.Panel();
            this.bombAmmoCount = new System.Windows.Forms.Label();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.ocarina = new System.Windows.Forms.PictureBox();
            this.mantra = new System.Windows.Forms.PictureBox();
            this.vesselPanel = new System.Windows.Forms.Panel();
            this.vessel = new System.Windows.Forms.PictureBox();
            this.vesselNotFound = new System.Windows.Forms.PictureBox();
            this.keySword = new System.Windows.Forms.PictureBox();
            this.lampOfTimePanel = new System.Windows.Forms.Panel();
            this.lampOfTimeNotFound = new System.Windows.Forms.PictureBox();
            this.lampOfTime = new System.Windows.Forms.PictureBox();
            this.mapsPanel = new System.Windows.Forms.Panel();
            this.mapCount = new System.Windows.Forms.Label();
            this.maps = new System.Windows.Forms.PictureBox();
            this.ankhJewelPanel = new System.Windows.Forms.Panel();
            this.ankhJewels = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.shellHorn = new System.Windows.Forms.PictureBox();
            this.waterproofCase = new System.Windows.Forms.PictureBox();
            this.heatproofCase = new System.Windows.Forms.PictureBox();
            this.swimsuit = new System.Windows.Forms.PictureBox();
            this.djedPillar = new System.Windows.Forms.PictureBox();
            this.mantraSingle = new System.Windows.Forms.PictureBox();
            this.xmailer = new System.Windows.Forms.PictureBox();
            this.yagomap = new System.Windows.Forms.PictureBox();
            this.yagostr = new System.Windows.Forms.PictureBox();
            this.bunemon = new System.Windows.Forms.PictureBox();
            this.bunplus = new System.Windows.Forms.PictureBox();
            this.guild = new System.Windows.Forms.PictureBox();
            this.beolamu = new System.Windows.Forms.PictureBox();
            this.emusic = new System.Windows.Forms.PictureBox();
            this.randc = new System.Windows.Forms.PictureBox();
            this.capstar = new System.Windows.Forms.PictureBox();
            this.deathv = new System.Windows.Forms.PictureBox();
            this.move = new System.Windows.Forms.PictureBox();
            this.mekuri = new System.Windows.Forms.PictureBox();
            this.bounce = new System.Windows.Forms.PictureBox();
            this.miracle = new System.Windows.Forms.PictureBox();
            this.lamulana = new System.Windows.Forms.PictureBox();
            this.bossPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amphisbaena = new System.Windows.Forms.PictureBox();
            this.sakit = new System.Windows.Forms.PictureBox();
            this.ellmac = new System.Windows.Forms.PictureBox();
            this.bahamut = new System.Windows.Forms.PictureBox();
            this.viy = new System.Windows.Forms.PictureBox();
            this.palenque = new System.Windows.Forms.PictureBox();
            this.baphomet = new System.Windows.Forms.PictureBox();
            this.tiamat = new System.Windows.Forms.PictureBox();
            this.shieldsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buckler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeSilverShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverShield)).BeginInit();
            this.whipsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flailWhip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainWhip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whip)).BeginInit();
            this.menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).BeginInit();
            this.readerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).BeginInit();
            this.grailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grailBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grailFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).BeginInit();
            this.mainPanel.SuspendLayout();
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
            this.womanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maternityStatue)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.knife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).BeginInit();
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
            this.vesselPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).BeginInit();
            this.lampOfTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).BeginInit();
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
            // ankhJewelCount
            // 
            this.ankhJewelCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ankhJewelCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ankhJewelCount.Location = new System.Drawing.Point(0, 40);
            this.ankhJewelCount.Name = "ankhJewelCount";
            this.ankhJewelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ankhJewelCount.Size = new System.Drawing.Size(40, 16);
            this.ankhJewelCount.TabIndex = 28;
            this.ankhJewelCount.Text = "0";
            this.ankhJewelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ankhJewelCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // translationTablets
            // 
            this.translationTablets.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.translationTablets.Location = new System.Drawing.Point(0, 40);
            this.translationTablets.Name = "translationTablets";
            this.translationTablets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.translationTablets.Size = new System.Drawing.Size(40, 16);
            this.translationTablets.TabIndex = 48;
            this.translationTablets.Text = "0%";
            this.translationTablets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.translationTablets.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // formColorDialog
            // 
            this.formColorDialog.AnyColor = true;
            this.formColorDialog.SolidColorOnly = true;
            // 
            // skullWallCount
            // 
            this.skullWallCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skullWallCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.skullWallCount.Location = new System.Drawing.Point(0, 40);
            this.skullWallCount.Name = "skullWallCount";
            this.skullWallCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skullWallCount.Size = new System.Drawing.Size(40, 16);
            this.skullWallCount.TabIndex = 67;
            this.skullWallCount.Text = "0/4";
            this.skullWallCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skullWallCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // shieldsPanel
            // 
            this.shieldsPanel.Controls.Add(this.buckler);
            this.shieldsPanel.Controls.Add(this.angelShield);
            this.shieldsPanel.Controls.Add(this.fakeSilverShield);
            this.shieldsPanel.Controls.Add(this.silverShield);
            this.shieldsPanel.Location = new System.Drawing.Point(160, 0);
            this.shieldsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.shieldsPanel.Name = "shieldsPanel";
            this.shieldsPanel.Size = new System.Drawing.Size(40, 40);
            this.shieldsPanel.TabIndex = 107;
            // 
            // buckler
            // 
            this.buckler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buckler.Image = global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            this.buckler.Location = new System.Drawing.Point(0, 0);
            this.buckler.Margin = new System.Windows.Forms.Padding(0);
            this.buckler.Name = "buckler";
            this.buckler.Size = new System.Drawing.Size(40, 40);
            this.buckler.TabIndex = 82;
            this.buckler.TabStop = false;
            // 
            // angelShield
            // 
            this.angelShield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angelShield.Image = global::LMRItemTracker.Properties.Resources.Icon_angelshield;
            this.angelShield.Location = new System.Drawing.Point(0, 0);
            this.angelShield.Margin = new System.Windows.Forms.Padding(0);
            this.angelShield.Name = "angelShield";
            this.angelShield.Size = new System.Drawing.Size(40, 40);
            this.angelShield.TabIndex = 102;
            this.angelShield.TabStop = false;
            this.angelShield.Visible = false;
            // 
            // fakeSilverShield
            // 
            this.fakeSilverShield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fakeSilverShield.Image = global::LMRItemTracker.Properties.Resources.Icon_silvershield;
            this.fakeSilverShield.Location = new System.Drawing.Point(0, 0);
            this.fakeSilverShield.Name = "fakeSilverShield";
            this.fakeSilverShield.Size = new System.Drawing.Size(40, 40);
            this.fakeSilverShield.TabIndex = 101;
            this.fakeSilverShield.TabStop = false;
            this.fakeSilverShield.Visible = false;
            // 
            // silverShield
            // 
            this.silverShield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.silverShield.Image = global::LMRItemTracker.Properties.Resources.Icon_silvershield;
            this.silverShield.Location = new System.Drawing.Point(0, 0);
            this.silverShield.Margin = new System.Windows.Forms.Padding(0);
            this.silverShield.Name = "silverShield";
            this.silverShield.Size = new System.Drawing.Size(40, 40);
            this.silverShield.TabIndex = 103;
            this.silverShield.TabStop = false;
            this.silverShield.Visible = false;
            // 
            // whipsPanel
            // 
            this.whipsPanel.Controls.Add(this.flailWhip);
            this.whipsPanel.Controls.Add(this.chainWhip);
            this.whipsPanel.Controls.Add(this.whip);
            this.whipsPanel.Location = new System.Drawing.Point(0, 0);
            this.whipsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.whipsPanel.Name = "whipsPanel";
            this.whipsPanel.Size = new System.Drawing.Size(40, 40);
            this.whipsPanel.TabIndex = 108;
            // 
            // flailWhip
            // 
            this.flailWhip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flailWhip.Image = global::LMRItemTracker.Properties.Resources.Icon_flailwhip;
            this.flailWhip.Location = new System.Drawing.Point(0, 0);
            this.flailWhip.Margin = new System.Windows.Forms.Padding(0);
            this.flailWhip.Name = "flailWhip";
            this.flailWhip.Size = new System.Drawing.Size(40, 40);
            this.flailWhip.TabIndex = 105;
            this.flailWhip.TabStop = false;
            this.flailWhip.Visible = false;
            // 
            // chainWhip
            // 
            this.chainWhip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chainWhip.Image = global::LMRItemTracker.Properties.Resources.Icon_chainwhip;
            this.chainWhip.Location = new System.Drawing.Point(0, 0);
            this.chainWhip.Margin = new System.Windows.Forms.Padding(0);
            this.chainWhip.Name = "chainWhip";
            this.chainWhip.Size = new System.Drawing.Size(40, 40);
            this.chainWhip.TabIndex = 104;
            this.chainWhip.TabStop = false;
            this.chainWhip.Visible = false;
            // 
            // whip
            // 
            this.whip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whip.Image = global::LMRItemTracker.Properties.Resources.Icon_whip;
            this.whip.Location = new System.Drawing.Point(0, 0);
            this.whip.Margin = new System.Windows.Forms.Padding(0);
            this.whip.Name = "whip";
            this.whip.Size = new System.Drawing.Size(40, 40);
            this.whip.TabIndex = 84;
            this.whip.TabStop = false;
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
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettings);
            // 
            // restoreDefaultsToolStripMenuItem
            // 
            this.restoreDefaultsToolStripMenuItem.Name = "restoreDefaultsToolStripMenuItem";
            this.restoreDefaultsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restoreDefaultsToolStripMenuItem.Text = "Restore Defaults";
            this.restoreDefaultsToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultSettings);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColorToolStripMenuItem,
            this.changeTextColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change Text Color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.textDoubleClick);
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
            this.clearLastItemToolStripMenuItem});
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.hermesBoots);
            this.flowLayoutPanel1.Controls.Add(this.grappleClaw);
            this.flowLayoutPanel1.Controls.Add(this.feather);
            this.flowLayoutPanel1.Controls.Add(this.scanner);
            this.flowLayoutPanel1.Controls.Add(this.readerPanel);
            this.flowLayoutPanel1.Controls.Add(this.grailPanel);
            this.flowLayoutPanel1.Controls.Add(this.mirai);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel1, true);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 66);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 40);
            this.flowLayoutPanel1.TabIndex = 110;
            this.flowLayoutPanel1.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // hermesBoots
            // 
            this.hermesBoots.Image = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
            this.hermesBoots.Location = new System.Drawing.Point(0, 0);
            this.hermesBoots.Margin = new System.Windows.Forms.Padding(0);
            this.hermesBoots.Name = "hermesBoots";
            this.hermesBoots.Size = new System.Drawing.Size(40, 40);
            this.hermesBoots.TabIndex = 44;
            this.hermesBoots.TabStop = false;
            // 
            // grappleClaw
            // 
            this.grappleClaw.Image = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
            this.grappleClaw.Location = new System.Drawing.Point(40, 0);
            this.grappleClaw.Margin = new System.Windows.Forms.Padding(0);
            this.grappleClaw.Name = "grappleClaw";
            this.grappleClaw.Size = new System.Drawing.Size(40, 40);
            this.grappleClaw.TabIndex = 45;
            this.grappleClaw.TabStop = false;
            // 
            // feather
            // 
            this.feather.Image = global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
            this.feather.Location = new System.Drawing.Point(80, 0);
            this.feather.Margin = new System.Windows.Forms.Padding(0);
            this.feather.Name = "feather";
            this.feather.Size = new System.Drawing.Size(40, 40);
            this.feather.TabIndex = 46;
            this.feather.TabStop = false;
            // 
            // scanner
            // 
            this.scanner.Image = global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
            this.scanner.Location = new System.Drawing.Point(120, 0);
            this.scanner.Margin = new System.Windows.Forms.Padding(0);
            this.scanner.Name = "scanner";
            this.scanner.Size = new System.Drawing.Size(40, 40);
            this.scanner.TabIndex = 1;
            this.scanner.TabStop = false;
            // 
            // readerPanel
            // 
            this.readerPanel.Controls.Add(this.reader);
            this.readerPanel.Controls.Add(this.translationTablets);
            this.readerPanel.Location = new System.Drawing.Point(160, 0);
            this.readerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.readerPanel.Name = "readerPanel";
            this.readerPanel.Size = new System.Drawing.Size(40, 40);
            this.readerPanel.TabIndex = 111;
            // 
            // reader
            // 
            this.reader.Dock = System.Windows.Forms.DockStyle.Top;
            this.reader.Image = global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
            this.reader.Location = new System.Drawing.Point(0, 0);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(40, 40);
            this.reader.TabIndex = 2;
            this.reader.TabStop = false;
            // 
            // grailPanel
            // 
            this.grailPanel.Controls.Add(this.grailBroken);
            this.grailPanel.Controls.Add(this.grailFull);
            this.grailPanel.Controls.Add(this.grail);
            this.grailPanel.Location = new System.Drawing.Point(200, 0);
            this.grailPanel.Margin = new System.Windows.Forms.Padding(0);
            this.grailPanel.Name = "grailPanel";
            this.grailPanel.Size = new System.Drawing.Size(40, 40);
            this.grailPanel.TabIndex = 112;
            // 
            // grailBroken
            // 
            this.grailBroken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grailBroken.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail2;
            this.grailBroken.Location = new System.Drawing.Point(0, 0);
            this.grailBroken.Margin = new System.Windows.Forms.Padding(0);
            this.grailBroken.Name = "grailBroken";
            this.grailBroken.Size = new System.Drawing.Size(40, 40);
            this.grailBroken.TabIndex = 115;
            this.grailBroken.TabStop = false;
            this.grailBroken.Visible = false;
            // 
            // grailFull
            // 
            this.grailFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grailFull.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail3;
            this.grailFull.Location = new System.Drawing.Point(0, 0);
            this.grailFull.Margin = new System.Windows.Forms.Padding(0);
            this.grailFull.Name = "grailFull";
            this.grailFull.Size = new System.Drawing.Size(40, 40);
            this.grailFull.TabIndex = 114;
            this.grailFull.TabStop = false;
            this.grailFull.Visible = false;
            // 
            // grail
            // 
            this.grail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grail.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            this.grail.Location = new System.Drawing.Point(0, 0);
            this.grail.Margin = new System.Windows.Forms.Padding(0);
            this.grail.Name = "grail";
            this.grail.Size = new System.Drawing.Size(40, 40);
            this.grail.TabIndex = 3;
            this.grail.TabStop = false;
            // 
            // mirai
            // 
            this.mirai.Image = global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
            this.mirai.Location = new System.Drawing.Point(240, 0);
            this.mirai.Margin = new System.Windows.Forms.Padding(0);
            this.mirai.Name = "mirai";
            this.mirai.Size = new System.Drawing.Size(40, 40);
            this.mirai.TabIndex = 113;
            this.mirai.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.mainPanel.Size = new System.Drawing.Size(340, 710);
            this.mainPanel.TabIndex = 111;
            this.mainPanel.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // overviewPanel
            // 
            this.overviewPanel.AutoSize = true;
            this.overviewPanel.Controls.Add(this.lastItemPanel);
            this.overviewPanel.Controls.Add(this.deathPanel);
            this.mainPanel.SetFlowBreak(this.overviewPanel, true);
            this.overviewPanel.Location = new System.Drawing.Point(10, 10);
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
            this.lastItemLabel.DoubleClick += new System.EventHandler(this.textDoubleClick);
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
            this.flowLayoutPanel2.Controls.Add(this.womanPanel);
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
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel2, true);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 114);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 176);
            this.flowLayoutPanel2.TabIndex = 112;
            this.flowLayoutPanel2.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // bronzeMirror
            // 
            this.bronzeMirror.Image = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
            this.bronzeMirror.Location = new System.Drawing.Point(0, 0);
            this.bronzeMirror.Margin = new System.Windows.Forms.Padding(0);
            this.bronzeMirror.Name = "bronzeMirror";
            this.bronzeMirror.Size = new System.Drawing.Size(40, 40);
            this.bronzeMirror.TabIndex = 38;
            this.bronzeMirror.TabStop = false;
            // 
            // fruitOfEden
            // 
            this.fruitOfEden.Image = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
            this.fruitOfEden.Location = new System.Drawing.Point(40, 0);
            this.fruitOfEden.Margin = new System.Windows.Forms.Padding(0);
            this.fruitOfEden.Name = "fruitOfEden";
            this.fruitOfEden.Size = new System.Drawing.Size(40, 40);
            this.fruitOfEden.TabIndex = 39;
            this.fruitOfEden.TabStop = false;
            // 
            // twinStatue
            // 
            this.twinStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
            this.twinStatue.Location = new System.Drawing.Point(80, 0);
            this.twinStatue.Margin = new System.Windows.Forms.Padding(0);
            this.twinStatue.Name = "twinStatue";
            this.twinStatue.Size = new System.Drawing.Size(40, 40);
            this.twinStatue.TabIndex = 40;
            this.twinStatue.TabStop = false;
            // 
            // keyOfEternity
            // 
            this.keyOfEternity.Image = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
            this.keyOfEternity.Location = new System.Drawing.Point(120, 0);
            this.keyOfEternity.Margin = new System.Windows.Forms.Padding(0);
            this.keyOfEternity.Name = "keyOfEternity";
            this.keyOfEternity.Size = new System.Drawing.Size(40, 40);
            this.keyOfEternity.TabIndex = 41;
            this.keyOfEternity.TabStop = false;
            // 
            // helmet
            // 
            this.helmet.Image = global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
            this.helmet.Location = new System.Drawing.Point(160, 0);
            this.helmet.Margin = new System.Windows.Forms.Padding(0);
            this.helmet.Name = "helmet";
            this.helmet.Size = new System.Drawing.Size(40, 40);
            this.helmet.TabIndex = 51;
            this.helmet.TabStop = false;
            // 
            // planeModel
            // 
            this.planeModel.Image = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            this.planeModel.Location = new System.Drawing.Point(200, 0);
            this.planeModel.Margin = new System.Windows.Forms.Padding(0);
            this.planeModel.Name = "planeModel";
            this.planeModel.Size = new System.Drawing.Size(40, 40);
            this.planeModel.TabIndex = 52;
            this.planeModel.TabStop = false;
            // 
            // crystalSkull
            // 
            this.crystalSkull.Image = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            this.crystalSkull.Location = new System.Drawing.Point(240, 0);
            this.crystalSkull.Margin = new System.Windows.Forms.Padding(0);
            this.crystalSkull.Name = "crystalSkull";
            this.crystalSkull.Size = new System.Drawing.Size(40, 40);
            this.crystalSkull.TabIndex = 57;
            this.crystalSkull.TabStop = false;
            // 
            // dimensionalKey
            // 
            this.dimensionalKey.Image = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
            this.dimensionalKey.Location = new System.Drawing.Point(280, 0);
            this.dimensionalKey.Margin = new System.Windows.Forms.Padding(0);
            this.dimensionalKey.Name = "dimensionalKey";
            this.dimensionalKey.Size = new System.Drawing.Size(40, 40);
            this.dimensionalKey.TabIndex = 56;
            this.dimensionalKey.TabStop = false;
            // 
            // pochetteKey
            // 
            this.pochetteKey.Image = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
            this.pochetteKey.Location = new System.Drawing.Point(0, 40);
            this.pochetteKey.Margin = new System.Windows.Forms.Padding(0);
            this.pochetteKey.Name = "pochetteKey";
            this.pochetteKey.Size = new System.Drawing.Size(40, 40);
            this.pochetteKey.TabIndex = 65;
            this.pochetteKey.TabStop = false;
            // 
            // iceCape
            // 
            this.iceCape.Image = global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
            this.iceCape.Location = new System.Drawing.Point(40, 40);
            this.iceCape.Margin = new System.Windows.Forms.Padding(0);
            this.iceCape.Name = "iceCape";
            this.iceCape.Size = new System.Drawing.Size(40, 40);
            this.iceCape.TabIndex = 80;
            this.iceCape.TabStop = false;
            // 
            // scalesphere
            // 
            this.scalesphere.Image = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
            this.scalesphere.Location = new System.Drawing.Point(80, 40);
            this.scalesphere.Margin = new System.Windows.Forms.Padding(0);
            this.scalesphere.Name = "scalesphere";
            this.scalesphere.Size = new System.Drawing.Size(40, 40);
            this.scalesphere.TabIndex = 94;
            this.scalesphere.TabStop = false;
            // 
            // cogOfTheSoul
            // 
            this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.cogOfTheSoul.Location = new System.Drawing.Point(120, 40);
            this.cogOfTheSoul.Margin = new System.Windows.Forms.Padding(0);
            this.cogOfTheSoul.Name = "cogOfTheSoul";
            this.cogOfTheSoul.Size = new System.Drawing.Size(40, 40);
            this.cogOfTheSoul.TabIndex = 53;
            this.cogOfTheSoul.TabStop = false;
            // 
            // dragonBone
            // 
            this.dragonBone.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            this.dragonBone.Location = new System.Drawing.Point(160, 40);
            this.dragonBone.Margin = new System.Windows.Forms.Padding(0);
            this.dragonBone.Name = "dragonBone";
            this.dragonBone.Size = new System.Drawing.Size(40, 40);
            this.dragonBone.TabIndex = 68;
            this.dragonBone.TabStop = false;
            // 
            // serpentStaff
            // 
            this.serpentStaff.Image = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
            this.serpentStaff.Location = new System.Drawing.Point(200, 40);
            this.serpentStaff.Margin = new System.Windows.Forms.Padding(0);
            this.serpentStaff.Name = "serpentStaff";
            this.serpentStaff.Size = new System.Drawing.Size(40, 40);
            this.serpentStaff.TabIndex = 95;
            this.serpentStaff.TabStop = false;
            // 
            // mulanaTalisman
            // 
            this.mulanaTalisman.Image = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            this.mulanaTalisman.Location = new System.Drawing.Point(240, 40);
            this.mulanaTalisman.Margin = new System.Windows.Forms.Padding(0);
            this.mulanaTalisman.Name = "mulanaTalisman";
            this.mulanaTalisman.Size = new System.Drawing.Size(40, 40);
            this.mulanaTalisman.TabIndex = 27;
            this.mulanaTalisman.TabStop = false;
            // 
            // womanPanel
            // 
            this.womanPanel.Controls.Add(this.maternityStatue);
            this.womanPanel.Controls.Add(this.womanStatue);
            this.womanPanel.Location = new System.Drawing.Point(280, 40);
            this.womanPanel.Margin = new System.Windows.Forms.Padding(0);
            this.womanPanel.Name = "womanPanel";
            this.womanPanel.Size = new System.Drawing.Size(40, 40);
            this.womanPanel.TabIndex = 116;
            // 
            // maternityStatue
            // 
            this.maternityStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_maternitystatue;
            this.maternityStatue.Location = new System.Drawing.Point(0, 0);
            this.maternityStatue.Margin = new System.Windows.Forms.Padding(0);
            this.maternityStatue.Name = "maternityStatue";
            this.maternityStatue.Size = new System.Drawing.Size(40, 40);
            this.maternityStatue.TabIndex = 106;
            this.maternityStatue.TabStop = false;
            // 
            // womanStatue
            // 
            this.womanStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
            this.womanStatue.Location = new System.Drawing.Point(0, 0);
            this.womanStatue.Margin = new System.Windows.Forms.Padding(0);
            this.womanStatue.Name = "womanStatue";
            this.womanStatue.Size = new System.Drawing.Size(40, 40);
            this.womanStatue.TabIndex = 75;
            this.womanStatue.TabStop = false;
            // 
            // pepper
            // 
            this.pepper.Image = global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
            this.pepper.Location = new System.Drawing.Point(0, 80);
            this.pepper.Margin = new System.Windows.Forms.Padding(0);
            this.pepper.Name = "pepper";
            this.pepper.Size = new System.Drawing.Size(40, 40);
            this.pepper.TabIndex = 76;
            this.pepper.TabStop = false;
            // 
            // talisman
            // 
            this.talisman.Image = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            this.talisman.Location = new System.Drawing.Point(40, 80);
            this.talisman.Margin = new System.Windows.Forms.Padding(0);
            this.talisman.Name = "talisman";
            this.talisman.Size = new System.Drawing.Size(40, 40);
            this.talisman.TabIndex = 25;
            this.talisman.TabStop = false;
            // 
            // diary
            // 
            this.diary.Image = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            this.diary.Location = new System.Drawing.Point(80, 80);
            this.diary.Margin = new System.Windows.Forms.Padding(0);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(40, 40);
            this.diary.TabIndex = 26;
            this.diary.TabStop = false;
            // 
            // miniDoll
            // 
            this.miniDoll.Image = global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
            this.miniDoll.Location = new System.Drawing.Point(120, 80);
            this.miniDoll.Margin = new System.Windows.Forms.Padding(0);
            this.miniDoll.Name = "miniDoll";
            this.miniDoll.Size = new System.Drawing.Size(40, 40);
            this.miniDoll.TabIndex = 78;
            this.miniDoll.TabStop = false;
            // 
            // treasures
            // 
            this.treasures.Image = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            this.treasures.Location = new System.Drawing.Point(160, 80);
            this.treasures.Margin = new System.Windows.Forms.Padding(0);
            this.treasures.Name = "treasures";
            this.treasures.Size = new System.Drawing.Size(40, 40);
            this.treasures.TabIndex = 47;
            this.treasures.TabStop = false;
            // 
            // anchor
            // 
            this.anchor.Image = global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
            this.anchor.Location = new System.Drawing.Point(200, 80);
            this.anchor.Margin = new System.Windows.Forms.Padding(0);
            this.anchor.Name = "anchor";
            this.anchor.Size = new System.Drawing.Size(40, 40);
            this.anchor.TabIndex = 87;
            this.anchor.TabStop = false;
            // 
            // keyFairy
            // 
            this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank;
            this.keyFairy.Location = new System.Drawing.Point(240, 80);
            this.keyFairy.Margin = new System.Windows.Forms.Padding(0);
            this.keyFairy.Name = "keyFairy";
            this.keyFairy.Size = new System.Drawing.Size(40, 40);
            this.keyFairy.TabIndex = 49;
            this.keyFairy.TabStop = false;
            // 
            // isisPendant
            // 
            this.isisPendant.Image = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            this.isisPendant.Location = new System.Drawing.Point(280, 80);
            this.isisPendant.Margin = new System.Windows.Forms.Padding(0);
            this.isisPendant.Name = "isisPendant";
            this.isisPendant.Size = new System.Drawing.Size(40, 40);
            this.isisPendant.TabIndex = 42;
            this.isisPendant.TabStop = false;
            // 
            // eyeOfTruth
            // 
            this.eyeOfTruth.Image = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
            this.eyeOfTruth.Location = new System.Drawing.Point(0, 120);
            this.eyeOfTruth.Margin = new System.Windows.Forms.Padding(0);
            this.eyeOfTruth.Name = "eyeOfTruth";
            this.eyeOfTruth.Size = new System.Drawing.Size(40, 40);
            this.eyeOfTruth.TabIndex = 77;
            this.eyeOfTruth.TabStop = false;
            // 
            // magatamaJewel
            // 
            this.magatamaJewel.Image = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
            this.magatamaJewel.Location = new System.Drawing.Point(40, 120);
            this.magatamaJewel.Margin = new System.Windows.Forms.Padding(0);
            this.magatamaJewel.Name = "magatamaJewel";
            this.magatamaJewel.Size = new System.Drawing.Size(40, 40);
            this.magatamaJewel.TabIndex = 79;
            this.magatamaJewel.TabStop = false;
            // 
            // torude
            // 
            this.torude.Image = global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
            this.torude.Location = new System.Drawing.Point(80, 120);
            this.torude.Margin = new System.Windows.Forms.Padding(0);
            this.torude.Name = "torude";
            this.torude.Size = new System.Drawing.Size(40, 40);
            this.torude.TabIndex = 96;
            this.torude.TabStop = false;
            // 
            // shrinePanel
            // 
            this.shrinePanel.Controls.Add(this.skullWall);
            this.shrinePanel.Controls.Add(this.skullWallCount);
            this.shrinePanel.Location = new System.Drawing.Point(120, 120);
            this.shrinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.shrinePanel.Name = "shrinePanel";
            this.shrinePanel.Size = new System.Drawing.Size(40, 56);
            this.shrinePanel.TabIndex = 115;
            // 
            // skullWall
            // 
            this.skullWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.skullWall.Image = ((System.Drawing.Image)(resources.GetObject("skullWall.Image")));
            this.skullWall.Location = new System.Drawing.Point(0, 0);
            this.skullWall.Margin = new System.Windows.Forms.Padding(0);
            this.skullWall.Name = "skullWall";
            this.skullWall.Size = new System.Drawing.Size(40, 40);
            this.skullWall.TabIndex = 35;
            this.skullWall.TabStop = false;
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 298);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(320, 80);
            this.flowLayoutPanel3.TabIndex = 117;
            this.flowLayoutPanel3.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // originSeal
            // 
            this.originSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            this.originSeal.Location = new System.Drawing.Point(0, 0);
            this.originSeal.Margin = new System.Windows.Forms.Padding(0);
            this.originSeal.Name = "originSeal";
            this.originSeal.Size = new System.Drawing.Size(40, 40);
            this.originSeal.TabIndex = 60;
            this.originSeal.TabStop = false;
            // 
            // birthSeal
            // 
            this.birthSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            this.birthSeal.Location = new System.Drawing.Point(40, 0);
            this.birthSeal.Margin = new System.Windows.Forms.Padding(0);
            this.birthSeal.Name = "birthSeal";
            this.birthSeal.Size = new System.Drawing.Size(40, 40);
            this.birthSeal.TabIndex = 61;
            this.birthSeal.TabStop = false;
            // 
            // lifeSeal
            // 
            this.lifeSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            this.lifeSeal.Location = new System.Drawing.Point(80, 0);
            this.lifeSeal.Margin = new System.Windows.Forms.Padding(0);
            this.lifeSeal.Name = "lifeSeal";
            this.lifeSeal.Size = new System.Drawing.Size(40, 40);
            this.lifeSeal.TabIndex = 62;
            this.lifeSeal.TabStop = false;
            // 
            // deathSeal
            // 
            this.deathSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            this.deathSeal.Location = new System.Drawing.Point(120, 0);
            this.deathSeal.Margin = new System.Windows.Forms.Padding(0);
            this.deathSeal.Name = "deathSeal";
            this.deathSeal.Size = new System.Drawing.Size(40, 40);
            this.deathSeal.TabIndex = 63;
            this.deathSeal.TabStop = false;
            // 
            // bookOfTheDead
            // 
            this.bookOfTheDead.Image = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
            this.bookOfTheDead.Location = new System.Drawing.Point(160, 0);
            this.bookOfTheDead.Margin = new System.Windows.Forms.Padding(0);
            this.bookOfTheDead.Name = "bookOfTheDead";
            this.bookOfTheDead.Size = new System.Drawing.Size(40, 40);
            this.bookOfTheDead.TabIndex = 69;
            this.bookOfTheDead.TabStop = false;
            // 
            // ring
            // 
            this.ring.Image = global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
            this.ring.Location = new System.Drawing.Point(200, 0);
            this.ring.Margin = new System.Windows.Forms.Padding(0);
            this.ring.Name = "ring";
            this.ring.Size = new System.Drawing.Size(40, 40);
            this.ring.TabIndex = 55;
            this.ring.TabStop = false;
            // 
            // fairyClothes
            // 
            this.fairyClothes.Image = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
            this.fairyClothes.Location = new System.Drawing.Point(240, 0);
            this.fairyClothes.Margin = new System.Windows.Forms.Padding(0);
            this.fairyClothes.Name = "fairyClothes";
            this.fairyClothes.Size = new System.Drawing.Size(40, 40);
            this.fairyClothes.TabIndex = 72;
            this.fairyClothes.TabStop = false;
            // 
            // msx2
            // 
            this.msx2.Image = global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
            this.msx2.Location = new System.Drawing.Point(280, 0);
            this.msx2.Margin = new System.Windows.Forms.Padding(0);
            this.msx2.Name = "msx2";
            this.msx2.Size = new System.Drawing.Size(40, 40);
            this.msx2.TabIndex = 91;
            this.msx2.TabStop = false;
            // 
            // scriptures
            // 
            this.scriptures.Image = global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
            this.scriptures.Location = new System.Drawing.Point(0, 40);
            this.scriptures.Margin = new System.Windows.Forms.Padding(0);
            this.scriptures.Name = "scriptures";
            this.scriptures.Size = new System.Drawing.Size(40, 40);
            this.scriptures.TabIndex = 70;
            this.scriptures.TabStop = false;
            // 
            // crucifix
            // 
            this.crucifix.Image = global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
            this.crucifix.Location = new System.Drawing.Point(40, 40);
            this.crucifix.Margin = new System.Windows.Forms.Padding(0);
            this.crucifix.Name = "crucifix";
            this.crucifix.Size = new System.Drawing.Size(40, 40);
            this.crucifix.TabIndex = 71;
            this.crucifix.TabStop = false;
            // 
            // perfume
            // 
            this.perfume.Image = global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
            this.perfume.Location = new System.Drawing.Point(80, 40);
            this.perfume.Margin = new System.Windows.Forms.Padding(0);
            this.perfume.Name = "perfume";
            this.perfume.Size = new System.Drawing.Size(40, 40);
            this.perfume.TabIndex = 92;
            this.perfume.TabStop = false;
            // 
            // glove
            // 
            this.glove.Image = global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
            this.glove.Location = new System.Drawing.Point(120, 40);
            this.glove.Margin = new System.Windows.Forms.Padding(0);
            this.glove.Name = "glove";
            this.glove.Size = new System.Drawing.Size(40, 40);
            this.glove.TabIndex = 88;
            this.glove.TabStop = false;
            // 
            // bracelet
            // 
            this.bracelet.Image = global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
            this.bracelet.Location = new System.Drawing.Point(160, 40);
            this.bracelet.Margin = new System.Windows.Forms.Padding(0);
            this.bracelet.Name = "bracelet";
            this.bracelet.Size = new System.Drawing.Size(40, 40);
            this.bracelet.TabIndex = 73;
            this.bracelet.TabStop = false;
            // 
            // spaulder
            // 
            this.spaulder.Image = global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
            this.spaulder.Location = new System.Drawing.Point(200, 40);
            this.spaulder.Margin = new System.Windows.Forms.Padding(0);
            this.spaulder.Name = "spaulder";
            this.spaulder.Size = new System.Drawing.Size(40, 40);
            this.spaulder.TabIndex = 100;
            this.spaulder.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.whipsPanel);
            this.flowLayoutPanel4.Controls.Add(this.knife);
            this.flowLayoutPanel4.Controls.Add(this.axe);
            this.flowLayoutPanel4.Controls.Add(this.katana);
            this.flowLayoutPanel4.Controls.Add(this.shieldsPanel);
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
            this.flowLayoutPanel4.Location = new System.Drawing.Point(10, 386);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(320, 80);
            this.flowLayoutPanel4.TabIndex = 115;
            this.flowLayoutPanel4.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // knife
            // 
            this.knife.Image = global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
            this.knife.Location = new System.Drawing.Point(40, 0);
            this.knife.Margin = new System.Windows.Forms.Padding(0);
            this.knife.Name = "knife";
            this.knife.Size = new System.Drawing.Size(40, 40);
            this.knife.TabIndex = 90;
            this.knife.TabStop = false;
            // 
            // axe
            // 
            this.axe.Image = global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
            this.axe.Location = new System.Drawing.Point(80, 0);
            this.axe.Margin = new System.Windows.Forms.Padding(0);
            this.axe.Name = "axe";
            this.axe.Size = new System.Drawing.Size(40, 40);
            this.axe.TabIndex = 81;
            this.axe.TabStop = false;
            // 
            // katana
            // 
            this.katana.Image = global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
            this.katana.Location = new System.Drawing.Point(120, 0);
            this.katana.Margin = new System.Windows.Forms.Padding(0);
            this.katana.Name = "katana";
            this.katana.Size = new System.Drawing.Size(40, 40);
            this.katana.TabIndex = 89;
            this.katana.TabStop = false;
            // 
            // gauntlet
            // 
            this.gauntlet.Image = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
            this.gauntlet.Location = new System.Drawing.Point(200, 0);
            this.gauntlet.Margin = new System.Windows.Forms.Padding(0);
            this.gauntlet.Name = "gauntlet";
            this.gauntlet.Size = new System.Drawing.Size(40, 40);
            this.gauntlet.TabIndex = 74;
            this.gauntlet.TabStop = false;
            // 
            // pistolPanel
            // 
            this.pistolPanel.Controls.Add(this.pistolAmmoCount);
            this.pistolPanel.Controls.Add(this.pistol);
            this.pistolPanel.Location = new System.Drawing.Point(240, 0);
            this.pistolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pistolPanel.Name = "pistolPanel";
            this.pistolPanel.Size = new System.Drawing.Size(40, 40);
            this.pistolPanel.TabIndex = 109;
            // 
            // pistolAmmoCount
            // 
            this.pistolAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pistolAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.pistolAmmoCount.Name = "pistolAmmoCount";
            this.pistolAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pistolAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.pistolAmmoCount.TabIndex = 68;
            this.pistolAmmoCount.Text = "0:0";
            this.pistolAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pistolAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // pistol
            // 
            this.pistol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pistol.Image = global::LMRItemTracker.Properties.Resources.Icon_pistol_blank;
            this.pistol.Location = new System.Drawing.Point(0, 0);
            this.pistol.Margin = new System.Windows.Forms.Padding(0);
            this.pistol.Name = "pistol";
            this.pistol.Size = new System.Drawing.Size(40, 40);
            this.pistol.TabIndex = 93;
            this.pistol.TabStop = false;
            // 
            // shurikenPanel
            // 
            this.shurikenPanel.Controls.Add(this.shurikenAmmoCount);
            this.shurikenPanel.Controls.Add(this.shuriken);
            this.shurikenPanel.Location = new System.Drawing.Point(280, 0);
            this.shurikenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.shurikenPanel.Name = "shurikenPanel";
            this.shurikenPanel.Size = new System.Drawing.Size(40, 40);
            this.shurikenPanel.TabIndex = 110;
            // 
            // shurikenAmmoCount
            // 
            this.shurikenAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.shurikenAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.shurikenAmmoCount.Name = "shurikenAmmoCount";
            this.shurikenAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shurikenAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.shurikenAmmoCount.TabIndex = 94;
            this.shurikenAmmoCount.Text = "0";
            this.shurikenAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shurikenAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // shuriken
            // 
            this.shuriken.Dock = System.Windows.Forms.DockStyle.Top;
            this.shuriken.Image = global::LMRItemTracker.Properties.Resources.Icon_shuriken_blank;
            this.shuriken.Location = new System.Drawing.Point(0, 0);
            this.shuriken.Margin = new System.Windows.Forms.Padding(0);
            this.shuriken.Name = "shuriken";
            this.shuriken.Size = new System.Drawing.Size(40, 40);
            this.shuriken.TabIndex = 97;
            this.shuriken.TabStop = false;
            // 
            // rollingShurikenPanel
            // 
            this.rollingShurikenPanel.Controls.Add(this.rollingShurikenAmmoCount);
            this.rollingShurikenPanel.Controls.Add(this.rollingShuriken);
            this.rollingShurikenPanel.Location = new System.Drawing.Point(0, 40);
            this.rollingShurikenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rollingShurikenPanel.Name = "rollingShurikenPanel";
            this.rollingShurikenPanel.Size = new System.Drawing.Size(40, 40);
            this.rollingShurikenPanel.TabIndex = 111;
            // 
            // rollingShurikenAmmoCount
            // 
            this.rollingShurikenAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rollingShurikenAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.rollingShurikenAmmoCount.Name = "rollingShurikenAmmoCount";
            this.rollingShurikenAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rollingShurikenAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.rollingShurikenAmmoCount.TabIndex = 98;
            this.rollingShurikenAmmoCount.Text = "0";
            this.rollingShurikenAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rollingShurikenAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // rollingShuriken
            // 
            this.rollingShuriken.Dock = System.Windows.Forms.DockStyle.Top;
            this.rollingShuriken.Image = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_blank;
            this.rollingShuriken.Location = new System.Drawing.Point(0, 0);
            this.rollingShuriken.Margin = new System.Windows.Forms.Padding(0);
            this.rollingShuriken.Name = "rollingShuriken";
            this.rollingShuriken.Size = new System.Drawing.Size(40, 40);
            this.rollingShuriken.TabIndex = 98;
            this.rollingShuriken.TabStop = false;
            // 
            // caltropsPanel
            // 
            this.caltropsPanel.Controls.Add(this.caltropsAmmoCount);
            this.caltropsPanel.Controls.Add(this.caltrops);
            this.caltropsPanel.Location = new System.Drawing.Point(40, 40);
            this.caltropsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.caltropsPanel.Name = "caltropsPanel";
            this.caltropsPanel.Size = new System.Drawing.Size(40, 40);
            this.caltropsPanel.TabIndex = 112;
            // 
            // caltropsAmmoCount
            // 
            this.caltropsAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.caltropsAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.caltropsAmmoCount.Name = "caltropsAmmoCount";
            this.caltropsAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.caltropsAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.caltropsAmmoCount.TabIndex = 99;
            this.caltropsAmmoCount.Text = "0";
            this.caltropsAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.caltropsAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // caltrops
            // 
            this.caltrops.Dock = System.Windows.Forms.DockStyle.Top;
            this.caltrops.Image = global::LMRItemTracker.Properties.Resources.Icon_caltrops_blank;
            this.caltrops.Location = new System.Drawing.Point(0, 0);
            this.caltrops.Margin = new System.Windows.Forms.Padding(0);
            this.caltrops.Name = "caltrops";
            this.caltrops.Size = new System.Drawing.Size(40, 40);
            this.caltrops.TabIndex = 99;
            this.caltrops.TabStop = false;
            // 
            // flareGunPanel
            // 
            this.flareGunPanel.Controls.Add(this.flareGunAmmoCount);
            this.flareGunPanel.Controls.Add(this.flareGun);
            this.flareGunPanel.Location = new System.Drawing.Point(80, 40);
            this.flareGunPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flareGunPanel.Name = "flareGunPanel";
            this.flareGunPanel.Size = new System.Drawing.Size(40, 40);
            this.flareGunPanel.TabIndex = 113;
            // 
            // flareGunAmmoCount
            // 
            this.flareGunAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.flareGunAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.flareGunAmmoCount.Name = "flareGunAmmoCount";
            this.flareGunAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flareGunAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.flareGunAmmoCount.TabIndex = 112;
            this.flareGunAmmoCount.Text = "0";
            this.flareGunAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.flareGunAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // flareGun
            // 
            this.flareGun.Dock = System.Windows.Forms.DockStyle.Top;
            this.flareGun.Image = global::LMRItemTracker.Properties.Resources.Icon_flaregun_blank;
            this.flareGun.Location = new System.Drawing.Point(0, 0);
            this.flareGun.Margin = new System.Windows.Forms.Padding(0);
            this.flareGun.Name = "flareGun";
            this.flareGun.Size = new System.Drawing.Size(40, 40);
            this.flareGun.TabIndex = 86;
            this.flareGun.TabStop = false;
            // 
            // chakramPanel
            // 
            this.chakramPanel.Controls.Add(this.chakramAmmoCount);
            this.chakramPanel.Controls.Add(this.chakram);
            this.chakramPanel.Location = new System.Drawing.Point(120, 40);
            this.chakramPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chakramPanel.Name = "chakramPanel";
            this.chakramPanel.Size = new System.Drawing.Size(40, 40);
            this.chakramPanel.TabIndex = 114;
            // 
            // chakramAmmoCount
            // 
            this.chakramAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chakramAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.chakramAmmoCount.Name = "chakramAmmoCount";
            this.chakramAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chakramAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.chakramAmmoCount.TabIndex = 112;
            this.chakramAmmoCount.Text = "0";
            this.chakramAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chakramAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // chakram
            // 
            this.chakram.Dock = System.Windows.Forms.DockStyle.Top;
            this.chakram.Image = global::LMRItemTracker.Properties.Resources.Icon_chakram_blank;
            this.chakram.Location = new System.Drawing.Point(0, 0);
            this.chakram.Margin = new System.Windows.Forms.Padding(0);
            this.chakram.Name = "chakram";
            this.chakram.Size = new System.Drawing.Size(40, 40);
            this.chakram.TabIndex = 83;
            this.chakram.TabStop = false;
            // 
            // earthSpearPanel
            // 
            this.earthSpearPanel.Controls.Add(this.earthSpearAmmoCount);
            this.earthSpearPanel.Controls.Add(this.earthSpear);
            this.earthSpearPanel.Location = new System.Drawing.Point(160, 40);
            this.earthSpearPanel.Margin = new System.Windows.Forms.Padding(0);
            this.earthSpearPanel.Name = "earthSpearPanel";
            this.earthSpearPanel.Size = new System.Drawing.Size(40, 40);
            this.earthSpearPanel.TabIndex = 115;
            // 
            // earthSpearAmmoCount
            // 
            this.earthSpearAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.earthSpearAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.earthSpearAmmoCount.Name = "earthSpearAmmoCount";
            this.earthSpearAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.earthSpearAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.earthSpearAmmoCount.TabIndex = 112;
            this.earthSpearAmmoCount.Text = "0";
            this.earthSpearAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.earthSpearAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // earthSpear
            // 
            this.earthSpear.Dock = System.Windows.Forms.DockStyle.Top;
            this.earthSpear.Image = global::LMRItemTracker.Properties.Resources.Icon_earthspear_blank;
            this.earthSpear.Location = new System.Drawing.Point(0, 0);
            this.earthSpear.Margin = new System.Windows.Forms.Padding(0);
            this.earthSpear.Name = "earthSpear";
            this.earthSpear.Size = new System.Drawing.Size(40, 40);
            this.earthSpear.TabIndex = 85;
            this.earthSpear.TabStop = false;
            // 
            // bombPanel
            // 
            this.bombPanel.Controls.Add(this.bombAmmoCount);
            this.bombPanel.Controls.Add(this.bomb);
            this.bombPanel.Location = new System.Drawing.Point(200, 40);
            this.bombPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bombPanel.Name = "bombPanel";
            this.bombPanel.Size = new System.Drawing.Size(40, 40);
            this.bombPanel.TabIndex = 116;
            // 
            // bombAmmoCount
            // 
            this.bombAmmoCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bombAmmoCount.Location = new System.Drawing.Point(0, 40);
            this.bombAmmoCount.Name = "bombAmmoCount";
            this.bombAmmoCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombAmmoCount.Size = new System.Drawing.Size(40, 16);
            this.bombAmmoCount.TabIndex = 112;
            this.bombAmmoCount.Text = "0";
            this.bombAmmoCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bombAmmoCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // bomb
            // 
            this.bomb.Dock = System.Windows.Forms.DockStyle.Top;
            this.bomb.Image = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            this.bomb.Location = new System.Drawing.Point(0, 0);
            this.bomb.Margin = new System.Windows.Forms.Padding(0);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(40, 40);
            this.bomb.TabIndex = 54;
            this.bomb.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.ocarina);
            this.flowLayoutPanel5.Controls.Add(this.mantra);
            this.flowLayoutPanel5.Controls.Add(this.vesselPanel);
            this.flowLayoutPanel5.Controls.Add(this.keySword);
            this.flowLayoutPanel5.Controls.Add(this.lampOfTimePanel);
            this.flowLayoutPanel5.Controls.Add(this.mapsPanel);
            this.flowLayoutPanel5.Controls.Add(this.ankhJewelPanel);
            this.mainPanel.SetFlowBreak(this.flowLayoutPanel5, true);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(10, 474);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(280, 56);
            this.flowLayoutPanel5.TabIndex = 115;
            this.flowLayoutPanel5.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // ocarina
            // 
            this.ocarina.Image = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            this.ocarina.Location = new System.Drawing.Point(0, 0);
            this.ocarina.Margin = new System.Windows.Forms.Padding(0);
            this.ocarina.Name = "ocarina";
            this.ocarina.Size = new System.Drawing.Size(40, 40);
            this.ocarina.TabIndex = 30;
            this.ocarina.TabStop = false;
            // 
            // mantra
            // 
            this.mantra.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantra.Location = new System.Drawing.Point(40, 0);
            this.mantra.Margin = new System.Windows.Forms.Padding(0);
            this.mantra.Name = "mantra";
            this.mantra.Size = new System.Drawing.Size(40, 40);
            this.mantra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mantra.TabIndex = 31;
            this.mantra.TabStop = false;
            // 
            // vesselPanel
            // 
            this.vesselPanel.Controls.Add(this.vessel);
            this.vesselPanel.Controls.Add(this.vesselNotFound);
            this.vesselPanel.Location = new System.Drawing.Point(80, 0);
            this.vesselPanel.Margin = new System.Windows.Forms.Padding(0);
            this.vesselPanel.Name = "vesselPanel";
            this.vesselPanel.Size = new System.Drawing.Size(40, 40);
            this.vesselPanel.TabIndex = 116;
            // 
            // vessel
            // 
            this.vessel.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel;
            this.vessel.Location = new System.Drawing.Point(0, 0);
            this.vessel.Name = "vessel";
            this.vessel.Size = new System.Drawing.Size(40, 40);
            this.vessel.TabIndex = 34;
            this.vessel.TabStop = false;
            // 
            // vesselNotFound
            // 
            this.vesselNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            this.vesselNotFound.Location = new System.Drawing.Point(0, 0);
            this.vesselNotFound.Margin = new System.Windows.Forms.Padding(0);
            this.vesselNotFound.Name = "vesselNotFound";
            this.vesselNotFound.Size = new System.Drawing.Size(40, 40);
            this.vesselNotFound.TabIndex = 66;
            this.vesselNotFound.TabStop = false;
            // 
            // keySword
            // 
            this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
            this.keySword.Location = new System.Drawing.Point(120, 0);
            this.keySword.Margin = new System.Windows.Forms.Padding(0);
            this.keySword.Name = "keySword";
            this.keySword.Size = new System.Drawing.Size(40, 40);
            this.keySword.TabIndex = 33;
            this.keySword.TabStop = false;
            // 
            // lampOfTimePanel
            // 
            this.lampOfTimePanel.Controls.Add(this.lampOfTimeNotFound);
            this.lampOfTimePanel.Controls.Add(this.lampOfTime);
            this.lampOfTimePanel.Location = new System.Drawing.Point(160, 0);
            this.lampOfTimePanel.Margin = new System.Windows.Forms.Padding(0);
            this.lampOfTimePanel.Name = "lampOfTimePanel";
            this.lampOfTimePanel.Size = new System.Drawing.Size(40, 40);
            this.lampOfTimePanel.TabIndex = 112;
            // 
            // lampOfTimeNotFound
            // 
            this.lampOfTimeNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            this.lampOfTimeNotFound.Location = new System.Drawing.Point(0, 0);
            this.lampOfTimeNotFound.Margin = new System.Windows.Forms.Padding(0);
            this.lampOfTimeNotFound.Name = "lampOfTimeNotFound";
            this.lampOfTimeNotFound.Size = new System.Drawing.Size(40, 40);
            this.lampOfTimeNotFound.TabIndex = 59;
            this.lampOfTimeNotFound.TabStop = false;
            // 
            // lampOfTime
            // 
            this.lampOfTime.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit;
            this.lampOfTime.Location = new System.Drawing.Point(0, 0);
            this.lampOfTime.Margin = new System.Windows.Forms.Padding(0);
            this.lampOfTime.Name = "lampOfTime";
            this.lampOfTime.Size = new System.Drawing.Size(40, 40);
            this.lampOfTime.TabIndex = 64;
            this.lampOfTime.TabStop = false;
            // 
            // mapsPanel
            // 
            this.mapsPanel.Controls.Add(this.mapCount);
            this.mapsPanel.Controls.Add(this.maps);
            this.mapsPanel.Location = new System.Drawing.Point(200, 0);
            this.mapsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mapsPanel.Name = "mapsPanel";
            this.mapsPanel.Size = new System.Drawing.Size(40, 56);
            this.mapsPanel.TabIndex = 113;
            // 
            // mapCount
            // 
            this.mapCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapCount.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mapCount.Location = new System.Drawing.Point(-6, 40);
            this.mapCount.Name = "mapCount";
            this.mapCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mapCount.Size = new System.Drawing.Size(52, 16);
            this.mapCount.TabIndex = 23;
            this.mapCount.Text = "0/17";
            this.mapCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mapCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // maps
            // 
            this.maps.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Dock = System.Windows.Forms.DockStyle.Top;
            this.maps.Location = new System.Drawing.Point(0, 0);
            this.maps.Margin = new System.Windows.Forms.Padding(0);
            this.maps.Name = "maps";
            this.maps.Size = new System.Drawing.Size(40, 40);
            this.maps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maps.TabIndex = 24;
            this.maps.TabStop = false;
            // 
            // ankhJewelPanel
            // 
            this.ankhJewelPanel.Controls.Add(this.ankhJewels);
            this.ankhJewelPanel.Controls.Add(this.ankhJewelCount);
            this.ankhJewelPanel.Location = new System.Drawing.Point(240, 0);
            this.ankhJewelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ankhJewelPanel.Name = "ankhJewelPanel";
            this.ankhJewelPanel.Size = new System.Drawing.Size(40, 56);
            this.ankhJewelPanel.TabIndex = 114;
            // 
            // ankhJewels
            // 
            this.ankhJewels.Dock = System.Windows.Forms.DockStyle.Top;
            this.ankhJewels.Image = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            this.ankhJewels.Location = new System.Drawing.Point(0, 0);
            this.ankhJewels.Margin = new System.Windows.Forms.Padding(0);
            this.ankhJewels.Name = "ankhJewels";
            this.ankhJewels.Size = new System.Drawing.Size(40, 40);
            this.ankhJewels.TabIndex = 29;
            this.ankhJewels.TabStop = false;
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
            this.flowLayoutPanel6.Location = new System.Drawing.Point(10, 538);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(320, 120);
            this.flowLayoutPanel6.TabIndex = 120;
            // 
            // shellHorn
            // 
            this.shellHorn.Image = global::LMRItemTracker.Properties.Resources.Icon_shellhorn_blank;
            this.shellHorn.Location = new System.Drawing.Point(0, 0);
            this.shellHorn.Margin = new System.Windows.Forms.Padding(0);
            this.shellHorn.Name = "shellHorn";
            this.shellHorn.Size = new System.Drawing.Size(40, 40);
            this.shellHorn.TabIndex = 112;
            this.shellHorn.TabStop = false;
            // 
            // waterproofCase
            // 
            this.waterproofCase.Image = global::LMRItemTracker.Properties.Resources.Icon_waterproofcase_blank;
            this.waterproofCase.Location = new System.Drawing.Point(40, 0);
            this.waterproofCase.Margin = new System.Windows.Forms.Padding(0);
            this.waterproofCase.Name = "waterproofCase";
            this.waterproofCase.Size = new System.Drawing.Size(40, 40);
            this.waterproofCase.TabIndex = 117;
            this.waterproofCase.TabStop = false;
            // 
            // heatproofCase
            // 
            this.heatproofCase.Image = global::LMRItemTracker.Properties.Resources.Icon_heatproofcase_blank;
            this.heatproofCase.Location = new System.Drawing.Point(80, 0);
            this.heatproofCase.Margin = new System.Windows.Forms.Padding(0);
            this.heatproofCase.Name = "heatproofCase";
            this.heatproofCase.Size = new System.Drawing.Size(40, 40);
            this.heatproofCase.TabIndex = 118;
            this.heatproofCase.TabStop = false;
            // 
            // swimsuit
            // 
            this.swimsuit.Image = global::LMRItemTracker.Properties.Resources.Icon_swimsuit_blank;
            this.swimsuit.Location = new System.Drawing.Point(120, 0);
            this.swimsuit.Margin = new System.Windows.Forms.Padding(0);
            this.swimsuit.Name = "swimsuit";
            this.swimsuit.Size = new System.Drawing.Size(40, 40);
            this.swimsuit.TabIndex = 121;
            this.swimsuit.TabStop = false;
            // 
            // djedPillar
            // 
            this.djedPillar.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_blank;
            this.djedPillar.Location = new System.Drawing.Point(160, 0);
            this.djedPillar.Margin = new System.Windows.Forms.Padding(0);
            this.djedPillar.Name = "djedPillar";
            this.djedPillar.Size = new System.Drawing.Size(40, 40);
            this.djedPillar.TabIndex = 119;
            this.djedPillar.TabStop = false;
            // 
            // mantraSingle
            // 
            this.mantraSingle.Image = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantraSingle.Location = new System.Drawing.Point(200, 0);
            this.mantraSingle.Margin = new System.Windows.Forms.Padding(0);
            this.mantraSingle.Name = "mantraSingle";
            this.mantraSingle.Size = new System.Drawing.Size(40, 40);
            this.mantraSingle.TabIndex = 120;
            this.mantraSingle.TabStop = false;
            // 
            // xmailer
            // 
            this.xmailer.Image = global::LMRItemTracker.Properties.Resources.Icon_xmailer_blank;
            this.xmailer.Location = new System.Drawing.Point(240, 0);
            this.xmailer.Margin = new System.Windows.Forms.Padding(0);
            this.xmailer.Name = "xmailer";
            this.xmailer.Size = new System.Drawing.Size(40, 40);
            this.xmailer.TabIndex = 122;
            this.xmailer.TabStop = false;
            // 
            // yagomap
            // 
            this.yagomap.Image = global::LMRItemTracker.Properties.Resources.Icon_yagomap_blank;
            this.yagomap.Location = new System.Drawing.Point(280, 0);
            this.yagomap.Margin = new System.Windows.Forms.Padding(0);
            this.yagomap.Name = "yagomap";
            this.yagomap.Size = new System.Drawing.Size(40, 40);
            this.yagomap.TabIndex = 123;
            this.yagomap.TabStop = false;
            // 
            // yagostr
            // 
            this.yagostr.Image = global::LMRItemTracker.Properties.Resources.Icon_yagostr_blank;
            this.yagostr.Location = new System.Drawing.Point(0, 40);
            this.yagostr.Margin = new System.Windows.Forms.Padding(0);
            this.yagostr.Name = "yagostr";
            this.yagostr.Size = new System.Drawing.Size(40, 40);
            this.yagostr.TabIndex = 124;
            this.yagostr.TabStop = false;
            // 
            // bunemon
            // 
            this.bunemon.Image = global::LMRItemTracker.Properties.Resources.Icon_bunemon_blank;
            this.bunemon.Location = new System.Drawing.Point(40, 40);
            this.bunemon.Margin = new System.Windows.Forms.Padding(0);
            this.bunemon.Name = "bunemon";
            this.bunemon.Size = new System.Drawing.Size(40, 40);
            this.bunemon.TabIndex = 125;
            this.bunemon.TabStop = false;
            // 
            // bunplus
            // 
            this.bunplus.Image = global::LMRItemTracker.Properties.Resources.Icon_bunplus_blank;
            this.bunplus.Location = new System.Drawing.Point(80, 40);
            this.bunplus.Margin = new System.Windows.Forms.Padding(0);
            this.bunplus.Name = "bunplus";
            this.bunplus.Size = new System.Drawing.Size(40, 40);
            this.bunplus.TabIndex = 126;
            this.bunplus.TabStop = false;
            // 
            // guild
            // 
            this.guild.Image = global::LMRItemTracker.Properties.Resources.Icon_guild_blank;
            this.guild.Location = new System.Drawing.Point(120, 40);
            this.guild.Margin = new System.Windows.Forms.Padding(0);
            this.guild.Name = "guild";
            this.guild.Size = new System.Drawing.Size(40, 40);
            this.guild.TabIndex = 127;
            this.guild.TabStop = false;
            // 
            // beolamu
            // 
            this.beolamu.Image = global::LMRItemTracker.Properties.Resources.Icon_beolamu_blank;
            this.beolamu.Location = new System.Drawing.Point(160, 40);
            this.beolamu.Margin = new System.Windows.Forms.Padding(0);
            this.beolamu.Name = "beolamu";
            this.beolamu.Size = new System.Drawing.Size(40, 40);
            this.beolamu.TabIndex = 129;
            this.beolamu.TabStop = false;
            // 
            // emusic
            // 
            this.emusic.Image = global::LMRItemTracker.Properties.Resources.Icon_emusic_blank;
            this.emusic.Location = new System.Drawing.Point(200, 40);
            this.emusic.Margin = new System.Windows.Forms.Padding(0);
            this.emusic.Name = "emusic";
            this.emusic.Size = new System.Drawing.Size(40, 40);
            this.emusic.TabIndex = 128;
            this.emusic.TabStop = false;
            // 
            // randc
            // 
            this.randc.Image = global::LMRItemTracker.Properties.Resources.Icon_randc_blank;
            this.randc.Location = new System.Drawing.Point(240, 40);
            this.randc.Margin = new System.Windows.Forms.Padding(0);
            this.randc.Name = "randc";
            this.randc.Size = new System.Drawing.Size(40, 40);
            this.randc.TabIndex = 130;
            this.randc.TabStop = false;
            // 
            // capstar
            // 
            this.capstar.Image = global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            this.capstar.Location = new System.Drawing.Point(280, 40);
            this.capstar.Margin = new System.Windows.Forms.Padding(0);
            this.capstar.Name = "capstar";
            this.capstar.Size = new System.Drawing.Size(40, 40);
            this.capstar.TabIndex = 131;
            this.capstar.TabStop = false;
            // 
            // deathv
            // 
            this.deathv.Image = global::LMRItemTracker.Properties.Resources.Icon_deathv_blank;
            this.deathv.Location = new System.Drawing.Point(0, 80);
            this.deathv.Margin = new System.Windows.Forms.Padding(0);
            this.deathv.Name = "deathv";
            this.deathv.Size = new System.Drawing.Size(40, 40);
            this.deathv.TabIndex = 132;
            this.deathv.TabStop = false;
            // 
            // move
            // 
            this.move.Image = global::LMRItemTracker.Properties.Resources.Icon_move_blank;
            this.move.Location = new System.Drawing.Point(40, 80);
            this.move.Margin = new System.Windows.Forms.Padding(0);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(40, 40);
            this.move.TabIndex = 133;
            this.move.TabStop = false;
            // 
            // mekuri
            // 
            this.mekuri.Image = global::LMRItemTracker.Properties.Resources.Icon_mekuri_blank;
            this.mekuri.Location = new System.Drawing.Point(80, 80);
            this.mekuri.Margin = new System.Windows.Forms.Padding(0);
            this.mekuri.Name = "mekuri";
            this.mekuri.Size = new System.Drawing.Size(40, 40);
            this.mekuri.TabIndex = 134;
            this.mekuri.TabStop = false;
            // 
            // bounce
            // 
            this.bounce.Image = global::LMRItemTracker.Properties.Resources.Icon_bounce_blank;
            this.bounce.Location = new System.Drawing.Point(120, 80);
            this.bounce.Margin = new System.Windows.Forms.Padding(0);
            this.bounce.Name = "bounce";
            this.bounce.Size = new System.Drawing.Size(40, 40);
            this.bounce.TabIndex = 135;
            this.bounce.TabStop = false;
            // 
            // miracle
            // 
            this.miracle.Image = global::LMRItemTracker.Properties.Resources.Icon_miracle_blank;
            this.miracle.Location = new System.Drawing.Point(160, 80);
            this.miracle.Margin = new System.Windows.Forms.Padding(0);
            this.miracle.Name = "miracle";
            this.miracle.Size = new System.Drawing.Size(40, 40);
            this.miracle.TabIndex = 136;
            this.miracle.TabStop = false;
            // 
            // lamulana
            // 
            this.lamulana.Image = global::LMRItemTracker.Properties.Resources.Icon_lamulana_blank;
            this.lamulana.Location = new System.Drawing.Point(200, 80);
            this.lamulana.Margin = new System.Windows.Forms.Padding(0);
            this.lamulana.Name = "lamulana";
            this.lamulana.Size = new System.Drawing.Size(40, 40);
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
            this.bossPanel.Location = new System.Drawing.Point(10, 666);
            this.bossPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bossPanel.MaximumSize = new System.Drawing.Size(280, 0);
            this.bossPanel.Name = "bossPanel";
            this.bossPanel.Size = new System.Drawing.Size(280, 34);
            this.bossPanel.TabIndex = 112;
            this.bossPanel.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            // 
            // amphisbaena
            // 
            this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
            this.amphisbaena.Location = new System.Drawing.Point(0, 0);
            this.amphisbaena.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.amphisbaena.Name = "amphisbaena";
            this.amphisbaena.Size = new System.Drawing.Size(34, 34);
            this.amphisbaena.TabIndex = 13;
            this.amphisbaena.TabStop = false;
            // 
            // sakit
            // 
            this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
            this.sakit.Location = new System.Drawing.Point(35, 0);
            this.sakit.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.sakit.Name = "sakit";
            this.sakit.Size = new System.Drawing.Size(34, 34);
            this.sakit.TabIndex = 8;
            this.sakit.TabStop = false;
            // 
            // ellmac
            // 
            this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
            this.ellmac.Location = new System.Drawing.Point(70, 0);
            this.ellmac.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.ellmac.Name = "ellmac";
            this.ellmac.Size = new System.Drawing.Size(34, 34);
            this.ellmac.TabIndex = 17;
            this.ellmac.TabStop = false;
            // 
            // bahamut
            // 
            this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
            this.bahamut.Location = new System.Drawing.Point(105, 0);
            this.bahamut.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.bahamut.Name = "bahamut";
            this.bahamut.Size = new System.Drawing.Size(34, 34);
            this.bahamut.TabIndex = 18;
            this.bahamut.TabStop = false;
            // 
            // viy
            // 
            this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
            this.viy.Location = new System.Drawing.Point(140, 0);
            this.viy.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.viy.Name = "viy";
            this.viy.Size = new System.Drawing.Size(34, 34);
            this.viy.TabIndex = 22;
            this.viy.TabStop = false;
            // 
            // palenque
            // 
            this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
            this.palenque.Location = new System.Drawing.Point(175, 0);
            this.palenque.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.palenque.Name = "palenque";
            this.palenque.Size = new System.Drawing.Size(34, 34);
            this.palenque.TabIndex = 21;
            this.palenque.TabStop = false;
            // 
            // baphomet
            // 
            this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
            this.baphomet.Location = new System.Drawing.Point(210, 0);
            this.baphomet.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.baphomet.Name = "baphomet";
            this.baphomet.Size = new System.Drawing.Size(34, 34);
            this.baphomet.TabIndex = 20;
            this.baphomet.TabStop = false;
            // 
            // tiamat
            // 
            this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
            this.tiamat.Location = new System.Drawing.Point(245, 0);
            this.tiamat.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.tiamat.Name = "tiamat";
            this.tiamat.Size = new System.Drawing.Size(34, 34);
            this.tiamat.TabIndex = 19;
            this.tiamat.TabStop = false;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.LaMulanaItemTrackerForm_Load);
            this.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            this.shieldsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buckler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeSilverShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverShield)).EndInit();
            this.whipsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flailWhip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainWhip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whip)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).EndInit();
            this.readerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reader)).EndInit();
            this.grailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grailBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grailFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
            this.womanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maternityStatue)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.knife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).EndInit();
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
            this.vesselPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).EndInit();
            this.lampOfTimePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).EndInit();
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

        private PictureBox scanner;
        private PictureBox reader;
        private PictureBox sakit;
        private PictureBox amphisbaena;
        private PictureBox ellmac;
        private PictureBox bahamut;
        private PictureBox tiamat;
        private PictureBox baphomet;
        private PictureBox palenque;
        private PictureBox viy;
        private PictureBox maps;
        private PictureBox mulanaTalisman;
        private PictureBox talisman;

        private Boolean mantrasRecited;
        private Boolean keySwordCollected;
        private Boolean miracleCollected;
        private Boolean mekuriCollected;
        private Boolean gameStarted;

        private bool whipCollected;
        private bool chainWhipCollected;
        private bool flailWhipCollected;

        private bool bucklerCollected;
        private bool fakeShieldCollected;
        private bool silverShieldCollected;
        private bool angelShieldCollected;

        private List<String> allItems;
        private SettingsBackup settingsBackup;

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new LMRItemTracker.LaMulanaItemTrackerForm());
        }

        private ColorDialog textColorDialog;
        private PictureBox ankhJewels;
        private Label ankhJewelCount;
        private PictureBox ocarina;
        private PictureBox mantra;
        private PictureBox keySword;
        private PictureBox vessel;
        private PictureBox skullWall;
        private PictureBox bronzeMirror;
        private PictureBox fruitOfEden;
        private PictureBox twinStatue;
        private PictureBox keyOfEternity;
        private PictureBox isisPendant;
        private PictureBox grappleClaw;
        private PictureBox hermesBoots;
        private PictureBox feather;
        private PictureBox treasures;
        private Label translationTablets;
        private PictureBox keyFairy;
        private PictureBox helmet;
        private PictureBox planeModel;
        private PictureBox cogOfTheSoul;
        private PictureBox bomb;
        private PictureBox ring;
        private PictureBox dimensionalKey;
        private PictureBox crystalSkull;
        private PictureBox lampOfTimeNotFound;
        private ColorDialog formColorDialog;
        private PictureBox originSeal;
        private PictureBox birthSeal;
        private PictureBox lifeSeal;
        private PictureBox deathSeal;
        private PictureBox lampOfTime;
        private PictureBox pochetteKey;
        private PictureBox vesselNotFound;
        private Label skullWallCount;
        private PictureBox dragonBone;
        private PictureBox bookOfTheDead;
        private PictureBox scriptures;
        private PictureBox crucifix;
        private PictureBox fairyClothes;
        private PictureBox bracelet;
        private PictureBox gauntlet;
        private PictureBox pepper;
        private PictureBox eyeOfTruth;
        private PictureBox miniDoll;
        private PictureBox magatamaJewel;
        private PictureBox iceCape;
        private PictureBox axe;
        private PictureBox buckler;
        private PictureBox chakram;
        private PictureBox whip;
        private PictureBox earthSpear;
        private PictureBox flareGun;
        private PictureBox anchor;
        private PictureBox glove;
        private PictureBox katana;
        private PictureBox knife;
        private PictureBox msx2;
        private PictureBox perfume;
        private PictureBox pistol;
        private PictureBox scalesphere;
        private PictureBox serpentStaff;
        private PictureBox torude;
        private PictureBox spaulder;
        private PictureBox fakeSilverShield;
        private PictureBox silverShield;
        private PictureBox shuriken;
        private PictureBox rollingShuriken;
        private PictureBox caltrops;
        private PictureBox angelShield;
        private PictureBox diary;
        private PictureBox chainWhip;
        private PictureBox flailWhip;
        private PictureBox womanStatue;
        private PictureBox maternityStatue;
        private Panel shieldsPanel;
        private Panel whipsPanel;
        private MenuStrip menu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveSettingsToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel readerPanel;
        private PictureBox grail;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripMenuItem layoutToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel mainPanel;
        private Panel lampOfTimePanel;
        private Panel mapsPanel;
        private Panel ankhJewelPanel;
        private Panel shrinePanel;
        private Panel womanPanel;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel vesselPanel;
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
        private Label mapCount;
        private PictureBox lastItem2;
        private PictureBox lastItem3;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem uncollectedItemsToolStripMenuItem;
        private ToolStripMenuItem noImageToolStripMenuItem;
        private ToolStripMenuItem shadedImageToolStripMenuItem;
        private ToolStripMenuItem showAmmoCountToolStripMenuItem;
        private Panel pistolPanel;
        private Label pistolAmmoCount;
        private Panel shurikenPanel;
        private Label shurikenAmmoCount;
        private Panel rollingShurikenPanel;
        private Label rollingShurikenAmmoCount;
        private Panel caltropsPanel;
        private Panel flareGunPanel;
        private Panel chakramPanel;
        private Panel earthSpearPanel;
        private Panel bombPanel;
        private Label caltropsAmmoCount;
        private Label flareGunAmmoCount;
        private Label chakramAmmoCount;
        private Label earthSpearAmmoCount;
        private Label bombAmmoCount;
        private Panel grailPanel;
        private PictureBox mirai;
        private PictureBox grailFull;
        private PictureBox grailBroken;
        private ToolStripMenuItem hideImageToolStripMenuItem;
        private PictureBox shellHorn;
        private PictureBox waterproofCase;
        private PictureBox heatproofCase;
        private PictureBox djedPillar;
        private PictureBox mantraSingle;
        private PictureBox swimsuit;
        private PictureBox xmailer;
        private PictureBox yagomap;
        private PictureBox yagostr;
        private PictureBox bunemon;
        private PictureBox bunplus;
        private PictureBox guild;
        private PictureBox emusic;
        private PictureBox beolamu;
        private PictureBox randc;
        private PictureBox capstar;
        private PictureBox deathv;
        private PictureBox move;
        private PictureBox mekuri;
        private PictureBox bounce;
        private PictureBox miracle;
        private PictureBox lamulana;
        private FlowLayoutPanel flowLayoutPanel6;
        private ToolStripMenuItem addItemPanel6ToolStripMenuItem;
        private ToolStripMenuItem showDeathCountToolStripMenuItem;
        private FlowLayoutPanel deathPanel;
        private Label deathLabel;
        private Label deathCount;
        private ToolStripMenuItem clearDeathCountToolStripMenuItem;
    }
}