
Dictionary<string, decimal> bankList = new Dictionary<string, decimal>()
        {
            { "BANK OF AMERICA YB", -208703.00m },
            { "YATIRIM FİNANSMAN", -189197.00m },
            { "AK", -124758.00m },
            { "ZİRAAT", -44721.00m },
            { "YAPIKREDİ", -20927.00m },
            { "QNB", -20450.00m },
            { "İŞ", -14469.00m },
            { "DENİZ", -10000.00m },
            { "GARANTİ", -299.00m },
            { "VAKIF", -173.00m },
            { "MİDAS MENKUL DEĞERLER A.Ş.", 173.00m },
            { "TACİRLER", 495.00m },
            { "TEB BANK", 9262.00m },
            { "PHİLLİP", 13000.00m },
            { "İNFO", 21665.00m },
            { "OSMANLI", 44721.00m },
            { "YATIRIM FONLARI", 126031.00m },
            { "CITIBANK YB", 418350.00m }
        };

Dictionary<string, decimal> matchingBanks = new Dictionary<string, decimal>();

foreach (var kvp in bankList)
{
    if (kvp.Value < 0)
    {
        decimal newValue = kvp.Value * -1m;

        foreach (var innerKvp in bankList)
        {
            if (innerKvp.Key != kvp.Key && innerKvp.Value == newValue)
            {
                //matchingBanks.Add(kvp.Key);
                //matchingBanks.Add(innerKvp.Key);

                matchingBanks.Add(innerKvp.Key, newValue);
                matchingBanks.Add(kvp.Key, kvp.Value);

                bankList.Remove(innerKvp.Key);
                bankList.Remove(kvp.Key);

                
            }
        }
    }
}

  
Console.WriteLine("Eşit olan bankalar:");

foreach (var item in matchingBanks)
{
    Console.WriteLine($"Banka ismi:{item.Key} Islem Degeri:{item.Value}");
}

Console.WriteLine("\n\n\nKalan Bankalar:");

foreach (var kvp in bankList)
{
    Console.WriteLine($"Banka ismi:{kvp.Key} Islem Degeri:{kvp.Value}");
}








