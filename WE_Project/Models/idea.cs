//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WE_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class idea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public idea()
        {
            this.comment = new HashSet<comment>();
            this.file = new HashSet<file>();
            this.notification = new HashSet<notification>();
            this.reaction = new HashSet<reaction>();
        }
    
        public int idea_id { get; set; }
        public int topic_id { get; set; }
        public Nullable<int> account_id { get; set; }
        public Nullable<int> category_id { get; set; }

        [DisplayName("Content")]
        [Required(ErrorMessage = "Content is required.")]
        [MaxLength(2000, ErrorMessage = "The number of characters has been exceeded, the limit is 100 characters")]
        [DataType(DataType.MultilineText)]
        public string idea_content { get; set; }

        [DisplayName("Thumbs Up")]
        public Nullable<int> thumbs_up { get; set; }

        [DisplayName("Thumbs Down")]
        public Nullable<int> thumbs_down { get; set; }


        public Nullable<int> views { get; set; }
        public Nullable<System.DateTime> idea_date { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "The number of characters has been exceeded, the limit is 100 characters")]
        public string idea_title { get; set; }
        public Nullable<bool> idea_trigger { get; set; }
        public Nullable<System.DateTime> idea_recent { get; set; }
    
        public virtual account account { get; set; }
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<file> file { get; set; }
        public virtual topic topic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<notification> notification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reaction> reaction { get; set; }
    }
}
