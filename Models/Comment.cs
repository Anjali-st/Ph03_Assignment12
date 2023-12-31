﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppMVC_Assignment_12.Models
{
    [Table("Comment")]

    public class Comment
    {

        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }

        // Foreign key to relate comments to a post
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}