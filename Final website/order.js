
function verify(){
    
    var output;

    var cold_white_brew_P = 180;
    var iced_creamy_latte_P = 180;
    var caramelo_P = 165;
    var white_Chocolate_Mocha_P = 165;
    var mocha_P = 165;
    var blueberry_Cheesecake_P = 1600;
    var chocolate_Cake_P = 1300;
    var salted_Caramel_Cake_P = 1400;
    var dark_Chocolate_P = 60;
    var raisin_Oatmeal_P = 65;
    var carrot_Bar_P = 75;
    var ensaymada_Cheddar_P = 70;
    var choco_Banana_Muffin_P = 60;
    var streussel_Muffin_P = 65;
    
    cold_white_brew_P = parseFloat(cold_white_brew_P)
    iced_creamy_latte_P = parseFloat(iced_creamy_latte_P)
    caramelo_P = parseFloat(caramelo_P);
    white_Chocolate_Mocha_P = parseFloat(white_Chocolate_Mocha_P);
    mocha_P = parseFloat(mocha_P);
    blueberry_Cheesecake_P = parseFloat(blueberry_Cheesecake_P);
    chocolate_Cake_P = parseFloat(chocolate_Cake_P);
    salted_Caramel_Cake_P = parseFloat(salted_Caramel_Cake_P); 
    dark_Chocolate_P = parseFloat(dark_Chocolate_P); 
    raisin_Oatmeal_P =  parseFloat(raisin_Oatmeal_P);
    carrot_Bar_P = parseFloat(carrot_Bar_P);
    ensaymada_Cheddar_P = parseFloat(ensaymada_Cheddar_P);
    choco_Banana_Muffin_P = parseFloat(choco_Banana_Muffin_P);
    streussel_Muffin_P = parseFloat(streussel_Muffin_P)

    var cold_white_brew_Q = 0;
    var iced_creamy_latte_Q = 0;
    var caramelo_Q = 0;
    var white_Chocolate_Mocha_Q = 0;
    var mocha_Q = 0;
    var blueberry_Cheesecake_Q = 0;
    var chocolate_Cake_Q = 0;
    var dark_Chocolate_Q = 0;
    var raisin_Oatmeal_Q = 0;
    var carrot_Bar_Q = 0;
    var ensaymada_Cheddar_Q = 0;
    var choco_Banana_Muffin_Q = 0;
    var streussel_Muffin_Q = 0;
    
    var cold_white_brew_Q = document.getElementById("product1").value;
    if(cold_white_brew_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product1").value = output;
    }
    var iced_creamy_latte_Q = document.getElementById("product2").value;
    if(iced_creamy_latte_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product2").value = output;
    }
    var caramelo_Q = document.getElementById("product3").value;
    if(caramelo_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product3").value = output;
    }
    var white_Chocolate_Mocha_Q = document.getElementById("product4").value;
    if(white_Chocolate_Mocha_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product4").value = output;
    }
    var mocha_Q = document.getElementById("product5").value;
    if(mocha_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product5").value = output;
    }
    var blueberry_Cheesecake_Q = document.getElementById("product6").value;
    if(blueberry_Cheesecake_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product6").value = output;
    }
    var chocolate_Cake_Q = document.getElementById("product7").value;
    if(chocolate_Cake_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product7").value = output;
    }
    var salted_Caramel_Cake_Q = document.getElementById("product8").value;
    if(salted_Caramel_Cake_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product8").value = output;
    }
    var dark_Chocolate_Q = document.getElementById("product9").value;
    if(dark_Chocolate_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product9").value = output;
    }
    var raisin_Oatmeal_Q = document.getElementById("product10").value;
    if(raisin_Oatmeal_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product10").value = output;
    }
    var carrot_Bar_Q = document.getElementById("product11").value;
    if(carrot_Bar_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product11").value = output;
    }
    var ensaymada_Cheddar_Q = document.getElementById("product12").value;
    if(ensaymada_Cheddar_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product12").value = output;
    }
    var choco_Banana_Muffin_Q = document.getElementById("product13").value;
    if(choco_Banana_Muffin_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product13").value = output;
    }
    var streussel_Muffin_Q = document.getElementById("product14").value;
    if(streussel_Muffin_Q < 0){
        output = "Enter a valid amount";
        document.getElementById("product14").value = output;
    }
    
   
    var cold_white_brew_T = cold_white_brew_Q * cold_white_brew_P;
    var iced_creamy_latte_T = iced_creamy_latte_Q * iced_creamy_latte_P;
    var caramelo_T = caramelo_Q * caramelo_P;
    var white_Chocolate_Mocha_T = white_Chocolate_Mocha_Q * white_Chocolate_Mocha_P;
    var mocha_T = mocha_Q * mocha_P;
    var blueberry_Cheesecake_T = blueberry_Cheesecake_Q * blueberry_Cheesecake_P;
    var chocolate_Cake_T = chocolate_Cake_Q * chocolate_Cake_P;
    var salted_Caramel_Cake_T = salted_Caramel_Cake_Q * salted_Caramel_Cake_P;
    var dark_Chocolate_T = dark_Chocolate_Q * dark_Chocolate_P;
    var raisin_Oatmeal_T = raisin_Oatmeal_Q * raisin_Oatmeal_P;
    var carrot_Bar_T = carrot_Bar_Q * carrot_Bar_P;
    var ensaymada_Cheddar_T = ensaymada_Cheddar_Q * ensaymada_Cheddar_P;
    var choco_Banana_Muffin_T = choco_Banana_Muffin_Q * choco_Banana_Muffin_P;
    var streussel_Muffin_T = streussel_Muffin_Q * streussel_Muffin_P;
    var streussel_Muffin_T = streussel_Muffin_Q * streussel_Muffin_P;
    

    if(cold_white_brew_Q <= 0 && iced_creamy_latte_Q <= 0 && caramelo_Q <= 0 && white_Chocolate_Mocha_Q <= 0 && mocha_Q <= 0 && blueberry_Cheesecake_Q <= 0 && chocolate_Cake_Q <= 0 && salted_Caramel_Cake_Q <= 0 && dark_Chocolate_Q <= 0 && raisin_Oatmeal_Q <= 0 && carrot_Bar_Q <= 0 && ensaymada_Cheddar_Q <= 0 && choco_Banana_Muffin_Q <= 0 && ensaymada_Cheddar_Q <= 0 && choco_Banana_Muffin_Q <= 0 && streussel_Muffin_Q <= 0)
    {
        alert("WARNING!!! \nMake sure you ordered something to get a receipt.");
        onlick = window.location.reload();

    } else {

        if(confirm("Are you sure you're done ordering?")){
            var output;
     
            output = document.getElementById("customerName").value;
            output = document.getElementById("customer_Name").innerHTML = output;


            if(cold_white_brew_T > 0){
                output = "Cold White Brew";
                document.getElementById("cold_white_brew").innerHTML = output;
                output = cold_white_brew_Q;
                document.getElementById("coldwhitebrewQuantity").innerHTML = output;
                output = cold_white_brew_T;
                document.getElementById("coldwhitebrewTotal").innerHTML = output;
            } else {
                output = "";
                document.getElementById("cold_white_brew").innerHTML = output;
                output = "";
                document.getElementById("coldwhitebrewQuantity").innerHTML = output;
                output = "";
                document.getElementById("coldwhitebrewTotal").innerHTML = output;
            }

            if(iced_creamy_latte_T > 0){
                output = "Iced Creamy Latte";
                document.getElementById("iced_creamy_latte").innerHTML = output;
                output = iced_creamy_latte_Q;
                document.getElementById("icedcreamylatteQuantity").innerHTML = output;
                output = iced_creamy_latte_T;
                document.getElementById("icedcreamylatteTotal").innerHTML = output;
            } else {
                output = "";
                document.getElementById("iced_creamy_latte").innerHTML = output;
                output = "";
                document.getElementById("icedcreamylatteQuantity").innerHTML = output;
                output = "";
                document.getElementById("icedcreamylatteTotal").innerHTML = output;
            }

            if(caramelo_T > 0){
                output = "Caramelo";
                document.getElementById("caramelo").innerHTML = output;
                output = caramelo_Q;
                document.getElementById("carameloQuantity").innerHTML = output;
                output = caramelo_T;
                document.getElementById("carameloTotal").innerHTML = output;
            } else {
                output = "";
                document.getElementById("caramelo").innerHTML = output;
                output = "";
                document.getElementById("carameloQuantity").innerHTML = output;
                output = "";
                document.getElementById("carameloTotal").innerHTML = output;
            }
        
            if(white_Chocolate_Mocha_T > 0){
                output = "White Chocolate Mocha";
                document.getElementById("white_Chocolate_Mocha").innerHTML = output;
                output = white_Chocolate_Mocha_Q;
                document.getElementById("whiteChocolateMochaQuantity").innerHTML = output;
                output = white_Chocolate_Mocha_T;
                document.getElementById("whiteChocolateMochaTotal").innerHTML = output;
            } else {
                output = "";
                document.getElementById("white_Chocolate_Mocha").innerHTML = output;
                output = "";
                document.getElementById("whiteChocolateMochaQuantity").innerHTML = output;
                output = "";
                document.getElementById("whiteChocolateMochaTotal").innerHTML = output;
            }
        
            if(mocha_T > 0){
                output = "Mocha";
                document.getElementById("mocha").innerHTML = output;
                output = mocha_Q;
                document.getElementById("mochaQuantity").innerHTML = output;
                output = mocha_T;
                document.getElementById("mochaTotal").innerHTML = output;
            } else {
                output = "";
                document.getElementById("mocha").innerHTML = output;
                output = "";
                document.getElementById("mochaQuantity").innerHTML = output;
                output = "";
                document.getElementById("mochaTotal").innerHTML = output;
            }

            if(blueberry_Cheesecake_T > 0){
                output = "Blueberry Cheesecake";
                document.getElementById("blueberry_Cheesecake").innerHTML = output;
                output = blueberry_Cheesecake_Q;
                document.getElementById("blueberryCheesecakeQuantity").innerHTML = output;
                output = blueberry_Cheesecake_T;
                document.getElementById("blueberryCheesecakeTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("blueberry_Cheesecake").innerHTML = output; 
                output ="";  
                document.getElementById("blueberryCheesecakeQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("blueberryCheesecakeTotal").innerHTML = output; 
            } 

            if(chocolate_Cake_T > 0){
                output = "Chocolate Cake";
                document.getElementById("chocolate_Cake").innerHTML = output;
                output = chocolate_Cake_Q;
                document.getElementById("chocolateCakeQuantity").innerHTML = output;
                output = chocolate_Cake_T;
                document.getElementById("chocolateCakeTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("chocolate_Cake").innerHTML = output; 
                output ="";  
                document.getElementById("chocolateCakeQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("chocolateCakeTotal").innerHTML = output; 
            } 

            if(salted_Caramel_Cake_T > 0){
                output = "Salted Caramel Cake";
                document.getElementById("salted_Caramel_Cake").innerHTML = output;
                output = salted_Caramel_Cake_Q;
                document.getElementById("saltedCaramelCakeQuantity").innerHTML = output;
                output = salted_Caramel_Cake_T;
                document.getElementById("saltedCaramelCakeTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("salted_Caramel_Cake").innerHTML = output; 
                output ="";  
                document.getElementById("saltedCaramelCakeQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("saltedCaramelCakeTotal").innerHTML = output; 
            } 

            if(dark_Chocolate_T > 0){
                output = "Craft Cookies Dark Chocolate";
                document.getElementById("dark_Chocolate").innerHTML = output;
                output = dark_Chocolate_Q;
                document.getElementById("darkChocolateQuantity").innerHTML = output;
                output = dark_Chocolate_T;
                document.getElementById("darkChocolateTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("dark_Chocolate").innerHTML = output; 
                output ="";  
                document.getElementById("darkChocolateQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("darkChocolateTotal").innerHTML = output; 
            } 
            
            if(raisin_Oatmeal_T > 0){
                output = "Craft Cookies Raisin and Oatmeal";
                document.getElementById("raisin_Oatmeal").innerHTML = output;
                output = raisin_Oatmeal_Q;
                document.getElementById("raisinOatmealQuantity").innerHTML = output;
                output = raisin_Oatmeal_T;
                document.getElementById("raisinOatmealTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("raisin_Oatmeal").innerHTML = output; 
                output ="";  
                document.getElementById("raisinOatmealQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("raisinOatmealTotal").innerHTML = output; 
            } 

            if(carrot_Bar_T > 0){
                output = "Carrot Bar";
                document.getElementById("carrot_Bar").innerHTML = output;
                output = carrot_Bar_Q;
                document.getElementById("carrotBarQuantity").innerHTML = output;
                output = carrot_Bar_T;
                document.getElementById("carrotBarTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("carrot_Bar").innerHTML = output; 
                output ="";  
                document.getElementById("carrotBarQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("carrotBarTotal").innerHTML = output; 
            } 

            if(ensaymada_Cheddar_T > 0){
                output = "Ensaymada Cheddar";
                document.getElementById("ensaymada_Cheddar").innerHTML = output;
                output = ensaymada_Cheddar_Q;
                document.getElementById("ensaymadaCheddarQuantity").innerHTML = output;
                output = ensaymada_Cheddar_T;
                document.getElementById("ensaymadaCheddarTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("ensaymada_Cheddar").innerHTML = output; 
                output ="";  
                document.getElementById("ensaymadaCheddarQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("ensaymadaCheddarTotal").innerHTML = output; 
            } 

            if(choco_Banana_Muffin_T > 0){
                output = "Choco Banana Muffin";
                document.getElementById("choco_Banana_Muffin").innerHTML = output;
                output = choco_Banana_Muffin_Q;
                document.getElementById("chocoBananaMuffinQuantity").innerHTML = output;
                output = choco_Banana_Muffin_T;
                document.getElementById("chocoBananaMuffinTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("choco_Banana_Muffin").innerHTML = output; 
                output ="";  
                document.getElementById("chocoBananaMuffinQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("chocoBananaMuffinTotal").innerHTML = output; 
            } 

            if(streussel_Muffin_T > 0){
                output = "Blue Berry Calamansi Streussel Muffin";
                document.getElementById("streussel_Muffin").innerHTML = output;
                output = streussel_Muffin_Q;
                document.getElementById("streusselMuffinQuantity").innerHTML = output;
                output = streussel_Muffin_T;
                document.getElementById("streusselMuffinTotal").innerHTML = output;
            } else {
                output ="";  
                document.getElementById("streussel_Muffin").innerHTML = output; 
                output ="";  
                document.getElementById("streusselMuffinQuantity").innerHTML = output; 
                output ="";  
                document.getElementById("streusselMuffinTotal").innerHTML = output; 
            } 


            output = "Total Amount to Pay:";
            document.getElementById("display").innerHTML = output;

            if(cold_white_brew_Q >= 0 && iced_creamy_latte_Q >= 0 && caramelo_Q >= 0 && white_Chocolate_Mocha_Q >= 0 && mocha_Q >= 0 && blueberry_Cheesecake_Q >= 0 && chocolate_Cake_Q >= 0 && salted_Caramel_Cake_Q >= 0 && dark_Chocolate_Q >= 0 && raisin_Oatmeal_Q >= 0 && carrot_Bar_Q >= 0 && ensaymada_Cheddar_Q >= 0 && choco_Banana_Muffin_Q >= 0 && ensaymada_Cheddar_Q >= 0 && choco_Banana_Muffin_Q >= 0 && streussel_Muffin_Q >= 0 )
            {   
                output = cold_white_brew_T + iced_creamy_latte_T + caramelo_T + white_Chocolate_Mocha_T + mocha_T + blueberry_Cheesecake_T + chocolate_Cake_T + salted_Caramel_Cake_T + dark_Chocolate_T + raisin_Oatmeal_T + carrot_Bar_T + ensaymada_Cheddar_T + choco_Banana_Muffin_T + streussel_Muffin_T;
                document.getElementById("total").innerHTML = output;  
            } else {
                
                    output = "";
                    document.getElementById("total").innerHTML = output;
                
            }
           
            if(caramelo_T >= 0 && white_Chocolate_Mocha_T >= 0 && mocha_T >= 0 && blueberry_Cheesecake_T >= 0 && chocolate_Cake_T >= 0 && salted_Caramel_Cake_T >= 0 && dark_Chocolate_T >= 0 && raisin_Oatmeal_T >= 0 && carrot_Bar_T >= 0 && ensaymada_Cheddar_T >= 0 && choco_Banana_Muffin_T >= 0 && ensaymada_Cheddar_T >= 0 && choco_Banana_Muffin_T >= 0 && streussel_Muffin_T >= 0 && cold_white_brew_T >= 0 && iced_creamy_latte_T >= 0)
            {
                output = "Thank you so much for your order. We really appreciate and hope that you love your purchase.";
                document.getElementById("thanks").innerHTML = output;
            } else {
                output = "";
                document.getElementById("thanks").innerHTML = output;
            }

            if(cold_white_brew_Q< 0 || iced_creamy_latte_Q  < 0 || caramelo_Q  < 0 || white_Chocolate_Mocha_Q < 0 || mocha_Q < 0 ||blueberry_Cheesecake_Q < 0 || chocolate_Cake_Q < 0 || salted_Caramel_Cake_Q < 0 || dark_Chocolate_Q < 0 || ensaymada_Cheddar_T < 0 || choco_Banana_Muffin_T < 0 || ensaymada_Cheddar_T < 0 || choco_Banana_Muffin_T < 0 || ensaymada_Cheddar_Q < 0 || choco_Banana_Muffin_Q < 0 || streussel_Muffin_Q < 0)
            {
                output = "Please enter a valid quantity to show the exact total amount to pay";
                document.getElementById("invalidQuantity").innerHTML = output;
            } else {
                output = "";
                document.getElementById("invalidQuantity").innerHTML = output;
            }
        } else {
            onlick = window.location.reload();
        }
    }
}       