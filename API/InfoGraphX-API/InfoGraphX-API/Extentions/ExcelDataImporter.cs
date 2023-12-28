using InfoGraphX_API.Context;
using InfoGraphX_API.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

public class ExcelDataImporter
{
    private readonly MyDbContext _dbContext;

    public ExcelDataImporter(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void ImportFTVIDataFromExcel(string excelFilePath)
    {
        using (FileStream file = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
        {
            HSSFWorkbook workbook = new HSSFWorkbook(file);
            ISheet sheet = workbook.GetSheetAt(0); // Assuming data is in the first sheet

            //int rowCount = sheet.PhysicalNumberOfRows;
            int rowCount = 137;


            for (int row = 7; row < rowCount; row++) // Assuming the header is in the eighth row
            {
                IRow currentRow = sheet.GetRow(row);

                var data = new ForeignTradeValueIndice
                {
                    Year = Convert.ToInt32(currentRow.GetCell(0).NumericCellValue),
                    Month = currentRow.GetCell(1).StringCellValue,
                    ExportUniteValue = Convert.ToSingle(currentRow.GetCell(2).NumericCellValue),
                    ImportUniteValue = Convert.ToSingle(currentRow.GetCell(4).NumericCellValue)
                };

                _dbContext.ForeignTradeValueIndices.Add(data);
            }

            _dbContext.SaveChanges();
        }
    }

    public void ImportHLBAGDataFromExcel(string excelFilePath)
    {
        using (FileStream file = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
        {
            HSSFWorkbook workbook = new HSSFWorkbook(file);

            ISheet sheet = workbook.GetSheetAt(0);

            for (int row = 6; row < 86; row += 4)
            {


                IRow currentRow = sheet.GetRow(row);
                int currentYear = Convert.ToInt32(currentRow.GetCell(0).NumericCellValue);
                Console.Write("row" + row + " : " + currentYear);
                Console.WriteLine();
                List<int> interval18_24 = new List<int>();
                List<int> interval25_34 = new List<int>();
                List<int> interval35_44 = new List<int>();
                List<int> interval45_54 = new List<int>();
                List<int> interval55_64 = new List<int>();
                List<int> interval65_plus = new List<int>();


                for (int innerRow = row; innerRow < row + 3; innerRow++)
                {
                    IRow innerRow_ = sheet.GetRow(innerRow);
                    //  Console.Write(innerRow + "        " + Convert.ToSingle(innerRow_.GetCell(2).NumericCellValue));


                    //18-24
                    interval18_24.Add(Convert.ToInt32(innerRow_.GetCell(2).NumericCellValue));
                    //25-34
                    interval25_34.Add(Convert.ToInt32(innerRow_.GetCell(3).NumericCellValue));
                    //35-44
                    interval35_44.Add(Convert.ToInt32(innerRow_.GetCell(4).NumericCellValue));
                    //45-54
                    interval45_54.Add(Convert.ToInt32(innerRow_.GetCell(5).NumericCellValue));
                    //55-64
                    interval55_64.Add(Convert.ToInt32(innerRow_.GetCell(6).NumericCellValue));
                    //65plus
                    interval65_plus.Add(Convert.ToInt32(innerRow_.GetCell(7).NumericCellValue));
                }


                _dbContext.HappinesRates.Add(new HappinesRates
                {
                    AgeInterval = "18-24",
                    HappinesRatesId = row,
                    HappyRate = interval18_24[0],
                    MediumRate = interval18_24[1],
                    UpsetRate = interval18_24[2],

                });


                _dbContext.HappinesRates.Add(new HappinesRates
                {
                    AgeInterval = "25-34",
                    HappinesRatesId = row,
                    HappyRate = interval25_34[0],
                    MediumRate = interval25_34[1],
                    UpsetRate = interval25_34[2],

                });

                _dbContext.HappinesRates.Add(new HappinesRates
                {
                    AgeInterval = "35-44",
                    HappinesRatesId = row,
                    HappyRate = interval35_44[0],
                    MediumRate = interval35_44[1],
                    UpsetRate = interval35_44[2],

                });

                _dbContext.HappinesRates.Add(new HappinesRates
                {
                    AgeInterval = "45-54",
                    HappinesRatesId = row,
                    HappyRate = interval45_54[0],
                    MediumRate = interval45_54[1],
                    UpsetRate = interval45_54[2],

                });

                _dbContext.HappinesRates.Add(new HappinesRates
                {
                    AgeInterval = "55-64",
                    HappinesRatesId = row,
                    HappyRate = interval55_64[0],
                    MediumRate = interval55_64[1],
                    UpsetRate = interval55_64[2],

                });

                _dbContext.HappinesRates.Add(new HappinesRates
                {

                    AgeInterval = "65+",
                    HappinesRatesId = row,
                    HappyRate = interval65_plus[0],
                    MediumRate = interval65_plus[1],
                    UpsetRate = interval65_plus[2],

                });
                _dbContext.HappinessLevelByAgeGroups.Add(new HappinessLevelByAgeGroup
                {
                    Year = currentYear,
                    HappinesRatesId = row

                });
                interval18_24.Clear();
                interval25_34.Clear();
                interval35_44.Clear();
                interval45_54.Clear();
                interval55_64.Clear();
                interval65_plus.Clear();
            }

            _dbContext.SaveChanges();
        }
    }
}
