

1. SKAPA PROPERTIES:
	1.1 G�r privat f�lt
	1.2 Getter och Setter

2. KLASSER:
	2.1 ViewModel : INotifyPropertyChanged
		- privat f�lt f�r koden (det som ska �ndras)
		- S�tt startv�rderna i konsturktorn

		PROPERTY: PropertyChanged
		METOD: OnPropertyChanged

		- Se initialisering av dataContext i MainWindow

	2.2 RGBCode : INotifyPropertyChanged

		PROP: R
		PROP: G
		PROP: B

		PROPERTY: PropertyChanged
		METOD: OnPropertyChanged

	2.3 RGBToHTMLColorConverter : IValueConverter:
		
		METOD: Convert
		METOD: ConvertBack
	
3. MAIN WINDOW:
	- Ge dataContext sitt v�rde:
		
		DataContext = new ViewModel()