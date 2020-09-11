using System;
public abstract class Professor<T>
{
    public abstract T trabalha (T var1, T var2);

    public void comprimenta()
    {
        Console.WriteLine("Bom dia classe!");
    }


}