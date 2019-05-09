using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files.Model
{
    public class FileModel
    {
        public Stream stream { get; set; }

        public string contentType { get; set; }
    }
}
