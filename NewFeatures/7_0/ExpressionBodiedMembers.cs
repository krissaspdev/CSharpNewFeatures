using System.Collections.Generic;

namespace NewFeatures._7_0
{
    public class ConcretePerson
    { 
        private int id;
       private static readonly Dictionary<int, string> names = new Dictionary<int, string>();

       // expression body in constructor and destructor
       public ConcretePerson(int id, string name) => names.Add(id, name);
       ~ConcretePerson() => names.Remove(id);

       //expression body in property
       public string Name
       {
           get => names[id];
           set => names[id] = value;
       }
    }
    
    public class ExpressionBodiedMembers
    {
        
    }
}