﻿using GroupDocs.Comparison.Options;
using System;
using System.IO;

namespace GroupDocs.Comparison.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates using option for select metadata 
    /// </summary>
    class SetDocumentMetadataTarget
    {
        public static void Run()
        {
            string outputDirectory = Constants.GetOutputDirectoryPath();
            string outputFileName = Path.Combine(outputDirectory, Constants.RESULT_WORD);

            using (Comparer comparer = new Comparer(Constants.SOURCE_WORD))
            {
                comparer.Add(Constants.TARGET_WORD);
                comparer.Compare(outputFileName, new SaveOptions() { CloneMetadataType = MetadataType.Target });
            }
            Console.WriteLine($"\nDocuments compared successfully.\nCheck output in {Directory.GetCurrentDirectory()}.");
        }
    }
}
