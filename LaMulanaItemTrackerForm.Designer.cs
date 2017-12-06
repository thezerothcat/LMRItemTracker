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
            this.mapCount = new System.Windows.Forms.Label();
            this.mapCountColorDialog = new System.Windows.Forms.ColorDialog();
            this.ankhJewelCount = new System.Windows.Forms.Label();
            this.ankhJewelCountColorDialog = new System.Windows.Forms.ColorDialog();
            this.translationTablets = new System.Windows.Forms.Label();
            this.translationCountColorDialog = new System.Windows.Forms.ColorDialog();
            this.formColorDialog = new System.Windows.Forms.ColorDialog();
            this.pochetteKey = new System.Windows.Forms.PictureBox();
            this.deathSeal = new System.Windows.Forms.PictureBox();
            this.lifeSeal = new System.Windows.Forms.PictureBox();
            this.birthSeal = new System.Windows.Forms.PictureBox();
            this.originSeal = new System.Windows.Forms.PictureBox();
            this.lampOfTimeNotFound = new System.Windows.Forms.PictureBox();
            this.capstar = new System.Windows.Forms.PictureBox();
            this.crystalSkull = new System.Windows.Forms.PictureBox();
            this.dimensionalKey = new System.Windows.Forms.PictureBox();
            this.ring = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.cogOfTheSoul = new System.Windows.Forms.PictureBox();
            this.planeModel = new System.Windows.Forms.PictureBox();
            this.helmet = new System.Windows.Forms.PictureBox();
            this.mekuri = new System.Windows.Forms.PictureBox();
            this.miracle = new System.Windows.Forms.PictureBox();
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
            this.yagostr = new System.Windows.Forms.PictureBox();
            this.yagomap = new System.Windows.Forms.PictureBox();
            this.dragonBone = new System.Windows.Forms.PictureBox();
            this.vessel = new System.Windows.Forms.PictureBox();
            this.keySword = new System.Windows.Forms.PictureBox();
            this.djedPillar = new System.Windows.Forms.PictureBox();
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
            this.vesselNotFound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miracle)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.yagostr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagomap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djedPillar)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).BeginInit();
            this.SuspendLayout();
            // 
            // mapCount
            // 
            this.mapCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.mapCount.Location = new System.Drawing.Point(188, 244);
            this.mapCount.Name = "mapCount";
            this.mapCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mapCount.Size = new System.Drawing.Size(50, 16);
            this.mapCount.TabIndex = 23;
            this.mapCount.Text = "0/18";
            this.mapCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mapCount.DoubleClick += new System.EventHandler(this.mapCount_DoubleClick);
            // 
            // mapCountColorDialog
            // 
            this.mapCountColorDialog.AnyColor = true;
            this.mapCountColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.mapCountColorDialog.SolidColorOnly = true;
            // 
            // ankhJewelCount
            // 
            this.ankhJewelCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ankhJewelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.ankhJewelCount.Location = new System.Drawing.Point(243, 390);
            this.ankhJewelCount.Name = "ankhJewelCount";
            this.ankhJewelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ankhJewelCount.Size = new System.Drawing.Size(30, 16);
            this.ankhJewelCount.TabIndex = 28;
            this.ankhJewelCount.Text = "0";
            this.ankhJewelCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ankhJewelCount.DoubleClick += new System.EventHandler(this.ankhJewelCount_DoubleClick);
            // 
            // ankhJewelCountColorDialog
            // 
            this.ankhJewelCountColorDialog.AnyColor = true;
            this.ankhJewelCountColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.ankhJewelCountColorDialog.SolidColorOnly = true;
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
            this.translationTablets.DoubleClick += new System.EventHandler(this.translationTablets_DoubleClick);
            // 
            // translationCountColorDialog
            // 
            this.translationCountColorDialog.AnyColor = true;
            this.translationCountColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.translationCountColorDialog.SolidColorOnly = true;
            // 
            // formColorDialog
            // 
            this.formColorDialog.AnyColor = true;
            this.formColorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.formColorDialog.SolidColorOnly = true;
            // 
            // pochetteKey
            // 
            this.pochetteKey.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.pochetteKey.Location = new System.Drawing.Point(54, 112);
            this.pochetteKey.Name = "pochetteKey";
            this.pochetteKey.Size = new System.Drawing.Size(40, 40);
            this.pochetteKey.TabIndex = 65;
            this.pochetteKey.TabStop = false;
            // 
            // deathSeal
            // 
            this.deathSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
            this.deathSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deathSeal.Location = new System.Drawing.Point(132, 292);
            this.deathSeal.Name = "deathSeal";
            this.deathSeal.Size = new System.Drawing.Size(40, 40);
            this.deathSeal.TabIndex = 63;
            this.deathSeal.TabStop = false;
            // 
            // lifeSeal
            // 
            this.lifeSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
            this.lifeSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lifeSeal.Location = new System.Drawing.Point(92, 292);
            this.lifeSeal.Name = "lifeSeal";
            this.lifeSeal.Size = new System.Drawing.Size(40, 40);
            this.lifeSeal.TabIndex = 62;
            this.lifeSeal.TabStop = false;
            // 
            // birthSeal
            // 
            this.birthSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
            this.birthSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birthSeal.Location = new System.Drawing.Point(52, 292);
            this.birthSeal.Name = "birthSeal";
            this.birthSeal.Size = new System.Drawing.Size(40, 40);
            this.birthSeal.TabIndex = 61;
            this.birthSeal.TabStop = false;
            // 
            // originSeal
            // 
            this.originSeal.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
            this.originSeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.originSeal.Location = new System.Drawing.Point(12, 292);
            this.originSeal.Name = "originSeal";
            this.originSeal.Size = new System.Drawing.Size(40, 40);
            this.originSeal.TabIndex = 60;
            this.originSeal.TabStop = false;
            // 
            // lampOfTimeNotFound
            // 
            this.lampOfTimeNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_blank;
            this.lampOfTimeNotFound.Location = new System.Drawing.Point(251, 112);
            this.lampOfTimeNotFound.Name = "lampOfTimeNotFound";
            this.lampOfTimeNotFound.Size = new System.Drawing.Size(40, 40);
            this.lampOfTimeNotFound.TabIndex = 59;
            this.lampOfTimeNotFound.TabStop = false;
            // 
            // capstar
            // 
            this.capstar.Image = global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            this.capstar.Location = new System.Drawing.Point(132, 172);
            this.capstar.Name = "capstar";
            this.capstar.Size = new System.Drawing.Size(40, 40);
            this.capstar.TabIndex = 58;
            this.capstar.TabStop = false;
            // 
            // crystalSkull
            // 
            this.crystalSkull.Image = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
            this.crystalSkull.Location = new System.Drawing.Point(251, 72);
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
            this.ring.Location = new System.Drawing.Point(211, 112);
            this.ring.Name = "ring";
            this.ring.Size = new System.Drawing.Size(40, 40);
            this.ring.TabIndex = 55;
            this.ring.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
            this.bomb.Location = new System.Drawing.Point(172, 112);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(40, 40);
            this.bomb.TabIndex = 54;
            this.bomb.TabStop = false;
            // 
            // cogOfTheSoul
            // 
            this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
            this.cogOfTheSoul.Location = new System.Drawing.Point(92, 112);
            this.cogOfTheSoul.Name = "cogOfTheSoul";
            this.cogOfTheSoul.Size = new System.Drawing.Size(40, 40);
            this.cogOfTheSoul.TabIndex = 53;
            this.cogOfTheSoul.TabStop = false;
            // 
            // planeModel
            // 
            this.planeModel.Image = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
            this.planeModel.Location = new System.Drawing.Point(211, 72);
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
            // mekuri
            // 
            this.mekuri.Image = global::LMRItemTracker.Properties.Resources.Icon_mekuri_blank;
            this.mekuri.Location = new System.Drawing.Point(92, 172);
            this.mekuri.Name = "mekuri";
            this.mekuri.Size = new System.Drawing.Size(40, 40);
            this.mekuri.TabIndex = 50;
            this.mekuri.TabStop = false;
            // 
            // miracle
            // 
            this.miracle.Image = global::LMRItemTracker.Properties.Resources.Icon_miracle_blank;
            this.miracle.Location = new System.Drawing.Point(52, 172);
            this.miracle.Name = "miracle";
            this.miracle.Size = new System.Drawing.Size(40, 40);
            this.miracle.TabIndex = 49;
            this.miracle.TabStop = false;
            // 
            // treasures
            // 
            this.treasures.Image = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
            this.treasures.Location = new System.Drawing.Point(252, 172);
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
            this.mirai.Location = new System.Drawing.Point(251, 12);
            this.mirai.Name = "mirai";
            this.mirai.Size = new System.Drawing.Size(40, 40);
            this.mirai.TabIndex = 43;
            this.mirai.TabStop = false;
            // 
            // isisPendant
            // 
            this.isisPendant.Image = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
            this.isisPendant.Location = new System.Drawing.Point(12, 172);
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
            // yagostr
            // 
            this.yagostr.Image = global::LMRItemTracker.Properties.Resources.Icon_yagostr_blank;
            this.yagostr.Location = new System.Drawing.Point(92, 232);
            this.yagostr.Name = "yagostr";
            this.yagostr.Size = new System.Drawing.Size(40, 40);
            this.yagostr.TabIndex = 37;
            this.yagostr.TabStop = false;
            // 
            // yagomap
            // 
            this.yagomap.Image = global::LMRItemTracker.Properties.Resources.Icon_yagomap_blank;
            this.yagomap.Location = new System.Drawing.Point(52, 232);
            this.yagomap.Name = "yagomap";
            this.yagomap.Size = new System.Drawing.Size(40, 40);
            this.yagomap.TabIndex = 36;
            this.yagomap.TabStop = false;
            // 
            // dragonBone
            // 
            this.dragonBone.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
            this.dragonBone.Location = new System.Drawing.Point(12, 232);
            this.dragonBone.Name = "dragonBone";
            this.dragonBone.Size = new System.Drawing.Size(40, 40);
            this.dragonBone.TabIndex = 35;
            this.dragonBone.TabStop = false;
            // 
            // vessel
            // 
            this.vessel.BackColor = System.Drawing.SystemColors.Control;
            this.vessel.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel;
            this.vessel.Location = new System.Drawing.Point(132, 347);
            this.vessel.Name = "vessel";
            this.vessel.Size = new System.Drawing.Size(40, 40);
            this.vessel.TabIndex = 34;
            this.vessel.TabStop = false;
            // 
            // keySword
            // 
            this.keySword.BackColor = System.Drawing.SystemColors.Control;
            this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
            this.keySword.Location = new System.Drawing.Point(172, 347);
            this.keySword.Name = "keySword";
            this.keySword.Size = new System.Drawing.Size(40, 40);
            this.keySword.TabIndex = 33;
            this.keySword.TabStop = false;
            // 
            // djedPillar
            // 
            this.djedPillar.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_blank;
            this.djedPillar.Location = new System.Drawing.Point(92, 347);
            this.djedPillar.Name = "djedPillar";
            this.djedPillar.Size = new System.Drawing.Size(40, 40);
            this.djedPillar.TabIndex = 32;
            this.djedPillar.TabStop = false;
            // 
            // mantra
            // 
            this.mantra.Image = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
            this.mantra.Location = new System.Drawing.Point(52, 347);
            this.mantra.Name = "mantra";
            this.mantra.Size = new System.Drawing.Size(40, 40);
            this.mantra.TabIndex = 31;
            this.mantra.TabStop = false;
            // 
            // ocarina
            // 
            this.ocarina.Image = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
            this.ocarina.Location = new System.Drawing.Point(12, 347);
            this.ocarina.Name = "ocarina";
            this.ocarina.Size = new System.Drawing.Size(40, 40);
            this.ocarina.TabIndex = 30;
            this.ocarina.TabStop = false;
            // 
            // ankhJewels
            // 
            this.ankhJewels.Image = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
            this.ankhJewels.Location = new System.Drawing.Point(237, 347);
            this.ankhJewels.Name = "ankhJewels";
            this.ankhJewels.Size = new System.Drawing.Size(40, 40);
            this.ankhJewels.TabIndex = 29;
            this.ankhJewels.TabStop = false;
            // 
            // mulanaTalisman
            // 
            this.mulanaTalisman.Image = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
            this.mulanaTalisman.Location = new System.Drawing.Point(132, 112);
            this.mulanaTalisman.Name = "mulanaTalisman";
            this.mulanaTalisman.Size = new System.Drawing.Size(40, 40);
            this.mulanaTalisman.TabIndex = 27;
            this.mulanaTalisman.TabStop = false;
            // 
            // diary
            // 
            this.diary.Image = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
            this.diary.Location = new System.Drawing.Point(212, 172);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(40, 40);
            this.diary.TabIndex = 26;
            this.diary.TabStop = false;
            // 
            // talisman
            // 
            this.talisman.Image = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
            this.talisman.Location = new System.Drawing.Point(252, 232);
            this.talisman.Name = "talisman";
            this.talisman.Size = new System.Drawing.Size(40, 40);
            this.talisman.TabIndex = 25;
            this.talisman.TabStop = false;
            // 
            // maps
            // 
            this.maps.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_map;
            this.maps.Location = new System.Drawing.Point(152, 232);
            this.maps.Name = "maps";
            this.maps.Size = new System.Drawing.Size(40, 40);
            this.maps.TabIndex = 24;
            this.maps.TabStop = false;
            // 
            // viy
            // 
            this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
            this.viy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viy.Location = new System.Drawing.Point(12, 454);
            this.viy.Name = "viy";
            this.viy.Size = new System.Drawing.Size(40, 40);
            this.viy.TabIndex = 22;
            this.viy.TabStop = false;
            // 
            // palenque
            // 
            this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
            this.palenque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.palenque.Location = new System.Drawing.Point(54, 454);
            this.palenque.Name = "palenque";
            this.palenque.Size = new System.Drawing.Size(40, 40);
            this.palenque.TabIndex = 21;
            this.palenque.TabStop = false;
            // 
            // baphomet
            // 
            this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
            this.baphomet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baphomet.Location = new System.Drawing.Point(96, 455);
            this.baphomet.Name = "baphomet";
            this.baphomet.Size = new System.Drawing.Size(40, 40);
            this.baphomet.TabIndex = 20;
            this.baphomet.TabStop = false;
            // 
            // tiamat
            // 
            this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
            this.tiamat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tiamat.Location = new System.Drawing.Point(138, 454);
            this.tiamat.Name = "tiamat";
            this.tiamat.Size = new System.Drawing.Size(40, 40);
            this.tiamat.TabIndex = 19;
            this.tiamat.TabStop = false;
            // 
            // bahamut
            // 
            this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
            this.bahamut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bahamut.Location = new System.Drawing.Point(138, 412);
            this.bahamut.Name = "bahamut";
            this.bahamut.Size = new System.Drawing.Size(40, 40);
            this.bahamut.TabIndex = 18;
            this.bahamut.TabStop = false;
            // 
            // ellmac
            // 
            this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
            this.ellmac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellmac.Location = new System.Drawing.Point(96, 412);
            this.ellmac.Name = "ellmac";
            this.ellmac.Size = new System.Drawing.Size(40, 40);
            this.ellmac.TabIndex = 17;
            this.ellmac.TabStop = false;
            // 
            // amphisbaena
            // 
            this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
            this.amphisbaena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.amphisbaena.Location = new System.Drawing.Point(12, 412);
            this.amphisbaena.Name = "amphisbaena";
            this.amphisbaena.Size = new System.Drawing.Size(40, 40);
            this.amphisbaena.TabIndex = 13;
            this.amphisbaena.TabStop = false;
            // 
            // sakit
            // 
            this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
            this.sakit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sakit.Location = new System.Drawing.Point(54, 412);
            this.sakit.Name = "sakit";
            this.sakit.Size = new System.Drawing.Size(40, 40);
            this.sakit.TabIndex = 8;
            this.sakit.TabStop = false;
            // 
            // grail
            // 
            this.grail.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
            this.grail.Location = new System.Drawing.Point(211, 12);
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
            this.lampOfTime.Location = new System.Drawing.Point(251, 112);
            this.lampOfTime.Name = "lampOfTime";
            this.lampOfTime.Size = new System.Drawing.Size(40, 40);
            this.lampOfTime.TabIndex = 64;
            this.lampOfTime.TabStop = false;
            // 
            // vesselNotFound
            // 
            this.vesselNotFound.BackColor = System.Drawing.SystemColors.Control;
            this.vesselNotFound.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel_blank;
            this.vesselNotFound.Location = new System.Drawing.Point(132, 347);
            this.vesselNotFound.Name = "vesselNotFound";
            this.vesselNotFound.Size = new System.Drawing.Size(40, 40);
            this.vesselNotFound.TabIndex = 66;
            this.vesselNotFound.TabStop = false;
            // 
            // LaMulanaItemTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 507);
            this.Controls.Add(this.vesselNotFound);
            this.Controls.Add(this.pochetteKey);
            this.Controls.Add(this.deathSeal);
            this.Controls.Add(this.lifeSeal);
            this.Controls.Add(this.birthSeal);
            this.Controls.Add(this.originSeal);
            this.Controls.Add(this.lampOfTimeNotFound);
            this.Controls.Add(this.capstar);
            this.Controls.Add(this.crystalSkull);
            this.Controls.Add(this.dimensionalKey);
            this.Controls.Add(this.ring);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.cogOfTheSoul);
            this.Controls.Add(this.planeModel);
            this.Controls.Add(this.helmet);
            this.Controls.Add(this.mekuri);
            this.Controls.Add(this.miracle);
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
            this.Controls.Add(this.yagostr);
            this.Controls.Add(this.yagomap);
            this.Controls.Add(this.dragonBone);
            this.Controls.Add(this.vessel);
            this.Controls.Add(this.keySword);
            this.Controls.Add(this.djedPillar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pochetteKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lampOfTimeNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capstar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalSkull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionalKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogOfTheSoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miracle)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.yagostr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yagomap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vessel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djedPillar)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.vesselNotFound)).EndInit();
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
        private PictureBox diary;
        private PictureBox talisman;

        private Boolean mantrasRecited;
        private Boolean keySwordCollected;

        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new LMRItemTracker.LaMulanaItemTrackerForm());
        }

        private ColorDialog mapCountColorDialog;
        private PictureBox ankhJewels;
        private Label ankhJewelCount;
        private ColorDialog ankhJewelCountColorDialog;
        private PictureBox ocarina;
        private PictureBox mantra;
        private PictureBox keySword;
        private PictureBox djedPillar;
        private PictureBox vessel;
        private PictureBox dragonBone;
        private PictureBox yagomap;
        private PictureBox yagostr;
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
        private PictureBox miracle;
        private PictureBox helmet;
        private PictureBox planeModel;
        private PictureBox cogOfTheSoul;
        private PictureBox bomb;
        private PictureBox ring;
        private PictureBox dimensionalKey;
        private PictureBox crystalSkull;
        private PictureBox mekuri;
        private PictureBox capstar;
        private PictureBox lampOfTimeNotFound;
        private ColorDialog translationCountColorDialog;
        private ColorDialog formColorDialog;
        private PictureBox originSeal;
        private PictureBox birthSeal;
        private PictureBox lifeSeal;
        private PictureBox deathSeal;
        private PictureBox lampOfTime;
        private PictureBox pochetteKey;
        private PictureBox vesselNotFound;
    }
}