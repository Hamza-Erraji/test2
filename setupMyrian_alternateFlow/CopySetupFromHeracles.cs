/*
 * Created by Ranorex
 * User: hamza.erraji
 * Date: 06/06/2016
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace setupMyrian_complexFlow
{
    /// <summary>
    /// Description of CopySetupFromHeracles.
    /// </summary>
    [TestModule("B2505C28-C778-47D8-BC60-F39788536785", ModuleType.UserCode, 1)]
    public class CopySetupFromHeracles : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CopySetupFromHeracles()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        // CopyDir permet de copier un dossier avec son contenu de "sourceDir" à "desDir"
         public static void CopyDir(string sourceDir, string desDir)
       	 {
        	   DirectoryInfo dir = new DirectoryInfo(sourceDir);
		       if (dir.Exists)
		       {
			     string realDestDir;
			     if(dir.Root.Name != dir.Name && dir.Name != "exec_64bit" && dir.Name != "Myrian_Delta_Dependencies")
			     {
			       realDestDir = Path.Combine(desDir,dir.Name);
				   if(!Directory.Exists(realDestDir))
				   Directory.CreateDirectory(realDestDir);
			     }
			     else realDestDir = desDir;
			     foreach(string d in Directory.GetDirectories(sourceDir))
			      CopyDir(d, realDestDir);
			     foreach(string file in Directory.GetFiles(sourceDir))
			     {
			       string fileNamedest = Path.Combine(realDestDir,Path.GetFileName(file));
				   File.Copy(file,fileNamedest,true);
		         }
	           }
          }	
         
         

string _codeLine = "";
[TestVariable("bb8a20df-556d-4e2e-9e40-9f05d63137d6")]
public string codeLine
{
	get { return _codeLine; }
	set { _codeLine = value; }
}


string _destDir = "";
[TestVariable("f7f8e036-afed-4c81-bf8b-0f11df5e1293")]
public string destDir
{
	get { return _destDir; }
	set { _destDir = value; }
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
            
            // Déclaration de variable contenant le chemin de la source des Executable et DLL
            string sourceDirSetup = @"\\192.168.1.223\DepotCompilationAutomatique";
            
            
            // Le nom du fichier dans lequelle les Execs et DLL vont être copiés
            
            
            
          //  modifyAttribute(@"C:\Users\hamza.erraji\Desktop\file");
           
            
            // Récuperation des dossiers dont le nom commence par "mainline" 
	        DirectoryInfo dirInfo = new DirectoryInfo(sourceDirSetup);
	        if (String.Compare(codeLine,"mainline") == 0)
	        {
	       		 DirectoryInfo[] dirInfos = dirInfo.GetDirectories("mainline_b*");
	       		 // Recupération de la derniere version en prenant le dernier build
	       		 foreach(DirectoryInfo  d in dirInfos)
	       		 {
	        		if(String.Compare(d.Name,codeLine) > 0)
	         		{
	        			codeLine = d.Name;
	          		}
	         	 }
	         }
	        
	        else 
	        {
	        	DirectoryInfo[] dirInfos = dirInfo.GetDirectories("2.0_prep_b*");
	       		 // Recupération de la derniere version en prenant le dernier build
	       		 foreach(DirectoryInfo  d in dirInfos)
	       		 {
	        		if(String.Compare(d.Name,codeLine) > 0)
	         		{
	        			codeLine = d.Name;
	          		}
	         	 }
	        }
	        	

           
            // Récuperation de chemin des Executables de la dernière version
            sourceDirSetup = Path.Combine(sourceDirSetup,codeLine);
            sourceDirSetup = Path.Combine(sourceDirSetup,"Setups"); 
            sourceDirSetup = Path.Combine(sourceDirSetup,"Myrian_installer"); 
            // Affichage de quelques informations dans le rapport de Ranorex 
            Ranorex.Report.Info("Répertoire source du Setup:" + sourceDirSetup);
            Ranorex.Report.Info("Répertoire de destination du Setup :" + destDir);  
            Ranorex.Report.Info("Copie en cours ...");
            // Copie des Executables 
		    CopyDir(sourceDirSetup,destDir);
		    destDir = Path.Combine(destDir,"Myrian_installer"); 
            Host.Local.RunApplication(Path.Combine(destDir,"setup.exe"), "", destDir, false);
        }
    }
}
