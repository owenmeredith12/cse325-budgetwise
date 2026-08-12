using System.ComponentModel.DataAnnotations;
using cse325_budgetwise.Data;

namespace cse325_budgetwise.Models;

public class Category
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public TransactionType Type { get; set; } = TransactionType.Expense;

    public string UserId { get; set; } = string.Empty;

    public ApplicationUser User { get; set; } = null!;
}