using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/NhanVien")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienRepository _NhanVienRepo;
        public NhanVienController(INhanVienRepository NhanVienRepo)
        {
            _NhanVienRepo = NhanVienRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetNhanVien()
        {
            try
            {
                var user = await _NhanVienRepo.GetNhanVien();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateNhanVien(NhanVienForCreationDto NhanVien)
        {
            try
            {
                var createdNhanVien = await _NhanVienRepo.CreateNhanVien(NhanVien);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "NhanVienById")]
        public async Task<IActionResult> GetNhanVien(int id)
        {
            try
            {
                var company = await _NhanVienRepo.GetNhanVien(id);
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
        /*     [HttpPost]
             public async Task<IActionResult> updateNhanVien(NhanVien NhanVien)
             {
                 try
                 {
                     var createdNhanVien = await _NhanVienRepo.UpdateNhanVien(NhanVien);
                     return StatusCode(200);
                 }
                 catch (Exception ex)
                 {
                     //log error
                     return StatusCode(500, ex.Message);
                 }
             }*/
        [HttpPut]
        public async Task<IActionResult> UpdateNhanVien( NhanVien NhanVien)
        {
            try
            {
                var dbCompany = await _NhanVienRepo.GetNhanVien(NhanVien.IDNV);
                if (dbCompany == null)
                    return NotFound();

                await _NhanVienRepo.UpdateNhanVien(NhanVien);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteNhanVien(int id)
        {
            try
            {
                var dbCompany = await _NhanVienRepo.GetNhanVien(id);
                if (dbCompany == null)
                    return NotFound();
                await _NhanVienRepo.DeleteNhanVien(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
