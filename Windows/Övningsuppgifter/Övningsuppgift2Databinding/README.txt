
1. SYFTE MED UPPGIFT:
	1.1 Kunna �ndra v�rdet i en text som redan st�r via att �ndra v�rdet i en inputTextRuta
	1.2 Om man trycker p� knappen Change s� �ndras texten som stod till "Kalle"

2. BINDA TEXTBLOCK TILL V�RDEN FR�N KLASSEN PERSON.CS:
	2.1 VIA KONSTRUKTORN:
		- Inga INotify etc beh�vs d�
		- L�gg bara till v�rden till PersonObjektet via konstruktorn och v�rdet kommer kopplas via bindings:
			
			BINDING:
				Text="{Binding Path=Name}" p� TextBlocket f�r att koppla till NamePropertyn i Person.cs

	2.2 VIA CLICK EVENT P� KNAPPEN F� V�RDET P� NAMNET SOM �R SATT VIA KONSTRUKTORN TILL TEXTBLOCKET:
		- Person.cs
			L�GG TILL:
						- Person :  INotifyPropertyChanged
						- PROPERTY:  PropertyChanged;
						- METOD:	 OnPropertyChanged

3. AUTOMATISK UPPDATERING AV V�RDE P� EN PROPERTRTY (Name) TILL TEXTBOX FR�N ETT INPUT F�LT:
	3.1 L�GG TILL P� TEXTBOXEN:
		
			BINDING:
				<TextBox Text="{Binding Path=Name,UpdateSourceTrigger=PropertyChanged}"/>
