using System;

namespace SuggestionAppLibrary.Models;

public class StatusModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;
    public string StatusName { get; set; } = String.Empty;
    public string StatusDescription { get; set; } = String.Empty;
}