
******************************************************************************************
UPPGIFT 1 DATABINDING
******************************************************************************************
1. TEXTBOX + TEXTBLOCK:
	1.1 TEXTBOX (Den man skriver input i)
		- D�p till txtInput

	1.2. TEXTBLOCK (Den som f�r sj�lva utskriften)
		- Det �r textblocket som f�r sj�lva bindingen (resultatet fr�n textBoxen ska bindas till textBlocket)
		- L�gg in detta p� textBlocket:
			
			BINDING:
			Text="{Binding Path=Text,ElementName=textbox}"

2. TEXTBOX + SLIDER:
	Om man drar i slidern ska v�rdet p� slidern �ka in i textBoxen

	2.1 TEXTBOX:
		- Ge den en binding till slidern:
			
			BINDING:
			Text="{Binding Path=Value, ElementName=slider}" Kan l�gga till Mode=OneWay
******************************************************************************************