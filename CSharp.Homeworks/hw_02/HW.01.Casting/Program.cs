//Data
#region
int numInt =-3;
sbyte numSByte = -23;
short numShort = 76;
long numLong = 1_000_000;
byte numByte = 232;
float numFloat = 34.55f;
double numDouble = 1.235;
ulong numUlong = 3_000_000_0000;
uint numUint = 68789;
ushort numUshort = 56;
decimal numDecimal = 7.999_777_000m;
#endregion

//example explicit types conversions
numInt = (int)numByte;
numSByte = (sbyte)numShort;
numShort = (short)numDouble;
numLong = (long)numUlong;
numByte = (byte)numUshort;
numFloat = (float)numInt;
numDouble = (double)numLong;
numUlong = (ulong)numShort;
numUint = (uint)numFloat;
numUshort = (ushort)numShort;

//example implicit types conversions
numDouble = numFloat;
numUlong = numUint;
numUint = numUshort;
numUshort = numByte;
numLong = numInt;
numInt = numShort;
numLong = numSByte;
numInt = numByte;
numUint= numUshort;
numInt = numUshort;

//example boxing
object objInt = numInt;
object objSByte = numSByte;
object objShort = numShort;
object objlong = numLong;
object objFloat = numFloat;
object objDouble = numDouble;
object objDecimal = numDecimal;
object objUshort = numUshort;
object objUint = numUint;
object objByte = numByte;

//example unboxing
numInt = (int)objInt;
numSByte = (sbyte)objSByte; 
numShort = (short)objShort;
numLong = (long)objlong;
numFloat = (float)objFloat;
numDouble = (double)objDouble;
numDecimal = (decimal)objDecimal;
numUshort = (ushort)objUshort;
numUint = (uint)objUint;
numByte = (byte)objByte;





