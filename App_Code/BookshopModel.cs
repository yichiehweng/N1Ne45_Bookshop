﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public int CategoryID { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public byte[] Image { get; set; }

    public virtual Category Category { get; set; }
}

public partial class Category
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Category()
    {
        this.Books = new HashSet<Book>();
    }

    public int CategoryID { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Book> Books { get; set; }
}
