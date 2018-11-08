using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OliviaDemoRazorPages.Pages
{
    //IndexMOdel är klassen vi binder till sidan (modell är alltså inbakat i det här)
    //Modellen är inte en entitet, utan bara det vi jobbar med, man kan lägga in prop i den
    //SKa kunna binda alla samtidigt[BindProperties]
    
    public class IndexModel : PageModel
    {
        //Två prop vi kan använda i formuläret, måste sätt ut attribut
        //Bindings, ex om man inte vill binda alla prop till formuläret
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        //Prop vi bara använder i koden o som vi inte vill binda till formuläret

        [BindProperty]
        //Blir namn="Message" på views
        public string Message { get; set; }

        //När vi startar sidan vill jag ge detta message
        //Kan ses som en konstruktor
        //Hårt typat vilkenHttps
        public void OnGet()
        {
            Message = "Detta är ett startvärde";
        }

        //Måste ha en metod som tar emot det här
        //Hårt typat vilkenHttps
        public void OnPost()
        {
            //Det vi vill göra är att lägga över värderna i variabler
            string angivetNamn = Name;
            string angivenEmail = Email;
        }

    }
}
