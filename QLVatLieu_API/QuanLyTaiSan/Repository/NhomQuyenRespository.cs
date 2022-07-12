using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class NhomQuyenRepository : INhomQuyenRepository
    {
        private readonly DapperContext _context;
        public NhomQuyenRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NhomQuyen>> GetNhomQuyen()
        {
            var procedureName = "get_NhomQuyen";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var NhomQuyen = await connection.QueryAsync<NhomQuyen>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return NhomQuyen;
            }
        }

        public async Task<NhomQuyen> CreateNhomQuyen(NhomQuyen NhomQuyen)
        {
            var procedureName = "insert_NhomQuyen";
            var parameters = new DynamicParameters();
            parameters.Add("tenNhom", NhomQuyen.TenNhomQuyen, DbType.String);
            parameters.Add("nguoiThem", NhomQuyen.NguoiThem, DbType.String);
           



            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<NhomQuyen> GetNhomQuyen(int id)
        {
            var procedureName = "get_NhomQuyenid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<NhomQuyen> UpdateNhomQuyen(int id, NhomQuyen NhomQuyen)
        {
            var query = "update_NhomQuyen";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("tenNhom", NhomQuyen.TenNhomQuyen, DbType.String);
            parameters.Add("nguoiSua", NhomQuyen.NguoiSua, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhomQuyen>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

     


    }
}
