using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week16_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //// Create a folder and a file, write to the file, and read from the file
            //string folder = @"C:\Users\Jules\Downloads\files\store\output";
            //string path = Path.Combine(folder, "hello.txt");

            //// Check if the folder exists, if not, print a message and exit
            //if (!Directory.Exists(folder))
            //{
            //    Console.WriteLine("Folder not found: " + folder);
            //    return;
            //}

            //// Check if the file exists, if not, create it and write some text to it
            //if (!File.Exists(path))
            //{
            //    using (StreamWriter writer = new StreamWriter(path))
            //    {
            //        writer.WriteLine("Hello, file!");
            //        writer.WriteLine("This text is saved on the disk.");
            //    }

            //    Console.WriteLine("Created: " + path);
            //}

            //// Read the first two lines from the file and print them to the console
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string firstLine = reader.ReadLine();
            //    string secondLine = reader.ReadLine();

            //    Console.WriteLine("Line 1: " + (firstLine ?? "(no line)"));
            //    Console.WriteLine("Line 2: " + (secondLine ?? "(no line)"));
            //}


            // Demo 2
            //string folder = @"C:\Users\Jules\Downloads\files\store\output";
            //string path = Path.Combine(folder, "notes.txt");

            //if (!Directory.Exists(folder))
            //{
            //    Console.WriteLine("Folder not found: " + folder);
            //    return;
            //}

            //if (!File.Exists(path))
            //{
            //    using (StreamWriter writer = new StreamWriter(path))
            //    {
            //        writer.WriteLine("Bring laptop");
            //        writer.WriteLine();
            //        writer.WriteLine("Quiz on Friday");
            //    }
            //}
            //// Read the file and print each line with its line number, handling empty lines
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string line;
            //    int lineNumber = 1;

            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        if (line == "")
            //        {
            //            Console.WriteLine(lineNumber + ". (empty line)");
            //        }
            //        else
            //        {
            //            Console.WriteLine(lineNumber + ". " + line);
            //        }

            //        lineNumber++;
            //        // End
            //    }
            //}


            //Demo 3
            //string folder = @"C:\Users\Jules\Downloads\files\store\output";
            //string path = Path.Combine(folder, "grades.csv");

            //if (!Directory.Exists(folder))
            //{
            //    Console.WriteLine("Folder not found: " + folder);
            //    return;
            //}

            //if (!File.Exists(path))
            //{
            //    // Create a CSV file with sample data, including some invalid records.
            //    File.WriteAllLines(path, new[]
            //    {
            //    // Header
            //    "Name,Grade,Remarks",
            //    // Valid records
            //    "Ana Reyes,92,Passed",
            //    "Mark Santos,74,Failed",
            //    "Juan Dela Cruz,88.5,Passed",
            //    "Liza Ramos,ninety,Passed",
            //    // Invalid records
            //    "Paolo Lim",
            //    // More valid records
            //    "Carla Mendoza,81,Passed"
            //});
            //}

            //// Read the CSV file, skip the header, and print valid records with their grades and remarks.
            //// Calculate and print the average grade of valid records.
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    reader.ReadLine(); // Skip the header.
            //    string line;
            //    int lineNumber = 1;
            //    int count = 0;
            //    decimal total = 0;


            //    // Print the header for the output table.
            //    Console.WriteLine("{0,-18} {1,6}  {2}", "Name", "Grade", "Remarks");

            //    // Read each line, validate the format, and process valid records.
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        lineNumber++;
            //        string[] fields = line.Split(',');
            //        decimal grade;

            //        if (fields.Length != 3 ||
            //            !decimal.TryParse(fields[1], NumberStyles.Number,
            //                CultureInfo.InvariantCulture, out grade))
            //        {
            //            Console.WriteLine("Skipped line " + lineNumber + ": " + line);
            //            continue;
            //        }

            //        // Print the valid record with formatted output.
            //        Console.WriteLine("{0,-18} {1,6:F1}  {2}", fields[0], grade, fields[2]);
            //        total += grade;
            //        count++;
            //    }

            //    // Calculate and print the average grade of valid records.
            //    if (count > 0)
            //    {
            //        Console.WriteLine("Valid records: " + count);
            //        Console.WriteLine("Average grade: {0:F2}", total / count);
            //    }
            //    //  Handle the case where there are no valid records to average.
            //    else
            //    {
            //        Console.WriteLine("No valid grades to average.");
            //    }
            //}
            //End


            // Demo 4
            //    string folder = @"C:\Users\Jules\Downloads\files\store\output";
            //    string path = Path.Combine(folder, "grades.csv");

            //    if (!Directory.Exists(folder))
            //    {
            //        Console.WriteLine("Folder not found: " + folder);
            //        return;
            //    }

            //    if (!File.Exists(path))
            //    {
            //        File.WriteAllLines(path, new[]
            //        {
            //        "Name,Grade,Remarks",
            //        "Ana Reyes,92,Passed",
            //        "Mark Santos,74,Failed",
            //        "Juan Dela Cruz,88.5,Passed",
            //        "Liza Ramos,ninety,Passed",
            //        "Paolo Lim",
            //        "Carla Mendoza,81,Passed"
            //    });
            //    }
            //    // Read the CSV file, skip the header, and print valid records with their grades and remarks.
            //    using (StreamReader reader = new StreamReader(path))
            //    {
            //        reader.ReadLine(); // Skip the header.
            //        string line;
            //        int lineNumber = 1;
            //        int count = 0;
            //        decimal total = 0;

            //        Console.WriteLine("{0,-18} {1,6}  {2}", "Name", "Grade", "Remarks");
            //        // Read each line, validate the format, and process valid records.
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            lineNumber++;
            //            string[] fields = line.Split(',');
            //            decimal grade;

            //            // Validate the record format and parse the grade, skipping invalid records.
            //            if (fields.Length != 3 ||
            //                !decimal.TryParse(fields[1], NumberStyles.Number,
            //                    CultureInfo.InvariantCulture, out grade))
            //            {
            //                // Print a message indicating the skipped line and continue to the next iteration.
            //                Console.WriteLine("Skipped line " + lineNumber + ": " + line);
            //                continue;
            //            }

            //            // Print the valid record with formatted output.
            //            Console.WriteLine("{0,-18} {1,6:F1}  {2}", fields[0], grade, fields[2]);
            //            total += grade;
            //            count++;
            //        }
            //        // Calculate and print the average grade of valid records.

            //        if (count > 0)
            //        {
            //            Console.WriteLine("Valid records: " + count);
            //            Console.WriteLine("Average grade: {0:F2}", total / count);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No valid grades to average.");
            //        }
            //    }
            //    //End
            //    /

            //     Demo 5
            //     Demonstrate exception handling when reading files, including handling missing files and access issues.
            //        string folder = @"C:\Users\Jules\Downloads\files\store\output";
            //    //  Check if the folder exists, if not, print a message and exit
            //    if (!Directory.Exists(folder))
            //    {
            //        Console.WriteLine("Folder not found: " + folder);
            //        return;
            //    }
            //    //  Create a file "hello.txt" if it doesn't exist, and write some text to it
            //    string helloPath = Path.Combine(folder, "hello.txt");

            //    if (!File.Exists(helloPath))
            //    {
            //        using (StreamWriter writer = new StreamWriter(helloPath))
            //        {
            //            writer.WriteLine("Hello, file!");
            //            writer.WriteLine("This text is saved on the disk.");
            //        }
            //    }
            //    //  Attempt to read from a missing file, which will trigger exception handling
            //    string missingPath = Path.Combine(folder, "missing-demo.txt");
            //    if (File.Exists(missingPath))
            //    {
            //        missingPath = Path.Combine(folder, "missing-" + Guid.NewGuid() + ".txt");
            //    }

            //    ReadFirstLine(missingPath);
            //    ReadFirstLine(helloPath);
            //}
            ////  Method to read the first line of a file, with exception handling for various scenarios
            //static void ReadFirstLine(string path)
            //{
            //    //  Use a try-catch block to handle potential exceptions when reading the file
            //    try
            //    {
            //        using (StreamReader reader = new StreamReader(path))
            //        {
            //            Console.WriteLine(reader.ReadLine() ?? "(The file is empty.)");
            //        }
            //    }
            //    //  Catch specific exceptions to provide meaningful error messages
            //    catch (FileNotFoundException)
            //    {
            //        Console.WriteLine("File not found: " + Path.GetFileName(path));
            //    }
            //    catch (UnauthorizedAccessException)
            //    {
            //        Console.WriteLine("Access denied: " + path);
            //    }
            //    catch (IOException ex)
            //    {
            //        Console.WriteLine("Unable to read the file: " + ex.Message);
            //    }
            //}
            //    //END

            //Lab

            string folder = @"C:\Users\Jules\Downloads\files\store\output";

            // Check that the output folder exists before opening any files.
            if (!Directory.Exists(folder))
            {
                Console.WriteLine("Folder not found: " + folder);
                return;
            }

            try
            {
                CreateSampleGrades(folder);

                // Show each CSV filename without its extension.
                Console.Write("Saved sections:");
                foreach (string file in Directory.GetFiles(folder, "*.csv"))
                {
                    Console.Write(" " + Path.GetFileNameWithoutExtension(file));
                }

                Console.WriteLine();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied: " + folder);
                return;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Unable to prepare the grade files: " + ex.Message);
                return;
            }

            // Keep asking for a section until the user enters a blank line.
            while (true)
            {
                Console.Write("\nSection to view (blank to quit): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                // Convert "BSIT 1A" to "bsit-1a.csv".
                string[] words = input.Split(
                    new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string fileName = string.Join("-", words).ToLowerInvariant() + ".csv";

                if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    Console.WriteLine("Enter a section name such as BSIT 1A.");
                    continue;
                }

                string path = Path.Combine(folder, fileName);

                // Return to the prompt if the selected section has no saved file.
                if (!File.Exists(path))
                {
                    Console.WriteLine("No saved grades for that section (" + fileName + " not found).");
                    continue;
                }

                try
                {
                    ShowGrades(path);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access denied: " + fileName);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Unable to read " + fileName + ": " + ex.Message);
                }
            }
        }

        static void CreateSampleGrades(string folder)
        {
            string path = Path.Combine(folder, "bsit-1a.csv");

            // Use the saved CSV if it already exists.
            if (File.Exists(path))
            {
                return;
            }

            // Two sample rows contain errors so students can test validation.
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Name,Grade,Remarks");
                writer.WriteLine("Ana Reyes,92,Passed");
                writer.WriteLine("Mark Santos,74,Failed");
                writer.WriteLine("Juan Dela Cruz,88.5,Passed");
                writer.WriteLine("Liza Ramos,ninety,Passed");
                writer.WriteLine("Carla Mendoza,81,Passed");
                writer.WriteLine("Ben Torres,69,Failed");
                writer.WriteLine("Paolo Lim");
                writer.WriteLine("Grace Villanueva,95,Passed");
            } // The writer closes here and saves any buffered text.
        }

        static void ShowGrades(string path)
        {
            int lineNumber = 1;
            int studentCount = 0;
            int passedCount = 0;
            int skippedCount = 0;

            decimal total = 0;
            decimal highest = 0;
            decimal lowest = 0;
            string highestName = "";
            string lowestName = "";

            Console.WriteLine("{0,3}  {1,-20} {2,7}  {3}", "#", "Name", "Grade", "Remarks");
            Console.WriteLine(new string('-', 45));

            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine(); // Skip the Name,Grade,Remarks header.

                // Read one line at a time. ReadLine() returns null at the end.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    string[] fields = line.Split(',');
                    decimal grade;

                    // Check the field count before accessing an array index.
                    // InvariantCulture reads the decimal point in grades such as 88.5.
                    if (fields.Length != 3 ||
                        string.IsNullOrWhiteSpace(fields[0]) ||
                        string.IsNullOrWhiteSpace(fields[2]) ||
                        !decimal.TryParse(fields[1], NumberStyles.Number,
                            CultureInfo.InvariantCulture, out grade) ||
                        grade < 0 || grade > 100)
                    {
                        skippedCount++;
                        Console.WriteLine("  ! Line {0} skipped: {1}", lineNumber, line);
                        continue;
                    }

                    string name = fields[0].Trim();
                    string remarks = fields[2].Trim();

                    // Only valid records contribute to the summary.
                    studentCount++;
                    total += grade;

                    if (grade >= 75)
                    {
                        passedCount++;
                    }

                    // Use the first valid grade to start both comparisons.
                    if (studentCount == 1 || grade > highest)
                    {
                        highest = grade;
                        highestName = name;
                    }

                    if (studentCount == 1 || grade < lowest)
                    {
                        lowest = grade;
                        lowestName = name;
                    }

                    Console.WriteLine("{0,3}  {1,-20} {2,7:F1}  {3}",
                        studentCount, name, grade, remarks);
                }
            } // The reader closes here.

            int failedCount = studentCount - passedCount;
            Console.WriteLine("\nStudents : {0} (Passed {1}, Failed {2})",
                studentCount, passedCount, failedCount);

            // Check the count before dividing to avoid dividing by zero.
            if (studentCount > 0)
            {
                Console.WriteLine("Average  : {0:F2}", total / studentCount);
                Console.WriteLine("Highest  : {0} ({1:0.##})", highestName, highest);
                Console.WriteLine("Lowest   : {0} ({1:0.##})", lowestName, lowest);
            }
            else
            {
                Console.WriteLine("No valid grades to summarize.");
            }

            Console.WriteLine("Skipped  : {0} line(s) with errors", skippedCount);
        }

    }
}
