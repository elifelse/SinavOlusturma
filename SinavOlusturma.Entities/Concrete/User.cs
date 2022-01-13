using SinavOlusturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavOlusturma.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
