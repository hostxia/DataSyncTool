using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using DevExpress.XtraPdfViewer;
using Microsoft.Office.Interop.Word;

namespace BasicFacility.Utility
{
    public class Print
    {
        public static void PrintDocument(List<string> listFilePath)
        {
            if (listFilePath.Count == 0) return;
            _Application WordApp = new Microsoft.Office.Interop.Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            var pdfViewer = new PdfViewer();
            foreach (string sFilePath in listFilePath)
            {
                string sFileExtension = Path.GetExtension(sFilePath).ToLower();
                if (sFileExtension.Contains(".doc"))
                {
                    object oFilePath = sFilePath;
                    _Document WordDoc = WordApp.Documents.Open(
                        ref oFilePath, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                    WordDoc.PrintOut();
                    WordDoc.Close(WdSaveOptions.wdDoNotSaveChanges, ref oMissing, ref oMissing);
                }
                if (sFileExtension == ".pdf")
                {
                    pdfViewer.LoadDocument(sFilePath);//打开文件 
                    var printerSettings = new PrinterSettings();
                    printerSettings.Copies = 1;
                    pdfViewer.Print(printerSettings);
                    pdfViewer.CloseDocument();
                }
            }
            WordApp.Quit();
            pdfViewer.Dispose();
        }

        public static void PrintDocument(string sTargetDirectoryPath)
        {
            string[] filePaths = Directory.GetFiles(sTargetDirectoryPath);
            if (filePaths.Length < 1) return;
            PrintDocument(filePaths.ToList());
        }
    }
}