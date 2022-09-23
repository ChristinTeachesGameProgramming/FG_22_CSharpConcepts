namespace Compostion
{
    public class Enemy 
    {
        public GameObject GameObject {private set; get;}
        public Life Life {private set; get;}

        public Enemy()
        {
            GameObject = new GameObject();
            Life = new Life();
        }

        public void Shoot() 
        {
            
        }


    }
}