using blog.business.Abstract;
using blog.entity;
using blog.webui.Extensions;
using blog.webui.Identity;
using blog.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
    
    public class AdminController : Controller
    {
        private IBlogService _blogService;
        private ICategoryService _categoryService;
        private ICommentService _commentService;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private SignInManager<User> _signInManager;
        public AdminController(IBlogService blogService,ICategoryService categoryService,ICommentService commentService, UserManager<User> userManager,SignInManager<User> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _commentService = commentService;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            
    }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData.SetMessage("message", new AlertMessage() { AlertType = "danger", Message = "Böyle bir hesap bulunamadı" });
                return RedirectToAction("Login");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect("/Admin/");
            }
            ModelState.AddModelError("", "E-posta veya şifreniz yanlış");
            return View(model);


        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult Index()
        {
            var resultCommentNewCount = _commentService.NotApprovedCommentCount();
            var resultBlogsCount = _blogService.GetCount();
            if (resultCommentNewCount.Success)
            {
                ViewBag.NotApprovedCommentCount = resultCommentNewCount.Data;
            }
            if (resultBlogsCount.Success)
            {
                ViewBag.BlogsCount = resultBlogsCount.Data;
            }
            return View();
           
        }
        [HttpGet]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult Blog(int page = 1)
        {
            const int pageSize = 5;
            var result = _blogService.GetAll(pageSize, page);
            if (result.Success)
            {
                var model = new DataPagingModel<Blog>()
                {
                    Data = result.Data,
                    PageModel = new PageModel()
                    {
                        TotalItems = _blogService.GetCount().Data,
                        ItemsPerPage = pageSize,
                        CurrentPage = page
                    }
                };
                return View(model);
            }
            else
            {
                return View(result.Message);
            }
            
        }
        [AuthorizeRoles(Role.Admin)]
        public IActionResult Roles()
        {
            return View(_roleManager.Roles);
        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult Category(int page = 1)
        {
            const int pageSize = 5;
            var result = _categoryService.GetAll(pageSize,page);
            if (result.Success)
            {
                var model = new DataPagingModel<Category>()
                {
                    Data = result.Data,
                    PageModel = new PageModel()
                    {
                        TotalItems = _categoryService.GetCount().Data,
                        ItemsPerPage = pageSize,
                        CurrentPage = page
                    }
                };
                return View(model);
            }
            return View();
        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult Comment(int page = 1)
        {
            
            const int pageSize = 5;
            var result = _commentService.GetAll(pageSize,page);

            if (result.Success)
            {
                var model = new DataPagingModel<Comment>()
                {
                    Data = result.Data,
                    PageModel = new PageModel()
                    {
                        TotalItems=_commentService.GetCount().Data,
                        ItemsPerPage=pageSize,
                        CurrentPage=page
                    }
                };
                return View(model);
            }
            
            
            return View();
        }
        [AuthorizeRoles(Role.Admin)]
        public IActionResult Employe()
        {
            return View(_userManager.Users);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AuthorizeRoles(Role.Admin)]
        public async Task<IActionResult> ManageEmployeRoles(string userId)
        {
            ViewBag.userId = userId;

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                TempData.SetMessage("message", new AlertMessage()
                {
                    AlertType = "error",
                    Message = "Kullanıcı bulunamadı"
                });
                return View();
            }

            var model = new List<UserRolesViewModel>();

            foreach (var role in _roleManager.Roles.ToList())
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin)]
        public async Task<IActionResult> ManageEmployeRoles(List<UserRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                TempData.SetMessage("message", new AlertMessage()
                {
                    AlertType = "error",
                    Message = "Kullanıcı bulunamadı"
                });
                return View("NotFound");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                TempData.SetMessage("message", new AlertMessage()
                {
                    AlertType = "error",
                    Message = "Kullanıcı bu rolden kaldırılamaz"
                }); 
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user,
                model.Where(x => x.IsSelected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şeçilen rol kullanıcıya eklenemez");
                return View(model);
            }

            return RedirectToAction("EmployeEdit", new { Id = userId });
        }

        //Edit Controller
        [HttpGet]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult BlogEdit(int id)
        {
            var result = _blogService.GetById(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public async Task<IActionResult> BlogEdit(Blog blog,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var result = _blogService.GetById(blog.Id);
                if (result.Success)
                {
                    result.Data.Name = blog.Name;
                    result.Data.ReadTime = blog.ReadTime;
                    result.Data.Content = blog.Content;
                    if (file != null)
                    {
                        var extention = Path.GetExtension(file.FileName);
                        var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                        result.Data.ImageUrl = randomName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blog", randomName);
                        using (var stream = new FileStream(path,FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                        result.Data.ImageUrl = blog.ImageUrl;
                    }
                    var resultUpdate = _blogService.Update(result.Data);
                    if (resultUpdate.Success)
                    {

                        TempData.SetMessage("message", new AlertMessage()
                        {
                            AlertType = "info",
                            Message = resultUpdate.Message
                        });

                        return RedirectToAction("Blog");
                    }


                }

            }
            return View(blog);
            
        }
        [HttpGet]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CategoryEdit(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CategoryEdit(Category category)
        {
            if (ModelState.IsValid)
            {
                var result = _categoryService.GetById(category.Id);
                if (result.Success)
                {
                    result.Data.Name = category.Name;
                    result.Data.Url = category.Url;
                    result.Data.IconClass = category.IconClass;

                    var resultUpdate = _categoryService.Update(result.Data);
                    if (resultUpdate.Success)
                    {
                        TempData.SetMessage("message", new AlertMessage()
                        {
                            AlertType = "info",
                            Message = resultUpdate.Message
                        });
                        return RedirectToAction("Category");
                    }
                    
                }

                
            }
            return View(category);
        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CommentEdit(int Id)
        {
            
            var result = _commentService.GetById(Id);
            if (result.Success)
            {
                result.Data.IsApproved = true;
                var resultUpdate = _commentService.Update(result.Data);
                if (resultUpdate.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = resultUpdate.Message });
                    return RedirectToAction("Comment");
                }

                
            }
            return View();
            
        }
        [AuthorizeRoles(Role.Admin)]
        public async Task<IActionResult> EmployeEdit(string Id)
        {
            var entity = await _userManager.FindByNameAsync(Id);
            if (entity != null)
            {
                var user = new User()
                {
                    UserName = entity.UserName,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    PasswordHash = entity.PasswordHash,
                    Email = entity.Email,
                    PhoneNumber = entity.PhoneNumber,
                };
                return View(user);
            }
            return RedirectToAction("Employe");
            
        }
        [AuthorizeRoles(Role.Admin)]
        [HttpPost]
        public async Task<IActionResult> EmployeEdit(User model)
        {

            if (ModelState.IsValid)
            {
                var entity = await _userManager.FindByNameAsync(model.Id);
                if (entity != null)
                {
                    entity.UserName = model.UserName;
                    entity.FirstName = model.FirstName;
                    entity.LastName= model.LastName;
                    entity.Email= model.Email;
                    entity.PhoneNumber= model.PhoneNumber;
                    var result = await _userManager.UpdateAsync(entity);
                    if (result.Succeeded)
                    {
                        TempData.SetMessage("message", new AlertMessage() { AlertType = "success", Message = "Başarıyla güncellendi" });
                        return RedirectToAction("Employe");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    TempData.SetMessage("message", new AlertMessage() { Message = "Kayıt bulunamadı", AlertType = "error" });
                }
            }
            return View(model);
        }


        //Create Controller
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult BlogCreate(int page = 1)
        {
            const int pageSize = 5;
            var result = _categoryService.GetAll(pageSize,page = 1);
            if (result.Success)
            {
                var blogCategoriesViewModel = new BlogCategoriesViewModel()
                {
                    Blog = null,                    
                    Categories = result.Data
                };
                return View(blogCategoriesViewModel);
            }
            return View();
           
            
                
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public async Task<IActionResult> BlogCreate(Blog blog,int[] categoryId,IFormFile file,string userId)
        {
            Console.WriteLine(userId);
            if (ModelState.IsValid)
            {
                if (blog != null && file != null)
                {
                    blog.UserId = userId;
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    blog.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blog", randomName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var result = _blogService.Create(blog, categoryId);
                    if (result.Success)
                    {
                        
                        TempData.SetMessage("message", new AlertMessage() { AlertType = "success", Message = result.Message });
                        return RedirectToAction("Blog");
                    }

                }
            }
            var blogCategoriesViewModel = new BlogCategoriesViewModel() { Blog = blog };
            return View(blogCategoriesViewModel);


        }
        [HttpGet]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CategoryCreate(Category category)
        {
            if (ModelState.IsValid)
            {

                var result = _categoryService.Create(category);
                if (result.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "success", Message = result.Message });
                    return RedirectToAction("Category");
                }
                
            }
            return View(category);
        }
        [AuthorizeRoles(Role.Admin)]
        public IActionResult EmployeCreate()
        {
            var roles = new RegisterModel()
            {
                Roles = _roleManager.Roles
            };
            return View(roles);
        }
        [AuthorizeRoles(Role.Admin)]
        [HttpPost]
        public async Task<IActionResult> EmployeCreate(RegisterModel model,string[] roles)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                TempData.SetMessage("message", new AlertMessage() { Message = "Başarıyla eklendi", AlertType = "success" });
                return RedirectToAction("Employe", "Admin");
            }
            ModelState.AddModelError("", "Bilinmiyen bir hata oluştu");
            return View(model);
        }
        [AuthorizeRoles(Role.Admin)]
        public IActionResult RoleCreate()
        {

            return View();
        }
        [HttpPost]
        [AuthorizeRoles(Role.Admin)]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("Roles", "Admin");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }


        //Delete Controller
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult BlogDelete(int blogId)
        {            
            var result = _blogService.GetById(blogId);
            if (result.Success)
            {
                var resultDelete = _blogService.DeleteWithCategories(result.Data);
                if (resultDelete.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { Message = resultDelete.Message, AlertType = "info" });                    
                    return RedirectToAction("Blog");
                }
            }
            TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = result.Message });
            

            return View();
        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CategoryDelete(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            if (result.Success)
            {
                var resultDelete = _categoryService.Delete(result.Data);
                if (resultDelete.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = resultDelete.Message });
                    return RedirectToAction("Category");
                }

            }
            TempData.SetMessage("message", new AlertMessage() { AlertType = "error", Message = result.Message });
            return View();
        }
        [AuthorizeRoles(Role.Admin, Role.Bloger)]
        public IActionResult CommentDelete(int commentId)
        {
            
            var result = _commentService.GetById(commentId);
            if (result.Success)
            {
                var resultDelete = _commentService.Delete(result.Data);
                if (resultDelete.Success)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = resultDelete.Message });
                    return RedirectToAction("Comment");
                }
            }
            return View();
        }
        [AuthorizeRoles(Role.Admin)]
        public async Task<IActionResult> RoleDelete(string rolId)
        {
            if (string.IsNullOrEmpty(rolId))
            {
                TempData.SetMessage("message", new AlertMessage() { AlertType = "error", Message = "Geçerli Id bulunamadı" });
                return RedirectToAction("Roles");
            }

            var entity = await _roleManager.FindByIdAsync(rolId);
            if (entity != null)
            {
                IdentityResult result = await _roleManager.DeleteAsync(entity);
                if (result.Succeeded)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = "Başarıyla silindi" });
                    RedirectToAction("Roles");
                }
                foreach (var error in result.Errors)
                {
                    TempData.SetMessage("message", new AlertMessage() { AlertType = "info", Message = error.Description });
                    return RedirectToAction("Roles");
                }
            }
            return RedirectToAction("Roles");


        }
        
        public async Task<IActionResult> EmployeDelete(string employeId)
        {
            var entity = await _userManager.FindByNameAsync(employeId);
            if (entity != null)
            {
                var result = await _userManager.DeleteAsync(entity);
                if (result.Succeeded)
                {
                    TempData.SetMessage("message", new AlertMessage() { Message = "Başarıyla silindi", AlertType = "info" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        TempData.SetMessage("message", new AlertMessage() { Message = error.Description, AlertType = "info" });
                        return RedirectToAction("Employe");
                    }
                }
            }
            else
            {
                
                TempData.SetMessage("message", new AlertMessage() { Message = "Kayıt bulunamadı", AlertType = "error" });
                return RedirectToAction("Employe");
            }
            return RedirectToAction("Employe");

        }
        
        
    }
}
