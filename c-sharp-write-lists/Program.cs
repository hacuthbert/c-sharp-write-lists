using CsvHelper;
using System.Globalization;
using c_sharp_write_lists;


internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfRecords = 100;
        int startingNumber = 62001;
        int startingSequence = 62001;
        string kitTypeCode = "A";
        int lastNumber = startingNumber + numberOfRecords;

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string kitListName = $"KitList - kit type {kitTypeCode} {startingNumber}to{lastNumber}.csv";
        string fullPath = Path.Combine(desktopPath, kitListName);

        List<Utilities.KitList> records = new List<Utilities.KitList>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            records.Add(new Utilities.KitList( startingNumber + i, startingSequence + i, kitTypeCode ));
        }


        using (var writer = new StreamWriter(fullPath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(records);
        }

        Console.WriteLine(fullPath);
    }
}