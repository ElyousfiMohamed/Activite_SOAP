using System;
using ClientDotNet.BanqueWS;

namespace ClientDotNet
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        BanqueWS.BanqueServiceClient client = new BanqueWS.BanqueServiceClient();
        Console.WriteLine(client.ConversionEuroToDh(100));
        Console.WriteLine(client.getCompte(1).dateCreation);
        foreach (var compte in client.getComptes())
        {
            Console.WriteLine("Code : "+compte.code + " | Solde : " + compte.solde);
        }
    }
  }
}