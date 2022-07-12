using QuanLyTaiSan.Context;
using QuanLyTaiSan.Contracts;
using QuanLyTaiSan.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
builder.Services.AddScoped<IPhongBanRepository, PhongBanRepository>();
builder.Services.AddScoped<IPhieuNhapTSRepository, PhieuNhapTSRepository>();
builder.Services.AddScoped<INhanHieuRepository, NhanHieuRepository>();
builder.Services.AddScoped<INhomQuyenRepository, NhomQuyenRepository>();
builder.Services.AddScoped<INhanVienRepository, NhanVienRepository>();
builder.Services.AddScoped<IDangNhapRepository, DangNhapRepository>();
builder.Services.AddScoped<INhomQuyen_TaiKhoanRepository, NhomQuyen_TaiKhoanRepository>();
builder.Services.AddScoped<INhomQuyen_ChucNangRepository, NhomQuyen_ChucNangRepository>();
builder.Services.AddControllers();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddControllers();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("http://localhost:4200", "http://localhost:4200")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
