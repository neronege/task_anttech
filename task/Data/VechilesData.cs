using task.Entity;

namespace task.Data;

public static class VechilesData
{
    public static List<Vehicle> Vehicles { get; set; } = new()
    {
        new Vehicle
        {
            Date = new DateTime(2024, 12, 6, 8, 36,0),
            Plate = "07 AT 1267",
            TransactionNo = "12865",
            TransactionStatus = "Tamamlandı",
            DeviceId = "SN07070712865",
            TotalKw = "162.000 KW",
            TotalAmount = "1,266.85 TL",
            PaymentMethod = "**** 1234 "
        },
        new Vehicle
        {
            Date = new DateTime(2024, 11, 30, 9, 15, 0),
            Plate = "34 XY 5678",
            TransactionNo = "12866",
            TransactionStatus = "Tamalandı",
            DeviceId = "SN08080812866",
            TotalKw = "145.000 KW",
            TotalAmount = "1,100.00 TL",
            PaymentMethod = "**** 5678"
        } ,
         new Vehicle
         {
             Date = new DateTime(2024, 12, 8, 9, 15, 0),
             Plate = "35 XZ 1234",
             TransactionNo = "13366",
             TransactionStatus = "Tamalandı",
             DeviceId = "SN0808099999",
             TotalKw = "155.000 KW",
             TotalAmount = "1,100.00 TL",
             PaymentMethod = "**** 5678"
         },
           new Vehicle
           {
               Date = new DateTime(2024, 12, 1, 9, 15, 0),
               Plate = "06 YT 1234",
               TransactionNo = "14466",
               TransactionStatus = "Tamalandı",
               DeviceId = "SN080801111",
               TotalKw = "159.000 KW",
               TotalAmount = "1,100.00 TL",
               PaymentMethod = "**** 1234"
           }
    };
}
