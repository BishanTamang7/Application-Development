namespace Week_4_Tutorial_Workshop;

public class ParameterDemo
{
    // REF parameter modifies existing variable
    public void Increase(ref int number)
    {
        number += 10;
    }

    // OUT parameter method MUST assign a value
    public void GetFullName(out string fullname)
    {
        fullname = "Bishan Tamang";
    }

    // PARAMS parameter accepts multiple numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}