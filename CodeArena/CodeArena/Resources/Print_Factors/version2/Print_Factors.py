def compute_factors(x):
   result = []
   for i in range(1, x + 1):
       if i % x == 0:
           result.append(i)
   return result
