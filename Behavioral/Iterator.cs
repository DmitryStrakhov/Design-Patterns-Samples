using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Design_Patterns_Samples {

    public sealed class ConcreteCollection<T> : IEnumerable<T> {
        CollectionNode<T> head;
        CollectionNode<T> tail;

        public ConcreteCollection() {
            this.head = null;
            this.tail = null;
        }

        public void AddValue(T value) {
            CollectionNode<T> node = new CollectionNode<T>(value);

            if(tail == null)
                head = tail = node;
            else
                tail = tail.Next = node;
        }
        public CollectionNode<T> Head { get { return head; } }

        private IEnumerator<T> CreateEnumerator() {
            return new ConcreteCollectionEnumerator<T>(this);
        }

        #region IEnumerator<T>

        IEnumerator IEnumerable.GetEnumerator() {
            return CreateEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator() {
            return CreateEnumerator();
        }
        #endregion
    }

    public sealed class CollectionNode<T> {
        readonly T value;

        public CollectionNode(T value) {
            this.value = value;
            this.Next = null;
        }
        public CollectionNode<T> Next { get; set; }
        public T Value { get { return value; } }
    }


    public sealed class ConcreteCollectionEnumerator<T> : IEnumerator<T> {
        readonly ConcreteCollection<T> owner;
        CollectionNode<T> currentNode;

        public ConcreteCollectionEnumerator(ConcreteCollection<T> owner) {
            this.owner = owner;
            this.currentNode = null;
        }

        private T CurrentValue {
            get {
                if(currentNode == null) throw new InvalidOperationException();
                return currentNode.Value;
            }
        }

        #region IEnumerator<T>

        object IEnumerator.Current {
            get { return CurrentValue; }
        }
        T IEnumerator<T>.Current {
            get { return CurrentValue; }
        }

        bool IEnumerator.MoveNext() {
            currentNode = currentNode != null ? currentNode.Next : owner.Head;
            return currentNode != null;
        }
        void IEnumerator.Reset() {
            currentNode = null;
        }
        void IDisposable.Dispose() {
        }

        #endregion
    }
}
