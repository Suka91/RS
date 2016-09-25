...

def math_formula(num_list, h, c):
    value = []
    for d in num_list:
        value.append(int(round(math.sqrt(2*c*float(d)/h))))
    return value
