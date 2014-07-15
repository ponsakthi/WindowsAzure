using System.Diagnostics;

namespace EventManagerWorker
{
    public class WorkerLog
    {
        public void Log()
        {
            Trace.WriteLine("Log from worker");
        }
    }
}