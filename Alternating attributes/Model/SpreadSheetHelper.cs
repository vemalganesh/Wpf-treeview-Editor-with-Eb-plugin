﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alternating_attributes.Model
{
    public class SpreadSheetHelper
    {
        public WorkbookPart workbookPart { get; set; }
        public Worksheet workSheet { get; set; }
        public string SheetId { get; set; }
        public WorksheetPart WorkSheetPart { get; set; }
        public SharedStringTablePart SharedStringTablePart { get; set; }
        public SharedStringTable sharedStringTable { get; set; }
        public List<Row> Rows { get; set; }
        public Sheets MultipleSheet { get; set; } 
        public string SheetName { get; set; }
}
}
