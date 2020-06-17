using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    var name = Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    var input = Console.ReadLine();
    double salesamount  = Convert.ToDouble(input);
    double sc = 200 +(0.09 *salesamount);
    Console.WriteLine("Sales commission for" + " "+ " "+ name+" "+ "is"+ " "+"$"+sc);
    if(sc  <= 2999){
      Console.WriteLine("Performance is poor");

    }
    else if(sc <= 4999){
      Console.WriteLine("Performance is average");
    }
    else if(sc <=9999){
      Console.WriteLine("Performance is good");
    }
    else if(sc <=14999){
      Console.WriteLine("Performance is excellent");

    }
    else{
      Console.WriteLine("Performance is outstanding");
    }

    
  }
}