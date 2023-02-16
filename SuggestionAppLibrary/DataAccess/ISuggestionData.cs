using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.DataAccess;

public interface ISuggestionData
{
    Task CreateSuggestionAsync(SuggestionModel suggestion);
    Task<List<SuggestionModel>> GetApprovedSuggestionsAsync();
    Task<SuggestionModel> GetSuggestionAsync(string id);
    Task<List<SuggestionModel>> GetSuggestionsAsync();
    Task<List<SuggestionModel>> GetSuggestionsWaitingForApprovalAsync();
    Task UpdateSuggestionAsync(SuggestionModel suggestion);
    Task UpvoteSuggestionAsync(string suggestionId, string userId);
}
