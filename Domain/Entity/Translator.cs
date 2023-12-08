using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Translator
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int SourceLanguageId { get; set; }
        public int TargetLanguageId { get; set; }

        public Language SourceLanguage { get; set; }
        public Language TargetLanguage { get; set; }

        public List<TranslationOfficeTranslators> TranslationOfficeTranslators { get; set; }

    }
}
