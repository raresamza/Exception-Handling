using ExceptionHandling;
try
{
    ValidateInput(10); 
    ValidateInput(-5); 
}
catch (CustomInputException ex)
{
    Console.WriteLine("Custom Input Exception: " + ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Argument Exception: " + ex.Message);
    throw; 
}
catch (Exception ex)
{
    Console.WriteLine("General Exception: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed.");
}

void ValidateInput(int number)
{
#if DEBUG
    Console.WriteLine("Debug mode is enabled.");
#endif

    if (number < 0)
    {
        throw new CustomInputException("Input number cannot be negative.");
    }
    else if (number == 0)
    {
        throw new ArgumentException("Input number cannot be zero.");
    }
    else
    {
        Console.WriteLine("Input validation successful.");
    }
}