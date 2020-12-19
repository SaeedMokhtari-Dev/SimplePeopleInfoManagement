using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SimplePeopleInfoManagement.Entity;
using SQLite.CodeFirst;

namespace SimplePeopleInfoManagement.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string FirstName { get; set; }
        [MaxLength(500)]
        public string LastName { get; set; }
        [MaxLength(500)]
        public string FatherName { get; set; }
        [MaxLength(500)]
        public string BirthDate { get; set; }
        [MaxLength(500)]
        public string NationalId { get; set; }
        [MaxLength(500)]
        public string NationalSeries { get; set; }
        [MaxLength(500)]
        public string Mobile { get; set; }
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
        public DateTime CreatedUtc { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}