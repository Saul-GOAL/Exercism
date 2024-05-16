
public class PhoneCallAnalysis
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a phone number like 'NNN-NNN-NNNN': ");
        var phoneNumber = Console.ReadLine();

        (bool IsNewYork, bool isFake, string localNumber) = Analyze(phoneNumber);
        Console.WriteLine($"\n The analysis form the number {phoneNumber} is: \n It is from New York?: {IsNewYork} \n Is Fake?: {isFake} \n Local NUmber: {localNumber}");
        Console.ReadLine();
    }

    public static (bool IsNewYork, bool isFake, string localNumber) Analyze(string phoneNumber)
    {
        var numbers = phoneNumber.Split("-");
        return (numbers[0].Equals("212"), numbers[1].Equals("555"), numbers[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) =>
        phoneNumberInfo.IsFake;
}