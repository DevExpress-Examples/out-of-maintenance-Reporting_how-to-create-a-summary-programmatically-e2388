Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace RepSummaryInCode
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			' Create a data binding object.
			Dim binding As New XRBinding("Text", Nothing, "table.MyData")

			' Add the data binding to the label's collection of bindings.
			xrSummaryLabel.DataBindings.Add(binding)


			' Create an XRSummary object.
			Dim summary As New XRSummary()

			' Set a function which should be calculated.
			summary.Func = SummaryFunc.Sum

			' Set a range for which the function should be calculated.
			summary.Running = SummaryRunning.Group

			' Set the output string format.
			summary.FormatString = "{0:c2}"

			' Make the label calculate the specified function for the
			' value specified by its DataBindings.Text property.
			xrSummaryLabel.Summary = summary
		End Sub

	End Class

End Namespace
