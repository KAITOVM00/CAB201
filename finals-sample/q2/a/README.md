# Question 2a

### Description

Write a method using the method header below. This method will reverse the elements in an array between a lower index position and an upper index position.

So given the following array declaration:

<pre>
double [] data = { 8.5, 12.0, 23.2, 18.0, 15.5, 5.0, 10.5};
</pre>

following a call to the method `Reverse(data, 2, 5);` the contents of data would be

<pre>
{ 8.5, 12.0, 5.0, 15.5, 18.0, 23.2, 10.5 }
</pre>

You have already written a method called swap that swaps two elements in an array; the elements identified by the two index values passed as parameters. `Swap(array, oneIndex, otherIndex)`

<pre>
public void Reverse( double [] values, int start, int finish)
</pre>
