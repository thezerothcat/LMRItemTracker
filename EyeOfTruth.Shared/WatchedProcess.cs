using LiveSplit.ComponentUtil;
using System;
using System.Diagnostics;
using System.Linq;

namespace EyeOfTruth
{
    public class WatchedProcess
    {
        public Process proc;
        public MemoryWatcherList vars = new MemoryWatcherList();

        public virtual bool Attach() { throw new NotImplementedException(); }
        public bool Attach(Func<Process, bool> pred)
        {
            if (proc == null || proc.HasExited)
            {
                proc = Process.GetProcesses().FirstOrDefault((p) => pred(p) && !p.HasExited && p.MainWindowHandle != IntPtr.Zero);
                if (proc != null)
                    vars.Clear();
            }
            return proc != null && !proc.HasExited && proc.MainWindowHandle != IntPtr.Zero;
        }

        public bool Attach(string name) => Attach((Process p) => p.ProcessName == name);

        public object Var(string id)
        {
            MemoryWatcher v = vars.FirstOrDefault((x) => x.Name == id);
            v?.Update(proc);
            return v?.Current;
        }

        public T Var<T>(string id) where T : struct
        {
            return (Var(id) as T?).GetValueOrDefault();
        }
    }
}