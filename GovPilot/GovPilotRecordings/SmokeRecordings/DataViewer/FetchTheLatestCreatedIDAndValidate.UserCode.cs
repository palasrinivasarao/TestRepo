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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.DataViewer
{
    public partial class FetchTheLatestCreatedIDAndValidate
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo tdtagInfo)
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);            
        	        
        	
        	Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'tdtagInfo' and assigning its value to variable 'LatestRecID'.", tdtagInfo);
            LatestRecID = tdtagInfo.FindAdapter<TdTag>().Element.GetAttributeValueText("InnerText");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.ColumnRecordID' at Center.", repo.ApplicationUnderTest.DataViewerGrid.ColumnRecordIDInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.DataViewerGrid.ColumnRecordID.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false); 
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Title' from item 'tdtagInfo' and assigning its value to variable 'RecIDAfterSort'.", tdtagInfo);
            RecIDAfterSort = tdtagInfo.FindAdapter<TdTag>().Element.GetAttributeValueText("InnerText");
            
            Int32.TryParse(LatestRecID, out int LatestRecordID);
            Int32.TryParse(RecIDAfterSort, out int RecordIDAfterSort);
            
            if (RecordIDAfterSort < LatestRecordID)
            {
            	Report.Log(ReportLevel.Info, "Ascending sort on column ID sucessfull and the Record ID after sort is " , RecordIDAfterSort.ToString());
            }
            else
            {
            	Report.Log(ReportLevel.Info, "Sorting on Record ID has failed");
            }
            	
        }

    }
}