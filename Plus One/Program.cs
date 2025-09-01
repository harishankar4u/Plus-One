class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumOne([1,2,9])); //output [1,2,4]
        Console.WriteLine(SumOne([4,3,2,1])); //output [4,3,2,2]
        Console.WriteLine(SumOne([9])); //output [1,0]
    }
    public static int[] SumOne(int[] digits)
    {
        int carry = 1;
        for(int i=digits.Length-1; i>=0; i--)
        {
            int sum=digits[i]+carry;
            digits[i] = sum%10; 
            carry = sum/10;
        }
        if(carry>0)
        {
            // Need extra space for carry
            /*
             * digits → the source array (where we copy from).

             0 → the starting index in the source (digits) from which copying begins.

             result → the destination array (where we copy to).

            1 → the starting index in the destination (result) where copied elements will be placed.

             digits.Length → how many elements to copy.
             */

            int[] result=new int[digits.Length+1];
            result[0]=carry;
            Array.Copy(digits,0,result, 1, digits.Length);
            return result;

        }
        return digits;
    }
}