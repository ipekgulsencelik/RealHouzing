using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DTOLayer.TeamDTOs;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult ListTeam()
        {
            var values = _teamService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTeam(AddTeamDTO addTeamDTO)
        {
            Team team = new Team()
            {
                FullName = addTeamDTO.FullName,
                Facebook = addTeamDTO.Facebook,
                ImageURL = addTeamDTO.ImageURL,
                Linkedin = addTeamDTO.Linkedin,
                Title = addTeamDTO.Title,
                Twitter = addTeamDTO.Twitter
            };
            _teamService.TInsert(team);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTeam(UpdateTeamDTO updateTeamDTO)
        {
            Team team = new Team()
            {
                TeamID = updateTeamDTO.TeamID,
                FullName = updateTeamDTO.FullName,
                Facebook = updateTeamDTO.Facebook,
                Twitter = updateTeamDTO.Twitter,
                ImageURL = updateTeamDTO.ImageURL,
                Linkedin = updateTeamDTO.Linkedin,
                Title = updateTeamDTO.Title
            };
            _teamService.TUpdate(team);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.TGetByID(id);
            _teamService.TDelete(values);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var values = _teamService.TGetByID(id);
            return Ok(values);
        }
    }
}