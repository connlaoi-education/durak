using System;
using System.Collections.Generic;
using System.Text;
/**
 * Statuses.cs - The Statuses Enumeration
 * 
 * This enumeration is
 * 
 * @author  Jeremy Power
 * @version 1.0
 * @since   3/23/2018
 */
namespace DurakGame
{
    /// <summary>
    /// Statuses Enumeration
    /// Used to represent the players states of durak
    /// </summary>
    public enum Statuses : byte
    {
        Attacking = 0,
        Defending,
        Throwing,
        Won
    }
}
