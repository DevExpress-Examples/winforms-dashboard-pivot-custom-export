Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DashboardCommon
Imports DevExpress.Drawing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.PivotGrid

Namespace WinFormsExport
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			For Each item As PivotDashboardItem In dashboardViewer1.Dashboard.Items
				item.AutoExpandColumnGroups = True
				item.AutoExpandRowGroups = True
			Next item
		End Sub

		Private Sub dashboardViewer1_CustomExport(ByVal sender As Object, ByVal e As CustomExportEventArgs) Handles dashboardViewer1.CustomExport
			Dim pivot1 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem1"), XRPivotGrid)
			Dim pivot2 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem2"), XRPivotGrid)
			Dim pivot3 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem3"), XRPivotGrid)
			Dim pivot4 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem4"), XRPivotGrid)
			Dim pivot5 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem5"), XRPivotGrid)
			Dim pivot6 As XRPivotGrid = TryCast(e.GetPrintableControl("pivotDashboardItem6"), XRPivotGrid)
			If pivot1 IsNot Nothing Then
				AddHandler pivot1.CustomFieldValueCells, AddressOf PivotCustomFieldValueCells
				AddHandler pivot1.AfterPrint, AddressOf PivotAfterPrint
			End If
			If pivot2 IsNot Nothing Then
				AddHandler pivot2.CustomColumnWidth, AddressOf PivotCustomColumnWidth
				AddHandler pivot2.CustomRowHeight, AddressOf PivotCustomRowHeight
				AddHandler pivot2.AfterPrint, AddressOf PivotAfterPrint
			End If
			If pivot3 IsNot Nothing Then
				AddHandler pivot3.FieldValueDisplayText, AddressOf PivotFieldValueDisplayText
				AddHandler pivot3.AfterPrint, AddressOf PivotAfterPrint
			End If
			If pivot4 IsNot Nothing Then
				AddHandler pivot4.PrintCell, AddressOf PivotPrintCell
				AddHandler pivot4.PrintFieldValue, AddressOf PivotPrintFieldValue
				AddHandler pivot4.AfterPrint, AddressOf PivotAfterPrint
			End If
			If pivot5 IsNot Nothing Then
				AddHandler pivot5.CustomFieldValueCells, AddressOf PivotCustomFieldValueCellsVals
				AddHandler pivot5.AfterPrint, AddressOf PivotAfterPrint
			End If
			If pivot6 IsNot Nothing Then
				AddHandler pivot6.CustomFieldValueCells, AddressOf PivotCustomFieldValueCellsResults
				pivot6.OptionsView.ShowRowGrandTotals = False
				AddHandler pivot6.AfterPrint, AddressOf PivotAfterPrint
			End If
		End Sub

		Private Sub PivotAfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			Dim pivotGrid As XRPivotGrid = DirectCast(sender, XRPivotGrid)
			RemoveHandler pivotGrid.CustomFieldValueCells, AddressOf PivotCustomFieldValueCells
			RemoveHandler pivotGrid.CustomFieldValueCells, AddressOf PivotCustomFieldValueCellsVals
			RemoveHandler pivotGrid.CustomFieldValueCells, AddressOf PivotCustomFieldValueCellsResults
			RemoveHandler pivotGrid.CustomColumnWidth, AddressOf PivotCustomColumnWidth
			RemoveHandler pivotGrid.CustomRowHeight, AddressOf PivotCustomRowHeight
			RemoveHandler pivotGrid.FieldValueDisplayText, AddressOf PivotFieldValueDisplayText
			RemoveHandler pivotGrid.PrintCell, AddressOf PivotPrintCell
			RemoveHandler pivotGrid.PrintFieldValue, AddressOf PivotPrintFieldValue
			RemoveHandler pivotGrid.AfterPrint, AddressOf PivotAfterPrint
		End Sub

		Private Sub PivotPrintFieldValue(ByVal sender As Object, ByVal e As CustomExportFieldValueEventArgs)
			If Not e.IsColumn AndAlso e.Value?.ToString()?.Trim() = "Seattle" Then
