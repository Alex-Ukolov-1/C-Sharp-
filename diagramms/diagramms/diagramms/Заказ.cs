//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diagramms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказ
    {
        public int Код_клиента { get; set; }
        public int Код_заказа { get; set; }
        public Nullable<System.DateTime> Дата_оформления { get; set; }
    
        public virtual Билет Билет { get; set; }
        public virtual Клиент Клиент { get; set; }
    }
}
