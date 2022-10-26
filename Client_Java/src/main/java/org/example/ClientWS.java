package org.example;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stub = new BanqueService().getBanqueServicePort();
        System.out.println(stub.conversionEuroToDh(100));
        Compte c = System.out.println(stub.getCompte(1));
        System.out.println(c.getSolde());
    }
}
