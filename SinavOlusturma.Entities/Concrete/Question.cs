using SinavOlusturma.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavOlusturma.Entities.Concrete
{
    public class Question : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Option { get; set; }
        public string Answer { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
