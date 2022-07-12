using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class NhomQuyen_TaiKhoanRepository : INhomQuyen_TaiKhoanRepository
    {
        private readonly DapperContext _context;
        public NhomQuyen_TaiKhoanRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NhomQuyen_TaiKhoan>> GetNhomQuyen_TaiKhoan()
        {
            var procedureName = "get_NQ_TK";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var NhomQuyen_TaiKhoan = await connection.QueryAsync<NhomQuyen_TaiKhoan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return NhomQuyen_TaiKhoan;
            }
        }

/*        public async Task<NhomQuyen_TaiKhoan> CreateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoanForCreationDto NhomQuyen_TaiKhoan)
        {
            var procedureName = "insert_NhomQuyen_TaiKhoan";
            var parameters = new DynamicParameters();
            parameters.Add("tendangnhap", NhomQuyen_TaiKhoan.TenDangNhap, DbType.String);
            parameters.Add("matkhau", NhomQuyen_TaiKhoan.MatKhau, DbType.String);
            parameters.Add("nguoithem", NhomQuyen_TaiKhoan.NguoiThem, DbType.String);



            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_TaiKhoan>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<NhomQuyen_TaiKhoan> GetNhomQuyen_TaiKhoan(int id)
        {
            var procedureName = "get_NhomQuyen_TaiKhoanid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_TaiKhoan>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<NhomQuyen_TaiKhoan> UpdateNhomQuyen_TaiKhoan(NhomQuyen_TaiKhoan NhomQuyen_TaiKhoan)
        {
            var query = "update_NhomQuyen_TaiKhoan";
            var parameters = new DynamicParameters();
            parameters.Add("id", NhomQuyen_TaiKhoan.ID, DbType.Int32);
            parameters.Add("tendangnhap", NhomQuyen_TaiKhoan.TenDangNhap, DbType.String);
            parameters.Add("matkhau", NhomQuyen_TaiKhoan.MatKhau, DbType.String);
            parameters.Add("nguoisua", NhomQuyen_TaiKhoan.NguoiSua, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_TaiKhoan>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

        public async Task DeleteNhomQuyen_TaiKhoan(int id)
        {
            var query = "delete_NhomQuyen_TaiKhoan @Id";
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }*/


    }
}

