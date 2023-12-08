using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageTitle { get; set; }
        public List<Translator> SourceTranslators { get; set; }
        public List<Translator> TargetTranslators { get; set; }
        public List<OrderDetail> SourceOrderDetails { get; set; }
        public List<OrderDetail> TargetOrderDetails { get; set; }
    }
}
