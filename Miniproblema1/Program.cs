namespace Miniproblema1;

public class Program{
    public static void Main(string[] args){
        try{
            var entrada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(entrada * entrada);
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
    }
}