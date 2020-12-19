using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SimplePeopleInfoManagement.Entity;
using SQLite.CodeFirst;

namespace SimplePeopleInfoManagement.Models
{
    public class CategoryModel
    {
        private ICollection<PersonModel> _people;
        
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string Description { get; set; }
        
        public DateTime CreatedUtc { get; set; }

        public virtual ICollection<PersonModel> People {
            get => _people ?? (_people = new HashSet<PersonModel>());
            set => _people = value;
        }
    }
}