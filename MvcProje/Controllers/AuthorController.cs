﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager bm = new BlogManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = bm.GetBlogByID(id);
            return PartialView(authordetail);
        }
        public PartialViewResult AuthorPopularPosts(int id)
        {
            var blogauthorid = bm.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorblogs = bm.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }
    }
}