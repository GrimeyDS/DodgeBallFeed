
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Enumerations;

namespace Pin.LiveSports.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IEnumerable<Team> Teams;

        public TeamService()
        {
            Teams = new List<Team>()
            {
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "The Lions",
                    Description =  "A Team from Belgium",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                            FirstName = "Jaan",
                            LastName = "De Bol",
                            Country = "Belgium",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                            FirstName = "Mieke",
                            LastName = "Vanlandschoot",
                            Country = "Belgium",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                            FirstName = "Sarah",
                            LastName = "De Zutter",
                            Country = "Belgium",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                            FirstName = "Bart",
                            LastName = "Smoet",
                            Country = "Belgium",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/lion.png"
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "The Bears",
                    Description =  "A Team from Canada",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                            FirstName = "Chloe",
                            LastName = "Ola",
                            Country = "Canada",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                            FirstName = "Amelia",
                            LastName = "Swan",
                            Country = "Canada",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                            FirstName = "Clive",
                            LastName = "Rosaria",
                            Country = "Canada",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                            FirstName = "Sid",
                            LastName = "Cloud",
                            Country = "Canada",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/bear.png"
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "The Tigers",
                    Description =  "A Team from India",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                            FirstName = "Ishita",
                            LastName = "Kashvi",
                            Country = "India",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                            FirstName = "Asmee",
                            LastName = "Ishana",
                            Country = "India",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                            FirstName = "Anaisha",
                            LastName = "Ananya",
                            Country = "India",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                            FirstName = "Anala",
                            LastName = "Adah",
                            Country = "India",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/tiger.png"
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "The Eagles",
                    Description =  "A Team from USA",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                            FirstName = "Mike",
                            LastName = "Longshot",
                            Country = "USA",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                            FirstName = "Joshua",
                            LastName = "Renfield",
                            Country = "USA",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                            FirstName = "Jack",
                            LastName = "Baur",
                            Country = "USA",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                            FirstName = "Jill",
                            LastName = "McAllister",
                            Country = "USA",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/eagle.png"
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "The Sharks",
                    Description =  "A Team from Australia",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                            FirstName = "Mia",
                            LastName = "Zeke",
                            Country = "Australia",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                            FirstName = "Henry",
                            LastName = "Cavil",
                            Country = "Australia",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                            FirstName = "Willliam",
                            LastName = "Genova",
                            Country = "Australia",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                            FirstName = "Isla",
                            LastName = "Maximillian",
                            Country = "Australia",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/shark.png"
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "The Dragons",
                    Description =  "A Team from China",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                            FirstName = "Ai",
                            LastName = "Yang",
                            Country = "China",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                            FirstName = "Zhao",
                            LastName = "Huang",
                            Country = "China",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                            FirstName = "Zhang",
                            LastName = "Li",
                            Country = "China",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                            FirstName = "Liu",
                            LastName = "Wan",
                            Country = "China",
                            Role = Role.Catchers
                        }
                    },
                    LogoUrl = "images/logos/dragon.png"
                }
            };
        }

        public IEnumerable<Team> GetTeams()
        {
            return Teams;
        }
    }
}
