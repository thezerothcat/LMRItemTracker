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
            this.mapCount = new System.Windows.Forms.Label();
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.ankhJewelCount = new System.Windows.Forms.Label();
            this.translationTablets = new System.Windows.Forms.Label();
            this.formColorDialog = new System.Windows.Forms.ColorDialog();
            this.skullWallCount = new System.Windows.Forms.Label();
            this.shields = new System.Windows.Forms.Panel();
            this.buckler = new System.Windows.Forms.PictureBox();
            this.angelShield = new System.Windows.Forms.PictureBox();
            this.fakeSilverShield = new System.Windows.Forms.PictureBox();
            this.silverShield = new System.Windows.Forms.PictureBox();
            this.maternityStatue = new System.Windows.Forms.PictureBox();
            this.flailWhip = new System.Windows.Forms.PictureBox();
            this.chainWhip = new System.Windows.Forms.PictureBox();
            this.spaulder = new System.Windows.Forms.PictureBox();
            this.caltrops = new System.Windows.Forms.PictureBox();
            this.rollingShuriken = new System.Windows.Forms.PictureBox();
            this.shuriken = new System.Windows.Forms.PictureBox();
            this.torude = new System.Windows.Forms.PictureBox();
            this.serpentStaff = new System.Windows.Forms.PictureBox();
            this.scalesphere = new System.Windows.Forms.PictureBox();
            this.pistol = new System.Windows.Forms.PictureBox();
            this.perfume = new System.Windows.Forms.PictureBox();
            this.msx2 = new System.Windows.Forms.PictureBox();
            this.knife = new System.Windows.Forms.PictureBox();
            this.katana = new System.Windows.Forms.PictureBox();
            this.glove = new System.Windows.Forms.PictureBox();
            this.anchor = new System.Windows.Forms.PictureBox();
            this.flareGun = new System.Windows.Forms.PictureBox();
            this.earthSpear = new System.Windows.Forms.PictureBox();
            this.whip = new System.Windows.Forms.PictureBox();
            this.chakram = new System.Windows.Forms.PictureBox();
            this.axe = new System.Windows.Forms.PictureBox();
            this.iceCape = new System.Windows.Forms.PictureBox();
            this.magatamaJewel = new System.Windows.Forms.PictureBox();
            this.miniDoll = new System.Windows.Forms.PictureBox();
            this.eyeOfTruth = new System.Windows.Forms.PictureBox();
            this.pepper = new System.Windows.Forms.PictureBox();
            this.womanStatue = new System.Windows.Forms.PictureBox();
            this.gauntlet = new System.Windows.Forms.PictureBox();
            this.bracelet = new System.Windows.Forms.PictureBox();
            this.fairyClothes = new System.Windows.Forms.PictureBox();
            this.crucifix = new System.Windows.Forms.PictureBox();
            this.scriptures = new System.Windows.Forms.PictureBox();
            this.bookOfTheDead = new System.Windows.Forms.PictureBox();
            this.dragonBone = new System.Windows.Forms.PictureBox();
            this.vesselNotFound = new System.Windows.Forms.PictureBox();
            this.pochetteKey = new System.Windows.Forms.PictureBox();
            this.deathSeal = new System.Windows.Forms.PictureBox();
            this.lifeSeal = new System.Windows.Forms.PictureBox();
            this.birthSeal = new System.Windows.Forms.PictureBox();
            this.originSeal = new System.Windows.Forms.PictureBox();
            this.lampOfTimeNotFound = new System.Windows.Forms.PictureBox();
            this.crystalSkull = new System.Windows.Forms.PictureBox();
            this.dimensionalKey = new System.Windows.Forms.PictureBox();
            this.ring = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.cogOfTheSoul = new System.Windows.Forms.PictureBox();
            this.planeModel = new System.Windows.Forms.PictureBox();
            this.helmet = new System.Windows.Forms.PictureBox();
            this.keyFairy = new System.Windows.Forms.PictureBox();
            this.treasures = new System.Windows.Forms.PictureBox();
            this.feather = new System.Windows.Forms.PictureBox();
            this.grappleClaw = new System.Windows.Forms.PictureBox();
            this.hermesBoots = new System.Windows.Forms.PictureBox();
            this.mirai = new System.Windows.Forms.PictureBox();
            this.isisPendant = new System.Windows.Forms.PictureBox();
            this.keyOfEternity = new System.Windows.Forms.PictureBox();
            this.twinStatue = new System.Windows.Forms.PictureBox();
            this.fruitOfEden = new System.Windows.Forms.PictureBox();
            this.bronzeMirror = new System.Windows.Forms.PictureBox();
            this.skullWall = new System.Windows.Forms.PictureBox();
            this.vessel = new System.Windows.Forms.PictureBox();
            this.keySword = new System.Windows.Forms.PictureBox();
            this.mantra = new System.Windows.Forms.PictureBox();
            this.ocarina = new System.Windows.Forms.PictureBox();
            this.ankhJewels = new System.Windows.Forms.PictureBox();
            this.mulanaTalisman = new System.Windows.Forms.PictureBox();
            this.diary = new System.Windows.Forms.PictureBox();
            this.talisman = new System.Windows.Forms.PictureBox();
            this.maps = new System.Windows.Forms.PictureBox();
            this.viy = new System.Windows.Forms.PictureBox();
            this.palenque = new System.Windows.Forms.PictureBox();
            this.baphomet = new System.Windows.Forms.PictureBox();
            this.tiamat = new System.Windows.Forms.PictureBox();
            this.bahamut = new System.Windows.Forms.PictureBox();
            this.ellmac = new System.Windows.Forms.PictureBox();
            this.amphisbaena = new System.Windows.Forms.PictureBox();
            this.sakit = new System.Windows.Forms.PictureBox();
            this.grail = new System.Windows.Forms.PictureBox();
            this.reader = new System.Windows.Forms.PictureBox();
            this.scanner = new System.Windows.Forms.PictureBox();
            this.lampOfTime = new System.Windows.Forms.PictureBox();
            this.whips = new System.Windows.Forms.Panel();
            this.shields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buckler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeSilverShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maternityStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flailWhip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainWhip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaulder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caltrops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollingShuriken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuriken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalesphere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flareGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthSpear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chakram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatamaJewel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOfTruth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauntlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairyClothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucifix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOfTheDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isisPendant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyOfEternity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twinStatue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOfEden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMirror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankhJewels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulanaTalisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talisman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palenque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baphomet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiamat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahamut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellmac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amphisbaena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTime)).BeginInit();
            this.whips.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapCount
            // 
            this.mapCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.mapCount.Location = new System.Drawing.Point(207, 492);
            this.mapCount.Name = "mapCount";
            this.mapCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mapCount.Size = new System.Drawing.Size(50, 16);
            this.mapCount.TabIndex = 23;
            this.mapCount.Text = "0/18";
            this.mapCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mapCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // textColorDialog
            // 
            this.textColorDialog.AnyColor = true;
            this.textColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.textColorDialog.SolidColorOnly = true;
            // 
            // ankhJewelCount
            // 
            this.ankhJewelCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ankhJewelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.ankhJewelCount.Location = new System.Drawing.Point(258, 492);
            this.ankhJewelCount.Name = "ankhJewelCount";
            this.ankhJewelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ankhJewelCount.Size = new System.Drawing.Size(30, 16);
            this.ankhJewelCount.TabIndex = 28;
            this.ankhJewelCount.Text = "0";
            this.ankhJewelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ankhJewelCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // translationTablets
            // 
            this.translationTablets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationTablets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.translationTablets.Location = new System.Drawing.Point(168, 52);
            this.translationTablets.Name = "translationTablets";
            this.translationTablets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.translationTablets.Size = new System.Drawing.Size(50, 16);
            this.translationTablets.TabIndex = 48;
            this.translationTablets.Text = "0/3";
            this.translationTablets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.translationTablets.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // formColorDialog
            // 
            this.formColorDialog.AnyColor = true;
            this.formColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.formColorDialog.SolidColorOnly = true;
            // 
            // skullWallCount
            // 
            this.skullWallCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skullWallCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.skullWallCount.Location = new System.Drawing.Point(251, 232);
            this.skullWallCount.Name = "skullWallCount";
            this.skullWallCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skullWallCount.Size = new System.Drawing.Size(40, 16);
            this.skullWallCount.TabIndex = 67;
            this.skullWallCount.Text = "0/4";
            this.skullWallCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skullWallCount.DoubleClick += new System.EventHandler(this.textDoubleClick);
            // 
            // shields
            // 
            this.shields.Controls.Add(this.buckler);
            this.shields.Controls.Add(this.angelShield);
            this.shields.Controls.Add(this.fakeSilverShield);
            this.shields.Controls.Add(this.silverShield);
            this.shields.Location = new System.Drawing.Point(172, 352);
            this.shields.Name = "shields";
            this.shields.Size = new System.Drawing.Size(40, 40);
            this.shields.TabIndex = 107;
            // 
            // buckler
            // 
            this.buckler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buckler.Image = global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
            this.buckler.Location = new System.Drawing.Point(0, 0);
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
            this.silverShield.Name = "silverShield";
            this.silverShield.Size = new System.Drawing.Size(40, 40);
            this.silverShield.TabIndex = 103;
            this.silverShield.TabStop = false;
            this.silverShield.Visible = false;
            // 
            // maternityStatue
            // 
            this.maternityStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_maternitystatue;
            this.maternityStatue.Location = new System.Drawing.Point(52, 152);
            this.maternityStatue.Name = "maternityStatue";
            this.maternityStatue.Size = new System.Drawing.Size(40, 40);
            this.maternityStatue.TabIndex = 106;
            this.maternityStatue.TabStop = false;
            this.maternityStatue.Visible = false;
            // 
            // flailWhip
            // 
            this.flailWhip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flailWhip.Image = global::LMRItemTracker.Properties.Resources.Icon_flailwhip;
            this.flailWhip.Location = new System.Drawing.Point(0, 0);
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
            this.chainWhip.Name = "chainWhip";
            this.chainWhip.Size = new System.Drawing.Size(40, 40);
            this.chainWhip.TabIndex = 104;
            this.chainWhip.TabStop = false;
            this.chainWhip.Visible = false;
            // 
            // spaulder
            // 
            this.spaulder.Image = global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
            this.spaulder.Location = new System.Drawing.Point(252, 292);
            this.spaulder.Name = "spaulder";
            this.spaulder.Size = new System.Drawing.Size(40, 40);
            this.spaulder.TabIndex = 100;
            this.spaulder.TabStop = false;
            // 
            // caltrops
            // 
            this.caltrops.Image = global::LMRItemTracker.Properties.Resources.Icon_caltrops_blank;
            this.caltrops.Location = new System.Drawing.Point(92, 392);
            this.caltrops.Name = "caltrops";
            this.caltrops.Size = new System.Drawing.Size(40, 40);
            this.caltrops.TabIndex = 99;
            this.caltrops.TabStop = false;
            // 
            // rollingShuriken
            // 
            this.rollingShuriken.Image = global::LMRItemTracker.Properties.Resources.Icon_rollingshuriken_blank;
            this.rollingShuriken.Location = new System.Drawing.Point(52, 392);
            this.rollingShuriken.Name = "rollingShuriken";
            this.rollingShuriken.Size = new System.Drawing.Size(40, 40);
            this.rollingShuriken.TabIndex = 98;
            this.rollingShuriken.TabStop = false;
            // 
            // shuriken
            // 
            this.shuriken.Image = global::LMRItemTracker.Properties.Resources.Icon_shuriken_blank;
            this.shuriken.Location = new System.Drawing.Point(12, 392);
            this.shuriken.Name = "shuriken";
            this.shuriken.Size = new System.Drawing.Size(40, 40);
            this.shuriken.TabIndex = 97;
            this.shuriken.TabStop = false;
            // 
            // torude
            // 
            this.torude.Image = global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
            this.torude.Location = new System.Drawing.Point(132, 192);
            this.torude.Name = "torude";
            this.torude.Size = new System.Drawing.Size(40, 40);
            this.torude.TabIndex = 96;
            this.torude.TabStop = false;
            // 
            // serpentStaff
            // 
            this.serpentStaff.Image = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
            this.serpentStaff.Location = new System.Drawing.Point(252, 112);
            this.serpentStaff.Name = "serpentStaff";
            this.serpentStaff.Size = new System.Drawing.Size(40, 40);
            this.serpentStaff.TabIndex = 95;
            this.serpentStaff.TabStop = false;
            // 
            // scalesphere
            // 
            this.scalesphere.Image = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
            this.scalesphere.Location = new System.Drawing.Point(132, 112);
            this.scalesphere.Name = "scalesphere";
            this.scalesphere.Size = new System.Drawing.Size(40, 40);
            this.scalesphere.TabIndex = 94;
            this.scalesphere.TabStop = false;
            // 
            // pistol
            // 
            this.pistol.Image = global::LMRItemTracker.Properties.Resources.Icon_pistol_blank;
            this.pistol.Location = new System.Drawing.Point(252, 352);
            this.pistol.Name = "pistol";
            this.pistol.Size = new System.Drawing.Size(40, 40);
            this.pistol.TabIndex = 93;
            this.pistol.TabStop = false;
            // 
            // perfume
            // 
            this.perfume.Image = global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
            this.perfume.Location = new System.Drawing.Point(132, 292);
            this.perfume.Name = "perfume";
            this.perfume.Size = new System.Drawing.Size(40, 40);
            this.perfume.TabIndex = 92;
            this.perfume.TabStop = false;
            // 
            // msx2
            // 
            this.msx2.Image = global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
            this.msx2.Location = new System.Drawing.Point(12, 292);
            this.msx2.Name = "msx2";
            this.msx2.Size = new System.Drawing.Size(40, 40);
            this.msx2.TabIndex = 91;
            this.msx2.TabStop = false;
            // 
            // knife
            // 
            this.knife.Image = global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
            this.knife.Location = new System.Drawing.Point(52, 352);
            this.knife.Name = "knife";
            this.knife.Size = new System.Drawing.Size(40, 40);
            this.knife.TabIndex = 90;
            this.knife.TabStop = false;
            // 
            // katana
            // 
            this.katana.Image = global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
            this.katana.Location = new System.Drawing.Point(132, 352);
            this.katana.Name = "katana";
            this.katana.Size = new System.Drawing.Size(40, 40);
            this.katana.TabIndex = 89;
            this.katana.TabStop = false;
            // 
            // glove
            // 
            this.glove.Image = global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
            this.glove.Location = new System.Drawing.Point(172, 292);
            this.glove.Name = "glove";
            this.glove.Size = new System.Drawing.Size(40, 40);
            this.glove.TabIndex = 88;
            this.glove.TabStop = false;
            // 
            // anchor
            // 
            this.anchor.Image = global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
            this.anchor.Location = new System.Drawing.Point(12, 192);
            this.anchor.Name = "anchor";
            this.anchor.Size = new System.Drawing.Size(40, 40);
            this.anchor.TabIndex = 87;
            this.anchor.TabStop = false;
            // 
            // flareGun
            // 
            this.flareGun.Image = global::LMRItemTracker.Properties.Resources.Icon_flaregun_blank;
            this.flareGun.Location = new System.Drawing.Point(132, 392);
            this.flareGun.Name = "flareGun";
            this.flareGun.Size = new System.Drawing.Size(40, 40);
            this.flareGun.TabIndex = 86;
            this.flareGun.TabStop = false;
            // 
            // earthSpear
            // 
            this.earthSpear.Image = global::LMRItemTracker.Properties.Resources.Icon_earthspear_blank;
            this.earthSpear.Location = new System.Drawing.Point(212, 392);
            this.earthSpear.Name = "earthSpear";
            this.earthSpear.Size = new System.Drawing.Size(40, 40);
            this.earthSpear.TabIndex = 85;
            this.earthSpear.TabStop = false;
            // 
            // whip
            // 
            this.whip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whip.Image = global::LMRItemTracker.Properties.Resources.Icon_whip;
            this.whip.Location = new System.Drawing.Point(0, 0);
            this.whip.Name = "whip";
            this.whip.Size = new System.Drawing.Size(40, 40);
            this.whip.TabIndex = 84;
            this.whip.TabStop = false;
            // 
            // chakram
            // 
            this.chakram.Image = global::LMRItemTracker.Properties.Resources.Icon_chakram_blank;
            this.chakram.Location = new System.Drawing.Point(172, 392);
            this.chakram.Name = "chakram";
            this.chakram.Size = new System.Drawing.Size(40, 40);
            this.chakram.TabIndex = 83;
            this.chakram.TabStop = false;
            // 
            // axe
            // 
            this.axe.Image = global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
            this.axe.Location = new System.Drawing.Point(92, 352);
            this.axe.Name = "axe";
            this.axe.Size = new System.Drawing.Size(40, 40);
            this.axe.TabIndex = 81;
            this.axe.TabStop = false;
            // 
            // iceCape
            // 
            this.iceCape.Image = global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
            this.iceCape.Location = new System.Drawing.Point(92, 112);
            this.iceCape.Name = "iceCape";
            this.iceCape.Size = new System.Drawing.Size(40, 40);
            this.iceCape.TabIndex = 80;
            this.iceCape.TabStop = false;
            // 
            // magatamaJewel
            // 
            this.magatamaJewel.Image = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
            this.magatamaJewel.Location = new System.Drawing.Point(92, 192);
            this.magatamaJewel.Name = "magatamaJewel";
            this.magatamaJewel.Size = new System.Drawing.Size(40, 40);
            this.magatamaJewel.TabIndex = 79;
            this.magatamaJewel.TabStop = false;
            // 
            // miniDoll
            // 
            this.miniDoll.Image = global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
            this.miniDoll.Location = new System.Drawing.Point(212, 152);
            this.miniDoll.Name = "miniDoll";
            this.miniDoll.Size = new System.Drawing.Size(40, 40);
            this.miniDoll.TabIndex = 78;
            this.miniDoll.TabStop = false;
            // 
            // eyeOfTruth
            // 
            this.eyeOfTruth.Image = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
            this.eyeOfTruth.Location = new System.Drawing.Point(52, 192);
            this.eyeOfTruth.Name = "eyeOfTruth";
            this.eyeOfTruth.Size = new System.Drawing.Size(40, 40);
            this.eyeOfTruth.TabIndex = 77;
            this.eyeOfTruth.TabStop = false;
            // 
            // pepper
            // 
            this.pepper.Image = global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
            this.pepper.Location = new System.Drawing.Point(92, 152);
            this.pepper.Name = "pepper";
            this.pepper.Size = new System.Drawing.Size(40, 40);
            this.pepper.TabIndex = 76;
            this.pepper.TabStop = false;
            // 
            // womanStatue
            // 
            this.womanStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
            this.womanStatue.Location = new System.Drawing.Point(52, 152);
            this.womanStatue.Name = "womanStatue";
            this.womanStatue.Size = new System.Drawing.Size(40, 40);
            this.womanStatue.TabIndex = 75;
            this.womanStatue.TabStop = false;
            // 
            // gauntlet
            // 
            this.gauntlet.Image = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
            this.gauntlet.Location = new System.Drawing.Point(212, 352);
            this.gauntlet.Name = "gauntlet";
            this.gauntlet.Size = new System.Drawing.Size(40, 40);
            this.gauntlet.TabIndex = 74;
            this.gauntlet.TabStop = false;
            // 
            // bracelet
            // 
            this.bracelet.Image = global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
            this.bracelet.Location = new System.Drawing.Point(212, 292);
            this.bracelet.Name = "bracelet";
            this.bracelet.Size = new System.Drawing.Size(40, 40);
            this.bracelet.TabIndex = 73;
            this.bracelet.TabStop = false;
            // 
            // fairyClothes
            // 
            this.fairyClothes.Image = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
            this.fairyClothes.Location = new System.Drawing.Point(252, 252);
            this.fairyClothes.Name = "fairyClothes";
            this.fairyClothes.Size = new System.Drawing.Size(40, 40);
            this.fairyClothes.TabIndex = 72;
            this.fairyClothes.TabStop = false;
            // 
            // crucifix
            // 
            this.crucifix.Image = global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
            this.crucifix.Location = new System.Drawing.Point(92, 292);
            this.crucifix.Name = "crucifix";
            this.crucifix.Size = new System.Drawing.Size(40, 40);
            this.crucifix.TabIndex = 71;
            this.crucifix.TabStop = false;
            // 
            // scriptures
            // 
            this.scriptures.Image = global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
            this.scriptures.Location = new System.Drawing.Point(52, 292);
            this.scriptures.Name = "scriptures";
            this.scriptures.Size = new System.Drawing.Size(40, 40);
            this.scriptures.TabIndex = 70;
            this.scriptures.TabStop = false;
            // 
            // bookOfTheDead
            // 
            this.bookOfTheDead.Image = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
            this.bookOfTheDead.Location = new System.Drawing.Point(172, 252);
            this.bookOfTheDead.Name = "bookOfTheDead";
            this.bookOfTheDead.Size = new System.Drawing.Size(40, 40);
            this.bookOfTheDead.TabIndex = 69;
            this.bookOfTheDead.TabStop = false;
            // 
            // dragonBone
            // 
            this.dragonBone.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            this.dragonBone.Location = new System.Drawing.Point(212, 112);
            this.dragonBone.Name = "dragonBone";
            this.dragonBone.Size = new System.Drawing.Size(40, 40);
            this.dragonBone.TabIndex = 68;
            this.dragonBone.TabStop = false;
            // 
            // vesselNotFound
            // 
            this.vesselNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            this.vesselNotFound.Location = new System.Drawing.Point(92, 452);
            this.vesselNotFound.Name = "vesselNotFound";
            this.vesselNotFound.Size = new System.Drawing.Size(40, 40);
            this.vesselNotFound.TabIndex = 66;
            this.vesselNotFound.TabStop = false;
            // 
            // pochetteKey
            // 
            this.pochetteKey.Image = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
            this.pochetteKey.Location = new System.Drawing.Point(52, 112);
            this.pochetteKey.Name = "pochetteKey";
            this.pochetteKey.Size = new System.Drawing.Size(40, 40);
            this.pochetteKey.TabIndex = 65;
            this.pochetteKey.TabStop = false;
            // 
            // deathSeal
            // 
            this.deathSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            this.deathSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deathSeal.Location = new System.Drawing.Point(132, 252);
            this.deathSeal.Name = "deathSeal";
            this.deathSeal.Size = new System.Drawing.Size(40, 40);
            this.deathSeal.TabIndex = 63;
            this.deathSeal.TabStop = false;
            // 
            // lifeSeal
            // 
            this.lifeSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            this.lifeSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lifeSeal.Location = new System.Drawing.Point(92, 252);
            this.lifeSeal.Name = "lifeSeal";
            this.lifeSeal.Size = new System.Drawing.Size(40, 40);
            this.lifeSeal.TabIndex = 62;
            this.lifeSeal.TabStop = false;
            // 
            // birthSeal
            // 
            this.birthSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            this.birthSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birthSeal.Location = new System.Drawing.Point(52, 252);
            this.birthSeal.Name = "birthSeal";
            this.birthSeal.Size = new System.Drawing.Size(40, 40);
            this.birthSeal.TabIndex = 61;
            this.birthSeal.TabStop = false;
            // 
            // originSeal
            // 
            this.originSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            this.originSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.originSeal.Location = new System.Drawing.Point(12, 252);
            this.originSeal.Name = "originSeal";
            this.originSeal.Size = new System.Drawing.Size(40, 40);
            this.originSeal.TabIndex = 60;
            this.originSeal.TabStop = false;
            // 
            // lampOfTimeNotFound
            // 
            this.lampOfTimeNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            this.lampOfTimeNotFound.Location = new System.Drawing.Point(172, 452);
            this.lampOfTimeNotFound.Name = "lampOfTimeNotFound";
            this.lampOfTimeNotFound.Size = new System.Drawing.Size(40, 40);
            this.lampOfTimeNotFound.TabIndex = 59;
            this.lampOfTimeNotFound.TabStop = false;
            // 
            // crystalSkull
            // 
            this.crystalSkull.Image = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            this.crystalSkull.Location = new System.Drawing.Point(252, 72);
            this.crystalSkull.Name = "crystalSkull";
            this.crystalSkull.Size = new System.Drawing.Size(40, 40);
            this.crystalSkull.TabIndex = 57;
            this.crystalSkull.TabStop = false;
            // 
            // dimensionalKey
            // 
            this.dimensionalKey.Image = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
            this.dimensionalKey.Location = new System.Drawing.Point(12, 112);
            this.dimensionalKey.Name = "dimensionalKey";
            this.dimensionalKey.Size = new System.Drawing.Size(40, 40);
            this.dimensionalKey.TabIndex = 56;
            this.dimensionalKey.TabStop = false;
            // 
            // ring
            // 
            this.ring.Image = global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
            this.ring.Location = new System.Drawing.Point(212, 252);
            this.ring.Name = "ring";
            this.ring.Size = new System.Drawing.Size(40, 40);
            this.ring.TabIndex = 55;
            this.ring.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            this.bomb.Location = new System.Drawing.Point(252, 392);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(40, 40);
            this.bomb.TabIndex = 54;
            this.bomb.TabStop = false;
            // 
            // cogOfTheSoul
            // 
            this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.cogOfTheSoul.Location = new System.Drawing.Point(172, 112);
            this.cogOfTheSoul.Name = "cogOfTheSoul";
            this.cogOfTheSoul.Size = new System.Drawing.Size(40, 40);
            this.cogOfTheSoul.TabIndex = 53;
            this.cogOfTheSoul.TabStop = false;
            // 
            // planeModel
            // 
            this.planeModel.Image = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            this.planeModel.Location = new System.Drawing.Point(212, 72);
            this.planeModel.Name = "planeModel";
            this.planeModel.Size = new System.Drawing.Size(40, 40);
            this.planeModel.TabIndex = 52;
            this.planeModel.TabStop = false;
            // 
            // helmet
            // 
            this.helmet.Image = global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
            this.helmet.Location = new System.Drawing.Point(172, 72);
            this.helmet.Name = "helmet";
            this.helmet.Size = new System.Drawing.Size(40, 40);
            this.helmet.TabIndex = 51;
            this.helmet.TabStop = false;
            // 
            // keyFairy
            // 
            this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank;
            this.keyFairy.Location = new System.Drawing.Point(212, 192);
            this.keyFairy.Name = "keyFairy";
            this.keyFairy.Size = new System.Drawing.Size(40, 40);
            this.keyFairy.TabIndex = 49;
            this.keyFairy.TabStop = false;
            // 
            // treasures
            // 
            this.treasures.Image = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            this.treasures.Location = new System.Drawing.Point(252, 152);
            this.treasures.Name = "treasures";
            this.treasures.Size = new System.Drawing.Size(40, 40);
            this.treasures.TabIndex = 47;
            this.treasures.TabStop = false;
            // 
            // feather
            // 
            this.feather.Image = global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
            this.feather.Location = new System.Drawing.Point(92, 12);
            this.feather.Name = "feather";
            this.feather.Size = new System.Drawing.Size(40, 40);
            this.feather.TabIndex = 46;
            this.feather.TabStop = false;
            // 
            // grappleClaw
            // 
            this.grappleClaw.Image = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
            this.grappleClaw.Location = new System.Drawing.Point(52, 12);
            this.grappleClaw.Name = "grappleClaw";
            this.grappleClaw.Size = new System.Drawing.Size(40, 40);
            this.grappleClaw.TabIndex = 45;
            this.grappleClaw.TabStop = false;
            // 
            // hermesBoots
            // 
            this.hermesBoots.Image = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
            this.hermesBoots.Location = new System.Drawing.Point(12, 12);
            this.hermesBoots.Name = "hermesBoots";
            this.hermesBoots.Size = new System.Drawing.Size(40, 40);
            this.hermesBoots.TabIndex = 44;
            this.hermesBoots.TabStop = false;
            // 
            // mirai
            // 
            this.mirai.Image = global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
            this.mirai.Location = new System.Drawing.Point(252, 12);
            this.mirai.Name = "mirai";
            this.mirai.Size = new System.Drawing.Size(40, 40);
            this.mirai.TabIndex = 43;
            this.mirai.TabStop = false;
            // 
            // isisPendant
            // 
            this.isisPendant.Image = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            this.isisPendant.Location = new System.Drawing.Point(172, 192);
            this.isisPendant.Name = "isisPendant";
            this.isisPendant.Size = new System.Drawing.Size(40, 40);
            this.isisPendant.TabIndex = 42;
            this.isisPendant.TabStop = false;
            // 
            // keyOfEternity
            // 
            this.keyOfEternity.Image = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
            this.keyOfEternity.Location = new System.Drawing.Point(132, 72);
            this.keyOfEternity.Name = "keyOfEternity";
            this.keyOfEternity.Size = new System.Drawing.Size(40, 40);
            this.keyOfEternity.TabIndex = 41;
            this.keyOfEternity.TabStop = false;
            // 
            // twinStatue
            // 
            this.twinStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
            this.twinStatue.Location = new System.Drawing.Point(92, 72);
            this.twinStatue.Name = "twinStatue";
            this.twinStatue.Size = new System.Drawing.Size(40, 40);
            this.twinStatue.TabIndex = 40;
            this.twinStatue.TabStop = false;
            // 
            // fruitOfEden
            // 
            this.fruitOfEden.Image = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
            this.fruitOfEden.Location = new System.Drawing.Point(52, 72);
            this.fruitOfEden.Name = "fruitOfEden";
            this.fruitOfEden.Size = new System.Drawing.Size(40, 40);
            this.fruitOfEden.TabIndex = 39;
            this.fruitOfEden.TabStop = false;
            // 
            // bronzeMirror
            // 
            this.bronzeMirror.Image = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
            this.bronzeMirror.Location = new System.Drawing.Point(12, 72);
            this.bronzeMirror.Name = "bronzeMirror";
            this.bronzeMirror.Size = new System.Drawing.Size(40, 40);
            this.bronzeMirror.TabIndex = 38;
            this.bronzeMirror.TabStop = false;
            // 
            // skullWall
            // 
            this.skullWall.Image = ((System.Drawing.Image)(resources.GetObject("skullWall.Image")));
            this.skullWall.Location = new System.Drawing.Point(252, 192);
            this.skullWall.Name = "skullWall";
            this.skullWall.Size = new System.Drawing.Size(40, 40);
            this.skullWall.TabIndex = 35;
            this.skullWall.TabStop = false;
            // 
            // vessel
            // 
            this.vessel.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel;
            this.vessel.Location = new System.Drawing.Point(92, 452);
            this.vessel.Name = "vessel";
            this.vessel.Size = new System.Drawing.Size(40, 40);
            this.vessel.TabIndex = 34;
            this.vessel.TabStop = false;
            // 
            // keySword
            // 
            this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
            this.keySword.Location = new System.Drawing.Point(132, 452);
            this.keySword.Name = "keySword";
            this.keySword.Size = new System.Drawing.Size(40, 40);
            this.keySword.TabIndex = 33;
            this.keySword.TabStop = false;
            // 
            // mantra
            // 
            this.mantra.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantra.Location = new System.Drawing.Point(52, 452);
            this.mantra.Name = "mantra";
            this.mantra.Size = new System.Drawing.Size(40, 40);
            this.mantra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mantra.TabIndex = 31;
            this.mantra.TabStop = false;
            // 
            // ocarina
            // 
            this.ocarina.Image = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            this.ocarina.Location = new System.Drawing.Point(12, 452);
            this.ocarina.Name = "ocarina";
            this.ocarina.Size = new System.Drawing.Size(40, 40);
            this.ocarina.TabIndex = 30;
            this.ocarina.TabStop = false;
            // 
            // ankhJewels
            // 
            this.ankhJewels.Image = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            this.ankhJewels.Location = new System.Drawing.Point(252, 452);
            this.ankhJewels.Name = "ankhJewels";
            this.ankhJewels.Size = new System.Drawing.Size(40, 40);
            this.ankhJewels.TabIndex = 29;
            this.ankhJewels.TabStop = false;
            // 
            // mulanaTalisman
            // 
            this.mulanaTalisman.Image = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            this.mulanaTalisman.Location = new System.Drawing.Point(12, 152);
            this.mulanaTalisman.Name = "mulanaTalisman";
            this.mulanaTalisman.Size = new System.Drawing.Size(40, 40);
            this.mulanaTalisman.TabIndex = 27;
            this.mulanaTalisman.TabStop = false;
            // 
            // diary
            // 
            this.diary.Image = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            this.diary.Location = new System.Drawing.Point(172, 152);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(40, 40);
            this.diary.TabIndex = 26;
            this.diary.TabStop = false;
            // 
            // talisman
            // 
            this.talisman.Image = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            this.talisman.Location = new System.Drawing.Point(132, 152);
            this.talisman.Name = "talisman";
            this.talisman.Size = new System.Drawing.Size(40, 40);
            this.talisman.TabIndex = 25;
            this.talisman.TabStop = false;
            // 
            // maps
            // 
            this.maps.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Location = new System.Drawing.Point(212, 452);
            this.maps.Name = "maps";
            this.maps.Size = new System.Drawing.Size(40, 40);
            this.maps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maps.TabIndex = 24;
            this.maps.TabStop = false;
            // 
            // viy
            // 
            this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
            this.viy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viy.Location = new System.Drawing.Point(154, 512);
            this.viy.Name = "viy";
            this.viy.Size = new System.Drawing.Size(34, 34);
            this.viy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viy.TabIndex = 22;
            this.viy.TabStop = false;
            // 
            // palenque
            // 
            this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
            this.palenque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.palenque.Location = new System.Drawing.Point(190, 512);
            this.palenque.Name = "palenque";
            this.palenque.Size = new System.Drawing.Size(34, 34);
            this.palenque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.palenque.TabIndex = 21;
            this.palenque.TabStop = false;
            // 
            // baphomet
            // 
            this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
            this.baphomet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baphomet.Location = new System.Drawing.Point(226, 512);
            this.baphomet.Name = "baphomet";
            this.baphomet.Size = new System.Drawing.Size(34, 34);
            this.baphomet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baphomet.TabIndex = 20;
            this.baphomet.TabStop = false;
            // 
            // tiamat
            // 
            this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
            this.tiamat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tiamat.Location = new System.Drawing.Point(262, 512);
            this.tiamat.Name = "tiamat";
            this.tiamat.Size = new System.Drawing.Size(34, 34);
            this.tiamat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tiamat.TabIndex = 19;
            this.tiamat.TabStop = false;
            // 
            // bahamut
            // 
            this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
            this.bahamut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bahamut.Location = new System.Drawing.Point(118, 512);
            this.bahamut.Name = "bahamut";
            this.bahamut.Size = new System.Drawing.Size(34, 34);
            this.bahamut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bahamut.TabIndex = 18;
            this.bahamut.TabStop = false;
            // 
            // ellmac
            // 
            this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
            this.ellmac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellmac.Location = new System.Drawing.Point(82, 512);
            this.ellmac.Name = "ellmac";
            this.ellmac.Size = new System.Drawing.Size(34, 34);
            this.ellmac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ellmac.TabIndex = 17;
            this.ellmac.TabStop = false;
            // 
            // amphisbaena
            // 
            this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
            this.amphisbaena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.amphisbaena.Location = new System.Drawing.Point(10, 512);
            this.amphisbaena.Name = "amphisbaena";
            this.amphisbaena.Size = new System.Drawing.Size(34, 34);
            this.amphisbaena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.amphisbaena.TabIndex = 13;
            this.amphisbaena.TabStop = false;
            // 
            // sakit
            // 
            this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
            this.sakit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sakit.Location = new System.Drawing.Point(46, 512);
            this.sakit.Name = "sakit";
            this.sakit.Size = new System.Drawing.Size(34, 34);
            this.sakit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sakit.TabIndex = 8;
            this.sakit.TabStop = false;
            // 
            // grail
            // 
            this.grail.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            this.grail.Location = new System.Drawing.Point(212, 12);
            this.grail.Name = "grail";
            this.grail.Size = new System.Drawing.Size(40, 40);
            this.grail.TabIndex = 3;
            this.grail.TabStop = false;
            // 
            // reader
            // 
            this.reader.Image = global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
            this.reader.Location = new System.Drawing.Point(172, 12);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(40, 40);
            this.reader.TabIndex = 2;
            this.reader.TabStop = false;
            // 
            // scanner
            // 
            this.scanner.Image = global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
            this.scanner.Location = new System.Drawing.Point(132, 12);
            this.scanner.Name = "scanner";
            this.scanner.Size = new System.Drawing.Size(40, 40);
            this.scanner.TabIndex = 1;
            this.scanner.TabStop = false;
            // 
            // lampOfTime
            // 
            this.lampOfTime.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit;
            this.lampOfTime.Location = new System.Drawing.Point(172, 452);
            this.lampOfTime.Name = "lampOfTime";
            this.lampOfTime.Size = new System.Drawing.Size(40, 40);
            this.lampOfTime.TabIndex = 64;
            this.lampOfTime.TabStop = false;
            // 
            // whips
            // 
            this.whips.Controls.Add(this.flailWhip);
            this.whips.Controls.Add(this.chainWhip);
            this.whips.Controls.Add(this.whip);
            this.whips.Location = new System.Drawing.Point(12, 352);
            this.whips.Name = "whips";
            this.whips.Size = new System.Drawing.Size(40, 40);
            this.whips.TabIndex = 108;
            // 
            // LaMulanaItemTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 561);
            this.Controls.Add(this.whips);
            this.Controls.Add(this.shields);
            this.Controls.Add(this.maternityStatue);
            this.Controls.Add(this.spaulder);
            this.Controls.Add(this.caltrops);
            this.Controls.Add(this.rollingShuriken);
            this.Controls.Add(this.shuriken);
            this.Controls.Add(this.torude);
            this.Controls.Add(this.serpentStaff);
            this.Controls.Add(this.scalesphere);
            this.Controls.Add(this.pistol);
            this.Controls.Add(this.perfume);
            this.Controls.Add(this.msx2);
            this.Controls.Add(this.knife);
            this.Controls.Add(this.katana);
            this.Controls.Add(this.glove);
            this.Controls.Add(this.anchor);
            this.Controls.Add(this.flareGun);
            this.Controls.Add(this.earthSpear);
            this.Controls.Add(this.chakram);
            this.Controls.Add(this.axe);
            this.Controls.Add(this.iceCape);
            this.Controls.Add(this.magatamaJewel);
            this.Controls.Add(this.miniDoll);
            this.Controls.Add(this.eyeOfTruth);
            this.Controls.Add(this.pepper);
            this.Controls.Add(this.womanStatue);
            this.Controls.Add(this.gauntlet);
            this.Controls.Add(this.bracelet);
            this.Controls.Add(this.fairyClothes);
            this.Controls.Add(this.crucifix);
            this.Controls.Add(this.scriptures);
            this.Controls.Add(this.bookOfTheDead);
            this.Controls.Add(this.dragonBone);
            this.Controls.Add(this.skullWallCount);
            this.Controls.Add(this.vesselNotFound);
            this.Controls.Add(this.pochetteKey);
            this.Controls.Add(this.deathSeal);
            this.Controls.Add(this.lifeSeal);
            this.Controls.Add(this.birthSeal);
            this.Controls.Add(this.originSeal);
            this.Controls.Add(this.lampOfTimeNotFound);
            this.Controls.Add(this.crystalSkull);
            this.Controls.Add(this.dimensionalKey);
            this.Controls.Add(this.ring);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.cogOfTheSoul);
            this.Controls.Add(this.planeModel);
            this.Controls.Add(this.helmet);
            this.Controls.Add(this.keyFairy);
            this.Controls.Add(this.translationTablets);
            this.Controls.Add(this.treasures);
            this.Controls.Add(this.feather);
            this.Controls.Add(this.grappleClaw);
            this.Controls.Add(this.hermesBoots);
            this.Controls.Add(this.mirai);
            this.Controls.Add(this.isisPendant);
            this.Controls.Add(this.keyOfEternity);
            this.Controls.Add(this.twinStatue);
            this.Controls.Add(this.fruitOfEden);
            this.Controls.Add(this.bronzeMirror);
            this.Controls.Add(this.skullWall);
            this.Controls.Add(this.vessel);
            this.Controls.Add(this.keySword);
            this.Controls.Add(this.mantra);
            this.Controls.Add(this.ocarina);
            this.Controls.Add(this.ankhJewels);
            this.Controls.Add(this.ankhJewelCount);
            this.Controls.Add(this.mulanaTalisman);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.talisman);
            this.Controls.Add(this.maps);
            this.Controls.Add(this.mapCount);
            this.Controls.Add(this.viy);
            this.Controls.Add(this.palenque);
            this.Controls.Add(this.baphomet);
            this.Controls.Add(this.tiamat);
            this.Controls.Add(this.bahamut);
            this.Controls.Add(this.ellmac);
            this.Controls.Add(this.amphisbaena);
            this.Controls.Add(this.sakit);
            this.Controls.Add(this.grail);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.scanner);
            this.Controls.Add(this.lampOfTime);
            this.Name = "LaMulanaItemTrackerForm";
            this.Text = "Item Tracker";
            this.Load += new System.EventHandler(this.LaMulanaItemTrackerForm_Load);
            this.DoubleClick += new System.EventHandler(this.LaMulanaItemTrackerForm_DoubleClick);
            this.shields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buckler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeSilverShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maternityStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flailWhip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainWhip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaulder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caltrops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollingShuriken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuriken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalesphere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flareGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthSpear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chakram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceCape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatamaJewel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeOfTruth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauntlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairyClothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crucifix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOfTheDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grappleClaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hermesBoots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isisPendant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyOfEternity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twinStatue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitOfEden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMirror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankhJewels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulanaTalisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talisman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palenque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baphomet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiamat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahamut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellmac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amphisbaena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTime)).EndInit();
            this.whips.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Assembly _assembly;
        private Stream _xmlStream;

        private PictureBox scanner;
        private PictureBox reader;
        private PictureBox grail;
        private PictureBox sakit;
        private PictureBox amphisbaena;
        private PictureBox ellmac;
        private PictureBox bahamut;
        private PictureBox tiamat;
        private PictureBox baphomet;
        private PictureBox palenque;
        private PictureBox viy;
        private Label mapCount;
        private PictureBox maps;
        private PictureBox mulanaTalisman;
        private PictureBox talisman;

        private Boolean mantrasRecited;
        private Boolean keySwordCollected;
        private Boolean miracleCollected;
        private Boolean mekuriCollected;

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
        private PictureBox mirai;
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
        private Panel shields;
        private Panel whips;
    }
}