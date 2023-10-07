namespace froggo.API.Models;

public class WaterQualityData
{
    public double Nitrogen { get; set; } // Азот, мг/дм3

    public double AmmoniumIons { get; set; } // Амоній-іони, мг/дм3

    public double BiochemicalOxygenDemand { get; set; } // Біохімічне споживання кисню за 5 діб, мгО2/дм3

    public double SuspendedSubstances { get; set; } // Завислі (суспендовані) речовини, мг/дм3

    public double DissolvedOxygen { get; set; } // Кисень розчинений, мгО2/дм3

    public double NitrateIons { get; set; } // Нітрат-іони, мг/дм3

    public double NitriteIons { get; set; } // Нітрит-іони, мг/дм3

    public double SulfateIons { get; set; } // Сульфат-іони, мг/дм3

    public double PhosphateIons { get; set; } // Фосфат-іони (поліфосфати), мг/дм3

    public double ChlorideIons { get; set; } // Хлорид-іони, мг/дм3
}