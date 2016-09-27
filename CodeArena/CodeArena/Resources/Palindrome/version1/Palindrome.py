def palindrome(my_str):

    my_str = my_str.casefold().strip()

    rev_str = ...

    if list(my_str) == list(rev_str):
        return 0
    else:
        return 1
