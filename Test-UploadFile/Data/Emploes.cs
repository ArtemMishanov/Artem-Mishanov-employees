using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_UploadFile.Interface;
using Test_UploadFile.Models;
using Test_UploadFile.ViewModels;
using System.Globalization;
using System.IO;
using System.Text;

namespace Test_UploadFile.Data
{
    public class Emploes : IFileUpload
    {
        public List<Emploes_out> Find_Pair_OldEmploes(List<Emploes_input> emploes_Inputs)
        {

            List<Emploes_input> SortResult = emploes_Inputs.OrderBy(x => x.Project_id).ThenByDescending(x => x.Count_days_worked).ToList();

            var id_projects = SortResult.GroupBy(proj => proj.Project_id).ToList();

            List<Emploes_out> foundEmploes = new List<Emploes_out>();

            DateTime DateFrom_min = new DateTime();

            DateTime DateTo_min = new DateTime();


            foreach (var project_id in id_projects) {

                List<Emploes_input> SortResultSelect = SortResult.Where(x => x.Project_id == project_id.Key).Take(2).ToList();
                
                if (SortResultSelect.Count == 2) {

                    Emploes_out emp = new Emploes_out();

                    emp.Employee_id_1 = SortResultSelect[0].Emp_id;
                    emp.Employee_id_2 = SortResultSelect[1].Emp_id;
                    emp.Priject_id = SortResultSelect[0].Project_id;

                    DateFrom_min = SortResultSelect.Min(DaateMin => DaateMin.Date_from);

                    DateTo_min = SortResultSelect.Min(DaateMin => DaateMin.Date_to);

                    emp.Count_days_worked = (DateTo_min - DateFrom_min).Days;
                    
                    foundEmploes.Add(emp);
                    
                }
            }
            
            return foundEmploes;
        }


        
        public List<Emploes_input> GetEmploes_from_file_csv(string filePath)
        {

            TimeSpan testDate = new TimeSpan();

            List<Emploes_input> empl = new List<Emploes_input>();

            string[] validformats = new[] { "yyyy-MM-dd", "dd-MM-yyyy", "MM/dd/yyyy", "yyyy/MM/dd", "MM/dd/yyyy HH:mm:ss",
                                        "MM/dd/yyyy hh:mm tt",  };

            CultureInfo provider = new CultureInfo("en-US");

            try
            {
                // чете фаил текст .csv
                StreamReader reader = new StreamReader(filePath, Encoding.Default);

                string[] rows = reader.ReadLine().Split(',');

                while (reader.EndOfStream == false)
                {
                    var row = reader.ReadLine();

                    var cells = row.Split(',').ToList();

                    if (cells.Count > 0)
                    {
                        Emploes_input item = new Emploes_input();

                        item.Emp_id = Convert.ToInt32(cells[0]);
                        item.Project_id = Convert.ToInt32(cells[1]);
                        item.Date_from = DateTime.ParseExact(cells[2], validformats, provider, DateTimeStyles.None);


                        if (cells[3] == "NULL")
                        {
                            item.Date_to = DateTime.Now;
                        }
                        else
                        {
                            item.Date_to = DateTime.ParseExact(cells[3], validformats, provider, DateTimeStyles.None);
                        }

                        testDate = item.Date_to - item.Date_from;

                        item.Count_days_worked = testDate.Days;

                        empl.Add(item);

                    }
                }
            }
            catch (Exception err)
            {
                throw err;
            }


            return empl;

        }
    }
}
