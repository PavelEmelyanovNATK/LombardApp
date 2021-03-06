//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LombardApp.Shared.Domain.Services.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.PaysPlans = new HashSet<PaysPlan>();
            this.SelledProducts = new HashSet<SelledProduct>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int TypeId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public System.DateTime InputDate { get; set; }
        public double Cost { get; set; }
        public double DepositeSum { get; set; }
        public double BuySum { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaysPlan> PaysPlans { get; set; }
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelledProduct> SelledProducts { get; set; }
    }
}
