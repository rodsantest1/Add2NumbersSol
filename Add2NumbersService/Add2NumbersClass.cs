namespace Add2NumbersService
{
    public class Add2NumbersClass
    {
        public async Task<int> Add2NumbersFunction(string input1, string input2)
        {
            return await Task.Run(() =>
            {
                int.TryParse(input1, out int number1);
                int.TryParse(input2, out int number2);

                var sum = number1 + number2;

                return sum;
            });
        }
    }
}