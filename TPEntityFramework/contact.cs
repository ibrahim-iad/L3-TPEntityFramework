//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class contact
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public Nullable<int> groupe_id { get; set; }
    
        public virtual groupe groupe { get; set; }
    }
}
