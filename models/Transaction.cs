using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using cse325_budgetwise.Data;

namespace cse325_budgetwise.Models;

public class Transaction
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    public DateTime Date { get; set; } = DateTime.Today;

    [Required]
    public TransactionType Type { get; set; }

    // Category relationship
    [Required]
    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    // User relationship
    [Required]
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }
}