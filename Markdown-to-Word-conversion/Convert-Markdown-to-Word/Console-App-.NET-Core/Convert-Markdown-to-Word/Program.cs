﻿using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;

namespace Convert_Markdown_to_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBMAY9C3t2VFhiQlJPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXpRckRkWXhcdnxdRWE=");
            //Open a file as a stream.
            using (FileStream fileStreamPath = new FileStream(Path.GetFullPath(@"../../../Input.md"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                //Load an existing Markdown file.
                using (WordDocument document = new WordDocument(fileStreamPath, FormatType.Markdown))
                {
                    //Create a file stream.
                    using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"../../../MarkdownToWord.docx"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        //Save a Word document to the file stream.
                        document.Save(outputFileStream, FormatType.Docx);
                    }
                }
            }
        }
    }
}
