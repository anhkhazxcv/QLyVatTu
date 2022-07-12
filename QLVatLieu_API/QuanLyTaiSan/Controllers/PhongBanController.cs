using Microsoft.AspNetCore.Mvc;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;

namespace QuanLyTaiSan.Controllers
{

    [Route("api/PhongBan")]
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        private readonly IPhongBanRepository _PhongBanRepo;
        public PhongBanController(IPhongBanRepository PhongBanRepo)
        {
            _PhongBanRepo = PhongBanRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetPhongBan()
        {
            try
            {
                var user = await _PhongBanRepo.GetPhongBan();
                return Ok(user);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreatePhongBan(PhongBanForCreationDto PhongBan)
        {
            try
            {
                var createdPhongBan = await _PhongBanRepo.CreatePhongBan(PhongBan);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}", Name = "PhongBanById")]
        public async Task<IActionResult> GetPhongBan(int id)
        {
            try
            {
                var company = await _PhongBanRepo.GetPhongBan(id);
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
             public async Task<IActionResult> updatePhongBan(PhongBan PhongBan)
             {
                 try
                 {
                     var createdPhongBan = await _PhongBanRepo.UpdatePhongBan(PhongBan);
                     return StatusCode(200);
                 }
                 catch (Exception ex)
                 {
                     //log error
                     return StatusCode(500, ex.Message);
                 }
             }*/
        [HttpPut]
        public async Task<IActionResult> UpdatePhongBan(PhongBan PhongBan)
        {
            try
            {
                var dbCompany = await _PhongBanRepo.GetPhongBan(PhongBan.IDPhongBan);
                if (dbCompany == null)
                    return NotFound();

                await _PhongBanRepo.UpdatePhongBan(PhongBan);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePhongBan(int id)
        {
            try
            {
                var dbCompany = await _PhongBanRepo.GetPhongBan(id);
                if (dbCompany == null)
                    return NotFound();
                await _PhongBanRepo.DeletePhongBan(id);
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
