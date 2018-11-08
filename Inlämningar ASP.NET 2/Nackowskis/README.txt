




2. Skapa mapp DATA
4. Lägg till ApplicationDbContext<T> som ärver från IdentityDbContext<T>
3. ApplicationDbContext: Lägg till konstruktor etc

******* VIKTIGT ATT NOTERA: ********
- I den här konstruktorn skickar vi inte in connectionstring av DbContext (som vi gjorde förut med EF)
- Nu skickar vi istället DbContextOptions
***********************************

4. För att kunna be om ENDAST den service WE REQUIRE så lägg in i
	- CONFIGURE SERVICE (Startup.cs)

	- options.UseSql: TIllåter oss att använda the SQL Server
	- Kopplar till connectionString

*****************************************************
CONFIGURING THE IDENTITY SERVICE
*****************************************************

1. Vi vill konfigurera för att kunna ha dependency injection

	START UP
			using ASPNetCoreIdentity.Models;
			using Microsoft.AspNetCore.Identity;

2. services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

3. services.AddIdentity<ApplicationUser, IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultTokenProviders();

		   - AddIdentity: Registrerar en service kopplat till dependency injection
					(i den måste vi säga vilka klassen vi använder för IdentityUser och vilken IdentityRole)

		   - EntityFramework: Registrerar services för EF

		   - DefaultToken: För att kunna reset password, ändra email


*****************************************************
ADDING IDENTITY IN THE PIPELINE
*****************************************************

1. STARTUP: Configure()

			- app.UseAuthentication();


*****************************************************
GENERATE THE DATABASE
*****************************************************

*****************************************************
USER REGISTRATION
*****************************************************
1. RegisterViewModels
	1.1 I Models mapp skapa mapp AccountViewModels
	1.2 Lägg till RegistrationViewModel.cs

2. Account Controller
	*************************
	LÄGG TILL ACCOUNT CONTROLLER
	*************************

	1. Lägg till usings

			using Microsoft.AspNetCore.Identity;
			using ASPNetCoreIdentity.Models;
			using Microsoft.AspNetCore.Authorization;
			using ASPNetCoreIdentity.Models.AccountViewModels;
			using Microsoft.Extensions.Logging;

	*************************
	DEPENDENCY INJECTION
	*************************

	1. USER MANAGER<T> - Klassen (Har metoder som gör att vi kan hantera usern)

	2.  SIGN IN MANAGER<T> - Klassen (Har metoder som hanterar login & logout)

		private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
 
    3.  public AccountController(
                    UserManager<ApplicationUser> userManager,
                    SignInManager<ApplicationUser> signInManager,   
                    ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

	*************************
	HELPER METHODS
	*************************

	1. Helper methods i AccountController.cs

	*************************
	REGISTER ACTION METHODS
	*************************

	1. Register GET & POST
	2. Lägg till kod i de metoderna (bl.a. logga in usern om registrering succeded)

	*************************
	- VIEW IMPORTS - Det vi skriver här injectas automatiskt in i alla views

	- REGISTER VIEW: Koda in alla label, input, span

	-Layout Page: Inserta kod i _layout
	*************************

*****************************************************
LOGIN SCREEN
*****************************************************

1. Login View Model
	- Lägg till alla properties: Email, Password, RememberMe

2. Login Actions

3. Login View
	- @inject signInManager



		
	