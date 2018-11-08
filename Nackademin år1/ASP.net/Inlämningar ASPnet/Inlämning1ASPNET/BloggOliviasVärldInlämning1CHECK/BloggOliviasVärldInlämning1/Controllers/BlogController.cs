using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggOliviasVärldInlämning1.Models;
using BloggOliviasVärldInlämning1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloggOliviasVärldInlämning1.Controllers
{
    public class BlogController : Controller
    {
        private OliviasBlogContext _context;
        private int selectListItem;

        public BlogController(OliviasBlogContext context)
        {
            _context = context;
        }

        //******************************************************
        //                      Start
        //******************************************************
        public IActionResult OliviasBubble()
        {
            var postsDb = GetAllPostsDb();
            
            return View(postsDb);
        }

        public List<Posts> GetAllPostsDb()
        {
            var postsDb = _context.Posts.ToList();

            return postsDb;
        }

        //******************************************************
        //              Create new post
        //******************************************************
        public IActionResult CreateNewPost()
        {
            var viewModel = new ViewModelPost();

            var categoriesDropdown = new List<SelectListItem>();
            var categoriesDb = GetCategoriesFromDb();

            CreateCategoriesDropDown(categoriesDb, categoriesDropdown);

            viewModel.Categories = categoriesDropdown;

            return View(viewModel);
        }

        public List<Categories> GetCategoriesFromDb()
        {
            var categoriesDb = _context.Categories.ToList();

            return categoriesDb;
        }

        public void CreateCategoriesDropDown(List<Categories> categoriesDb, List<SelectListItem> categoriesDropdown)
        {
            foreach (var category in categoriesDb)
            {
                categoriesDropdown.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNewPost(ViewModelPost newPost)
        {
            if (ModelState.IsValid)
            {
                AddNewPostToDb(newPost);

                return RedirectToAction("OliviasBubble");
            }
            else
            {
                return View("Error");
            }            
        }

        public void AddNewPostToDb(ViewModelPost newPost)
        {
            _context.Posts.Add(newPost.CurrentPost);
            _context.SaveChanges();
        }

        //******************************************************
        //                   Search functions
        //******************************************************
        [HttpPost]
        public IActionResult SearchForHeadLine(string inputSearchedHeadline)
        {
            var matchingPosts = GetSearchedHeadline(inputSearchedHeadline);

            return View(matchingPosts);
        }

        public List<Posts> GetSearchedHeadline(string inputSearchedHeadline)
        {
            var matchingPosts = _context.Posts.Where(post => post.HeadLine.Contains(inputSearchedHeadline)).ToList();

            return matchingPosts;
        }

        [HttpPost]
        public IActionResult SearchForCategory(string inputSearchedCategory)
        {
            var matchingPosts = GetSearchedCategory(inputSearchedCategory);

            return View("SearchForHeadLine", matchingPosts);
        }

        public List<Posts> GetSearchedCategory(string inputSearchedCategory)
        {
            var matchingPosts = _context.Posts.Where(post => post.Category.CategoryName.Contains(inputSearchedCategory)).ToList();

            return matchingPosts;
        }

        //******************************************************
        //                  Read post
        //******************************************************
        public IActionResult ReadSelectedPost(int id)
        {
            var selectedPost = GetSelectedPost(id);

            return View(selectedPost);
        }

        public Posts GetSelectedPost(int postId)
        {
            var selectedPost = _context.Posts.SingleOrDefault(post => post.PostId == postId);

            return selectedPost;
        }
    }
}