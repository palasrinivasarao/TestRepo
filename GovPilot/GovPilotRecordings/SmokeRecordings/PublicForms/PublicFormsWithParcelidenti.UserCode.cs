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
using Ranorex.AutomationHelpers;
using Ranorex.AutomationHelpers.UserCodeCollections;
using System.IO;

namespace GovPilot.GovPilotRecordings.SmokeRecordings.PublicForms
{
    public partial class PublicFormsWithParcelidenti
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ChooseFile(RepoItemInfo info, string FilePath)
        {
            //Select file current directory and concat with the file path
			string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;              
			string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\TestData"+FilePath.Trim().ToString());
			string chooseFile = Path.GetFullPath(sFile);  	
			Report.Log(ReportLevel.Info, "Set value", "ChooseFile: " + chooseFile, info);	
			if ((info.FindAdapter<Text>().Element != null)) 
				{
	                Report.Log(ReportLevel.Info, "Set value", "ChooseFile: " + chooseFile, info);
	                info.FindAdapter<Text>().Element.SetAttributeValue("Text", chooseFile);
			    }			
        }

        public void Set_value_Input(RepoItemInfo inputtagInfo, string prefix, string length)
        {
        	InputValue = prefix + StringLibrary.GetRandomString(length).ToString().Trim().ToUpper();
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'yourValue' on item 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Value", InputValue);
        }

        public void Set_Phonenumber(RepoItemInfo inputtagInfo)
        {
        	Random generator = new Random();
            randomPhoneNumber = generator.Next(1000000000).ToString("D10");
            inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Value", randomPhoneNumber);
        }

        public void Set_value_email(RepoItemInfo inputtagInfo, string prefix, string length)
        {
        	randomEmail = prefix + StringLibrary.GetRandomString(length).ToString().Trim().ToUpper()+"@gmail.com";
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'yourValue' on item 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Value", randomEmail);
        }
        
        public void Set_Current_Future_Date(RepoItemInfo inputtagInfo, int days)
        {
        	date = System.DateTime.Now.AddDays(days).ToString("MM/dd/yyyy");
        	date = date.Replace("-", "/");
        	date = date.TrimStart('0');
            inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Value", date);
        }
        

    }
}
