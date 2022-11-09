using DictionaryExample;

var dictionary = new DictionaryOperation();
dictionary.Print();

var dictionaryArray = new DictionaryArray();
var list = dictionaryArray.PairOfArray();

foreach(var item in list)
{
    Console.WriteLine(item);
}
