var userval;
var balance = 10000;
var amount;

userval = Number(prompt("Please enter your option (1. withdraw, 2. transfer, 3. deposit)"+"\nYour balance "+balance));

switch (userval){
    case 1:
        amount = Number(prompt("Enter the amount"));
        if(amount > balance && amount > 0){
            alert("The balance is not enough.");
        }
        else{
            balance -= amount;
            alert("You have draw " + amount + "\nYour balance "+balance);
        }
        break;
    case 2:
        amount = Number(prompt("Enter the amount"));
        var name = prompt("Enter the name")
        if(amount > balance && amount > 0){
            alert("The balance is not enough.");
        }
        else{
            balance -= amount;
            alert("You have tansfered" + amount + "to "+{name}+"\nYour balance "+balance);
        }
        break;

    case 3:
        amount = Number(prompt("Enter the amount"));
        balance += amount;
        alert("Successful!\nYour current balance "+balance);
        break;
    
    default:
        alert("invalid input.")
}
    

