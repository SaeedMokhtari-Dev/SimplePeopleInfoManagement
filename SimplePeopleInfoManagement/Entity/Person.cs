using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite.CodeFirst;

namespace SimplePeopleInfoManagement.Entity
{
    public class Person: IEntity
    {
        [Key]
        [Autoincrement]
        public int Id { get; set; }
        [MaxLength(500)]
        public string FirstName { get; set; }
        [MaxLength(500)]
        public string LastName { get; set; }
        [MaxLength(500)]
        public string FatherName { get; set; }
        [MaxLength(500)]
        public string BirthDate { get; set; }
        [Index("IX_Person_NationalId")]
        [MaxLength(500)]
        public string NationalId { get; set; }
        [MaxLength(500)]
        public string NationalSeries { get; set; }
        [Index("IX_Person_Mobile")]
        [MaxLength(500)]
        public string Mobile { get; set; }
        [Index("IX_Person_PhoneNumber")]
        [MaxLength(500)]
        public string PhoneNumber { get; set; }
        [MaxLength(2048)]
        public string Address { get; set; }
        [MaxLength(500)]
        public string Sex { get; set; }
        [MaxLength(500)]
        public string Telegram { get; set; }
        [MaxLength(500)]
        public string Instagram { get; set; }
        [MaxLength(500)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Job { get; set; }
        [MaxLength(500)]
        public string Qualification { get; set; }
        [MaxLength(5000)]
        public string FolderAddress { get; set; }
        [MaxLength(5000)]
        public string Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [SqlDefaultValue(DefaultValue = "DATETIME('now')")]
        public DateTime CreatedUtc { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}