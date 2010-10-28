using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace eu.humml.floatz.shrink {
   
   class AssemblyInfo {

      static private System.Type applicationType = typeof(shrink.Program);
      
      static private T getAttribute<T>() {
         System.Type t = typeof(T);
         object[] attr = applicationType.Assembly.GetCustomAttributes(t, false);
         return (T)attr[0];
      }

      static public string Product {
         get {
            return getAttribute<AssemblyProductAttribute>().Product;
         }
      }

      static public string Description {
         get {
            return getAttribute<AssemblyDescriptionAttribute>().Description;
         }
      }

      static public string Company {
         get {
            return getAttribute<AssemblyCompanyAttribute>().Company;
         }
      }

      static public string Copyright {
         get {
            return getAttribute<AssemblyCopyrightAttribute>().Copyright;
         }
      }

      static public string Version {
         get {
            return applicationType.Assembly.GetName().Version.ToString();
         }
      }
   }
}
