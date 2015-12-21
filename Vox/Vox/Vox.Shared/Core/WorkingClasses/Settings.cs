using System;
using System.Collections.Generic;
using System.Text;
using Vox.Enums;
using Windows.Media.MediaProperties;

namespace Vox.Core.WorkingClasses
{
    public class Settings
    {
        private static string _path = Windows.Storage.KnownFolders.MusicLibrary.Path;
        public static string Path { get { return _path; } set { _path = value; } }

        private static AudioEncodingQuality _audioQuality = AudioEncodingQuality.Auto;
        public static AudioEncodingQuality AudioQuality
        {
            get { return _audioQuality; }
            set { _audioQuality = value; }
        }

        private static AudioEncodingFormat _audioFormat = AudioEncodingFormat.mp3;
        public static AudioEncodingFormat AudioFormat
        {
            get { return _audioFormat; }
            set { _audioFormat = value; }
        }
    }
}
