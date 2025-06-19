using System.ComponentModel.DataAnnotations;

namespace LAB2.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Task không được để trống")]
        [StringLength(100, ErrorMessage = "Task không được vượt quá 100 ký tự")]
        public string Task { get; set; } = string.Empty;
    }
}