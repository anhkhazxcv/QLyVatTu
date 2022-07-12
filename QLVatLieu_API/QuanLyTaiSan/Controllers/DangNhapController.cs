//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/DangNhap")]
    [ApiController]
    public class DangNhapController : ControllerBase
    {
        private readonly IDangNhapRepository _DangNhapRepo;
        public DangNhapController(IDangNhapRepository DangNhapRepo)
        {
            _DangNhapRepo = DangNhapRepo;
        }
       /* [HttpPost]
        public async Task<IActionResult> GetDangNhap()
        {
            try
            {
                var user = await _DangNhapRepo.GetDangNhap();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
*/
        [HttpPost]
        public async Task<IActionResult> GetDangNhap(DangNhap DangNhap)
        {
            try
            {
                var companies = await _DangNhapRepo.GetDangNhap(DangNhap);
                var abc = await _DangNhapRepo.GetDangNhap(DangNhap);
                if (companies == null)

                    return Ok(abc);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        /*[HttpPost]

        public async Task<IActionResult> CreateDangNhap(DangNhapForCreationDto DangNhap)
        {
            try
            {
                var createdDangNhap = await _DangNhapRepo.CreateDangNhap(DangNhap);
                return StatusCode(0);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "DangNhapById")]
        public async Task<IActionResult> GetDangNhap(int id)
        {
            try
            {
                var company = await _DangNhapRepo.GetDangNhap(id);
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
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDangNhap(int id, DangNhapForCreationDto DangNhap)
        {
            try
            {
                var dbCompany = await _DangNhapRepo.GetDangNhap(id);
                if (dbCompany == null) 
                    return NotFound();

                await _DangNhapRepo.UpdateDangNhap(id, DangNhap);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDangNhap(int id)
        {
            try
            {
                var dbCompany = await _DangNhapRepo.GetDangNhap(id);
                if (dbCompany == null)
                    return NotFound();
                await _DangNhapRepo.DeleteDangNhap(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }*/
    }

}