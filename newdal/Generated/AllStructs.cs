using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
	#region Tables Struct
	public partial struct Tables
	{
		
		public static readonly string DmucCanhbao = @"dmuc_canhbao";
        
		public static readonly string DmucChidanKedonthuoc = @"dmuc_chidan_kedonthuoc";
        
		public static readonly string DmucChung = @"dmuc_chung";
        
		public static readonly string DmucDoituongkcb = @"dmuc_doituongkcb";
        
		public static readonly string DmucKhoaphong = @"dmuc_khoaphong";
        
		public static readonly string DmucKieudmuc = @"dmuc_kieudmuc";
        
		public static readonly string DmucLoaithuoc = @"dmuc_loaithuoc";
        
		public static readonly string DmucNhanvien = @"dmuc_nhanvien";
        
		public static readonly string DmucPhikemtheo = @"dmuc_phikemtheo";
        
		public static readonly string DmucThuoc = @"dmuc_thuoc";
        
		public static readonly string KcbLoghuy = @"kcb_loghuy";
        
		public static readonly string QheBacsiKhoaphong = @"qhe_bacsi_khoaphong";
        
		public static readonly string QheCamchidinhChungphieu = @"qhe_camchidinh_chungphieu";
        
		public static readonly string QheDoituongKho = @"qhe_doituong_kho";
        
		public static readonly string QheDoituongThuoc = @"qhe_doituong_thuoc";
        
		public static readonly string QheNhanvienDanhmuc = @"qhe_nhanvien_danhmuc";
        
		public static readonly string QheNhanvienKho = @"qhe_nhanvien_kho";
        
		public static readonly string QheNhanvienQuyensudung = @"qhe_nhanvien_quyensudung";
        
		public static readonly string QheNhomnhanvienQuyensudung = @"qhe_nhomnhanvien_quyensudung";
        
		public static readonly string QheThuoctuongduong = @"qhe_thuoctuongduong";
        
		public static readonly string SysAdministrator = @"Sys_Administrator";
        
		public static readonly string SysDelegateUser = @"Sys_DelegateUser";
        
		public static readonly string SysFunction = @"Sys_Functions";
        
		public static readonly string SysGridViewOption = @"Sys_GridViewOptions";
        
		public static readonly string SysGroupRole = @"Sys_GroupRoles";
        
		public static readonly string SysGroup = @"Sys_Groups";
        
		public static readonly string SysGroupUser = @"Sys_GroupUser";
        
		public static readonly string SysImgAndIcon = @"Sys_ImgAndIcon";
        
		public static readonly string SysLockObject = @"Sys_LockObject";
        
		public static readonly string SysManagementUnit = @"Sys_ManagementUnit";
        
		public static readonly string SysMessage = @"Sys_Messages";
        
		public static readonly string SysMultiLanguage = @"Sys_MultiLanguage";
        
		public static readonly string SysReport = @"Sys_Reports";
        
		public static readonly string SysRole = @"Sys_Roles";
        
		public static readonly string SysRolesForUser = @"Sys_RolesForUsers";
        
		public static readonly string SysScreen = @"Sys_Screen";
        
		public static readonly string SysSecurity = @"Sys_Security";
        
		public static readonly string SysSystemParameter = @"Sys_SystemParameters";
        
		public static readonly string SysTieude = @"sys_Tieude";
        
		public static readonly string SysToolbarButton = @"Sys_ToolbarButton";
        
		public static readonly string SysTrace = @"Sys_Trace";
        
		public static readonly string SysTrinhky = @"Sys_Trinhky";
        
		public static readonly string SysUser = @"Sys_Users";
        
		public static readonly string SysVersion = @"Sys_Version";
        
		public static readonly string SysConfigRadio = @"SysConfigRadio";
        
		public static readonly string SysUserPrinter = @"SysUserPrinter";
        
		public static readonly string TBiendongThuoc = @"t_biendong_thuoc";
        
		public static readonly string TDmucKho = @"t_dmuc_kho";
        
		public static readonly string TDutruThuoc = @"t_dutru_thuoc";
        
		public static readonly string TLichsuChotthuoc = @"t_lichsu_chotthuoc";
        
		public static readonly string TLichsuHieuchinhDonthuoc = @"t_lichsu_hieuchinh_donthuoc";
        
		public static readonly string TLichsuHieuchinhDonthuocChitiet = @"t_lichsu_hieuchinh_donthuoc_chitiet";
        
		public static readonly string TNhapxuatTempt = @"t_nhapxuat_tempt";
        
		public static readonly string TNhapxuattonTemp = @"t_nhapxuatton_temp";
        
		public static readonly string TNhapxuattonThethuocTemp = @"t_nhapxuatton_thethuoc_temp";
        
		public static readonly string TPhieuCapphatChitiet = @"t_phieu_capphat_chitiet";
        
		public static readonly string TPhieuCapphatNoitru = @"t_phieu_capphat_noitru";
        
		public static readonly string TPhieuNhapxuatthuoc = @"t_phieu_nhapxuatthuoc";
        
		public static readonly string TPhieuNhapxuatthuocChitiet = @"t_phieu_nhapxuatthuoc_chitiet";
        
		public static readonly string TPhieuXuatthuocBenhnhan = @"t_phieu_xuatthuoc_benhnhan";
        
		public static readonly string TPhieuXuatthuocBenhnhanChitiet = @"t_phieu_xuatthuoc_benhnhan_chitiet";
        
		public static readonly string TPhieutrathuocKholeVekhochan = @"t_phieutrathuoc_khole_vekhochan";
        
		public static readonly string TPhieutrathuocKholeVekhochanChitiet = @"t_phieutrathuoc_khole_vekhochan_chitiet";
        
		public static readonly string TPhieutrathuocthua = @"t_phieutrathuocthua";
        
		public static readonly string TThethuoc = @"t_thethuoc";
        
		public static readonly string TThuocCapphatChitiet = @"t_thuoc_capphat_chitiet";
        
		public static readonly string TThuocThua = @"t_thuoc_thua";
        
		public static readonly string TThuockho = @"t_thuockho";
        
		public static readonly string TTondauTemp = @"t_tondau_temp";
        
		public static readonly string TTondauVacxinTemp = @"t_tondau_vacxin_temp";
        
		public static readonly string TXuatthuocTheodon = @"t_xuatthuoc_theodon";
        
		public static readonly string TblKedonthuocTempt = @"tbl_kedonthuoc_tempt";
        
		public static readonly string TblTest = @"tbl_test";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table DmucCanhbao
		{
            get { return DataService.GetSchema("dmuc_canhbao", "ORM"); }
		}
        
		public static TableSchema.Table DmucChidanKedonthuoc
		{
            get { return DataService.GetSchema("dmuc_chidan_kedonthuoc", "ORM"); }
		}
        
		public static TableSchema.Table DmucChung
		{
            get { return DataService.GetSchema("dmuc_chung", "ORM"); }
		}
        
		public static TableSchema.Table DmucDoituongkcb
		{
            get { return DataService.GetSchema("dmuc_doituongkcb", "ORM"); }
		}
        
		public static TableSchema.Table DmucKhoaphong
		{
            get { return DataService.GetSchema("dmuc_khoaphong", "ORM"); }
		}
        
		public static TableSchema.Table DmucKieudmuc
		{
            get { return DataService.GetSchema("dmuc_kieudmuc", "ORM"); }
		}
        
		public static TableSchema.Table DmucLoaithuoc
		{
            get { return DataService.GetSchema("dmuc_loaithuoc", "ORM"); }
		}
        
		public static TableSchema.Table DmucNhanvien
		{
            get { return DataService.GetSchema("dmuc_nhanvien", "ORM"); }
		}
        
		public static TableSchema.Table DmucPhikemtheo
		{
            get { return DataService.GetSchema("dmuc_phikemtheo", "ORM"); }
		}
        
		public static TableSchema.Table DmucThuoc
		{
            get { return DataService.GetSchema("dmuc_thuoc", "ORM"); }
		}
        
		public static TableSchema.Table KcbLoghuy
		{
            get { return DataService.GetSchema("kcb_loghuy", "ORM"); }
		}
        
		public static TableSchema.Table QheBacsiKhoaphong
		{
            get { return DataService.GetSchema("qhe_bacsi_khoaphong", "ORM"); }
		}
        
		public static TableSchema.Table QheCamchidinhChungphieu
		{
            get { return DataService.GetSchema("qhe_camchidinh_chungphieu", "ORM"); }
		}
        
		public static TableSchema.Table QheDoituongKho
		{
            get { return DataService.GetSchema("qhe_doituong_kho", "ORM"); }
		}
        
		public static TableSchema.Table QheDoituongThuoc
		{
            get { return DataService.GetSchema("qhe_doituong_thuoc", "ORM"); }
		}
        
		public static TableSchema.Table QheNhanvienDanhmuc
		{
            get { return DataService.GetSchema("qhe_nhanvien_danhmuc", "ORM"); }
		}
        
		public static TableSchema.Table QheNhanvienKho
		{
            get { return DataService.GetSchema("qhe_nhanvien_kho", "ORM"); }
		}
        
		public static TableSchema.Table QheNhanvienQuyensudung
		{
            get { return DataService.GetSchema("qhe_nhanvien_quyensudung", "ORM"); }
		}
        
		public static TableSchema.Table QheNhomnhanvienQuyensudung
		{
            get { return DataService.GetSchema("qhe_nhomnhanvien_quyensudung", "ORM"); }
		}
        
		public static TableSchema.Table QheThuoctuongduong
		{
            get { return DataService.GetSchema("qhe_thuoctuongduong", "ORM"); }
		}
        
		public static TableSchema.Table SysAdministrator
		{
            get { return DataService.GetSchema("Sys_Administrator", "ORM"); }
		}
        
		public static TableSchema.Table SysDelegateUser
		{
            get { return DataService.GetSchema("Sys_DelegateUser", "ORM"); }
		}
        
		public static TableSchema.Table SysFunction
		{
            get { return DataService.GetSchema("Sys_Functions", "ORM"); }
		}
        
		public static TableSchema.Table SysGridViewOption
		{
            get { return DataService.GetSchema("Sys_GridViewOptions", "ORM"); }
		}
        
		public static TableSchema.Table SysGroupRole
		{
            get { return DataService.GetSchema("Sys_GroupRoles", "ORM"); }
		}
        
		public static TableSchema.Table SysGroup
		{
            get { return DataService.GetSchema("Sys_Groups", "ORM"); }
		}
        
		public static TableSchema.Table SysGroupUser
		{
            get { return DataService.GetSchema("Sys_GroupUser", "ORM"); }
		}
        
		public static TableSchema.Table SysImgAndIcon
		{
            get { return DataService.GetSchema("Sys_ImgAndIcon", "ORM"); }
		}
        
		public static TableSchema.Table SysLockObject
		{
            get { return DataService.GetSchema("Sys_LockObject", "ORM"); }
		}
        
		public static TableSchema.Table SysManagementUnit
		{
            get { return DataService.GetSchema("Sys_ManagementUnit", "ORM"); }
		}
        
		public static TableSchema.Table SysMessage
		{
            get { return DataService.GetSchema("Sys_Messages", "ORM"); }
		}
        
		public static TableSchema.Table SysMultiLanguage
		{
            get { return DataService.GetSchema("Sys_MultiLanguage", "ORM"); }
		}
        
		public static TableSchema.Table SysReport
		{
            get { return DataService.GetSchema("Sys_Reports", "ORM"); }
		}
        
		public static TableSchema.Table SysRole
		{
            get { return DataService.GetSchema("Sys_Roles", "ORM"); }
		}
        
		public static TableSchema.Table SysRolesForUser
		{
            get { return DataService.GetSchema("Sys_RolesForUsers", "ORM"); }
		}
        
		public static TableSchema.Table SysScreen
		{
            get { return DataService.GetSchema("Sys_Screen", "ORM"); }
		}
        
		public static TableSchema.Table SysSecurity
		{
            get { return DataService.GetSchema("Sys_Security", "ORM"); }
		}
        
		public static TableSchema.Table SysSystemParameter
		{
            get { return DataService.GetSchema("Sys_SystemParameters", "ORM"); }
		}
        
		public static TableSchema.Table SysTieude
		{
            get { return DataService.GetSchema("sys_Tieude", "ORM"); }
		}
        
		public static TableSchema.Table SysToolbarButton
		{
            get { return DataService.GetSchema("Sys_ToolbarButton", "ORM"); }
		}
        
		public static TableSchema.Table SysTrace
		{
            get { return DataService.GetSchema("Sys_Trace", "ORM"); }
		}
        
		public static TableSchema.Table SysTrinhky
		{
            get { return DataService.GetSchema("Sys_Trinhky", "ORM"); }
		}
        
		public static TableSchema.Table SysUser
		{
            get { return DataService.GetSchema("Sys_Users", "ORM"); }
		}
        
		public static TableSchema.Table SysVersion
		{
            get { return DataService.GetSchema("Sys_Version", "ORM"); }
		}
        
		public static TableSchema.Table SysConfigRadio
		{
            get { return DataService.GetSchema("SysConfigRadio", "ORM"); }
		}
        
		public static TableSchema.Table SysUserPrinter
		{
            get { return DataService.GetSchema("SysUserPrinter", "ORM"); }
		}
        
		public static TableSchema.Table TBiendongThuoc
		{
            get { return DataService.GetSchema("t_biendong_thuoc", "ORM"); }
		}
        
		public static TableSchema.Table TDmucKho
		{
            get { return DataService.GetSchema("t_dmuc_kho", "ORM"); }
		}
        
		public static TableSchema.Table TDutruThuoc
		{
            get { return DataService.GetSchema("t_dutru_thuoc", "ORM"); }
		}
        
		public static TableSchema.Table TLichsuChotthuoc
		{
            get { return DataService.GetSchema("t_lichsu_chotthuoc", "ORM"); }
		}
        
		public static TableSchema.Table TLichsuHieuchinhDonthuoc
		{
            get { return DataService.GetSchema("t_lichsu_hieuchinh_donthuoc", "ORM"); }
		}
        
		public static TableSchema.Table TLichsuHieuchinhDonthuocChitiet
		{
            get { return DataService.GetSchema("t_lichsu_hieuchinh_donthuoc_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TNhapxuatTempt
		{
            get { return DataService.GetSchema("t_nhapxuat_tempt", "ORM"); }
		}
        
		public static TableSchema.Table TNhapxuattonTemp
		{
            get { return DataService.GetSchema("t_nhapxuatton_temp", "ORM"); }
		}
        
		public static TableSchema.Table TNhapxuattonThethuocTemp
		{
            get { return DataService.GetSchema("t_nhapxuatton_thethuoc_temp", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuCapphatChitiet
		{
            get { return DataService.GetSchema("t_phieu_capphat_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuCapphatNoitru
		{
            get { return DataService.GetSchema("t_phieu_capphat_noitru", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuNhapxuatthuoc
		{
            get { return DataService.GetSchema("t_phieu_nhapxuatthuoc", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuNhapxuatthuocChitiet
		{
            get { return DataService.GetSchema("t_phieu_nhapxuatthuoc_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuXuatthuocBenhnhan
		{
            get { return DataService.GetSchema("t_phieu_xuatthuoc_benhnhan", "ORM"); }
		}
        
		public static TableSchema.Table TPhieuXuatthuocBenhnhanChitiet
		{
            get { return DataService.GetSchema("t_phieu_xuatthuoc_benhnhan_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TPhieutrathuocKholeVekhochan
		{
            get { return DataService.GetSchema("t_phieutrathuoc_khole_vekhochan", "ORM"); }
		}
        
		public static TableSchema.Table TPhieutrathuocKholeVekhochanChitiet
		{
            get { return DataService.GetSchema("t_phieutrathuoc_khole_vekhochan_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TPhieutrathuocthua
		{
            get { return DataService.GetSchema("t_phieutrathuocthua", "ORM"); }
		}
        
		public static TableSchema.Table TThethuoc
		{
            get { return DataService.GetSchema("t_thethuoc", "ORM"); }
		}
        
		public static TableSchema.Table TThuocCapphatChitiet
		{
            get { return DataService.GetSchema("t_thuoc_capphat_chitiet", "ORM"); }
		}
        
		public static TableSchema.Table TThuocThua
		{
            get { return DataService.GetSchema("t_thuoc_thua", "ORM"); }
		}
        
		public static TableSchema.Table TThuockho
		{
            get { return DataService.GetSchema("t_thuockho", "ORM"); }
		}
        
		public static TableSchema.Table TTondauTemp
		{
            get { return DataService.GetSchema("t_tondau_temp", "ORM"); }
		}
        
		public static TableSchema.Table TTondauVacxinTemp
		{
            get { return DataService.GetSchema("t_tondau_vacxin_temp", "ORM"); }
		}
        
		public static TableSchema.Table TXuatthuocTheodon
		{
            get { return DataService.GetSchema("t_xuatthuoc_theodon", "ORM"); }
		}
        
		public static TableSchema.Table TblKedonthuocTempt
		{
            get { return DataService.GetSchema("tbl_kedonthuoc_tempt", "ORM"); }
		}
        
		public static TableSchema.Table TblTest
		{
            get { return DataService.GetSchema("tbl_test", "ORM"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static readonly string VDmucKhoaphong = @"v_dmuc_khoaphong";
        
		public static readonly string VDmucNhanvien = @"v_dmuc_nhanvien";
        
		public static readonly string VDmucThuoc = @"v_dmuc_thuoc";
        
		public static readonly string VQheDoituongThuoc = @"v_qhe_doituong_thuoc";
        
		public static readonly string VThuocPhieunhapxuat = @"v_thuoc_phieunhapxuat";
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["ORM"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository 
        {
            get 
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static readonly string ORM = @"ORM";
    
}
#endregion