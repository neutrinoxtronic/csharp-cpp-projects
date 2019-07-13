#include <iostream>
#include <cmath>

int main() {
  double a, b, c, root1, root2;
  
  std::cout << "Enter a:" << "\n";
  std::cin >> a;
  std::cout << "Enter b:" << "\n";
  std::cin >> b;
  std::cout << "Enter c:" << "\n";
  std::cin >> c;
  
  root1 = (-b + std::sqrt(b*b - 4*a*c) ) / (2*a);
  root2 = (-b - std::sqrt(b*b - 4*a*c) ) / (2*a);
  
  std::cout << "Root 1 is " << root1 << "\n";
  std::cout << "Root 2 is " <<  root2 << "\n";
  
 }

 /*
 SAMPLE OUTPUT 1:

Enter a: 6
Enter b: -7
Enter c: -3
Root 1 is 1.5
Root 2 is -0.333333


SAMPLE OUTPUT 1:
Enter a: 3
Enter b: -11
Enter c: -4
Root 1 is 4
Root 2 is -0.333333
*/

