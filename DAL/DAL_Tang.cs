using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Tang
    {
        public List<DTO_Tang> Xem()
        {
            var xem = from t in ConectionData.dt.TANGs
                      select t;
            List<DTO_Tang> tang = new List<DTO_Tang>();
            foreach (var item in xem)
            {
                DTO_Tang dtoTang = new DTO_Tang();
                dtoTang.Id = item.MATANG;
                dtoTang.Lau = item.TANG1;
                tang.Add(dtoTang);
            }
            return tang;
        }
        public DataTable XemPhong()
        {
            // Thực thi truy vấn LINQ để lấy dữ liệu
            var xem = ConectionData.dt.TANGs.Select(d => d).ToList();

            // Tạo DataTable với cấu trúc phù hợp
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MATANG", typeof(int)); // Giả sử MATANG là kiểu int
            dataTable.Columns.Add("TANG1", typeof(string));  // Giả sử TANG1 là kiểu string
                                                          // Thêm các cột khác nếu cần

            // Duyệt qua kết quả truy vấn và thêm dữ liệu vào DataTable
            foreach (var item in xem)
            {
                DataRow row = dataTable.NewRow();
                row["MATANG"] = item.MATANG;
                row["TANG1"] = item.TANG1;
                // Gán các giá trị khác nếu cần
                dataTable.Rows.Add(row);
            }

            // Bây giờ `dataTable` đã chứa dữ liệu từ bảng TANGs
            return dataTable;
        }
        public List<DTO_Phong> CheckTang(int maTang, int maLP)
        {
            var xem = from t in ConectionData.dt.PHONGs
                      where t.MATANG == maTang && (maLP == 1 || t.MALOAIP == maLP)
                      select t;

            List<DTO_Phong> phong = new List<DTO_Phong>();

            foreach (var item in xem)
            {
                DTO_Phong p = new DTO_Phong
                {
                    MaKS = item.MAKS,
                    MaPhong = item.MAPHONG,
                    MaTang = item.MATANG,
                    TenPhong = item.TENPHONG,
                    MaLoaiP = item.MALOAIP,
                    MaHT = item.MAHT,
                    SucChua = item.SUCCHUA
                };
                phong.Add(p);
            }
            return phong;
        }


        public string LayTenTang(int maTang)
        {
            var tangList = ConectionData.dt.TANGs
                .Where(d => d.MATANG == maTang)
                .Select(d => d)
                .ToList();

            // Kiểm tra xem danh sách có phần tử không
            if (tangList.Any())
            {
                // Lấy giá trị LAU từ phần tử đầu tiên trong danh sách (giả sử chỉ có một phần tử)
                string tenTang = tangList[0].TANG1;
                return tenTang;
            }
            else
            {
                // Trả về null nếu không có phần tử nào trong danh sách
                return null;
            }
        }
        public int Them(DTO_Tang tang)
        {
            try
            {
                TANG t = new TANG
                {
                    TANG1 = tang.Lau,
                };
                ConectionData.dt.TANGs.InsertOnSubmit(t);
                return t.MATANG;

            }
            finally
            {
                ConectionData.dt.SubmitChanges();
                
            }
        }
        public int Sua(DTO_Tang tang)
        {
            var sua = ConectionData.dt.TANGs.Single(t => t.MATANG == tang.Id);
            sua.TANG1 = tang.Lau;
            ConectionData.dt.SubmitChanges();
            return 1;
        }
        public int Xoa(int maTang)
        {
            var xoa = ConectionData.dt.TANGs
                .Where(t => t.MATANG == maTang)
                .Select(t => t);
            foreach (var t in xoa)
            {
                ConectionData.dt.TANGs.DeleteOnSubmit(t);
            }
            ConectionData.dt.SubmitChanges();
            return 1;
        }
        public DTO_Tang Lay1Tang(int maTang)
        {
            var lay = ConectionData.dt.TANGs
                .Where(t => t.MATANG == maTang)
                .Select(t => new DTO_Tang
                {
                    Id = t.MATANG,
                    Lau = t.TANG1
                }).FirstOrDefault();
            return lay;
        }
    }
}
