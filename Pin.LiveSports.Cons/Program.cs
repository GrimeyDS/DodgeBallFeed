
using Pin.LiveSports.Cons.Entities;

Game newGame = new();

GeneralReport gReport = new GeneralReport(newGame.GameTime);
gReport.Title = "General Report";
gReport.ReportMessage = $"Dit is een general report. Time: {gReport.Time}";
newGame.GameTime = gReport.Time;

newGame.GeneralReports.Add(gReport);

FoulReport fReport = new FoulReport(newGame.GameTime);
fReport.Title = "Foul Report";
fReport.Player = "Jan de null";
fReport.ReportMessage = $"Dit is een foul report. Time: {fReport.Time} - Player: {fReport.Player}";
newGame.GameTime = fReport.Time;

newGame.FoulReports.Add(fReport);

// Primary Constructor
// Zet de meegegeven parameters in scope van heel de class. Hierdoor kunnen ze direct gebruikt worden voor initializering.
// Dit verminderd lijnen code en lijkt me super interessant bij dependency injection.
// Ik vind dat dit in bijna elk project gebruikt kan worden en word ook in dit project gebruikt.
Console.WriteLine("Primary Constructor");
Console.WriteLine("Tijd wordt als parameter doorgegeven bij een report en kan direct geinitialiseerd worden wegens de primary constructor");
Console.WriteLine("In dit geval wordt er 1 minuut bij geteld bij de huidige game time");

Console.WriteLine(gReport.Title);
Console.WriteLine(gReport.ReportMessage);

// Collection Expression and Spread Operator
// Dit zorgt ervoor dat je collecties kan samenhangen en ze 1 dimensioneel maken via de spread operator ..
// Voordeel: Minder lijnen code en overzichterlijker.
// Nog niet nodig gehad in vorige projecten maar wel zeer dankbaar voor in dit project.
// Dit maakte het zeer gemakkelijk om mn rapporten samen te gooien en te sorteren op tijd.
// Initialiseren van lijsten en arrays ook gemakkelijker. (zie entity Game).

Console.WriteLine("");
Console.WriteLine("Collection Expression");
Console.WriteLine("Lijst van alle soorten rapporten in game worden samen gevoegd en gesorteerd op tijd");
GeneralReport[] reports = [.. newGame.GeneralReports, .. newGame.FoulReports];
reports = [.. reports.OrderByDescending(x => x.Time)];

foreach(var report in reports)
{
    Console.WriteLine($"{report.Title} - {report.Time}");
}

// Default Lambda Parameters
// Je zet een default value voor 1 of meerdere parameters van een lambda expressie. 
// Hierdoor moet je niet altijd een extra parameter meegeven en zorgt dit voor overzichterlijke code.
// In dit project niet gebruikt omdat ik er nergens een nut voor vond. 
// Hiervoor dus kort wat democode geschreven. Dit zou eventueel nuttig zijn als je een spel hebt waar de score met verschillende sprongen kan gebeuren. Is niet het geval bij dodgeball.
Console.WriteLine("");
Console.WriteLine("Default Lambda Parameters");
Console.WriteLine("Score wordt gewijzigd met eventueel meegegeven parameter");


var scoreLambda = (int score, int toAddScore = 1) => score + toAddScore;

Console.WriteLine("Home Score + 1");
Console.WriteLine(scoreLambda(newGame.HomeScore));

Console.WriteLine("Away Score + 5");
Console.WriteLine(scoreLambda(newGame.AwayScore, 5));