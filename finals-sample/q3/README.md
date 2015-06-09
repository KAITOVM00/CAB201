# Question 3
(Total 10 marks)

A program has a one-dimensional array of integers called rainfall which is used to record the rainfall each day. For example, if `rainfall[0]` is 15 and `rainfall[1]` is 0, there was 15mm of rain on the first day and no rain on the second day.

The number of days represented in the array is open-ended: it might be just a few days, or even none; it might be a month; it might be several years. The number of days is determined solely by the location in the array of the 9999 entry.

Negative rainfall values are data entry errors, and should be ignored.

A rainfall value of 9999 is used to indicate that no more rainfall figures have been registered beyond that element of the array; the last actual rainfall value recorded is in the element immediately before the 9999.

The array pictured here shows that rainfall was recorded for five days, with falls of 15mm, 0, 0, 5mm, and 2mm.

| i             | 0  | 1 | 2   | 3 | 4 | 5    |
|:-------------:|:--:|:-:|:---:|:-:|:-:|:----:|
| `rainfall[i]` | 15 | 0 | -53 | 5 | 2 | 9999 |

Write a method to find and return the average rainfall over all the days represented in the array. A day with negative rainfall is still counted as a day, but with a rainfall of zero.

````c
static double AverageRainfall(int[] rainfall)
````
