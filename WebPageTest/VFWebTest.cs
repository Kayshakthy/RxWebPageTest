﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace WebPageTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VFWebTest recording.
    /// </summary>
    [TestModule("4129fdd6-268a-4ebc-9a92-51d58cb29bc6", ModuleType.Recording, 1)]
    public partial class VFWebTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WebPageTestRepository repository.
        /// </summary>
        public static WebPageTestRepository repo = WebPageTestRepository.Instance;

        static VFWebTest instance = new VFWebTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VFWebTest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VFWebTest Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            NavigateVFPage();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='About  ') on item 'Home.About'.", repo.Home.AboutInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.Home.AboutInfo, "InnerText", "About  ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.vodafone.com/about') on item 'Home.About'.", repo.Home.AboutInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.Home.AboutInfo, "Href", "https://www.vodafone.com/about");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Careers  ') on item 'Home.Careers'.", repo.Home.CareersInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.Home.CareersInfo, "InnerText", "Careers  ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://careers.vodafone.com/') on item 'Home.Careers'.", repo.Home.CareersInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.Home.CareersInfo, "Href", "https://careers.vodafone.com/");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='globeLink') on item 'Home.GlobeLink'.", repo.Home.GlobeLinkInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.Home.GlobeLinkInfo, "InnerText", "globeLink");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=35,Height=30}) on item 'Home.GlobeLink'.", repo.Home.GlobeLinkInfo, new RecordItemIndex(7));
            Validate.ContainsImage(repo.Home.GlobeLinkInfo, GlobeLink_Screenshot1, GlobeLink_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Home.Media' at 78;42.", repo.Home.MediaInfo, new RecordItemIndex(8));
            repo.Home.Media.Click("78;42");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage GlobeLink_Screenshot1
        { get { return repo.Home.GlobeLinkInfo.GetScreenshot1(new Rectangle(0, 0, 35, 30)); } }

        Imaging.FindOptions GlobeLink_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
