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

    ////EXCELLDEKİ VERİLERİN DÜZENİNDEN DOLAYI DÜZGÜN BİR OKUMA YÖNTEMİ GELİŞTİREMEDİM.(elle girilebilir)
    //public void ImportHLBAGDataFromExcel(string excelFilePath)
    //{
    //    using (FileStream file = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
    //    {
    //        HSSFWorkbook workbook = new HSSFWorkbook(file);
    //        ISheet sheet = workbook.GetSheetAt(0); 

    //        int rowCount = sheet.PhysicalNumberOfRows;

    //        for (int row = 7; row < rowCount; row++) 
    //        {
    //            IRow currentRow = sheet.GetRow(row);

    //            var data = new HappinessLevelByAgeGroup
    //            {
    //                Year = Convert.ToInt32(currentRow.GetCell(0).NumericCellValue),
    //                AgeGroup = currentRow.GetCell(1).StringCellValue,
    //                Happy = Convert.ToSingle(currentRow.GetCell(2).NumericCellValue),
    //                Medium = Convert.ToSingle(currentRow.GetCell(3).NumericCellValue),
    //                UnHappy = Convert.ToSingle(currentRow.GetCell(4).NumericCellValue)
    //            };

    //            _dbContext.HappinessLevelByAgeGroups.Add(data);
    //        }

    //        _dbContext.SaveChanges();
    //    }
    //}

}
