namespace inversaoCaracteres {
    internal class Program {
        static void Main(string[] args)
        {


            string originalString = "eu vou ser dev";
            char[] charArray = originalString.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - 1 - i];
                charArray[length - 1 - i] = temp;
            }

            string reversedString = new string(charArray);
            Console.WriteLine("Original string: " + originalString);
            Console.WriteLine("Reversed string: " + reversedString);

        }
    }
}