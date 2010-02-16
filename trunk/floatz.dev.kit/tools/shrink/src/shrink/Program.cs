using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace eu.humml.floatz.shrink {
   /// <summary>
   /// 
   /// </summary>
   class Program {
   
      static void Main(string[] args) {

         // Parse arguments
         Action action = ParseArguments(args);

         // Show splashcreen for application
         ShowSplashScreen(action);

         // Handle actions
         switch(action.Type) {
            case Action.ACTION_HELP :
               ShowHelpScreen(action);
               break;
            case Action.ACTION_SHRINK :
               Shrink(action);
               break;
         }         
      }

      /// <summary>
      /// Parse and check arguments
      /// </summary>
      /// <param name="args"></param>
      static private Action ParseArguments(string[] args) {
         Action action = new Action();

         // If not arguments are available, switch to help action
         if(args.Length == 0) {
            action.Type = Action.ACTION_HELP;
         }
         else {
            // Determine processing information from arguments
            foreach(String arg in args) {
               switch(arg.ToLower()) {
                  case "/c" :
                     action.KeepComments = true;
                     break;
                  case "/h":
                     action.Type = Action.ACTION_HELP;
                     break;
                  case "/l" :
                     action.KeepLineBreaks = true;
                     break;
                  case "/n" :
                     action.NoBackup = true;
                     break;
                  case "/s" :
                     action.SilentMode = true;
                     break;
                  default :
                     if (arg.StartsWith("/e:")) {
                        action.Encoding = arg.Substring(arg.LastIndexOf(":") + 1);
                     } else if (arg.StartsWith("/o:")) {
                        action.OutputFile = arg.Substring(arg.LastIndexOf(":") + 1);
                     } else if (arg.StartsWith("/p:")) {
                        action.Profile = arg.Substring(arg.LastIndexOf(":") + 1);
                        action.Type = Action.ACTION_SHRINK;                     
                     } else {
                        action.Files = arg;
                        action.Type = Action.ACTION_SHRINK;
                     }
                     break;
               }
            }
         }
         
         return action;
      }

      /// <summary>
      /// Show splash screen
      /// </summary>
      static private void ShowSplashScreen(Action action) {
         if (!action.SilentMode) {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("floatz CSS Framework - CSS and Javascript Shrinker");
            Console.WriteLine("Copyright (c) 2008-2010 by :humml:design");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
         }
      }

      /// <summary>
      /// Show help screen
      /// </summary>
      static private void ShowHelpScreen(Action action) {
         if (!action.SilentMode) {
            Console.WriteLine("Syntax:");
            Console.WriteLine("");
            Console.WriteLine("  shrink [file(s)] [option(s)]");
            Console.WriteLine("");
            Console.WriteLine("Options:");
            Console.WriteLine("");
            Console.WriteLine("  /c             - Keep comments");
            Console.WriteLine("  /e:<encoding>  - Encoding type for output file(s)");
            Console.WriteLine("  /h             - Show help screen");
            Console.WriteLine("  /l             - Keep linebreaks");
            Console.WriteLine("  /n             - No backup");
            Console.WriteLine("  /o:<file>      - Merge into output file");
            Console.WriteLine("  /p:<profile>   - List of files to be shrinked");
            Console.WriteLine("  /s             - Silent mode");
            Console.WriteLine("");
            Console.WriteLine("Examples:");
            Console.WriteLine("");
            Console.WriteLine("  Shrink and backup all css files");
            Console.WriteLine("     shrink *.css");
            Console.WriteLine("");
            Console.WriteLine("  Shrink and override all css files");
            Console.WriteLine("     shrink *.css /n");
            Console.WriteLine("");
            Console.WriteLine("  Shrink all css files and merge into floatz.css");
            Console.WriteLine("     shrink *.css /o:floatz.css");
            Console.WriteLine("");
            Console.WriteLine("  Shrink files from profile and merge into floatz.css");
            Console.WriteLine("     shrink /p:floatz.profile /o:floatz.css");
            Console.WriteLine("");
         }
      }

      /// <summary>
      /// Show error message
      /// </summary>
      /// <param name="msg"></param>
      static public void ShowErrorMessage(Action action, String msg) {
         if (!action.SilentMode) {
            Console.WriteLine(String.Format("Error - {0}", msg));
         }
      }

      /// <summary>
      /// Shrink and (optionally) merge files
      /// </summary>
      /// <param name="action"></param>
      static private void Shrink(Action action) {
         
         // Get list of files that should be shrinked
         string[] files = ReadFiles(action);
         if (files != null) {
            foreach (String file in files) {
               Console.WriteLine(String.Format("Shrinking {0} ...", file));
            }
         }
      }

      /// <summary>
      /// Read files from directory or from given profile
      /// </summary>
      /// <param name="action"></param>
      /// <returns></returns>
      static private string[] ReadFiles(Action action) {
         string[] fileList = null;
         bool error = false;

         try {
            // Read files from directory
            if (action.Files != null) {
               fileList = Directory.GetFiles(
                  Path.GetDirectoryName(action.Files).Length > 0 ? Path.GetDirectoryName(action.Files) : @".\" , 
                  Path.GetFileName(action.Files));

               // Show error message, if no files are found
               if (fileList.Length == 0) {
                  ShowErrorMessage(action, String.Format("No files found for {0}", action.Files));
                  error = true;
               }

            // Read files from profile
            } else if (action.Profile != null) {
               ArrayList files = new ArrayList();

               // Read file list from profile
               string[] lines = File.ReadAllLines(action.Profile);
               foreach (String file in lines) {

                  // Ignore empty lines
                  if (file.Trim().Length == 0) {
                     continue;
                  // Check if file exists and add it to file list
                  } else if (File.Exists(file)) {
                     files.Add(file);
                  // Show error message if file does not exist
                  } else {
                     ShowErrorMessage(action, String.Format("File in profile {0} does not exist: {1}", action.Profile, file));
                     error = true;
                  }
               }

               // Convert Arraylist to string[]
               fileList = (string[])files.ToArray(typeof(string));

               // Show error message, if no files are found
               if (! error && fileList.Length == 0) {
                  ShowErrorMessage(action, String.Format("No file from profile {0} found", action.Profile));
                  error = true;
               }
            }
         } 
         catch (Exception ex) {
            ShowErrorMessage(action, ex.Message);
         }

         // Return file list
         return error ? null : fileList;
      }
   }
}
