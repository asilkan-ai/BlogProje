﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentText { get; set; }
    }
}
