using System;
using System.Collections.Generic;

namespace SuggestionAppLibrary.Models;

public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;
    public string ObjectIdentifier { get; set; } = String.Empty;
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string DisplayName { get; set; } = String.Empty;
    public string EmailAddress { get; set; } = String.Empty;
    public List<SuggestionModel> AuthoredSuggestions { get; set; } = new();
    public List<SuggestionModel> VotedOnSuggestions { get; set; } = new();
}