def sum_multiples_of_3_or_5(limit):
    return sum(num for num in range(limit) if num % 3 == 0 or num % 5 == 0)

# Find the sum of all multiples of 3 or 5 below 1000
result = sum_multiples_of_3_or_5(1000)
print(f"The sum of all multiples of 3 or 5 below 1000 is: {result}")