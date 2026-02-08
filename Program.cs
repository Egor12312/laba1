using System;

class Program {
  static long CalculatePower(int baseNumber, int exponent) {
    long result;
    int counter;
    result = 1;

    for (counter = 0; counter < exponent; ++counter) {
      result *= baseNumber;
    }

    return result;
  }

  static bool TryTransformNumber(string inputNumber, out string transformedNumber) {
    int MinDigitsRequired, SecondDigitIndex;
    char secondDigit;
    string numberWithoutSecondDigit;
    MinDigitsRequired = 2;
    SecondDigitIndex = 1;

    transformedNumber = string.Empty;

    if (inputNumber.Length <= MinDigitsRequired) {
      return false;
    }

    secondDigit = inputNumber[SecondDigitIndex];

    numberWithoutSecondDigit = inputNumber.Remove(SecondDigitIndex, 1);

    transformedNumber = numberWithoutSecondDigit + secondDigit;

    return true;
  }

  static void Main() {
    Console.Write("\nTask 1:\nEnter the base a: ");
    int baseNumber, exponent;
    long powerResult;
    string inputNumber, transformedNumber;
    bool isTransformed;

    baseNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter the degree indicator n: ");
    exponent = int.Parse(Console.ReadLine());

    powerResult = CalculatePower(baseNumber, exponent);

    Console.WriteLine($"Result: {baseNumber} to the extent of {exponent} = {powerResult}\n\nTask 2:\nEnter a number x (more than 2 digits): ");
    inputNumber = Console.ReadLine();

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