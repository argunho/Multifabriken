# Multifabriken (C#, Console applikation)

Projekten innehåller 5 klasser utöver Program klass, 4 av dessa såsom Cars (Bilar), Candy (Godis), Pipe (Rör) och OatMilk (HavreMjölk) är krav att göra klart uppgiften.
Den femte klassen som var nämnt av mig som HelpMethods, var skapat att undvika onödiga upprepande kod. Denna klassen innehåller två metod vilka används i alla andra 4 klasser.
Metod ReturneAnsewer() skriven för att behandla inmatad text med enkel validering och returnerar texten om texten är fel fri i fall om texten har fel, då kommer fel meddelande med röd färg.
Metod Order() tar in information och visar  kompletta order på konsolen.

I de andra klassen skrivna egna variabler med metod att ställa fram frågor att göra order fullständigt.
I Program klassen skapades objektet till klasser förutom HelpMethods och vid start börjar While loop som avsett att återvända användare till början vid val att återgå till menyn i slutet av programmet.
I While loop körs switch och körs den klassobjekt som bli vald av användare.
I slutet visas meddelande till användare, hur kan man återgå till menyn och alternativ avsluta programmet.
