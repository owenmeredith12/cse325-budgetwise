using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using cse325_budgetwise.Data;

namespace cse325_budgetwise.Models;

public class Budget
{
    public int Id { get; set; }

    [Required]
    [Range(
        typeof(decimal),
        "0.01",
        "999999999.99",
        ErrorMessage = "Budget amount must be greater than zero.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    [Range(1, 12, ErrorMessage = "Month must be between 1 and 12.")]
    public int Month { get; set; } = DateTime.Today.Month;

    [Required]
    [Range(2000, 2100, ErrorMessage = "Enter a valid year.")]
    public int Year { get; set; } = DateTime.Today.Year;

    [Required]
    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }
}