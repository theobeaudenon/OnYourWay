//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckoutSet
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int EmployeesId { get; set; }
    
        public virtual EmployeesSet EmployeesSet { get; set; }
                public override string ToString()
        {
            return   "Caise " + Id + "{"+X+"/"+Y+"}"  ;
        }
    }
}
