using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/NhomQuyen")]
    [ApiController]
    public class NhomQuyenController : ControllerBase
    {
        private readonly INhomQuyenRepository _NhomQuyenRepo;
        public NhomQuyenController(INhomQuyenRepository NhomQuyenRepo)
        {
            _NhomQuyenRepo = NhomQuyenRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetNhomQuyen()
        {
            try
            {
                var user = await _NhomQuyenRepo.GetNhomQuyen();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]

        public async Task<IActionResult> CreateNhomQuyen(NhomQuyen NhomQuyen)
        {
            try
            {
                var createdNhomQuyen = await _NhomQuyenRepo.CreateNhomQuyen(NhomQuyen);
                return StatusCode(0);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "NhomQuyenById")]
        public async Task<IActionResult> GetNhomQuyen(int id)
        {
            try
            {
                var company = await _NhomQuyenRepo.GetNhomQuyen(id);
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
        public async Task<IActionResult> UpdateNhomQuyen(int id, NhomQuyen NhomQuyen)
        {
            try
            {
                var dbCompany = await _NhomQuyenRepo.GetNhomQuyen(id);
                if (dbCompany == null)
                    return NotFound();

                await _NhomQuyenRepo.UpdateNhomQuyen(id, NhomQuyen);
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