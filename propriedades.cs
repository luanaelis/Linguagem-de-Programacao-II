/******************************************************************************

Luana Elis Teixeira Gallo - Usando Propriedades

*******************************************************************************/
class Funcionario
    {
        private string nome;
        private int matricula;
        public float salario;

        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int matricula, float salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = salario;
        }


        // get e set nome
        public string getNome ()
        {
            return this.nome;
        }

        public void setNome (string nome)
        {
            this.nome = nome;
        }

        // get e set matricula
        public int  getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int  matricula)
        {
            this.matricula = matricula;
        }

        // get e set email
        public float getSalario()
        {
            return this.salario;
        }

        public void setSalario(float salario)
        {
            this.nome = salario;
        }

        public void imprimir ()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.salario);
        }


    }


class Program
    {
        static void Main(string[] args)
        {

	    Fun[] garage = { 
		new Fun("Luana", 11111, 2500.00), 
		new Fun("Bernardo", 22222, 5100.00),
		new Fun("Boris", 33333, 9800.00)
	    }

	    foreach (Fun Funcionario in garage) {
	    	Console.WriteLine(Funcionario.name);
		Console.WriteLine(Funcionario.matricula);
		Console.WriteLine(Funcionario.salario);
	    }

            Console.ReadKey();
        }
    }

