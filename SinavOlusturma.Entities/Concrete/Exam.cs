using SinavOlusturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavOlusturma.Entities.Concrete
{
    public class Exam : EntityBase, IEntity
    {
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
