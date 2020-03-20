using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
   class clsSingleton
   {
      private  static clsSingleton  _instance;
      private  static object        syncLock = new object();
      public   static clsSingleton  GetClsSingleton()
      {
         if(_instance == null)
         {
            lock(syncLock)
            {
               if(_instance == null)
               {
                  _instance = new clsSingleton();
               }
            }
         }

         return _instance;
      }



      public double AddTwoNumbers(double d1, double d2)
      {
         return d1 + d2;
      }

   }
}
