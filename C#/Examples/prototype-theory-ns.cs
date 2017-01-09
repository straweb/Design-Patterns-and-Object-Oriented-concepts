  using System;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

  namespace PrototypePattern {
    // Prototype Pattern
    // Serialization is used for the deep copy option
     
    [Serializable()]
    public abstract class IPrototype <T> {
      public T Clone() {
          return (T) this.MemberwiseClone(); // Shallow copy
      }
      
      public T DeepCopy() { // Deep Copy
          MemoryStream stream = new MemoryStream();
          BinaryFormatter formatter = new BinaryFormatter();
          formatter.Serialize(stream, this);
          stream.Seek(0, SeekOrigin.Begin);
          T copy = (T) formatter.Deserialize(stream);
          stream.Close();
        return copy;
      }
    }
  }
  
  