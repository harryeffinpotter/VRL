using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace VRL
{
  class Class1
    {
        private string FullPath { get; set; }
        private string Platform { get; set; }
        private string ShortcutName { get; set; }

        public string BuiltSource()
        {
            string source = $"string FullPath = {FullPath}" +
                            $"string Platform = {Platform}" +
                            $"string name = {ShortcutName}" +
                            $"Process MakeExes = new Process();" +
            "MakeExes.StartInfo.CreateNoWindow = true;" +
            "MakeExes.StartInfo.UseShellExecute = false;" +
            "MakeExes.StartInfo.FileName = ShortcutName;" +
            "MakeExes.StartInfo.Arguments = args;" +
            "MakeExes.StartInfo.WorkingDirectory = {FullPath}" +
            "MakeExes.StartInfo.TargetFile = $"+
            "MakeExes.Start();" +
            "MakeExes.WaitForExit();";
            return source;
        }
        [Obsolete]
        public void CreateShortcut()
        {
   
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "Out.exe";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, source);

            if (results.Errors.Count > 0
            {
                textBox2.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    textBox2.Text = textBox2.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                textBox2.ForeColor = Color.Blue;
                textBox2.Text = "Success!";
                //If we clicked run then launch our EXE
                if (ButtonObject.Text == "Run") Process.Start(Output);
            }
        }
    }
}
