F: 1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion  
S: Stacken är som en stapel med böcker, man får ta först boken som är överst och uprepa det tills man når den bok man letar efter. Dvs som en LIFO (Last In First Out).
Heapen är som att ha böcker i en bokhylla, på rad, man får ta den bok man behöver direkt, utan att behöva ta bort andra böcker först som i stacken.
Stacken har koll på vilka anrop och metoder som körs, när metoden är körd kastas den från stacken och nästa körs. Stacken är alltså självunderhållande och behöver ingen hjälp med minnet. 
Heapen däremot som håller stor del av informationen (men inte har någon koll på exekveringsordning) behöver Garbage Collection för att frigöra utrymme i minnet.

F: 2 Vad är Value Types respektive Reference Types och vad skiljer dem åt?  
  Value Types är typer från System.ValueType:  
• bool
• byte 
• char
• decimal
• double
• enum
• float
• int
• long
• sbyte
• short
• struct
• uint
• ulong
• ushort  
  Reference Types är typer som ärver från System.Object (eller är System.Object.object):  
• class
• interface
• object
• delegate
• string  
  En reference type lagras alltid på heapen. Medan Value types, lagras där de deklareras. Om de deklareras i en metod, lagras de i stacken, om i en class, i heapen. Alltså kan value types lagras både på stacken eller heapen.
   
F: 3. Följande metoder genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför? 
    public static int ReturnValue()
    {
        int x = new int();
        x = 3;
        int y = new int();
        y = x;
        y = 4;
        return x;
    }  

    public static int ReturnValue2()
    {
        MyInt x = new MyInt();
        x.MyValue = 3;
        MyInt y = new MyInt();
        y = x;
        y.MyValue = 4;
        return x.MyValue;
    }
}

public class MyInt
{
    public int MyValue;
}

S: Eftersom i den första metoden x och y är value types (värdetyper) variabler. En variabel av en värdetyp innehåller en instans av typen int. Detta skiljer sig från en variabel av en referenstyp (de som finns i andra metoden), som innehåller referenser till 2 instanser av typen MyInt. Men y på rad 48 börjar peka endast på samma objektinstans som x, så när y.MyValue blir samma som x.MyValue eftersom de refererar till samma objekt som finns i heapen.
Variabler av referenstyper lagrar referenser till deras data (objekt), medan variabler av värdetyper direkt innehåller deras data. Med referenstyper kan två variabler referera till samma objekt; därför kan operationer på en variabel påverka objektet som den andra variabeln refererar till. Med värdetyper har varje variabel sin egen kopia av data, och det är inte möjligt för operationer på en variabel att påverka den andra (förutom när det gäller parametervariabler in, ref och out).

Källhänvisning:  
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types  
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
