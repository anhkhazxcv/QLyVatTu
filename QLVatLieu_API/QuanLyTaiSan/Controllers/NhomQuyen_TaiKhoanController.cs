//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/NhomQuyen_TaiKhoan")]
    [ApiController]
    public class NhomQuyen_TaiKhoanController : ControllerBase
    {
        private readonly INhomQuyen_TaiKhoanRepository _NhomQuyen_TaiKhoanRepo;
        public NhomQuyen_TaiKhoanController(INhomQuyen_TaiKhoanRepository NhomQuyen_TaiKhoanRepo)
        {
            _NhomQuyen_TaiKhoanRepo = NhomQuyen_TaiKhoanRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetNhomQuyen_TaiKhoan()
        {
            try
            {
                var user = await _NhomQuyen_TaiKhoanRepo.GetNhomQuyen_TaiKhoan();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
       /* [HttpPost]

        public async Task<IActionResult> CreateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoanForCreationDto NhomQuyen_TaiKhoan)
        {
            try
            {
                var createdNhomQuyen_TaiKhoan = await _NhomQuyen_TaiKhoanRepo.CreateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "NhomQuyen_TaiKhoanById")]
        public async Task<IActionResult> GetNhomQuyen_TaiKhoan(int id)
        {
            try
            {
                var company = await _NhomQuyen_TaiKhoanRepo.GetNhomQuyen_TaiKhoan(id);
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
        public async Task<IActionResult> UpdateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan NhomQuyen_TaiKhoan)
        {
            try
            {
                var dbCompany = await _NhomQuyen_TaiKhoanRepo.GetNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan.ID);
                if (dbCompany == null)
                    return NotFound();

                await _NhomQuyen_TaiKhoanRepo.UpdateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteNhomQuyen_TaiKhoan(int id)
        {
            try
            {
                var dbCompany = await _NhomQuyen_TaiKhoanRepo.GetNhomQuyen_TaiKhoan(id);
                if (dbCompany == null)
                    return NotFound();
                await _NhomQuyen_TaiKhoanRepo.DeleteNhomQuyen_TaiKhoan(id);
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