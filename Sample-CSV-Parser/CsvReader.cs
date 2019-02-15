using System.Collections.Generic;
using System.IO;

namespace Sample_CSV_Parser
{
    public class CsvReader
    {
        private string[] columns;
        private TextReader source;
        public CsvReader(TextReader reader)
        {
            this.source = reader;
            var columnLine =reader.ReadLine();
            this.columns = columnLine.Split(',');

        }
        public IEnumerable<KeyValuePair<string,string>[]> Lines
        {
           get{
               string row;
               while ((row=this.source.ReadLine()) !=null)
               {
                   var cells = row.Split(',');
                   var pairs = new KeyValuePair<string,string>[columns.Length];
                   for (int i = 0; i < columns.Length; i++)
                   {
                       pairs[i]= new KeyValuePair<string, string>(columns[i],cells[i]);

                   }
                   yield return pairs; //yield return returns enumerable values as they are read
               }
           } 
        }
    }
}