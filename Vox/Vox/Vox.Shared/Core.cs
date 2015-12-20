using System;
using System.Collections.Generic;
using System.Text;
using Vox.Base;

namespace Vox
{
    public class Core
    {
        private FileManager _fileManager = new FileManager();
        public FileManager FileManager
        {
            get { return _fileManager; }
            set { _fileManager = value; }
        }

        private Player _player = new Player();
        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        private Recorder _recorder = new Recorder();
        public Recorder Recorder
        {
            get { return _recorder; }
            set { _recorder = value; }
        }
    }
}
