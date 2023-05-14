#Игра крестики нолики
def draw_board(board):
    print("   |   |")
    print(" " + board[7] + " | " + board[8] + " | " + board[9])
    print("   |   |")
    print("-----------")
    print("   |   |")
    print(" " + board[4] + " | " + board[5] + " | " + board[6])
    print("   |   |")
    print("-----------")
    print("   |   |")
    print(" " + board[1] + " | " + board[2] + " | " + board[3])
    print("   |   |")

def check_win(board, player):
    return ((board[7] == player and board[8] == player and board[9] == player) or
            (board[4] == player and board[5] == player and board[6] == player) or
            (board[1] == player and board[2] == player and board[3] == player) or
            (board[7] == player and board[4] == player and board[1] == player) or
            (board[8] == player and board[5] == player and board[2] == player) or
            (board[9] == player and board[6] == player and board[3] == player) or
            (board[7] == player and board[5] == player and board[3] == player) or
            (board[9] == player and board[5] == player and board[1] == player))

def play_game():
    board = [" "]*10
    player = "X"
    game_over = False
    
    while not game_over:
        draw_board(board)
        move = int(input("Выберите клетку от 1 до 9: "))
        if board[move] == " ":
            board[move] = player
            if check_win(board, player):
                draw_board(board)
                print("Игрок " + player + " выиграл!")
                game_over = True
            elif " " not in board:
                draw_board(board)
                print("Ничья!")
                game_over = True
            else:
                player = "O" if player == "X" else "X"
        else:
            print("Эта клетка уже занята. Выберите другую клетку.")

play_game()

