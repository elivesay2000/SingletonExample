using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   /// <summary>
   /// The Singleton class itself.  Only a single instances of clsSingleton will exist anywhere within the program.
   /// In many cases, I have had a class that has only one instance in existence and I have had to pass that class from the class that owns the single instance to other classes (e.g., via parameters).
   /// The use of the singleton design pattern allows a single instance of a class to exist (e.g., clsSingleton) and for any other class to have access to it WITHOUT having to pass the reference to that single instance as a parameter when that other class is created or when one of the new classes routines is called.
   /// See https://www.dofactory.com/net/singleton-design-pattern
   /// </summary>
   public class clsSingleton
   {
      #region Stuff related to being a Singleton
      /// <summary>
      /// The single instance of clsSingleton that will ever exist.
      /// </summary>
      private  static clsSingleton  _instance;
      /// <summary>
      /// An object that is used for maintaining the thread-safety of clsSingleton. What happens when 'things' on separate threads all ask for _instance at the same time?
      /// </summary>
      private static object        syncLock = new object();
      
      /// <summary>
      /// Maintain thread safety while avoiding the need to lock every time the instance of the singleton is requested.
      /// </summary>
      /// <returns></returns>
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
      #endregion


      #region Routines that do stuff - folks get ahold of clsSingleton so that they can use these routines
      /// <summary>
      /// Add two numbers together.
      /// </summary>
      /// <param name="d1">The first number</param>
      /// <param name="d2">The second number.</param>
      /// <returns>The sum of d1 and d2.</returns>
      public double AddTwoNumbers(double d1, double d2)
      {
         return d1 + d2;
      }

      /// <summary>
      /// Calculate the difference of two number.
      /// </summary>
      /// <param name="d1">The first number</param>
      /// <param name="d2">The second number.</param>
      /// <returns>The difference between d1 and d2 (i.e., d1 - d2).</returns>
      public double SubtractTwoNumbers(double d1, double d2)
      {
         return d1 - d2;
      }
      #endregion
   }
}
