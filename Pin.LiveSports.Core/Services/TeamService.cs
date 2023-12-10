
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
                    Name = "The lions",
                    Description =  "A Team from Belgium",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Doe",
                            Country = "Belgium",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Doe",
                            Country = "Belgium",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Doe",
                            Country = "Belgium",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Doe",
                            Country = "Belgium",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "The bears",
                    Description =  "A Team from Canada",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Kenobi",
                            Country = "Canada",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Kenobi",
                            Country = "Canada",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Kenobi",
                            Country = "Canada",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Kenobi",
                            Country = "Canada",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "The tigers",
                    Description =  "A Team from India",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Skywalker",
                            Country = "India",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Skywalker",
                            Country = "India",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Skywalker",
                            Country = "India",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Skywalker",
                            Country = "India",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "The eagles",
                    Description =  "A Team from USA",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Solo",
                            Country = "USA",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Solo",
                            Country = "USA",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Solo",
                            Country = "USA",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Solo",
                            Country = "USA",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "The sharks",
                    Description =  "A Team from Australia",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Maximillian",
                            Country = "Australia",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Maximillian",
                            Country = "Australia",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Maximillian",
                            Country = "Australia",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Maximillian",
                            Country = "Australia",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "The dragons",
                    Description =  "A Team from China",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Wong",
                            Country = "China",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Wong",
                            Country = "China",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Wong",
                            Country = "China",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Wong",
                            Country = "China",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "The bulls",
                    Description =  "A Team from Spain",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Garcia",
                            Country = "Spain",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Garcia",
                            Country = "Spain",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Garcia",
                            Country = "Spain",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Garcia",
                            Country = "Spain",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "The wolves",
                    Description =  "A Team from Russia",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Ivanov",
                            Country = "Russia",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Ivanov",
                            Country = "Russia",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Ivanov",
                            Country = "Russia",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Ivanov",
                            Country = "Russia",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "The panthers",
                    Description =  "A Team from Brazil",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Silva",
                            Country = "Brazil",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Silva",
                            Country = "Brazil",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Silva",
                            Country = "Brazil",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Silva",
                            Country = "Brazil",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "The falcons",
                    Description =  "A Team from France",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Leroy",
                            Country = "France",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Leroy",
                            Country = "France",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Leroy",
                            Country = "France",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Leroy",
                            Country = "France",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "The hawks",
                    Description =  "A Team from Japan",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Tanaka",
                            Country = "Japan",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Tanaka",
                            Country = "Japan",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Tanaka",
                            Country = "Japan",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Tanaka",
                            Country = "Japan",
                            Role = Role.Catchers
                        }
                    }
                },
                new Team()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "The jaguars",
                    Description =  "A Team from Mexico",
                    Players = new List<Player>()
                    {
                        new Player()
                        {
                            FirstName = "John",
                            LastName = "Amigo",
                            Country = "Mexico",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            FirstName = "Jane",
                            LastName = "Amigo",
                            Country = "Mexico",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            FirstName = "Jack",
                            LastName = "Amigo",
                            Country = "Mexico",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            FirstName = "Jill",
                            LastName = "Amigo",
                            Country = "Mexico",
                            Role = Role.Catchers
                        }
                    }
                }
            };
        }

        public IEnumerable<Team> GetTeams()
        {
            return Teams;
        }
    }
}
