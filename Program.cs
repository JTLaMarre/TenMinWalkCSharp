using System;
public class Kata
{
    public static void Main(string[] args){
        IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"});
        IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"});
    }
  public static int startV = 0; 
  public static int startH = 0; 
  public static int min =0;
  
  public static bool IsValidWalk(string[] walk)
  {
    //insert brilliant code here
    // starting point = 0
    //  n = +1, s= -2
   //   w =+1, e = -2   
    foreach(string b in walk){
      if(b == "n"){
        startV = startV + 1;
        min = min +1;
      }
      if(b == "s"){
        startV = startV - 1;
        min = min +1;
      }
      if(b == "w"){
        startH = startH +1;
        min = min +1;
      }
      if(b == "e"){
        startH = startH -1;
        min = min +1;
      }
    }
    if(startV == 0  && startH == 0 && min == 10){
      Console.WriteLine("true");
      Console.WriteLine(start);
      return true;
    }
    else{
      Console.WriteLine("false");
      Console.WriteLine(start);
      return false;
    }
  }
}
