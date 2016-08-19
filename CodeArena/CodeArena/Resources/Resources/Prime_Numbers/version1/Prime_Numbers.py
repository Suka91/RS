def prime_numbers(low_range, up_range):
    prime_numbers = []
    for num in range(low_range,up_range + 1):
        if num == 1:
            continue
        else:
            for i in range(2, num):
                ...
            else:
                prime_numbers.append(num)
    return prime_numbers
