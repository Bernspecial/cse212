public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    public static void Run()
    {
        double start = 7;
        // int numberOfMultiplese = 5;
        double[] result = MultiplesOf(start, 5);
        Console.WriteLine("Multiple of" + start + ":" + string.Join(",", result));



        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int amount = 5;
        List<int> result2 = RotateListRight(data, amount);
        Console.WriteLine("Rotated List:" + string.Join(",", result2));
    }



    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEP 1 IS TO INITIALIZE AN ARRAY TO DOUBLES HOLD THE MULTIPLES
        double[] result = new double[length];

        // STEP 2 IS TO LOOP FROM 1 TO LENGTH TO CALCULATE MULTIPLES
        for (int i = 1; i <= length; i++)
        {
            // STEP 3 TO CALCULATE THE MULTIPLES BY MULTIPLYING THE START WITH THE CURRENT INDEX
            result[i - 1] = number * i;
        }
        // STEP 4 RETURN THE ARRAY OF MULTIPLES.
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {

        // STEP 1 IS TO MAKE SURE THE ROTATION AMOUNT IS WITHIN THE VALID RANGE
        int rotation = amount % data.Count;

        // STEP 2 IS TO IDENTIFY PARTITION POINT
        int splitIndex = data.Count - rotation;


        // STEP 3 IS TO REORGANISE THE LIST BY USING SLICING
        // Get last 'amount' elements and move them to the front
        List<int> temp = new List<int>(data.GetRange(splitIndex, rotation));
        data.RemoveRange(splitIndex, rotation); // Remove the last 'amount' elements
        data.InsertRange(0, temp); // Insert them at the beginning



        // STEP 5 IS RETURN THE RESULT
        return temp;

    }
}
