wizard wizardA = new wizard("Yuji", 25);
wizard wizardB = new wizard("Mahito", 30);

Console.WriteLine("Permainan Dimulai\n");
wizardA.ShowsStats();
wizardB.ShowsStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardB.Heal();
//wizardA.Attack(wizardB);

string pilihan;

while (wizardA.Energi > 0 && wizardB.Energi > 0)
{
    Console.WriteLine("Pilih salah satu penyihir: ");
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\n Masukkan pilihan anda(1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan anda ngawur");
    }
}

Console.WriteLine("Permainan Berakhir\n");
Console.WriteLine("Statistik Akhir");
wizardA.ShowsStats();
wizardB.ShowsStats();

if (wizardA.Energi > wizardB.Energi)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel");
}
else
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel");
}

public class wizard
{
    //deklarasi field
    public string Name;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public wizard(string name, int damage)
    {
        Name = name;
        Energi = 100;
        Damage = damage;
    }

    public void ShowsStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi} \n");
    }

    public void Attack(wizard wizardLawanobj)
    {
        //mengurangi energi wizardLawanonj sebesar damage
        wizardLawanobj.Energi -= Damage;
        Console.WriteLine($" {Name} menyerang {wizardLawanobj.Name} ");
        Console.WriteLine($"Sisa energi {wizardLawanobj.Name} adalah {wizardLawanobj.Energi}");
    }
    public void Heal()
    {
        Energi += 5;

        if (Energi <= 100)
        {
            Console.WriteLine($"{Name} melakukan heal energi meningkat menjadi {Energi}");
        }
        else
        {
            Energi = 100;
            Console.WriteLine("Sudah mencapai energi maksimum");
        }
    }
}