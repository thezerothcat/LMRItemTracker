using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace EyeOfTruth
{
    public class LaMulanaClassic : WatchedProcess
    {
        struct Offsets
        {
            public int diff;
        };
        Offsets? offsets;

        DeepPointer flags, roms;

        public override bool Attach()
        {
            if (!Attach((Process p) =>
            {
                if (!p.ProcessName.ToLowerInvariant().StartsWith("lamulana"))
                    return false;
                try
                {
                    String s = new DeepPointer(0xBD518).DerefString(p, 27);
                    return new DeepPointer(0xBD518).DerefString(p, 27) == "THE ADVENTURE STARTS HERE!";
                }
                catch (Win32Exception) // sigh, see http://www.aboutmycode.com/net/access-denied-process-bugs/
                {
                    throw;
                }
                catch { return false; }
            }))
            {
                offsets = null;
                return false;
            }

            if (offsets != null)
                return true;

            offsets = new Offsets { diff = 0 };

            flags = new DeepPointer(offsets.Value.diff + 0xCC748, 0);
            roms = new DeepPointer(offsets.Value.diff + 0xCCA98);
            // treasures? 1 if possessed
            for (int i = 0; i < 60; i++)
                vars.Add(new GameVar<byte>(String.Format("tr-{0:x3}", i), offsets.Value.diff + 0xD9E70 + i));
            // treasure menu? treasure ids, -1 if empty
            for (int i = 0; i < 40; i++)
                vars.Add(new GameVar<sbyte>(String.Format("trslot-{0:x3}", i), offsets.Value.diff + 0xD9EB8 + i));
            for (int i = 0; i < 24; i++)
                vars.Add(new GameVar<byte>(String.Format("04-{0:x3}", i), offsets.Value.diff + 0xCC888 + i));
            for (int i = 0; i < 5; i++)
                vars.Add(new GameVar<sbyte>(String.Format("05-{0:x3}", i), offsets.Value.diff + 0xD9DA8 + i));
            for (int i = 0; i < 24; i++)
                vars.Add(new GameVar<byte>(String.Format("06-{0:x3}", i), offsets.Value.diff + 0xD9D68 + i));
            for (int i = 0; i < 10; i++)
                vars.Add(new GameVar<sbyte>(String.Format("sub-{0:x3}", i), offsets.Value.diff + 0xE5F44 + i));
            for (int i = 0; i < 10; i++)
                vars.Add(new GameVar<Int16>(String.Format("ammo-{0}", i), offsets.Value.diff + 0xD9EEC + i * 2));
            vars.Add(new GameVar<byte>("hpmult", offsets.Value.diff + 0xBD594));
            vars.Add(new GameVar<Int16>("coins", offsets.Value.diff + 0xD9EB6));
            vars.Add(new GameVar<Int16>("weights", offsets.Value.diff + 0xE5F0C));
            vars.Add(new GameVar<Int32>("igt", offsets.Value.diff + 0xC873C));
            for (int i = 0; i < 4; i += 4)
                vars.Add(new GameVar<Int32>(String.Format("13-{0:x3}", i), offsets.Value.diff + 0xBD22C + i));
            for (int i = 0; i < 4; i++)
                vars.Add(new GameVar<byte>(String.Format("15-{0:x3}", i), offsets.Value.diff + 0xD9EE8 + i));
            for (int i = 0; i < 20; i++)
                vars.Add(new GameVar<byte>(String.Format("16-{0:x3}", i), offsets.Value.diff + 0xCCFD8 + i));
            // 1 while in xelpud's hut, only 1 for one frame elsewhere? Usable for avoiding the in place encryption I think
            vars.Add(new GameVar<Int32>("someflags", offsets.Value.diff + 0x3A8DA0));
            return true;
        }

        public byte[] readflags()
        {
            return flags.DerefBytes(proc, 875);
        }

        public byte[] readroms()
        {
            return roms.DerefBytes(proc, 1344);
        }
    }
}