using System;

class Program {
  static long CalculatePower(int theBasisOfTheDegree, int degree) {
    long result = 1;
    for (int exponentiationCounter = 0; exponentiationCounter < degree; ++exponentiationCounter) {
      result *= theBasisOfTheDegree;
    }
    return result;
  }

  static bool TryTransformNumber(string theEnteredNumber, out string transformedNumber) {
    int number = 1;
    int numberLength = 2;
    transformedNumber = string.Empty;

    if (theEnteredNumber.Length <= numberLength) {
      return false;
    }

    char secondDigit = theEnteredNumber[number];
    string newNumber = theEnteredNumber.Remove(1, 1);
    transformedNumber = newNumber + secondDigit;

    return true;
  }

  static void Main() {
    Console.Write("\nTask 1:\n");
    Console.Write("Enter the base a: ");
    int theBasisOfTheDegree = int.Parse(Console.ReadLine());

    Console.Write("Enter the degree indicator n: ");
    int degree = int.Parse(Console.ReadLine());

    long powerResult = CalculatePower(theBasisOfTheDegree, degree);
    Console.WriteLine($"Result: {theBasisOfTheDegree} to the extent of {degree} = {powerResult}");

    Console.Write("\nTask 2:\n");
    Console.Write("Enter a number x (more than 2 digits): ");
    string theEnteredNumber = Console.ReadLine();

    if (TryTransformNumber(theEnteredNumber, out string transformedNumber)) {
      Console.WriteLine($"The original number: {theEnteredNumber}");
      Console.WriteLine($"Conversion result: {transformedNumber}");
    }
    else {
      Console.WriteLine($"Mistake: The number must contain more than two digits");
    }

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}