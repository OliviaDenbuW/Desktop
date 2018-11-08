using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TextEdit2 {
  static class Program { 
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      new TextEdit2();
      Application.Run();
    }
  }
}