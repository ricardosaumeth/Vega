using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Model;
using vega.Persistence;
using vega.Controllers.Resources;
using AutoMapper;

namespace vega.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly VegaDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(VegaDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;

    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<MakeResource>> GetMakes()
    {
       var makes = await context.Makes.Include(m => m.Models).ToListAsync();
       return mapper.Map<List<Make>, List<MakeResource>>(makes);
    }
  }
}