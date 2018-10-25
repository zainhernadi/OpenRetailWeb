using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenRetail.Web.Models
{
    public class EmployeeModel
    {
        [Key]
        [StringLength(24)]
        [Display(Name = "Kode Pegawai")]
        public string EmployeeCode { get; set; }
        [StringLength(64)]
        [Required]
        [Display(Name = "Nama Pegawai")]
        public string EmployeeName { get; set; }
        [StringLength(128)]
        [Required]
        [Display(Name = "Alamat")]
        public string Address { get; set; }
        [StringLength(16)]
        [Required]
        [Display(Name = "Telp. Rumah")]
        public string Phone { get; set; }
        [StringLength(16)]
        [Required]
        [Display(Name = "Telp. HP")]
        public string HP { get; set; }
        [StringLength(24)]
        [Required]
        [Display(Name = "Status Pegawai")]
        public string Status { get; set; }
        [StringLength(256)]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [StringLength(128)]
        [Required]
        [Display(Name = "Divisi")]
        public string DivisionName { get; set; }
    }
}
