using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{
   
        [Route("api/NhanHieu")]
        [ApiController]
        public class NhanHieuController : ControllerBase
        {
            private readonly INhanHieuRepository _NhanHieuRepo;
            public NhanHieuController(INhanHieuRepository NhanHieuRepo)
            {
                _NhanHieuRepo = NhanHieuRepo;
            }
            [HttpGet]
            public async Task<IActionResult> GetNhanHieu()
            {
                try
                {
                    var user = await _NhanHieuRepo.GetNhanHieu();
                    return Ok(user);
                }
                catch (Exception ex)
                {
                    //log error
                    return StatusCode(500, ex.Message);
                }
            }
            [HttpPost]
            public async Task<IActionResult> CreateNhanHieu(NhanHieu NhanHieu)
            {
                try
                {
                    var createdNhanHieu = await _NhanHieuRepo.CreateNhanHieu(NhanHieu);
                return StatusCode(0);
                }
                catch (Exception ex)
                {
                    //log error
                    return StatusCode(500, ex.Message);
                }
            }
            [HttpGet("{id}", Name = "NhanHieuById")]
            public async Task<IActionResult> GetNhanHieu(int id)
            {
                try
                {
                    var company = await _NhanHieuRepo.GetNhanHieu(id);
                    if (company == null)
                        return NotFound();
                    return Ok(company);
                }
                catch (Exception ex)
                {
                    //log error
                    return StatusCode(500, ex.Message);
                }
            }
        }
}
