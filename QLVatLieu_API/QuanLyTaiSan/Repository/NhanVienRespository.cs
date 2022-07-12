using Dapper;
using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Dto;
using QuanLyTaiSan.Entities;
using System.Data;

namespace QuanLyTaiSan.Repository
{

    public class NhanVienRepository : INhanVienRepository
    {
        private readonly DapperContext _context;
        public NhanVienRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NhanVien>> GetNhanVien()
        {
            var procedureName = "get_NhanVien";
            var parameters = new DynamicParameters();

            using (var connection = _context.CreateConnection())
            {
                var NhanVien = await connection.QueryAsync<NhanVien>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return NhanVien;
            }
        }

        public async Task<NhanVien> CreateNhanVien(NhanVienForCreationDto NhanVien)
        {
            var procedureName = "insert_NhanVien";
            var parameters = new DynamicParameters();
            parameters.Add("hoten", NhanVien.HoTen, DbType.String);
            parameters.Add("gioitinh", NhanVien.GioiTinh, DbType.String);
            parameters.Add("ngaysinh", NhanVien.NgaySinh, DbType.String);
            parameters.Add("diachi", NhanVien.DiaChi, DbType.String);
            parameters.Add("sdt", NhanVien.SDT, DbType.String);
            parameters.Add("CMND", NhanVien.CMND, DbType.String);
            parameters.Add("IDPhongBan", NhanVien.IDPhongBan, DbType.Int64);
            parameters.Add("nguoithem", NhanVien.NguoiThem, DbType.String); 
            parameters.Add("IDNhomQuyen", NhanVien.IDNhomQuyen, DbType.Int64);
            

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhanVien>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }

        }
        public async Task<NhanVien> GetNhanVien(int id)
        {
            var procedureName = "get_NhanVienid";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhanVien>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }
        public async Task<NhanVien> UpdateNhanVien(NhanVien NhanVien)
        {
            var query = "update_NhanVien";
            var parameters = new DynamicParameters();
            parameters.Add("id", NhanVien.IDNV, DbType.Int32);
            parameters.Add("hoten", NhanVien.HoTen, DbType.String);
            parameters.Add("gioitinh", NhanVien.GioiTinh, DbType.String);
            parameters.Add("ngaysinh", NhanVien.NgaySinh, DbType.Date);
            parameters.Add("diachi", NhanVien.DiaChi, DbType.String);
            parameters.Add("sdt", NhanVien.SDT, DbType.String);
            parameters.Add("CMND", NhanVien.CMND, DbType.String);
            parameters.Add("IDPhongBan", NhanVien.IDPhongBan, DbType.Int64);
            parameters.Add("nguoiSua", NhanVien.NguoiSua, DbType.String);
            parameters.Add("IDNhomQuyen", NhanVien.IDNhomQuyen, DbType.Int64);
            parameters.Add("trangthai", NhanVien.TrangThai, DbType.Boolean);
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<NhanVien>
                    (query, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

        public async Task DeleteNhanVien(int id)
        {
            var query = "delete_NhanVien @id";
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }
    }

}
