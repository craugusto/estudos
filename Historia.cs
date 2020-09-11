namespace estudos
{
    public class Historia : Professor<string>
    {
        public override string trabalha(string var1, string var2)
        {
            return "História do meu primeiro " + var1 + " " + var2;
        }
    }
}