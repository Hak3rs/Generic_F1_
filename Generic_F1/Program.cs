using Generic_F1.Data;
using Generic_F1.Repository;
using Generic_F1.Team;

var recerRepo = new SqlRepo<Racer>(new F1DbContext());
AddRacer(recerRepo);
AddRecerTests(recerRepo);
WriteAllConsole(recerRepo);


static void AddRacer(IRepo<Racer> racer)
{
    racer.Add(new Racer { Name = "Max", Surname = "Verstappen", Team = "RedBull Racing" });
    racer.Add(new Racer { Name = "Sergio", Surname = "Perez", Team = "RedBull Racing" });
    racer.Save();
}

static void AddRecerTests(IWriteRepo<RacerTests> racerT)
{
    racerT.Add(new RacerTests { Name = "Sebastien", Surname = "Buemi", Team = "RedBull Racing" });
    racerT.Add(new RacerTests { Name = "Sergio", Surname = "Camara", Team = "RedBull Racing" });
    racerT.Save();
}

static void WriteAllConsole(IReadRepo<IPerson> personRepo)
{
    var person = personRepo.GetAll();
    foreach (var team in person)
    {
        Console.WriteLine(team);
    }
}