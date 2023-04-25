namespace pz_009
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region microwave

            //Microwave toshiba = new();
            //toshiba.Time = 1.0f;
            //toshiba.Mode = 2;
            //toshiba.Start(new Food() { Name = "egg" });

            #endregion

            Client a = new();
            a.Show('o');
            a.Show(9);
            a.Show(2.0f);
        }
    }
}