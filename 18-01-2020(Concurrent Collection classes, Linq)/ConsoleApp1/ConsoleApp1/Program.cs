using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StackExample s = new StackExample();
             s.StackMethod();
             QueueExample q = new QueueExample();
             q.QueueMethod();*/

            /* LinkedListExample lie = new LinkedListExample();
             lie.linkedListMethod();

             LinkedExample li = new LinkedExample();
             li.AddBeforeAddAfter();*/

            /* BlockCollectionExample bce = new BlockCollectionExample();
             bce.blockCollectionMethod();*/

            /*  BlockingCollectionsRemovalExample bcre = new BlockingCollectionsRemovalExample();
              bcre.RemoveItems();*/

            /* BlockingTryTakeExample bt = new BlockingTryTakeExample();
             bt.tryTakeMethod();*/

            /*CompleteAddingMethodAndIsCompleteProperty cmp = new CompleteAddingMethodAndIsCompleteProperty();
            cmp.methodAndProperty();*/

            /* MultipleProducersAndConsumers mpc = new MultipleProducersAndConsumers();
             mpc.multipleBlockingMethods();*/

            /*  AddingAndRetrivingFromConcurrentDictionary ar = new AddingAndRetrivingFromConcurrentDictionary();
                  ar.AddingAndRetriving();*/

            /* TaskCreation tc = new TaskCreation();
             tc.taskCreation();*/

            ConcurrentStackExample cs = new ConcurrentStackExample();
            cs.stackMethod();
        }
    }
}
