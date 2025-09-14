using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service.Models;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnBusinessOne.DataAccess.Extensions
{
    public static class TextConnectorExtension
    {
        public static string FullFilePath(this string fileName) 
        {
            return string.Format(@"{0}\{1}", ConfigurationManager.AppSettings["filePath"], fileName);
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static async Task<List<JournalEntry>> ConvertToJournalEntryAsync(this List<string> lines)
        {
            return await Task.Run(() =>
            {
                List<JournalEntry> output = new List<JournalEntry>();

                foreach (string line in lines)
                {
                    string[] cols = line.Split(',');

                    JournalEntry p = new JournalEntry();
                    p.TransId = int.Parse(cols[0]);
                    output.Add(p);
                }

                return output;
            });
        }

        public static async Task<List<ResponseOK<JournalEntry>>> ConvertToJournalReverseAsync(this List<string> lines)
        {
            return await Task.Run(() =>
            {
                List<ResponseOK<JournalEntry>> response = new List<ResponseOK<JournalEntry>>();

                foreach (var line in lines)
                {
                    string[] cols = line.Split(',');
                    ResponseOK<JournalEntry> r = new ResponseOK<JournalEntry>
                    {
                        Id = int.Parse(cols[0].Trim()),
                        Data = new JournalEntry
                        {
                            TransId = int.Parse(cols[1].Trim()),
                        },
                        Result = cols[2].Trim(),
                        Message = cols[3].Trim()
                    };
                    response.Add(r);
                }

                return response;
            });
        }

        public static async Task SaveJournalReverseAsync(this List<ResponseOK<JournalEntry>> models)
        {
            await Task.Run(() =>
            {
                List<string> lines = new List<string>();

                foreach (ResponseOK<JournalEntry> p in models)
                {
                    lines.Add(string.Format("{0}, {1}, {2}, {3}", p.Id, p.Data.TransId, p.Result, p.Message));
                }

                //File.WriteAllLines(GlobalConfig.JournalReverseFile.FullFilePath(), lines);                

                using (var stream = new StreamWriter(FileResources.JournalReverseFile.FullFilePath()))
                {
                    lines.ForEach(line =>
                    {
                        var lineWrite = Regex.Replace(line, @"\s", " ");
                        stream.WriteLine(lineWrite);
                    });

                    stream.Close();
                    stream.Dispose();
                }
            });
        }
    }
}
