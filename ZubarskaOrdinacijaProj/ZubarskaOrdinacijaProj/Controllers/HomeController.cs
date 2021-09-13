using Common;
using Common.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZubarskaOrdinacijaProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public readonly ITerminService serviceTermin;
        public readonly IPacijentService servicePacijent;
        public readonly IZubarService serviceZubar;

        public HomeController(ITerminService ser1, IPacijentService ser2, IZubarService ser3)
        {
            this.serviceTermin = ser1;
            this.servicePacijent = ser2;
            this.serviceZubar = ser3;
        }

        [HttpPost("AddTermin")]
        public async Task<ActionResult> AddTermin(TerminDTO terminDto)
        {
            try
            {
                return Ok(await serviceTermin.CreateUser(terminDto));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("RemoveTermin")]
        public async Task<ActionResult> RemoveTermin([FromBody] string id)
        {
            try
            {
                return Ok(await serviceTermin.RemoveTermin(Int32.Parse(id)));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("AddPacijent")]
        public async Task<ActionResult> AddPacijent([FromBody] string mail)
        {
            try
            {
                return Ok(await servicePacijent.AddPacijent(mail));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("AddZubar")]
        public async Task<ActionResult> AddZubar([FromBody] string sifra)
        {
            try
            {
                return Ok(await serviceZubar.AddZubar(sifra));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}