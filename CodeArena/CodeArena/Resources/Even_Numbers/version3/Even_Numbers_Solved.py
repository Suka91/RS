def even_numbers(list_of_numbers):
    even_list = list(filter(lambda x:(x%2==0),list_of_numbers))
    return even_list
