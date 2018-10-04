using Helper;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(CarMetadata))]
    public partial class Car
    {
        internal sealed class CarMetadata
        {
            [ElementAssociated("TablaParaGuardarDecimales", "CampoParaGuardarDecimales")]
            public decimal Price { get; set; }
            [ElementAssociated("TablaParaGuardarColor", "CampoParaGuardarColor")]
            public string Color { get; set; }
        }
    }

    [MetadataType(typeof(MotoMetadata))]
    public partial class Moto
    {
        internal sealed class MotoMetadata
        {
            [ElementAssociated("TablaParaGuardarColor", "CampoParaGuardarColor")]
            public string Color { get; set; }
        }
    }
}
