using System;

class Program {
  static long CalculatePower(int baseNumber, int exponent) {
    long result;
    result = 1;

    for (int counter = 0; counter < exponent; ++counter) {
      result *= baseNumber;
    }

    return result;
  }

  static bool TryTransformNumber(string inputNumber, out string transformedNumber) {
    int MinDigitsRequired;
    MinDigitsRequired = 2;

    int SecondDigitIndex;
    SecondDigitIndex = 1;

    transformedNumber = string.Empty;

    if (inputNumber.Length <= MinDigitsRequired) {
      return false;
    }

    char secondDigit;
    secondDigit = inputNumber[SecondDigitIndex];

    string numberWithoutSecondDigit;
    numberWithoutSecondDigit = inputNumber.Remove(SecondDigitIndex, 1);

    transformedNumber = numberWithoutSecondDigit + secondDigit;

    return true;
  }

  static void Main() {
    Console.Write("\nTask 1:\nEnter the base a: ");
    int baseNumber;
    baseNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter the degree indicator n: ");
    int exponent;
    exponent = int.Parse(Console.ReadLine());

    long powerResult;
    powerResult = CalculatePower(baseNumber, exponent);

    Console.WriteLine($"Result: {baseNumber} to the extent of {exponent} = {powerResult}");

    Console.Write("\nTask 2:\nEnter a number x (more than 2 digits): ");
    string inputNumber;
    inputNumber = Console.ReadLine();

    string transformedNumber;
    bool isTransformed;
    isTransformed = TryTransformNumber(inputNumber, out transformedNumber);

    if (isTransformed) {
      Console.WriteLine($"The original number: {inputNumber}\nConversion result: {transformedNumber}");
    } else {
      Console.WriteLine("Mistake: The number must contain more than two digits");
    }

    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}