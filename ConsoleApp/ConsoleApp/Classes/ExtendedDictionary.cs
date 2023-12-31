
using System.Collections;

namespace ConsoleApp.Classes;

public class ExtendedDictionary<T, U, V> : IEnumerable
{
    private List<ExtendedDictionaryElement<T, U, V>> dictionary { get; set; } = new();

    public void Add(ExtendedDictionaryElement<T, U, V> obj)
        => dictionary.Add(obj);

    public IEnumerator GetEnumerator()
        => dictionary.GetEnumerator();

    public ExtendedDictionaryElement<T, U, V>? GetElement(T key)
        => dictionary.FirstOrDefault(x => Equals(x.Key, key));

    public void Remove(T key)
        => dictionary.Remove(GetElement(key));

    public bool Exist(T key)
        => GetElement(key) is not null;

    public bool Exist(U firstValue, V secondValue)
        => dictionary.FirstOrDefault(obj => Equals(obj.FirstValue, firstValue) && Equals(obj.SecondValue, secondValue)) is not null;

    public ExtendedDictionaryElement<T, U, V>? this[T key]
    {
        get => GetElement(key);
        set => Add(value);
    }

}
