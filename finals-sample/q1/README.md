# Question 1
(Total 10 marks)

In an exam students were ask to write a method, **int FirstPairOfDuplicates (int[] anArray)** that returns the index of the first element of the first pair of duplicate numbers in **anArray**, where the two numbers in the pair are adjacent to each other.

For example, if the array contained the values { 1, 9, 1, 9, 9, 5, 7, 7, 4 }, then the method would return the value 3, which is the index of the first element of the &lt;9, 9&gt; pair which is the first pair of duplicate numbers in the array. The method returns -1, if there are no adjacent pairs of duplicate numbers.

Each of the following methods is a student’s answer to that question and each one contains one or more logic errors and/or runtime errors which would have been detected with a reasonable designed Test plan.  

There are no compiler errors in any of the answers. For each, identify what is the error (or errors). Each part is worth 2 marks.

**(a)**
<pre>
static int FirstPairOfDuplicates (int[] anArray) {
    for (int i = 0; i < anArray.Length;  i++) {
            for (int j = 0; j < anArray.Length; j++) {
                if (anArray[i] == anArray[j]) {
                    return i;
                }
            }
        }
    return -1;
}
</pre>

* The code returns `i` when it is equal to `j` even if the two values are not "adjacent"

**(b)**
<pre>
static int FirstPairOfDuplicates (int[] anArray) {
    int counter = 1;
    int currentNumber = anArray[0];
    int nextNumber;
    bool found = false;

    do {
        nextNumber = anArray[counter];
        if (nextNumber == currentNumber) {
            found = true;
        } else {
            counter++;
        }
    } while (!found)
        return counter;
}
</pre>

* `currentNumber` is setup to the first element of the array so, realistically, the method is ignoring and not comparing the other numbers in the array
* index of the number (called `counter` in this case) is returned even if the two numbers not adjacent
* max length of the array is 9. However, `counter` is incremented by 1 each iteration if a match is not found. Furthermore, the loop will indefinitely run and the return statement would become "unreachable code".
* when the value of `counter` becomes 9, the application will crash throwing an `index out of range` exception

**(c)**
<pre>
static int FirstPairOfDuplicates (int[] anArray) {
    int temp = -1;
    int count = 0;
    foreach( int item in anArray) {
        if (item == temp) {
            return count;
        } else {
            temp = item;
            count++;
        }
    }
    return count;
}
</pre>

* `count` is still returned even if a pair is not found instead of `-1`

**(d)**
<pre>
static int FirstPairOfDuplicates (int[] anArray) {
    int temp =0;
    int index = 0;
    for (int i = 0; i < anArray.Length;  i++) {
        temp = anArray[i];
        if (temp == anArray[i+1]) {
            index = i;
            return i;
        }
    }
    return -1;
}
</pre>

* `index` is unused in any useful manner

**(e)**
<pre>
static int FirstPairOfDuplicates (int[] anArray) {
    for (int i = 0; i < anArray.Length;  i++) {
        if (anArray[i] == anArray[i+1]) {
            return i;
        }
    }
    return -1;
}
</pre>
