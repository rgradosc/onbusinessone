using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service;
using OnBusinessOne.Service.Models;
using System.Threading.Tasks;

namespace OnBusinessOne.Controllers
{
    public class JournalEntryController
    {
        private readonly FileController _fileController;
        private readonly LoginController _loginController;
        private readonly JournalEntryService _journalEntryService;

        public JournalEntryController()
        {
            _fileController = new FileController();
            _loginController = new LoginController();
            _journalEntryService = new JournalEntryService();
        }

        public async Task ReverseAsync()
        {
            var journalEntries = await _fileController.AllJournalEntriesFromFileAsync();
            if (journalEntries.Count > 0)
            {
                Company companyAuth = await _loginController.AuthenticateAsync();
                if (companyAuth != null)
                {
                    foreach (var journalEntry in journalEntries)
                    {
                        Response<JournalEntry> journalEntryReverse =
                            await _journalEntryService.ReverseAsync(journalEntry, companyAuth);
                        await _fileController.SaveJournalEntryToFileAsync((ResponseOK<JournalEntry>)journalEntryReverse);
                    }
                }
            }
            await _loginController.LogoutAsync();
        }

    }
}
