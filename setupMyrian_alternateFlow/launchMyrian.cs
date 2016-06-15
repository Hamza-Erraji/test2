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

namespace setupMyrian_complexFlow
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The launchMyrian recording.
    /// </summary>
    [TestModule("c5ad3ad2-99fd-49f9-96ce-95a4995e50b0", ModuleType.Recording, 1)]
    public partial class launchMyrian : ITestModule
    {
        /// <summary>
        /// Holds an instance of the setupMyrian_complexFlowRepository repository.
        /// </summary>
        public static setupMyrian_complexFlowRepository repo = setupMyrian_complexFlowRepository.Instance;

        static launchMyrian instance = new launchMyrian();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public launchMyrian()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static launchMyrian Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\intrasense\\Myrian\\myrian.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files\\intrasense\\Myrian\\myrian.exe", "", "C:\\Program Files\\intrasense\\Myrian", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR200OuvertureDeSession.ComboBox880'.", repo.MyrianR200OuvertureDeSession.ComboBox880Info, new RecordItemIndex(1));
            Validate.Exists(repo.MyrianR200OuvertureDeSession.ComboBox880Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR200OuvertureDeSession.Text882'.", repo.MyrianR200OuvertureDeSession.Text882Info, new RecordItemIndex(2));
            Validate.Exists(repo.MyrianR200OuvertureDeSession.Text882Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OK') on item 'MyrianR200OuvertureDeSession.Button1'.", repo.MyrianR200OuvertureDeSession.Button1Info, new RecordItemIndex(3));
            Validate.Attribute(repo.MyrianR200OuvertureDeSession.Button1Info, "Text", "OK");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Quitter') on item 'MyrianR200OuvertureDeSession.Button2'.", repo.MyrianR200OuvertureDeSession.Button2Info, new RecordItemIndex(4));
            Validate.Attribute(repo.MyrianR200OuvertureDeSession.Button2Info, "Text", "Quitter");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyrianR200OuvertureDeSession.Text882' at 99;8.", repo.MyrianR200OuvertureDeSession.Text882Info, new RecordItemIndex(5));
            repo.MyrianR200OuvertureDeSession.Text882.Click("99;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'myrian' with focus on 'MyrianR200OuvertureDeSession.Text882'.", repo.MyrianR200OuvertureDeSession.Text882Info, new RecordItemIndex(6));
            repo.MyrianR200OuvertureDeSession.Text882.PressKeys("myrian");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MyrianR200OuvertureDeSession.Button1' at 42;11.", repo.MyrianR200OuvertureDeSession.Button1Info, new RecordItemIndex(7));
            repo.MyrianR200OuvertureDeSession.Button1.DoubleClick("42;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR'.", repo.MyrianR.SelfInfo, new RecordItemIndex(8));
            Validate.Exists(repo.MyrianR.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyrianR.Button2' at 24;14.", repo.MyrianR.Button2Info, new RecordItemIndex(9));
            repo.MyrianR.Button2.Click("24;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Quitter') on item 'MyrianRCalibrationEcranC2005Intra.Button2'.", repo.MyrianRCalibrationEcranC2005Intra.Button2Info, new RecordItemIndex(10));
            Validate.Attribute(repo.MyrianRCalibrationEcranC2005Intra.Button2Info, "Text", "Quitter");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MyrianRCalibrationEcranC2005Intra.Button2' at 21;9.", repo.MyrianRCalibrationEcranC2005Intra.Button2Info, new RecordItemIndex(11));
            repo.MyrianRCalibrationEcranC2005Intra.Button2.DoubleClick("21;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'ContratDeLicenceEULA.CheckBox2134'.", repo.ContratDeLicenceEULA.CheckBox2134Info, new RecordItemIndex(12));
            Validate.Attribute(repo.ContratDeLicenceEULA.CheckBox2134Info, "Checked", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContratDeLicenceEULA.CheckBox2134' at 8;12.", repo.ContratDeLicenceEULA.CheckBox2134Info, new RecordItemIndex(13));
            repo.ContratDeLicenceEULA.CheckBox2134.Click("8;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContratDeLicenceEULA.Button1' at 28;13.", repo.ContratDeLicenceEULA.Button1Info, new RecordItemIndex(14));
            repo.ContratDeLicenceEULA.Button1.Click("28;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR200.AfxWnd140'.", repo.MyrianR200.AfxWnd140Info, new RecordItemIndex(15));
            Validate.Exists(repo.MyrianR200.AfxWnd140Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR'.", repo.MyrianR.SelfInfo, new RecordItemIndex(16));
            Validate.Exists(repo.MyrianR.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyrianR.Button2' at 58;18.", repo.MyrianR.Button2Info, new RecordItemIndex(17));
            repo.MyrianR.Button2.Click("58;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='&Copier la clé dans le presse-papiers') on item 'MyrianR200.Button1052'.", repo.MyrianR200.Button1052Info, new RecordItemIndex(18));
            Validate.Attribute(repo.MyrianR200.Button1052Info, "Text", "&Copier la clé dans le presse-papiers");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyrianR200.Button737' at 30;28.", repo.MyrianR200.Button737Info, new RecordItemIndex(19));
            repo.MyrianR200.Button737.Click("30;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyrianR200OuvertureDeSession.ComboBox880'.", repo.MyrianR200OuvertureDeSession.ComboBox880Info, new RecordItemIndex(20));
            Validate.Exists(repo.MyrianR200OuvertureDeSession.ComboBox880Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyrianR200OuvertureDeSession.Button2' at 37;12.", repo.MyrianR200OuvertureDeSession.Button2Info, new RecordItemIndex(21));
            repo.MyrianR200OuvertureDeSession.Button2.Click("37;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
