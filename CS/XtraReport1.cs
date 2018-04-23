using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace RepSummaryInCode
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            // Create a data binding object.
            XRBinding binding = new XRBinding("Text", null, "table.MyData");

            // Add the data binding to the label's collection of bindings.
            xrSummaryLabel.DataBindings.Add(binding);
            

            // Create an XRSummary object.
            XRSummary summary = new XRSummary();

            // Set a function which should be calculated.
            summary.Func = SummaryFunc.Sum;

            // Set a range for which the function should be calculated.
            summary.Running = SummaryRunning.Group;

            // Set the output string format.
            summary.FormatString = "{0:c2}";

            // Make the label calculate the specified function for the
            // value specified by its DataBindings.Text property.
            xrSummaryLabel.Summary = summary;
        }

    }
    
}
