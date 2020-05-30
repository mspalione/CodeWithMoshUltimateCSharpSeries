using System.Collections.Generic;

namespace StringBuilder
{
    class StringExtractor
    {
        public List<int> InputList(string input)
        {
            var inputArray = input.Split('-');
            var inputList = new List<int>();
            foreach (var num in inputArray)
            {
                var number = int.Parse(num);
                inputList.Add(number);
            }
            return inputList;
        }
    }
}
