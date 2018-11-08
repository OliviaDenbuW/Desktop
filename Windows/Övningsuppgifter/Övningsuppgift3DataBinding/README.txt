

1. SKAPA PROPERTIES:
	1.1 Gör privat fält
	1.2 Getter och Setter

2. KLASSER:
	2.1 ViewModel : INotifyPropertyChanged
		- privat fält för koden (det som ska ändras)
		- Sätt startvärderna i konsturktorn

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
	- Ge dataContext sitt värde:
		
		DataContext = new ViewModel()