namespace BitwiseXORExample
{
    public class BitwiseXORDemo
    {
        public int MyXOR(int x, int y)
        {
            var result = 0;

            for (int i = 31; i >= 0; i--)
            {
                // find current bits in y and y
                var bitOne = ((x & (1 << i)) == 0) ? 0 : 1;
                var bitTwo = ((y & (1 << i)) == 0) ? 0 : 1;

                var xoredBit = ((bitOne & bitTwo) != 0) ? 0 : (bitOne | bitTwo);

                result <<= 1;
                result |= xoredBit;
            }

            return result;
        }

        public int XORWithoutLoop(int x, int y)
        {
            return (x | y) & (~x | ~y);
        }

        public int XOR(int x, int y)
        {
            return (x + y - (2 * (x & y)));
        }
    }
}
