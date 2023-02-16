using System;

namespace SuggestionAppLibrary.Models;

public class BasicSuggestionModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;
    public string Suggestion { get; set; } = String.Empty;

    public BasicSuggestionModel()
    {
    }

    public BasicSuggestionModel(SuggestionModel suggestion)
    {
        Id = suggestion.Id;
        Suggestion = suggestion.Suggestion;
    }
}