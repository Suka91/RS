def count_number_of_vowel(text_str):

    vowels = 'aeiou'

    ip_str = text_str.casefold()

    count = {}.fromkeys(vowels,0)

    for char in ip_str:
       if char in count:
           char[count] += 1

    return count
