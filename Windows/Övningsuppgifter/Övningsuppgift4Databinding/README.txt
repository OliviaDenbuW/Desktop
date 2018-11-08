

1. KLASSER:
	1.1 ViewModel : INotifyPropertyChanged
		
		PROPERTY: PropertyChanged
		METOD: OnPropertyChanged
		METOD: VmOnPropertyChanged

		L�gg till initialisering av ViewModel

	1.2 AddCommand : ICommand

		METOD: CanExecute
		METOD: Execute

	1.3 RemoveCommand : ICommand

2. LISTBOX TA BORT OCH KOPPLA TILL ALLA ITEMS:
	2.1 ITEMS:
		- Skapa en property som Items som ska h�lla v�rdena fr�n listboxen
		- Initialisera i konstruktorn
		- DataBind till listboxen i windows
			
			DATABIND: 
				ItemsSource="{Binding Path=Items}" (p� listboxen)
					OCH
				SelectedItem="{Binding Path=SelectedItem}"

3. ADD ITEM:
	3.1 TextBox:
			- DataBind:
						Text="{Binding Path=NewItem,UpdateSourceTrigger=PropertyChanged}"
	3.2 Button:
			- DataBind: 
						Command="{Binding Path=Add}

4. REMOVIE ITEM BUTTON:
	4.1 ListBoxen SelectedItem={Binding Path=SelectedItem}
	4.2 Button:
			- DataBind: 
						Command="{Binding Path=Remove}

5. VALD ITEM:
	3.1 _newItem

	3.3 _selectedItem

			G�r:
				- privat f�lt
				- G�r Property med getter/Setter

6. L�gg till initialisering av ViewModel