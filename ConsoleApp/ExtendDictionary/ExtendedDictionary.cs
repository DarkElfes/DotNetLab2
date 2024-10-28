using System.Collections;

namespace ConsoleApp.ExtendDictionary;

internal class ExtendedDictionary<T, U, V> : IEnumerable
{
    private readonly Dictionary<T, ExtendedDictionaryElement<T, U, V>> _dictionary = [];
    public int Count => _dictionary.Count;

    public void Add(ExtendedDictionaryElement<T, U, V> el)
    {
        if (_dictionary.ContainsKey(el.Key))
            throw new ArgumentException("Element with this key already exist");
        _dictionary.Add(el.Key, el);
    }
    public void Remove(T key) => _dictionary.Remove(key);

    public bool ContainsKey(T key) => _dictionary.ContainsKey(key);
    public bool ContainsValue(U firstValue, V secondValue)
    {
        foreach (var value in _dictionary.Values)
            if (Equals(value.FirstValue, firstValue) && Equals(value.SecondValue, secondValue))
                return true;

        return false;
    }

    public IEnumerator GetEnumerator() => _dictionary.GetEnumerator();
    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get => _dictionary[key];
        set => Add(value);
    }


}
