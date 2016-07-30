#Programming Assignment: Maximum Pairwise Product

##Introduction and Learning Outcomes

In this assignment and the next videos and readings, you will ...

> Implement a program for a given computational problem.
> Find out that it is slow: on large datasets, it takes too long to run.
> Implement a more efficient program that is able to process even large datasets in less than a second.
> Use stress testing to locate and fix a bug in the program.

##Problem Description

**Problem**

Given a sequence of non-negative integers a0,…,an−1, find the maximum pairwise product, that is, the largest integer that can be obtained by multiplying two different elements from the sequence (or, more formally, max0≤i≠j≤n−1aiaj). Different elements here mean ai and aj with i≠j (it can be the case that ai=aj).

**Input format**

The first line of the input contains an integer n. The next line contains n non-negative integers a0,…,an−1 (separated by spaces).
Constraints

2≤n≤2⋅10 to power 5; 0≤a0,…,an−1≤10 to power 5.

**Output format**

Output a single number — the maximum pairwise product.

**Sample 1**

Input:

    3
    1 2 3

Output:

    6

Explanation:

6=2×3

**Sample 2**

Input:

    10
    7 5 14 2 8 8 10 1 2 3

Output:

    140

Explanation:

140=14×10

**Sample 3**

Input:

    5
    4 6 2 6 1

Output:

    36

**Note:** Based on the problem the numbers may be bigger than a integer. 

**Note:** Make sure the algorithm completes under 1 sec. Modern machines can perform roughly 10 to power 9, basic operations per second (this depends on a machine of course, but 10 to power 9 is a reasonable average estimate). 