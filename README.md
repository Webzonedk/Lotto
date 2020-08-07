# Lotto
An excercise in arrays, methods, loops and conditions

Vondering why the methods can't return int values to a predefined variable with a value of 0 in program as the return value for some reason gets reset hwen the program moves on.
So I decided to only return arrays and two of them only have one index number, and then the value is just stored in that way, which happens to work.

Figured out that to save a method when returning to main program, I need to save the method into an int variable ie:
int variableToSaveTo = CompareNumbers(winnerNumbersAmount, lottonumbers, userCoupon);

