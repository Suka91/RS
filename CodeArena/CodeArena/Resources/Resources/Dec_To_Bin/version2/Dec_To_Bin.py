def binary(n,bin_list):
   if n > 0:
      bin_list.append(...)
      return binary(...)
   else:
      bin_num = 0
      bin_list.reverse()
      for digit in bin_list:
         bin_num = bin_num * 10 + digit 
      return bin_num



