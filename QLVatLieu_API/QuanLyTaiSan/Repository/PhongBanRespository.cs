using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{

    public class PhongBanRepository : IPhongBanRepository
    {
        private readonly DapperContext _context;
        public PhongBanRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PhongBan>> GetPhongBan()
        {
            var procedureName = "get_PhongBan";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var PhongBan = await connection.QueryAsync<PhongBan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return PhongBan;
            }
        }

        public async Task<PhongBan> CreatePhongBan(PhongBanForCreationDto PhongBan)
        {
            var procedureName = "insert_PhongBan";
            var parameters = new DynamicParameters();
            parameters.Add("tenphongban", PhongBan.TenPhongBan, DbType.String);
            parameters.Add("nguoithem", PhongBan.NguoiThem, DbType.String);
            
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhongBan>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<PhongBan> GetPhongBan(int id)
        {
            var procedureName = "get_PhongBanid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhongBan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<PhongBan> UpdatePhongBan(PhongBan PhongBan)
        {
            var query = "update_PhongBan";
            var parameters = new DynamicParameters();
            parameters.Add("id", PhongBan.IDPhongBan, DbType.Int32);
            parameters.Add("tenphongban", PhongBan.TenPhongBan, DbType.String);
            parameters.Add("nguoiSua", PhongBan.NguoiSua, DbType.String);
            parameters.Add("trangthai", PhongBan.TrangThai, DbType.Boolean);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<PhongBan>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

        public async Task DeletePhongBan(int id)
        {
            var query = "delete_PhongBan @id";

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }
    }

}
