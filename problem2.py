# https://projecteuler.net/problem=2 

def sum_fibonacci_even_values(limit):
    a, b = 0, 1
    total = 0
    while a < limit:
        if a % 2 == 0:
            total += a
        a, b = b, a + b
    return total    

result = sum_fibonacci_even_values(4000000)
print(result) 