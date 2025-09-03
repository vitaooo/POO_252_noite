class produto() {
    private int codigo;
    private string nome;
    private double preco;
    private int estoque;
    double subtotal;

    public void mostrarAtributos() {
        System.Console.WriteLine(produto.codigo);
        System.Console.WriteLine(produto.nome);
        System.Console.WriteLine(produto.preco);
        System.Console.WriteLine(produto.estoque);
    }

    public void calcularAumento(int desc) {
        produto.preco = produto.preco + (produto.preco * (desc / 100));
        System.Console.WriteLine("O produto subiu e agora custa: " + produto.preco);
    }

    public void retirarEstoque(int codigo, int qtd) {
        if (codigo)
    }
}