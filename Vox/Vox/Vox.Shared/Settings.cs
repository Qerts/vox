using System;
using System.Collections.Generic;
using System.Text;
using Vox.Enums;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Vox
{
    public static class Settings
    {
        private static string _path = @"C:\Users\MBalicky\Music";
        public static string Path { get { return _path; } set { _path = value; } }

        private static AudioEncodingQuality _audioQuality = AudioEncodingQuality.Auto;
        public static AudioEncodingQuality AudioQuality
        {
            get { return _audioQuality; }
            set { _audioQuality = value; }
        }

        private static AudioEncodingFormat _audioFormat = AudioEncodingFormat.wav;
        public static AudioEncodingFormat AudioFormat
        {
            get { return _audioFormat; }
            set { _audioFormat = value; }
        }
    }
}
