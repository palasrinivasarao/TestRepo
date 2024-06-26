﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.Globalization;

namespace GovPilot.GovPilotRecordings.SmokeRecordings.DataViewer
{
    public partial class VerifySaveNew
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Get_value_TxtDateEnteredField(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'inputtagInfo' and assigning its value to variable 'DateEnteredForNew'.", inputtagInfo);
            DateEnteredForNew = inputtagInfo.FindAdapter<InputTag>().Element.GetAttributeValueText("Value");
            
            System.DateTime originalDate = System.DateTime.ParseExact(DateEnteredForNew, "M/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

             System.DateTime trimmedDate = new System.DateTime(originalDate.Year, originalDate.Month, originalDate.Day, originalDate.Hour, originalDate.Minute, 0, originalDate.Kind);
			 string formatedDateinApp = trimmedDate.ToString("M/d/yy hh", CultureInfo.InvariantCulture);
                      
            
            System.DateTime currentDateTime = System.DateTime.Now;
            string outputFormat = "M/d/yy hh"; 
            string formattedDateTime = currentDateTime.ToString(outputFormat);//Converting the system date format to match the format of Date and Time in the application
            
            if (formatedDateinApp.Equals (formattedDateTime)) 
            {
            	Report.Log(ReportLevel.Info, "Record date and time matches the current system date and time", formatedDateinApp);
            
            }
            else
            {
            	Report.Log(ReportLevel.Info, "Record date and time does not match the current system date and time", formatedDateinApp);
            	Report.Log(ReportLevel.Info, "Your current system date and time is", formattedDateTime);
            	Report.Failure("Test Failed", "Date Mismatch");
            }
        }
        
        public void Report_Log()
        {
            Report.Log(ReportLevel.Info, "User", FetchDateForm);
        }

        public void Get_value_TxtDateEnteredField1(RepoItemInfo inputtagInfo)
        {
                
        
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'inputtagInfo' and assigning its value to variable 'FetchDateForm'.", inputtagInfo);
            FetchDateForm = inputtagInfo.FindAdapter<InputTag>().Element.GetAttributeValueText("Value");
            
            System.DateTime dateTime;
            string formattedDate="";
            if (System.DateTime.TryParse(FetchDateForm, out dateTime))
        {
            formattedDate = dateTime.ToString("M/d/yyyy h:mm tt");
            
            Report.Log(ReportLevel.Info, "Formated Date is : "+formattedDate);
            
            
        }
            FetchDateForm = formattedDate;       
                               
        }

        public void Get_value_DateEntered(RepoItemInfo tdtagInfo)
        {
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'tdtagInfo' and assigning its value to variable 'DateEnteredGrid'.", tdtagInfo);
            DateEnteredGrid = tdtagInfo.FindAdapter<TdTag>().Element.GetAttributeValueText("InnerText");
            
            System.DateTime dateTime;
            string formattedDate="";
            if (System.DateTime.TryParse(DateEnteredGrid, out dateTime))
        {
            formattedDate = dateTime.ToString("M/d/yyyy h:mm tt");
            
            Report.Log(ReportLevel.Info, "Formated Date is : "+formattedDate);
            
            
        }
            DateEnteredGrid = formattedDate;
        }}}

      
