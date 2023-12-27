# https://projecteuler.net/problem=3

# Define a function to find the largest prime factor of a given number
def largest_prime_factor(n):
    # Start with the smallest prime number
    i = 2
    # Continue while i squared is less than or equal to n
    while i * i <= n:
        # If n is not divisible by i, increment i
        if n % i:
            i += 1
        # If n is divisible by i, divide n by i
        else:
            n //= i
    # Return the final value of n, which is the largest prime factor
    return n

# Calculate the largest prime factor of 600851475143
result = largest_prime_factor(600851475143)
# Print the result
print(result)