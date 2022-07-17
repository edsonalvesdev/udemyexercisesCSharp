using System.Globalization;
using Udemy;

#region Exercicio 1, Capitulo 4
/*
Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade) {
    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
} else {
    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
}
*/
#endregion

#region Exercicio 2, Capitulo 4
/*
Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double m = (f1.Salario + f2.Salario) / 2;
Console.WriteLine("Salário médio = " + m.ToString("F2", CultureInfo.InvariantCulture));
*/
#endregion

#region Exercicio 1, Capitulo 5
/*
ContaBancaria conta;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá despósito inicial (s/n)?");
string resp = Console.ReadLine();

if (resp == "s" || resp == "S") {
    Console.Write("Entre o valor de depósito inicial: ");
    double saldo = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(numero, titular, saldo);
} else {
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine());
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine());
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);
*/
#endregion

#region Exercício 1, Capitulo 6
/*
Cliente c;
Object[] rooms = new Object[10];

Console.Write("How many room will be rented? ");
int nStudents = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < nStudents; i++) {
    c = new Cliente();
    Console.WriteLine("Rent #" + (i+1).ToString());
    Console.Write("Name: ");
    c.Name = Console.ReadLine();
    Console.Write("Email: ");
    c.Email = Console.ReadLine();
    Console.Write("Room: ");
    c.Room = int.Parse(Console.ReadLine());
    rooms[c.Room] = c;
    Console.WriteLine();
}

Console.WriteLine("Busy rooms:");

for (int i = 0; i < rooms.Length; i++) {
    if (rooms[i] != null) {
        Console.WriteLine(rooms[i]);
    }
}
*/
#endregion

#region Exercício 1, Capítulo 7
/*
List<Employee> list = new List<Employee>();

Console.Write("How many employees will be registered: ");
int reg = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < reg; i++) {
    //e = new Employee();
    Console.WriteLine("Employee #" + (i + 1).ToString());
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = list.Find(x => x.Id == searchId);

if (emp != null) {
    Console.Write("Enter the percentage : ");
    double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(perc);
} else {
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
list.ForEach(item => { Console.WriteLine(item); });
*/
#endregion

#region Exercício 2, Capitulo 7

string[] estrutura = Console.ReadLine().Split(' ');
object[,] matriz = new object[int.Parse(estrutura[0]), int.Parse(estrutura[1])];

for (int i = 0; i < matriz.GetLength(0); i++) {
    object[] colunas = Console.ReadLine().Split(' ');

    for (int j = 0; j < colunas.Length; j++) {
        matriz[i,j] = colunas[j];
    }
}

string number = Console.ReadLine();

for (int i = 0; i < matriz.GetLength(0); i++) {
    for (int j = 0; j < matriz.GetLength(1); j++) {
        if (matriz.GetValue(i,j).ToString() == number) {
            Console.WriteLine($"Position {i},{j}:");
            
            if (j-1 >= 0) {
                Console.WriteLine($"Left: {matriz.GetValue(i, j-1)}");
            }

            if (j+1 >= 0) {
                Console.WriteLine($"Right: {matriz.GetValue(i, j+1)}");
            }

            if (i-1 >= 0) {
                Console.WriteLine($"Up: {matriz.GetValue(i-1, j)}");
            }

            if (i+1 >= 0) {
                Console.WriteLine($"Down: {matriz.GetValue(i+1, j)}");
            }
        }
    }
}


#endregion