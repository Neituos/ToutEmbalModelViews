using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryProduction
{
    public class TestThread
    {
        public delegate void DelegeUpdateProgressBar(int max, int value, string sender);
        public event DelegeUpdateProgressBar WorkingProgress;

        private void EventProgressBar(int max, int value, string sender)
        {
            if(WorkingProgress != null)
            {
                WorkingProgress(max, value, sender);
            }
        }

        public void Poussepousse(int max, int step, string sender)
        {
            for(int i = 0; i <= max; i += step)
            {
                EventProgressBar(max, i, sender);
                Thread.Sleep(500);
            }
        }
    }
}
