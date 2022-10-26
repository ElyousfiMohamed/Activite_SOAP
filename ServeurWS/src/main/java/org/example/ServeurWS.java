package org.example;

import jakarta.xml.ws.Endpoint;

public class    ServeurWS {
    public static void main(String[] args) {
        Endpoint.publish("http://localhost:8080/BanqueWS", new org.example.WebService.BanqueService());
        System.out.println("Serveur WS démarré");
    }
}
