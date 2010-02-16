using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eu.humml.floatz.shrink {
   class Action {
      public const int ACTION_NONE = 0;
      public const int ACTION_HELP = 1;
      public const int ACTION_SHRINK = 2;
      
      private int type = ACTION_NONE;
      public int Type {
         get { return this.type; }
         set { this.type = value; }
      }

      private bool keepComments = false;
      public bool KeepComments {
         get { return keepComments; }
         set { keepComments = value; }
      }

      private bool keepLineBreaks = false;
      public bool KeepLineBreaks {
         get { return keepLineBreaks; }
         set { keepLineBreaks = value; }
      }

      private bool noBackup = false;
      public bool NoBackup {
         get { return noBackup; }
         set { noBackup = value; }
      }

      private bool silentMode = false;
      public bool SilentMode {
         get { return silentMode; }
         set { silentMode = value; }
      }

      private String encoding;
      public String Encoding {
         get { return encoding; }
         set { encoding = value; }
      }

      private String profile;
      public String Profile {
         get { return profile; }
         set { profile = value; }
      }

      private String outputFile;
      public String OutputFile {
         get { return outputFile; }
         set { outputFile = value; }
      }

      private String files;
      public String Files {
         get { return files; }
         set { files = value; }
      }
   }
}
