using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{



    public class NhanHieuRepository : INhanHieuRepository
    {
        private readonly DapperContext _context;
        public NhanHieuRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NhanHieu>> GetNhanHieu()
        {
            var procedureName = "get_NhanHieu";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var NhanHieu = await connection.QueryAsync<NhanHieu>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return NhanHieu;
            }
        }

        public async Task<NhanHieu> CreateNhanHieu(NhanHieu NhanHieu)
        {
            var procedureName = "insert_NhanHieu";
            var parameters = new DynamicParameters();
            parameters.Add("tenNhanHieu", NhanHieu.TenNhanHieu, DbType.String);
            parameters.Add("nguoiThem", NhanHieu.NguoiThem, DbType.String);
             
                using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhanHieu>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<NhanHieu> GetNhanHieu(int id)
        {
            var procedureName = "get_NhanHieuid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhanHieu>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
    }
}

