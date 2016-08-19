def binary(n,bin_list):
   if n > 0:
      bin_list.append(n%2)
      return binary(n//2,bin_list)
   else:
      bin_num = 0
      ...
      
      return bin_num



