namespace TicTacToe
{
    internal class Player
    {
        private char activePlayer;
        public Player()
        {
            activePlayer = 'O';
        }
        public string GetPlayer()
        {
            return activePlayer.ToString();
        }
        public void SwitchPlayer()
        {
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
        }
        public void Reset()
        {
            activePlayer = 'O';
        }
    }
}
