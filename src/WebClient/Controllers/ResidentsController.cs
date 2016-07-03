﻿using Dramonkiller.HappyGrandpaCareHome.WebClient.Models;
using Dramonkiller.HappyGrandpaCareHome.WebClient.Server;
using Dramonkiller.HappyGrandpaCareHome.WebServerDTOs.Residents;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Dramonkiller.HappyGrandpaCareHome.WebClient.Controllers
{
    public class ResidentsController : Controller
    {
        // GET: Residents
        public async Task<ActionResult> Index()
        {
            WebServerClient client = new WebClient.Server.WebServerClient();

            var residentsDTO = await client.GetAllResidents();

            return View(residentsDTO.Select(r => ConvertResidentToViewModel(r)));
        }

        private ResidentViewModel ConvertResidentToViewModel(ResidentDTO resident)
        {
            return resident == null ?
                null :
                new ResidentViewModel()
                {
                    Id = resident.Id,
                    Name = resident.Name,
                    Middle = resident.Middle,
                    Surname = resident.Surname
                };
        }
    }
}