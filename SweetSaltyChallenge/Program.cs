//Initializing the initial boolean so that on correct input the while loop only runs once.
bool loop = false;
//Initial input values
int numVal = 0;
int numVal2 = 0;
do {
    //Set the bool to false after each loop so that it only loops if it triggers the conditionals
    loop = false;
    // Getting User input

    //Secondary loop to verify if individual input is a integer
    bool valid = false;
    do {
        valid = false;
    Console.WriteLine("Please input the number you want to start the count with.");
    string? input = Console.ReadLine();
    bool success = int.TryParse(input, out numVal);
    if (input != null && success)
     numVal = (int) Int32.Parse(input);
    Console.WriteLine("");
    // use this to check
    if (success == false) {
        Console.WriteLine("Invalid input. Please submit a Integer.");
        valid = true;
    }
    } while(valid);

    //Secondary loop to verify if individual input is a integer
     do {
        valid = false;
    Console.WriteLine("Please input the number you want to stop the count at.");
    string? input2 = Console.ReadLine();
    bool success = int.TryParse(input2, out numVal2);
    if (input2 != null && success)
     numVal2 = (int) Int32.Parse(input2);
    Console.WriteLine("");
    // use this to check
    if (success == false) {
         Console.WriteLine("Invalid input. Please submit a Integer.");
        valid = true;
    }
    } while(valid);
  
// Calculating the amount of numbers that will be printed.
    int Count = ((numVal2 - numVal) + 1);

    // Checking the 4 conditions that would cause the program to prompt the User to resubmit values.
    if (Math.Abs(numVal2 - numVal) > 1000) {
        Console.WriteLine("The difference between your two numbers exceeds 1000. Please choose numbers within range of 1000. 1000 is a valid range. ");
        Console.WriteLine("");
        loop = true;
    }
    else if (numVal > numVal2) {
        Console.WriteLine("The number you selected to end the count is smaller then the number that you inputted to start the count. Please input a start number that is larger than your end number.");
        Console.WriteLine("");
        loop = true;
    }
    else if (Count > 30) {
        Console.WriteLine($"Based on your inputs, you will print {Count} numbers, which exceeds the maximum alloted amount of 30. Please select inputs that produce a quantity of no more than 30.");
        Console.WriteLine("");
        loop = true;
    }
    else if (Count < 5) {
        Console.WriteLine($"Based on your inputs, you will print {Count} numbers, which is under the minimum required amount of 5. Please select inputs that produce a quantity of no more than 30.");
        Console.WriteLine("");
        loop = true;
    }
} while(loop); // conditional for loop
// Setting the counters for the words.
int SwSa = 0;
int Sw = 0;
int Sa = 0;

// For loop that starts at the first number and stops at the last number
for(int i = numVal; i <= numVal2; i++) {
 
 // Conditionals to print the number or the appropiate word based on whether it was divisible by 5, 3 or both.
    if (i % 5 == 0 && i % 3 == 0 ) {
        Console.WriteLine("Sweet’nSalty");
        SwSa++; //Increments counter
    }
    else if (i % 3 == 0) {
        Console.WriteLine("Sweet");
            Sw++; //Increments counter
    }
    else if (i % 5 == 0) {
        Console.WriteLine("Salty");
            Sa++; //Increments counter
    }
    else {
        Console.WriteLine(i); 
    }
    Console.WriteLine(""); //BreakLine
}

Console.WriteLine("# of Sweet: " + Sw);
Console.WriteLine("# of Salty: " + Sa);
Console.WriteLine("# of Sweet'nSalty: " + SwSa);