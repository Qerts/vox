using System;
using System.Collections.Generic;
using System.Text;
using Vox.Core.WorkingClasses;

namespace Vox.Core
{
    public class Core
    {
        #region Singleton
        private static Core _instance = null;
        public static Core Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Core();
                }
                return _instance;
            }
        }
        #endregion

        #region Members
        private Player _player = null;
        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }
        private Recorder _recorder = null;
        public Recorder Recorder
        {
            get { return _recorder; }
            set { _recorder = value; }
        }
        private Settings _settings = null;
        public Settings Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }
        private FileManager _fileManager = null;
        public FileManager FileManager
        {
            get { return _fileManager; }
            set { _fileManager = value; }
        }
        private SoundHolder _soundHolder = null;
        public SoundHolder SoundHolder
        {
            get { return _soundHolder; }
            set { _soundHolder = value; }
        }
        private SoundProcessor _soundProcessor = null;
        public SoundProcessor SoundProcessor
        {
            get { return _soundProcessor; }
            set { _soundProcessor = value; }
        }
        private EffectStorage _effectStorage = null;
        public EffectStorage EffectStorage
        {
            get { return _effectStorage; }
            set { _effectStorage = value; }
        }



        #endregion

        #region Constructor
        private Core()
        {
            _player = new Player();
            _recorder = new Recorder();
            _settings = new Settings();
            _fileManager = new FileManager();
            _soundHolder = new SoundHolder();
            _soundProcessor = new SoundProcessor();
            _effectStorage = new EffectStorage();
        } 
        #endregion


    }
}
