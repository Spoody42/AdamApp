using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApp
{
///<summary>
///Dice Class Template
///
/// </summary>

internal class Dice
{
   // 1. Attributes
    protected string _Colour;
    protected int _Num;

    // 2. Properties
    public string Colour
    {
        get         // 2a
        {
            return _Colour;
        }
        set         //2b
        {
            if ((value.Length > 0) && (value.Length <= 6))     //2b-1
            {
                _Colour = value;
            }
            else
            {
                throw new Exception("Bad colour : " + value);   //2b-2
            }
        }
        } // end Colour P
        public virtual int Num              // 2c
        {
            get { return _Num; }    //Read only property
        } // end Num Property

          // 3. Methods
        protected static Random random = new Random(); //
        public virtual void GenerateNumber()   // 4a
        {
            _Num =random.Next(1, 6);          // 4a-2   
        } // end of GenerateNumber
    // 4. Overide methods
    public override string ToString()   // 4b
    {
    return _Colour + " " + _Num;
    }  //end of ToString method

 // 5. Object Constructor Methods

    public Dice()   // 5a
    {
        _Colour = "Black";
    } // end of d Dice Constructor

    public Dice(string inColour, int inNum)     //5b
    {
        _Colour = inColour;
        _Num = inNum;
        //end of Dice C
    }

    public Dice(string inColour) // 8
    {
        Colour = inColour;
        GenerateNumber();
        //end of Dice c
    }
   
    } //end of Dice c
}

