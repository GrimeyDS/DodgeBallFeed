
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
