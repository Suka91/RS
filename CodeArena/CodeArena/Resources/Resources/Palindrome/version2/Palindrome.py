def palindrome(my_str):
    # make it suitable for caseless comparison
    ...
    # reverse the string
    ...
    # check if the string is equal to its reverse
    if list(my_str) == list(rev_str):
        return 0
    else:
        return 1
