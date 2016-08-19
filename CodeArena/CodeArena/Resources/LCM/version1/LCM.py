def lcm(x, y):
   """This function takes two integers and returns the L.C.M."""

   # choose the greater number
   if x > y:
      greater = x
   else:
      greater = y
   lcm = greater
   while(True):
      if((lcm % x == 0) and (lcm % y == 0)):
         return lcm
      lcm += lcm
