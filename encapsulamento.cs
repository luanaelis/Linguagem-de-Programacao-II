/******************************************************************************

Luana Elis Teixeira Gallo - Usando Propriedades

*******************************************************************************/
class Pessoa
    {
        private String nome;
        private int idade;
        private char sexo;

        public void setNome (String nome)
        {
            this.nome = nome;
        }

        public String getNome ()
        {
            return (this.nome);
        }

static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            p1.setNome("Ana");
            p2.setNome("Paulo");
            p3.setNome("Lia");


            p1.setIdade (23);
            p2.setIdade (35);
            p3.setIdade (12);

            p1.setSexo ('F');
            p2.setSexo ('M');
            p3.setSexo ('F');

            Console.WriteLine(p1.getNome() + " " + p1.getIdade() + " " + p1.getSexo());
            Console.WriteLine(p2.getNome() + " " + p2.getIdade() + " " + p2.getSexo());
            Console.WriteLine(p3.getNome() + " " + p3.getIdade() + " " + p3.getSexo());

            Console.ReadKey();
        }

