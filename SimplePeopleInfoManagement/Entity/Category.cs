using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SimplePeopleInfoManagement.Models;
using SQLite.CodeFirst;

namespace SimplePeopleInfoManagement.Entity
{
    public class Category: IEntity
    {
        private ICollection<Person> _people;
        
        [Key]
        [Autoincrement]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string Description { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [SqlDefaultValue(DefaultValue = "DATETIME('now')")]
        public DateTime CreatedUtc { get; set; }

        public virtual ICollection<Person> People {
            get => _people ?? (_people = new HashSet<Person>());
            set => _people = value;
        }
    }
}