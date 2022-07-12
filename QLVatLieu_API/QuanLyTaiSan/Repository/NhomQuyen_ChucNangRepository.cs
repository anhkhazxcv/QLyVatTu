using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class NhomQuyen_ChucNangRepository : INhomQuyen_ChucNangRepository
    {
        private readonly DapperContext _context;
        public NhomQuyen_ChucNangRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NhomQuyen_ChucNang>> GetNhomQuyen_ChucNang()
        {
            var procedureName = "get_NQ_CN";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var NhomQuyen_ChucNang = await connection.QueryAsync<NhomQuyen_ChucNang>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return NhomQuyen_ChucNang;
            }
        }

/*        public async Task<NhomQuyen_ChucNang> CreateNhomQuyen_ChucNang(NhomQuyen_ChucNangForCreationDto NhomQuyen_ChucNang)
        {
            var procedureName = "insert_NhomQuyen_ChucNang";
            var parameters = new DynamicParameters();
            parameters.Add("tendangnhap", NhomQuyen_ChucNang.TenDangNhap, DbType.String);
            parameters.Add("matkhau", NhomQuyen_ChucNang.MatKhau, DbType.String);
            parameters.Add("nguoithem", NhomQuyen_ChucNang.NguoiThem, DbType.String);



            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_ChucNang>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<NhomQuyen_ChucNang> GetNhomQuyen_ChucNang(int id)
        {
            var procedureName = "get_NhomQuyen_ChucNangid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_ChucNang>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<NhomQuyen_ChucNang> UpdateNhomQuyen_ChucNang(NhomQuyen_ChucNang NhomQuyen_ChucNang)
        {
            var query = "update_NhomQuyen_ChucNang";
            var parameters = new DynamicParameters();
            parameters.Add("id", NhomQuyen_ChucNang.ID, DbType.Int32);
            parameters.Add("tendangnhap", NhomQuyen_ChucNang.TenDangNhap, DbType.String);
            parameters.Add("matkhau", NhomQuyen_ChucNang.MatKhau, DbType.String);
            parameters.Add("nguoisua", NhomQuyen_ChucNang.NguoiSua, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen_ChucNang>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

        public async Task DeleteNhomQuyen_ChucNang(int id)
        {
            var query = "delete_NhomQuyen_ChucNang @Id";
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }*/


    }
}

