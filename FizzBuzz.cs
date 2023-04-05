// Write a public method that accepts a number
// - Whats makes up a method? 
//     - Access modifier
//     - Return type
//     - Name
//     - Paramenters
//     - Scope


public string Fizzbuzz(int num)
// when the number is divisible by 3 return the word fizz
if(num % 3 == 0)
{
    return "fizz";
}
//when the number is divisible by 5 return the word buzz
else if(num % 5 == 0) 
{
    return "buzz"
}
//when the number is divisible by both, return the word fizzbuzz
else if(num % 3 ==0) && (num % 5 == 0)
{
    return "Fizzbuzz";
}
