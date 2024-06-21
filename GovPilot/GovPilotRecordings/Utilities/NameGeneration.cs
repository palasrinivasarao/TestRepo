/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 20:49
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace GovPilot
{
    /// <summary>
    /// Description of FirstNameGeneration.
    /// </summary>
    [TestModule("01282B83-43D0-4F78-93C9-64D7E7E82F16", ModuleType.UserCode, 1)]
    public class NameGeneration : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _RandomNameCreated = "";
        [TestVariable("5f2d6784-6b6f-4af1-8b07-50d8548c5ef5")]
        public string RandomNameCreated
        {
        	get { return _RandomNameCreated; }
        	set { _RandomNameCreated = value; }
        }
        
        
        public NameGeneration()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
               RandomNameCreated = GenerateRandomLetters(6);
        //Console.WriteLine(randomLetters);
            

    string GenerateRandomLetters(int length)
    	
    {
        Random random = new Random();
        const string chars = "abcdefghijklmnopqrstuvwxyz"; // You can include uppercase if needed
        StringBuilder builder = new StringBuilder(length);
        
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            builder.Append(chars[index]);
        }
        string Name = "Name_"+builder.ToString();
        return Name;
            
            // Random generator = new Random();
            // string num = generator.Next(9).ToString("D5");
            // RandomNameCreated="Jimm"+num;
        }
    }
    }}
