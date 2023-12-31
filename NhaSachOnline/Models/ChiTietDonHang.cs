﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace NhaSachOnline.Models
{
  [Table("ChiTietDonHang")]
  public class ChiTietDonHang
  {
    [Key]
    public int MaChiTietDonHang { get; set; }
    [Required]
    public int MaDonHang { get; set; }
    [Required]
    public int MaSach { get; set; }
    [Required]
    public int SoLuong { get; set; }
    [Required]
    public double DonGia { get; set; }
    public Sach Sach { get; set; }
    public DonHang DonHang { get; set; }
  }
}
