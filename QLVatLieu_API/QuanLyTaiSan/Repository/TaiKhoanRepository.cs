using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private readonly DapperContext _context;
        public TaiKhoanRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TaiKhoan>> GetTaiKhoan()
        {
            var procedureName = "get_TaiKhoan";
            var parameters = new DynamicParameters();
            
            using (var connection = _context.CreateConnection())
            {
                var TaiKhoan = await connection.QueryAsync<TaiKhoan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return TaiKhoan;
            }
        }

        public async Task<TaiKhoan> CreateTaiKhoan(TaiKhoanForCreationDto TaiKhoan)
        {
            var procedureName = "insert_TaiKhoan";
            var parameters = new DynamicParameters();
            parameters.Add("tendangnhap", TaiKhoan.TenDangNhap, DbType.String);
            parameters.Add("matkhau", TaiKhoan.MatKhau, DbType.String);
            parameters.Add("nguoithem", TaiKhoan.NguoiThem, DbType.String);
           


            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<TaiKhoan>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<TaiKhoan> GetTaiKhoan(int id)
        {
            var procedureName = "get_TaiKhoanid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<TaiKhoan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<TaiKhoan> UpdateTaiKhoan(TaiKhoan TaiKhoan)
        {
            var query = "update_TaiKhoan";
            var parameters = new DynamicParameters();
            parameters.Add("id", TaiKhoan.ID , DbType.Int32);
            parameters.Add("tendangnhap", TaiKhoan.TenDangNhap, DbType.String);
            parameters.Add("matkhau", TaiKhoan.MatKhau, DbType.String);
            parameters.Add("nguoisua", TaiKhoan.NguoiSua, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<TaiKhoan>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
    
        public async Task DeleteTaiKhoan(int id)
        {
            var query = "delete_TaiKhoan @Id";
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }


    }
}
