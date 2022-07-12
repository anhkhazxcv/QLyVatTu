//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/TaiKhoan")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly ITaiKhoanRepository _TaiKhoanRepo;
        public TaiKhoanController(ITaiKhoanRepository TaiKhoanRepo)
        {
            _TaiKhoanRepo = TaiKhoanRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetTaiKhoan()
        {
            try
            {
                var user = await _TaiKhoanRepo.GetTaiKhoan();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]

        public async Task<IActionResult> CreateTaiKhoan(TaiKhoanForCreationDto TaiKhoan)
            {
            try
            {
                var createdTaiKhoan = await _TaiKhoanRepo.CreateTaiKhoan(TaiKhoan);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "TaiKhoanById")]
        public async Task<IActionResult> GetTaiKhoan(int id)
        {
            try
            {
                var company = await _TaiKhoanRepo.GetTaiKhoan(id);
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
        [HttpPut]
        public async Task<IActionResult> UpdateTaiKhoan(TaiKhoan TaiKhoan)
        {
            try
            {
                var dbCompany = await _TaiKhoanRepo.GetTaiKhoan(TaiKhoan.ID);
                if (dbCompany == null) 
                    return NotFound();

                await _TaiKhoanRepo.UpdateTaiKhoan(TaiKhoan);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTaiKhoan(int id)
        {
            try
            {
                var dbCompany = await _TaiKhoanRepo.GetTaiKhoan(id);
                if (dbCompany == null)
                    return NotFound();
                await _TaiKhoanRepo.DeleteTaiKhoan(id);
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