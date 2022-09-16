## YieldAppCSharp
> The yield keyword signals to the compiler that the method in which it appears is an iterator block. The compiler generates a class to implement the behavior that is expressed in the iterator block. In the iterator block, the yield keyword is used together with the return keyword to provide a value to the enumerator object. This is the value that is returned, for example, in each loop of a foreach statement. The yield keyword is also used with break to signal the end of iteration.

## Example of using yield

```c#
public class Generators
{
    public static IEnumerable<int> GetPrimeNumbers()
    {
        int counter = 1;

        while (true)
        {
            if (IsPrimeNumber(counter))
            {
                yield return counter;
            }
            
            counter++;
        }
    }

    private static bool IsPrimeNumber(int value)
    {
        bool output = true;

        for (int i = 2; i < value / 2; i++)
        {
            if (value % i == 0)
            {
                output = false;
                break;
            }
        }
        
        return output;
    }
}
```

## Requirements for the use of yield return

* Do not put `yield` in an unsafe block.
* Do not use `ref` or `out` keywords with the parameters of the method, operator or accessor (getter / setter).
* `Yield return` can only be placed in the try block if it is followed by a finally block.
* `Yield break` can be put in the try block and catch, but not placed in the finally block.
* Do not use `yield` within the anonymous method.

## Conclusion
One advantage of using "yield" is to help keep the code clean and concise. On top of that, because the yield is called within a method that uses IEnumerable there is no need to create or get a list of elements to browse. This applies in cases such as searching and browsing a number of elements required that will be reduce the dependency on the location of the element to find.
