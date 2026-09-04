using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Threading.Tasks;
using MobileServer.Models;

namespace MobileServer.Services
{
    public class FileService
    {  
        private string _orginalpath;
        private string _temppath;
        public int NumberFileinList;
        public FileService()
        {
            _orginalpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _temppath = Path.Combine(Path.GetTempPath(),"uploaded_file");
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
            CacheFile[NumberFileinList].FileName;
            CacheFile[NumberFileinList].FileFormat;
            CacheFile[NumberFileinList].FileDate;
            CacheFile[NumberFileinList].FileSize; 
        }
                

    }
}