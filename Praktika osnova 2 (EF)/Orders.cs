//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika_osnova_2__EF_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Sales = new HashSet<Sales>();
        }
    
        public int order_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> notebook_id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual Customers Customers {private get; set; }
        public virtual Notebooks Notebooks {private get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales {private get; set; }
    }
}