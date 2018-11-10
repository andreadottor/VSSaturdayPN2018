namespace XE.VSSaturday.RazorPages.Agenda.Areas.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using XE.VSSaturday.RazorPages.Agenda.Models;

    [Produces("application/json")]
    [Route("api/agenda/sessions", Name = "AgendaSessions")]
    [ApiController]
    public class SessionsApiController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<SessionModel>> Get()
        {
            var list = new[]
            {
                new SessionModel
                {
                    Speaker = "Alessio Biasiutti",
                    Title = "Visual Studio for IoT Solutions"
                },
                new SessionModel
                {
                    Speaker = "Marco Parenzan",
                    Title = "C#: dove siamo"
                },
                new SessionModel
                {
                    Speaker = "Marco Minerva",
                    Title = "AI on The Edge"
                },
                new SessionModel
                {
                    Speaker = "Riccardo Cappello - Marco Leoncini",
                    Title = "Continuous everything with Visual Studio App Center"
                },
                new SessionModel
                {
                    Speaker = "Andrea Dottor",
                    Title = "ASP.NET Core Razor Pages"
                },
                new SessionModel
                {
                    Speaker = "Emanuele Bartolesi",
                    Title = "ASP.NET Core SignalR"
                },
                new SessionModel
                {
                    Speaker = "Marco Zamana",
                    Title = "Machine Learning in ML.NET"
                },
                new SessionModel
                {
                    Speaker = "Gaetano Paternò",
                    Title = "Crea, condividi e usa codice utile con NuGet"
                },
                new SessionModel
                {
                    Speaker = "Marco Bortolin",
                    Title = "Visual Studio for Mac"
                },
                new SessionModel
                {
                    Speaker = "Mirco Vanini",
                    Title = "Debugger Tips and Tricks for .NET Developers with Microsoft Visual Studio 2017"
                },
                new SessionModel
                {
                    Speaker = "Andrea Dottor",
                    Title = "ASP.NET Core - dove siamo arrivati"
                },
                new SessionModel
                {
                    Speaker = "Alessandro Melchiori",
                    Title = "A quick tour around Azure Dev Spaces"
                },
                new SessionModel
                {
                    Speaker = "Sync workitems between multiple Team Projects: the good, the bad, the ugly...",
                    Title = "Lorenzo Barbieri"
                },
                new SessionModel
                {
                    Speaker = "Public speaking for geeks: how to rock the stage!",
                    Title = "Lorenzo Barbieri"
                },
                new SessionModel
                {
                    Speaker = "Andrea Agnoletto",
                    Title = "The 'Blazor effect'"
                },
                new SessionModel
                {
                    Speaker = "Daniele Morosinotto - Davide Contin",
                    Title = "UN NUOVO MODO DI COLLABORARE GRAZIE A LIVE SHARE"
                },
                new SessionModel
                {
                    Speaker = "Marco Minerva",
                    Title = "Sviluppare librerie cross-platform con .NET Standard"
                },
                new SessionModel
                {
                    Speaker = "Andrea Tosato",
                    Title = "Visual Studio Performance Tools"
                }
            };
            
            return Ok(list.OrderBy(x => x.Title).ToArray());
        }
    }
}
