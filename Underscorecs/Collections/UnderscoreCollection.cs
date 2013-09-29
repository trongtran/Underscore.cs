using System;
using System.Collections.Generic;


namespace Com.AsNet.Common.Underscore.Collections
{
    public class UnderscoreCollection
    {

        /// <summary>
        /// Iterates over a list of elements, yielding each in turn to an 
        /// iterator function. The iterator is bound to the context object,
        /// if one is passed
        /// </summary>
        /// <typeparam name="T">Parameter type</typeparam>
        /// <param name="collection">work on array, list</param>
        /// <param name="iterator">element in the collection</param>
        public void Each<T>(IEnumerable<T> collection, Action<T> iterator)
        {
            foreach (var item in collection)
            {
                iterator(item);
            }
        }


        public IEnumerable<T> Map<T>(IEnumerable<T> collection, Action<T> iterator)
        {
            // TODO: Not yet implement
            return null;
        }
    }
}
