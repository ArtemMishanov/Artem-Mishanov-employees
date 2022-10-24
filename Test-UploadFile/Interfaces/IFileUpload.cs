using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_UploadFile.Models;
using Test_UploadFile.ViewModels;

namespace Test_UploadFile.Interface
{
    public interface IFileUpload
    {
        public List<Emploes_input> GetEmploes_from_file_csv(string filePath);
        public List<Emploes_out> Find_Pair_OldEmploes(List<Emploes_input> emploes_Inputs);
    }
}
