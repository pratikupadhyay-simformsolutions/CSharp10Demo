namespace CSharp10Demo;

public struct Demo
{
    // Parameterless constructor with property initialization 
    public Demo()
    {
        Size = 10; 
    }

    // Initialization of the property at its declaration
    public int Size { get; set; } = 10;
}
