wizard wizardA = new wizard("Yuji", 25);
wizard wizardB = new wizard("Mahito", 30);

Console.WriteLine("Permainan Dimulai\n");
wizardA.ShowsStats();
wizardB.ShowsStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Berakhir\n");

public class wizard
{
    //deklarasi field
    public string Name;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public wizard (string name, int damage)
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
}