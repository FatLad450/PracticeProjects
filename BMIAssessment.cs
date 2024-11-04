// See https://aka.ms/new-console-template for more information
/* The following code will calculate BMI. 
 * It will ask for the name, age, weight, and height.
 * The code will ask for information for three individuals. 
 * Then it present the BMI for each indicidual, as well as name, height, and weight
 */

// Intialization Phase (Varibles)

// First Person Questions 
Console.WriteLine("Enter Person1's Name: ");

// Creation of a string varible to get a user input from a keyboard. 
string PersonOneName = Console.ReadLine();

Console.WriteLine("What is this person's age: ");

// NOTE TO SELF: I HAVE TO USE A FLOAT CONVERSION 

float PersonOneAge = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("What is this person's weight(kg): "); 

float PersonOneWeight = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("What is this person's height(cm): "); 

float PersonOneHeight = Convert.ToSingle(Console.ReadLine());

// Person Two's Stats 

Console.WriteLine("Great, now what's the second person's name: ");

string PersonTwoName = Console.ReadLine();

Console.WriteLine("What's the second person's age: "); 

float PersonTwoAge = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("What's the second person's weight(kg): "); 

float PersonTwoWeight = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("What's the second person's height(cm): ");

float PersonTwoHeight = Convert.ToSingle(Console.ReadLine());

// Person Three's Stats

Console.WriteLine("Ok, what's the last person's name: ");

string PersonThreeName = Console.ReadLine();

Console.WriteLine("What's the age of the third person:"); 

float PersonThreeAge = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Can you tell me the weight(kg) of the third person: ");

float PersonThreeWeight = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Finally, could you tell me the height(cm) of the third person: ");

float PersonThreeHeight = Convert.ToSingle(Console.ReadLine());


// Action Phase (Calculations)

// First Person's BMI 

float PersonOneBMI = PersonOneWeight / PersonOneHeight / PersonOneHeight * 10000 ;

// Second Person's BMI 

float PersonTwoBMI = PersonTwoWeight / PersonTwoHeight / PersonTwoHeight * 10000;

// Third Person's BMI 

float PersonThreeBMI = PersonThreeWeight / PersonThreeHeight / PersonThreeHeight * 10000;

// Body Mass Index (BMI) Ratings 
/* Underweight: Less than 18.50
 * Healthy Weight: 18.50 - 24.99
 * Overweight: 25 - 29.99
 * Obese: 30 or greater
 * IF condition for final BMI assessment 
 */

//BMI LIST 


List<string> BMIAssessments = new List<string>
        {
            "Underweight: Less than 18.5",
            "Healthy weight: 18.5 to less than 25",
            "Overweight: 25 to less than 30",
            "Class 1 Obesity: 30 to less than 35",
            "Class 2 Obesity: 35 to less than 40",
            "Class 3 Obesity (Severe obesity): 40 or greater"
        };
// PersonOneBMI Assessment
string PersonOneAssessment; 

if (PersonOneBMI < 18.5)
{
    PersonOneAssessment = "Underweight"; 
}
else if (PersonOneBMI >= 18.5 && PersonOneBMI < 25)
{
    PersonOneAssessment = "Healthy"; 
}
else if (PersonOneBMI >=25 && PersonOneBMI <30)
{
    PersonOneAssessment = "Overweight";
}
else
{
    PersonOneAssessment = "Obese";
}

// Person Two BMI Assessment


string PersonTwoAssessment;

if (PersonTwoBMI < 18.5)
{
    PersonTwoAssessment = "Underweight";
}
else if (PersonTwoBMI >= 18.5 && PersonTwoBMI < 25)
{
    PersonTwoAssessment = "Healthy";
}
else if (PersonTwoBMI >= 25 && PersonTwoBMI < 30)
{
    PersonTwoAssessment = "Overweight";
}
else
{
    PersonTwoAssessment = "Obese";
}

// Person Three BMI Assessment 

string PersonThreeAssessment;

if (PersonThreeBMI < 18.5)
{
    PersonThreeAssessment = "Underweight";
}
else if (PersonThreeBMI >= 18.5 && PersonThreeBMI < 25)
{
    PersonThreeAssessment = "Healthy";
}
else if (PersonThreeBMI >= 25 && PersonThreeBMI < 30)
{
    PersonThreeAssessment = "Overweight";
}
else
{
    PersonThreeAssessment = "Obese";
}




// Finalization Phase (Output) 
// BMI Assessment Chart: (MAKE CHART)
Console.WriteLine("BMI Assessment Chart:");
Console.WriteLine(BMIAssessments); 


// Person One 

Console.WriteLine(PersonOneName + " is " + PersonOneAge + " years old, his weight is " + PersonOneWeight + " kg and his height is " + PersonOneHeight + "cm.");
Console.WriteLine(PersonOneName + " has a BMI of " + PersonOneBMI + " and is consideered: " + PersonOneAssessment);

// Person Two 

Console.WriteLine(PersonTwoName + " is " + PersonTwoAge + " years old, his weight is " + PersonTwoWeight + " kg and his height is " + PersonTwoHeight + "cm.");
Console.WriteLine(PersonTwoName + " has a BMI of " + PersonTwoBMI + " and is considered: "+ PersonTwoAssessment);

// Person Three 

Console.WriteLine(PersonThreeName + " is " + PersonThreeAge + " years old, his weight is " + PersonThreeWeight + " kg and his height is " + PersonThreeHeight + "cm.");
Console.WriteLine(PersonThreeName + " has a BMI of " + PersonThreeBMI + " and is considered: " + PersonThreeAssessment);



