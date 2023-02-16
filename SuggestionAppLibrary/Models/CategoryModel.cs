using System;

namespace SuggestionAppLibrary.Models;

public class CategoryModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string CategoryId { get; set; } = String.Empty;
    public string CategoryName { get; set; } = String.Empty;
    public string CategoryDescription { get; set; } = String.Empty;
}