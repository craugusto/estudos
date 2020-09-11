using estudos;

public class Portugues : Professor<string>
{
    public override string trabalha(string var1, string var2)
    {
        return var1 + " " + var2;
    }
}
