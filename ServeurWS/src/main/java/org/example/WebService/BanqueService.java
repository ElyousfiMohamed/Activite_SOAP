package org.example.WebService;

import jakarta.jws.WebMethod;
import jakarta.jws.WebService;

import java.util.Date;
import java.util.List;

@WebService(serviceName = "BanqueWS")
public class BanqueService {

    @WebMethod(operationName = "ConversionEuroToDh")
    public double conversionEuroToDh(double montant) {
        return montant * 10.5;
    }

    @WebMethod(operationName = "getCompte")
    public Compte getCompte(int code) {
        return new Compte(code, Math.random() * 9000, new Date());
    }

    @WebMethod(operationName = "getComptes")
    public List<Compte> getComptes() {
        return List.of(
            new Compte(1, Math.random() * 9000, new Date()),
            new Compte(2, Math.random() * 9000, new Date()),
            new Compte(3, Math.random() * 9000, new Date())
        );
    }
}
