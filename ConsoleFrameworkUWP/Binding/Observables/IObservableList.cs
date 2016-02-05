using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleFramework.Binding.Observables {

    /// <summary>
    /// Marks the IList or IList&lt;T&gt; with notifications support.
    /// It is not derived from IList and IList&lt;T&gt; to allow
    /// to create both generic and nongeneric implementations.
    /// </summary>
    internal interface IObservableList
    {
        event ListChangedHandler ListChanged;
    }

    internal delegate void ListChangedHandler(object sender, ListChangedEventArgs args);

    public enum ListChangedEventType
    {
        ItemsInserted,
        ItemsRemoved,
        ItemReplaced
    }

    internal sealed class ListChangedEventArgs //: EventArgs
    {
        public ListChangedEventArgs(ListChangedEventType type, int index, int count, IList<object> removedItems) {
            this.type = type;
            this.index = index;
            this.count = count;
            this.removedItems = removedItems;
        }

        internal readonly ListChangedEventType type;
        public ListChangedEventType Type { get { return type; } }
        internal readonly int index;
        public int Index { get { return index; } }

        internal readonly int count;
        public int Count { get { return count; } }
        internal readonly IList<object> removedItems;
        public IList<object> RemovedItems { get { return removedItems; } }
    }
    
}