using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SleeveSewing
{
    class SetupManager
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Static Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Static Members

        private static object _lock = new object();
        private static SetupManager _settingsManager;

        #endregion ~Static Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Instance Members 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Instance Members

        private Setup _settings = null;
        private LoadPrompts _loadPrompts = null;

        #endregion ~Instance Members


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Construction 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Construction

        private SetupManager()
        {
        }

        #endregion ~Construction

        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Properties 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Properties

        public static SetupManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_settingsManager == null)
                    {
                        _settingsManager = new SetupManager();
                    }
                    return (_settingsManager);
                }
            }
        }

        public Setup Settings
        {
            get { return _settings; }
        }

        public LoadPrompts LoadPrompts
        {
            get { return _loadPrompts; }
        }


        #endregion ~Properties


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Pulic Methods
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Public Methods

        public bool Initialize()
        {
            bool res = LoadSystemSetup();
            if (res == false)
            {
                return (false);
            }

            res = LoadMessagePrompts();
            return (res);
        }

        
        #endregion ~Public Methods


        ///////////////////////////////////////////////////////////////////////////////////////////
        //          Private Methods 
        //////////////////////////////////////////////////////////////////////////////////////////
        #region Private Methods

        private bool LoadSystemSetup()
        {
            string path = CommonDirectory.SetupDataDirectory + Path.DirectorySeparatorChar + "Setup.xml";

            bool exists = File.Exists(path);
            if (exists == false)
            {
                ShowError("The System Setup File does not Exist. \nContact Engineering");
                return (false);
            }

            XmlSerializer xml = new XmlSerializer(typeof(Setup));
            bool result = true;
            FileStream fStream = null;
            try
            {
                
                 fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                _settings = new Setup();
                _settings = (Setup)xml.Deserialize(fStream);
            }
            catch (Exception ex)
            {

                //_logger.ErrorException("LoadSystemSetup", ex);
                Console.WriteLine(ex.Message + ex.StackTrace);
                result = false;
            }
            finally
            {
                if (fStream != null)
                {
                    fStream.Close();
                }
            }
            return (result);
        }

        private bool LoadMessagePrompts()
        {

            string path = CommonDirectory.SetupDataDirectory + Path.DirectorySeparatorChar + "LoadPrompts.xml";

            bool exists = File.Exists(path);
            if (exists == false)
            {
                ShowError("The Sleeve Load Prompts File does not Exist. \nContact Engineering");
                return (false);
            }

            XmlSerializer xml = new XmlSerializer(typeof(LoadPrompts));
            bool result = true;
            FileStream fStream = null;
            try
            {

                fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                _loadPrompts = new LoadPrompts();
                _loadPrompts = (LoadPrompts)xml.Deserialize(fStream);
            }
            catch (Exception ex)
            {

                //_logger.ErrorException("LoadMessagePrompts", ex);
                Console.WriteLine(ex.Message + ex.StackTrace);
                result = false;
            }
            finally
            {
                if (fStream != null)
                {
                    fStream.Close();
                }
            }
            return (result);
        }

        private void ShowError(string msg )
        {
            string caption = "Error";
            string buttonLabel = "STOP";
            //AlertDialog.Show(caption, msg, buttonLabel);
            //_logger.Error(msg);
        }

        #endregion ~Private Methods
    }
}
