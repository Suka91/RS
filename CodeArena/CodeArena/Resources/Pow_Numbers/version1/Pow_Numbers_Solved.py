def pow_numbers(list_of_numbers, degree):
    """Function takes list of numbers as first parameter
and return list of items that are pow(item,second_param)"""
    pow_list = list(map(lambda x:pow(x,degree),list_of_numbers))
    return pow_list