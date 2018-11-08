
1. SYFTE MED UPPGIFT:
	1.1 Kunna ändra värdet i en text som redan står via att ändra värdet i en inputTextRuta
	1.2 Om man trycker på knappen Change så ändras texten som stod till "Kalle"

2. BINDA TEXTBLOCK TILL VÄRDEN FRÅN KLASSEN PERSON.CS:
	2.1 VIA KONSTRUKTORN:
		- Inga INotify etc behövs då
		- Lägg bara till värden till PersonObjektet via konstruktorn och värdet kommer kopplas via bindings:
			
			BINDING:
				Text="{Binding Path=Name}" på TextBlocket för att koppla till NamePropertyn i Person.cs

	2.2 VIA CLICK EVENT PÅ KNAPPEN FÅ VÄRDET PÅ NAMNET SOM ÄR SATT VIA KONSTRUKTORN TILL TEXTBLOCKET:
		- Person.cs
			LÄGG TILL:
						- Person :  INotifyPropertyChanged
						- PROPERTY:  PropertyChanged;
						- METOD:	 OnPropertyChanged

3. AUTOMATISK UPPDATERING AV VÄRDE PÅ EN PROPERTRTY (Name) TILL TEXTBOX FRÅN ETT INPUT FÄLT:
	3.1 LÄGG TILL PÅ TEXTBOXEN:
		
			BINDING:
				<TextBox Text="{Binding Path=Name,UpdateSourceTrigger=PropertyChanged}"/>
