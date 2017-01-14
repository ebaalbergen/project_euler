def sumOfDivisors(number: int) -> int:
    sum = 0;
    for x in range(1, number // 2 + 1):
        if number % x == 0:
            sum += x

    return sum

for number in range(1, 10000):
    res = sumOfDivisors(number)
    if(res != number and sumOfDivisors(res) == number):
        sum += number

print(sum)

