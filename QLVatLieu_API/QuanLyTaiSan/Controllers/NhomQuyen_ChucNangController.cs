//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/NhomQuyen_ChucNang")]
    [ApiController]
    public class NhomQuyen_ChucNangController : ControllerBase
    {
        private readonly INhomQuyen_ChucNangRepository _NhomQuyen_ChucNangRepo;
        public NhomQuyen_ChucNangController(INhomQuyen_ChucNangRepository NhomQuyen_ChucNangRepo)
        {
            _NhomQuyen_ChucNangRepo = NhomQuyen_ChucNangRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetNhomQuyen_ChucNang()
        {
            try
            {
                var user = await _NhomQuyen_ChucNangRepo.GetNhomQuyen_ChucNang();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
       /* [HttpPost]

        public async Task<IActionResult> CreateNhomQuyen_ChucNang(NhomQuyen_ChucNangForCreationDto NhomQuyen_ChucNang)
        {
            try
            {
                var createdNhomQuyen_ChucNang = await _NhomQuyen_ChucNangRepo.CreateNhomQuyen_ChucNang(NhomQuyen_ChucNang);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "NhomQuyen_ChucNangById")]
        public async Task<IActionResult> GetNhomQuyen_ChucNang(int id)
        {
            try
            {
                var company = await _NhomQuyen_ChucNangRepo.GetNhomQuyen_ChucNang(id);
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
        public async Task<IActionResult> UpdateNhomQuyen_ChucNang(NhomQuyen_ChucNang NhomQuyen_ChucNang)
        {
            try
            {
                var dbCompany = await _NhomQuyen_ChucNangRepo.GetNhomQuyen_ChucNang(NhomQuyen_ChucNang.ID);
                if (dbCompany == null)
                    return NotFound();

                await _NhomQuyen_ChucNangRepo.UpdateNhomQuyen_ChucNang(NhomQuyen_ChucNang);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteNhomQuyen_ChucNang(int id)
        {
            try
            {
                var dbCompany = await _NhomQuyen_ChucNangRepo.GetNhomQuyen_ChucNang(id);
                if (dbCompany == null)
                    return NotFound();
                await _NhomQuyen_ChucNangRepo.DeleteNhomQuyen_ChucNang(id);
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