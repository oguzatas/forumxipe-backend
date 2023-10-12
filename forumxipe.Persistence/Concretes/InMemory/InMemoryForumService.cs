using forumxipe.Application.Abstraction;
using forumxipe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumxipe.Persistence.Concretes.InMemory
{
    public class InMemoryForumService : IForumService
    {
        public List<Forum> GetForums()
         => new()
         {
            new() {Id= Guid.NewGuid() } ,
            new() {Id= Guid.NewGuid() } ,
            new() {Id= Guid.NewGuid() }
         };
    }
}
