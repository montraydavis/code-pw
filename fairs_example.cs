using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Globalization;

namespace TfidfExample
{
    public class DocumentData
    {
        public string Text { get; set; }
        public string DocumentName { get; set; }
    }

    public class DocumentVector
    {
        public string DocumentName { get; set; }
        public float[] Vector { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string documentsDir = @"path\to\documents"; // Replace with the path to your documents directory
            string outputCsv = @"path\to\document_vectors.csv"; // Replace with the desired path for the output CSV

            // Step 1: Load documents
            var documents = LoadDocuments(documentsDir);

            // Step 2: Convert documents to TF-IDF vectors
            var documentVectors = ConvertDocumentsToTfidfVectors(documents);

            // Step 3: Save vectors to CSV
            SaveVectorsToCsv(documentVectors, outputCsv);

            Console.WriteLine("TF-IDF vectorization complete.");
        }

        static List<DocumentData> LoadDocuments(string directoryPath)
        {
            var documents = new List<DocumentData>();

            foreach (var filePath in Directory.EnumerateFiles(directoryPath, "*.txt"))
            {
                var text = File.ReadAllText(filePath);
                documents.Add(new DocumentData { Text = text, DocumentName = Path.GetFileName(filePath) });
            }

            return documents;
        }

        static List<DocumentVector> ConvertDocumentsToTfidfVectors(List<DocumentData> documents)
        {
            var context = new MLContext();

            // Load data into ML.NET data view
            var dataView = context.Data.LoadFromEnumerable(documents);

            // Define the data preparation pipeline
            var pipeline = context.Transforms.Text.FeaturizeText("Features", nameof(DocumentData.Text));

            // Fit the pipeline to the data
            var model = pipeline.Fit(dataView);

            // Transform the data
            var transformedData = model.Transform(dataView);

            // Extract the TF-IDF vectors
            var vectorData = context.Data.CreateEnumerable<TransformedData>(transformedData, reuseRowObject: false).ToList();

            // Combine document names with their corresponding vectors
            var documentVectors = documents
                .Zip(vectorData, (doc, vec) => new DocumentVector { DocumentName = doc.DocumentName, Vector = vec.Features.ToArray() })
                .ToList();

            return documentVectors;
        }

        static void SaveVectorsToCsv(List<DocumentVector> documentVectors, string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, config))
            {
                // Write header
                var headerRecord = Enumerable.Range(0, documentVectors.First().Vector.Length).Select(i => $"Feature_{i}").Append("DocumentName").ToArray();
                csv.WriteField(headerRecord);
                csv.NextRecord();

                // Write records
                foreach (var docVector in documentVectors)
                {
                    foreach (var value in docVector.Vector)
                    {
                        csv.WriteField(value);
                    }
                    csv.WriteField(docVector.DocumentName);
                    csv.NextRecord();
                }
            }
        }

        public class TransformedData
        {
            [VectorType]
            public VBuffer<float> Features { get; set; }
        }
    }
}
