using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class SetPiece
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SetPieceId { get; set; }
        public string PieceLabel { get; set; }
        public string TwoPieceBonus { get; set; }
        public string ThreePieceBonus { get; set; }
        public string FourPieceBonus { get; set; }
        public string SetLogo { get; set; }
    }
}