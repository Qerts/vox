using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Windows.Storage.Pickers;
using System.Threading.Tasks;
using Windows.Storage;

namespace Vox.Base
{
    /// <summary>
    /// This class serves for manipulation with audio files.
    /// </summary>
    public class FileManager
    {
        public void Load()
        {
            throw new NotImplementedException();
        }

        public async Task Save(byte[] buffer)
        {
            try
            {
                StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(Settings.Path);
                StorageFile file = await folder.CreateFileAsync("name123." + Settings.AudioFormat, CreationCollisionOption.ReplaceExisting);
                using (Stream writeStream = await file.OpenStreamForWriteAsync())
                {
                    writeStream.Read(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
