Imports Microsoft.VisualBasic
Imports System
Namespace RepSummaryInCode
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.manualDataSet1 = New RepSummaryInCode.ManualDataSet()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrSummaryLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "table.MyData")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(274.9999F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "table.MyRow")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 42F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 42F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Report"
			' 
			' manualDataSet1
			' 
			Me.manualDataSet1.DataSetName = "ManualDataSet"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.HeightF = 100F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 100F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("MyRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 23F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrSummaryLabel
			' 
			Me.xrSummaryLabel.LocationFloat = New DevExpress.Utils.PointFloat(275F, 10.00001F)
			Me.xrSummaryLabel.Name = "xrSummaryLabel"
			Me.xrSummaryLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrSummaryLabel.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrSummaryLabel.Text = "summary"
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrSummaryLabel})
			Me.GroupFooter1.HeightF = 33.00001F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(275F, 0F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(100F, 2.083333F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1, Me.GroupHeader1, Me.GroupFooter1})
			Me.DataMember = "table"
			Me.DataSource = Me.manualDataSet1
			Me.Version = "9.3"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
			CType(Me.manualDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private manualDataSet1 As ManualDataSet
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrSummaryLabel As DevExpress.XtraReports.UI.XRLabel
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
	End Class
End Namespace
