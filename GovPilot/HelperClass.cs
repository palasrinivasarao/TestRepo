/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 4/22/24
 * Time: 23:11
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Configuration;


namespace GovPilot
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class HelperClass
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
       public static GovPilotRepository repo = GovPilotRepository.Instance;
        
        public static string GetConfigurationValue(string Parameter)
		{
			string val = ConfigurationManager.AppSettings[Parameter];
			
			return val;
			
		}
        [UserCodeMethod]
        public static void adjustResolution()
        {
        	var lnkModules = repo.ApplicationUnderTest.HomePage.LnkModules;
        	lnkModules.EnsureVisible();
        	Ranorex.Report.Info("Adjusts Resolution to 67%");
        	for(int i=0;i<4;i++)
        	{
        	Keyboard.Press("{ControlKey down}"); // Press the Control key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{Subtract}"); // Press the Subtract key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{ControlKey up}"); // Release the Control key			
        	}
        	Ranorex.Report.Success("Changed to smaller Resolution");
        
      	}
        [UserCodeMethod]
        public static void ChangeBackResolution()
        {
        	var lnkModules = repo.ApplicationUnderTest.HomePage.LnkModules;
        	lnkModules.EnsureVisible();
        	Ranorex.Report.Info("Changes the Resolution back to 100%");
        	for(int i=0;i<4;i++)
        	{
        	Keyboard.Press("{ControlKey down}"); // Press the Control key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{Add}"); // Press the Subtract key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{ControlKey up}"); // Release the Control key			
        	}
        	Ranorex.Report.Success("Changed to larger Resolution");
        
      	}
        [UserCodeMethod]
        public static void SelectViewName(string viewname)
        {
        	
            ATag tileName = repo.ApplicationUnderTest.HomePage.List_ViewNames.GetPath()+ "//a[@innertext='" + viewname + "']";
        	
        	
        	string cell = tileName.GetInnerHtml();
            Ranorex.Report.Info(cell);
            
            ITag tileCheckbox = repo.ApplicationUnderTest.HomePage.List_ViewNames.GetPath()+"//a[@innertext='" + viewname + "']/i";
           
            
            if(cell.Contains(viewname))
            {  
               tileCheckbox.EnsureVisible();
           	   tileCheckbox.Click();
               Delay.Duration(500);
               //repo.ApplicationUnderTest.HomePage.Btn_AddTile.EnsureVisible();
               //Delay.Duration(1000);
               //repo.ApplicationUnderTest.HomePage.Btn_AddTile.Click();
               //Delay.Duration(1000);
               Ranorex.Report.Success("Success! The Checked ViewName is "+viewname);
            }
            else
            {
            	Ranorex.Report.Error("View Name does not exist in Add Tile Window");
            }
        }
        
        [UserCodeMethod]
        public static void RetrieveAndVerifyExpectedCountValue(string ActualTileCount)
        {
        	
       	//string Text="1-\\d{2} of \\d{3} items";
        string xpath = $"/dom[@domain='platformqa.govpilot.com']//div[#'dv-content']/div//span[@innertext~'^1 -*']";
        
        Ranorex.SpanTag element = Host.Local.FindSingle<Ranorex.SpanTag>(xpath);
       	
        string cell = element.InnerText;
        	
       	Ranorex.Report.Info("The Inner Text to retrieve count from the bottom of the page is " + cell);
            
        // Define regular expression pattern
        string pattern = @"of (\d+)";
        
        // Match the pattern
        Match match = Regex.Match(cell, pattern);
        if (match.Success)
        {
            // Extract the digits after "of"
            string ActualCount = match.Groups[1].Value;
            Report.Info("Digits after 'of': " + ActualCount);
            
            if(ActualCount.Equals(ActualTileCount))
            {
            	Ranorex.Report.Info("The Actual Count on the Bottom of the Page is "+ ActualCount + "The Actual Count on Top of the Tile is " +ActualTileCount);
            	Ranorex.Report.Info("Success!The Actual and Expected Count Values Match");
            }
            else
            {
            	Ranorex.Report.Warn("The Actual Count on the Bottom of the Page is "+ ActualCount + "The Actual Count on Top of the Tile is " +ActualTileCount);
            	Ranorex.Report.Warn("The Actual and Expected Count Values does not  Match");
            }
        }
        else
        {
          Report.Warn("The Count Value cannot be retrived as it does not match the expression defined");
        }
        
     }
        
      
        [UserCodeMethod]
        public static void ToVerifyAddedTile(string viewname)
        {
       
        	// Iterate through each element and verify its inner text
        	for (int i= 1; i <= 4; i++)
        	{
        		string text = "^[a-zA-Z0-9]{6,20}$";
        		SpanTag name= repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//ul/li["+i+"]//span[@innertext~'" + text + "']";
        		
        		string actualText = name.GetInnerHtml();
            	Ranorex.Report.Info("The InnerHtml Obtained is " + actualText);
            	string view =viewname.Trim();
            	if(actualText.Contains(view))
            	{
            			Ranorex.Report.Info("The Actual View Name is  " + actualText + "The Expected View Name is "  + viewname);
            			Ranorex.Report.Info("Success!The actual and expected View Names match");
            			break;
            	}
            	else
            	{
            			Ranorex.Report.Info("The Actual View Name is  " + actualText + "The Expected View Name is " + viewname);
            			Ranorex.Report.Info("The actual and expected View Names does not match");
            			Ranorex.Report.Info("Current Iteration No "+i);
            	}
            	
            }
            	
        }
        [UserCodeMethod]
        public static string ToFetchCountValueOnTile(string viewname)
        {
       
        	// Iterate through each element and verify its inner text
        	for (int i= 1; i <= 4; i++)
        	{
        		string digit = "^\\d{1,6}$";
        		SpanTag count= repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//ul/li["+i+"]//span[@innertext~'" + digit + "']";
        	
            	string text = "^[a-zA-Z0-9]{6,20}$";
        		SpanTag name= repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//ul/li["+i+"]//span[@innertext~'" + text + "']";
        		
            	string actualText = name.InnerText;
            	Ranorex.Report.Info("The Actual View Name is  " + actualText);
            	if(actualText.Equals(viewname))
            	{
            			string actualcount = count.InnerText;
            			Ranorex.Report.Info("The Actual Count Value  "+ actualcount + "associated with the View Name " +actualText);
            			return actualcount;
            	}
            	else
            	{
            			Ranorex.Report.Info("The Actual View Name is  " + actualText + "The Expected View Name is " +viewname);
            			Ranorex.Report.Info("The actual and expected View Names does not match");
            			Ranorex.Report.Info("Current Iteration No " +i);
            	}
            	 	
            }
      		return null;
           
        }
        
         [UserCodeMethod]
        public static void ToVerifyTileNotExists(string viewname,int count)
        {
      		
        	// Iterate through each element and verify its inner text
        	for (int i= 1; i <= count; i++)
        	{
        		string text = "^[a-zA-Z0-9]{6,20}$";
        		SpanTag name= repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//ul/li["+i+"]//span[@innertext~'" + text + "']";
        		
            	string actualText = name.InnerText;
            	Ranorex.Report.Info("The Actual View Name Obtained is " + actualText);
            	if(actualText.Equals(viewname))
            	{
            			Ranorex.Report.Info("The Actual Tile Name is  " + actualText + "The Expected Tile Name is "  + viewname);
            			Ranorex.Report.Error("Tile Name Exists");
            			break;
            	}
            	else
            	{
            			Ranorex.Report.Info("The Actual Tile Name is  " + actualText + "The Expected Tile Name is "  + viewname);
            			Ranorex.Report.Success("Success.Tile Name Does not Exists");
            			Ranorex.Report.Info("Current Iteration No "+i);
            	}
            	
            }
          }
        
        [UserCodeMethod]
        public static void CloseTile(string viewname)
        {
        	
           	ATag tileName = repo.ApplicationUnderTest.HomePage.List_ViewNames.GetPath()+ "//a[@innertext='" + viewname + "']";
        
        	string cell = tileName.GetInnerHtml();
            Ranorex.Report.Info(cell);
            
            ITag tileCheckbox = repo.ApplicationUnderTest.HomePage.List_ViewNames.GetPath()+"//a[@innertext='" + viewname + "']/i";
            
			if(cell.Contains(viewname))
            {  
               tileCheckbox.Click();
               Delay.Duration(500);
               repo.ApplicationUnderTest.HomePage.Btn_CloseTile.EnsureVisible();
               repo.ApplicationUnderTest.HomePage.Btn_CloseTile.Click();
               Delay.Duration(1000);
               Ranorex.Report.Success("Success.Close Tile Button is clicked After Checking the ViewName " + viewname);
               
           }
            else
            {
            	Ranorex.Report.Error("Close Tile Operation Cannot be Performed");
            }
        }

        [UserCodeMethod]
        public static void SaveView(string viewName)
        {
        
      	 ATag btn_SaveAs = repo.ApplicationUnderTest.DogLicensePage.Btn_SaveAs;
         btn_SaveAs.Click();
         Delay.Duration(500);
         
         var dialogWindow_SaveAsView = repo.ApplicationUnderTest.DogLicensePage.DialogWindow_SaveAsView;
         Validate.Exists(dialogWindow_SaveAsView);
         Ranorex.Report.Info("The SaveAs Dialog Window Exists in the Save View As Window");
         
         var popWindowTitle_SaveAs = repo.ApplicationUnderTest.DogLicensePage.PopWindowTitle_SaveAs;
         Validate.Exists(popWindowTitle_SaveAs);
         Ranorex.Report.Info("PopUp Window Title Save As Exists in the Save View As Window");
         
         var txtBox_SaveAs_ViewName = repo.ApplicationUnderTest.DogLicensePage.TxtBox_SaveAs_ViewName;
        
         Validate.Exists(txtBox_SaveAs_ViewName);
         Ranorex.Report.Info("Save as Text Box Placeholder text exists in the Save View As Window");
         
         var btn_Cancel_ViewName = repo.ApplicationUnderTest.DogLicensePage.Btn_Cancel_ViewName;
         Validate.Exists(btn_Cancel_ViewName);
         Ranorex.Report.Info("Button Cancel exists in the Save View As Window");
         
         var btn_SaveViewName = repo.ApplicationUnderTest.DogLicensePage.Btn_SaveViewName;
         Validate.Exists(btn_SaveViewName);
         Ranorex.Report.Info("Button Save exists in the Save View As Window");
         
         txtBox_SaveAs_ViewName.Click();
         Delay.Duration(1000);
         
         txtBox_SaveAs_ViewName.PressKeys("{ControlKey down}{AKey}{ControlKey up}");
         Delay.Duration(500);
       	 // Simulate pressing Ctrl+A to select all text
		 txtBox_SaveAs_ViewName.PressKeys("{DELETE}");
		 Delay.Duration(500);

         txtBox_SaveAs_ViewName.PressKeys(viewName);
		 Delay.Duration(500);
         Ranorex.Report.Info("The ViewName is Entered as " +viewName);
		
         btn_SaveViewName.Click();
         Delay.Duration(100);
         Ranorex.Report.Info("Save Button Is clicked for the View " +viewName);
       	
         var popWindowTitle_SavedSuccess = repo.ApplicationUnderTest.DogLicensePage.PopWindowTitle_SavedSuccess;
         
       	 Validate.Exists(popWindowTitle_SavedSuccess); 
       	 Ranorex.Report.Success("ThePopup window for view successfully saved exists");
       	
       	 Ranorex.Report.Info("The ViewName Saved is " +viewName);
        }
     
      [UserCodeMethod]
      public static void ClickOnView(string viewname)
      {
         
      	for(int i =1;i<=1000;i++)
          {
        
          LiTag listViewName = repo.ApplicationUnderTest.HomePage.List_BgVerifyViewName.GetPath()+"/li["+i+"]";
          string selectedView = listViewName.GetInnerHtml();
          
          Ranorex.Report.Info("The InnerHtml for the selected view is " +selectedView);
          if(selectedView.Contains(viewname))
          {
          	Validate.Exists(listViewName);
          	listViewName.EnsureVisible();
          	listViewName.Click();
          	Delay.Duration(5000);
          	break;
          }
          else
          {
          	Ranorex.Report.Info("Warning . Exact View Match Not Found.Actual View Name " + selectedView + "Expected View Name "+ viewname);
          	Ranorex.Report.Info("Current Iteration is " + i);
          }
          	
      }
      }
      	[UserCodeMethod]
        public static void CleanViews()
        {
        
         for(int i=1;i<=5;i++)
         {
          LiTag listViewName = repo.ApplicationUnderTest.HomePage.List_BgVerifyViewName.GetPath()+"/li[2]";
          string selectedView = listViewName.GetInnerHtml();
          listViewName.Click();
          Delay.Duration(1000);
          
          Ranorex.Report.Info("The InnerHtml is " +selectedView);
          
          if(selectedView != " ") 
          {
          		if(selectedView.Contains("hr-line-solid no-margins"))
          		{
          			Ranorex.Report.Info("No Views Found");
          			break;
          		}
          		Validate.Exists(listViewName);
          		listViewName.EnsureVisible();
          	
          		var btn_More = repo.ApplicationUnderTest.DogLicensePage.Btn_More;
         		Validate.Exists(btn_More);
         		Delay.Duration(1000);
         		btn_More.EnsureVisible();
         		btn_More.Click();
            	Delay.Duration(1000);
          	
            var option_Delete_More = repo.ApplicationUnderTest.DogLicensePage.Option_Delete_More;
            Validate.Exists(option_Delete_More);
            Delay.Duration(1000);
            option_Delete_More.EnsureVisible();
         	option_Delete_More.Click();
         	Delay.Duration(1000);
         	
         	
         	var popup_Delete_Message = repo.ApplicationUnderTest.DogLicensePage.Popup_Delete_Message;
         	var btn_IChangedMyMind = repo.ApplicationUnderTest.DogLicensePage.Btn_IChangedMyMind;
         	var btn_DeleteView = repo.ApplicationUnderTest.DogLicensePage.Btn_DeleteView;
         	
         	
         	Validate.Exists(popup_Delete_Message);
         	Validate.Exists(btn_IChangedMyMind);
         	Validate.Exists(btn_DeleteView);
         	
         	btn_DeleteView.Click();
         	Delay.Duration(2000);
         	Ranorex.Report.Info("View Deleted" +selectedView);
         	
          }
           
         }
        }
        
      [UserCodeMethod]
      public static void CleanTiles()
      {
      	
         // Iterate through each element and verify its inner text
        	for (int i= 1; i <=20; i++)
        	{
        		
        		Ranorex.Report.Info("Index of Iteration is "+i);
        		
        		try{
        			
	     		Ranorex.Core.Element element = Host.Local.FindSingle("/dom[@domain='platformqa.govpilot.com']//div[#'tiles-container']/div//div[1]//div//div[1]//span[@innertext='Dog License']");
	     		string text = element.GetAttributeValue("InnerText").ToString();
	     		Validate.Exists(element);
	     		Delay.Duration(2000);
	     		if(element != null)
        		{
        		Ranorex.Report.Info("The Tile with the innertext  " + text + " exists on the home page and so it needs to be cleared");
                ITag cxtMenu= repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//div//div[1]//div//div[1]//i[@class='fa fa-ellipsis-v']";
                cxtMenu.Click();
                Delay.Duration(600);
                Ranorex.Report.Info("ContextMenu is Clicked");
         
                ATag deleteTile = repo.ApplicationUnderTest.HomePage.Txt_TileViewName_CountValue.GetPath()+"//div//div[1]//div//div[1]//a[@innertext~'Delete Tile']";
                deleteTile.EnsureVisible();
                deleteTile.Click();
                Delay.Duration(500);
                Ranorex.Report.Info("Delete Tile Button is clicked");
                
                var btn_Cancel = repo.ApplicationUnderTest.HomePage.Btn_Cancel;
                var btn_Delete = repo.ApplicationUnderTest.HomePage.Btn_Delete;
                var txt_OnDeletePopUpWindow = repo.ApplicationUnderTest.HomePage.Txt_OnDeletePopUpWindow;

                Validate.Exists(btn_Cancel);
                Validate.Exists(btn_Delete);
                Validate.Exists(txt_OnDeletePopUpWindow);
                
            	btn_Delete.Click();
                Delay.Duration(1000);
                Ranorex.Report.Info("Delete Button is clicked");
	     		}
        		}
        		
                catch (Ranorex.ElementNotFoundException)
				{
                   Ranorex.Report.Success("The Existing Tiles on the Home Page got Deleted");
                   break;
				}
        		
        	}
      }
    }}
        
        

