using OnBusinessOne.DataAccess;
using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnBusinessOne.Controllers
{
    public class FileController
    {
        private readonly TextConnector _connector;

        public FileController()
        {
            _connector = new TextConnector();
        }

        public async Task<List<JournalEntry>> AllJournalEntriesFromFileAsync()
        {
            return await _connector.GetJournalEntriesAsync();
        }

        public async Task SaveJournalEntryToFileAsync(ResponseOK<JournalEntry> response)
        {
            await _connector.CreateJournalReverseAsync(response);
        }
    }
}
