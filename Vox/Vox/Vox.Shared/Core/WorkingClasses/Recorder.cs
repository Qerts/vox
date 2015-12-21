using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;

namespace Vox.Core.WorkingClasses
{
    public class Recorder
    {
        private MediaCapture _capturer;
        private FileManager _fileManager;
        private IRandomAccessStream _audioStream;


        public Recorder()
        {
            _capturer = new MediaCapture();
            _capturer.Failed += _capturer_Failed;
            _capturer.RecordLimitationExceeded += _capturer_RecordLimitationExceeded;

            _fileManager = new FileManager();
        }

        private void _capturer_RecordLimitationExceeded(MediaCapture sender)
        {
            throw new NotImplementedException();
        }

        private void _capturer_Failed(MediaCapture sender, MediaCaptureFailedEventArgs errorEventArgs)
        {
            throw new NotImplementedException();
        }

        public async Task StartRecording()
        {
            MediaCaptureInitializationSettings settings = new MediaCaptureInitializationSettings();
            settings.StreamingCaptureMode = StreamingCaptureMode.Audio;
            await _capturer.InitializeAsync(settings);


            MediaEncodingProfile profile = null;
            switch (Settings.AudioFormat)
            {
                case Enums.AudioEncodingFormat.mp3:
                    profile = MediaEncodingProfile.CreateMp3(Settings.AudioQuality);
                    break;
                case Enums.AudioEncodingFormat.wav:
                    profile = MediaEncodingProfile.CreateWav(Settings.AudioQuality);
                    break;
                default:
                    throw new NotImplementedException();
            }

            _audioStream = new InMemoryRandomAccessStream();
            await _capturer.StartRecordToStreamAsync(profile, _audioStream);
        }

        public async Task PauseRecording()
        {
            throw new NotImplementedException();
        }

        public async Task StopRecording()
        {
            try
            {
                await _capturer.StopRecordAsync();
                using (DataReader dataReader = new DataReader(_audioStream.GetInputStreamAt(0)))
                {
                    await dataReader.LoadAsync((uint)_audioStream.Size);
                    byte[] buffer = new byte[(uint)_audioStream.Size];
                    dataReader.ReadBytes(buffer);
                    await _fileManager.Save(buffer);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal void ResumeRecording()
        {
            throw new NotImplementedException();
        }
    }
}
