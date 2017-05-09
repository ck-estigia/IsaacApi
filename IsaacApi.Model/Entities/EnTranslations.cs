using IsaacApi.Model.Partial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class EnTranslations: ITranslation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnTranslationsId { get; set; }
        public string TranslationKey { get; set; }
        public string TranslationValue { get; set; }
    }
}
