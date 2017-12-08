using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace LMRItemTracker
{
    public partial class LaMulanaItemTrackerForm : Form
    {
        private BackgroundWorker flagListener;

        public LaMulanaItemTrackerForm()
        {
            InitializeComponent();
            this.mantrasRecited = false;
            this.keySwordCollected = false;
            this.miracleCollected = false;
            this.mekuriCollected = false;
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            flagListener = new BackgroundWorker();
            flagListener.DoWork += new DoWorkEventHandler(flagListener_DoWork);
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

        public void toggleItem(string itemName, bool isAdd)
        {
            if ("w-chain".Equals(itemName))
            {
                chainWhip.Visible = (bool)isAdd;
                chainWhip.Refresh();
            }
            else if ("w-flail".Equals(itemName))
            {
                flailWhip.Visible = (bool)isAdd;
                flailWhip.Refresh();
            }
            else if ("w-axe".Equals(itemName))
            {
                if (isAdd)
                {
                    axe.Image = global::LMRItemTracker.Properties.Resources.Icon_axe;
                }
                else
                {
                    axe.Image = global::LMRItemTracker.Properties.Resources.Icon_axe_blank;
                }
                axe.Refresh();
            }
            else if ("w-knife".Equals(itemName))
            {
                if (isAdd)
                {
                    this.knife.Image = global::LMRItemTracker.Properties.Resources.Icon_knife;
                }
                else
                {
                    this.knife.Image = global::LMRItemTracker.Properties.Resources.Icon_knife_blank;
                }
                this.knife.Refresh();
            }
            else if ("w-katana".Equals(itemName))
            {
                if (isAdd)
                {
                    this.katana.Image = global::LMRItemTracker.Properties.Resources.Icon_katana;
                }
                else
                {
                    this.katana.Image = global::LMRItemTracker.Properties.Resources.Icon_katana_blank;
                }
                this.katana.Refresh();
            }
            else if ("w-keysword".Equals(itemName))
            {
                if (isAdd)
                {
                    this.keySwordCollected = true;
                    if (this.mantrasRecited)
                    {
                        this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened;
                    }
                    else
                    {
                        this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword;
                    }
                }
                else
                {
                    this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_blank;
                }
                this.keySword.Refresh();
            }
            if ("w-scanner".Equals(itemName))
            {
                if (isAdd)
                {
                    this.scanner.Image = global::LMRItemTracker.Properties.Resources.Icon_handscanner;
                }
                else
                {
                    this.scanner.Image = global::LMRItemTracker.Properties.Resources.Icon_handscanner_blank;
                }
                this.scanner.Refresh();
            }
            else if ("w-reader".Equals(itemName))
            {
                if (isAdd)
                {
                    this.reader.Image = global::LMRItemTracker.Properties.Resources.Icon_reader;
                }
                else
                {
                    this.reader.Image = global::LMRItemTracker.Properties.Resources.Icon_reader_blank;
                }
                this.reader.Refresh();
            }
            else if ("w-grail".Equals(itemName))
            {
                if (isAdd)
                {
                    this.grail.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail;
                }
                else
                {
                    this.grail.Image = global::LMRItemTracker.Properties.Resources.Icon_holygrail_blank;
                }
                this.grail.Refresh();
            }
            else if ("w-doll".Equals(itemName))
            {
                if (isAdd)
                {
                    this.miniDoll.Image = global::LMRItemTracker.Properties.Resources.Icon_minidoll;
                }
                else
                {
                    this.miniDoll.Image = global::LMRItemTracker.Properties.Resources.Icon_minidoll_blank;
                }
                this.miniDoll.Refresh();
            }
            else if ("w-magatama".Equals(itemName))
            {
                if (isAdd)
                {
                    this.magatamaJewel.Image = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel;
                }
                else
                {
                    this.magatamaJewel.Image = global::LMRItemTracker.Properties.Resources.Icon_magatamajewel_blank;
                }
                this.magatamaJewel.Refresh();
            }
            else if ("w-pepper".Equals(itemName))
            {
                if (isAdd)
                {
                    this.pepper.Image = global::LMRItemTracker.Properties.Resources.Icon_pepper;
                }
                else
                {
                    this.pepper.Image = global::LMRItemTracker.Properties.Resources.Icon_pepper_blank;
                }
                this.pepper.Refresh();
            }
            else if ("w-woman".Equals(itemName))
            {
                if (isAdd)
                {
                    this.womanStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_womanstatue;
                }
                else
                {
                    this.womanStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_womanstatue_blank;
                }
                this.womanStatue.Refresh();
            }
            else if ("w-maternity".Equals(itemName))
            {
                this.maternityStatue.Visible = (bool)isAdd;
                this.maternityStatue.Refresh();
            }
            else if ("w-serpent".Equals(itemName))
            {
                if (isAdd)
                {
                    this.serpentStaff.Image = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff;
                }
                else
                {
                    this.serpentStaff.Image = global::LMRItemTracker.Properties.Resources.Icon_serpentstaff_blank;
                }
                this.serpentStaff.Refresh();
            }
            else if ("w-glove".Equals(itemName))
            {
                if (isAdd)
                {
                    this.glove.Image = global::LMRItemTracker.Properties.Resources.Icon_glove;
                }
                else
                {
                    this.glove.Image = global::LMRItemTracker.Properties.Resources.Icon_glove_blank;
                }
                this.glove.Refresh();
            }
            else if ("w-crucifix".Equals(itemName))
            {
                if (isAdd)
                {
                    this.crucifix.Image = global::LMRItemTracker.Properties.Resources.Icon_crucifix;
                }
                else
                {
                    this.crucifix.Image = global::LMRItemTracker.Properties.Resources.Icon_crucifix_blank;
                }
                this.crucifix.Refresh();
            }
            else if ("w-eye-truth".Equals(itemName))
            {
                if (isAdd)
                {
                    this.eyeOfTruth.Image = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth;
                }
                else
                {
                    this.eyeOfTruth.Image = global::LMRItemTracker.Properties.Resources.Icon_eyeoftruth_blank;
                }
                this.eyeOfTruth.Refresh();
            }
            else if ("w-scale".Equals(itemName))
            {
                if (isAdd)
                {
                    this.scalesphere.Image = global::LMRItemTracker.Properties.Resources.Icon_scalesphere;
                }
                else
                {
                    this.scalesphere.Image = global::LMRItemTracker.Properties.Resources.Icon_scalesphere_blank;
                }
                this.scalesphere.Refresh();
            }
            else if ("w-gauntlet".Equals(itemName))
            {
                if (isAdd)
                {
                    this.gauntlet.Image = global::LMRItemTracker.Properties.Resources.Icon_gauntlet;
                }
                else
                {
                    this.gauntlet.Image = global::LMRItemTracker.Properties.Resources.Icon_gauntlet_blank;
                }
                this.gauntlet.Refresh();
            }
            else if ("w-anchor".Equals(itemName))
            {
                if (isAdd)
                {
                    this.anchor.Image = global::LMRItemTracker.Properties.Resources.Icon_anchor;
                }
                else
                {
                    this.anchor.Image = global::LMRItemTracker.Properties.Resources.Icon_anchor_blank;
                }
                this.anchor.Refresh();
            }
            else if ("w-book".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bookOfTheDead.Image = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead;
                }
                else
                {
                    this.bookOfTheDead.Image = global::LMRItemTracker.Properties.Resources.Icon_bookofthedead_blank;
                }
                this.bookOfTheDead.Refresh();
            }
            else if ("w-clothes".Equals(itemName))
            {
                if (isAdd)
                {
                    this.fairyClothes.Image = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes;
                }
                else
                {
                    this.fairyClothes.Image = global::LMRItemTracker.Properties.Resources.Icon_fairyclothes_blank;
                }
                this.fairyClothes.Refresh();
            }
            else if ("w-scriptures".Equals(itemName))
            {
                if (isAdd)
                {
                    this.scriptures.Image = global::LMRItemTracker.Properties.Resources.Icon_scriptures;
                }
                else
                {
                    this.scriptures.Image = global::LMRItemTracker.Properties.Resources.Icon_scriptures_blank;
                }
                this.scriptures.Refresh();
            }
            else if ("w-bracelet".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bracelet.Image = global::LMRItemTracker.Properties.Resources.Icon_bracelet;
                }
                else
                {
                    this.bracelet.Image = global::LMRItemTracker.Properties.Resources.Icon_bracelet_blank;
                }
                this.bracelet.Refresh();
            }
            else if ("w-perfume".Equals(itemName))
            {
                if (isAdd)
                {
                    this.perfume.Image = global::LMRItemTracker.Properties.Resources.Icon_perfume;
                }
                else
                {
                    this.perfume.Image = global::LMRItemTracker.Properties.Resources.Icon_perfume_blank;
                }
                this.perfume.Refresh();
            }
            else if ("w-spaulder".Equals(itemName))
            {
                if (isAdd)
                {
                    this.spaulder.Image = global::LMRItemTracker.Properties.Resources.Icon_spaulder;
                }
                else
                {
                    this.spaulder.Image = global::LMRItemTracker.Properties.Resources.Icon_spaulder_blank;
                }
                this.spaulder.Refresh();
            }
            else if ("w-icecape".Equals(itemName))
            {
                if (isAdd)
                {
                    this.iceCape.Image = global::LMRItemTracker.Properties.Resources.Icon_icecape;
                }
                else
                {
                    this.iceCape.Image = global::LMRItemTracker.Properties.Resources.Icon_icecape_blank;
                }
                this.iceCape.Refresh();
            }
            else if ("w-talisman".Equals(itemName))
            {
                if (isAdd)
                {
                    this.talisman.Image = global::LMRItemTracker.Properties.Resources.Icon_talisman;
                }
                else
                {
                    this.talisman.Image = global::LMRItemTracker.Properties.Resources.Icon_talisman_blank;
                }
                this.talisman.Refresh();
            }
            else if ("w-diary".Equals(itemName))
            {
                if (isAdd)
                {
                    this.diary.Image = global::LMRItemTracker.Properties.Resources.Icon_diary;
                }
                else
                {
                    this.diary.Image = global::LMRItemTracker.Properties.Resources.Icon_diary_blank;
                }
                this.diary.Refresh();
            }
            else if ("w-mulanatalisman".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mulanaTalisman.Image = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman;
                }
                else
                {
                    this.mulanaTalisman.Image = global::LMRItemTracker.Properties.Resources.Icon_mulanatalisman_blank;
                }
                this.mulanaTalisman.Refresh();
            }
            else if ("w-dimension-key".Equals(itemName))
            {
                if (isAdd)
                {
                    this.dimensionalKey.Image = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey;
                }
                else
                {
                    this.dimensionalKey.Image = global::LMRItemTracker.Properties.Resources.Icon_dimensionalkey_blank;
                }
                this.dimensionalKey.Refresh();
            }
            else if ("w-bomb".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bomb.Image = global::LMRItemTracker.Properties.Resources.Icon_bomb;
                }
                else
                {
                    this.bomb.Image = global::LMRItemTracker.Properties.Resources.Icon_bomb_blank;
                }
                this.bomb.Refresh();
            }
            else if ("w-djed".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mantra.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar_small;

                }
                else
                {
                    this.mantra.Image = null;
                }
                this.mantra.Refresh();
            }
            else if ("w-cog".Equals(itemName))
            {
                if (isAdd)
                {
                    this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul;

                }
                else
                {
                    this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
                }
                this.cogOfTheSoul.Refresh();
            }
            else if ("w-cog".Equals(itemName))
            {
                if (isAdd)
                {
                    this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul;

                }
                else
                {
                    this.cogOfTheSoul.Image = global::LMRItemTracker.Properties.Resources.Icon_cogofthesoul_blank;
                }
                this.cogOfTheSoul.Refresh();
            }
            else if ("w-dragonbone".Equals(itemName))
            {
                if (isAdd)
                {
                    this.dragonBone.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone;
                    this.skullWallCount.Text = (Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) + 1) + "/4";
                }
                else
                {
                    this.dragonBone.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_blank;
                    this.skullWallCount.Text = Math.Max(0, Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) - 1) + "/4";
                }
                this.dragonBone.Refresh();
                this.skullWallCount.Refresh();
            }
            else if ("w-cskull".Equals(itemName))
            {
                if (isAdd)
                {
                    this.crystalSkull.Image = global::LMRItemTracker.Properties.Resources.Icon_crystalskull;
                }
                else
                {
                    this.crystalSkull.Image = global::LMRItemTracker.Properties.Resources.Icon_crystalskull_blank;
                }
                this.crystalSkull.Refresh();
            }
            else if ("w-endless-key".Equals(itemName))
            {
                if (isAdd)
                {
                    this.keyOfEternity.Image = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity;
                }
                else
                {
                    this.keyOfEternity.Image = global::LMRItemTracker.Properties.Resources.Icon_keyofeternity_blank;
                }
                this.keyOfEternity.Refresh();
            }
            else if ("w-isispendant".Equals(itemName))
            {
                if (isAdd)
                {
                    this.isisPendant.Image = global::LMRItemTracker.Properties.Resources.Icon_isispendant;
                }
                else
                {
                    this.isisPendant.Image = global::LMRItemTracker.Properties.Resources.Icon_isispendant_blank;
                }
                this.isisPendant.Refresh();
            }
            else if ("w-helmet".Equals(itemName))
            {
                if (isAdd)
                {
                    this.helmet.Image = global::LMRItemTracker.Properties.Resources.Icon_helmet;
                }
                else
                {
                    this.helmet.Image = global::LMRItemTracker.Properties.Resources.Icon_helmet_blank;
                }
                this.helmet.Refresh();
            }
            else if ("w-grapple".Equals(itemName))
            {
                if (isAdd)
                {
                    this.grappleClaw.Image = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw;

                }
                else
                {
                    this.grappleClaw.Image = global::LMRItemTracker.Properties.Resources.Icon_grappleclaw_blank;
                }
                this.grappleClaw.Refresh();
            }
            else if ("w-mirror".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bronzeMirror.Image = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror;

                }
                else
                {
                    this.bronzeMirror.Image = global::LMRItemTracker.Properties.Resources.Icon_bronzemirror_blank;
                }
                this.bronzeMirror.Refresh();
            }
            else if ("w-ring".Equals(itemName))
            {
                if (isAdd)
                {
                    this.ring.Image = global::LMRItemTracker.Properties.Resources.Icon_ring;

                }
                else
                {
                    this.ring.Image = global::LMRItemTracker.Properties.Resources.Icon_ring_blank;
                }
                this.ring.Refresh();
            }
            else if ("w-plane".Equals(itemName))
            {
                if (isAdd)
                {
                    this.planeModel.Image = global::LMRItemTracker.Properties.Resources.Icon_planemodel;

                }
                else
                {
                    this.planeModel.Image = global::LMRItemTracker.Properties.Resources.Icon_planemodel_blank;
                }
                this.planeModel.Refresh();
            }
            else if ("w-ocarina".Equals(itemName))
            {
                if (isAdd)
                {
                    this.ocarina.Image = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina;

                }
                else
                {
                    this.ocarina.Image = global::LMRItemTracker.Properties.Resources.Icon_philosophersocarina_blank;
                }
                this.ocarina.Refresh();
            }
            else if ("w-feather".Equals(itemName))
            {
                if (isAdd)
                {
                    this.feather.Image = global::LMRItemTracker.Properties.Resources.Icon_feather;

                }
                else
                {
                    this.feather.Image = global::LMRItemTracker.Properties.Resources.Icon_feather_blank;
                }
                this.feather.Refresh();
            }
            else if ("w-hermes".Equals(itemName))
            {
                if (isAdd)
                {
                    this.hermesBoots.Image = global::LMRItemTracker.Properties.Resources.Icon_hermesboots;

                }
                else
                {
                    this.hermesBoots.Image = global::LMRItemTracker.Properties.Resources.Icon_hermesboots_blank;
                }
                this.hermesBoots.Refresh();
            }
            else if ("w-fruit".Equals(itemName))
            {
                if (isAdd)
                {
                    this.fruitOfEden.Image = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden;

                }
                else
                {
                    this.fruitOfEden.Image = global::LMRItemTracker.Properties.Resources.Icon_fruitofeden_blank;
                }
                this.fruitOfEden.Refresh();
            }
            else if ("w-twin-statue".Equals(itemName))
            {
                if (isAdd)
                {
                    this.twinStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_twinstatue;

                }
                else
                {
                    this.twinStatue.Image = global::LMRItemTracker.Properties.Resources.Icon_twinstatue_blank;
                }
                this.fruitOfEden.Refresh();
            }
            else if ("w-treasures".Equals(itemName))
            {
                if (isAdd)
                {
                    this.treasures.Image = global::LMRItemTracker.Properties.Resources.Icon_treasures;
                }
                else
                {
                    this.treasures.Image = global::LMRItemTracker.Properties.Resources.Icon_treasures_blank;
                }
                this.treasures.Refresh();
            }
            else if ("w-pochettekey".Equals(itemName))
            {
                if (isAdd)
                {
                    this.pochetteKey.Image = global::LMRItemTracker.Properties.Resources.Icon_pochettekey;

                }
                else
                {
                    this.pochetteKey.Image = global::LMRItemTracker.Properties.Resources.Icon_pochettekey_blank;
                }
                this.pochetteKey.Refresh();
            }
            else if ("w-vessel".Equals(itemName))
            {
                this.vesselNotFound.Visible = !isAdd;
                this.vesselNotFound.Refresh();
            }
            else if ("w-lamp".Equals(itemName))
            {
                this.lampOfTimeNotFound.Visible = !isAdd;
                this.lampOfTimeNotFound.Refresh();
            }
            else if ("w-msx2".Equals(itemName))
            {
                if (isAdd)
                {
                    this.msx2.Image = global::LMRItemTracker.Properties.Resources.Icon_msx2;

                }
                else
                {
                    this.msx2.Image = global::LMRItemTracker.Properties.Resources.Icon_msx2_blank;
                }
                this.msx2.Refresh();
            }
            else if ("w-medicine".Equals(itemName))
            {
                if (isAdd)
                {
                    this.vessel.Image = global::LMRItemTracker.Properties.Resources.Icon_medicineofthemind;
                }
                else
                {
                    this.vessel.Image = global::LMRItemTracker.Properties.Resources.Icon_vessel;
                }
                this.vessel.Refresh();
            }
            else if ("w-mantra".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mantra.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra;

                }
                else
                {
                    this.mantra.BackgroundImage = global::LMRItemTracker.Properties.Resources.Icon_mantra_blank;
                }
                this.mantra.Refresh();
            }
            else if ("w-torude".Equals(itemName))
            {
                if (isAdd)
                {
                    this.torude.Image = global::LMRItemTracker.Properties.Resources.Icon_torude;

                }
                else
                {
                    this.torude.Image = global::LMRItemTracker.Properties.Resources.Icon_torude_blank;
                }
                this.torude.Refresh();
            }
            //            else if ("w-capstar".Equals(itemName))
            //            {
            //                if (isAdd)
            //                {
            //                    this.capstar.Image = global::LMRItemTracker.Properties.Resources.Icon_capstar;
            //                }
            //                else
            //                {
            //                    this.capstar.Image = global::LMRItemTracker.Properties.Resources.Icon_capstar_blank;
            //                }
            //                this.capstar.Refresh();
            //            }
            else if ("w-mekuri".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mekuriCollected = true;
                    if (this.miracleCollected)
                    {
                        this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy;
                    }
                }
                else
                {
                    this.mekuriCollected = false;
                    this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank;
                }
                this.keyFairy.Refresh();
            }
            else if ("w-miracle".Equals(itemName))
            {
                if (isAdd)
                {
                    this.miracleCollected = true;
                    if (this.mekuriCollected)
                    {
                        this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy;
                    }
                }
                else
                {
                    this.miracleCollected = false;
                    this.keyFairy.Image = global::LMRItemTracker.Properties.Resources.Icon_keyfairy_blank;
                }
                this.keyFairy.Refresh();
            }
            else if ("w-mirai".Equals(itemName))
            {
                if (isAdd)
                {
                    this.mirai.Image = global::LMRItemTracker.Properties.Resources.Icon_mirai;

                }
                else
                {
                    this.mirai.Image = global::LMRItemTracker.Properties.Resources.Icon_mirai_blank;
                }
                this.mirai.Refresh();
            }
            else if ("w-yagomap".Equals(itemName) || "w-yagostr".Equals(itemName))
            {
                if (isAdd)
                {
                    this.skullWallCount.Text = (Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) + 1) + "/4";
                }
                else
                {
                    this.skullWallCount.Text = Math.Max(0, Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) - 1) + "/4";
                }
                skullWallCount.Refresh();
            }
            else if ("w-seal1".Equals(itemName))
            {
                if (isAdd)
                {
                    this.originSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_originseal;

                }
                else
                {
                    this.originSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_originseal_blank;
                }
                this.originSeal.Refresh();
            }
            else if ("w-seal2".Equals(itemName))
            {
                if (isAdd)
                {
                    this.birthSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_birthseal;

                }
                else
                {
                    this.birthSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_birthseal_blank;
                }
                this.birthSeal.Refresh();
            }
            else if ("w-seal3".Equals(itemName))
            {
                if (isAdd)
                {
                    this.lifeSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_lifeseal;

                }
                else
                {
                    this.lifeSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_lifeseal_blank;
                }
                this.lifeSeal.Refresh();
            }
            else if ("w-seal4".Equals(itemName))
            {
                if (isAdd)
                {
                    this.deathSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_deathseal;

                }
                else
                {
                    this.deathSeal.Image = global::LMRItemTracker.Properties.Resources.Icon_deathseal_blank;
                }
                this.deathSeal.Refresh();
            }
        }

        internal void updateShield(string displayname, Boolean isAdd)
        {
            if ("shield-buckler".Equals(displayname))
            {
                if (isAdd)
                {
                    this.buckler.Image = global::LMRItemTracker.Properties.Resources.Icon_buckler;
                }
                else
                {
                    this.buckler.Image = global::LMRItemTracker.Properties.Resources.Icon_buckler_blank;
                }
                this.buckler.Refresh();
            }
            else if ("shield-silver".Equals(displayname))
            {
                this.silverShield.Visible = (bool)isAdd;
                this.silverShield.Refresh();
            }
            else if ("shield-fake".Equals(displayname))
            {
                this.fakeSilverShield.Visible = (bool)isAdd;
                this.fakeSilverShield.Refresh();
            }
            else if ("shield-angel".Equals(displayname))
            {
                this.angelShield.Visible = (bool)isAdd;
                this.angelShield.Refresh();
            }
        }

        internal void updateLampOfTime(string displayname, bool isAdd)
        {
            if ("invus-lamp-lit".Equals(displayname))
            {
                if (isAdd)
                {
                    this.lampOfTime.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime;
                }
            }
            else if ("invus-lamp-unlit".Equals(displayname))
            {
                if (isAdd)
                {
                    this.lampOfTime.Image = global::LMRItemTracker.Properties.Resources.Icon_lampoftime_unlit;
                }
            }
            this.lampOfTime.Refresh();
        }

        internal void updateTranslationTablets(byte cur)
        {
            this.translationTablets.Text = cur + "/3";
            this.translationTablets.Refresh();
        }

        public void updateAnkhJewels(ushort cur)
        {
//            short existingCount = (ushort)Int32.Parse(this.ankhJewelCount.Text);

            this.ankhJewelCount.Text = "" + cur;
            this.ankhJewelCount.Refresh();
//            if(cur > 0)
//            {
//                this.ankhJewels.Image = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel;
//            }
//            else
//            {
//                this.ankhJewels.Image = global::LMRItemTracker.Properties.Resources.Icon_ankhjewel_blank;
//            }
        }

        public void toggleBoss(string itemName, Boolean isAdd)
        {
            if ("boss-amphisbaena".Equals(itemName))
            {
                if (isAdd)
                {
                    this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena;
                }
                else
                {
                    this.amphisbaena.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_amphisbaena_blank;
                }
                this.amphisbaena.Refresh();
            }
            else if ("boss-sakit".Equals(itemName))
            {
                if (isAdd)
                {
                    this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit;
                }
                else
                {
                    this.sakit.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_sakit_blank;
                }
                this.sakit.Refresh();
            }
            else if ("boss-ellmac".Equals(itemName))
            {
                if (isAdd)
                {
                    this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac;
                }
                else
                {
                    this.ellmac.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_ellmac_blank;
                }
                this.ellmac.Refresh();
            }
            else if ("boss-bahamut".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut;
                }
                else
                {
                    this.bahamut.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_bahamut_blank;
                }
                this.bahamut.Refresh();
            }
            else if ("boss-viy".Equals(itemName))
            {
                if (isAdd)
                {
                    this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy;
                }
                else
                {
                    this.viy.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_viy_blank;
                }
                this.viy.Refresh();
            }
            else if ("boss-palenque".Equals(itemName))
            {
                if (isAdd)
                {
                    this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque;
                }
                else
                {
                    this.palenque.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_palenque_blank;
                }
                this.palenque.Refresh();
            }
            else if ("boss-baphomet".Equals(itemName))
            {
                if (isAdd)
                {
                    this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet;
                }
                else
                {
                    this.baphomet.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_baphomet_blank;
                }
                this.baphomet.Refresh();
            }
            else if ("boss-tiamat".Equals(itemName))
            {
                if (isAdd)
                {
                    this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat;
                }
                else
                {
                    this.tiamat.BackgroundImage = global::LMRItemTracker.Properties.Resources.Boss_tiamat_blank;
                }
                this.tiamat.Refresh();
            }
        }

        public void toggleMap(string itemName, Boolean isAdd)
        {
            if (isAdd)
            {
                this.mapCount.Text = (Int32.Parse(this.mapCount.Text.Substring(0, this.mapCount.Text.IndexOf('/'))) + 1) + "/18";
                if ("w-map-shrine".Equals(itemName))
                {
                    this.maps.Image = global::LMRItemTracker.Properties.Resources.Icon_dragonbone_small;
                    this.maps.Refresh();
                    this.skullWallCount.Text = (Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) + 1) + "/4";
                    this.skullWallCount.Refresh();
                }
            }
            else
            {
                this.mapCount.Text = Math.Max(0, Int32.Parse(this.mapCount.Text.Substring(0, this.mapCount.Text.IndexOf('/'))) - 1) + "/18";
                if ("w-map-shrine".Equals(itemName))
                {
                    this.maps.Image = null;
                    this.maps.Refresh();
                    this.skullWallCount.Text = Math.Max(0, Int32.Parse(this.skullWallCount.Text.Substring(0, this.skullWallCount.Text.IndexOf('/'))) - 1) + "/4";
                    this.skullWallCount.Refresh();
                }
            }
            this.mapCount.Refresh();
        }

        public void toggleMantra(string itemName, bool isAdd)
        {
            if ("mantra-keysword".Equals(itemName))
            {
                if(isAdd)
                {
                    this.mantrasRecited = true;
                    if (this.keySwordCollected)
                    {
                        this.keySword.Image = global::LMRItemTracker.Properties.Resources.Icon_keysword_awakened;
                        this.keySword.Refresh();
                    }
                }
                else
                {
                    this.mantrasRecited = false;
                }
            }
            else if ("mantra-amphisbaena".Equals(itemName))
            {
                if (isAdd)
                {
                    this.amphisbaena.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.amphisbaena.Image = null;
                }
                this.amphisbaena.Refresh();
            }
            else if ("mantra-sakit".Equals(itemName))
            {
                if (isAdd)
                {
                    this.sakit.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.sakit.Image = null;
                }
                this.sakit.Refresh();
            }
            else if ("mantra-ellmac".Equals(itemName))
            {
                if (isAdd)
                {
                    this.ellmac.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.ellmac.Image = null;
                }
                this.ellmac.Refresh();
            }
            else if ("mantra-bahamut".Equals(itemName))
            {
                if (isAdd)
                {
                    this.bahamut.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.bahamut.Image = null;
                }
                this.bahamut.Refresh();
            }
            else if ("mantra-viy".Equals(itemName))
            {
                if (isAdd)
                {
                    this.viy.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.viy.Image = null;
                }
                this.viy.Refresh();
            }
            else if ("mantra-palenque".Equals(itemName))
            {
                if (isAdd)
                {
                    this.palenque.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.palenque.Image = null;
                }
                this.palenque.Refresh();
            }
            else if ("mantra-baphomet".Equals(itemName))
            {
                if (isAdd)
                {
                    this.baphomet.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.baphomet.Image = null;
                }
                this.baphomet.Refresh();
            }
            else if ("mantra-tiamat".Equals(itemName))
            {
                if (isAdd)
                {
                    this.tiamat.Image = global::LMRItemTracker.Properties.Resources.Icon_djedpillar;
                }
                else
                {
                    this.tiamat.Image = null;
                }
                this.tiamat.Refresh();
            }
        }

        private void LaMulanaItemTrackerForm_Load(object sender, EventArgs e)
        {
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
                this.BackColor = formColorDialog.Color;
        }

        private void textDoubleClick(object sender, EventArgs e)
        {
            if (textColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.mapCount.ForeColor = textColorDialog.Color;
                this.ankhJewelCount.ForeColor = textColorDialog.Color;
                this.translationTablets.ForeColor = textColorDialog.Color;
                this.skullWallCount.ForeColor = textColorDialog.Color;
            }
        }
    }
}
