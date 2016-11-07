using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibApp;
using System.Data;
using Microsoft.Reporting.WebForms;


namespace SmartLMS.RDLC
{
    public partial class frmReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                csReport objreport = new csReport();
                DataSet ds = new DataSet();
                if (Session["KEY"].ToString() == "1")
                {
                    //DateTime dtfrom;
                    //DateTime dtTo;
                    //dtfrom = Convert.ToDateTime(Session["FromDate"].ToString());
                    //dtTo = Convert.ToDateTime(Session["ToDate"].ToString());
                    objreport.FromDate = DateTime.ParseExact(Session["FromDate"].ToString(), "dd/MM/yyyy", null);
                    objreport.ToDate = DateTime.ParseExact(Session["ToDate"].ToString(), "dd/MM/yyyy", null);
                    //objreport.FromDate = dtfrom;
                    //objreport.ToDate = dtTo;
                    ds = objreport.ActivePaidUsers();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("../RDLC/rdlcPaidUserList.rdlc");
                    ReportDataSource datasource = new ReportDataSource("dsPaidUserList", ds.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(datasource);

                }
                else  if (Session["KEY"].ToString() == "2")
                {
                    objreport.FromDate = DateTime.ParseExact(Session["FromDate"].ToString(), "dd/MM/yyyy", null);
                    objreport.ToDate = DateTime.ParseExact(Session["ToDate"].ToString(), "dd/MM/yyyy", null);
                    ds = objreport.IssuedBook();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("../RDLC/rdlcIssuedBook.rdlc");
                    ReportDataSource datasource = new ReportDataSource("dsBookIssue", ds.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(datasource);
                }

                else if (Session["KEY"].ToString() == "3")
                {
                    objreport.FromDate = DateTime.ParseExact(Session["FromDate"].ToString(), "dd/MM/yyyy", null);
                    objreport.ToDate = DateTime.ParseExact(Session["ToDate"].ToString(), "dd/MM/yyyy", null);
                    ds = objreport.ReturnBook();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("../RDLC/rdlcReturnBook.rdlc");
                    ReportDataSource datasource = new ReportDataSource("dsReturnBook", ds.Tables[0]);
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(datasource);
                }
                else if (Session["KEY"].ToString() == "4")
                {
                    objreport.FromDate = DateTime.ParseExact(Session["FromDate"].ToString(), "dd/MM/yyyy", null);
                    objreport.ToDate = DateTime.ParseExact(Session["ToDate"].ToString(), "dd/MM/yyyy", null);
                    //ds = objreport.FineDetails();
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("../RDLC/rdlcFineSummary.rdlc");
                    //ReportDataSource datasource = new ReportDataSource("dsFineSummary", ds.Tables[0]);
                    //ReportViewer1.LocalReport.DataSources.Clear();
                    //ReportViewer1.LocalReport.DataSources.Add(datasource);               
                }
            }
        }
    }
}