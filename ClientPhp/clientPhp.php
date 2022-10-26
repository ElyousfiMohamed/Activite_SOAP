<?php
        $clientSOAP = new SoapClient("http://localhost:8080/BanqueWS?wsdl");
        $res = $clientSOAP->__soapCall("getComptes",array());
?>

<html>
    <body>
        <table border="1" cellpadding="2" cellspacing="0">
            <tr>
                <th>Code</th>
                <th>Solde</th>
                <th>Date Creation</th>
            </tr>
            <?php
                foreach($res->return as $c) {
                    echo("<tr>");
                    echo("<td>".$c->code."</td>");
                    echo("<td>".$c->solde."</td>");
                    echo("<td>".$c->dateCreation."</td>");
                    echo("</tr>");
                }
            ?>
    </body>
</html>


