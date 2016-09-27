def remove_punctuations(my_str):

    punctuations = '''!()-[]{};:'"\,<>./?@#$%^&*_~'''

    no_punct = ""
    for char in my_str:
       if char in punctuations:
           no_punct = no_punct + char

    return no_punct
