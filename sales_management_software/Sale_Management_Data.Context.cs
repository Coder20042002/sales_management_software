﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sales_management_software
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Sale_ManagementEntities : DbContext
    {
        public Sale_ManagementEntities()
            : base("name=Sale_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DON_HANG> DON_HANG { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<LOAI_SAN_PHAM> LOAI_SAN_PHAM { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
        public virtual DbSet<QUAN_LY> QUAN_LY { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONG_SO_KY_THUAT> THONG_SO_KY_THUAT { get; set; }
    
        public virtual int Insert_donhang(string madh, string makh, Nullable<System.DateTime> ngaydat, Nullable<System.DateTime> ngaygiao, string diachigiao, Nullable<bool> deleted, string masp, string tensp, Nullable<int> dongia, Nullable<int> soluong)
        {
            var madhParameter = madh != null ?
                new ObjectParameter("madh", madh) :
                new ObjectParameter("madh", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaydatParameter = ngaydat.HasValue ?
                new ObjectParameter("ngaydat", ngaydat) :
                new ObjectParameter("ngaydat", typeof(System.DateTime));
    
            var ngaygiaoParameter = ngaygiao.HasValue ?
                new ObjectParameter("ngaygiao", ngaygiao) :
                new ObjectParameter("ngaygiao", typeof(System.DateTime));
    
            var diachigiaoParameter = diachigiao != null ?
                new ObjectParameter("diachigiao", diachigiao) :
                new ObjectParameter("diachigiao", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_donhang", madhParameter, makhParameter, ngaydatParameter, ngaygiaoParameter, diachigiaoParameter, deletedParameter, maspParameter, tenspParameter, dongiaParameter, soluongParameter);
        }
    
        public virtual int Insert_hoadon(string mahd, string masp, string tensp, Nullable<int> dongia, Nullable<int> giamgia, Nullable<int> soluong, Nullable<int> tongtien, Nullable<bool> deleted, string madh, Nullable<System.DateTime> ngaydat, string makh, string tenkh)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var giamgiaParameter = giamgia.HasValue ?
                new ObjectParameter("giamgia", giamgia) :
                new ObjectParameter("giamgia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var madhParameter = madh != null ?
                new ObjectParameter("madh", madh) :
                new ObjectParameter("madh", typeof(string));
    
            var ngaydatParameter = ngaydat.HasValue ?
                new ObjectParameter("ngaydat", ngaydat) :
                new ObjectParameter("ngaydat", typeof(System.DateTime));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_hoadon", mahdParameter, maspParameter, tenspParameter, dongiaParameter, giamgiaParameter, soluongParameter, tongtienParameter, deletedParameter, madhParameter, ngaydatParameter, makhParameter, tenkhParameter);
        }
    
        public virtual int Insert_kh(string makh, string tenkh, string sdt, string diachi, Nullable<bool> deleted, string username, string pass)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_kh", makhParameter, tenkhParameter, sdtParameter, diachiParameter, deletedParameter, usernameParameter, passParameter);
        }
    
        public virtual int Insert_lsp(string maloai, string tenloai, Nullable<bool> deleted)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_lsp", maloaiParameter, tenloaiParameter, deletedParameter);
        }
    
        public virtual int Insert_ncc(string maNCC, string tencty, string diachi, string sdt, Nullable<bool> deleted)
        {
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var tenctyParameter = tencty != null ?
                new ObjectParameter("tencty", tencty) :
                new ObjectParameter("tencty", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_ncc", maNCCParameter, tenctyParameter, diachiParameter, sdtParameter, deletedParameter);
        }
    
        public virtual int Insert_sp(string masp, string tensp, Nullable<int> dongia, Nullable<int> soluong, string maNCC, string maloai, Nullable<bool> deleted, string anhsp, string mats)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var anhspParameter = anhsp != null ?
                new ObjectParameter("anhsp", anhsp) :
                new ObjectParameter("anhsp", typeof(string));
    
            var matsParameter = mats != null ?
                new ObjectParameter("mats", mats) :
                new ObjectParameter("mats", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_sp", maspParameter, tenspParameter, dongiaParameter, soluongParameter, maNCCParameter, maloaiParameter, deletedParameter, anhspParameter, matsParameter);
        }
    
        public virtual ObjectResult<Search_kh_Result> Search_kh(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_kh_Result>("Search_kh", tukhoaParameter);
        }
    
        public virtual ObjectResult<Search_lsp_Result> Search_lsp(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_lsp_Result>("Search_lsp", tukhoaParameter);
        }
    
        public virtual ObjectResult<Search_ncc_Result> Search_ncc(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_ncc_Result>("Search_ncc", tukhoaParameter);
        }
    
        public virtual ObjectResult<Search_sp_Result> Search_sp(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_sp_Result>("Search_sp", tukhoaParameter);
        }
    
        public virtual ObjectResult<select_donhang_Result> select_donhang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_donhang_Result>("select_donhang");
        }
    
        public virtual ObjectResult<select_hoadon_Result> select_hoadon()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<select_hoadon_Result>("select_hoadon");
        }
    
        public virtual ObjectResult<Select_kh_DE_Result> Select_kh_DE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_kh_DE_Result>("Select_kh_DE");
        }
    
        public virtual ObjectResult<Select_lsp_Result> Select_lsp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_lsp_Result>("Select_lsp");
        }
    
        public virtual ObjectResult<Select_ncc_Result> Select_ncc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_ncc_Result>("Select_ncc");
        }
    
        public virtual ObjectResult<Select_ql_Result> Select_ql()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_ql_Result>("Select_ql");
        }
    
        public virtual ObjectResult<Select_sp_Result> Select_sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_sp_Result>("Select_sp");
        }
    
        public virtual ObjectResult<Select_tskt_Result> Select_tskt()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_tskt_Result>("Select_tskt");
        }
    
        public virtual ObjectResult<Select_with_lsp_Result> Select_with_lsp(string maloai)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_with_lsp_Result>("Select_with_lsp", maloaiParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Update_kh(string makh, string tenkh, string sdt, string diachi, Nullable<bool> deleted, string username, string pass)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_kh", makhParameter, tenkhParameter, sdtParameter, diachiParameter, deletedParameter, usernameParameter, passParameter);
        }
    
        public virtual int update_lsp(string maloai, string tenloai, Nullable<bool> deleted)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_lsp", maloaiParameter, tenloaiParameter, deletedParameter);
        }
    
        public virtual int Update_ncc(string maNCC, string tencty, string diachi, string sdt, Nullable<bool> deleted)
        {
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var tenctyParameter = tencty != null ?
                new ObjectParameter("tencty", tencty) :
                new ObjectParameter("tencty", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_ncc", maNCCParameter, tenctyParameter, diachiParameter, sdtParameter, deletedParameter);
        }
    
        public virtual int Update_sp(string masp, string tensp, Nullable<int> dongia, Nullable<int> soluong, string maNCC, string maloai, Nullable<bool> deleted, string anhsp, string mats)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            var anhspParameter = anhsp != null ?
                new ObjectParameter("anhsp", anhsp) :
                new ObjectParameter("anhsp", typeof(string));
    
            var matsParameter = mats != null ?
                new ObjectParameter("mats", mats) :
                new ObjectParameter("mats", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_sp", maspParameter, tenspParameter, dongiaParameter, soluongParameter, maNCCParameter, maloaiParameter, deletedParameter, anhspParameter, matsParameter);
        }
    }
}