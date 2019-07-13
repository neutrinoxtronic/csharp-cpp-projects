# Project - Creature Constructor

A command line c# application that prints ascii creatures by constructing their bodies on piece at the time. The body parts of the creatures can be pieced together randomly or be user-defined. If user does not define a body part, a random body part will be assigned to the creature before printing it.

The project can be extended through addition of more creatures body parts from [ASCII Art Archive](https://www.asciiart.eu/animals).

## Usage

1. `dotnet run`
2. Enter `y` to randomly generate a creature.
3. Enter `n` to go to run the body selector functions.
4. Enter `monster`, `ghost` or `bug` for each part of the body:
   - head
   - body
   - feet

> *Note*: If you don't select any of the above options for head, body or feet, the programme will randomly select one for you.

## Sample Output:
           
```shell
$ dotnet run                                       
Welcome to the ASCII Art Creature                  
Construct a random creature? [y/n]                 
y                                                  
     ..-..                                         
    ( o o )                                        
    |  O  |                                        
   ,-/`~`\-,___                                    
  / /).:.('--._)                                   
 {_[ (_,_)                                         
    |     |                                        
    |     |                                        
    '~~~~~'                                        
```

```shell
$ dotnet run                                       
Welcome to the ASCII Art Creature Constructor!     
Construct a random creature? [y/n]                 
n                                                  
Choose any of the following:                       
head: [monster/ghost/bug]                          
bug                                                
body: [monster/ghost/bug]                          
monster                                            
feet: [monster/ghost/bug]                          
monster                                            
bug                                                
     /   \                                         
     \. ./                                         
    (o + o)                                        
   ,-/`~`\-,___                                    
  / /).:.('--._)                                   
 {_[ (_,_)                                         
    |  Y  |                                        
   /   |   \                                       
   """" """"                                       
```

```shell
$ dotnet run                                       
Welcome to the ASCII Art Creature Constructor!     
Construct a random creature? [y/n]                 
n                                                  
Choose any of the following:                       
head: [monster/ghost/bug]                          
monster                                            
body: [monster/ghost/bug]                          
                                                   
feet: [monster/ghost/bug]                          
                                                   
monster                                            
     _____                                         
 .-,;='';_),-.                                     
  \_\(),()/_/                                      
　  (,___,)                                        
  --|  |  |--                                      
  --|  |  |--                                      
  --|  |  |--                                      
     v   v                                         
     *****  
```