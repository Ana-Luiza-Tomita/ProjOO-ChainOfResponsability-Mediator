namespace ProjOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Janela janela1 = new Janela();
            Janela janela2 = new Janela();
            janela1.OpenWindow(janela2);
            janela2.OpenWindow(janela1);

            janela1.GetForm().ShowDialog();
        }
    }
}