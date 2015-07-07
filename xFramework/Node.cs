using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace xFramework
{
    public class KeyedObjectCollection : KeyedCollection<string, KeyedObject>
    {
        // The parameterless constructor of the base class creates a 
        // KeyedCollection with an internal dictionary. For this code 
        // example, no other constructors are exposed.
        //
        public KeyedObjectCollection() : base() { }

        // This is the only method that absolutely must be overridden,
        // because without it the KeyedCollection cannot extract the
        // keys from the items. The input parameter type is the 
        // second generic type argument, in this case OrderItem, and 
        // the return value type is the first generic type argument,
        // in this case int.
        //
        protected override string GetKeyForItem(KeyedObject item)
        {
            // In this example, the key is the part number.
            return item.Key;
        }
    }

    [XmlRoot("Node", Namespace = "http://s.xshare.com.cn", IsNullable = false)]
    public class Node : KeyedObject
    {
        public HashSet<string> Characteristics { get; } = new HashSet<string>();
        public KeyedObjectCollection Content { get; } = new KeyedObjectCollection();
        public HashSet<Node> RelativeNodes { get; } = new HashSet<Node>();

    }
}
