//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace student_learning_outcomes_management
{
    using System;
    using System.Collections.Generic;
    
    public partial class tGiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tGiaoVien()
        {
            this.tKhoaHocs = new HashSet<tKhoaHoc>();
        }
    
        public string MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public string HocVi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaKhoa { get; set; }
    
        public virtual tKhoa tKhoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tKhoaHoc> tKhoaHocs { get; set; }
    }
}
