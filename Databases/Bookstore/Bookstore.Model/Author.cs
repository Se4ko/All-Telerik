//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookstore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int AuthorId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
