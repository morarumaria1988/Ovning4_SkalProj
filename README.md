F: 1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion  
S: Stacken är som en stapel med böcker, man får ta först boken som är överst och uprepa det tills man når den bok man letar efter. Dvs som en LIFO (Last In First Out).
Heapen är som att ha böcker i en bokhylla, på rad, man får ta den bok man behöver direkt, utan att behöva ta bort andra böcker först som i stacken.
Stacken har koll på vilka anrop och metoder som körs, när metoden är körd kastas den från stacken och nästa körs. Stacken är alltså självunderhållande och behöver ingen hjälp med minnet. 
Heapen däremot som håller stor del av informationen (men inte har någon koll på exekveringsordning) behöver Garbage Collection för att frigöra utrymme i minnet.

F: 2 Vad är Value Types respektive Reference Types och vad skiljer dem åt?  
  
   Value types lagras dir 
   
3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den 
andra returnerar 4, varför? 
