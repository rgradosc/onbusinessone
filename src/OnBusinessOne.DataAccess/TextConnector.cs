using OnBusinessOne.DataAccess.Extensions;
using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBusinessOne.DataAccess
{
    public class TextConnector
    {
        public async Task CreateJournalReverseAsync(ResponseOK<JournalEntry> model)
        {
            List<ResponseOK<JournalEntry>> responses = await FileResources
                .JournalReverseFile.FullFilePath().LoadFile().ConvertToJournalReverseAsync();

            int currentId = 1;

            if (responses.Count > 0)
            {
                currentId = responses.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            responses.Add(model);

            await responses.SaveJournalReverseAsync();
        }

        public async Task<List<JournalEntry>> GetJournalEntriesAsync()
        {
            return await FileResources.JournalEntryFile
                .FullFilePath().LoadFile().ConvertToJournalEntryAsync();
        }
    }
}
