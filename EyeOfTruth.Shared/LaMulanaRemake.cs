using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace EyeOfTruth
{
    public class LaMulanaRemake : WatchedProcess
    {
        struct Offsets
        {
            public int bytes, wordsptr, flags, igt;
        };
        Offsets? offsets;
        string version;

        Dictionary<string, Offsets?> veroffsets = new Dictionary<string, Offsets?>
        {
            {"1.0.0.1", new Offsets { bytes = 0x2D5A70, wordsptr = 0x2D5650, flags = 0x2D59C0, igt = 0x2D5044 } },
            {"1.3.3.1", new Offsets { bytes = 0x2D7E80, wordsptr = 0x2D7858, flags = 0x2D7BC8, igt = 0x2D724C } },
            {"1.5.5.2", new Offsets { bytes = 0x2E1E48, wordsptr = 0x2E1820, flags = 0x2E1B90, igt = 0x2E1214 } },
            {"1.6.6.1", new Offsets { bytes = 0x2D7D08, wordsptr = 0x2D76E4, flags = 0x2D7A40, igt = 0x2D70D8 } },
            {"1.6.6.2", new Offsets { bytes = 0x2E1E48, wordsptr = 0x2E1820, flags = 0x2E1B90, igt = 0x2E1214 } },
        };

        DeepPointer bytesptr, wordsptr;

        public override bool Attach()
        {
            if (!Attach((Process p) =>
            {
                if (!p.ProcessName.ToLowerInvariant().StartsWith("lamulana"))
                    return false;
                try
                {
                    return p.MainModule.FileVersionInfo.ProductName == "La-Mulana";
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

            version = proc.MainModule.FileVersionInfo.FileVersion;

            if (!veroffsets.TryGetValue(version, out offsets))
                return false;

            bytesptr = new DeepPointer(offsets.Value.bytes);
            for (int i = 0; i < 0x1000; i++)
                vars.Add(new GameVar<byte>(String.Format("byte-{0:x3}", i), offsets.Value.bytes + i));

            wordsptr = new DeepPointer(offsets.Value.wordsptr, 0);
            for (int i = 0; i < 255; i++)
                vars.Add(new GameVar<ushort>(String.Format("word-{0:x3}", i), offsets.Value.wordsptr, i * 2));

            vars.Add(new GameVar<uint>("flags-1", offsets.Value.flags));
            vars.Add(new GameVar<uint>("flags-2", offsets.Value.flags + 4));
            vars.Add(new GameVar<uint>("flags-3", offsets.Value.flags + 8));
            vars.Add(new GameVar<uint>("flags-4", offsets.Value.flags + 12));
            vars.Add(new GameVar<uint>("flags-5", offsets.Value.flags + 16));

            vars.Add(new GameVar<uint>("igt", offsets.Value.igt));
            return true;
        }

        public byte[] readbytes()
        {
            return bytesptr.DerefBytes(proc, 0x1000);
        }

        public byte[] readwords()
        {
            return wordsptr.DerefBytes(proc, 510);
        }
    }
}
