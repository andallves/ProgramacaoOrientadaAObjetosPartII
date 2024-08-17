namespace OitavaAtividade;

public abstract class Poligono
{
    public static void Main(string[] args)
    {
        // No código seguinte, apesar de parecer que está sendo instânciado um objeto do tipo T, na verdade
        // o que está acontecendo é que estou declarando uma array do tipo T, ou seja, informando que a variável
        // armazenará objeto que extendem o tipo T.
        // Portanto no C# podemos rodar o código sem nenhum problema.
        Poligono[] poligonos = new Poligono[10];
        Console.WriteLine(poligonos.Length); // retorna 10, que seria o tamanho do array.
        
        // Esse segundo caso já nos gera um erro.
        Poligono poligono = new Poligono(); // Aqui a própria IDE (Rider) já retorna um erro
        // "Cannot create an instance of the abstract class 'OitavaAtividade.Poligono'"
        
        
        // Com isso, podemos concluir que é permitido eu declarar um array utilizando uma class abstrata pois,
        // estou 'dizendo' que a variável terá objetos que herdem da class abstrata. No entanto não é permitido 
        // que eu instancie um objetivo utilizando class abstrata.
    }
}