//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        public int PictureId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string Path { get; set; }
        public Nullable<int> TypeId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
