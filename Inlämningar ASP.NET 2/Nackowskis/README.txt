




2. Skapa mapp DATA
4. L�gg till ApplicationDbContext<T> som �rver fr�n IdentityDbContext<T>
3. ApplicationDbContext: L�gg till konstruktor etc

******* VIKTIGT ATT NOTERA: ********
- I den h�r konstruktorn skickar vi inte in connectionstring av DbContext (som vi gjorde f�rut med EF)
- Nu skickar vi ist�llet DbContextOptions
***********************************

4. F�r att kunna be om ENDAST den service WE REQUIRE s� l�gg in i
	- CONFIGURE SERVICE (Startup.cs)

	- options.UseSql: TIll�ter oss att anv�nda the SQL Server
	- Kopplar till connectionString

*****************************************************
CONFIGURING THE IDENTITY SERVICE
*****************************************************

1. Vi vill konfigurera f�r att kunna ha dependency injection

	START UP
			using ASPNetCoreIdentity.Models;
			using Microsoft.AspNetCore.Identity;

2. services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

3. services.AddIdentity<ApplicationUser, IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultTokenProviders();

		   - AddIdentity: Registrerar en service kopplat till dependency injection
					(i den m�ste vi s�ga vilka klassen vi anv�nder f�r IdentityUser och vilken IdentityRole)

		   - EntityFramework: Registrerar services f�r EF

		   - DefaultToken: F�r att kunna reset password, �ndra email


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
	1.2 L�gg till RegistrationViewModel.cs

2. Account Controller
	*************************
	L�GG TILL ACCOUNT CONTROLLER
	*************************

	1. L�gg till usings

			using Microsoft.AspNetCore.Identity;
			using ASPNetCoreIdentity.Models;
			using Microsoft.AspNetCore.Authorization;
			using ASPNetCoreIdentity.Models.AccountViewModels;
			using Microsoft.Extensions.Logging;

	*************************
	DEPENDENCY INJECTION
	*************************

	1. USER MANAGER<T> - Klassen (Har metoder som g�r att vi kan hantera usern)

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
	2. L�gg till kod i de metoderna (bl.a. logga in usern om registrering succeded)

	*************************
	- VIEW IMPORTS - Det vi skriver h�r injectas automatiskt in i alla views

	- REGISTER VIEW: Koda in alla label, input, span

	-Layout Page: Inserta kod i _layout
	*************************

*****************************************************
LOGIN SCREEN
*****************************************************

1. Login View Model
	- L�gg till alla properties: Email, Password, RememberMe

2. Login Actions

3. Login View
	- @inject signInManager



		
	