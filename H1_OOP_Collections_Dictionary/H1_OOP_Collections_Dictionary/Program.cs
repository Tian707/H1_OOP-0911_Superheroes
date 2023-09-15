namespace H1_OOP_Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare a dictionary
            Dictionary<string, int> people = new Dictionary<string, int>();

            // 2. Read and write dictionary values

            // Using Add method
            people.Add("Tian", 35);

            // Access and modify values using index notation

            // Adding a new key-value pair
            people["Lily"] = 5;
            people["Lis"] = 57;

            // Access first element and print it to the console
            var firstPerson = people.First();
            Console.WriteLine($"Name: {firstPerson.Key}, Age: {firstPerson.Value}");

            // 3. Create a characters dictionary
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true }, 
                { "Han", false },
                { "Chewbacca", false }
            };
            // Remove "Han"
            characters.Remove("Han");

            // 4. Print all elements
            foreach (var character in characters)
            {
                Console.WriteLine($"Character name: {character.Key} | isJedi: {character.Value}");
            }

        }
    }
}