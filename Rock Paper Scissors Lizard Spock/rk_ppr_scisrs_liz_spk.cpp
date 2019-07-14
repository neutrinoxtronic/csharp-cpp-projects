/* GAME LOGIC

Scissors cut Paper
Paper covers Rock
Rock crushes Lizard
Lizard poisons Spock
Spock smashes Scissors
Scissors decapitate Lizard
Lizard eats Paper
Paper disproves Spock
Spock vaporizes Rock
Rock crushes Scissors

*/

#include <iostream>
#include <stdlib.h>

// function declaration

std::string TranslateChoice(int choice)
{
  switch(choice)
  {
    case 1:
      return "✊";
      break;
    case 2:
      return "✋";
      break;
    case 3:
      return "✌️";
      break;
    case 4:
      return "👌";
      break;
    case 5:
      return "🖖";
      break;
    default:
      break;  
  }
}

void AnnounceResults(int user, int computer, std::string result)
{
    std::cout <<"You chose: " << TranslateChoice(user) << "\n";
    std::cout <<"Computer chose: " << TranslateChoice(computer) << "\n";
    std::cout <<"And the result is as follows: " << result << "\n";
}

std::string PlayWithComputer(int user, int computer)
{
  if (user == computer)
  {
    return "It is a draw!";
  }
    
  switch (user)
  {
    case 1: // Rock
      if (computer == 3 || computer == 4) // Scissors & Lizard
      {
        return "You Win!";
      }
      else 
      {
        return "You Lose!";
      }
      break;
      
    case 2: // Paper
      if (computer == 1 || computer == 5) // Rock & Spock
      {
        return "You Win!";
      }
      else
      {
        return "You Lose!";
      }
      break;
      
    case 3: // Scissors
      if (computer == 2 || computer == 4) // Paper & Lizard
      {
        return "You Win!";
      }
      else 
      {
        return "You Lose!";
      }
      break;
      
    case 4: // Lizard
      if (computer == 2 || computer == 5) // Paper & Spock
      {
        return "You Win!";
      }
      else 
      {
        return "You Lose!";
      }
      break;
      
    case 5: // Spock
      if (computer == 1 || computer == 3) // Rock & Scissors
      {
        return "You Win!";
      }
      else
      {
        return "You Lose!";
      }
      break;
      
    default:
      std::cout << "INVALID INPUT. TRY AGAIN.\n";
      return "0";
      break;
  }
}

int main()
{
  srand (time(NULL));
  int user = 0, computer = rand() % 5 + 1;
  std::string result;
  
  std::cout << "=================================\n";
  std::cout << "rock paper scissors Lizard Spock!\n";
  std::cout << "=================================\n";

  std::cout << "1) ✊\n"; // Rock
  std::cout << "2) ✋\n"; // Paper
  std::cout << "3) ✌️\n"; // Scissors
  std::cout << "4) 👌\n"; // Lizard
  std::cout << "5) 🖖\n"; // Spock

  std::cout << "shoot! ";
  
  std::cin >> user;
  result = PlayWithComputer(user, computer);
  if (result == "0")
  {
    return 0;
  }
  AnnounceResults(user, computer, result);
}
