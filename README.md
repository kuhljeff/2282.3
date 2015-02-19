# 2282.3
Project 3
1.	Using C#, implement generic Stack and Queue classes derived from a generic abstract De-queue class that contains a reference to a List class.  You may want to have your classes contain references to other classes or be derived from other classes.
a.	The Stack class has the following methods: pop, push, peek, count.
b.	The Queue class has the following methods: pop, push, peek, count
c.	The De-queue class as the following method: popFront, popBack, pushFront, PushBack, peekFront, peekBack, count.

2.	Develop a function that evaluations a postfix expression. Postfix notation is a way of writing arithmetic expressions without using parentheses. For example, the expression (4+2) *3 would be written 4 2 + 3 *. A postfix expression is evaluated using a stack. Scan a postfix expression from left to right. A variable or constant is pushed onto the stack.  When a operator is encountered, apply the operator with the top two operands in the stack and replace the two operands with the result. The following diagram shows how to evalute1 2 + 3 *
	
Write a program that function that accepts a string containing a post fix expression and returns its integer value. Your solution should be able to handle +, -, *, and integer divide (/). Assume all numbers are single numeral positive numbers with values between 0 and 9. Assume all numbers and operators are separated by one or more spaces (Remember the .trim methods for strings.)

Extra Credit: Implement an infix to postfix conversion function in C++ based on the provided code given in Note 3.6. It only needs to work with the operators provided in that note and only with single digit numbers. 
