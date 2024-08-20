using MyProject.Models.Defaults;
using MyProject.Types;
using MyProject.Utility;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyProject.Models.SecurityModels
{
    [Table("ChangesLog", Schema = DatabaseSchema.SecuritySchema)]
    public class ChangesLog
    {
        [Key]
        public int Id { get; set; }
        public DateTime? ChangeDate { get; set; } = DateTime.Now;
        public string? ChangedBy { get; set; }
        public ChangeMode? ChangeMode {  get; set; }
        public string? ObjectName { get; set; }
        public int ObjectIndex { get; set; }
        public string? Changes {  get; set; }
    }
    public class ChangeLogModel
    {
        public string? PropertyName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
