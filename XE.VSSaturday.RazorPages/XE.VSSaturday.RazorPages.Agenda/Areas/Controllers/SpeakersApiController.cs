namespace XE.VSSaturday.RazorPages.Agenda.Areas.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using XE.VSSaturday.RazorPages.Agenda.Models;

    [Produces("application/json")]
    [Route("api/agenda/speakers", Name = "AgendaSpeakers")]
    [ApiController]
    public class SpeakersApiController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<SpeakerModel>> Get()
        {
            var list = new[]
            {
                new SpeakerModel
                {
                    Name = "Alessio Biasiutti",
                    Description = "Azure Solution Architect @ Altitudo"
                },
                new SpeakerModel
                {
                    Name = "Marco Parenzan",
                    Description = "1nn0va community lead"
                },
                new SpeakerModel
                {
                    Name = "Marco Minerva",
                    Description = "Microsoft MVP Windows Development"
                },
                new SpeakerModel
                {
                    Name = "Riccardo Cappello",
                    Description = "Microsoft Azure MVP"
                },
                new SpeakerModel
                {
                    Name = "Marco Leoncini",
                    Description = "Senior Software Engineer @ ALTEN Italia"
                },
                new SpeakerModel
                {
                    Name = "Andrea Dottor",
                    Description = "Microsoft MVP Developer Technologies"
                },
                new SpeakerModel
                {
                    Name = "Emanuele Bartolesi",
                    Description = "ASP.NET Core Ninja and Unicorn Trainer"
                },
                new SpeakerModel
                {
                    Name = "Marco Zamana",
                    Description = "Senior Software Developer .NET"
                },
                new SpeakerModel
                {
                    Name = "Gaetano Paternò",
                    Description = "DotNetSicilia, OrangeDev"
                },
                new SpeakerModel
                {
                    Name = "Marco Bortolin",
                    Description = "Co–Founder Hunext Software srl"
                },
                new SpeakerModel
                {
                    Name = "Mirco Vanini",
                    Description = "Senior Developer & Consultant"
                },
                new SpeakerModel
                {
                    Name = "Alessandro Melchiori",
                    Description = "Software developer @ CodicePlastico"
                },
                new SpeakerModel
                {
                    Name = "Lorenzo Barbieri",
                    Description = "Normal People Bore Me! Cloud Wizard @@ Microsoft, Solutions Architect, Speaker, Mentor, Would-Be Book Author. Here & Now."
                },
                new SpeakerModel
                {
                    Name = "Andrea Agnoletto",
                    Description = "MCSD Web Applications - Sviluppatore e consulente."
                },
                new SpeakerModel
                {
                    Name = "Daniele Morosinotto",
                    Description = "Javascript enthusiast"
                },
                new SpeakerModel
                {
                    Name = "Davide Contin",
                    Description = "QWERTY Studio"
                },
                new SpeakerModel
                {
                    Name = "Marco Minerva",
                    Description = "Microsoft MVP Windows Development"
                },
                new SpeakerModel
                {
                    Name = "Andrea Tosato",
                    Description = "CloudGen Verona co-fondatore, Senior Software .NET Developer"
                }
            };

            return Ok(list.OrderBy(x => x.Name).ToArray());
        }
    }
}
