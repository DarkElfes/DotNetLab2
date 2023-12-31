
namespace ConsoleApp.Classes;

public class ExtendedDictionaryElement<T, U, V>
{
    public T Key { get; set; }
    public U FirstValue { get; set; }
    public V SecondValue { get; set; }

    public ExtendedDictionaryElement(T key, U firstValue, V secondValue)
        => (Key, FirstValue, SecondValue) = (key, firstValue, secondValue);

    public override string ToString()
        => $"{Key}: {FirstValue}, {SecondValue}";
}
