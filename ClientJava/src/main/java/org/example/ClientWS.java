package org.example;

import org.example.proxy.BanqueService;
import org.example.proxy.BanqueWS;
import org.example.proxy.Compte;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stub = new BanqueWS().getBanqueServicePort();
        System.out.println(stub.conversionEuroToDh(100));
        Compte compte = stub.getCompte(1);
        System.out.println(compte.getDateCreation());
        stub.getComptes().forEach(c -> System.out.println(c.getCode() + " " + Math.round(c.getSolde())));

    }
}
