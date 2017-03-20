using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel_DataProcessor;
using System.Data;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string excelFilePath = System.Web.HttpContext.Current.Server.MapPath(".");
        excelFilePath = excelFilePath + "\\Excel_Data\\tomtom-en_login_20150101_20161130.xlsx";
        Excel_DataReader exl = new Excel_DataReader();
        DataTable dt =  exl.ReadExcelFile(excelFilePath);
        if (dt != null)
        {
            grdSearchResults.Visible = true;
            grdSearchResults.DataSource = dt;
            grdSearchResults.DataBind();
            //dgSearchResults.Visible = true;
            //dgSearchResults.DataSource = dt;
            //dgSearchResults.DataBind();
        }
    }
}