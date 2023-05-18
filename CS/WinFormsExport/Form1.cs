using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.Drawing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;

namespace WinFormsExport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            foreach(PivotDashboardItem item in dashboardViewer1.Dashboard.Items) {
                item.AutoExpandColumnGroups = true;
                item.AutoExpandRowGroups = true;
            }
        }

        void dashboardViewer1_CustomExport(object sender, CustomExportEventArgs e) {
            XRPivotGrid pivot1 = e.GetPrintableControl("pivotDashboardItem1") as XRPivotGrid;
            XRPivotGrid pivot2 = e.GetPrintableControl("pivotDashboardItem2") as XRPivotGrid;
            XRPivotGrid pivot3 = e.GetPrintableControl("pivotDashboardItem3") as XRPivotGrid;
            XRPivotGrid pivot4 = e.GetPrintableControl("pivotDashboardItem4") as XRPivotGrid;
            XRPivotGrid pivot5 = e.GetPrintableControl("pivotDashboardItem5") as XRPivotGrid;
            XRPivotGrid pivot6 = e.GetPrintableControl("pivotDashboardItem6") as XRPivotGrid;
            if(pivot1 != null) {
                pivot1.CustomFieldValueCells += PivotCustomFieldValueCells;
                pivot1.AfterPrint += PivotAfterPrint;
            }
            if(pivot2 != null) {
                pivot2.CustomColumnWidth += PivotCustomColumnWidth;
                pivot2.CustomRowHeight += PivotCustomRowHeight;
                pivot2.AfterPrint += PivotAfterPrint;
            }
            if(pivot3 != null) {
                pivot3.FieldValueDisplayText += PivotFieldValueDisplayText;
                pivot3.AfterPrint += PivotAfterPrint;
            }
            if(pivot4 != null) {
                pivot4.PrintCell += PivotPrintCell;
                pivot4.PrintFieldValue += PivotPrintFieldValue;
                pivot4.AfterPrint += PivotAfterPrint;
            }
            if(pivot5 != null) {
                pivot5.CustomFieldValueCells += PivotCustomFieldValueCellsVals;
                pivot5.AfterPrint += PivotAfterPrint;
            }
            if(pivot6 != null) {
                pivot6.CustomFieldValueCells += PivotCustomFieldValueCellsResults;
                pivot6.OptionsView.ShowRowGrandTotals = false;
                pivot6.AfterPrint += PivotAfterPrint;
            }
        }

        void PivotAfterPrint(object sender, EventArgs e) {
            XRPivotGrid pivotGrid = (XRPivotGrid)sender;
            pivotGrid.CustomFieldValueCells -= PivotCustomFieldValueCells;
            pivotGrid.CustomFieldValueCells -= PivotCustomFieldValueCellsVals;
            pivotGrid.CustomFieldValueCells -= PivotCustomFieldValueCellsResults;
            pivotGrid.CustomColumnWidth -= PivotCustomColumnWidth;
            pivotGrid.CustomRowHeight -= PivotCustomRowHeight;
            pivotGrid.FieldValueDisplayText -= PivotFieldValueDisplayText;
            pivotGrid.PrintCell -= PivotPrintCell;
            pivotGrid.PrintFieldValue -= PivotPrintFieldValue;
            pivotGrid.AfterPrint -= PivotAfterPrint;
        }

        void PivotPrintFieldValue(object sender, CustomExportFieldValueEventArgs e) {
            if(!e.IsColumn && e.Value?.ToString()?.Trim() == "Seattle") {
                var font = new DXFont(e.Appearance.Font, DXFontStyle.Bold);
                e.Appearance.Font = font;
            }
        }

        void PivotPrintCell(object sender, CustomExportCellEventArgs e) {
            if(e.RowValue?.DisplayText?.Trim() == "Seattle") {
                var font = new DXFont(e.Appearance.Font, DXFontStyle.Bold);
                e.Appearance.Font = font;
                e.Appearance.ForeColor = System.Drawing.Color.Red;
                e.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            }
        }

        void PivotFieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            RenameColumn(e, new Dictionary<string, string> {
                { "1", "Qtr.1" },
                { "2", "Qtr.2" },
                { "3", "Qtr.3" },
                { "4", "Qtr.4" },
            });
        }

        void RenameColumn(PivotFieldDisplayTextEventArgs e, Dictionary<string, string> map) {
            if(e.IsColumn && !string.IsNullOrEmpty(e.DisplayText) && map.ContainsKey(e.DisplayText.Trim())) {
                e.DisplayText = map[e.DisplayText.Trim()];
            }
        }

        void PivotCustomRowHeight(object sender, PivotCustomRowHeightEventArgs e) {
            if(object.Equals(e.Value?.ToString()?.Trim(), "London") && e.ValueType != PivotGridValueType.Total) {
                e.RowHeight = 100;
            }
        }

        void PivotCustomColumnWidth(object sender, PivotCustomColumnWidthEventArgs e) {
            if(object.Equals(e.Value, 2) && e.ValueType != PivotGridValueType.Total)
                e.ColumnWidth = 120;
        }

        void PivotCustomFieldValueCells(object sender, PivotCustomFieldValueCellsEventArgs e) {
            RemoveColumnByName(e, "1", "3");
            RemoveRowByName(e, "Kirkland");
        }

        void PivotCustomFieldValueCellsVals(object sender, PivotCustomFieldValueCellsEventArgs e) {
            RemoveCellsByValue(e, false, false, 200);
        }

        void PivotCustomFieldValueCellsResults(object sender, PivotCustomFieldValueCellsEventArgs e) {
            e.SetGrandTotalLocation(true, DevExpress.XtraPivotGrid.Data.GrandTotalLocation.Near);
        }

        void RemoveRowByName(PivotCustomFieldValueCellsEventArgs e, params string[] rowName) {
            for(int i = e.GetCellCount(false) - 1; i >= 0; i--) {
                FieldValueCell cell = e.GetCell(false, i);
                if(cell?.Value == null)
                    continue;

                if(rowName.Contains(cell.Value.ToString().Trim()) &&
                  cell.ValueType != PivotGridValueType.Total)
                    e.Remove(cell);
            }
        }

        void RemoveColumnByName(PivotCustomFieldValueCellsEventArgs e, params string[] colName) {
            for(int i = e.GetCellCount(true) - 1; i >= 0; i--) {
                FieldValueCell cell = e.GetCell(true, i);
                if(cell?.Value == null)
                    continue;
                if(colName.Contains(cell.Value.ToString().Trim()) &&
                  cell.ValueType != PivotGridValueType.Total)
                    e.Remove(cell);
            }
        }

        void RemoveCellsByValue(PivotCustomFieldValueCellsEventArgs e, bool isColumn, bool isNull, decimal lessValue) {
            List<FieldValueCell> cells = e.FindAllCells(isColumn, new Predicate<object[]>((dataCellValues) => {
                foreach(object value in dataCellValues) {
                    if(value == null && !isNull)
                        continue;
                    if((decimal)value >= lessValue)
                        return false;
                }
                return true;
            }));
            foreach(var cell in cells)
                e.Remove(cell);
        }
    }
}
