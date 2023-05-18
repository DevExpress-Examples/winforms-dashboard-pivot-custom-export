Namespace WinFormsExport
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim allColumns1 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns2 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns3 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns4 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join3 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension6 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension7 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension8 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim dimension9 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension10 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension11 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension12 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim dimension13 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension14 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension15 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension16 As New DevExpress.DashboardCommon.Dimension()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim dimension17 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension18 As New DevExpress.DashboardCommon.Dimension()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim dimension19 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension20 As New DevExpress.DashboardCommon.Dimension()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup4 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup5 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem5 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem6 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
			Me.pivotDashboardItem3 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.pivotDashboardItem2 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.pivotDashboardItem4 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.pivotDashboardItem5 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.pivotDashboardItem6 = New DevExpress.DashboardCommon.PivotDashboardItem()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension13, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension14, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension15, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension16, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension17, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension18, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotDashboardItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension19, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension20, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' pivotDashboardItem1
			' 
			dimension1.DataMember = "OrderDate"
			dimension2.DataMember = "OrderDate"
			dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
			Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1, dimension2})
			Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
			dimension3.DataMember = "City"
			measure1.DataMember = "UnitPrice"
			dimension4.DataMember = "Country"
			Me.pivotDashboardItem1.DataItemRepository.Clear()
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem4")
			Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem2")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem3")
			Me.pivotDashboardItem1.DataMember = "Orders"
			Me.pivotDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem1.Name = "Remove Specified Columns and Rows"
			Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4, dimension3})
			Me.pivotDashboardItem1.ShowCaption = True
			Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
			' 
			' dashboardSqlDataSource1
			' 
			Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
			Me.dashboardSqlDataSource1.ConnectionName = "NWindConnectionString"
			Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""347"" />"
			table1.Name = "Orders"
			allColumns1.Table = table1
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""467"" />"
			table2.Name = "Employees"
			allColumns2.Table = table2
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""167"" />"
			table3.Name = "OrderDetails"
			allColumns3.Table = table3
			table4.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""287"" />"
			table4.Name = "Products"
			allColumns4.Table = table4
			selectQuery1.Columns.Add(allColumns1)
			selectQuery1.Columns.Add(allColumns2)
			selectQuery1.Columns.Add(allColumns3)
			selectQuery1.Columns.Add(allColumns4)
			selectQuery1.Name = "Orders"
			relationColumnInfo1.NestedKeyColumn = "EmployeeID"
			relationColumnInfo1.ParentKeyColumn = "EmployeeID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "OrderID"
			relationColumnInfo2.ParentKeyColumn = "OrderID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			relationColumnInfo3.NestedKeyColumn = "ProductID"
			relationColumnInfo3.ParentKeyColumn = "ProductID"
			join3.KeyColumns.Add(relationColumnInfo3)
			join3.Nested = table4
			join3.Parent = table3
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Relations.Add(join3)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			selectQuery1.Tables.Add(table4)
			Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
			' 
			' pivotDashboardItem3
			' 
			dimension5.DataMember = "OrderDate"
			dimension6.DataMember = "OrderDate"
			dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
			Me.pivotDashboardItem3.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension5, dimension6})
			Me.pivotDashboardItem3.ComponentName = "pivotDashboardItem3"
			dimension7.DataMember = "Country"
			dimension8.DataMember = "City"
			measure2.DataMember = "UnitPrice"
			Me.pivotDashboardItem3.DataItemRepository.Clear()
			Me.pivotDashboardItem3.DataItemRepository.Add(dimension5, "DataItem0")
			Me.pivotDashboardItem3.DataItemRepository.Add(dimension6, "DataItem1")
			Me.pivotDashboardItem3.DataItemRepository.Add(dimension7, "DataItem2")
			Me.pivotDashboardItem3.DataItemRepository.Add(dimension8, "DataItem3")
			Me.pivotDashboardItem3.DataItemRepository.Add(measure2, "DataItem4")
			Me.pivotDashboardItem3.DataMember = "Orders"
			Me.pivotDashboardItem3.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem3.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem3.Name = "Rename Columns"
			Me.pivotDashboardItem3.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension7, dimension8})
			Me.pivotDashboardItem3.ShowCaption = True
			Me.pivotDashboardItem3.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
			' 
			' pivotDashboardItem2
			' 
			dimension9.DataMember = "OrderDate"
			dimension10.DataMember = "OrderDate"
			dimension10.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
			Me.pivotDashboardItem2.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension9, dimension10})
			Me.pivotDashboardItem2.ComponentName = "pivotDashboardItem2"
			dimension11.DataMember = "Country"
			dimension12.DataMember = "City"
			measure3.DataMember = "UnitPrice"
			Me.pivotDashboardItem2.DataItemRepository.Clear()
			Me.pivotDashboardItem2.DataItemRepository.Add(dimension9, "DataItem0")
			Me.pivotDashboardItem2.DataItemRepository.Add(dimension10, "DataItem1")
			Me.pivotDashboardItem2.DataItemRepository.Add(dimension11, "DataItem2")
			Me.pivotDashboardItem2.DataItemRepository.Add(dimension12, "DataItem3")
			Me.pivotDashboardItem2.DataItemRepository.Add(measure3, "DataItem4")
			Me.pivotDashboardItem2.DataMember = "Orders"
			Me.pivotDashboardItem2.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem2.Name = "Resize Columns and Rows"
			Me.pivotDashboardItem2.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension11, dimension12})
			Me.pivotDashboardItem2.ShowCaption = True
			Me.pivotDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3})
			' 
			' pivotDashboardItem4
			' 
			dimension13.DataMember = "OrderDate"
			dimension14.DataMember = "OrderDate"
			dimension14.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter
			Me.pivotDashboardItem4.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension13, dimension14})
			Me.pivotDashboardItem4.ComponentName = "pivotDashboardItem4"
			dimension15.DataMember = "Country"
			dimension16.DataMember = "City"
			measure4.DataMember = "UnitPrice"
			Me.pivotDashboardItem4.DataItemRepository.Clear()
			Me.pivotDashboardItem4.DataItemRepository.Add(dimension13, "DataItem0")
			Me.pivotDashboardItem4.DataItemRepository.Add(dimension14, "DataItem1")
			Me.pivotDashboardItem4.DataItemRepository.Add(dimension15, "DataItem2")
			Me.pivotDashboardItem4.DataItemRepository.Add(dimension16, "DataItem3")
			Me.pivotDashboardItem4.DataItemRepository.Add(measure4, "DataItem4")
			Me.pivotDashboardItem4.DataMember = "Orders"
			Me.pivotDashboardItem4.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem4.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem4.Name = "Change Row Appearance"
			Me.pivotDashboardItem4.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension15, dimension16})
			Me.pivotDashboardItem4.ShowCaption = True
			Me.pivotDashboardItem4.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure4})
			' 
			' pivotDashboardItem5
			' 
			dimension17.DataMember = "Country"
			Me.pivotDashboardItem5.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension17})
			Me.pivotDashboardItem5.ComponentName = "pivotDashboardItem5"
			dimension18.DataMember = "ShipCity"
			measure5.DataMember = "UnitPrice"
			Me.pivotDashboardItem5.DataItemRepository.Clear()
			Me.pivotDashboardItem5.DataItemRepository.Add(dimension17, "DataItem0")
			Me.pivotDashboardItem5.DataItemRepository.Add(dimension18, "DataItem1")
			Me.pivotDashboardItem5.DataItemRepository.Add(measure5, "DataItem2")
			Me.pivotDashboardItem5.DataMember = "Orders"
			Me.pivotDashboardItem5.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem5.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem5.Name = "Remove Rows by Value"
			Me.pivotDashboardItem5.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension18})
			Me.pivotDashboardItem5.ShowCaption = True
			Me.pivotDashboardItem5.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure5})
			' 
			' pivotDashboardItem6
			' 
			dimension19.DataMember = "OrderDate"
			Me.pivotDashboardItem6.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension19})
			Me.pivotDashboardItem6.ComponentName = "pivotDashboardItem6"
			dimension20.DataMember = "Country"
			measure6.DataMember = "UnitPrice"
			Me.pivotDashboardItem6.DataItemRepository.Clear()
			Me.pivotDashboardItem6.DataItemRepository.Add(dimension19, "DataItem0")
			Me.pivotDashboardItem6.DataItemRepository.Add(dimension20, "DataItem1")
			Me.pivotDashboardItem6.DataItemRepository.Add(measure6, "DataItem2")
			Me.pivotDashboardItem6.DataMember = "Orders"
			Me.pivotDashboardItem6.DataSource = Me.dashboardSqlDataSource1
			Me.pivotDashboardItem6.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem6.Name = "Customize Grand Totals "
			Me.pivotDashboardItem6.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension20})
			Me.pivotDashboardItem6.ShowCaption = True
			Me.pivotDashboardItem6.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure6})
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1, Me.pivotDashboardItem2, Me.pivotDashboardItem3, Me.pivotDashboardItem4, Me.pivotDashboardItem5, Me.pivotDashboardItem6})
			dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
			dashboardLayoutItem1.Weight = 55.725190839694655R
			dashboardLayoutItem2.DashboardItem = Me.pivotDashboardItem3
			dashboardLayoutItem2.Weight = 44.274809160305345R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 49.913644214162346R
			dashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem2
			dashboardLayoutItem3.Weight = 55.725190839694655R
			dashboardLayoutItem4.DashboardItem = Me.pivotDashboardItem4
			dashboardLayoutItem4.Weight = 44.274809160305345R
			dashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup4.DashboardItem = Nothing
			dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup4.Weight = 50.086355785837654R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup3, dashboardLayoutGroup4})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Weight = 71.5846994535519R
			dashboardLayoutItem5.DashboardItem = Me.pivotDashboardItem5
			dashboardLayoutItem5.Weight = 50.086355785837654R
			dashboardLayoutItem6.DashboardItem = Me.pivotDashboardItem6
			dashboardLayoutItem6.Weight = 49.913644214162346R
			dashboardLayoutGroup5.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem5, dashboardLayoutItem6})
			dashboardLayoutGroup5.DashboardItem = Nothing
			dashboardLayoutGroup5.Weight = 28.415300546448087R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup5})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension13, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension14, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension15, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension16, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension17, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension18, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension19, System.ComponentModel.ISupportInitialize).EndInit()
			CType(dimension20, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotDashboardItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
		Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
		Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
		Private pivotDashboardItem2 As DevExpress.DashboardCommon.PivotDashboardItem
		Private pivotDashboardItem3 As DevExpress.DashboardCommon.PivotDashboardItem
		Private pivotDashboardItem4 As DevExpress.DashboardCommon.PivotDashboardItem
		Private pivotDashboardItem5 As DevExpress.DashboardCommon.PivotDashboardItem
		Private pivotDashboardItem6 As DevExpress.DashboardCommon.PivotDashboardItem
	End Class
End Namespace
