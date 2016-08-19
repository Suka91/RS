import math
def bin_search(li, element):
    bottom = 0
    top = len(li)-1
    index = -1
    while top>=bottom and index==-1:
        mid = ...
        if ...
            index = mid
        elif ...
            top = mid-1
        else:
            bottom = mid+1

    return index