'INSTANT VB NOTE: The variable font was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim font_Renamed = New DXFont(e.Appearance.Font, DXFontStyle.Bold)
				e.Appearance.Font = font_Renamed
			End If
		End Sub

		Private Sub PivotPrintCell(ByVal sender As Object, ByVal e As CustomExportCellEventArgs)
			If e.RowValue?.DisplayText?.Trim() = "Seattle" Then
'INSTANT VB NOTE: The variable font was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim font_Renamed = New DXFont(e.Appearance.Font, DXFontStyle.Bold)
				e.Appearance.Font = font_Renamed
				e.Appearance.ForeColor = System.Drawing.Color.Red
				e.Appearance.BackColor = System.Drawing.Color.AliceBlue
			End If
		End Sub

		Private Sub PivotFieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
			RenameColumn(e, New Dictionary(Of String, String) From {
				{ "1", "Qtr.1" },
				{ "2", "Qtr.2" },
				{ "3", "Qtr.3" },
				{ "4", "Qtr.4" }
			})
		End Sub

		Private Sub RenameColumn(ByVal e As PivotFieldDisplayTextEventArgs, ByVal map As Dictionary(Of String, String))
			If e.IsColumn AndAlso Not String.IsNullOrEmpty(e.DisplayText) AndAlso map.ContainsKey(e.DisplayText.Trim()) Then
				e.DisplayText = map(e.DisplayText.Trim())
			End If
		End Sub

		Private Sub PivotCustomRowHeight(ByVal sender As Object, ByVal e As PivotCustomRowHeightEventArgs)
			If Object.Equals(e.Value?.ToString()?.Trim(), "London") AndAlso e.ValueType <> PivotGridValueType.Total Then
				e.RowHeight = 100
			End If
		End Sub

		Private Sub PivotCustomColumnWidth(ByVal sender As Object, ByVal e As PivotCustomColumnWidthEventArgs)
			If Object.Equals(e.Value, 2) AndAlso e.ValueType <> PivotGridValueType.Total Then
				e.ColumnWidth = 120
			End If
		End Sub

		Private Sub PivotCustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
			RemoveColumnByName(e, "1", "3")
			RemoveRowByName(e, "Kirkland")
		End Sub

		Private Sub PivotCustomFieldValueCellsVals(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
			RemoveCellsByValue(e, False, False, 200)
		End Sub

		Private Sub PivotCustomFieldValueCellsResults(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
			e.SetGrandTotalLocation(True, DevExpress.XtraPivotGrid.Data.GrandTotalLocation.Near)
		End Sub

		Private Sub RemoveRowByName(ByVal e As PivotCustomFieldValueCellsEventArgs, ParamArray ByVal rowName() As String)
			For i As Integer = e.GetCellCount(False) - 1 To 0 Step -1
				Dim cell As FieldValueCell = e.GetCell(False, i)
				If cell?.Value Is Nothing Then
					Continue For
				End If

				If rowName.Contains(cell.Value.ToString().Trim()) AndAlso cell.ValueType <> PivotGridValueType.Total Then
					e.Remove(cell)
				End If
			Next i
		End Sub

		Private Sub RemoveColumnByName(ByVal e As PivotCustomFieldValueCellsEventArgs, ParamArray ByVal colName() As String)
			For i As Integer = e.GetCellCount(True) - 1 To 0 Step -1
				Dim cell As FieldValueCell = e.GetCell(True, i)
				If cell?.Value Is Nothing Then
					Continue For
				End If
				If colName.Contains(cell.Value.ToString().Trim()) AndAlso cell.ValueType <> PivotGridValueType.Total Then
					e.Remove(cell)
				End If
			Next i
		End Sub

		Private Sub RemoveCellsByValue(ByVal e As PivotCustomFieldValueCellsEventArgs, ByVal isColumn As Boolean, ByVal isNull As Boolean, ByVal lessValue As Decimal)
			Dim cells As List(Of FieldValueCell) = e.FindAllCells(isColumn, New Predicate(Of Object())(Function(dataCellValues)
				For Each value As Object In dataCellValues
					If value Is Nothing AndAlso Not isNull Then
						Continue For
					End If
					If DirectCast(value, Decimal) >= lessValue Then
						Return False
					End If
				Next value
				Return True
			End Function))
			For Each cell In cells
				e.Remove(cell)
			Next cell
		End Sub
	End Class
End Namespace
