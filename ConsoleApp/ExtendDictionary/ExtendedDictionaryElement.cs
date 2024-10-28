namespace ConsoleApp.ExtendDictionary;

internal class ExtendedDictionaryElement<T, U, V>(
    T key,
    U firstValue,
    V secondValue)
{
    public T Key { get; set; } = key;
    public U FirstValue { get; set; } = firstValue;
    public V SecondValue { get; set; } = secondValue;

    public override string ToString()
       => $"{Key}: {FirstValue}, {SecondValue}";
}
