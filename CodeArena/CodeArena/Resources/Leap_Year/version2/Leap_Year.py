def leap_year(year):
    if(year % 4)==0:
        if(year % 100)== 0:
            if(year % 400) == 0:
                print("{0} is a  leap year".format(year))
                return 1
            else:
                ...
        else:
            ...
    else:
        ...
