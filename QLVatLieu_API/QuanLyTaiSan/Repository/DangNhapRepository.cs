using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{
    public class DangNhapRepository : IDangNhapRepository
    {
        private readonly DapperContext _context;
        public DangNhapRepository(DapperContext context)
        {
            _context = context;
        }
        /*  public async Task<IEnumerable<DangNhap>> GetDangNhap()
          {
              var procedureName = "exec get_DangNhap @tendangnhap, @matkhau";
              var parameters = new DynamicParameters();
              using (var connection = _context.CreateConnection())
              {
                  var DangNhap = await connection.QueryAsync<DangNhap>
                      (procedureName, parameters, commandType: CommandType.StoredProcedure);
                  return DangNhap;
              }
          }*/
        /*   public async Task<IEnumerable<DangNhap>> GetDangNhap()
           {
               var query = "exec get_DangNhap @tendangnhap, @matkhau";
               using (var connection = _context.CreateConnection())
               {
                   var companies = await connection.QueryAsync<DangNhap>(query);
                   return companies;
               }
           }*/
  /*      public async Task<DangNhap> GetDangNhap(DangNhap DangNhap)
        {
            var procedureName = "get_DangNhap";
            var parameters = new DynamicParameters();
            parameters.Add("tendangnhap", DangNhap.TenDangNhap, DbType.String);
            parameters.Add("matkhau", DangNhap.MatKhau, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<DangNhap>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }*/

        public async Task<DangNhap> GetDangNhap(DangNhap DangNhap)
        {
            var query = "exec get_DangNhap @tendangnhap, @matkhau";

            var parameters = new DynamicParameters();
            parameters.Add("tendangnhap", DangNhap.TenDangNhap, DbType.String);
            parameters.Add("matkhau", DangNhap.MatKhau, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QuerySingleOrDefaultAsync<DangNhap>(query, new { DangNhap.TenDangNhap, DangNhap.MatKhau      });

                return company;
            }

        }

        /*       public async Task<DangNhap> CreateDangNhap(DangNhapForCreationDto DangNhap)
               {
                   var procedureName = "insert_DangNhap";
                   var parameters = new DynamicParameters();
                   parameters.Add("tendangnhap", DangNhap.TenDangNhap, DbType.String);
                   parameters.Add("matkhau", DangNhap.MatKhau, DbType.String);
                   parameters.Add("nguoithem", DangNhap.NguoiThem, DbType.String);



                   using (var connection = _context.CreateConnection())
                   {
                       var company = await connection.QueryFirstOrDefaultAsync<DangNhap>
                   (procedureName, parameters, commandType: CommandType.StoredProcedure);
                       return company;
                   }

               }
               public async Task<DangNhap> GetDangNhap(int id)
               {
                   var procedureName = "get_DangNhapid";
                   var parameters = new DynamicParameters();
                   parameters.Add("id", id, DbType.Int32);
                   using (var connection = _context.CreateConnection())
                   {
                       var company = await connection.QueryFirstOrDefaultAsync<DangNhap>
                           (procedureName, parameters, commandType: CommandType.StoredProcedure);
                       return company;
                   }
               }
               public async Task<DangNhap> UpdateDangNhap(int id, DangNhapForCreationDto DangNhap)
               {
                   var query = "update_DangNhap";
                   var parameters = new DynamicParameters();
                   parameters.Add("id", id, DbType.Int32);
                   parameters.Add("tendangnhap", DangNhap.TenDangNhap, DbType.String);
                   parameters.Add("matkhau", DangNhap.MatKhau, DbType.String);
                   parameters.Add("nguoithem", DangNhap.NguoiThem, DbType.String);
                   using (var connection = _context.CreateConnection())
                   {
                       var company = await connection.QueryFirstOrDefaultAsync<DangNhap>
                           (query, parameters, commandType: CommandType.StoredProcedure);
                       return company;
                   }
               }

               public async Task DeleteDangNhap(int id)
               {
                   var query = "DELETE FROM PQ_DangNhap WHERE ID = @Id";
                   using (var connection = _context.CreateConnection())
                   {
                       await connection.ExecuteAsync(query, new { id });
                   }
               }*/


    }
}
