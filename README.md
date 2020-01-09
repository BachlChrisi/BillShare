# BillShare (Domainname:BillShare)
Beschreibung vom Projekt.  
Das ist eine neue Zeile.  
Eine Auflistung kann wie folgt erstellt werden:  
+ *Schritt1:*
+ *Schritt2:*
+ Schritt3:  

Ein Programmabschnitt kann auch eingef�gt werden. Dazu verwende folgende Syntax:  
```csharp
 public class Person{
   public string Firstname{get;set;}
}
```

  
## Projekstruktur erstellen  
+ **Schritt1:** Projektname �berlegen und mit diesem Namen eine Solution erstellen  
+ **Schritt2:** Eine Klassenbibliothek 'CommonBase' erstellen. In dieser Bibliothek werden alle Algorithmen welche unabh�ngig vom Domain-Bereich sind, gesammelt.  
+ **Schritt3:** Eine Klassenbibliothek f�r die Schnittstellen anlegen. Der Projektname wird wie folgt definiert: [Domainname].Contracts.  
+ **Schritt1:** Eine Klassenbibliothek f�r die Gesch�ftslogik. In diesem Projekt werden alle Gesch�ftsprozesse gesammelt. Projektname wird wie folgt definiert: [Domainname].Logic  
+ **Schritt4:** Erstellung einer Konsolenanwendung zum Testen der Struktur. Projektname wird wie folgt definiert: [Domainname].ConApp  
+ **Hint:** Im weitern Ausbau werden noch weitere Projekte hinzugef�gt (z.B. : Rest-Service)
+ **Schritt6:** Abh�ngigkeiten definieren