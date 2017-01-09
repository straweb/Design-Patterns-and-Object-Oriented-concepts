  using System;
  using System.Collections;

  class IteratorPatternTheory {
  
  // Simplest iterator 
  
  class MonthCollection : IEnumerable {
  
    string [] months = {"January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"};
     
    public IEnumerator GetEnumerator () {
      // Generates values from the collection
      foreach( string element in months )
        yield return element;
      }
    }

    static void Main() {
      MonthCollection collection = new MonthCollection();
      // Consumes values generated from collection's GetEnumeror method
      foreach (string n in collection)
        Console.Write(n+"   ");
        Console.WriteLine("\n");
        Console.ReadKey();
      }
  }
/*Output
January   February   March   April   May   June   July   August   September   October   November   December   
*/