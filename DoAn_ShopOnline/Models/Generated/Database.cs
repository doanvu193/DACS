




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `ShopOnlineConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=LAPTOP-R7OB3OFM\MSSQLSERVER01;Initial Catalog=ShopOnline;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace ShopOnlineConnection
{

	public partial class ShopOnlineConnectionDB : Database
	{
		public ShopOnlineConnectionDB() 
			: base("ShopOnlineConnection")
		{
			CommonConstruct();
		}

		public ShopOnlineConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			ShopOnlineConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static ShopOnlineConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new ShopOnlineConnectionDB();
        }

		[ThreadStatic] static ShopOnlineConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static ShopOnlineConnectionDB repo { get { return ShopOnlineConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.__MigrationHistory")]



	[PrimaryKey("MigrationId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class __MigrationHistory : ShopOnlineConnectionDB.Record<__MigrationHistory>  
    {



		[Column] public string MigrationId { get; set; }





		[Column] public string ContextKey { get; set; }





		[Column] public byte[] Model { get; set; }





		[Column] public string ProductVersion { get; set; }



	}

    

	[TableName("dbo.AspNetRoles")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetRole : ShopOnlineConnectionDB.Record<AspNetRole>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }



	}

    

	[TableName("dbo.AspNetUserClaims")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class AspNetUserClaim : ShopOnlineConnectionDB.Record<AspNetUserClaim>  
    {



		[Column] public int Id { get; set; }





		[Column] public string UserId { get; set; }





		[Column] public string ClaimType { get; set; }





		[Column] public string ClaimValue { get; set; }



	}

    

	[TableName("dbo.AspNetUserLogins")]



	[PrimaryKey("LoginProvider", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserLogin : ShopOnlineConnectionDB.Record<AspNetUserLogin>  
    {



		[Column] public string LoginProvider { get; set; }





		[Column] public string ProviderKey { get; set; }





		[Column] public string UserId { get; set; }



	}

    

	[TableName("dbo.AspNetUserRoles")]



	[PrimaryKey("UserId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserRole : ShopOnlineConnectionDB.Record<AspNetUserRole>  
    {



		[Column] public string UserId { get; set; }





		[Column] public string RoleId { get; set; }



	}

    

	[TableName("dbo.AspNetUsers")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUser : ShopOnlineConnectionDB.Record<AspNetUser>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Email { get; set; }





		[Column] public bool EmailConfirmed { get; set; }





		[Column] public string PasswordHash { get; set; }





		[Column] public string SecurityStamp { get; set; }





		[Column] public string PhoneNumber { get; set; }





		[Column] public bool PhoneNumberConfirmed { get; set; }





		[Column] public bool TwoFactorEnabled { get; set; }





		[Column] public DateTime? LockoutEndDateUtc { get; set; }





		[Column] public bool LockoutEnabled { get; set; }





		[Column] public int AccessFailedCount { get; set; }





		[Column] public string UserName { get; set; }



	}

    

	[TableName("dbo.BinhLuan")]



	[PrimaryKey("MaBinhLuan")]




	[ExplicitColumns]

    public partial class BinhLuan : ShopOnlineConnectionDB.Record<BinhLuan>  
    {



		[Column] public int MaBinhLuan { get; set; }





		[Column] public string MaSanPham { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public string TenTaiKhoan { get; set; }





		[Column] public string NoiDung { get; set; }





		[Column] public int? TinhTrang { get; set; }





		[Column] public DateTime? Ngay { get; set; }



	}

    

	[TableName("dbo.ChiTietHoaDon")]



	[PrimaryKey("MaSanPham", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class ChiTietHoaDon : ShopOnlineConnectionDB.Record<ChiTietHoaDon>  
    {



		[Column] public string MaSanPham { get; set; }





		[Column] public long OrderID { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public int? Gia { get; set; }





		[Column] public int? TongTien { get; set; }



	}

    

	[TableName("dbo.GioHang")]



	[PrimaryKey("IdGH")]




	[ExplicitColumns]

    public partial class GioHang : ShopOnlineConnectionDB.Record<GioHang>  
    {



		[Column] public int IdGH { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public string MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public int? Gia { get; set; }





		[Column] public int? TongTien { get; set; }



	}

    

	[TableName("dbo.HoaDon")]



	[PrimaryKey("ID")]




	[ExplicitColumns]

    public partial class HoaDon : ShopOnlineConnectionDB.Record<HoaDon>  
    {



		[Column] public long ID { get; set; }





		[Column] public DateTime? NgayTao { get; set; }





		[Column] public string NguoiDat { get; set; }





		[Column] public string NguoiNhan { get; set; }





		[Column] public string SDT { get; set; }





		[Column] public string DiaChi { get; set; }





		[Column] public long? TongTien { get; set; }





		[Column] public int? TrangThai { get; set; }



	}

    

	[TableName("dbo.LoaiSanPham")]



	[PrimaryKey("MaLoaiSanPham", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class LoaiSanPham : ShopOnlineConnectionDB.Record<LoaiSanPham>  
    {



		[Column] public string MaLoaiSanPham { get; set; }





		[Column] public string TenLoaiSanPham { get; set; }





		[Column] public string TinhTrang { get; set; }



	}

    

	[TableName("dbo.NhaSanXuat")]



	[PrimaryKey("MaNhaSanXuat", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class NhaSanXuat : ShopOnlineConnectionDB.Record<NhaSanXuat>  
    {



		[Column] public string MaNhaSanXuat { get; set; }





		[Column] public string TenNhaSanXuat { get; set; }





		[Column] public string TinhTrang { get; set; }



	}

    

	[TableName("dbo.SanPham")]



	[PrimaryKey("MaSanPham", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class SanPham : ShopOnlineConnectionDB.Record<SanPham>  
    {



		[Column] public string MaSanPham { get; set; }





		[Column] public string MaLoaiSanPham { get; set; }





		[Column] public string MaNhaSanXuat { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public string CauHinh { get; set; }





		[Column] public string MoreImages { get; set; }





		[Column] public int? Gia { get; set; }





		[Column] public int? SoLuongDaBan { get; set; }





		[Column] public int? LuotView { get; set; }





		[Column] public string TinhTrang { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : ShopOnlineConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    

	[TableName("dbo.ThongTinCaNhan")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class ThongTinCaNhan : ShopOnlineConnectionDB.Record<ThongTinCaNhan>  
    {



		[Column] public int id { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public string TenTaiKhoan { get; set; }





		[Column] public int? SoDienThoai { get; set; }





		[Column] public string DiaChi { get; set; }





		[Column] public string GioiTinh { get; set; }





		[Column] public string NgaySinh { get; set; }



	}


}
