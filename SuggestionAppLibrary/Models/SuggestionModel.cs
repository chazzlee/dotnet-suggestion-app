using System;
using System.Collections.Generic;

namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;
    public string Suggestion { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public CategoryModel Category { get; set; } = new();
    public BasicUserModel Author { get; set; } = new();
    public HashSet<string> UserVotes { get; set; } = new();
    public StatusModel? SuggestionStatus { get; set; } = null;
    public string OwnerNotes { get; set; } = String.Empty;
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Rejected { get; set; } = false;
}