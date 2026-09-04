using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MobileServer.Models
{
    public class FileInformation
    {
       public string FileName{ get; set;}
       public string FileFormat { get; set;}
       public long FileSize { get; set;}
       public DateTime FileDate { get; set;}
       public string FilePath {get; set;}
       public int NumberOfFiles { get; set;}
       public static List<FileInformation> CacheFiles = new List<FileInformation>();
       public FileInformation(string FN,string FF,long FS,DateTime FD,string FP)
        {
              FileName = FN;
              FileFormat = FF;
              FileSize = FS;
              FileDate = FD;
              FilePath = FP;
              CacheFiles.Add(this);
        }
        public void writejson()
        {
            File.AppendAllText(Path.Combine(FilePath,"Filesinfo.json"),
            $"|{FileName}.{FileFormat} : size:{FileSize} date:{FileDate}|");
        }
      

    }
}