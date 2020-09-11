namespace estudos
{
    public class Matematica : Professor<int>
    {
        public override int trabalha(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}