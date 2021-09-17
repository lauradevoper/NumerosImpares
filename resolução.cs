using System;

class minhaClasse {
  public static void Main() {

    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++) {
      if (i % 2 == 1) { // pode ser tbm i % 2!=0
        Console.WriteLine(i);
      }
    }
  }
}