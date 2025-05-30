using MAPZebraPrinter.Data;
using MAPZebraPrinter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MAPZebraPrinter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext Context => _context;

        [HttpGet("ProductRSF")]
        public async Task<ActionResult<IEnumerable<ProductRSF>>> GetProductRSF()
        {
            return await Context.ProductRSF.ToListAsync();
        }

        [HttpGet("AliasNumber")]
        public async Task<ActionResult<IEnumerable<AliasNumber>>> GetAliasNumber()
        {
            return await Context.AliasNumber.ToListAsync();
        }

        [HttpGet("BOEODTrn")]
        public async Task<ActionResult<IEnumerable<BOEODTrn>>> GetBOEODTrn()
        {
            return await Context.BOEODTrn.ToListAsync();
        }

        [HttpGet("SalesPriceList")]
        public async Task<ActionResult<IEnumerable<SalesPriceList>>> GetSalesPriceList()
        {
            return await Context.SalesPriceList.ToListAsync();
        }

        [HttpGet("SystemTable")]
        public async Task<ActionResult<IEnumerable<SystemTable>>> GetSystemTable()
        {
            return await Context.SystemTable.ToListAsync();
        }

        // Get single item by code
        /*[HttpGet("{code}")]
        public async Task<ActionResult<Object>> GetProductRSFByCode(string code)
        {
            
            var queryData = await (
                from p in _context.ProductRSF
                join a in _context.AliasNumber on p.ItemNumber equals a.ItemNumber
                join sys in _context.SystemTable on p.ItemGroup equals sys.KeyValue into sysGroup
                from sys in sysGroup.DefaultIfEmpty()
                select new
                {
                    p.ItemNumber,
                    p.Description,
                    p.DimensionX,
                    p.DimensionYOptionID,
                    Category = (string)null, // placeholder, fill later
                    EAN = a.AliasNumber1,
                    p.FreeField4,
                    SystemDesc = sys.Description
                }
            ).FirstOrDefaultAsync();

            if (queryData == null)
                return NotFound();

            // Now query SalesPriceList separately
            var priceGroupList = await _context.SalesPriceList
                .Where(sp => sp.ItemNumber == queryData.ItemNumber)
                .ToListAsync();

            var result = new
            {
                Variant = queryData.ItemNumber,
                Description = queryData.Description,
                ProductCategory = queryData.SystemDesc ?? queryData.FreeField4,
                EANNumber = queryData.EAN,
                Size = queryData.DimensionX,
                Color = queryData.DimensionYOptionID,
                WasPrice = priceGroupList.FirstOrDefault(p => p.SalesCampaign == "0")?.SalesPrice,
                CurrentPrice = priceGroupList
                    .OrderByDescending(p => int.TryParse(p.SalesCampaign, out var val) ? val : -1)
                    .FirstOrDefault()?.SalesPrice
            };

            return Ok(result);
            
        }*/
    }
}
