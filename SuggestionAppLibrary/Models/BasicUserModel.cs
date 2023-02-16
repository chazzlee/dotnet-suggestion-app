using System;

namespace SuggestionAppLibrary.Models;

public class BasicUserModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;
    public string DisplayName { get; set; } = String.Empty;

    public BasicUserModel()
    {
    }

    public BasicUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName;
    }
}