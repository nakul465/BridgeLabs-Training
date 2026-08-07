// See https://aka.ms/new-console-template for more information
using RegExpression;
Console.WriteLine(ValidateUserName.IsValidUserName("Nakul_1234"));
Console.WriteLine(ValidateLicensePlate.IsValidLicensePlate("NA2314"));
Console.WriteLine(ValidateHexColorCode.IsValidHexColorCode("#2CB445"));
ExtractEmailAddress.ExtractsEmailAddress("Contact us at support@example.com and info@company.org");
ExtractCapitalisedWords.ExtractsCapitalisedWords("The Eiffel Tower is in Paris and the Statue of Liberty is in New York.");
ExtractDates.ExtractsDates("The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.");
ExtarctLink.ExtarctsLink("Visit https://www.google.com and http://example.org for more info.");
Console.WriteLine(ReplaceSpaces.ReplaceAllSpaces("123     123     133     123"));
Console.WriteLine(CensorWordsInString.CensorBadWordsInString("This is a damn bad example with some stupid words."));
ExtractProgrammingLanguages.ExtractProgrammingLanguagesNames("I love Java, Python, and JavaScript, but I haven't tried Go yet.");
ExtractCurrency.ExtractCurrencyValues("The price is $45.99, and the discount 100 is $ 10.50.");
Console.WriteLine(ValidSSN.IsValidSSN("My SSN is 123-45-6789."));
ValidCreditCard.ValidCreditCardNumber("4123456789012345");
