using BitwiseXORExample;

var bitwiseXORDemo = new BitwiseXORDemo();

var x = 3; 
var y = 5;

Console.WriteLine($"XOR is {bitwiseXORDemo.MyXOR(x, y)}");

Console.WriteLine($"Using ^ operatot XOR is {x ^ y}");

Console.WriteLine($"XOR with out loop is {bitwiseXORDemo.XORWithoutLoop(x, y)}");

Console.WriteLine($"Using XOR method result is {bitwiseXORDemo.XOR(x, y)}");