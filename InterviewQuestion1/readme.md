# Google Interview Question 1 - Array (Easy)

Given an array of integers, return the indices of the two numbers that add up to a given target.

## Step 1 - VErify constraint

- Are all the number positive or can there be negatives? all number positives
- Are there duplicate number in the array? no
- Will there always be a solution avaible? no
- what do we return if there's no solution> just return null? null
- Can there be multiple pairs that add up to the target? no only 1 pair of numbers will add up to the target.

## step 2 - Test Case

```

arr1 = [1, 3, 7, 9, 2] target= 11 answeer = [3,4]
arr2 = [1, 3, 7, 9, 2] target= 25 answeer = null
arr3 = [] target= 1 answeer= null
arr4 = [5] target=5 answeer= null
arr5 = [1,6] target= 7 answeer= [0,1]

```

## Step 3 - speudo code
