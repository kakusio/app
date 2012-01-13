using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    public class StringExtensionsSpecs 
    {
        public class concern:Observes
        {
        }

        public class when_formatting_an_string : concern
        {
            Establish context = () =>
            {
                input_string = "{0}{1}";
            };

            Because of = () => result = input_string.format_using(1,2);

            It should_return_the_formatted_string_correctly = () => result.ShouldEqual("12");

            static string result;
            static string result_string;
            static string input_string;
        }
    }
}