using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
    [Subject(typeof (EnumerableExtensions))]
    public class EnumerableExtensionsSpecs
    {
        public abstract class concern : Observes
        {

        }

        public class when_iterating_on_a_collection_of_items : concern
        {
            Establish context = () =>
            {
                list = Enumerable.Range(1, 100).Select(x=>new TheClass()).ToList();

            };

            Because of = () => list.for_each(x => x.was_called = true);
            
            It should_return_an_enumerable_type = () => list.ShouldEachConformTo(x => x.was_called);

            static IEnumerable<TheClass> list;
                   
        }

        public class TheClass
        {
            public bool was_called { get; set; }
        }
    }
}
