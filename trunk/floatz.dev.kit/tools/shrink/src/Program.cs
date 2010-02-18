﻿using System;
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
               ShrinkFiles(action);
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
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("floatz CSS Framework - CSS and Javascript Shrinker");
            Console.WriteLine("Copyright (c) 2008-2010 by :humml:design");
            Console.WriteLine("---------------------------------------------------");
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
      /// Show inline message
      /// </summary>
      /// <param name="action"></param>
      /// <param name="msg"></param>
      static private void ShowInlineMessage(Action action, String msg) {
         if (!action.SilentMode) {
            Console.Write(msg);
         }
      }

      /// <summary>
      /// Show message with new line
      /// </summary>
      /// <param name="action"></param>
      /// <param name="msg"></param>
      static private void ShowMessage(Action action, String msg) {
         if (!action.SilentMode) {
            Console.WriteLine(msg);
         }
      }

      /// <summary>
      /// Show newline message
      /// </summary>
      /// <param name="action"></param>
      static private void ShowNewline(Action action) {
         ShowMessage(action, "");
      }

      /// <summary>
      /// Show error message with new line
      /// </summary>
      /// <param name="msg"></param>
      static private void ShowErrorMessage(Action action, String msg) {
         ShowMessage(action, String.Format("> ERROR - {0}", msg));
      }

      /// <summary>
      /// Shrink and (optionally) merge files
      /// </summary>
      /// <param name="action"></param>
      static private void ShrinkFiles(Action action) {
         StreamWriter writer = null;
         FileInfo tempFile = null;
         int shrinkCount = 0;
         
         // Get list of files that should be shrinked
         string[] files = GetFileList(action);
         if (files != null) {

            // Prepare target file for merging
            /*if (action.OutputFile != null) {
               tempFile = new FileInfo(action.OutputFile);
               if (! File.Exists(tempFile.FullName)) {
               }
            }*/

            foreach (String file in files) {
               FileInfo sourceFile = new FileInfo(file);

               try {
                  // Show message
                  ShowInlineMessage(action, String.Format("Shrinking {0}", sourceFile));

                  // Create temporary file
                  tempFile = new FileInfo(String.Format("{0}.temp", sourceFile.FullName));
                  writer = File.CreateText(tempFile.FullName);

                  // Shrink file
                  ShrinkFile(action, sourceFile, writer);

                  // Closed writer
                  writer.Close();

                  // Create backup file, override original with temporary file
                  if (!File.Exists(String.Format("{0}.bak", sourceFile.FullName))) {

                     // Show statistic information for file
                     ShowInlineMessage(action, String.Format(" from {0:0.00} KB to {1:0.00} KB (-{2:0}%)",
                        sourceFile.Length / 1024.0, tempFile.Length / 1024.0, (sourceFile.Length - tempFile.Length) * 100 / sourceFile.Length));
                     ShowNewline(action);

                     // Backup original file, replace original with new file, delete new file
                     File.Replace(tempFile.FullName, sourceFile.FullName, String.Format("{0}.bak", action.NoBackup ? null : sourceFile.FullName));

                     // Increase counter for shrinked files
                     shrinkCount += 1;
                  } else {
                     // Show error message if backup still exists
                     ShowNewline(action);
                     ShowErrorMessage(action, String.Format("Backup file still exists. Shrink of {0} aborted.", sourceFile.Name));
                  }

               } 
               // Exception handling for each file
               catch (Exception ex) {
                  // Show error message
                  ShowNewline(action);
                  ShowErrorMessage(action, ex.Message);

                  // Close writer for temporary target file
                  if (writer != null) {
                     writer.Close();
                  }

                  // Delete temporary target file if exists
                  if (tempFile != null && File.Exists(tempFile.FullName)) {
                     File.Delete(tempFile.FullName);
                  }
               }
            }

            // Show summary
            ShowNewline(action);
            ShowMessage(action, String.Format("{0} from {1} files shrinked.", shrinkCount, files.Length));
         }
      }

      /// <summary>
      /// Shrink file
      /// </summary>
      /// <remarks>
      /// Remove of inline comment between code is currently not supported
      /// Sample: floatz.init(a /* value a */, b);
      /// </remarks>
      /// <param name="action"></param>
      /// <param name="sourceFile"></param>
      static private void ShrinkFile(Action action, FileInfo file, StreamWriter writer) {
         bool multiLineComment = false;
         String newLine = null;
         String line = null;

         // Read all lines from original file
         string[] lines = File.ReadAllLines(file.FullName);

         // Shrink lines of code
         for (int i = 0; i < lines.Length; i++) {
            line = lines[i].Trim();

            // Single comment line
            if (line.StartsWith("//") || (line.StartsWith("/*") && line.EndsWith("*/"))) {
               WriteCommentLine(action, writer, line);
            }
               // Multi line comment start
            else if (line.StartsWith("/*")) {
               WriteCommentLine(action, writer, line);
               multiLineComment = true;
            }
               // Multi line comment end
            else if (multiLineComment && line.EndsWith("*/")) {
               WriteCommentLine(action, writer, line);
               multiLineComment = false;
            }
               // Part of multi line comment
            else if (action.KeepComments && multiLineComment) {
               WriteCommentLine(action, writer, line);
            }
               // Code lines
            else if (!multiLineComment) {
               if (line.Length > 0) {

                  // Single line comment at end of code line
                  int commentPos = line.LastIndexOf("//");
                  if (!action.KeepComments && commentPos != -1) {
                     newLine = ShrinkLine(line.Substring(0, commentPos));
                  }
                     // Multiline comment at end of code line
                  else if (!action.KeepComments && line.EndsWith("*/")) {
                     newLine = ShrinkLine(line.Substring(0, line.LastIndexOf("/*")));
                  }
                     // Non commenting lines
                  else {
                     newLine = ShrinkLine(line);
                  }

                  // Write line into stream
                  if (newLine.EndsWith("}")) {
                     WriteCodeLine(action, writer, newLine);
                  } else {
                     writer.Write(newLine);
                  }
               }
            }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="code"></param>
      /// <returns></returns>
      static private String ShrinkLine(String code) {
         return code.Trim()
                    .Replace(" :", ":")
                    .Replace(": ", ":")
                    .Replace(" ,", ",")
                    .Replace(", ", ",")
                    .Replace(" {", "{");
      }

      /// <summary>
      /// Write comment to stream writer
      /// </summary>
      /// <param name="action"></param>
      /// <param name="writer"></param>
      /// <param name="comment"></param>
      static private void WriteCommentLine(Action action, StreamWriter writer, string comment) {
         if (action.KeepComments) {
            WriteCodeLine(action, writer, comment);
         }
      }

      /// <summary>
      /// Write code to stream writer
      /// </summary>
      /// <param name="writer"></param>
      /// <param name="code"></param>
      static private void WriteCodeLine(Action action, StreamWriter writer, string code) {
         if (action.KeepLineBreaks) {
            writer.WriteLine(code);
         } else {
            writer.Write(code);
         }
      }

      /// <summary>
      /// Read files from directory or from given profile
      /// </summary>
      /// <param name="action"></param>
      /// <returns></returns>
      static private string[] GetFileList(Action action) {
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
