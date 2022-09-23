namespace Compostion
{
    public class Player 
    {
        public string Name {private set; get;}
        public GameObject GameObject {private set; get;}
        public Life Life {private set; get;}

        public Player(string name)
        {
            GameObject = new GameObject();
            Life = new Life();
            Name = name;
        }

        public void Shoot() 
        {

        }
    }
}