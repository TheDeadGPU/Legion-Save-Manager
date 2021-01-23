using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Legion_Save_Manager.Properties;

namespace Legion_Save_Manager
{
    class WDLSaveManager
    {
        public WDLSaveManager()
        {

        }
        void AttachToWDLProcess()
        {

        }
        /// <summary>
        /// If the WDLSaveDirectory variable is empty, this will ask the user for the save directory.
        /// </summary>
        public void PromptWDLSaveLocation()
        {
            if (Settings.Default.WDLSaveDirectory == "")
            {
                FolderBrowserDialog fDialog = new FolderBrowserDialog();
                fDialog.Description = "Please navigate to your WDL save directory.";
                DialogResult res = fDialog.ShowDialog();
                if(res == DialogResult.OK)
                {
                    //The user pressed Ok and selected a path
                    string pth = fDialog.SelectedPath;
                    System.Diagnostics.Debug.WriteLine(pth);
                    //Check selected directory for valid WDL Saves
                    //Implement later
                }

            }
            
        }
        public void GetWDLRootDirectory()
        {
            System.Diagnostics.Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
