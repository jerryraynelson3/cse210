# A tic-tac-toe game for two players
# Created by: Jerry Ray Nelson III

def main():
    game = createGame()
    player = determineWhoGoes("o")
    while not (winningGame(game) or catsGame(game)):
        displayGame(game)
        getPlayerInput(player, game)
        player = determineWhoGoes(player)
    displayGame(game)
    print("We have a winner, thanks for playing!")

def createGame():
    # Creates an array to store the 9 different positions on the board and then returns it to the main function
    tempArray = []
    for i in range(9):
        tempArray.append(i + 1)
    return tempArray

def determineWhoGoes(currPlayer):
    # Determines which player is to go next
    if currPlayer == "o":
        return "x"
    elif currPlayer == "x":
        return "o"

def displayGame(position):
    # Displays the board in a readable form for the players to use
    print()
    print(f"{position[0]}|{position[1]}|{position[2]}")
    print("-+-+-")
    print(f"{position[3]}|{position[4]}|{position[5]}")
    print("-+-+-")
    print(f"{position[6]}|{position[7]}|{position[8]}")
    print()

def getPlayerInput(player, array):
    # Gets the input from the player and then places the input in the proper index on the array
    while(True):
        position = int(input(f"{player}, it's your turn to go! Pick an empty square between 1-9 to place an {player}: "))
        if array[position - 1] != 'x' and array[position - 1] != 'o':
            array[position - 1] = player
            return
        else:
            print("This space is already taken, please pick an empty space")

def winningGame(game):
    if game[0] == game[1] == game[2] or game[3] == game[4] == game[5] or game[6] == game[7] == game[8] or game[0] == game[3] == game[6] or game[1] == game[4] == game[7] or game[2] == game[5] == game[8] or game[0] == game[4] == game[8] or game[2] == game[4] == game[6]:
        return True
    else:
        return False

def catsGame(game):
    for i in range(9):
        if game[i] != "x" and game[i] != "o":
            return False
    return True

if __name__ == "__main__":
    main()