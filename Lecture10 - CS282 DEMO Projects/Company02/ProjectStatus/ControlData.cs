using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace ProjectStatus
{
    public class ControlData
    {
        private XLWorkbook workbook = new XLWorkbook("project.xlsx");
        private int currentPage = new int();
        private int totalPages = new int();
        private int yearValue = new int();
        private string projectNumber;
        private string productName;
        private string projectOpenDate;
        private string productDescription;
        private string projectStatus;
        private string saftyStatus;
        private string projectNote;

        public int CurrentPage
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                string itemNumber = worksheet.Cell(1, 1).Value.ToString();

                if (itemNumber == "")
                {
                    this.currentPage = 0;
                }
                return currentPage;
            }
            set
            {
                if ((value <= this.totalPages) & (value > 0))
                {
                    this.currentPage = value;
                }
            }
        }

        public int TotalPages
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                string itemNumber;

                this.totalPages = 0;
                do
                {
                    this.totalPages++;
                    itemNumber = worksheet.Cell(this.totalPages, 1).Value.ToString();
                }
                while (itemNumber != "");

                this.totalPages--;
                return this.totalPages;
            }
        }

        public int YearValue
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.yearValue = 0;
                }
                else
                {
                    string stringYear = worksheet.Cell(this.currentPage, 2).Value.ToString();
                    bool conversionSuccessful = int.TryParse(stringYear, out this.yearValue);
                    if (conversionSuccessful == false)
                    {
                        this.yearValue = 0;
                    }
                }
                return this.yearValue;
            }
            set
            {
                if ((value >= 2000) && (value < 2100))
                {
                    this.yearValue = value;
                }
            }
        }

        public string ProjectNumber
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.projectNumber = "";
                }
                else
                {
                    this.projectNumber = worksheet.Cell(this.currentPage, 3).Value.ToString();
                }
                return this.projectNumber;
            }
            set
            {
                this.projectNumber = value;
            }
        }

        public string ProductName
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.productName = "";
                }
                else
                {
                    this.productName = worksheet.Cell(this.currentPage, 4).Value.ToString();
                }
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        public string ProjectOpenDate
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.projectOpenDate = "";
                }
                else
                {
                    this.projectOpenDate = Convert.ToDateTime(worksheet.Cell(this.currentPage, 5).Value).ToString("yyyy/MM/dd");
                }
                return this.projectOpenDate;
            }
            set
            {
                this.projectOpenDate = value;
            }
        }

        public string ProductDescription
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.productDescription = "";
                }
                else
                {
                    this.productDescription = worksheet.Cell(this.currentPage, 6).Value.ToString();
                }
                return this.productDescription;
            }
            set
            {
                this.productDescription = value;
            }
        }

        public string ProjectStatus
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.projectStatus = "";
                }
                else
                {
                    this.projectStatus = worksheet.Cell(this.currentPage, 7).Value.ToString();
                }
                return this.projectStatus;
            }
            set
            {
                this.projectStatus = value;
            }
        }

        public string SaftyStatus
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.saftyStatus = "";
                }
                else
                {
                    this.saftyStatus = worksheet.Cell(this.currentPage, 8).Value.ToString();
                }
                return this.saftyStatus;
            }
            set
            {
                this.saftyStatus = value;
            }
        }

        public string ProjectNote
        {
            get
            {
                var worksheet = workbook.Worksheet(1);
                if (this.currentPage == 0)
                {
                    this.projectNote = "";
                }
                else
                {
                    this.projectNote = worksheet.Cell(this.currentPage, 9).Value.ToString();
                }
                return this.projectNote;
            }
            set
            {
                this.projectNote = value;
            }
        }

        public void Initialize()
        {
            this.totalPages = TotalPages;
            if (this.totalPages != 0)
            {
                this.currentPage = 1;
            }
        }

        public void Save()
        {
            var worksheet = workbook.Worksheet(1);
            worksheet.Cell(this.currentPage, 1).Value = currentPage;
            worksheet.Cell(this.currentPage, 2).Value = yearValue;
            worksheet.Cell(this.currentPage, 3).Value = projectNumber;
            worksheet.Cell(this.currentPage, 4).Value = productName;
            worksheet.Cell(this.currentPage, 5).Value = projectOpenDate;
            worksheet.Cell(this.currentPage, 6).Value = productDescription;
            worksheet.Cell(this.currentPage, 7).Value = projectStatus;
            worksheet.Cell(this.currentPage, 8).Value = saftyStatus;
            worksheet.Cell(this.currentPage, 9).Value = projectNote;
            workbook.Save();
        }

        public void New()
        {
            this.currentPage += 1;
            this.totalPages += 1;
        }

        /*
        protected string fileName = "project.xlsx";
        //        private XLWorkbook workbook = new XLWorkbook();
        //        private XLWorkbook workbook = new XLWorkbook(fileName);

        public void Open()
        {
            if (System.IO.File.Exists(fileName))
            {
                //檔案存在
                XLWorkbook workbook = new XLWorkbook(fileName);
                var worksheet = workbook.Worksheet(1);

                string x = worksheet.Cell("A1").Value.ToString();
                int y = int.Parse(x);
                int z = y + 1;
                y += 1;

                worksheet.Cell("A1").Value = y.ToString();
                worksheet.Cell(z, y).Value = y.ToString();

                //  worksheet.Cell("A1").Value = y.ToString();
                workbook.Save();
                //workbook.Cell("A1").Value = "Hello World!";
                //workbook.SaveAs("Helloworld.xlsx");
            }
            else
            {
                //檔案不存在
                XLWorkbook workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("ProjectStatus");
                worksheet.Cell("A1").Value = "1";
                workbook.SaveAs(fileName);
            }
        }

        public void Save()
        {
        }
        */
    }
}