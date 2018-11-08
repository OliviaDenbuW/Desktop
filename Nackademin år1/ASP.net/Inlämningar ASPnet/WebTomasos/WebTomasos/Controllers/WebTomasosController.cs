using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebTomasos.Entities;
using WebTomasos.Models;

namespace WebTomasos.Controllers
{
    public class WebTomasosController : Controller
    {
        private tomasosContext _context;

        public WebTomasosController(tomasosContext context)
        {
            _context = context;
        }

        //*********************************************************
        //                      Login                          
        //*********************************************************
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel customer)
        {
            if (ModelState.IsValid)
            {
                var customerDb = FindCustomerInDb(customer.UserName, customer.Password);
                
                if (customerDb != null)
                {
                    var currentCustomer = TransformToCustomerModel(customerDb);
                    StartSession(currentCustomer);

                    return RedirectToAction("Menu");
                }
                else
                {
                    ViewBag.Message = "Your login failed";

                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public Kund FindCustomerInDb(string userName, string password)
        {
            var customerDb = _context.Kund.SingleOrDefault(
                c => (c.AnvandarNamn == userName &&
                    c.Losenord == password));

            return customerDb;
        }

        public CustomerModel TransformToCustomerModel(Kund customerDb)
        {
            return new CustomerModel
            {
                Id = customerDb.KundId,
                Name = customerDb.Namn,
                StreetAddress = customerDb.Gatuadress,
                PostalNumber = customerDb.Postnr,
                PostalArea = customerDb.Postort,
                Email = customerDb.Email,
                PhoneNumber = customerDb.Telefon,
                UserName = customerDb.AnvandarNamn,
                Password = customerDb.Losenord
            };
        }

        public bool GetIfCustomerIsLoggedIn()
        {
            var sessionVariable = HttpContext.Session.GetString("LoggedIn");

            if (sessionVariable != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StartSession(CustomerModel currentCustomer)
        {
            var tempCustomer = JsonConvert.SerializeObject(currentCustomer);

            HttpContext.Session.SetString("LoggedIn", tempCustomer);
            HttpContext.Session.SetString("UserId", currentCustomer.Id.ToString());
        }

        public string GetInloggedCustomer()
        {
            var customerLoggedIn = HttpContext.Session.GetString("LoggedIn");

            return customerLoggedIn;
        }

        //*********************************************************
        //                      Menu                        
        //*********************************************************
        public IActionResult Menu()
        {
            var customerIsLoggedIn = GetIfCustomerIsLoggedIn();

            if (customerIsLoggedIn == true)
            {
                var allDishesDb = GetAllDishesFromDb();
                var allDishes = TransformToDishModel(allDishesDb);

                return View(allDishes);
            }
            else
            {
                return View("Login");
            }
        }

        public IEnumerable<Matratt> GetAllDishesFromDb()
        {
            var dishesDb = _context.Matratt.ToList();

            return dishesDb;
        }

        public IEnumerable<DishModel> TransformToDishModel(IEnumerable<Matratt> dishesDb)
        {
            var dishes = dishesDb.Select(dish => new DishModel
            {
                Id = dish.MatrattId,
                Name = dish.MatrattNamn,
                Price = dish.Pris,
                Type = dish.MatrattTyp,
                Products = GetAllProductsForSpecificDish(dish.MatrattId), 
            }).ToList();

            return dishes;
        }

        public string GetAllProductsForSpecificDish(int dishId)
        {
            var currentDishDb = GetCurrentDish(dishId);
            var matrattProduktRelations = currentDishDb.MatrattProdukt;
            var productsForCurrentDish = new List<string>();

            AddProductsForCurrentDishToRelationList(matrattProduktRelations, productsForCurrentDish);
            var allProductsAsOneString = GetAllProductsAsOneString(productsForCurrentDish);

            return allProductsAsOneString;
        }

        public Matratt GetCurrentDish(int dishId)
        {
            var currentDish = _context.Matratt.Include(x => x.MatrattProdukt).
                                Where(d => d.MatrattId == dishId).FirstOrDefault();

            return currentDish;
        }

        public void AddProductsForCurrentDishToRelationList(IEnumerable<MatrattProdukt> matrattProduktRelations, List<string> productsForCurrentDish)
        {
            foreach (var relation in matrattProduktRelations)
            {
                var prodId = relation.ProduktId;
                var currentProdukt = _context.Produkt.FirstOrDefault(p => p.ProduktId == prodId);

                productsForCurrentDish.Add(currentProdukt.ProduktNamn);
            }
        }

        public string GetAllProductsAsOneString(List<string> products)
        {
            var productsAsString = products.Aggregate((partialPhrase, product) =>
                                        $"{partialPhrase} {product}");

            return productsAsString;
        }

        //*********************************************************
        //                   Edit and Register                        
        //*********************************************************
        public IActionResult EditContactInformation()
        {
            var customerIsLoggedIn = GetIfCustomerIsLoggedIn();
            var customerLoggedIn = GetInloggedCustomer();

            if (customerIsLoggedIn == true)
            {
                var customerToEdit = JsonConvert.DeserializeObject<CustomerModel>(customerLoggedIn);

                return View(customerToEdit);
            }
            else
            {
                return View("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditContactInformation(CustomerModel customerToEdit)
        {
            if (ModelState.IsValid)
            {
                var customerDb = GetCustomerToEdit(customerToEdit);
                TransformCustomerModelToKundEntity(customerDb, customerToEdit);

                _context.SaveChanges();
            }
            else
            {
                return View();
            }

            return View();
        }

        public Kund GetCustomerToEdit(CustomerModel customerToEdit)
        {
            var customerDb = _context.Kund.SingleOrDefault(customer => customer.KundId == customerToEdit.Id);

            return customerDb;
        }

        public Kund TransformCustomerModelToKundEntity(Kund customerDb, CustomerModel customer)
        {
            customerDb.Namn = customer.Name;
            customerDb.Gatuadress = customer.StreetAddress;
            customerDb.Postnr = customer.PostalNumber;
            customerDb.Postort = customer.PostalArea;
            customerDb.Email = customer.Email;
            customerDb.Telefon = customer.PhoneNumber;
            customerDb.AnvandarNamn = customer.UserName;
            customerDb.Losenord = customer.Password;

            return customerDb;
        }

        public IActionResult RegisterNewCustomer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterNewCustomer(RegistrationModel newCustomer)
        {
            if (ModelState.IsValid)
            {
                var emptyCustomer = new Kund();
                var customerToAdd = TransformRegistrationModelToKundEntity(emptyCustomer, newCustomer);

                _context.Kund.Add(customerToAdd);
                _context.SaveChanges();

                return View("Login");
            }
            else
            {
                return View();
            }
        }

        public Kund TransformRegistrationModelToKundEntity(Kund customerDb, RegistrationModel newCustomer)
        {
            customerDb.Namn = newCustomer.Name;
            customerDb.Gatuadress = newCustomer.StreetAddress;
            customerDb.Postnr = newCustomer.PostalNumber;
            customerDb.Postort = newCustomer.PostalArea;
            customerDb.Email = newCustomer.Email;
            customerDb.Telefon = newCustomer.PhoneNumber;
            customerDb.AnvandarNamn = newCustomer.UserName;
            customerDb.Losenord = newCustomer.Password;

            return customerDb;
        }

        //*********************************************************
        //             Adding dishes to shopping cart                        
        //*********************************************************

        public IActionResult AddDish(int id)
        {
            List<Matratt> chosenDishes;

            var dishToAdd = GetDishFromDb(id);
            var shoppingCartIsEmpty = GetIfShoppingCartIsEmpty();

            if (shoppingCartIsEmpty == true)
            {
                chosenDishes = new List<Matratt>();
            }
            else
            {
                chosenDishes = GetOrdersFromShoppingCart();
            }

            chosenDishes.Add(dishToAdd);
            AddCurrentOrderListToShoppingCart(chosenDishes);

            return RedirectToAction("Menu");

        }

        public Matratt GetDishFromDb(int dishId)
        {
            var dishToAdd = _context.Matratt.SingleOrDefault(dish => dish.MatrattId == dishId);

            return dishToAdd;
        }

        public bool GetIfShoppingCartIsEmpty()
        {
            var sessionVariable = HttpContext.Session.GetString("ShoppingCart");

            if (sessionVariable == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Matratt> GetOrdersFromShoppingCart()
        {
            var serializedValue = (HttpContext.Session.GetString("ShoppingCart"));
            var chosenDishes = JsonConvert.DeserializeObject<List<Matratt>>(serializedValue);

            return chosenDishes;
        }

        public void AddCurrentOrderListToShoppingCart(List<Matratt> chosenDishes)
        {
            var temp = JsonConvert.SerializeObject(chosenDishes);
            HttpContext.Session.SetString("ShoppingCart", temp);
        }

        //*********************************************************
        //                  Complete order                          
        //*********************************************************
        public IActionResult Checkout()
        {
            var dishes = GetOrdersFromShoppingCart();
            var chosenDishes = TransformToDishModel(dishes);

            return View(chosenDishes);
        }

        public IActionResult CompleteOrder()
        {
            var dishesToOrderDb = GetOrdersFromShoppingCart();
            var userId = GetUserId();
            var currentOrder = MapOrderToBestallningEntity(dishesToOrderDb, userId);

            _context.Bestallning.Add(currentOrder);

            var dishesIdnWithoutDuplicates = GetDishesIdnWithoutDuplicates(dishesToOrderDb);
            AddBestallningMatrattRelationToDb(currentOrder, dishesToOrderDb, dishesIdnWithoutDuplicates);

            _context.SaveChanges();

            ClearPreviousOrderList();

            return View();
        }

        public int GetUserId()
        {
            var userId = int.Parse(HttpContext.Session.GetString("UserId"));

            return userId;
        }

        public Bestallning MapOrderToBestallningEntity(List<Matratt> dishesToOrderDb, int userId)
        {
            var order = new Bestallning
            {
                BestallningDatum = DateTime.Now,
                Totalbelopp = dishesToOrderDb.Sum(o => o.Pris),
                Levererad = false,
                KundId = userId
            };

            return order;
        }

        public IEnumerable<int> GetDishesIdnWithoutDuplicates(List<Matratt> dishesToOrderDb)
        {
            var dishesIdnWithoutDuplicates = dishesToOrderDb.Select(dish => dish.MatrattId).Distinct();

            return dishesIdnWithoutDuplicates;
        }

        public void AddBestallningMatrattRelationToDb(Bestallning currentOrder, List<Matratt> dishesToOrderDb, IEnumerable<int> dishesIdnWithoutDuplicates)
        {
            foreach (var dishId in dishesIdnWithoutDuplicates)
            {
                var bestallningMatrattRelation = new BestallningMatratt
                {
                    BestallningId = currentOrder.BestallningId,
                    MatrattId = dishId,
                    Antal = dishesToOrderDb.Count(dish => dish.MatrattId == dishId)
                };

                _context.BestallningMatratt.Add(bestallningMatrattRelation);
            }
        }

        public void ClearPreviousOrderList()
        {
            var clearedOrderList = new List<Matratt>();
            var temp = JsonConvert.SerializeObject(clearedOrderList);

            HttpContext.Session.SetString("ShoppingCart", temp);
        }
    }
}