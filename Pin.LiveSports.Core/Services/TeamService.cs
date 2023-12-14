
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
                            PictureUrl = "images/players/belgium.jpg",
                            FirstName = "Jan",
                            LastName = "De Bol",
                            Country = "Belgium",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                            PictureUrl = "images/players/belgium.jpg",
                            FirstName = "Mieke",
                            LastName = "Vanlandschoot",
                            Country = "Belgium",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                            PictureUrl = "images/players/belgium.jpg",
                            FirstName = "Sarah",
                            LastName = "De Zutter",
                            Country = "Belgium",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                            PictureUrl = "images/players/belgium.jpg",
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
                            PictureUrl = "images/players/canadian.jpg",
                            FirstName = "Chloe",
                            LastName = "Ola",
                            Country = "Canada",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                            PictureUrl = "images/players/canadian.jpg",
                            FirstName = "Amelia",
                            LastName = "Swan",
                            Country = "Canada",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                            PictureUrl = "images/players/canadian.jpg",
                            FirstName = "Clive",
                            LastName = "Rosaria",
                            Country = "Canada",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                            PictureUrl = "images/players/canadian.jpg",
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
                            PictureUrl = "images/players/india.png",
                            FirstName = "Ishita",
                            LastName = "Kashvi",
                            Country = "India",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                            PictureUrl = "images/players/india.png",
                            FirstName = "Asmee",
                            LastName = "Ishana",
                            Country = "India",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                            PictureUrl = "images/players/india.png",
                            FirstName = "Anaisha",
                            LastName = "Ananya",
                            Country = "India",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                            PictureUrl = "images/players/india.png",
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
                            PictureUrl = "images/players/american.png",
                            FirstName = "Mike",
                            LastName = "Longshot",
                            Country = "USA",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                            PictureUrl = "images/players/american.png",
                            FirstName = "Joshua",
                            LastName = "Renfield",
                            Country = "USA",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                            PictureUrl = "images/players/american.png",
                            FirstName = "Jack",
                            LastName = "Baur",
                            Country = "USA",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                            PictureUrl = "images/players/american.png",
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
                            PictureUrl = "images/players/australian.jpg",
                            FirstName = "Mia",
                            LastName = "Zeke",
                            Country = "Australia",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                            PictureUrl = "images/players/australian.jpg",
                            FirstName = "Henry",
                            LastName = "Cavil",
                            Country = "Australia",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                            PictureUrl = "images/players/australian.jpg",
                            FirstName = "Willliam",
                            LastName = "Genova",
                            Country = "Australia",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                            PictureUrl = "images/players/australian.jpg",
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
                            PictureUrl = "images/players/chinese.jpg",
                            FirstName = "Ai",
                            LastName = "Yang",
                            Country = "China",
                            Role = Role.Captain
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                            PictureUrl = "images/players/chinese.jpg",
                            FirstName = "Zhao",
                            LastName = "Huang",
                            Country = "China",
                            Role = Role.Throwers
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                            PictureUrl = "images/players/chinese.jpg",
                            FirstName = "Zhang",
                            LastName = "Li",
                            Country = "China",
                            Role = Role.Corners
                        },
                        new Player()
                        {
                            Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                            PictureUrl = "images/players/chinese.jpg",
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
