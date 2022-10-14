using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest22
{

    
    public enum PlayerType {Warrior, Wizard, Hunter}
    public class Player
    {
		private int _no;

		public int No
		{
			get { return _no; }
			set { _no = value; }
		}


		public PlayerType PType { get; set; }

		public string Name { get; set; }

		private int _hitpoints;

		public int Hitpoint
		{
			get { return _hitpoints; }
			set { _hitpoints = value; }
		}

		public Player(int no, string name, PlayerType pType)
		{
			_no = no;
			Name= name;
			PType = pType;
			if(pType ==  PlayerType.Warrior)
			{
				_hitpoints = 100;
			}
			else if (pType == PlayerType.Wizard)
			{
				_hitpoints = 60; 
			} else
			{
				_hitpoints = 80;
			}
		}

		public override string ToString()
		{
			return $"{_no} {Name} {_hitpoints}  {PType}";
		}

	}
}
