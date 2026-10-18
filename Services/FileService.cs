using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Threading.Tasks;
using MobileServer.Models;
using MobileServer.Network;

namespace MobileServer.Services
{
    public class FileService
    {  
        private string _orginalpath;
        private string _temppath;
        public int NumberFileinList;
        public string folder;
        public FileService()
        {
            _orginalpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _temppath = Path.Combine(Path.GetTempPath(),"uploaded_file");
            folder = Path.Combine(_orginalpath,"files");
        }
        public async Task SaveFile(IFormFile f)
        {
            Directory.CreateDirectory(folder);
            using (var filef = new FileStream(folder,FileMod.CreatNew,FileAccess.ReadWrite))
            {
                await f.CopyToAsync(file);
                
            }
            
        }
         public void Process()
        {
            var fbyte = new FileInfo(_temppath);
            string name = fbyte.Name;
            string format = fbyte.Extension;
            long size = fbyte.Length;
            DateTime dt = DateTime.Now;
            var fi = new FileInformation(name,format,size,dt,_orginalpath);
        }
        public void ReadFileInfoList()
        {
          
          
        }
                

    }
}