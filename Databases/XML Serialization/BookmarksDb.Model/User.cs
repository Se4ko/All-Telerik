//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookmarksDb.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public int BookmarkId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    
        public virtual Bookmark Bookmark { get; set; }
    }
}
