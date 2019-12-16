using System;

namespace DataAccess.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}