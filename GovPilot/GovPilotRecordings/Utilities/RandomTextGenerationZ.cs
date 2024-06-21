/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 21:03
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
    /// Description of Address2Generation.
    /// </summary>
    [TestModule("46767468-1C48-4929-96EA-88A2BE2D36AE", ModuleType.UserCode, 1)]
    public class RandomTextGenerationZ : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
       
       string _RandomTextCreated = "";
       [TestVariable("98e7390b-20c0-4b4b-974f-9866f1ed5043")]
       public string RandomTextCreated
       {
       	get { return _RandomTextCreated; }
       	set { _RandomTextCreated = value; }
       }
       
        public RandomTextGenerationZ()
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
       
              RandomTextCreated = GenerateRandomLetters(6);
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
        string finalText = "UniqueText_"+builder.ToString();
        return finalText;
            
        }
    }
    }
}
