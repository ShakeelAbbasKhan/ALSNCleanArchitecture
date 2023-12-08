using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class TranslationOfficeTranslators
    {
        public int Id { get; set; }
        public int TranslatorID { get; set; }
        public Translator Translator { get; set; }
        public string TranslationOfficeId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
