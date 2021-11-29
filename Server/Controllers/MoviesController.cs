using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Logging;
using proyFinal_g63.Shared;
using Microsoft.EntityFrameworkCore;
using proyFinal_g63.Shared.Model;

namespace proyFinal_g63.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController:ControllerBase
    {
        //Es necesario inyectarlo:
        private readonly ApplicationDbContext context;
        public MoviesController(ApplicationDbContext context){
            this.context = context;
        }

        
        [HttpPost]
        //Con el POST permite crear un nuevo recurso
        public async Task<ActionResult<int>> Post(Movie movie){
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }        
    }
}