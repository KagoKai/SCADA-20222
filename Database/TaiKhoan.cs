using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Database
{
    public class TaiKhoan
    {
        private string _tenTaiKhoan;
        public string TenTaiKhoan {
            get => _tenTaiKhoan;
            set => _tenTaiKhoan = value;
        }
        private string _matKhau;
        public string MatKhau 
        {
            get => _matKhau;
            set => _matKhau = value;
        }
        private bool _quyenTruyCap;
        public bool QuyenTruyCap 
        {
            get => _quyenTruyCap;
            set => _quyenTruyCap = value;
        }
        public TaiKhoan(string tenTaiKhoan="", string matKhau="", bool quyenTruyCap=false)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.QuyenTruyCap = quyenTruyCap;
        }
    }
}
