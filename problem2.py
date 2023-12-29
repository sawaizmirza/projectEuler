# https://projecteuler.net/problem=2 

# Define a function to sum even Fibonacci values up to a given limit
def sum_fibonacci_even_values(limit):
    # Initialize the first two Fibonacci numbers
    a, b = 0, 1
    # Initialize the total sum
    total = 0
    # Continue while the current Fibonacci number is less than the limit
    while a < limit:
        # If the current Fibonacci number is even
        if a % 2 == 0:
            # Add it to the total
            total += a
        # Generate the next Fibonacci number
        a, b = b, a + b
    # Return the total sum
    return total    

# Calculate the sum of even Fibonacci numbers up to 4,000,000
result = sum_fibonacci_even_values(4000000)
# Print the result
print(result)  