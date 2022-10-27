/**
 * BanqueWSCallbackHandler.java
 *
 * <p>This file was auto-generated from WSDL by the Apache Axis2 version: 1.8.2 Built on : Jul 13,
 * 2022 (06:38:03 EDT)
 */
package org.example;

/**
 * BanqueWSCallbackHandler Callback class, Users can extend this class and implement their own
 * receiveResult and receiveError methods.
 */
public abstract class BanqueWSCallbackHandler {

  protected Object clientData;

  /**
   * User can pass in any object that needs to be accessed once the NonBlocking Web service call is
   * finished and appropriate method of this CallBack is called.
   *
   * @param clientData Object mechanism by which the user can pass in user data that will be
   *     avilable at the time this callback is called.
   */
  public BanqueWSCallbackHandler(Object clientData) {
    this.clientData = clientData;
  }

  /** Please use this constructor if you don't want to set any clientData */
  public BanqueWSCallbackHandler() {
    this.clientData = null;
  }

  /** Get the client data */
  public Object getClientData() {
    return clientData;
  }

  /**
   * auto generated Axis2 call back method for getComptes method override this method for handling
   * normal response from getComptes operation
   */
  public void receiveResultgetComptes(org.example.BanqueWSStub.GetComptesResponseE result) {}

  /**
   * auto generated Axis2 Error handler override this method for handling error response from
   * getComptes operation
   */
  public void receiveErrorgetComptes(java.lang.Exception e) {}

  /**
   * auto generated Axis2 call back method for conversionEuroToDh method override this method for
   * handling normal response from conversionEuroToDh operation
   */
  public void receiveResultconversionEuroToDh(
      org.example.BanqueWSStub.ConversionEuroToDhResponseE result) {}

  /**
   * auto generated Axis2 Error handler override this method for handling error response from
   * conversionEuroToDh operation
   */
  public void receiveErrorconversionEuroToDh(java.lang.Exception e) {}

  /**
   * auto generated Axis2 call back method for getCompte method override this method for handling
   * normal response from getCompte operation
   */
  public void receiveResultgetCompte(org.example.BanqueWSStub.GetCompteResponseE result) {}

  /**
   * auto generated Axis2 Error handler override this method for handling error response from
   * getCompte operation
   */
  public void receiveErrorgetCompte(java.lang.Exception e) {}
}
