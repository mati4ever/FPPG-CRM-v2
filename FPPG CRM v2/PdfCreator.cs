using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace FPPG_CRM_v2
{
    public class PdfCreator
    {
        public string FileName { get; set; }
        public List<TaskModel> Lista { get; set; }

        private string path
        {
            get
            {
                return $@"{ FileName }.pdf";
            }
        }

        public void CreateReport()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph($"Raport z dnia:  { DateTime.Now.ToString("dd-MM-yyyy") }");
            doc.Add(title);

            foreach (TaskModel task in Lista)
            {
                Paragraph paragraph = new Paragraph($"{task.DateOfExecution.ToString("dd-MM-yyyy")}   --   { task.Person.LastName } {task.Person.LastName}   --   {task.Category}");
                doc.Add(paragraph);
            }
            
            
            doc.Close();
            System.Diagnostics.Process.Start(path);
        }


    }
}
