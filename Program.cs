using System;

namespace IntegralNumericTypesProj
{
    class Program
    {
        static void CnLog(string text) => Console.WriteLine(text); 
        static void Main()
        {
            // Characteristics of the integral types
            CnLog($"sbyte Range: {sbyte.MinValue} to {sbyte.MaxValue}");    // SIGNED 8-bit integer
            CnLog($"byte Range: {byte.MinValue} to {byte.MaxValue}");       // UNSIGNED 8-bit integer
            CnLog($"short Range: {short.MinValue} to {short.MaxValue}");    // SIGNED 16-bit integer
            CnLog($"ushort Range: {ushort.MinValue} to {ushort.MaxValue}"); // USIGNED 16-bit integer
            CnLog($"int Range: {int.MinValue} to {int.MaxValue}");          // SIGNED 32-bit integer
            CnLog($"uint Range: {uint.MinValue} to {uint.MaxValue}");       // UNSIGNED 32-bit integer
            CnLog($"long Range: {long.MinValue} to {long.MaxValue}");       // SIGNED 64-bit integer
            CnLog($"ulong Range: {ulong.MinValue} to {ulong.MaxValue}");    // USIGNED 64-bit integer
            CnLog($"System.IntPtr size:{ System.IntPtr.Size}");             // SIGNED 32-bit or 64-bit integer
            CnLog($"System.UIntPtr size:{ System.UIntPtr.Size}");           // UNSIGNED 32-bit or 64-bit integer

            int a = 123;
            System.Int32 b = 123;

            bool isSame = (a.GetHashCode() == b.GetHashCode());
            CnLog($"\nVarables \"int a\" and \"System.Int32 b\" are identical: {isSame}");

            System.Numerics.BigInteger BigOneHere = System.Numerics.BigInteger.Max(-222222222222222222, 88888888888888);

            var decimalLiteral = 42;
            var hexLiteral = 0x2A;
            var binaryLiteral = 0b_0010_1010;

            CnLog("DcimalLiteral type: " + decimalLiteral.GetType().ToString());
            CnLog("hexLiteral type: " + hexLiteral.GetType().ToString());
            CnLog("binaryLiteral type: " + binaryLiteral.GetType().ToString());


        }
    }
}
