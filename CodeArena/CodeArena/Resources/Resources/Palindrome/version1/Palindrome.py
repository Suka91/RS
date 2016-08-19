def palindrome(my_str):
    # make it suitable for caseless comparison
    my_str = my_str.casefold().strip()
    # reverse the string
    rev_str = ...
    # check if the string is equal to its reverse
    if list(my_str) == list(rev_str):
        return 0
    else:
        return 1
