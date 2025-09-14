using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service.Models;
using RestSharp;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnBusinessOne.Service
{
    public class JournalEntryService : BaseService
    {
        public async Task<Response<JournalEntry>> ReverseAsync(JournalEntry journalEntry, Company company)
        {
            var response = new ResponseOK<JournalEntry>();

            var result = await RequestAsync(new BaseServiceRequest<JournalEntry>
            {
                Body = journalEntry,
                Company = company,
                Method = Method.Post,
                Resource = $"JournalEntries({journalEntry.TransId})/Cancel",
            });

            if (result.StatusCode == HttpStatusCode.NoContent)
            {
                response.Data = new JournalEntry
                {
                    TransId = journalEntry.TransId,
                };
                response.Result = "OK";
                response.Message = "Asiento procesado satisfactoriamente";
                response.Success = true;
            }
            else
            {
                var responseError = JsonSerializer.Deserialize<ResponseError<string>>(result.Content);
                string[] arr = responseError.Error.Message.Value.Split(',');
                string messageError = arr.Length > 1 ? arr[1] : arr[0];                
                response.Data = new JournalEntry
                {
                    TransId = journalEntry.TransId,
                };
                response.Result = $"ERROR";
                response.Message = $"{messageError}";
            }
            return response;
        }
    }
}
