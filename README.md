# BillShare (Domainname:BillShare)
Beschreibung vom Projekt.  
Das ist eine neue Zeile.  
Eine Auflistung kann wie folgt erstellt werden:  
+ *Schritt1:*
+ *Schritt2:*
+ Schritt3:  

Ein Programmabschnitt kann auch eingefügt werden. Dazu verwende folgende Syntax:  
```csharp
 public class Person{
   public string Firstname{get;set;}
}
```

  
## Projekstruktur erstellen  
+ **Schritt1:** Projektname überlegen und mit diesem Namen eine Solution erstellen  
+ **Schritt2:** Eine Klassenbibliothek 'CommonBase' erstellen. In dieser Bibliothek werden alle Algorithmen welche unabhängig vom Domain-Bereich sind, gesammelt.  
+ **Schritt3:** Eine Klassenbibliothek für die Schnittstellen anlegen. Der Projektname wird wie folgt definiert: [Domainname].Contracts.  
+ **Schritt1:** Eine Klassenbibliothek für die Geschäftslogik. In diesem Projekt werden alle Geschäftsprozesse gesammelt. Projektname wird wie folgt definiert: [Domainname].Logic  
+ **Schritt4:** Erstellung einer Konsolenanwendung zum Testen der Struktur. Projektname wird wie folgt definiert: [Domainname].ConApp  
+ **Hint:** Im weitern Ausbau werden noch weitere Projekte hinzugefügt (z.B. : Rest-Service)
+ **Schritt6:** Abhängigkeiten definieren