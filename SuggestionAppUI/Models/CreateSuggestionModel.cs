using System.ComponentModel.DataAnnotations;
using System;

namespace SuggestionAppUI.Models;

public class CreateSuggestionModel
{
    [Required]
    [MaxLength(75)]
    public string Suggestion { get; set; } = String.Empty;

    [Required]
    [MinLength(1)]
    [Display(Name = "Category")]
    public string CategoryId { get; set; } = String.Empty;

    [MaxLength(500)]
    public string Description { get; set; } = String.Empty;
}