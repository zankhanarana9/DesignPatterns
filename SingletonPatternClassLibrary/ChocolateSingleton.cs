using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternClassLibrary
{
    public class ChocolateSingleton
    {
        private static ChocolateSingleton UniqueInstance;
        // Lock synchronization object
        private static object syncLock = new object();

        public bool empty { get; private set; }
        public bool boiled { get; private set; }

        private ChocolateSingleton()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateSingleton GetInstance()
        {            
            if(UniqueInstance == null)
            {
                lock(syncLock)
                {
                    UniqueInstance = new ChocolateSingleton();
                }                
            }
            return UniqueInstance;
        }

        public void Fill()
        {
            if(IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }
        public void Drain()
        {
            if (!IsEmpty() && IsBoil())
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if(!IsEmpty()  && !IsBoil())
            {
                boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }
        public bool IsBoil()
        {
            return boiled;
        }
    }
}
