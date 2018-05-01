public class BlmgData
  {
 public double high;
    public double low;
    public double close;
    public double dividend;
 public double index;
    public override string ToString()
            {  
            return low.ToString() + "-" + high.ToString();
            }    
};
void Main()
{
  double None = 0.0;
  Dictionary<string, BlmgData> EQuities = new Dictionary<string, BlmgData>();
  BlmgData  Stocks5 = new BlmgData();
            Stocks5.high = 43.87;
            Stocks5.low = 41.14;
            Stocks5.dividend = None;  
            Stocks5.close = 43.55;
EQuities["INTC"] = Stocks5;
//string Stocks = "Enter a Stock";
 double quote;
bool done = false;
//string inputMSG = "Enter A Stock Ticker:";
 do
 {
 //Util.ClearResults();
 Console.WriteLine("inputMSG");
  string tkr = Console.ReadLine();
   if(EQuities.Keys.Contains(tkr) )
   {
    var rec = EQuities[tkr];
    rec.Dump();
     //Console.WriteLine("Stocks5");
     done = true;
   }
   else
   {
    Console.WriteLine();
   }
 }while ( !done );
}

