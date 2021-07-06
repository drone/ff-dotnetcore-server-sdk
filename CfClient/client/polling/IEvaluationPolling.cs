using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace io.harness.cfsdk.client.polling
{
    public interface IEvaluationPolling
    {
        public void start(Action<object, ElapsedEventArgs> runnable);

        public void stop();
    }
}
