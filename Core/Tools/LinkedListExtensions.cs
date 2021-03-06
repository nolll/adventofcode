using System.Collections.Generic;

namespace Core.Tools
{
    public static class LinkedListExtensions
    {
        public static LinkedListNode<T> NextOrFirst<T>(this LinkedListNode<T> node)
        {
            return node.Next ?? node.List.First;
        }

        public static LinkedListNode<T> PreviousOrLast<T>(this LinkedListNode<T> node)
        {
            return node.Previous ?? node.List.Last;
        }
    }
}