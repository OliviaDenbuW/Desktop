
******************************************************************************************
UPPGIFT 1 DATABINDING
******************************************************************************************
1. TEXTBOX + TEXTBLOCK:
	1.1 TEXTBOX (Den man skriver input i)
		- Döp till txtInput

	1.2. TEXTBLOCK (Den som får själva utskriften)
		- Det är textblocket som får själva bindingen (resultatet från textBoxen ska bindas till textBlocket)
		- Lägg in detta på textBlocket:
			
			BINDING:
			Text="{Binding Path=Text,ElementName=textbox}"

2. TEXTBOX + SLIDER:
	Om man drar i slidern ska värdet på slidern åka in i textBoxen

	2.1 TEXTBOX:
		- Ge den en binding till slidern:
			
			BINDING:
			Text="{Binding Path=Value, ElementName=slider}" Kan lägga till Mode=OneWay
******************************************************************************************