using System;
using System.Collections.Generic;
using System.Text;

/**
 *CardRank.cs - The CardRank Enumeration
 * 
 * This enumeration is
 * 
 * @author  Jeremy Power
 * @version 1.0
 * @since   3/23/2018
 */
namespace JeremyCards
{
    /// <summary>
    /// CardRank Enumeration
    /// Used to represent the 13 ranks of a standard playing card deck
    /// </summary>
    public enum CardRank : byte
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
        Joker
    }
}
