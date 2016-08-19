'''
Please write a binary search function which searches an item in a sorted list. The function should return the index of element to be searched in the list.
'''

import math
def bin_search(li, element):
    bottom = 0
    top = len(li)-1
    index = -1
    while ...
        mid = int(math.floor((top+bottom)/2.0))
        if li[mid]==element:
            index = mid
        elif li[mid]>element:
            top = mid-1
        else:
            bottom = mid+1

    return index
