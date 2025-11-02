using System.Text;

string root = Directory.GetCurrentDirectory();
string dir = Path.Join(root, "stores", "201");

// Create directory if it doesn't exist
Directory.CreateDirectory(dir);

// Create sales files with sample data
string salesFilesPath = Path.Join(root, "stores", "201", "sales.json");
if (!File.Exists(salesFilesPath))
{
    File.WriteAllText(salesFilesPath, "{ \"total\": 100000.00 }");
}

// Add more sales files for demonstration
string salesFilesPath2 = Path.Join(root, "stores", "201", "sales2.json");
if (!File.Exists(salesFilesPath2))
{
    File.WriteAllText(salesFilesPath2, "{ \"total\": 250000.50 }");
}

string salesFilesPath3 = Path.Join(root, "stores", "201", "sales3.json");
if (!File.Exists(salesFilesPath3))
{
    File.WriteAllText(salesFilesPath3, "{ \"total\": 175000.75 }");
}

// Generate sales summary report
GenerateSalesSummaryReport(root);

static void GenerateSalesSummaryReport(string rootDirectory)
{
    string storesDir = Path.Join(rootDirectory, "stores", "201");
    
    if (!Directory.Exists(storesDir))
    {
        Console.WriteLine("Stores directory not found.");
        return;
    }

    var salesFiles = Directory.GetFiles(storesDir, "sales*.json");
    
    if (salesFiles.Length == 0)
    {
        Console.WriteLine("No sales files found.");
        return;
    }

    StringBuilder report = new StringBuilder();
    report.AppendLine("Sales Summary");
    report.AppendLine("----------------------------");
    
    decimal totalSales = 0;
    var details = new List<(string filename, decimal amount)>();

    foreach (var file in salesFiles)
    {
        try
        {
            string content = File.ReadAllText(file);
            // Simple JSON parsing - extract total value
            var totalMatch = System.Text.RegularExpressions.Regex.Match(content, @"""total""\s*:\s*([0-9]+\.?[0-9]*)");
            if (totalMatch.Success && decimal.TryParse(totalMatch.Groups[1].Value, out decimal amount))
            {
                string filename = Path.GetFileName(file);
                totalSales += amount;
                details.Add((filename, amount));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file {file}: {ex.Message}");
        }
    }

    report.AppendLine($" Total Sales: {totalSales:C}");
    report.AppendLine();
    report.AppendLine(" Details:");

    foreach (var (filename, amount) in details)
    {
        report.AppendLine($"  {filename}: {amount:C}");
    }

    // Write report to file
    string reportPath = Path.Join(storesDir, "sales-summary.txt");
    File.WriteAllText(reportPath, report.ToString());
    
    // Also display to console
    Console.WriteLine(report.ToString());
    Console.WriteLine($"\nReport saved to: {reportPath}");
}

