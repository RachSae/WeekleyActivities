using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RachelleBray
{

    public class WeekEight : MonoBehaviour
    {
        public Fruit[] myFruitBasket = new Fruit[10];

        public enum Fruit
        {
            Apple,
            Banana,
            Orange,
            Strawberry,
            Mango,
            Kiwi,
            Watermelon,
            Peach
        }

        public Fruit favouriteFruitOfAaron = Fruit.Mango;
        public Fruit favouriteFruitOfMitch = Fruit.Banana;
        public Fruit favouriteFruitOfRachelle = Fruit.Watermelon;
        public Fruit favouriteFruitOfOwen = Fruit.Kiwi;
        public Fruit favouriteFruitOfCallum = Fruit.Mango;
        public Fruit favouriteFruitOfChester = Fruit.Watermelon;

        // Start is called before the first frame update
        void Start()
        {

            CheckBasketWithSwitch();

        }

        // Update is called once per frame
        void Update()
        {

           


        }

        private void CheckBasketWithIfElse()
        {
            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                if (myFruitBasket[i] == favouriteFruitOfAaron)
                {
                    Debug.Log("This is Aaron's favourtie fruit!");
                }
                else if (myFruitBasket[i] == favouriteFruitOfCallum)
                {
                    Debug.Log("This is Callums favourite Fruit!");
                }

            }
        }

        private void CheckBasketWithSwitch()
        {
            for (int i = 0; i < myFruitBasket.Length; i++)
            {
               switch (myFruitBasket[i])
                {
                  
                    case Fruit.Mango:
                        Debug.Log("This is Aaron and Callum's favourite fruit!");
                        break;
                    case Fruit.Banana:
                        Debug.Log("This is Mitch's favourite fruit!");
                        break;
                    case Fruit.Watermelon:
                        Debug.Log("This is Rach and Chester's favourite fruit!");
                        break;
                    case Fruit.Kiwi:
                        Debug.Log("This is Owen's favourite fruit!");
                        break;
                    default:
                        Debug.Log("Some other fruit.");
                        break;

                }

            }
        }
    }

}