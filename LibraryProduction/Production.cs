using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryProduction
{
    public class Production
    {
        private static Random Alea;
        private enum StateProduct { Ready, InProgress, Pause, Finish  };
        private object syncObj = new object();

        private string Name;
        private int ObjectifNumberProduct;
        private int SpeedProductPerHour;
        private int NumberBoxDefault;
        private int NumberBoxBuild;
        private StateProduct CurrentlyState;

        public delegate void DelegateProductChange(Production p);
        public event DelegateProductChange ProductChange;

        private void EventProductChange(Production p)
        {
            if(ProductChange != null)
            {
                ProductChange(p);
            }
        }

        public Production(string _name, int _objectifNumberProduct, int _speedProductPerHour)
        {
            Name = _name;
            ObjectifNumberProduct = _objectifNumberProduct;
            SpeedProductPerHour = _speedProductPerHour;
            NumberBoxDefault = 0;
            NumberBoxBuild = 0;
            CurrentlyState = StateProduct.Ready;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetObjectifNumberProduct()
        {
            return ObjectifNumberProduct;
        }

        public int GetProductPerHour()
        {
            return SpeedProductPerHour;
        }

        public int GetNumberBoxDefault()
        {
            return NumberBoxDefault;
        }
        
        public int GetNumberBoxBuild()
        {
            return NumberBoxBuild;
        }

        public void StartProduct()
        {
            while (!CurrentlyState.Equals(StateProduct.Pause) && !CurrentlyState.Equals(StateProduct.Finish))
            {
                Thread.Sleep(1000);
                if (NumberBoxBuild >= ObjectifNumberProduct)
                {
                    CurrentlyState = StateProduct.Finish;
                }
                else
                {
                    
                    Alea = new Random();
                    if (Alea.NextDouble() >= 0.027) //Verif caisse
                    {
                        NumberBoxBuild += SpeedProductPerHour;
                    }
                    else
                    {
                        NumberBoxDefault++;
                    }
                }
                EventProductChange(this);
                lock (syncObj) { }
            }
        }

        public int GiveNumberBoxDefault()
        {
            return 1;
        }

        public int GiveDefaultPerHour()
        {
            return 0;
        }

        public bool Start()
        {
            if(CurrentlyState.Equals(StateProduct.Ready))
            {
                CurrentlyState = StateProduct.InProgress;
                Task tsk = Task.Factory.StartNew(() => StartProduct());
                return true;
            }
            return false;
        }

        public bool Pause()
        {
            if(CurrentlyState.Equals(StateProduct.InProgress))
            {
                CurrentlyState = StateProduct.Pause;
                Monitor.Enter(syncObj);
                return true;
            }
            return false;
        }

        public bool Continue()
        {
            if(CurrentlyState.Equals(StateProduct.Pause))
            {
                CurrentlyState = StateProduct.InProgress;
                Monitor.Exit(syncObj);
                return true;
            }
            return false;
        }
    }
}
