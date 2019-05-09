using Files.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files.IService
{
    public interface IFileService
    {
        FileModel FindFile(string appid, string fileid);
    }
}
