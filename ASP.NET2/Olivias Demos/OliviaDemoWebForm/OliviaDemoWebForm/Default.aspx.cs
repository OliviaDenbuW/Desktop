using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Page load: Finns lika i winforms, när man laddar formuläret (lägger saker där i som ska laddas direkt)
    //Ex startvärden, dropdowns,
    //Page load körs varjw gång man skickar upp request upp till webservern. Gör inte så att ddl laddas jämt
    //Lösning if sats

    //Page load är ett event, en händelse
    protected void Page_Load(object sender, EventArgs e)
    {
        //Lösnig
        if (!Page.IsPostBack)
        {
            //Här körs kod bara första gången sidan laddas
            lblSida.Text = "Första gången sidan körs";
        }
        else
        {
            lblSida.Text = "Sidan har laddats flera gånger";
        }

    }

    //När vi debuggar och hamnar i det här exventet är vi på servern
    protected void Spara_Click(object sender, EventArgs e)
    {
        //Koppla till requesten och i [] säger jag vad jag vill ha ut
        string namn = Request.Form["txtNamn"];

        string email = Request.Form["txtEmail"];

        //När programmet körs görs allt om till html kod, input och span fält (om man tittar behind på det som genereas
        //upp som vi inte har koll på)

        //Vill lägga in värdena i listbox
        ListItem item = new ListItem(namn + " " + email);

        lstValues.Items.Add(item);
       
    }
}