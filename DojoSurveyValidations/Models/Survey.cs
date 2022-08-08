#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

public class Survey {


    [Required]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
    public string Name { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    public string FavoriteLanguage { get; set; }


    [MinLength(20, ErrorMessage = "Comment must be at least 20 characters if included.")]
    public string? Comment { get; set; }
}