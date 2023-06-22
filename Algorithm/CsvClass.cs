using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CsvClass 
    { 
        public string StringValue { get; set; }

        public int IntValue { get; set; }

        public CsvClass(string stringInput, int intInput)
        {
            this.StringValue = stringInput;
            this.IntValue = intInput;
        }

        //Normal Compare Method
        public int CompareTo(string compareBase, CsvClass item)
        {
            switch (compareBase)
            {
                case "Age": // Sort by title
                    return this.IntValue.CompareTo(item.IntValue);
                case "Name":
                    return this.StringValue.CompareTo(item.StringValue);
                default:
                    throw new ArgumentException($"Error input value: {compareBase}");
            }
        }

        //Compare method for search algorithms
        public int CompareBySearchTerm(string compareBase,string searchTerm)
        {     
                switch (searchTerm)
                {
                    case "Age": // Sort by title
                        return this.IntValue.ToString().CompareTo(compareBase); 
                    case "Name":
                        return this.StringValue.CompareTo(compareBase);
               
                    default:
                        throw new ArgumentException($"Error input value:  {compareBase}");
                }
           
            throw new InvalidOperationException("Items must be of type CsvClass."); 
        }
    }
}


